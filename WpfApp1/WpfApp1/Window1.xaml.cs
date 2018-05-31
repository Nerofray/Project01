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
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public ObservableCollection<Book> lv;

        public Window1(ObservableCollection<Book> lv_)
        {
            InitializeComponent();
            lv = lv_;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_ptc.Text = ofd.FileName;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox_pti.Text = ofd.FileName;
        }

        private void Apply(object sender, RoutedEventArgs e)
        {
            lv.Add(new Book(textBox_name.Text, textBox_author.Text, File.ReadAllText(textBox_ptc.Text), textBox_pti.Text));
        }
    }
}
