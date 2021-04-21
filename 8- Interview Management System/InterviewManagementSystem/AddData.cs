using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;

namespace InterviewManagementSystem
{
    public partial class AddData : Form
    {
        private SqlConnection dbConnection;
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        private int ID = 0;
        ToolStripStatusLabel statusLabel;

        public AddData(ref ToolStripStatusLabel statusLabel)
        {
            InitializeComponent();
            Get_Customized_Button();
            Change_Data_Grid_Theme(ref dgInterviewees);
            Initialize_Information();
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

        private void AddData_Load(object sender, EventArgs e)
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

        public void Get_Customized_Button()
        {
            btn_AddData.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\plus.png");
            btn_AddData.MouseHover += new EventHandler((o, a) =>
            {
                btn_AddData.Image.Dispose();
                btn_AddData.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\selected plus.png");
            });
            btn_AddData.MouseLeave += new EventHandler((o, a) =>
            {
                btn_AddData.Image.Dispose();
                btn_AddData.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\plus.png");
            });
        }

        private void btn_AddData_Click(object sender, EventArgs e)
        {
            if (Validate_CheckBoxes())
            {
                ID++;
                statusLabel.Text = "Total Interviewees: " + ID.ToString();
                cmd = new SqlCommand("INSERT INTO Interviewee(ID, Name, Age, Gender, Skills) VALUES(@id, @name, @age, @gender, @skills)", dbConnection);
                dbConnection.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", nameBox.Text);
                cmd.Parameters.AddWithValue("@age", ageBox.Text);
                cmd.Parameters.AddWithValue("@gender", genderBox.Text);
                cmd.Parameters.AddWithValue("@skills", skillBox.Text);
                cmd.ExecuteNonQuery();
                dbConnection.Close();
                Display_Record();
                Clear_Data();
            }
        }

        private bool Validate_CheckBoxes()
        {
            if (nameBox.Text != "" && ageBox.Text != "" && genderBox.Text != "" && skillBox.Text != "")
            {
                if (!Name_Validate())
                    return false;
                if (!Age_Validate())
                    return false;
                Reset_Checks();
                return true;
            }
            else
            {
                if (!Name_Validate())
                    return false;
                if (!Age_Validate())
                    return false;
                if (!Gender_Check())
                    return false;
                if (!Skills_Validate())
                    return false;
            }
            return false;
        }

        private bool Name_Validate()
        {
            if (nameBox.Text.All(char.IsDigit))
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

        private bool Gender_Check()
        {
            if (genderBox.Text == "")
            {
                genderCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Wrong.png";
                statusLabel.Text = "Please enter record to add!";
                return false;
            }
            else
            {
                genderCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Right.png";
                return true;
            }
        }

        private bool Skills_Validate()
        {
            if (skillBox.Text == "")
            {
                skillsCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Wrong.png";
                statusLabel.Text = "Please enter record to add!";
                return false;
            }
            else
            {
                skillsCheck.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\Right.png";
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
    }
}
