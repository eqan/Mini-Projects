using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Recommendation_System
{
    public partial class PriceRangeFilters : Form
    {
        string ImageNewName = "";
        int[] priceRanges, totalMenuPrices, originalPrices;
        string[] marquees;
        int numberOfMarquees = 0, numberOfItems = 0, totalMenuPrice = 0;
        string path = Environment.CurrentDirectory + @"\Data\";
        public PriceRangeFilters()
        {
            InitializeComponent();
            initalizeSidePanel();
            importMarquees();
            importMenuPrices();
            calculatePriceRange();
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
        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchMarquees obj = new SearchMarquees();
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


        void countSize()
        {
            string tempPath = path + "Marquees.txt";
            string[] readText = File.ReadAllLines(tempPath);
            foreach (string s in readText)
            {
                if ((s[0] >= 65 && s[0] <= 90) || (s[0] >= 97 && s[0] <= 122))
                {
                    numberOfMarquees++;
                }
            }
        }
        void countTotalMenuItems()
        {
            string tempPath = (path + @"Menus\" + "menu.txt");
            string[] readText = File.ReadAllLines(tempPath);
            foreach (string s in readText)
            {
                if ((s[0] >= 65 && s[0] <= 90) || (s[0] >= 97 && s[0] <= 122))
                    numberOfItems++;
            }
        }

        void calculatePriceRange()
        {
            for (int i = 0; i < numberOfItems; i++)
                totalMenuPrices[i] = totalMenuPrice + originalPrices[i];
        }

        void importMenuPrices()
        {
            countTotalMenuItems();
            totalMenuPrices = new int[numberOfItems];
            originalPrices = new int[numberOfItems];
            int count = 0;
            string temp = (path + @"Menus\" + "menu.txt");
            string[] readText = File.ReadAllLines(temp);
            foreach (string s in readText)
            {
                if ((s[0] >= 65 && s[0] <= 90) || (s[0] >= 97 && s[0] <= 122))
                {
                    splitPrices(s, count);
                    count++;
                }
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string text = listView1.FocusedItem.Text;
            string[] result = text.Split('-');
            string[] result2 = result[0].Split(' ');
            int startingPrice = int.Parse(result2[1]);
            MenuSystem obj = new MenuSystem(startingPrice);
            this.Hide();
            obj.Show();
        }

        void splitPrices(string line, int count)
        {
            string[] result = line.Split(' ');
            if ((result[0][0] >= 65 && result[1][0] <= 90))
            {
                originalPrices[count] = int.Parse(result[1]);
                totalMenuPrice += int.Parse(result[1]);
                count++;
            }
            else if ((result[0][0] >= 97 && result[1][0] <= 122))
            {
                originalPrices[count] = int.Parse(result[1]);
                totalMenuPrice += int.Parse(result[1]);
                count++;
            }
            else return;
        }

        void importMarquees()
        {
            countSize();
            priceRanges = new int[numberOfMarquees];
            marquees = new string[numberOfMarquees];
            int i = 0;
            string marqueesPath = path + "Marquees.txt";
            FileStream marqueeFile = new FileStream(marqueesPath, FileMode.Open, FileAccess.Read);
            StreamReader marqueeStream = new StreamReader(marqueeFile);

            string priceRangesPath = path + "Price Ranges.txt";
            FileStream priceRangesFile = new FileStream(priceRangesPath, FileMode.Open, FileAccess.Read);
            StreamReader priceRangesStream = new StreamReader(priceRangesFile);

            marqueeStream.BaseStream.Seek(0, SeekOrigin.Begin);
            string marqueeStr = marqueeStream.ReadLine();
            priceRangesStream.BaseStream.Seek(0, SeekOrigin.Begin);
            string priceStr = priceRangesStream.ReadLine();
            while ((marqueeStr != null || priceStr != null))
            {
                if ((marqueeStr != null || priceStr != null))
                {
                    if ((priceStr[0] >= 48 && priceStr[0] <= 57))
                        priceRanges[i] = int.Parse(priceStr);
                    if ((marqueeStr[0] >= 65 && marqueeStr[0] <= 90) || (marqueeStr[0] >= 97 || marqueeStr[0] <= 122))
                        marquees[i] = marqueeStr;
                    i++;
                }
                marqueeStr = marqueeStream.ReadLine();
                priceStr = priceRangesStream.ReadLine();
            }
            marqueeStream.Close();
            marqueeFile.Close();
            priceRangesStream.Close();
            priceRangesFile.Close();
        }
        private void PriceRangeFilters_Load(object sender, EventArgs e)
        {
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(150, 100);
            string imageLocation = "";
            for (int i = 0; i < numberOfMarquees; i++)
            {
                try
                {
                    imageLocation = (path + @"Marquee Icons\" + marquees[i] + ".jpg");
                    Console.WriteLine(marquees[i]);
                    imageList1.Images.Add(Image.FromFile(imageLocation));
                    string labelText = (marquees[i] + "\nPrice: " + originalPrices[i].ToString() + " - " + totalMenuPrices[i].ToString());
                    listView1.Items.Add(new ListViewItem
                    {
                        ImageIndex = i,
                        Text = labelText,
                        Tag = marquees[i]
                    }); ; ; ; ;
                }
                catch
                {
                    Console.WriteLine(marquees[i] + " is not found");
                }
            }
            listView1.LargeImageList = imageList1;
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            ImageNewName = Convert.ToString(e.Label);
            ListViewItem item1 = listView1.SelectedItems[0];
            FileInfo fileInfo = new FileInfo(item1.Tag.ToString());
            fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + ImageNewName + fileInfo.Extension);
            listView1.Items[numberOfMarquees].Text = ImageNewName;
        }
    }
}
