using MauiExample.Models;

namespace MauiExample.Views;

public partial class BloodPressurePage : ContentPage
{
    public BloodPressurePage()
    {
        InitializeComponent();
    }
    private void GetButton_Clicked(object sender, EventArgs e)
    {
        var rand = new Random();
        BloodPressureModel data = new BloodPressureModel
        {
            bpm_id = 1,
            sys = rand.Next(100, 130),
            dia = rand.Next(50, 80),
            pul = rand.Next(50, 80)
        };
        BindingContext = data;
    }
}