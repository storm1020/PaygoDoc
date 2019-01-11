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
using static PaygoDoc.MetodoMAIN;

namespace PaygoDoc
{
    /// <summary>
    /// Interação lógica para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region WindowsFormComands
        public MainWindow()
        {
            InitializeComponent();

            cbBox.SelectedValue = Metodos.Todos.ToString();

            PopularMenu();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            cbBox.Items.Clear();
            lstChoice.Items.Clear();
            PopularMenu();
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarForm())
            {
                MessageBox.Show("Por favor, selecione um metodo.");
            }
            else
            {
                string selecionado = AddParametroEscolhido(cbBox.SelectedItem.ToString());

                RemoveItemDaLista(selecionado);
            }
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarLstItem())
            {
                MessageBox.Show("Selecione um item");
            }
            else
            {
                string selecionado = lstChoice.SelectedItem.ToString();

                lstChoice.Items.Remove(selecionado);

                InsereValorNaCombo(selecionado);
            }
        }
        #endregion

        #region Metodos gerais
        private void PopularMenu()
        {
            foreach (var item in MetodoMAIN.GetAllMetodos())
            {
                cbBox.Items.Add(item);
            }
        }

        private string AddParametroEscolhido(string param)
        {
            if (IdentificarDuplicidade(param))
            {
                if (param.Equals(Metodos.Todos.ToString()))
                {
                    PopularLista();
                }
                else
                {
                    lstChoice.Items.Add(param);
                }
            }
            else
            {
                MessageBox.Show("Item já selecionado!");
            }

            return param;
        }

        private void PopularLista()
        {
            foreach (var item in Enum.GetNames(typeof(Metodos)))
            {
                if (item != Metodos.Todos.ToString())
                {
                    lstChoice.Items.Add(item);
                }
            }
        }

        private bool IdentificarDuplicidade(string param)
        {
            if (lstChoice.Items.Contains(param)) return false;
            return true;
        }

        private void RemoveItemDaLista(string param)
        {
            if (lstChoice.Items.Contains(param))
            {
                cbBox.Items.Remove(param);
            }
        }

        private void InsereValorNaCombo(string param)
        {
            if (!cbBox.Items.Contains(param))
            {
                cbBox.Items.Add(param);
            }
        }

        private bool ValidarForm()
        {
            if (cbBox.SelectedIndex == -1) return false;
            return true;
        }

        private bool ValidarLstItem()
        {
            if (lstChoice.SelectedIndex == -1) return false;
            return true;
        }
        #endregion

        private string LerListaEcolhas()
        {
            string retorno = string.Empty;

            if (lstChoice.Items.Count == 0)
            {
                MessageBox.Show("A lista não contém itens.");
            }
            else
            {
                foreach (var item in lstChoice.Items)
                {
                    retorno = item.ToString();
                }
            }

            return retorno;
        }

        private void BtnGerar_Click(object sender, RoutedEventArgs e)
        {
            string select = LerListaEcolhas();
        }
    }
}
