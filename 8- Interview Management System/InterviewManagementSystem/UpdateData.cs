using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace InterviewManagementSystem
{
    public partial class UpdateData : Form
    {
        private SqlConnection dbConnection;
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        private int ID = 0;
        ToolStripStatusLabel statusLabel;
        public UpdateData(ref ToolStripStatusLabel statusLabel)
        {
            InitializeComponent();
            Initialize_Information();
            Change_Data_Grid_Theme(ref dgInterviewees);
            Get_Customized_Button();
            Import_Genders();
            this.statusLabel = statusLabel;
        }

        public void Initialize_Information()
        {
            dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename= E:\C++\Interview Management System\Interview Management System\InterviewManagementSystem\Interviewee_DB.mdf; Integrated Security=True; Connect Timeout=30");
        }

        public void Import_Genders()
        {
            genderBox.Items.Add("Male");
            genderBox.Items.Add("Female");
            genderBox.Items.Add("Other");
        }

        private void UpdateData_Load(object sender, EventArgs e)
        {
            Display_Record();
            statusLabel.Text = "Total Interviewees: " + ID.ToString();
        }

        private void Display_Record()
        {
            DataTable intervieweeTable = new DataTable();
            dbConnection.Open();
            cmd = new SqlCommand("SELECT * FROM Interviewee", dbConnection);
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(intervieweeTable);
            dgInterviewees.DataSource = intervieweeTable;
            dbConnection.Close();
            ID = intervieweeTable.Rows.Count;
        }

        private bool Validate_CheckBoxes()
        {
            if (!ID_Validate())
                return false;
            if (!Name_Validate())
                return false;
            if (!Age_Validate())
                return false;
            return true;
        }
        private bool ID_Validate()
        {
            if (idBox.Text == "")
            {
                idCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Wrong.png";
                statusLabel.Text = "ID has been left blank!";
                return false;
            }

            if (idBox.Text.All(char.IsNumber))
            {
                idCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Right.png";
            }
            else
            {
                idCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Wrong.png";
                statusLabel.Text = "ID should only consist a Number";
                return false;
            }
            if (Int32.Parse(idBox.Text) > 0 && (Int32.Parse(idBox.Text) <= ID))
            {
                idCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Right.png";
            }
            else
            {
                idCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Wrong.png";
                statusLabel.Text = "ID should only consist a Number";
                return false;
            }
            return true;
        }


        private bool Name_Validate()
        {
            if (nameBox.Text == "")
                return true;
            if (nameBox.Text.All(char.IsNumber))
            {
                nameCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Wrong.png";
                statusLabel.Text = "Name shouldnt consist of digit!";
                return false;
            }
            else
            {
                nameCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Right.png";
                return true;
            }
        }

        private bool Age_Validate()
        {
            if (ageBox.Text == "")
                return true;
            if (ageBox.Text.All(char.IsLetter))
            {
                ageCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Wrong.png";
                statusLabel.Text = "Age shouldnt be a letter";
                return false;
            }
            else
                ageCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Right.png";
            if (Int32.Parse(ageBox.Text) > 120 || Int32.Parse(ageBox.Text) < 0)
            {
                ageCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Wrong.png";
                statusLabel.Text = "Age should lie between 0 and 120!";
                return false;
            }
            else
            {
                ageCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Right.png";
                return true;
            }
        }

        private void Clear_Data()
        {
            nameBox.Text = "";
            ageBox.Text = "";
            genderBox.Text = "";
            skillBox.Text = "";
        }

        private void Reset_Checks()
        {
            skillsCheck.ImageLocation = "";
            ageCheck.ImageLocation = "";
            genderCheck.ImageLocation = "";
            nameCheck.ImageLocation = "";
        }

        public void Change_Data_Grid_Theme(ref DataGridView obj)
        {
            Color background = Color.FromArgb(57, 57, 57);
            Color foreGround = Color.White;
            obj.GridColor = Color.Black;
            obj.BorderStyle = BorderStyle.Fixed3D;
            obj.EnableHeadersVisualStyles = false;
            obj.DefaultCellStyle.BackColor = background;
            obj.DefaultCellStyle.ForeColor = foreGround;
            obj.ColumnHeadersDefaultCellStyle.BackColor = background;
            obj.ColumnHeadersDefaultCellStyle.ForeColor = foreGround;
            obj.RowHeadersDefaultCellStyle.BackColor = background;
            obj.RowHeadersDefaultCellStyle.ForeColor = foreGround;
        }
        public void Get_Customized_Button()
        {
            btn_UpdateData.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\update.png");
            btn_UpdateData.MouseHover += new EventHandler((o, a) =>
            {
                btn_UpdateData.Image.Dispose();
                btn_UpdateData.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\selected update.png");
            });
            btn_UpdateData.MouseLeave += new EventHandler((o, a) =>
            {
                btn_UpdateData.Image.Dispose();
                btn_UpdateData.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\update.png");
            });
        }
        private void Update_Records()
        {
            if (Validate_CheckBoxes())
            {
                statusLabel.Text = "Total Interviewees: " + ID.ToString();
                Fill_Blank_Boxes();
                cmd = new SqlCommand("UPDATE Interviewee set Name=@name, Age=@age, Gender=@gender, Skills=@skills WHERE ID=@id", dbConnection);
                dbConnection.Open();
                cmd.Parameters.AddWithValue("@id", idBox.Text);
                cmd.Parameters.AddWithValue("@name", nameBox.Text);
                cmd.Parameters.AddWithValue("@age", ageBox.Text);
                cmd.Parameters.AddWithValue("@gender", genderBox.Text);
                cmd.Parameters.AddWithValue("@skills", skillBox.Text);
                cmd.ExecuteNonQuery();
                dbConnection.Close();
                Display_Record();
                Reset_Checks();
                Clear_Data();
                statusLabel.Text = idBox.Text + "th Row has been updated!";
            }
        }

        private void Fill_Blank_Boxes()
        {
            DataGridViewRow row = dgInterviewees.Rows[Int32.Parse(idBox.Text)-1];
            if (nameBox.Text == "")
                nameBox.Text = row.Cells["Name"].Value.ToString();
            if (ageBox.Text == "")
                ageBox.Text = row.Cells["Age"].Value.ToString();
            if (genderBox.Text == "")
                genderBox.Text = row.Cells["Gender"].Value.ToString();
            if (skillBox.Text == "")
                skillBox.Text = row.Cells["Skills"].Value.ToString();
        }

        private void btn_UpdateData_Click(object sender, EventArgs e)
        {
            Update_Records();
        }
    }
}
