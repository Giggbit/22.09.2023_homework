using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _22._09._2023_homework
{
    class Presenter {
        private MainWindow _view;
        private Model _model;

        public Presenter(MainWindow view, Model model) {
            _view = view;
            _model = model;
        }

        public void ButtonClicked(string buttonText) {
            string currentText = _view.textBlock.Text;
            string updatedText = currentText + buttonText;
            _view.UpdateTextBlock(updatedText);
        }

        public void ButtonClear() {
            _view.UpdateTextBlock(string.Empty);
        }

        public void OKButtonClicked() {
            MessageBox.Show("OK");
        }
    }
}
