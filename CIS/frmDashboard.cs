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

namespace CIS
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        //ACCESSORS


        private void LoadCitizenInfo()
        {
            using (SqlConnection sqlCon = new SqlConnection(CONFIG.StringConnetion))
            {
                sqlCon.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"SELECT id, ISNULL(first_name,'') + ' ' + ISNULL(last_name,'') AS Name, first_name as FirstName, last_name as LastName, province AS Province, age AS Age, email as Email, birthdate as Birthday FROM RefTblCitizen WHERE citizen_is_deleted = 0;", sqlCon);

                DataTable tbl = new DataTable();



                da.Fill(tbl);


                dataGridMain.DataSource = tbl;
                dataGridMain.Columns[0].Visible = false;
                dataGridMain.Columns[2].Visible = false;
                dataGridMain.Columns[3].Visible = false;
                dataGridMain.Columns[7].Visible = false;
                dataGridMain.Columns[5].Width = 100;
                dataGridMain.ReadOnly = true;

                lblRecordCount.Text = dataGridMain.Rows.Count.ToString();

            }
        }

        private void LoadProvinces()
        {
            ProvinceData provData = new ProvinceData();
            String[] sortedProvinces = provData.getProvinces();
            Array.Sort(sortedProvinces);
            cmbSortProvince.Items.Add("-");
            for (int i = 0; i < sortedProvinces.Length; i++)
            {
                cmbSortProvince.Items.Add(sortedProvinces[i]);
                cmbProvince.Items.Add(sortedProvinces[i]);
            }
            cmbSortProvince.SelectedItem = "-";
            cmbProvince.SelectedItem = "ABRA";

        }


        //METHODS

        private void defaultUI() {
            txtFirstName.Enabled =
            txtLastName.Enabled =
            txtEmail.Enabled =
            cmbProvince.Enabled =
            btnDelete.Enabled =
            btnCancel.Enabled =
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;

            datePickerAge.Value = DateTime.Now;
            txtFirstName.Text =
            txtLastName.Text =
            txtEmail.Text = "";
            cmbProvince.Text = "ABRA";

            btnAdd.Text = "ADD";
            btnEdit.Text = "EDIT";
            btnSortCancel.Enabled = false;
            cmbSortProvince.SelectedItem = "-";
        }
        private void defaultSortUI() {

            btnSortCancel.Enabled = false;
            cmbSortProvince.SelectedItem = "-";
        }
        private void disableTextBoxes()
        {
            txtFirstName.Enabled =
            txtLastName.Enabled =
            txtEmail.Enabled =
            cmbProvince.Enabled = false;
        }
        private void enableTextBoxes()
        {
            txtFirstName.Enabled =
            txtLastName.Enabled =
            txtEmail.Enabled =
            cmbProvince.Enabled = true;
        }
        private void clearTextBoxes()
        {
            txtFirstName.Text =
            txtLastName.Text =
            txtEmail.Text = "";
            cmbProvince.Text = "ABRA";
        }
        private void addCitizenUI()
        {
            txtFirstName.Enabled =
            txtLastName.Enabled =
            txtEmail.Enabled =
            cmbProvince.Enabled = true;

            btnEdit.Enabled =
            btnDelete.Enabled = false;
        }
        private void cellClickUI()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled =
            btnCancel.Enabled = 
            btnDelete.Enabled = true;
            enableTextBoxes();
        }
        private void cellClickUIRevert()
        {
            btnAdd.Enabled = true;
            disableTextBoxes();
        }
        private int computeAge(DateTime chosenDate)
        {
            int age = 0;
            TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks - chosenDate.Ticks);
            age = (int)(timeSpan.Days / 365);
            return age;
        }
        private DateTime stringToDate(String date)
        {
            return Convert.ToDateTime(date);
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadCitizenInfo();
            LoadProvinces();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD")
            {
                btnAdd.Text = "SAVE";
                addCitizenUI();
                LoadCitizenInfo();
                defaultSortUI();

            }
            else 
            {
                bool isNullSafe = txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "" && txtEmail.Text.Trim() != "";

                if (isNullSafe) {
                    using (SqlConnection sqlCon = new SqlConnection(CONFIG.StringConnetion))
                    {
                        sqlCon.Open();

                        SqlCommand cmd = new SqlCommand(@"INSERT INTO RefTblCitizen(first_name, last_name, province, birthdate, age, email, citizen_is_deleted) VALUES (@first_name, @last_name, @province, @birthdate, @age, @email, @citizen_is_deleted)", sqlCon);

                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@province", cmbProvince.Text);
                        cmd.Parameters.AddWithValue("@birthdate", datePickerAge.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@age", computeAge(datePickerAge.Value));
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@citizen_is_deleted", 0);

                        int success = cmd.ExecuteNonQuery();
                        if (success == 0)
                        {
                            MessageBox.Show("Failed to add!");
                        }

                        defaultUI();
                        LoadCitizenInfo();
                    }
                }
            }

        }

        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearTextBoxes();
            cellClickUI();
            lblID.Text = dataGridMain.CurrentRow.Cells["id"].Value.ToString();
            txtFirstName.Text = dataGridMain.CurrentRow.Cells["FirstName"].Value.ToString();
            txtLastName.Text = dataGridMain.CurrentRow.Cells["LastName"].Value.ToString();
            txtEmail.Text = dataGridMain.CurrentRow.Cells["Email"].Value.ToString();
            cmbProvince.Text = dataGridMain.CurrentRow.Cells["Province"].Value.ToString();
            cmbProvince.SelectedText = dataGridMain.CurrentRow.Cells["Province"].Value.ToString();
            datePickerAge.Value = stringToDate(dataGridMain.CurrentRow.Cells["Birthday"].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure to delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(CONFIG.StringConnetion))
                {
                    sqlCon.Open();

                    SqlCommand cmd = new SqlCommand(@"UPDATE RefTblCitizen SET citizen_is_deleted = 1 WHERE id = @id", sqlCon);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", lblID.Text);

                    int success = cmd.ExecuteNonQuery();
                    if (success == 0)
                    {
                        MessageBox.Show("Failed to delete");
                    }

                    defaultUI();
                    LoadCitizenInfo();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            defaultUI();
        }

        private void cmbSortProvince_TextChanged(object sender, EventArgs e)
        {

            if (cmbSortProvince.Text != "-")
            {
                btnSortCancel.Enabled = true;
                using (SqlConnection sqlCon = new SqlConnection(CONFIG.StringConnetion))
                {
                    sqlCon.Open();

                    SqlDataAdapter da = new SqlDataAdapter(@"SELECT id, ISNULL(first_name,'') + ' ' + ISNULL(last_name,'') AS Name, first_name as FirstName, last_name as LastName, province AS Province, age AS Age, email as Email FROM RefTblCitizen WHERE province = '" + cmbSortProvince.Text + "' AND citizen_is_deleted = 0;", sqlCon);

                    DataTable tbl = new DataTable();

                    da.Fill(tbl);


                    dataGridMain.DataSource = tbl;
                    dataGridMain.Columns[0].Visible = false;
                    dataGridMain.Columns[2].Visible = false;
                    dataGridMain.Columns[3].Visible = false;
                    dataGridMain.Columns[5].Width = 100;
                    dataGridMain.ReadOnly = true;

                    lblRecordCount.Text = dataGridMain.Rows.Count.ToString();

                }
            }
            else {
                LoadCitizenInfo();
                btnSortCancel.Enabled = false;
            }
        }

        private void btnSortCancel_Click(object sender, EventArgs e)
        {
            cmbSortProvince.SelectedItem = "-";
            btnSortCancel.Enabled = false;
            LoadCitizenInfo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(CONFIG.StringConnetion))
            {
                sqlCon.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"SELECT id, ISNULL(first_name,'') + ' ' + ISNULL(last_name,'') AS Name, first_name as FirstName, last_name as LastName, province AS Province, age AS Age, email as Email FROM RefTblCitizen WHERE (first_name LIKE '%" + txtSearchBox.Text + "%' OR last_name LIKE '%" + txtSearchBox.Text + "%' OR province LIKE '%" + txtSearchBox.Text + "%' OR email LIKE '%" + txtSearchBox.Text + "%') AND citizen_is_deleted = 0;", sqlCon);

                DataTable tbl = new DataTable();



                da.Fill(tbl);


                dataGridMain.DataSource = tbl;
                dataGridMain.Columns[0].Visible = false;
                dataGridMain.Columns[2].Visible = false;
                dataGridMain.Columns[3].Visible = false;
                dataGridMain.Columns[5].Width = 100;
                dataGridMain.ReadOnly = true;

                lblRecordCount.Text = dataGridMain.Rows.Count.ToString();

            }
        }
    }
}
