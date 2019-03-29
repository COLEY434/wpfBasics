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

namespace wpfBasics
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

		private void ApplyButton_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show($"This description is: {this.description.Text}");
		}

		private void RefreshButton_Click(object sender, RoutedEventArgs e)
		{
			this.weldCheckbox.IsChecked = this.LaserCheckbox.IsChecked = this.AssemblyCheckbox.IsChecked = this.PurchaseCheckbox.IsChecked = this.PlasmaCheckbox.IsChecked =
				this.SawCheckbox.IsChecked = this.LatheCheckbox.IsChecked = this.RollCheckbox.IsChecked = this.DrillCheckbox.IsChecked = this.FoldCheckbox.IsChecked = false;
		}

		private void Checkbox_Checked(object sender, RoutedEventArgs e)
		{
			this.LengthText.Text += ((CheckBox)sender).Content;
		}

		private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (this.textnote == null)
				return;

			var combo = (ComboBox)sender;
			var value = (ComboBoxItem)combo.SelectedValue;

			this.textnote.Text += (string)value.Content;
		}
	}
}
