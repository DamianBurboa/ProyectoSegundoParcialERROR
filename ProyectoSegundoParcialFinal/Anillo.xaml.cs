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

namespace ProyectoSegundoParcialFinal
{
    /// <summary>
    /// Interaction logic for Anillo.xaml
    /// </summary>
    public partial class Anillo : Page
    {
        public Anillo()
        {
            InitializeComponent();
        }


        private void TboxFecha_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxFecha.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxCliente_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxCliente.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxPrecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxPrecio.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxCantidad_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxCantidad.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxAnillo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxAnillo.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxColor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxColor.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (tboxCliente.Text == "" || tboxFecha.Text == "" || tboxPrecio.Text == "" || tboxCliente.Text == ""
                || tboxAnillo.Text == "" || tboxColor.Text == "" || (checkBoxXS.IsChecked == true && checkBoxS.IsChecked == true
                && checkBoxM.IsChecked == true && checkBoxL.IsChecked == true && checkBoxXL.IsChecked == true) ||
                (cbMarca.SelectedItem == cbMarca.ItemsSource))
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                gridAnillo.Children.Clear();
                alerta.Visibility = Visibility.Hidden;
                btnGuardar.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;

            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            gridAnillo.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }

        private void TboxFecha_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (tboxFecha.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }
    }
}
