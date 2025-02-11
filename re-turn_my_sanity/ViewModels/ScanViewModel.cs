﻿namespace ReTurnMySanity.ViewModels;

public sealed class ScanViewModel : BaseViewModel
{
    private bool _scanned;
    public bool Scanned
    {
        get 
        {
            return _scanned;
        }
        set 
        {
            _scanned = value;
            OnPropertyChanged(nameof(Scanned));
        }
    }

    public ScanViewModel() 
    {

    }
}
