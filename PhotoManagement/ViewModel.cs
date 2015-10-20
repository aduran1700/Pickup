using System;
using Bizmonger.Patterns;
using Core;
using Xamarin.Forms;

namespace PhotoManagement
{
    public partial class ViewModel : ViewModelBase
    {
        ImageSource _imageSource = null;
        public ImageSource ImageSource
        {
            get { return _imageSource; }
            set
            {
                if (_imageSource != value)
                {
                    _imageSource = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}