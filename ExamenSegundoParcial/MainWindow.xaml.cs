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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if(controlInformacionPersonal.Visibility == Visibility.Visible)
            {

                if (controlInformacionPersonal.txtApellidoMaterno.Text != "" && 
                    controlInformacionPersonal.txtApellidoPaterno.Text != "" && 
                    controlInformacionPersonal.txtEdad.Text != "" &&
                    controlInformacionPersonal.txtNombre.Text != "")
                {
                    controlInformacionPersonal.msjLlenarCamposInfoPersonal.Visibility = Visibility.Collapsed;
                    controlInformacionPersonal.Visibility = Visibility.Collapsed;
                    controlContacto.Visibility = Visibility.Visible;
                    btnSiguiente2.Visibility = Visibility.Visible;
                    btnSiguiente.Visibility = Visibility.Collapsed;
                }
                else
                {
                    controlInformacionPersonal.msjLlenarCamposInfoPersonal.Visibility = Visibility.Visible;
                }
            }

            
        }

        private void btnFinalizar_Click(object sender, RoutedEventArgs e)
        {
            if (controlInformacionDePago.Visibility == Visibility.Visible)
            {
                if (controlInformacionDePago.txtNumeroTarjeta.Text.Length != 16)
                {
                    controlInformacionDePago.msjNumTarjeta.Visibility = Visibility.Visible;
                }
                else
                {
                    controlInformacionDePago.msjNumTarjeta.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void btnSiguiente2_Click(object sender, RoutedEventArgs e)
        {
            if (controlContacto.Visibility == Visibility.Visible)
            {
                controlInformacionDePago.Visibility = Visibility.Collapsed;
                if (controlContacto.txtCelular.Text != "" &&
                    controlContacto.txtCorreo.Text != "" &&
                    controlContacto.txtTelefono.Text != "")
                {
                    controlContacto.msjLlenarContacto.Visibility = Visibility.Collapsed;
                    controlContacto.Visibility = Visibility.Collapsed;
                    controlInformacionDePago.Visibility = Visibility.Visible;
                    btnFinalizar.Visibility = Visibility.Visible;
                    btnSiguiente2.Visibility = Visibility.Collapsed;
                }
                else
                {
                    controlContacto.msjLlenarContacto.Visibility = Visibility.Visible;
                }
            }
        }
    }
    
}
