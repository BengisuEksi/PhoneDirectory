using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhoneDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=PhoneDirectory;Integrated Security=True");
        void list()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_PersonInformation", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list();
            dataGridView1.TabStop = false;
        }

        void clear()
        {
            id_txtbox.Text = "";
            name_txtbox.Text = "";
            surname_txtbox.Text = "";
            number_txtbox.Text = "";
            mail_txtbox.Text = "";
            photo_txtbox.Text = "";
            pictureBox1.Image = null;
            name_txtbox.Focus();
        }

        private void clear_bttn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void add_bttn_Click(object sender, EventArgs e)
        {
            if (name_txtbox.Text == "" || surname_txtbox.Text == "" || number_txtbox.Text == "" || mail_txtbox.Text == "" || photo_txtbox.Text == "")
            {
                MessageBox.Show("Fill the blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] validDomains = { "@gmail.com", "@hotmail.com", "@outlook.com" };
                bool isValid = validDomains.Any(domain => mail_txtbox.Text.EndsWith(domain, StringComparison.OrdinalIgnoreCase));
                if (!isValid)
                {
                    MessageBox.Show("Invalid e-mail address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Tbl_PersonInformation (Name,Surname,Number,Mail,Photograph) values (@p1,@p2,@p3,@p4,@p5)", conn);
                    cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
                    cmd.Parameters.AddWithValue("@p2", surname_txtbox.Text);
                    cmd.Parameters.AddWithValue("@p3", number_txtbox.Text);
                    cmd.Parameters.AddWithValue("@p4", mail_txtbox.Text);
                    cmd.Parameters.AddWithValue("@p5", photo_txtbox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New person is added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    list();
                    clear();
                }
            }
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            if (name_txtbox.Text == "" || surname_txtbox.Text == "" || number_txtbox.Text == "" || mail_txtbox.Text == "" || photo_txtbox.Text == "")
            {
                MessageBox.Show("Fill the blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] validDomains = { "@gmail.com", "@hotmail.com", "@outlook.com" };
                bool isValid = validDomains.Any(domain => mail_txtbox.Text.EndsWith(domain, StringComparison.OrdinalIgnoreCase));
                if (!isValid)
                {
                    MessageBox.Show("Invalid e-mail address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update Tbl_PersonInformation set Name=@p1,Surname=@p2,Number=@p3,Mail=@p4,Photograph=@p5 where ID=@p6", conn);
                    cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
                    cmd.Parameters.AddWithValue("@p2", surname_txtbox.Text);
                    cmd.Parameters.AddWithValue("@p3", number_txtbox.Text);
                    cmd.Parameters.AddWithValue("@p4", mail_txtbox.Text);
                    cmd.Parameters.AddWithValue("@p5", photo_txtbox.Text);
                    cmd.Parameters.AddWithValue("@p6", id_txtbox.Text);
                    pictureBox1.ImageLocation = photo_txtbox.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Person information is updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    clear();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int no = dataGridView1.SelectedCells[0].RowIndex;
            id_txtbox.Text = dataGridView1.Rows[no].Cells[0].Value.ToString();
            name_txtbox.Text = dataGridView1.Rows[no].Cells[1].Value.ToString();
            surname_txtbox.Text = dataGridView1.Rows[no].Cells[2].Value.ToString();
            number_txtbox.Text = dataGridView1.Rows[no].Cells[3].Value.ToString();
            mail_txtbox.Text = dataGridView1.Rows[no].Cells[4].Value.ToString();
            photo_txtbox.Text = dataGridView1.Rows[no].Cells[5].Value.ToString();
            pictureBox1.ImageLocation = photo_txtbox.Text;
        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to delete this contact?","", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Tbl_PersonInformation where ID=" + id_txtbox.Text, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Person is deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                list();
                clear();
            }
            else
            {
                MessageBox.Show("Deletion cancelled.","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void add_photo_bttn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            photo_txtbox.Text = openFileDialog1.FileName;
        }
    }
}
