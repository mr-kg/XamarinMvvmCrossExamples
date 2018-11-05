using Microsoft.AspNetCore.SignalR.Client;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;

namespace XamNativeShowcase.Core.ViewModels
{
    public class SignalRViewModel : MvxViewModel
    {
        HubConnection connection;
        public async override Task Initialize()
        {
            connection = new HubConnectionBuilder()
            .WithUrl("http://localhost:63522/ChatHub")
            .Build();

            State = "Connecting...";

            await ConnectAsync();
            await base.Initialize();
        }

        private async Task ConnectAsync()
        {
            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                Message += $"User: {user}\tMessage: {message}\r\n";
            });

            try
            {
                await connection.StartAsync();
                State = "Connection started";
            }
            catch (Exception ex)
            {
                State = ex.Message;
            }
        }

        string _state;
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                RaisePropertyChanged(() => State);
            }
        }

        string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                RaisePropertyChanged(() => Message);
            }
        }
    }
}
