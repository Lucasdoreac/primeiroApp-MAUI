using Microsoft.Maui.Controls;

namespace appUsandoEntry.Views;

public partial class CadastroDeCarros : ContentPage
{
	public CadastroDeCarros()
	{
		InitializeComponent();
	}

    private void exibirDadosClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNomeCarro.Text))
        {
            DisplayAlertAsync("Erro", "Verifique se a caixa de texto Nome do Carro está vazia !!!!", "OK");
            txtNomeCarro.Focus();
        }
        else if (string.IsNullOrWhiteSpace(txtPlacaCarro.Text))
        {
            DisplayAlertAsync("Erro", "Verifique se a caixa de texto Placa do Carro está vazia !!!!", "OK");
            txtPlacaCarro.Focus();
        }
        else
        {
            DisplayAlertAsync("Dados do Carro", "Nome do Carro: " + txtNomeCarro.Text +
                          "\nPlaca do Carro: " + txtPlacaCarro.Text, "OK");
        }
    }

    private void limparDadosClicked(object sender, EventArgs e)
    {
        txtNomeCarro.Text = "";
        txtPlacaCarro.Text = "";
        txtNomeCarro.Focus();
    }

    private async void sairClicked(object sender, EventArgs e)
    {
        var resultado = await DisplayAlertAsync("Alerta", "Deseja realmente sair?", "Sim", "Não");
        if (resultado) System.Diagnostics.Process.GetCurrentProcess().Kill();
    }
}