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
using System.Data.SqlClient;

namespace ExamenCsharp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = "Data Source=.; Initial Catalog=examenCsharp; Integrated Security=True";
                cnx.Open();
                string sql = "select * from Departement";
                SqlCommand cmd = new SqlCommand(sql, cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    deptCombo.Items.Add(dr.GetString(1));
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private int IdFiliere()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.; Initial Catalog=examenCsharp; Integrated Security=True";
            cnx.Open();
            string sql = "select * from Filiere";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (filCombo.SelectedItem.ToString().Equals(dr.GetString(1)))
                {
                    return dr.GetInt32(0);
                }
            }
            return 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int idfil = IdFiliere();
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = "Data Source=.; Initial Catalog=examenCsharp; Integrated Security=True";
                cnx.Open();
                string sql = "insert into Classe values('" + libelleCl.Text + "','" + montant.Text + "','" + mensualite.Text + "','" + idfil + "')";
                SqlCommand cmd = new SqlCommand(sql, cnx);
                int n = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int IdDepartement()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.; Initial Catalog=examenCsharp; Integrated Security=True";
            cnx.Open();
            string sql = "select * from Departement";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (deptCombo.SelectedItem.ToString().Equals(dr.GetString(1)))
                {
                    return dr.GetInt32(0);
                }
            }
            return 0;
        }

        private void deptCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idDep = IdDepartement();
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.; Initial Catalog=examenCsharp; Integrated Security=True";
            cnx.Open();
            string sql = "select * from Filiere where id_dep='"+idDep+"'";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Filiere> lf = new List<Filiere>();
            while (dr.Read())
            {
                Filiere filiere = new Filiere();
                filiere.Id_filiere = dr.GetInt32(0);
                filiere.LibelleF = dr.GetString(1);
                lf.Add(filiere);
            }
            dr.Close();
            filCombo.ItemsSource = lf;
            filCombo.DisplayMemberPath = "LibelleF";
        }
    }
}
