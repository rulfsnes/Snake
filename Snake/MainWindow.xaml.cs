using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
namespace SnakeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Control control;
        public MainWindow()
        {
            InitializeComponent();
            this.control = new Control();
            this.DataContext = control;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,0,0,1);
            timer.Tick += dispatcherTimer_Tick;
            timer.Start();

        }
        private bool increment;
        void dispatcherTimer_Tick(object sender, EventArgs e) {
            
            if (this.control.Offset < 0.1){
                this.increment = true;
            }
            else if(this.control.Offset > 0.9) {
                this.increment = false;
            }
            if (this.control.Offset <= 1 && increment)
            {
                this.control.Offset += 0.1;
            }
            else if(this.control.Offset > 0 && !increment)
            {
                this.control.Offset -= 0.1;
            }
        }
    }
}
