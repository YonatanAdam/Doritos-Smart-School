using SmartSchool_YAS;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ViewModel;
using HamburgerMenu;

namespace YonatanFinalProj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICommand
    {
        static Frame frame;

        StudentDB db = new StudentDB();
        public MainWindow()
        {
            InitializeComponent();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentsList lst = db.SelectAll();
            txt.Text = lst.Count.ToString();
            lstView.ItemsSource = lst;
        }
    }
}
