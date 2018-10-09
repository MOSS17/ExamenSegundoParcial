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

namespace ExamenSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para ControlInformacionDePago.xaml
    /// </summary>
    public partial class ControlInformacionDePago : UserControl
    {
        public ControlInformacionDePago()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumeroTarjeta.Text.Length == 16)
            {
                msjNumTarjeta.Visibility = Visibility.Visible;
            }
            else
            {
                msjNumTarjeta.Visibility = Visibility.Collapsed;
            }
        }
    }
}
