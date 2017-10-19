using System;
using System.Collections.Generic;
using AppFormatacaoBasica.Model;
using Xamarin.Forms;


namespace AppFormatacaoBasica
{
    public partial class AppFormatacaoBasicaPage : ContentPage
    {
        List<string> listaGenero;

        public AppFormatacaoBasicaPage()
        {
            InitializeComponent();
            ListarGenero();
        }

        private void ListarGenero()
        {
            listaGenero = new List<string>();
            listaGenero.Add("Feminino");
            listaGenero.Add("Masculino");

            picGenero.ItemsSource = listaGenero;
        }

        void btnLimpar_Clicked(object sender, System.EventArgs e)
        {
            
        }

        void Exibir_Clicked(object sender, System.EventArgs e)
        {
            ExibirFormulario();
        }

        public void ExibirFormulario()
        {
            // Instanciar objeto
            Formulario form = new Formulario();
            form.Nome = txtNome.Text;
            form.Email = txtEmail.Text;
            form.Telefone = Convert.ToInt32(txtTelefone.Text);
            form.Genero = picGenero.SelectedItem.ToString();
            form.DataNascimento = dpicDataNascimento.Date;
            form.HoraNascimento = tpicData.Time;
            form.Informacao = txtInformacao.Text;
            form.Preco = 100.00;

            DisplayAlert(
                "Formulario", 
                form.Nome + "\n" +
                form.Email + "\n" +
                form.Telefone + "\n" +
                form.Genero + "\n" +
                form.DataNascimento + "\n" +
                form.HoraNascimento + "\n" +
                form.Informacao + "\n" +
                form.Preco, "Fechar");
        }
    }
}