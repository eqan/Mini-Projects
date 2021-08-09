using System;
using System.Windows.Forms;
using System.IO;

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

        // Find all versions of the metatrader and add them into the drop down
        public void Add_Directory_Names_For_MetaTraderVersions_To_DropDown_Menu()
        {
            try
            {
                di = new DirectoryInfo(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + @"\Users\" + Environment.UserName + @"\AppData\Roaming\MetaQuotes\Terminal\");
                diArr = di.GetDirectories();
                foreach (DirectoryInfo dri in diArr)
                {
                	if(dri.Name != "Help" && dr.Name != "C.." && dr.Name != "C..")
	                    metaTraderVersionList.Items.Add(dri.Name);
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
