using System.Collections.Generic;
using System.ComponentModel;
using View.Annotations;

namespace View.Models.BrowserInfo
{
    public class TypeBrowserInfo : INotifyPropertyChanged
    {
        private string name;
        
        private List<string> signatures;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public List<string> Signatures
        {
            get => signatures;
            set
            {
                signatures = value;
                OnPropertyChanged(nameof(Signatures));
            }
        }

        public TypeBrowserInfo()
        {
            signatures = new List<string>();
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}