using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace WPF_New_Students
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



        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataToGrid();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(FNameTextBox.Text)) && !(String.IsNullOrWhiteSpace(LNameTextBox.Text)) && !(String.IsNullOrWhiteSpace(SemesterComboBox.Text))) {
                string ConString = Properties.Settings.Default.StudentsConnectionString;
                string sqlcmd = string.Empty;
                SqlConnection cn_connection = new SqlConnection(ConString);
                if (cn_connection.State != System.Data.ConnectionState.Open)
                {
                    cn_connection.Open();
                }

                sqlcmd = "INSERT INTO tbl_Students (FirstName, LastName, Semester) VALUES ('" + FNameTextBox.Text + "','" + LNameTextBox.Text + "','" + SemesterComboBox.Text + "')";

                SqlCommand cmd_Command = new SqlCommand(sqlcmd, cn_connection);
                cmd_Command.ExecuteNonQuery();
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show("Please fill the text boxes!");
            }
        }

        private void LoadDataToGrid()
        {
            string ConString = Properties.Settings.Default.StudentsConnectionString;
            string sqlcmd = string.Empty;
            SqlConnection cn_connection = new SqlConnection(ConString);
            if(cn_connection.State != System.Data.ConnectionState.Open)
            {
                cn_connection.Open();
            }
            sqlcmd = "SELECT * FROM tbl_Students";
            DataTable dt = new DataTable("Students");
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, cn_connection);
            sda.Fill(dt);
            grdStudents.ItemsSource = dt.DefaultView;
        }

        private void grdStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if(row_selected != null)
            {
                FNameTextBox.Text = row_selected["FirstName"].ToString();
                LNameTextBox.Text = row_selected["LastName"].ToString();
                int comboindex = Convert.ToInt32(row_selected["Semester"].ToString());
                SemesterComboBox.SelectedIndex = --comboindex;
            }
            btnUpdate.IsEnabled = true;
            btnDelete.IsEnabled = true;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string ConString = Properties.Settings.Default.StudentsConnectionString;
            string sqlcmd = string.Empty;
            SqlConnection cn_connection = new SqlConnection(ConString);
            if (cn_connection.State != System.Data.ConnectionState.Open)
            {
                cn_connection.Open();
            }

            DataRowView row = grdStudents.SelectedItem as DataRowView;
            if (row != null)
            {
                MessageBoxResult boxResult = MessageBox.Show("Are you sure?", "Delete confirmation", MessageBoxButton.YesNo);
                if (boxResult == MessageBoxResult.Yes)
                {
                    string IdtoDelete = row["Id"].ToString();
                    sqlcmd = "DELETE FROM tbl_Students WHERE(Id = " + IdtoDelete + ")";
                    SqlCommand cmd_Command = new SqlCommand(sqlcmd, cn_connection);
                    cmd_Command.ExecuteNonQuery();
                    LoadDataToGrid();
                    ResetTextAndButton();
                }
            }
            else
            {
                MessageBox.Show("Please select a row!");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string ConString = Properties.Settings.Default.StudentsConnectionString;
            string sqlcmd = string.Empty;
            SqlConnection cn_connection = new SqlConnection(ConString);
            if (cn_connection.State != System.Data.ConnectionState.Open)
            {
                cn_connection.Open();
            }

            DataRowView row = grdStudents.SelectedItem as DataRowView;
            if (row != null)
            {
                string IdtoDelete = row["Id"].ToString();
                sqlcmd = "UPDATE tbl_Students set FirstName='" + FNameTextBox.Text + "',LastName='" + LNameTextBox.Text + "',Semester='" + SemesterComboBox.Text + "' WHERE Id ='" + IdtoDelete + "'";

                SqlCommand cmd_Command = new SqlCommand(sqlcmd, cn_connection);
                cmd_Command.ExecuteNonQuery();
                LoadDataToGrid();
                ResetTextAndButton();
                MessageBox.Show("Record updated!", "Notification", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Please select a row!");
            }
        }

        private void ResetTextAndButton()
        {
            FNameTextBox.Text = "";
            LNameTextBox.Text = "";
            SemesterComboBox.SelectedIndex = 0;
            btnUpdate.IsEnabled = false;
            btnDelete.IsEnabled = false;
        }
    }
}
