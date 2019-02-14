using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netbioRDTx
{
    public partial class Frm_Main : Form
    {
        public struct RDT_Header_Obj
        {
            public int Offset;
            public int Size;
        }

        ///////////////////////////////////////////////////////////////////////////////
        //GLOBAL!
        ///////////////////////////////////////////////////////////////////////////////
        public RDT_Header_Obj[] H_RDT = new RDT_Header_Obj[32];
        public string G_RDT_NAME = "";
        public string G_RDT = "";

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //Check if RDT dir exists, if not create it!
            string tmp_dir = Path.GetDirectoryName(Application.ExecutablePath) + @"\RDT";

            if (Directory.Exists(tmp_dir) == false)
            {
                Directory.CreateDirectory(tmp_dir);
            }
        }

        private void M_FILE_OPEN_Click(object sender, EventArgs e)
        {
            OPEN_RDT();
        }
        private void M_FILE_EXTRACT_Click(object sender, EventArgs e)
        {
            string tmp_dir = Path.GetDirectoryName(Application.ExecutablePath) + @"\RDT\" + G_RDT_NAME;

            if (Directory.Exists(tmp_dir) == false)
            {
                Directory.CreateDirectory(tmp_dir);
            }
            EXTRACT_RDT(tmp_dir, LBL_RDT_NAME.Text);
        }
        private void M_FILE_REBUILD_Click(object sender, EventArgs e)
        {
            string tmp_dir = "";

            DLG_FOLDER.ShowDialog();
            tmp_dir = DLG_FOLDER.SelectedPath;

            if (tmp_dir.Length > 15)
            {
                G_RDT = DLG_FOLDER.SelectedPath.Substring(tmp_dir.Length - 8, 8);
                REBUILD_RDT(tmp_dir, Path.GetDirectoryName(Application.ExecutablePath) + @"\RDT\" + G_RDT + ".RDT");
            }
            else
            {
                ;
            }
        }
        private void M_FILE_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void M_TOOLS_CLEAR_LOG_Click(object sender, EventArgs e)
        {
            LST_LOG.Items.Clear();
        }
        private void M_HELP_ABOUT_Click(object sender, EventArgs e)
        {
            Frm_Dlg_About newfrm = new Frm_Dlg_About();
            newfrm.Show();
        }
        private void BTN_FILE_OPEN_Click(object sender, EventArgs e)
        {
            OPEN_RDT();
        }
        private void BTN_FILE_EXTRACT_Click(object sender, EventArgs e)
        {
            string tmp_dir = Path.GetDirectoryName(Application.ExecutablePath) + @"\RDT\" + G_RDT_NAME;

            if (Directory.Exists(tmp_dir) == false)
            {
                Directory.CreateDirectory(tmp_dir);
            }
            EXTRACT_RDT(tmp_dir, LBL_RDT_NAME.Text);
        }
        private void BTN_FILE_REBUILD_Click(object sender, EventArgs e)
        {
            string tmp_dir = "";

            DLG_FOLDER.ShowDialog();
            tmp_dir = DLG_FOLDER.SelectedPath;

            if(tmp_dir.Length > 15)
            {   
                G_RDT = DLG_FOLDER.SelectedPath.Substring(tmp_dir.Length - 8, 8);
                REBUILD_RDT(tmp_dir, Path.GetDirectoryName(Application.ExecutablePath) + @"\RDT\" + G_RDT + ".RDT");
            }
            else
            {
                ;
            }
            
        }
        private void BTN_WIP_FOLDER_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(Application.ExecutablePath) + @"\RDT");
        }
        private void BTN_CLEAR_LOG_Click(object sender, EventArgs e)
        {
            LST_LOG.Items.Clear();
        }

        private void OPEN_RDT()
        {
            string filename = "";

            DLG_FILE_OPEN.ShowDialog();
            filename = DLG_FILE_OPEN.FileName;
 
            if (File.Exists(filename))
            {
                this.Text = "NetBioRDTx - " + DLG_FILE_OPEN.SafeFileName;
                G_RDT_NAME = DLG_FILE_OPEN.SafeFileName.Substring(0, DLG_FILE_OPEN.SafeFileName.Length - 4);
                READ_RDT_HEADER(filename);
            }
        }

        private void READ_RDT_HEADER(string sFile)
        {
            FileStream fs = new FileStream(sFile, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            //Clear listview
            LST_TOC.Items.Clear();

            LST_LOG.Items.Add(">> Opened file " + sFile);
            LBL_PROGRESS.Text = "Reading Header...";

            int obj_cnt = 0;

            //Read header...
            for (int i = 0; i < H_RDT.Length; i++)
            {
                H_RDT[i].Offset = br.ReadInt32();
                H_RDT[i].Size = br.ReadInt32();

                if (H_RDT[i].Offset != fs.Length && H_RDT[i].Size > 0)
                {
                    LST_TOC.Items.Add(i.ToString());
                    LST_TOC.Items[i].ForeColor = Color.Blue;
                    LST_TOC.Items[i].SubItems.Add(H_RDT[i].Offset.ToString());
                    LST_TOC.Items[i].SubItems.Add(H_RDT[i].Size.ToString());
                    
                    if (i == 0) { LST_TOC.Items[i].SubItems.Add("CAM"); }
                    if (i == 2 || i == 3) { LST_TOC.Items[i].SubItems.Add("SND"); }
                    if (i == 10) { LST_TOC.Items[i].SubItems.Add("AOT"); }

                    obj_cnt += 1;
                }
                else
                {
                    LST_TOC.Items.Add(i.ToString());
                    LST_TOC.Items[i].ForeColor = Color.LightGray;
                    LST_TOC.Items[i].SubItems.Add(H_RDT[i].Offset.ToString());
                    LST_TOC.Items[i].SubItems.Add(H_RDT[i].Size.ToString());
                    LST_TOC.Items[i].SubItems.Add("no data");
                }
                LBL_RDT_NAME.Text = sFile;
                LBL_RDT_SIZE.Text = fs.Length.ToString();
                M_FILE_EXTRACT.Enabled = true;
                BTN_FILE_EXTRACT.Enabled = true;
                this.Text = "NetBioRDTx - " + LBL_RDT_NAME.Text.Substring(LBL_RDT_NAME.Text.Length - 12, 8);
            }
            br.Close();
            LBL_PROGRESS.Text = "Idle";
        }

        private void EXTRACT_RDT(string tFolder, string sFile)
        {
            FileStream fs = new FileStream(sFile, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            byte[] tmp_arr = new byte[0];

            //Update log...
            LST_LOG.Items.Add("===============================================================================");
            LST_LOG.Items.Add("Extracting... [..\\RDT\\" + G_RDT_NAME + "]");
            LST_LOG.Items.Add("===============================================================================");
            LBL_PROGRESS.Text = "Extracting...";

            //Extract files...
            for (int i = 0; i < H_RDT.Length; i++)
            {
                if (H_RDT[i].Size > 0)
                {
                    fs.Seek(H_RDT[i].Offset, SeekOrigin.Begin);
                    Array.Resize(ref tmp_arr, H_RDT[i].Size);

                    LBL_PROGRESS.Text = "Extracting file " + i.ToString().PadLeft(2, '0');
                    LST_LOG.Items.Add((i.ToString().PadLeft(2, '0')) + "\tOffset: " + H_RDT[i].Offset.ToString() + "\tSize: " + H_RDT[i].Size.ToString());

                    tmp_arr = br.ReadBytes(H_RDT[i].Size);
                    DUMP_FILE(tFolder + @"\" + i.ToString().PadLeft(2, '0') + "_" + G_RDT_NAME + ".BIN", tmp_arr);
                }
            }

            br.Close();
            
            LST_LOG.Items.Add("===============================================================================");
            LST_LOG.Items.Add(">> Done!");
            LBL_PROGRESS.Text = "Idle";
        }

        private void REBUILD_RDT(string sFolder, string tFile)
        {
            //If file exists already, kill it!
            if (File.Exists(tFile)) { File.Delete(tFile); }

            FileStream fs = new FileStream(tFile, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);

            byte[] tmp_arr = new byte[0];

            //Update log...
            LST_LOG.Items.Add("===============================================================================");
            LST_LOG.Items.Add("Rebuilding... [..\\RDT\\" + G_RDT + "]");
            LST_LOG.Items.Add("===============================================================================");
            LBL_PROGRESS.Text = "Rebuilding...";

            fs.Seek(256, SeekOrigin.Begin);

            //Extract files...
            for (int i = 0; i < H_RDT.Length; i++)
            {

                if(File.Exists(sFolder + "\\" + @"\" + i.ToString().PadLeft(2, '0') + "_" + G_RDT + ".BIN"))
                {
                    H_RDT[i].Size = GRAB_FILE(sFolder + "\\" + @"\" + i.ToString().PadLeft(2, '0') + "_" + G_RDT + ".BIN").Length;
                    H_RDT[i].Offset = Convert.ToInt32(fs.Position);

                    tmp_arr = GRAB_FILE(sFolder + "\\" + @"\" + i.ToString().PadLeft(2, '0') + "_" + G_RDT + ".BIN");

                    bw.Write(tmp_arr);
                }
                else
                {
                    H_RDT[i].Size = 0;
                    H_RDT[i].Offset = Convert.ToInt32(fs.Position);
                }

                LBL_PROGRESS.Text = "Rebuilding file " + i.ToString().PadLeft(2, '0');
                LST_LOG.Items.Add((i.ToString().PadLeft(2, '0')) + "\tOffset: " + H_RDT[i].Offset.ToString() + "\tSize: " + H_RDT[i].Size.ToString());

            }

            fs.Seek(0, SeekOrigin.Begin);

            for (int i = 0; i < H_RDT.Length; i++)
            {
                bw.Write(H_RDT[i].Offset);
                bw.Write(H_RDT[i].Size);
            }

            bw.Close();

            LST_LOG.Items.Add("===============================================================================");
            LST_LOG.Items.Add(">> Done!");
            LBL_PROGRESS.Text = "Idle";

            MessageBox.Show(tFile + "\n\nhas been rebuild!","Done!");

            READ_RDT_HEADER(tFile);

        }

        private void DUMP_FILE(string sFILE, byte[] tmp_arr)
        {
            if (File.Exists(sFILE))
            {
                File.Delete(sFILE);
            }

            FileStream fs = new FileStream(sFILE, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(tmp_arr);
            bw.Close();
        }

        private byte[] GRAB_FILE(string sFILE)
        {
            FileStream fs = new FileStream(sFILE, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            byte[] tmp_arr = new byte[fs.Length];

            tmp_arr = br.ReadBytes(Convert.ToInt32(fs.Length));

            br.Close();
            return tmp_arr;

        }

        private void M_FILE_SHOW_WIP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(Application.ExecutablePath) + @"\RDT");
        }















    }
}
