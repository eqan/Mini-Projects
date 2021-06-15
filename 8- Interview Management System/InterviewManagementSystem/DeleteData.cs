using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace InterviewManagementSystem
{
    public partial class DeleteData : Form
    {
        private SqlConnection dbConnection;
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        private int totalIDs = 0;
        ToolStripStatusLabel statusLabel;

        public DeleteData(ref ToolStripStatusLabel statusLabel)
        {
            InitializeComponent();
            Get_Customized_Button();
            Initialize_Information();
            Change_Data_Grid_Theme(ref dgInterviewees);
            this.statusLabel = statusLabel;
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

        public void Initialize_Information()
        {
            dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename= E:\C++\Interview Management System\Interview Management System\InterviewManagementSystem\Interviewee_DB.mdf; Integrated Security=True; Connect Timeout=30");
        }

        private void DeleteData_Load(object sender, EventArgs e)
        {
            Display_Record();
            statusLabel.ForeColor = Color.White;
            statusLabel.Text = "Total Interviewees: " + totalIDs.ToString();
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
            totalIDs = intervieweeTable.Rows.Count;
        }
        private void Clear_Data()
        {
            initialIndexBox.Text = "";
            endIndexBox.Text = "";
        }

        public void Get_Customized_Button()
        {
            btn_DeleteData.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\next.png");
            btn_DeleteData.MouseHover += new EventHandler((o, a) =>
            {
                btn_DeleteData.Image.Dispose();
                btn_DeleteData.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\selected next.png");
            });
            btn_DeleteData.MouseLeave += new EventHandler((o, a) =>
            {
                btn_DeleteData.Image.Dispose();
                btn_DeleteData.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\next.png");
            });
        }

        private void btn_DeleteData_Click(object sender, EventArgs e)
        {
            int initialIndex = Int32.Parse(initialIndexBox.Text), endIndex = Int32.Parse(endIndexBox.Text);
            if ((initialIndex > 0 && initialIndex <= totalIDs) && (endIndex > 0 && endIndex <= totalIDs))
            {
                dbConnection.Open();
                for (int i = initialIndex; i <= endIndex; i++)
                {
                    cmd = new SqlCommand("DELETE Interviewee WHERE ID=@id", dbConnection);
                    cmd.Parameters.AddWithValue("@id", i);
                    cmd.ExecuteNonQuery();
                }
                dbConnection.Close();
                Display_Record();
                Clear_Data();
            }
            else
            {
                statusLabel.ForeColor = Color.Yellow;
                statusLabel.Text = "Please define initial Values and ending values in range!";
            }
        }
    }
}
