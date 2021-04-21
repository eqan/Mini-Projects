using System;
using System.Drawing;
using System.Windows.Forms;

namespace InterviewManagementSystem
{
    public partial class MainForm : Form
    {
        private UIUtilities obj;
        public MainForm()
        {
            InitializeComponent();
            Initalize_UI();
            timer1.Start();
        }
        private void Initalize_UI()
        {
            statusLabel.ForeColor = Color.White;
            int width = this.Width, height = this.Height;
            obj = new UIUtilities(width, height);
            // Top Left Buttons
            this.Controls.Add(obj.Get_CloseBtn());
            this.Controls.Add(obj.Get_MaximizeBtn());
            this.Controls.Add(obj.Get_MinimizeBtn());
            // Side Panel
            this.Controls.Add(obj.Get_Panel());
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (obj.Get_State_Maximized())
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
            //if (obj.Get_State_Minimized())
            //    this.WindowState = FormWindowState.Minimized;
        }
        private void Account_MouseDown(object sender, MouseEventArgs e)
        {
            IntPtr handle = this.Handle;
            obj.MouseDown(handle, sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //UpdateData form = new UpdateData(ref statusLabel) { TopLevel = false, TopMost = true };
            //DeleteData form = new DeleteData(ref statusLabel) { TopLevel = false, TopMost = true };
            //AddData form = new AddData(ref statusLabel) { TopLevel = false, TopMost = true };
            //SearchData form = new SearchData(ref statusLabel) { TopLevel = false, TopMost = true };
            ProfileData form = new ProfileData() { TopLevel = false, TopMost = true };
            panel1.Controls.Add(form);
            form.Show();
        }
    }
}
