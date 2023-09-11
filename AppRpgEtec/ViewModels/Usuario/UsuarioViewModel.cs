using AppRpgEtec.Services.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AppRpgEtec.Models;

namespace AppRpgEtec.ViewModels.Usuario
{
    public class UsuarioViewModel : BaseViewModel
    {
        private UsuarioService uService;
        public ICommand RegistrarCommand { get; set; }


        private string login = string.Empty;
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged();
            }
        }

        private string senha = string.Empty;
        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                OnPropertyChanged();
            }
        }

        public async Task RegistrarUsuario()
        {
            try
            {
                Usuario u = new Usuario();
                u.Username = Login;
                u.PasswordString  = senha;

                Usuario uRegistrado.Id != 0
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + "Detalhes: " + ex.InnerException, "Ok");
            }
        }

    }
}

