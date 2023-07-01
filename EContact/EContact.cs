using EContact.econtactClasses;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EContact
{
    public partial class EContact : Form
    {
        public EContact()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void EContact_Load(object sender, EventArgs e)
        {
            //Load Data on DataGridView
            DataTable dt = c.Select();
            dgvTableList.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e) { }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //Get the value from the input field
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.ContactNo = txtBoxContactNumber.Text;
            c.Address = txtBoxAddress.Text;
            c.Gender = cmboxGender.Text.ToString();

            //Inserting value into DB using method Add.
            bool success = c.Insert(c);
            if (success)
            {
                //Successfully Inserted
                MessageBox.Show("New Contact Sucessfully Inserted.");
                Clear();
            }
            else
            {
                //Failed to insert the contact
                MessageBox.Show("Failed to add new contact. Try Again.");
            }
            //Load Data on DataGridView
            DataTable dt = c.Select();
            dgvTableList.DataSource = dt;
        }

        private void dgvTableList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBoxCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Method to clear fields
        public void Clear()
        {
            txtBoxContactID.Text = "";
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxContactNumber.Text = "";
            txtBoxAddress.Text = "";
            cmboxGender.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get value from textboxes
            c.ContactID = int.Parse(txtBoxContactID.Text);
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.ContactNo = txtBoxContactNumber.Text;
            c.Address = txtBoxAddress.Text;
            c.Gender = cmboxGender.Text;

            //Update data in DB.
            bool success = c.Update(c);
            if (success)
            {
                //Updated Successfully
                MessageBox.Show("Contact has been updated sucessfully");
                //Load Data on DataGridView
                DataTable dt = c.Select();
                dgvTableList.DataSource = dt;
                Clear();
            }
            else
            {
                //Failed to update.
                MessageBox.Show("Failed to update contact. Try Again.");
            }

        }

        private void dgvTableList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from DataGridView and load it to textboxes respectively.
            //Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtBoxContactID.Text = dgvTableList.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxFirstName.Text = dgvTableList.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxLastName.Text = dgvTableList.Rows[rowIndex].Cells[2].Value.ToString();
            txtBoxContactNumber.Text = dgvTableList.Rows[rowIndex].Cells[3].Value.ToString();
            txtBoxAddress.Text = dgvTableList.Rows[rowIndex].Cells[4].Value.ToString();
            cmboxGender.Text = dgvTableList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call clear() method here
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get data from DataGridView to delete
            c.ContactID = Convert.ToInt32(txtBoxContactID.Text);
            bool success = c.Delete(c);
            if (success)
            {
                //Data deleted successfully.
                MessageBox.Show("Contact deleted successfully");
                //Load Data on DataGridView
                DataTable dt = c.Select();
                dgvTableList.DataSource = dt;
                Clear();
            }
            else
            {
                //Data not deleted
                MessageBox.Show("Failed to delete contact. Try Again");
            }

        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get data from textbox
            string keyword = txtBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvTableList.DataSource = dt;
        }
    }
}