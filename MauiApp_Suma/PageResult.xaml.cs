using Microsoft.Maui.Controls;

namespace MauiApp_Suma;

public partial class PageResult : ContentPage
{
    public PageResult(double resultado)
    {
        InitializeComponent();
        ResultadoLabel.Text = $"Resultado: {resultado}";
    }
}
