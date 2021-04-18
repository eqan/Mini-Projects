using System;
using System.Windows.Forms;
using System.IO;

namespace Recommendation_System
{
    public partial class MenuSystem : Form
    {
        Doubly_LinkedList obj = new Doubly_LinkedList();
        string path = Environment.CurrentDirectory + @"\Data\Menus\";
        int z = 0, size = 0, numberOfPromoCodes = 0, count = 0, totalCapacity = 0, currentCapacity = 1, startingPrice = 0, status = 0;
        double currentDiscount = 0, total_bill = 0;
        int[] promoDiscounts, capacity, price;
        string[] promoCodes, name, ingredients;
        public MenuSystem(int startingPrice)
        {
            InitializeComponent();
            initalizeSidePanel();
            importPromoCodes();
            this.startingPrice = startingPrice;
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


        private void calculateNumberOfItems()
        {
            string temp = (path + "menu.txt");
            using (StreamReader sr = new StreamReader(temp))
            {
                string[] lines = File.ReadAllLines(temp);
                foreach (string s in lines)
                    size++;
            }
        }

        private void MenuSystem_Load(object sender, EventArgs e)
        {
            string temp = (path + "menu.txt");
            count = 0;
            if (size == 0)
                calculateNumberOfItems();
            name = new string[size];
            price = new int[size];
            capacity = new int[size];
            ingredients = new string[size];
            string[] readText = File.ReadAllLines(temp);
            foreach (string s in readText)
            {
                if ((s[0] >= 65 && s[0] <= 90) || (s[0] >= 97 && s[0] <= 122))
                    splitMenuInfo(s);
            }
            obj.display_next(size);
        }
        void splitMenuInfo(string line)
        {
            string[] result = line.Split(' ');
            if ((result[0][0] >= 65 && result[1][0] <= 90))
            {
                name[count] = result[0]; price[count] = (int.Parse(result[1]) + startingPrice); capacity[count] = int.Parse(result[2]);
                Console.WriteLine(result[3]);
                ingredients[count] = result[3];
                obj.insertEnd(name[count], price[count], capacity[count], ingredients[count]);
                count++;
            }
            else if ((result[0][0] >= 97 && result[1][0] <= 122))
            {
                name[count] = result[0]; price[count] = (int.Parse(result[1]) + startingPrice); capacity[count] = int.Parse(result[2]);
                ingredients[count] = result[3];
                obj.insertEnd(name[count], price[count], capacity[count], ingredients[count]);
                count++;
            }
            else return;
        }

        private void calculateNumberOfPromoCodes()
        {
            string temp = (path + "promoCodes.txt");
            using (StreamReader sr = new StreamReader(temp))
            {
                string[] lines = File.ReadAllLines(temp);
                foreach (string s in lines)
                    numberOfPromoCodes++;
            }
        }

        void readPromoCodes()
        {
            count = 0;
            calculateNumberOfPromoCodes();
            promoCodes = new string[numberOfPromoCodes]; promoDiscounts = new int[numberOfPromoCodes];
            string temp = (path + "promoCodes.txt");
            string[] readText = File.ReadAllLines(temp);
            foreach (string s in readText)
            {
                if ((s[0] >= 65 && s[0] <= 90) || (s[0] >= 97 && s[0] <= 122))
                    splitPromosAndDiscounts(s);
            }
        }


        private void peopleEntryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                totalCapacity = int.Parse(peopleEntryBox.Text);
            Console.WriteLine(totalCapacity);
        }

        void splitPromosAndDiscounts(string line)
        {
            string[] result = line.Split(' ');
            if ((result[0][0] >= 65 && result[1][0] <= 90))
            {
                promoCodes[count] = result[0]; promoDiscounts[count] = int.Parse(result[1]);
                count++;
            }
            else if ((result[0][0] >= 97 && result[1][0] <= 122))
            {
                promoCodes[count] = result[0]; promoDiscounts[count] = int.Parse(result[1]);
                count++;
            }
            else return;
        }

        private void calculateClick(object sender, EventArgs e)
        {
            totalBillBox.Text = Convert.ToString(total_bill);
        }

        private void selectClick(object sender, EventArgs e)
        {
            if (currentCapacity >= totalCapacity)
            {
                MessageBox.Show("Capacity has been filled!");
                return;
            }
            if (status == 1)
                z--;
            currentCapacity += capacity[z];
            total_bill += (Convert.ToInt32(obj.str_price[z]));
            billLabel.Text = Convert.ToString(total_bill);
            z++;
        }

        private void nextClick(object sender, EventArgs e)
        {
            if (z == size-1)
                z = 0;
            
            pictureBox1.ImageLocation = (path + @"menu pics\");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
          
            menuLabel.Text = obj.str_name[z];
            priceLabel.Text = obj.str_price[z].ToString();
            ingredientsLabel.Text = obj.str_ingredient[z];
            string temp_var;
            temp_var = path + @"menu pic\" + (obj.str_name[z] + ".jpg");
            pictureBox1.ImageLocation = temp_var;

            z++;
            Console.WriteLine(z);
            status = 1;
        }

        private void backClick(object sender, EventArgs e)
        {
        	if(z==0)
                z = size - 1;
            if (z > 0)
                z--;
            else
                z = size - 1;
            menuLabel.Text = obj.str_name[z];
            priceLabel.Text = obj.str_price[z].ToString();
            ingredientsLabel.Text = obj.str_ingredient[z];

            string temp_var;
            temp_var = path + @"menu pic\" + (obj.str_name[z] + ".jpg");
            pictureBox1.ImageLocation = temp_var;
            Console.WriteLine(z);
            status = 0;
        }

        private void importPromoCodes()
        {
            readPromoCodes();
        }
        bool checkIfPromoCodeMatches(string input)
        {
            for (int i = 0; i < numberOfPromoCodes; i++)
                if (input == promoCodes[i])
                {
                    currentDiscount = promoDiscounts[i];
                    promoCodes[i] = "NULL"; promoDiscounts[i] = 0;
                    return true;
                }
            return false;
        }
        void applyDiscount()
        {
            if (currentDiscount == 0)
                return;
            total_bill = total_bill - (currentDiscount * total_bill) / 100.0;
            totalBillBox.Text = total_bill.ToString();
            currentDiscount = 0;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (promoCodes[0] == null)
                importPromoCodes();
                if (e.KeyChar == (char)Keys.Enter)
                    if (checkIfPromoCodeMatches(promoCodeBox.Text))
                        applyDiscount();
            if (e.KeyChar == (char)Keys.Escape)
                promoCodeBox.Text = "";
        }
    }
}
