using Microsoft.Maui;
using Microsoft.Maui.Controls;


namespace MauiApp_Suma
{ 
    public partial class MainPage : ContentPage
    {
        private double resultado; // Variable para almacenar el resultado


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSumarClicked(object sender, EventArgs e)
        {
            if (double.TryParse(EntryNumero1.Text, out double numero1) &&
                double.TryParse(EntryNumero2.Text, out double numero2))
            {
                resultado = numero1 + numero2;
            }
            else
            {
                resultado = 0;
            }

            PageResult page = new PageResult(resultado);
            Navigation.PushAsync(page);
        }

        private void OnRestarClicked(object sender, EventArgs e)
        {
            if (double.TryParse(EntryNumero1.Text, out double numero1) &&
                double.TryParse(EntryNumero2.Text, out double numero2))
            {
                resultado = numero1 - numero2;
            }
            else
            {
                resultado = 0;
            }

            PageResult page = new PageResult(resultado);
            Navigation.PushAsync(page);
        }


        private void OnMulClicked(object sender, EventArgs e)
        {
            if (double.TryParse(EntryNumero1.Text, out double numero1) &&
                double.TryParse(EntryNumero2.Text, out double numero2))
            {
                resultado = numero1 * numero2;
            }
            else
            {
                resultado = 0;
            }

            PageResult page = new PageResult(resultado);
            Navigation.PushAsync(page);
        }


        private void OnDivClicked(object sender, EventArgs e)
        {
            if (double.TryParse(EntryNumero1.Text, out double numero1) &&
                double.TryParse(EntryNumero2.Text, out double numero2))
            {
                resultado = numero1 / numero2;
            }
            else
            {
                resultado = 0;
            }

            PageResult page = new PageResult(resultado);
            Navigation.PushAsync(page);
        }


        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }

}
