namespace appUsandoEntry.Views;

public partial class Apostila07Page : ContentPage
{
	public Apostila07Page()
	{
		InitializeComponent();
	}

	private async void btnSalvarClicked(object sender, EventArgs e)
	{
		// Buscar os campos pelo nome
		var txtNomeCarro = this.FindByName<Entry>("txtNomeCarro");
		var txtPlacaCarro = this.FindByName<Entry>("txtPlacaCarro");
		var txtAnoCarro = this.FindByName<Entry>("txtAnoCarro");

		// Validação do campo Nome do Carro
		if (txtNomeCarro == null || string.IsNullOrWhiteSpace(txtNomeCarro.Text))
		{
			await DisplayAlert("Erro", "Verifique se a caixa de texto Nome do Carro está vazia!!!", "OK");
			txtNomeCarro?.Focus();
			return;
		}

		// Validação do campo Placa do Carro
		if (txtPlacaCarro == null || string.IsNullOrWhiteSpace(txtPlacaCarro.Text))
		{
			await DisplayAlert("Erro", "Verifique se a caixa de texto Placa do Carro está vazia!!!", "OK");
			txtPlacaCarro?.Focus();
			return;
		}

		// Validação do campo Ano do Carro
		if (txtAnoCarro == null || string.IsNullOrWhiteSpace(txtAnoCarro.Text))
		{
			await DisplayAlert("Erro", "Verifique se a caixa de texto Ano do Carro está vazia!!!", "OK");
			txtAnoCarro?.Focus();
			return;
		}

		// Exibir os dados validados
		await DisplayAlert("Dados do Carro",
			"Nome do Carro: " + txtNomeCarro.Text + "\n" +
			"Placa do Carro: " + txtPlacaCarro.Text + "\n" +
			"Ano do Carro: " + txtAnoCarro.Text,
			"OK");
	}

	private void btnLimparClicked(object sender, EventArgs e)
	{
		// Buscar os campos pelo nome
		var txtNomeCarro = this.FindByName<Entry>("txtNomeCarro");
		var txtPlacaCarro = this.FindByName<Entry>("txtPlacaCarro");
		var txtAnoCarro = this.FindByName<Entry>("txtAnoCarro");

		// Limpar todos os campos
		if (txtNomeCarro != null) txtNomeCarro.Text = string.Empty;
		if (txtPlacaCarro != null) txtPlacaCarro.Text = string.Empty;
		if (txtAnoCarro != null) txtAnoCarro.Text = string.Empty;
		txtNomeCarro?.Focus();
	}

	private async void btnCancelarClicked(object sender, EventArgs e)
	{
		// Voltar para a página anterior
		await Navigation.PopAsync();
	}
}
