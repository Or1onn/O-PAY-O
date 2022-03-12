using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using O_PAY_O.View.Login;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using O_PAY_O.Model;
using System.Net.NetworkInformation;
using System.Windows;
using System.Threading;
using System.Net;
using System.IO;
using System.Text.Json;

namespace O_PAY_O.ViewModel.Login
{
    internal class LoginViewModel : ViewModelBase
    {
        private ViewModelBase? currentViewModel;
        public readonly string path = @"C:\User";

        public RelayCommand OpenRegister
        {
            get => new RelayCommand(async () =>
            {
                AccountModel acc = new();
                acc.Login = "ABOBA";
                acc.Password = "123";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                Directory.CreateDirectory($"{path}\\abc");

                using (FileStream fs = new(path + "\\" + acc.Login + "\\" + $"{acc.Login}.json", FileMode.OpenOrCreate))
                {
                    //string? json = JsonSerializer.Serialize(acc);
                    await JsonSerializer.SerializeAsync<AccountModel>(fs, acc);
                }
                //Register register = new();
                //register.ShowDialog();
            });
        }

    }
}
