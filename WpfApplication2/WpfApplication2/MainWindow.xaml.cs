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

namespace WpfApplication2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateButton();
        }


        Random rnd = new Random(777);

        public void CreateButton()
        {
            Button Button1 = new Button()
            { Content = "name",
                Margin = new Thickness(rnd.Next(0,400), rnd.Next(0, 400), rnd.Next(0, 400), rnd.Next(0, 400)),
                Width = 90,
                Height=30,
            Padding=new Thickness(10,0,10,0) };
            Button1.Click += new RoutedEventHandler(this.OnClickEvent);
            this.grid.Children.Add(Button1);
        }
        public void OnClickEvent(object sender, RoutedEventArgs e)
        {
            CreateButton();
        }
    }
}
