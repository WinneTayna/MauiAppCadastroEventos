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

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Confirmacao());
        }
    }
