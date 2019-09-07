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
using Business;

namespace Semana04
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BtnConsultar_Click(object sender, RoutedEventArgs e)
		{
			BPedido bPedido = null;
			try
			{
				bPedido = new BPedido();
				dgvPedido.ItemsSource = bPedido.GetPedidosEntreFechas(Convert.ToDateTime(txtFechaInicio.Text),
																	  Convert.ToDateTime(txtFechaFin.Text));
			}
			catch (Exception)
			{

				MessageBox.Show("Comunicarse con el Administrador");
			}
			finally
			{
				bPedido = null;
			}
		}
	}
}
