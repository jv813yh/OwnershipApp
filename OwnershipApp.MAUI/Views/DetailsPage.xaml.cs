using OwnershipApp.MAUI.Models;
using OwnershipApp.MAUI.ViewModels;

namespace OwnershipApp.MAUI.Views;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(Property selectedProperty)
	{
		InitializeComponent();

        var viewModel = new DetailsViewModel(selectedProperty);
        viewModel.PropertyImages = selectedProperty.Images.Take(2).ToList();
        viewModel.MoreItems = selectedProperty.Images.Count - 2;

        BindingContext = viewModel;

    }
}