using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using O_PAY_O.Messages;
using O_PAY_O.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_PAY_O.Services.Classes
{
    public class NavigationService : INavigationService
    {
        private readonly IMessenger _messenger;

        public NavigationService(IMessenger messenger)
        {
            _messenger = messenger;
        }


        public void NavigateTo<T>() where T : ViewModelBase
        {
            _messenger.Send(new NavigationMessage() { ViewModelType = typeof(T) });
        }
    }
}
