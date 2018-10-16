using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Mapping;
using MvvmCross.Core.ViewModels;
using PCLStorage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;

namespace XamNativeShowcase.Core.ViewModels
{
    public class MapViewModel : MvxViewModel
    {
        private Map _map;
        public Map Map { get { return _map; } set { _map = value; RaisePropertyChanged(nameof(Map)); } }

        private string _streetMapFilename = "streetmap.map.vtpk";
        private string _hydrantsFilename = "hydrants.geodatabase";
        private string _waterMainsFilename = "watermains.geodatabase";
        bool _useLocalAppFolder = false;
        string _externalFolderPath = @"C:\map\";
        IFolder _mapFolder;

        public override void Start()
        { 
            base.Start();
        }

        public override async Task Initialize()
        {
            Map = new Map();

            await HandleLocalMapFolder();

            // Add base layer
            Map.Basemap.BaseLayers.Add(new ArcGISVectorTiledLayer(new Uri(System.IO.Path.Combine(_useLocalAppFolder ? _mapFolder.Path : _externalFolderPath, _streetMapFilename))));

            // Add Pipes & Hydrants
            Map.OperationalLayers.Add(await GetOfflineFeatureLayer(_hydrantsFilename));
            Map.OperationalLayers.Add(await GetOfflineFeatureLayer(_waterMainsFilename));
        }

        private async Task HandleLocalMapFolder()
        {
            if (await FileSystem.Current.LocalStorage.CheckExistsAsync("map") == ExistenceCheckResult.NotFound)
                await FileSystem.Current.LocalStorage.CreateFolderAsync("map", CreationCollisionOption.FailIfExists);

            _mapFolder = await FileSystem.Current.LocalStorage.GetFolderAsync("map");
        }

        private async Task<FeatureLayer> GetOfflineFeatureLayer(string filename)
        {
            try
            {
                var path = System.IO.Path.Combine(_useLocalAppFolder ? _mapFolder.Path : _externalFolderPath, filename);
                var db = await Geodatabase.OpenAsync(path);
                var ft = db.GeodatabaseFeatureTables.First();
                var layer = new FeatureLayer(ft)
                {
                    Id = Guid.NewGuid().ToString(),
                    MinScale = 5000,
                    MaxScale = 1000
                };

                return layer;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return new FeatureLayer();
            }
        }
    }
}
