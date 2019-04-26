using ExamenClient.ServiceReferenceEval;
using ExamenClient.ServiceReferenceIndic;
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

namespace ExamenClient
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GridIndic.IsEnabled = false;
            RemplirCombo();
        }

        private void RemplirCombo()
        {
            EvaluationServiceClient client = new EvaluationServiceClient();
            CombCrit.ItemsSource = client.ListCritere().ToList();
            CombCrit.DisplayMemberPath = "Libelle";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!GridIndic.IsEnabled)
            {
                try
                {
                    EvaluationServiceClient client = new EvaluationServiceClient();
                    ServiceReferenceEval.CritereEvaluation critere = new ServiceReferenceEval.CritereEvaluation();
                    critere.Libelle = TBcrit.Text;
                    critere = client.Add(critere);
                    MessageBox.Show("Critere d'evaluation enregistrer");
                }
                catch (Exception)
                {

                    throw;
                } 
            }
            else
            {
                EvaluationServiceClient client1 = new EvaluationServiceClient();
                IndicateurServiceClient client2 = new IndicateurServiceClient();

                ServiceReferenceEval.CritereEvaluation c = new ServiceReferenceEval.CritereEvaluation();
                ServiceReferenceIndic.Indicateur i = new ServiceReferenceIndic.Indicateur();

                c.Libelle = TBcrit.Text;
                c = client1.Add(c);

                i.Libelle = TBlib.Text;
                i = client2.Add(i);

                //note.N = Convert.ToInt32(NoteTB.Text);
                // note.IdM = ((ServiceReferenceClasse.Matiere)CombMat.SelectedItem).IdM;
                //note.IdE = ((ServiceReferenceEtudiant.Etudiant)CombEt.SelectedItem).IdE;
                //note = client.Add(note);
                MessageBox.Show("Note enregistree avec succes !");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(GridIndic.IsEnabled)
            {
                GridIndic.IsEnabled = false;
            }
            else
            {
                GridIndic.IsEnabled = true;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //notemin = Convert.ToInt32(TBnoteMin.Text);
            //notemax = Convert.ToInt32(TBnoteMax.Text);


            EvaluationServiceClient client = new EvaluationServiceClient();
            tab.ItemsSource = client.ListCritere();

        }

        private void CombCrit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //TBcr.Text = Convert.ToString(CombCrit.SelectedItem).ToString();
            TBcr.Text = ((ServiceReferenceEval.CritereEvaluation)CombCrit.SelectedItem).Libelle;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EvaluationServiceClient client = new EvaluationServiceClient();
            string l = ((ServiceReferenceEval.CritereEvaluation)CombCrit.SelectedItem).Libelle;

            // Recuperation de l'objet selectionne dans le combobox
            ServiceReferenceEval.CritereEvaluation c = client.Find(l);
            int i = client.Modify(TBcr.Text, c.Id);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            // Recupere l'id du combo selectionne
            int i = ((ServiceReferenceEval.CritereEvaluation)CombCrit.SelectedItem).Id;

            EvaluationServiceClient client = new EvaluationServiceClient();

            int del = client.Delete(i);
        }
    }
}
