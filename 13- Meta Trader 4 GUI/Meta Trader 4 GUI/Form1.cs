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

        private void Copy_Files_ButtonClick(object sender, EventArgs e)
        {
            Copy_Files("Eqan Expert", "Experts");
            Copy_Files(new string[] { "MQLTA MT4 Supertrend Line.ex4", "MQLTA MT4 Supertrend Multi-Timeframe.ex4" }, "Indicators");
        }

        // @Method 1
        // Copies a folder along with its files and subdirectories to the destination
        // @Parameters
        // copyFoler is the name of the folder to be copied
        // destinatioFolder is the destination where it is to be copied
        // example      Copy_Files("Eqan Expert", "Experts");
        private void Copy_Files(string copyFolder, string destinationFolder)
        {
            try
            {
                string targetPath = di.ToString().Remove(3, 1) + Return_Meta_Trader_Name() + @"\MQL4\" + destinationFolder + @"\" + copyFolder;
                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                    Copy_All_Files_And_Subdirectories(Environment.CurrentDirectory + @"\"+ copyFolder + @"\", targetPath);
                    MessageBox.Show("Bot Successfully Installed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Path doesn't exist or is invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // @Method 2
        // Copies only files to a specific folder
        // @Parameters
        // fileNames is a string array where the files names to be copied are stored
        // destinationFolder is a string where the destination folder is stored
        // example  Copy_Files(new string[] { "MQLTA MT4 Supertrend Line.ex4", "MQLTA MT4 Supertrend Multi-Timeframe.ex4" }, "Indicators");
        private void Copy_Files(string[] fileNames, string destinationFoler)
        {
            if (metaTraderVersionList.SelectedItem.ToString() != "")
            {
                try
                {
                    string targetPath = di.ToString().Remove(3, 1) + Return_Meta_Trader_Name() + @"\MQL4\" + destinationFoler + @"\";
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

        // Discards unnecessary information and returns the actual metatrader version name
        private string Return_Meta_Trader_Name()
        {
            string[] fileName = (metaTraderVersionList.SelectedItem.ToString()).Split(':');
            return (fileName[fileName.Length - 1].Substring(1));
        }

        // Copies all files from source diretory to target directory
        void Copy_All_Files_And_Subdirectories(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)));

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy_All_Files_And_Subdirectories(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
        }
    }
}
