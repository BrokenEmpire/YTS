using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YTS.ClientApp.Base
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Support

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion
    }
}
