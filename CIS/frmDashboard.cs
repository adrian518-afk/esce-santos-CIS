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


        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadCitizenInfo();
            LoadProvinces();

        }

        private void LoadCitizenInfo()
        {
            using (SqlConnection sqlCon = new SqlConnection(CONFIG.StringConnetion))
            {
                sqlCon.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"SELECT id, ISNULL(first_name,'') + ' ' + ISNULL(last_name,'') AS Name, first_name as FirstName, last_name as LastName, province AS Province, age AS Age, school as School, email as Email,  birthdate as Birthday FROM RefTblCitizen WHERE citizen_is_deleted = 0;", sqlCon);

                DataTable tbl = new DataTable();



                da.Fill(tbl);


                dataGridMain.DataSource = tbl;
                dataGridMain.Columns[0].Visible = false;
                dataGridMain.Columns[2].Visible = false;
                dataGridMain.Columns[3].Visible = false;
                dataGridMain.Columns[5].Visible = false;
                dataGridMain.Columns[5].Width = 100;
                dataGridMain.ReadOnly = true;

                lblRecordCount.Text = dataGridMain.Rows.Count.ToString();

                if (dataGridMain.RowCount == 0)
                {
                    txtNoRecords.Visible = true;
                }
                else {
                    txtNoRecords.Visible = false;
                }
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
            txtSchool.Enabled =
            txtEmail.Enabled =
            cmbProvince.Enabled =
            btnDelete.Enabled =
            btnCancel.Enabled =
            datePickerAge.Enabled =
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;

            datePickerAge.Value = DateTime.Now;
            txtFirstName.Text =
            txtLastName.Text =
            txtEmail.Text = "";
            cmbProvince.Text = "ABRA";

            btnAdd.Text = "ADD";
            txtFirstName.Text = "Firstname";
            txtLastName.Text = "Lastname";
            txtEmail.Text = "Email";
            txtSchool.Text = "School";
            btnSortCancel.Enabled = false;
            cmbSortProvince.SelectedItem = "-";

            btnAdd.BackColor = Color.WhiteSmoke;
            btnEdit.BackColor =
            btnDelete.BackColor =
            btnCancel.BackColor = Color.Gray;

            label1.Visible =
            label2.Visible =
            label7.Visible =
            label3.Visible = false;


            txtFirstName.Font =
            txtLastName.Font =
            txtEmail.Font = new Font(txtFirstName.Font, FontStyle.Italic);
        }

        private void hideAll() {
            txtFirstName.Visible = 
            txtLastName.Visible =
            txtEmail.Visible =
            txtSchool.Visible =
            cmbProvince.Visible =
            datePickerAge.Visible =
            btnAdd.Visible =
            btnEdit.Visible = 
            btnDelete.Visible =
            btnCancel.Visible =
            label4.Visible = false;
        }

        
        private void showAll() {
            txtFirstName.Visible =
            txtLastName.Visible =
            txtEmail.Visible =
            txtSchool.Visible =
            cmbProvince.Visible =
            datePickerAge.Visible =
            btnAdd.Visible =
            btnEdit.Visible =
            btnDelete.Visible =
            btnCancel.Visible =
            label4.Visible = true;
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
            txtSchool.Enabled =
            cmbProvince.Enabled = false;
        }
        private void enableTextBoxes()
        {
            txtFirstName.Enabled =
            txtLastName.Enabled =
            txtEmail.Enabled =
            txtSchool.Enabled =
            cmbProvince.Enabled = true;
        }
        private void clearTextBoxes()
        {
            txtFirstName.Text =
            txtLastName.Text =
            txtSchool.Text =
            txtEmail.Text = "";
            cmbProvince.Text = "ABRA";
        }
        private void addCitizenUI()
        {
            txtFirstName.Enabled =
            txtLastName.Enabled =
            txtSchool.Enabled =
            txtEmail.Enabled =
            btnCancel.Enabled =
            datePickerAge.Enabled =
            cmbProvince.Enabled = true;
            btnCancel.BackColor = Color.WhiteSmoke;

            btnEdit.Enabled =
            btnDelete.Enabled = false;


            txtFirstName.ForeColor =
            txtLastName.ForeColor =
            txtEmail.ForeColor = Color.Gray;
        }
        private void cellClickUI()
        {
            label1.Visible =
            label7.Visible =
            label2.Visible =
            label3.Visible = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled =
            btnCancel.Enabled = 
            datePickerAge.Enabled =
            btnDelete.Enabled = true;
            btnEdit.BackColor =
            btnDelete.BackColor =
            btnCancel.BackColor = Color.WhiteSmoke;
            btnAdd.BackColor = Color.Gray;
            txtFirstName.Font =
            txtLastName.Font =
            txtSchool.Font =
            txtEmail.Font = new Font(txtFirstName.Font, FontStyle.Regular);
            txtFirstName.ForeColor = 
            txtLastName.ForeColor =
            txtSchool.ForeColor =
            txtEmail.ForeColor = Color.White;
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panelRegister.Width == 53)
            {
                //expand
                panelRegister.Visible = false;
                panelRegister.Width = 231;
                panelMain.Width = 723;
                slideTransitionHamburger.ShowSync(panelRegister);
                showAll();

            }
            else 
            {
                //minimize
                hideAll();
                panelRegister.Width = 53;
                panelRegister.Visible = false;
                panelMain.Width = 901;
                slideTransitionHamburger.ShowSync(panelRegister);
            }
        }

        private void dataGridMain_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMain.RowCount != 0) {
                clearTextBoxes();
                cellClickUI();
                lblID.Text = dataGridMain.CurrentRow.Cells["id"].Value.ToString();
                txtFirstName.Text = dataGridMain.CurrentRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = dataGridMain.CurrentRow.Cells["LastName"].Value.ToString();
                txtEmail.Text = dataGridMain.CurrentRow.Cells["Email"].Value.ToString();
                cmbProvince.Text = dataGridMain.CurrentRow.Cells["Province"].Value.ToString();
                cmbProvince.SelectedText = dataGridMain.CurrentRow.Cells["Province"].Value.ToString();
                txtSchool.Text = dataGridMain.CurrentRow.Cells["School"].Value.ToString();
                datePickerAge.Value = stringToDate(dataGridMain.CurrentRow.Cells["Birthday"].Value.ToString());
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
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
                bool isNullSafe = txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "" && txtEmail.Text.Trim() != "" && txtSchool.Text.Trim() != "";

                if (isNullSafe)
                {
                    using (SqlConnection sqlCon = new SqlConnection(CONFIG.StringConnetion))
                    {
                        sqlCon.Open();

                        SqlCommand cmd = new SqlCommand(@"INSERT INTO RefTblCitizen(first_name, last_name, province, birthdate, age, school, email, citizen_is_deleted) VALUES (@first_name, @last_name, @province, @birthdate, @age, @school, @email, @citizen_is_deleted)", sqlCon);

                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@province", cmbProvince.Text);
                        cmd.Parameters.AddWithValue("@birthdate", datePickerAge.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@age", computeAge(datePickerAge.Value));
                        cmd.Parameters.AddWithValue("@school", txtSchool.Text);
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

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            bool isNullSafe = txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "" && txtEmail.Text.Trim() != "" && txtSchool.Text.Trim() != "";

            if (isNullSafe)
            {
                using (SqlConnection sqlCon = new SqlConnection(CONFIG.StringConnetion))
                {
                    sqlCon.Open();

                    SqlCommand cmd = new SqlCommand(@"UPDATE RefTblCitizen SET first_name = @first_name, last_name = @last_name, province = @province, birthdate = @birthdate, age = @age, email = @email, school = @school WHERE id = @id", sqlCon);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", lblID.Text);
                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@province", cmbProvince.Text);
                    cmd.Parameters.AddWithValue("@school", txtSchool.Text);
                    cmd.Parameters.AddWithValue("@birthdate", datePickerAge.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@age", computeAge(datePickerAge.Value));
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);

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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            defaultUI();
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBox.Text.Trim() != "Type here to search...")
            {
                txtSearchBox.Font = new Font(txtSchool.Font, FontStyle.Regular);
                txtSearchBox.ForeColor = Color.Black;

                using (SqlConnection sqlCon = new SqlConnection(CONFIG.StringConnetion))
                {
                    sqlCon.Open();

                    SqlDataAdapter da = new SqlDataAdapter(@"SELECT id, ISNULL(first_name, '') +' ' + ISNULL(last_name, '') AS Name, first_name as FirstName, last_name as LastName, province AS Province, age AS Age, school as School, email as Email,  birthdate as Birthday FROM RefTblCitizen WHERE(first_name LIKE '%" + txtSearchBox.Text + "%' OR last_name LIKE '%" + txtSearchBox.Text + "%' OR province LIKE '%" + txtSearchBox.Text + "%' OR email LIKE '%" + txtSearchBox.Text + "%' OR school LIKE '%" + txtSearchBox.Text + "%') AND citizen_is_deleted = 0;", sqlCon);

                    DataTable tbl = new DataTable();



                    da.Fill(tbl);


                    dataGridMain.DataSource = tbl;
                    dataGridMain.Columns[0].Visible = false;
                    dataGridMain.Columns[2].Visible = false;
                    dataGridMain.Columns[3].Visible = false;
                    dataGridMain.Columns[5].Width = 100;
                    dataGridMain.ReadOnly = true;

                    lblRecordCount.Text = dataGridMain.Rows.Count.ToString();

                    if (dataGridMain.RowCount == 0)
                    {
                        txtNoRecords.Visible = true;
                    }
                    else
                    {
                        txtNoRecords.Visible = false;
                    }

                }
            }
            else {
                LoadCitizenInfo();
            }

            
        }

        private void btnSortCancel_Click(object sender, EventArgs e)
        {
            cmbSortProvince.SelectedItem = "-";
            btnSortCancel.Enabled = false;
            LoadCitizenInfo();
        }

        private void cmbSortProvince_TextChanged(object sender, EventArgs e)
        {
            if (cmbSortProvince.Text != "-")
            {
                btnSortCancel.Enabled = true;
                using (SqlConnection sqlCon = new SqlConnection(CONFIG.StringConnetion))
                {
                    sqlCon.Open();

                    SqlDataAdapter da = new SqlDataAdapter(@"SELECT id, ISNULL(first_name, '') +' ' + ISNULL(last_name, '') AS Name, first_name as FirstName, last_name as LastName, province AS Province, age AS Age, school as School, email as Email,  birthdate as Birthday FROM RefTblCitizen WHERE province = '" + cmbSortProvince.Text + "' AND citizen_is_deleted = 0;", sqlCon);

                    DataTable tbl = new DataTable();

                    da.Fill(tbl);


                    dataGridMain.DataSource = tbl;
                    dataGridMain.Columns[0].Visible = false;
                    dataGridMain.Columns[2].Visible = false;
                    dataGridMain.Columns[3].Visible = false;
                    dataGridMain.Columns[5].Width = 100;
                    dataGridMain.ReadOnly = true;

                    lblRecordCount.Text = dataGridMain.Rows.Count.ToString();

                    if (dataGridMain.RowCount == 0)
                    {
                        txtNoRecords.Visible = true;
                    }
                    else
                    {
                        txtNoRecords.Visible = false;
                    }

                }
            }
            else
            {
                LoadCitizenInfo();
                btnSortCancel.Enabled = false;
            }
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void txtFirstName_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtFirstName.Text == "Firstname") {
                txtFirstName.Text = "";
            }
        }

        private void txtLastName_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtLastName.Text == "Lastname")
            {
                txtLastName.Text = "";
            }
        }

        private void txtEmail_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
            }
        }

        private void txtSchool_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtSchool.Text == "School")
            {
                txtSchool.Text = "";
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() == "") {
                
                txtFirstName.Font = new Font(txtFirstName.Font, FontStyle.Italic);
                txtFirstName.ForeColor = Color.Gray;
                txtFirstName.Text = "Firstname";
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text.Trim() == "")
            {
                txtLastName.Text = "Lastname";
                txtLastName.Font = new Font(txtLastName.Font, FontStyle.Italic);
                txtLastName.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                txtEmail.Text = "Email";
                txtEmail.Font = new Font(txtEmail.Font, FontStyle.Italic);
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtSchool_Leave(object sender, EventArgs e)
        {
            if (txtSchool.Text.Trim() == "")
            {
                txtSchool.Text = "School";
                txtSchool.Font = new Font(txtSchool.Font, FontStyle.Italic);
                txtSchool.ForeColor = Color.Gray;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() != "Firstname") {
                txtFirstName.Font = new Font(txtFirstName.Font, FontStyle.Regular);
                txtFirstName.ForeColor = Color.White;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text.Trim() != "Lastname")
            {
                txtLastName.Font = new Font(txtLastName.Font, FontStyle.Regular);
                txtLastName.ForeColor = Color.White;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() != "Email")
            {
                txtEmail.Font = new Font(txtEmail.Font, FontStyle.Regular);
                txtEmail.ForeColor = Color.White;
            }
        }

        private void txtSchool_TextChanged(object sender, EventArgs e)
        {
            if (txtSchool.Text.Trim() != "School")
            {
                txtSchool.Font = new Font(txtSchool.Font, FontStyle.Regular);
                txtSchool.ForeColor = Color.White;
            }
        }

        private void txtSearchBox_Leave(object sender, EventArgs e)
        {
            if (txtSearchBox.Text.Trim() == "")
            {

                txtSearchBox.Font = new Font(txtSearchBox.Font, FontStyle.Italic);
                txtSearchBox.ForeColor = Color.Gray;
                txtSearchBox.Text = "Type here to search...";
            }
        }

        private void txtSearchBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtSearchBox.Text == "Type here to search...")
            {
                txtSearchBox.Text = "";
            }
        }
    }
}
