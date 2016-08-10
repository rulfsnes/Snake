using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Control : System.ComponentModel.INotifyPropertyChanged
    {
        private double _offset;

        public double Offset {
            get {
                return _offset;
            }
            set {
                if (Offset != value)
                {
                    NotifyPropertyChanged("Offset");
                    _offset = value;
                }
            }
        }
        public Control()
        {
            _offset = 0;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
