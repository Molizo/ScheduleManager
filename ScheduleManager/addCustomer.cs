using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ScheduleManager
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        private void addButton_click(object sender,EventArgs e)
        {
            string query = "INSERT INTO customers([ID], [Nume Client], [Telefon Client]) Values('" + 
                            Properties.Settings.Default.CurrentID + "', '" + name.Text + "', '" + telephone.Text + "')";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            Properties.Settings.Default.CurrentID++;
            this.Close();
        }
        private void nameTextField_click(object sender, EventArgs e)
        {
            name.Text = String.Empty;
            name.ForeColor = Color.FromName("Black");
        }
        private void telephoneTextField_click(object sender, EventArgs e)
        {
            telephone.Text = String.Empty;
            telephone.ForeColor = Color.FromName("Black");
        }
        
    }
}
