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

namespace _22._09._2023_homework
{
    interface IView {
        void UpdateTextBlock(string text);
    }

    public partial class MainWindow : Window, IView
    {
        private Presenter _presenter;

        public MainWindow() {
            InitializeComponent();

            _presenter = new Presenter(this, new Model());
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var button = sender as Button;
            if (button != null) {
                _presenter.ButtonClicked(button.Content.ToString());
            }
        }

        private void Button_Clear(object sender, RoutedEventArgs e) { 
            _presenter.ButtonClear();
        }

        private void Button_Ok(object sender, RoutedEventArgs e){
            _presenter.OKButtonClicked();
        }

        public void UpdateTextBlock(string text) {
            textBlock.Text = text;
        }

        
    }
}
