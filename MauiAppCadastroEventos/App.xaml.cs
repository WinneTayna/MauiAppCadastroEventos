using MauiAppCadastroEventos.Views;
using Microsoft.Maui.Controls;

namespace MauiAppCadastroEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Definindo a página inicial
            MainPage = new NavigationPage(new CadastroEvento());
        }
    }
}
