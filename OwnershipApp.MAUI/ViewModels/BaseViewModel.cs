﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace OwnershipApp.MAUI.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool _isBusy;

        public bool IsNotBusy 
            => !_isBusy;
    }
}
