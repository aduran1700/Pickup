using System;
using Bizmonger.Patterns;

namespace ManageProfile
{
    public partial class ViewModel
    {
        public DelegateCommand Save { get; set; }
        protected override void ActivateCommands()
        {
            Save = new DelegateCommand(OnSave, CanSave);
        }
    }
}