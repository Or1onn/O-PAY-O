using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using O_PAY_O.ViewModel.Login;
using O_PAY_O.View.Login;
using System.Threading.Tasks;
using O_PAY_O.Model;
using System.IO;

namespace O_PAY_O.ViewModel.Login
{
    internal class RegisterViewModel : ViewModelBase
    {

        public readonly string path = @"C:\User";

        private string? login;

        public string Login
        {
            get { return login!; }
            set
            {
                if (value != login) { Set(ref login, value); }
            }
        }

        private string? password;

        public string Password
        {
            get { return password!; }
            set
            {
                if (value != password) { Set(ref password, value); }
            }
        }

        public RelayCommand NewUserRegister
        {
            get => new RelayCommand(async () =>
            {
                //AccountModel acc = new();
                //acc.Login = this.Login;
                //acc.Password = this.Password;

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                Directory.CreateDirectory($"{path}\\abc");

                //using (FileStream fs = new(path + "\\" + Login + "\\" + $"{Login}.json", FileMode.OpenOrCreate))
                //{
                //    //string? json = JsonSerializer.Serialize(acc);
                //    await JsonSerializer.SerializeAsync<AccountModel>(fs, acc);
                //}
            });
        }
    }
}
