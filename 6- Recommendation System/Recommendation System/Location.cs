using System;
using System.IO;
using System.Windows.Forms;

namespace Recommendation_System
{
    public partial class Location : Form
    {
        int V, E;
        const int numberOfAlphabets = 26;
        bool[] visited = new bool[numberOfAlphabets];
        Graph graph;
        Queue queue = new Queue();
        public Location()
        {
            InitializeComponent();
            for (int i = 0; i < numberOfAlphabets; i++)
                visited[i] = false;
            initalizeSidePanel();
            process();
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchMarquees obj = new SearchMarquees();
            obj.Show();
        }


        private void powerBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void process()
        {
            readFromFile();
            createGraph();
            graph.KruskalMST();
        }
        void search()
        {
            string rawText = textBox1.Text;
            int inputSrc = 0;
            Console.WriteLine(rawText);
            if (rawText != null)
            {
                if ((rawText[0] >= 65) && (rawText[0] <= 90))
                    inputSrc = (int)(rawText[0] - 65);
                else if ((rawText[0] >= 97) && (rawText[0] <= 122))
                    inputSrc = (int)(rawText[0] - 97);
                else
                {
                    Console.WriteLine("Invalid Input!");
                    return;
                }
                graph.displayShortestPath(inputSrc);
                showResultant();
            }
        }
        void showResultant()
        {
            string imageLocation = Environment.CurrentDirectory + @"\Data\Marquee Icons\";
            char dest = (char)(graph.resultantDestination + 65);
            sourceLabel.Text = textBox1.Text;
            pictureBox1.ImageLocation = (imageLocation + sourceLabel.Text + ".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            destinationLabel.Text = dest.ToString();
            pictureBox2.ImageLocation = (imageLocation + destinationLabel.Text + ".jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            distanceLabel.Text = (graph.resultantWeight.ToString() + "KM");
        }
        void readFromFile()
        {
            string path = Environment.CurrentDirectory + @"\Data\Locations\dataPoints.txt";
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                if ((s[0] >= 65 && s[0] <= 90) || (s[0] >= 97 && s[0] <= 122))
                    createEdge(s);
            }
        }
        void createEdge(string line)
        {
            string[] result = line.Split(' ');
            int src = 0, dest = 0, weight = 0;
            if ((result[0][0] >= 65 && result[1][0] <= 90))
            {
                src = (result[0][0] - 65); dest = (result[1][0] - 65); weight = (int.Parse(result[2]));
                E++;
                if (visited[src] == false)
                {
                    V++;
                    visited[src] = true;
                }
            }
            else if ((result[0][0] >= 97 && result[1][0] <= 122))
            {
                src = (result[0][0] - 97); dest = (result[1][0] - 97); weight = (int.Parse(result[2]));
                E++;
                if (visited[src] == false)
                {
                    V++;
                    visited[src] = true;
                }
            }
            else return;
            queue.enqueue(src, dest, weight);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                search();
        }

        void createGraph()
        {
            Console.WriteLine("Number Of Vertices & Edges: {0} | {1}", V, E);
            graph = new Graph((V), (E + 1));
            for (int i = 0; i <= E; i++)
            {
                int src = queue.ele[queue.front].src;
                int dest = queue.ele[queue.front].dest;
                int weight = queue.ele[queue.front].weight;
                graph.edge[i].src = src; graph.edge[i].dest = dest; graph.edge[i].weight = weight;
                queue.dequeue();
            }
        }
    }
}
