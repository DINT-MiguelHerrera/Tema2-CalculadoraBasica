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

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            botonCalcular.IsEnabled = false;
        }
        private void BotonCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double operando1 = double.Parse(casillaOperando1.Text);
                double operando2 = double.Parse(casillaOperando2.Text);
                char operador = char.Parse(casillaOperador.Text);

                switch (operador)
                {
                    case '+':
                        casillaResultado.Text = (operando1 + operando2).ToString();

                        break;
                    case '-':
                        casillaResultado.Text = (operando1 - operando2).ToString();

                        break;
                    case '*':
                        casillaResultado.Text = (operando1 * operando2).ToString();

                        break;
                    case '/':
                        casillaResultado.Text = (operando1 / operando2).ToString();

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error. Revise los operandos y el operador");
            }
        }

        private void BotonLimpiar_Click(object sender, RoutedEventArgs e)
        {
            casillaOperando1.Text = "";
            casillaOperando2.Text = "";
            casillaOperador.Text = "";
            casillaResultado.Text = "";
        }

        private void casillaOperador_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (casillaOperador.Text)
            {
                case "+":
                    botonCalcular.IsEnabled = true;
                    break;
                case "-":
                    botonCalcular.IsEnabled = true;
                    break;
                case "*":
                    botonCalcular.IsEnabled = true;
                    break;
                case "/":
                    botonCalcular.IsEnabled = true;
                    break;
                default:
                    botonCalcular.IsEnabled = false;
                    break;
            }
        }
    }
}
