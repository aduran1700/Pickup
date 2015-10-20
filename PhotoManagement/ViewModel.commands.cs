using Bizmonger.Patterns;

namespace PhotoManagement
{
    public partial class ViewModel
    {
        DelegateCommand _takePictureCommand = null;
        public DelegateCommand TakePictureCommand
        {
            get { return _takePictureCommand; }

            set
            {
                if (_takePictureCommand != value)
                {
                    _takePictureCommand = value;
                    OnPropertyChanged();
                }
            }
        }

        DelegateCommand _selectPictureCommand = null;
        public DelegateCommand SelectPictureCommand
        {
            get { return _selectPictureCommand; }
            set
            {
                if (_selectPictureCommand != value)
                {
                    _selectPictureCommand = value;
                    OnPropertyChanged();
                }
            }
        }

        protected override void ActivateCommands()
        {
            TakePictureCommand = new DelegateCommand(async obj => await TakePicture());
            SelectPictureCommand = new DelegateCommand(async obj => await SelectPicture());
        }
    }
}