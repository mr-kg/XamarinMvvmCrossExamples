﻿using Esri.ArcGISRuntime.Mapping;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamNativeShowcase.Shared.ViewModels
{
    public class MapViewModel : MvxViewModel
    {
        private Map _map;
        public Map Map { get { return _map; } set { _map = value; RaisePropertyChanged(nameof(Map)); } }

        public override void Start()
        {
            Map = new Map(Basemap.CreateImagery());
            base.Start();
        }
    }
}
