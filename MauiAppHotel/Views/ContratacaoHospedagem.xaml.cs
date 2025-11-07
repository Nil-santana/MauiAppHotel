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

    private void BtnAvançar_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new HospedagemContratada());


		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "ok!");
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