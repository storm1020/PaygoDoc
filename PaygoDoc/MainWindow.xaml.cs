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
using static PaygoDoc.MetodosMODEL;

namespace PaygoDoc
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cbBox.SelectedValue = Metodos.Todos.ToString();

            PopularMenu();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            cbBox.Text = "";
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarForm())
            {
                MessageBox.Show("Por favor, selecione um metodo.");
            }
        }

        public void PopularMenu()
        {
            foreach (string item in Enum.GetNames(typeof(Metodos)))
            {
                cbBox.Items.Add(item);
            }
        }

        private bool ValidarForm()
        {
            if (cbBox.SelectedIndex == -1) return false;
            return true;
        }
    }
}
