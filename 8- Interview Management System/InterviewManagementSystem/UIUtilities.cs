using System.Windows.Forms;
using System;
using System.Drawing;

namespace InterviewManagementSystem
{
    class UIUtilities
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        PictureBox btn_Close, btn_Minimize, btn_Maximize, btn_AccountManipulation, btn_Search, btn_Settings;
        Panel panel = new Panel();
        bool isMaximized = false, isMinimized = false;
        int formWidth, formHeight;
        FormWindowState currentState = FormWindowState.Normal;
        public UIUtilities(int width, int height)
        {
            formWidth = width;
            formHeight = height;
            Initialize_Top_Left_Buttons();
            Initialize_Side_Panel();
            //Initialize_Button_Transition_Effect();
        }

        private void Initialize_Top_Left_Buttons()
        {
            int x = formWidth, btn_Width = 45, btn_Height = 20;
            // Initializing
            btn_Close = new PictureBox();
            btn_Maximize = new PictureBox();
            btn_Minimize = new PictureBox();
            // Importing Images
            btn_Close.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\close.png";
            btn_Maximize.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\maximize.png";
            btn_Minimize.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\minimize.png";
            // Setting Width & Height
            btn_Close.Width = btn_Maximize.Width = btn_Minimize.Width = btn_Width;
            btn_Close.Height = btn_Maximize.Height = btn_Minimize.Height = btn_Height;
            // Setting Location
            btn_Close.Location = new System.Drawing.Point(x - btn_Width, 0);
            btn_Maximize.Location = new System.Drawing.Point(x - (btn_Width * 2), 0);
            btn_Minimize.Location = new System.Drawing.Point(x - (btn_Width * 3), 0);
            // Setting Size Mode To Zoom
            btn_Close.SizeMode = btn_Maximize.SizeMode = btn_Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            // Bringing Buttons To front
            btn_Close.BringToFront();
            btn_Maximize.BringToFront();
            btn_Minimize.BringToFront();
            // Mouse Event Handling
            btn_Close.MouseClick += new MouseEventHandler((o, a) => Application.Exit());
            btn_Close.MouseHover += new EventHandler((o, a) => btn_Close.BackColor = Color.Red);
            btn_Close.MouseLeave += new EventHandler((o, a) => btn_Close.BackColor = Color.FromArgb(57, 57, 57));
            btn_Maximize.MouseClick += new MouseEventHandler((o, a) =>
            {
                if (!isMaximized)
                {
                    currentState = FormWindowState.Maximized;
                    isMaximized = true;
                }
                else
                {
                    currentState = FormWindowState.Normal;
                    isMaximized = false;
                }
            }
            );
            btn_Maximize.MouseHover += new EventHandler((o, a) => btn_Maximize.BackColor = Color.FromArgb(64, 64, 64));
            btn_Maximize.MouseLeave += new EventHandler((o, a) => btn_Maximize.BackColor = Color.FromArgb(57, 57, 57));
            btn_Minimize.MouseClick += new MouseEventHandler((o, a) => isMinimized = true);
            btn_Minimize.MouseHover += new EventHandler((o, a) => btn_Minimize.BackColor = Color.FromArgb(64, 64, 64));
            btn_Minimize.MouseLeave += new EventHandler((o, a) => btn_Minimize.BackColor = Color.FromArgb(57, 57, 57));
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

        public void Initialize_Side_Panel()
        {
            int y = formHeight / 2 - 75, btn_Width = 65, btn_Height = 30;
            // Initializing
            btn_AccountManipulation = new PictureBox();
            btn_Search = new PictureBox();
            btn_Settings = new PictureBox();
            // Importing Images
            btn_AccountManipulation.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\account.png";
            btn_Search.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\search.png";
            btn_Settings.ImageLocation = Environment.CurrentDirectory + @"\UI Icons\settings.png";
            // Setting Width & Height
            btn_AccountManipulation.Width = panel.Width = btn_Search.Width = btn_Settings.Width = btn_Width;
            panel.Height = formHeight;
            btn_AccountManipulation.Height = btn_Height;
            btn_Search.Height = btn_Settings.Height = btn_Height - 4;
            // Setting Location
            panel.Location = new System.Drawing.Point(0, 0);
            btn_AccountManipulation.Location = new System.Drawing.Point(0, y);
            btn_Search.Location = new System.Drawing.Point(0, y + btn_Height * 2);
            btn_Settings.Location = new System.Drawing.Point(0, formHeight - 80);
            // Setting Size Mode To Zoom
            btn_AccountManipulation.SizeMode = btn_Search.SizeMode = btn_Settings.SizeMode = PictureBoxSizeMode.Zoom;
            // Bringing Buttons To front
            btn_AccountManipulation.BringToFront();
            btn_Search.BringToFront();
            btn_Settings.BringToFront();
            // Mouse Event Handling
            btn_AccountManipulation.MouseClick += new MouseEventHandler((o, a) =>
            {

            });
            btn_AccountManipulation.MouseHover += new EventHandler((o, a) =>
            {
                btn_AccountManipulation.Image.Dispose();
                btn_AccountManipulation.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\selected account.png");
            });
            btn_AccountManipulation.MouseLeave += new EventHandler((o, a) =>
            {
                btn_AccountManipulation.Image.Dispose();
                btn_AccountManipulation.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\account.png");
            });
            btn_Search.MouseClick += new MouseEventHandler((o, a) =>
            {
            });
            btn_Search.MouseHover += new EventHandler((o, a) =>
            {
                btn_Search.Image.Dispose();
                btn_Search.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\selected search.png");
            });
            btn_Search.MouseLeave += new EventHandler((o, a) =>
            {
                btn_Search.Image.Dispose();
                btn_Search.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\search.png");
            });
            btn_Settings.MouseClick += new MouseEventHandler((o, a) =>
            {
            });
            btn_Settings.MouseHover += new EventHandler((o, a) =>
            {
                btn_Settings.Image.Dispose();
                btn_Settings.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\selected settings.png");
            });
            btn_Settings.MouseLeave += new EventHandler((o, a) =>
            {
                btn_Settings.Image.Dispose();
                btn_Settings.Image = Image.FromFile(Environment.CurrentDirectory + @"\UI Icons\settings.png");
            });
            // Color Scheme
            Color panelBackgroundColor = Color.FromArgb(43, 43, 43);
            panel.BackColor = btn_AccountManipulation.BackColor = btn_Search.BackColor = btn_Settings.BackColor = panelBackgroundColor;
            // Panel Config
            panel.Controls.Add(btn_AccountManipulation);
            panel.Controls.Add(btn_Search);
            panel.Controls.Add(btn_Settings);
        }

        public bool Get_State_Maximized()
        {
            return isMaximized;
        }
        public bool Get_State_Minimized()
        {
            return isMinimized;
        }

        public PictureBox Get_Customized_Button(string original, string updated)
        {
            PictureBox obj = new PictureBox();
            obj.Image = Image.FromFile(original);
            obj.MouseHover += new EventHandler((o, a) =>
            {
                obj.Image.Dispose();
                obj.Image = Image.FromFile(original);
            });
            obj.MouseLeave += new EventHandler((o, a) =>
            {
                obj.Image.Dispose();
                obj.Image = Image.FromFile(updated);
            });
            return obj;
        }

        public void MouseDown(IntPtr obj, object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(obj, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public PictureBox Get_CloseBtn()
        {
            return btn_Close;
        }

        public PictureBox Get_MaximizeBtn()
        {
            return btn_Maximize;
        }

        public PictureBox Get_MinimizeBtn()
        {
            return btn_Minimize;
        }
        public Panel Get_Panel()
        {
            return panel;
        }
    }
}
