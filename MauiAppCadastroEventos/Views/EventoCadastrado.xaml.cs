using MauiAppCadastroEventos.Models;
using Microsoft.Maui.Controls;

namespace MauiAppCadastroEventos.Views;

public partial class EventoCadastrado : ContentPage
{
    public EventoCadastrado(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }
}
