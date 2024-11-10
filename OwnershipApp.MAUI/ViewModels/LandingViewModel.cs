using CommunityToolkit.Mvvm.Input;
using OwnershipApp.MAUI.Models;
using OwnershipApp.MAUI.Views;
using System.Diagnostics;

namespace OwnershipApp.MAUI.ViewModels
{
    public partial class LandingViewModel : BaseViewModel
    {
        public List<string> Sections { get; }
        public List<Property> Properties { get; }

        public Property SelectedProperty { get; set; }

        public LandingViewModel()
        {
            Sections = new List<string> { "Trending", "Popular", "Buy", "Rent" };
            Properties = PropertyRepo.AllProperties;
        }

        [RelayCommand]
        private async Task PropertySelectedAsync()
        {
            if (IsBusy)
            {
                return;
            }

            try
            {
                if(SelectedProperty != null &&
                    Application.Current.MainPage is not null)
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new DetailsPage(SelectedProperty));
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);

                await Shell.Current.DisplayAlert("Error", "An error occurred. Please try again later.", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
