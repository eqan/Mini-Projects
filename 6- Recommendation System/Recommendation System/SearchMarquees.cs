using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Recommendation_System
{
    public partial class SearchMarquees : Form
    {
        Hashing obj;
        string[] str;
        string ImageNewName = "";
        int count = 0, size = 0;

        public SearchMarquees()
        {
            string path = Environment.CurrentDirectory + @"\Data\Marquees.txt";
            countSize(path);
            InitializeComponent();
            initalizeSidePanel();
            str = new string[size];
            obj = new Hashing(path);
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
        void countSize(string path)
        {
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                if ((s[0] >= 65 && s[0] <= 90) || (s[0] >= 97 && s[0] <= 122))
                    size++;
            }
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string selected = listView1.SelectedItems[0].Text;
            this.Hide();
            CompleteMarqueeDetails f = new CompleteMarqueeDetails(selected);
            f.Show();
        }

        private void populate()
        {
            int i = 0;
            string imageLocation = Environment.CurrentDirectory + @"\Data\Marquee Icons\";
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(150, 100);
            listView1.SmallImageList = imgs; // Setting Size Of Images
            string[] paths = { };
            paths = Directory.GetFiles(imageLocation);
            try
            {
                foreach (String path in paths)
                {
                    //Console.WriteLine(imageLocation + obj.finalstring[0]+".jpg");
                    //Console.WriteLine(path);
                    for (int l = 0; l < obj.size; l++)
                    {
                        if (path == imageLocation + obj.finalstring[l] + ".jpg")
                        {
                            imgs.Images.Add(Image.FromFile(path));
                            str[i++] = obj.finalstring[l];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Image Not Found!");
            }

            for (int j = 0; j < imgs.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                item.SubItems.Add(str[j]);
                item.Text = str[j];
                this.listView1.Items.Add(item);
            }
        }

        private void fill()
        {
            listView1.Items.Clear();
            string searchTerm = textBox1.Text;
            obj.searching(searchTerm);
            populate();
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            ImageNewName = Convert.ToString(e.Label);
            ListViewItem item1 = listView1.SelectedItems[0];
            FileInfo fileInfo = new FileInfo(item1.Tag.ToString());
            fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + ImageNewName + fileInfo.Extension);
            listView1.Items[count].Text = ImageNewName;
        }

        private void SearchMarquees_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.View = View.Details;
            listView1.Columns.Add("ThumbNails", 150);
            listView1.Columns.Add("Locations", 300);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                fill();
            if (e.KeyChar == (char)Keys.Escape)
            {
                listView1.Items.Clear();
                textBox1.Text = "";
            }
        }
    }
}
