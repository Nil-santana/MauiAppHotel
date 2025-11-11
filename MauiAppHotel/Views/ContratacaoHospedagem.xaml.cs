using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{

	App PropriedadesApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

		dtcpk_checkin.MinimumDate = DateTime.Now;
		dtcpk_checkin.MaximumDate = new DateTime(DateTime.Now.Year,
			                            DateTime.Now.Month +1,
			                            DateTime.Now.Day);
		dtcpk_checkout.MinimumDate = dtcpk_checkin.Date.AddDays(1);
		dtcpk_checkout.MaximumDate = dtcpk_checkin.Date.AddMonths(6);
    }

    private void BtnSobre_Clicked(object sender, EventArgs e)
    {

		DisplayAlert("Desenvolvido por:", "Lenildo Santana ,2025.", "Fechar");
    }

    private async void BtnAvançar_Clicked(object sender, EventArgs e)
    {
		try
		{
			Hospedagem h = new Hospedagem
			{
				QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
				QntAdultos = Convert.ToInt32(stp_adultos.Value),
				QntCrianças = Convert.ToInt32(stp_criancas.Value),
				DataCheckin = dtcpk_checkin.Date,
				DataCheckout = dtcpk_checkout.Date
			};


			await Navigation.PushAsync(new HospedagemContratada()
			{
				BindingContext = h
			});


		}
		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "ok!");
		}
    }

    private void dtcpk_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = elemento.Date;

		dtcpk_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
		dtcpk_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}