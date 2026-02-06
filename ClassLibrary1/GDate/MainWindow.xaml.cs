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

namespace GDate
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            tbErreur.Text = "";
            tbJourAnnee.Text = "";
            tbBissextile.Text = "";

            try
            {
                int jour = int.Parse(tbJour.Text);
                int mois = int.Parse(tbMois.Text);
                int annee = int.Parse(tbAnnee.Text);

                tbJourAnnee.Text =
                    ClassLibrary1.Class1.DayOfYear(mois, jour, annee).ToString();

                tbBissextile.Text =
                    ClassLibrary1.Class1.IsLeapYear(annee) ? "Oui" : "Non";
            }
            catch (Exception ex)
            {
                tbErreur.Text = ex.Message;
            }
        }
    }
}
