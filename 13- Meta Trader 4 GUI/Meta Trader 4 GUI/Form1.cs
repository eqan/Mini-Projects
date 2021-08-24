using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Meta_Trader_4_GUI
{
    public partial class MetaTraderBotInstaller : Form
    {
        // Sets the default directory where to put the files 
        DirectoryInfo di;
        // Stores the list of all directories of the different meta trader versions
        DirectoryInfo[] diArr;
        public MetaTraderBotInstaller()
        {
            InitializeComponent();
            Add_Directory_Names_For_MetaTraderVersions_To_DropDown_Menu();
        }

        /***
         * @Procedure for Add_Directory_Names_For_MetaTraderVersions_To_DropDown_Menu function
         * Find all versions of the metatrader
         * Check for all the possible usable metatrader directories
         * Check if a name of the metatrader exists
         * Add the that name and version of the metatrader to the drop down
         * else add just the metatrader version
        * **/
        public void Add_Directory_Names_For_MetaTraderVersions_To_DropDown_Menu()
        {
            try
            {
                di = new DirectoryInfo(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + @"\Users\" + Environment.UserName + @"\AppData\Roaming\MetaQuotes\Terminal\");
                diArr = di.GetDirectories();
                foreach (DirectoryInfo dri in diArr)
                {
                    if (dri.Name != "Help" && dri.Name != "Common" && dri.Name != "Community")
                    {
                        if (File.Exists(dri.FullName + @"\origin.txt"))
                        {
                            string line1 = File.ReadLines(dri.FullName + @"\origin.txt").First();
                            string[] arr = line1.Split('\\');
                            metaTraderVersionList.Items.Add(arr[arr.Length - 1] + " | Version: " + dri.Name);
                        }
                        else
                            metaTraderVersionList.Items.Add("Unknown Trader | Version: " + dri.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Metatrader not found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void Copt_Files_ButtonClick(object sender, EventArgs e)
        {
            Copy_Files(new string[] { "bot.txt", "bot2.txt" }, "Indicators");
        }

        // @Parameters
        // fileNames is a string array where the files names to be copied are storesd
        // folder is a string where the destination folder is stored
        private void Copy_Files(string[] fileNames, string folder)
        {
            if (metaTraderVersionList.SelectedItem.ToString() != "")
            {
                try
                {
                    string targetPath = di.ToString() + metaTraderVersionList.SelectedItem.ToString() + @"\MQL4\" + folder + @"\";
                    foreach (string file in fileNames)
                    {
                        FileInfo fileInfo = new FileInfo(Environment.CurrentDirectory + @"\" + file);
                        File.Copy(fileInfo.FullName, targetPath + fileInfo.Name, true);
                    }
                    MessageBox.Show("Bot Successfully Installed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Path doesn't exist or is invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
