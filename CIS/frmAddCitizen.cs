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
using System.Diagnostics;

namespace CIS
{
    public partial class frmAddCitizen : Form
    {
        public frmAddCitizen()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection sqlCon = new SqlConnection(CONFIG.StringConnetion))
            {
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand(@"INSERT INTO RefTblCitizen(first_name, last_name, province, age, email, citizen_is_deleted) VALUES (@first_name, @last_name, @province, @age, @email, @citizen_is_deleted)", sqlCon);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                cmd.Parameters.AddWithValue("@province", cmbProvince.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@citizen_is_deleted", 0);

                int success = cmd.ExecuteNonQuery();
                if (success > 0)
                {
                    MessageBox.Show("Successfully added a user!");
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
                else {
                    MessageBox.Show("Failed to add a user!");
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                }

            }

        }

        private void LoadProvinces() {
            ProvinceData provData = new ProvinceData();
            String[] sortedProvinces = provData.getProvinces();
            Array.Sort(sortedProvinces);
            for (int i = 0; i < sortedProvinces.Length; i++ )
            {
                cmbProvince.Items.Add(sortedProvinces[i]);
            }
            cmbProvince.SelectedItem = "ABRA";
            
        }

        private void frmAddCitizen_Load(object sender, EventArgs e)
        {
            LoadProvinces();
        }
    }
}
