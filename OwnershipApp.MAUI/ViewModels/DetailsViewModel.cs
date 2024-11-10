using CommunityToolkit.Mvvm.Input;
using OwnershipApp.MAUI.Models;
using System.Diagnostics;

namespace OwnershipApp.MAUI.ViewModels
{
    public partial class DetailsViewModel : BaseViewModel
    {
        public Property SelectedProperty { get; set; }
        public List<string> PropertyImages { get; set; }

        public int MoreItems { get; set; }


        public DetailsViewModel(Property currentSelectedProperty)
        {
            SelectedProperty = currentSelectedProperty;
        }


        [RelayCommand]
        private async Task CloseAsync()
        {
            if (IsBusy)
            {
                return;
            }

            try
            {
                IsBusy = true;

                if(Application.Current is not null)
                {
                    await Application.Current.MainPage.Navigation.PopAsync();
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

