using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
namespace SnakeGame
{
    class BaseView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void InvokePropertyChanged(string propertyName)
        {
            var e = new PropertyChangedEventArgs(propertyName);
            PropertyChangedEventHandler changed = PropertyChanged;
            if (changed != null) changed(this, e);
        }
    }

    class ViewModel : BaseView
    {
        private Game m_model { get; set; }
        public ViewModel()
        {
            m_model = new Game();
            m_model.PropertyChanged += M_model_PropertyChanged;
            this.Timer = new DispatcherTimer(); 
            this.Timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            this.Timer.Tick += this.Tick;
            this.Timer.Start();
        }

        private void M_model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Offset")
            {
                Offset = m_model.Offset;
                InvokePropertyChanged("Offset");
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private DispatcherTimer Timer;
        public double Offset
        {
            get
             {
                return m_model.Offset;
            }
            set
            {
                if (Offset != value)
                {
                    InvokePropertyChanged("Offset");
                    Offset = value;
                }
            }

        }
        public void Tick(object sender, EventArgs e)
        {
            m_model.updateBackground();
        }
    }
}
