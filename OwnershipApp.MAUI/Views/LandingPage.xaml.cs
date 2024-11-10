using OwnershipApp.MAUI.ViewModels;

namespace OwnershipApp.MAUI.Views;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
        BindingContext = new LandingViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if(SectionList.Children.First() is RadioButton firstRadioButton)
        {
            firstRadioButton.IsChecked = true;
        }
    }
}