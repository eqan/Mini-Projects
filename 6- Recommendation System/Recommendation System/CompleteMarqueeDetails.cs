using System;
using System.Windows.Forms;
using System.IO;

namespace Recommendation_System
{
    public partial class CompleteMarqueeDetails : Form
    {
        string fileName = "";
        public CompleteMarqueeDetails(string fileName)
        {
            InitializeComponent();
            initalizeSidePanel();
            this.fileName = fileName;
        }
        void initalizeSidePanel()
        {
            string buttonLocation = Environment.CurrentDirectory + @"\UI Icons\";
            homeBtn.ImageLocation = buttonLocation + "Home.png";
            searchBtn.ImageLocation = buttonLocation + "Search.png";
            locationBtn.ImageLocation = buttonLocation + "Location.png";
            powerBtn.ImageLocation = buttonLocation + "Power.png";
            powerBtn.SizeMode = PictureBoxSizeMode.Zoom;
            locationBtn.SizeMode = PictureBoxSizeMode.Zoom;
            searchBtn.SizeMode = PictureBoxSizeMode.Zoom;
            homeBtn.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PriceRangeFilters obj = new PriceRangeFilters();
            obj.Show();
        }

        private void locationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location obj = new Location();
            obj.Show();
        }

        private void powerBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void CompleteMarqueeDetails_Load(object sender, EventArgs e)
        {
            string detailsLocation = Environment.CurrentDirectory + @"\Data\Marquee Details\" + fileName + ".txt";
            string imageLocation = Environment.CurrentDirectory + @"\Data\Marquee Icons\" + fileName + ".jpg";
            loadImage(imageLocation);
            loadDetails(detailsLocation);
            Console.WriteLine("Form Loaded!");
        }
        void loadImage(string imageLocation)
        {
            pictureBox1.ImageLocation = imageLocation;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Console.WriteLine("Image Loaded!");
        }
        void loadDetails(string detailLocation)
        {
            Console.WriteLine(detailLocation);
            FileStream fs = new FileStream(detailLocation, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string file = "NULL";
            int count = 0;
            while (file != null)
            {
                file = sr.ReadLine();
                if (file != null)
                {
                    if ((file[0] >= 65 && file[0] <= 90) || (file[0] >= 97 && file[0] <= 122))
                    {
                        if (count == 0)
                            title.Text = file;
                        else if (count == 1)
                            destination.Text = file;
                        else if (count == 2)
                            cuisines.Text = file;
                        count++;
                    }
                }
            }
            fs.Close();
            sr.Close();
        }
    }
}
