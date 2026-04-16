namespace appUsandoEntry.Views;

public partial class CadastroDeCarros : ContentPage
{
	public CadastroDeCarros()
	{
		InitializeComponent();
	}

	private async void exibirDadosClicked(object sender, EventArgs e)
	{
		// Validação do campo Nome do Carro
		if (string.IsNullOrWhiteSpace(txtNomeCarro.Text))
		{
			await DisplayAlert("Erro", "Verifique se a caixa de texto Nome do Carro está vazia!!!!", "OK");
			txtNomeCarro.Focus();
			return;
		}

		// Validação do campo Placa do Carro
		if (string.IsNullOrWhiteSpace(txtPlacaCarro.Text))
		{
			await DisplayAlert("Erro", "Verifique se a caixa de texto Placa do Carro está vazia!!!!", "OK");
			txtPlacaCarro.Focus();
			return;
		}

		// Validação do campo Ano do Carro
		if (string.IsNullOrWhiteSpace(txtAnoCarro.Text))
		{
			await DisplayAlert("Erro", "Verifique se a caixa de texto Ano do Carro está vazia!!!!", "OK");
			txtAnoCarro.Focus();
			return;
		}

		// Exibir os dados validados
		await DisplayAlert("Dados do Carro",
			"Nome do Carro: " + txtNomeCarro.Text + "\n" +
			"Placa do Carro: " + txtPlacaCarro.Text + "\n" +
			"Ano do Carro: " + txtAnoCarro.Text,
			"OK");
	}

	private void limparDadosClicked(object sender, EventArgs e)
	{
		// Limpar todos os campos conforme apostila
		txtNomeCarro.Text = "";
		txtPlacaCarro.Text = "";
		txtAnoCarro.Text = "";
		txtNomeCarro.Focus();
	}

	private async void sairClicked(object sender, EventArgs e)
	{
		// Voltar para a página anterior
		await Navigation.PopAsync();
	}
}
