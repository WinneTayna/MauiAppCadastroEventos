using MauiAppCadastroEventos.Models;
using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiAppCadastroEventos.Views
{
    public partial class CadastroEvento : ContentPage
    {
        public CadastroEvento()
        {
            InitializeComponent();

            DataInicioPicker.Date = DateTime.Now;
            DataTerminoPicker.Date = DateTime.Now.AddDays(1);
        }

        private void OnDataInicioChanged(object sender, DateChangedEventArgs e)
        {
            if (DataTerminoPicker.Date < e.NewDate)
            {
                DataTerminoPicker.Date = e.NewDate;
            }
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            try
            {

                var evento = new Evento
                {
                    Nome = NomeEntry.Text,
                    DataInicio = DataInicioPicker.Date,
                    DataTermino = DataTerminoPicker.Date,
                    NumeroParticipantes = int.Parse(NumeroParticipantesEntry.Text),
                    Local = LocalEntry.Text,
                    CustoPorParticipante = decimal.Parse(CustoPorParticipanteEntry.Text)
                };


                if (string.IsNullOrWhiteSpace(evento.Nome) || string.IsNullOrWhiteSpace(evento.Local))
                {
                    await DisplayAlert("Erro", "Preencha todos os campos!", "OK");
                    return;
                }

                if (evento.DataTermino < evento.DataInicio)
                {
                    await DisplayAlert("Erro", "A data de término não pode ser antes da data de início.", "OK");
                    return;
                }


                await Navigation.PushAsync(new EventoCadastrado(evento));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", "Verifique os dados informados! " + ex.Message, "OK");
            }
        }
    }
}