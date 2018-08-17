using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace YTS.ClientApp.Base
{
    public abstract class ViewModel : IViewModel
    {
        public abstract event PropertyChangedEventHandler PropertyChanged;

        public abstract void Dispose();
    }
}
