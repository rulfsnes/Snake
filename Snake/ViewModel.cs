using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
namespace SnakeGame
{
    class ViewModel : INotifyPropertyChanged
    {
        private Game m_model;
        public ViewModel()
        {
            m_model = new Game();
            this.Timer = new DispatcherTimer(); 
            this.Timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            this.Timer.Tick += this.Tick;
            this.Timer.Start();
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

                m_model.Offset = value;
                InvokePropertyChanged("Offset");

            }

        }
        public void Tick(object sender, EventArgs e)
        {
            m_model.updateBackground();
            Offset = m_model.Offset;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void InvokePropertyChanged(string propertyName)
        {
            var e = new PropertyChangedEventArgs(propertyName);
            PropertyChangedEventHandler changed = PropertyChanged;
            if (changed != null) changed(this, e);
        }
    }
}
