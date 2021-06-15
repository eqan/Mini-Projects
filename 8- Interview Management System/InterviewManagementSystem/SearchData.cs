using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace InterviewManagementSystem
{
    public partial class SearchData : Form
    {
        private SqlConnection dbConnection;
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        private int totalIDs = 0;
        ToolStripStatusLabel statusLabel;
        public SearchData(ref ToolStripStatusLabel statusLabel)
        {
            InitializeComponent();
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
            dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename= E:\Mini Projects\8- Interview Management System\InterviewManagementSystem\Interviewee_DB.mdf; Integrated Security=True; Connect Timeout=30");
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
            searchBox.Text = "";
        }

        private void Search_Load(object sender, EventArgs e)
        {
            Display_Record();
            statusLabel.ForeColor = Color.White;
            statusLabel.Text = "Total Interviewees: " + totalIDs.ToString();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            dbConnection.Open();
            adapt = new SqlDataAdapter("select * from Interviewee where Name like '" + searchBox.Text + "%'", dbConnection);
            DataTable intervieweeTable = new DataTable();
            adapt.Fill(intervieweeTable);
            dgInterviewees.DataSource = intervieweeTable;
            dbConnection.Close();
        }
    }
}
