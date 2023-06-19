using MySql.Data.MySqlClient;
using Renci.SshNet;
using Renci.SshNet.Security;
using Renci.SshNet.Sftp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FTP_Disable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string ftpUrl = "ftp://example.com/path/to/file.txt";
        string privateKeyPath = @"C:\path\to\private\key";
        string ftpUsername = "Username";
        TimeSpan upDateTime = DateTime.Now.TimeOfDay;
        string ftpPassword = "Password";
        int FTP_port = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            clsSetting.AppSettings Parm = clsSetting.LoadSettings("Setting.xml");
            ftpUrl = Parm.HostName ;
            textBoxFTPUrl.Text = ftpUrl;

            ftpUsername = Parm.UserName ;
            textBoxUser.Text = ftpUsername;

            privateKeyPath = Parm.privateKeyPath;
            textBoxFilePath.Text = privateKeyPath;

            chkKey.Checked =Parm.isPK ;
            dateTimePicker1.Text = Parm.UpdateTime;
            upDateTime = dateTimePicker1.Value.TimeOfDay;
            chkAuto.Checked = Parm.isAutoUpdate;

            ftpPassword = Parm.password;
            FTP_port = Parm.FTP_Port;
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                // 使用 filePath 進行相關操作
                if(filePath != "")
                {
                    textBoxFilePath.Text = filePath;
                }
            }

        }

        private void chkKey_CheckedChanged(object sender, EventArgs e)
        {
            if(chkKey.Checked)
            {
                btnPath.Visible = true;
                textBoxFilePath.Visible = true;
            }
            else
            {
                btnPath.Visible = false;
                textBoxFilePath.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAuto.Checked)
            {
                dateTimePicker1.Visible = true;
            }
            else
            {
                dateTimePicker1.Visible = false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ftpUrl = textBoxFTPUrl.Text;
            ftpUsername = textBoxUser.Text;
            privateKeyPath = textBoxFilePath.Text;
            upDateTime = dateTimePicker1.Value.TimeOfDay;
            SFTP();


        }

        private void SFTP()
        {
            ShowInfo("更新中....");
            //var privateKey = new PrivateKeyFile(File.OpenRead(privateKeyPath));
            //var connectionInfo = new ConnectionInfo(ftpUrl, ftpUsername, new PrivateKeyAuthenticationMethod(ftpUsername, privateKey));

            using (var client = new SftpClient(ftpUrl, FTP_port, ftpUsername, ftpPassword))
            {
                client.Connect();
                ShowInfo("SFTP 連線成功.");
                //查最新檔案


                var latestFile = GetLatestFile(client, "/list/");

                if (latestFile != null)
                {
                    string strDownFile = latestFile.Name;
                    ShowInfo("SFTP 下載檔案 " + strDownFile);
                    // Download

                    try
                    {
                        using (var fileStream = File.Create(strDownFile))
                        {

                            client.DownloadFile("/list/" + strDownFile, fileStream);
                            fileStream.Close();


                            Analysis(latestFile.Name);
                            if (File.Exists(strDownFile))
                            {
                                File.Delete(strDownFile);
                            }

                            UpdataDB();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
                else
                {

                    //查無檔案
                    ShowInfo("更新....失敗.");
                    
                }
                client.Disconnect();
                ShowInfo("更新完成.");
                
            }
        }
        private static SftpFile GetLatestFile(SftpClient client, string remotePath)
        {
            var latestFile = (SftpFile)null;
            var latestTime = DateTime.MinValue;


            foreach (var file in client.ListDirectory(remotePath))
            {
                if (!file.IsDirectory)
                {
                    if (file.LastWriteTime > latestTime)
                    {
                        latestFile = file;
                        latestTime = file.LastWriteTime;
                    }
                }
            }

            return latestFile;
        }
 
        private void btnSave_Click(object sender, EventArgs e)
        {
            ftpUrl = textBoxFTPUrl.Text;
            ftpUsername = textBoxUser.Text;
            privateKeyPath = textBoxFilePath.Text;
            upDateTime = dateTimePicker1.Value.TimeOfDay;

            clsSetting.AppSettings Parm = new clsSetting.AppSettings();
            Parm.HostName = ftpUrl;
            Parm.UserName = ftpUsername;
            Parm.privateKeyPath = privateKeyPath;
            Parm.isPK = chkKey.Checked;
            Parm.UpdateTime = dateTimePicker1.Text;
            Parm.isAutoUpdate = chkAuto.Checked;

            clsSetting.SaveSettings(Parm, "Setting.xml");

        }

        private void AutoTimer_Tick(object sender, EventArgs e)
        {
            if (chkAuto.Checked)
            {
                AutoTimer.Enabled = false;
                TimeSpan curTime = DateTime.Now.TimeOfDay;

                string T1 = string.Format("{0:00}:{1:00}", (int)curTime.TotalHours, curTime.TotalMinutes % 60);
                string T2 = string.Format("{0:00}:{1:00}", (int)upDateTime.TotalHours, upDateTime.TotalMinutes % 60);
                // MessageBox.Show(T1 + T2);
                if (T1 == T2)
                {
                    SFTP();
                }
                AutoTimer.Enabled = true;
            }
        }
        private void ShowInfo(String strMsg)
        {
            string str = DateTime.Now.ToString() + "：" + strMsg + "\r\n";
            string str2 = str + textBoxConnectMsg.Text.Trim();
            string strValue = str2.Substring(0,  str2.Length > 5000 ? 5000:str2.Length -1);
            textBoxConnectMsg.Text = strValue;
            Application.DoEvents();
        }


        List<string> liData = new List<string>();
        private void Analysis(String strFile)
        {
            liData.Clear();

            StreamReader reader = new StreamReader(strFile);
            string strItem = "";
            string strSQL;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Contains("-"))
                {
                    string[] parts = line.Split(',');
                    //parts[0] = parts[0].Replace("-", "");
                    parts[1] = parts[1].Replace("-", "");
                    parts[2] = (int.Parse(parts[2].Substring(0, 4)) - 1911).ToString() + parts[2].Substring(4);

                    string strCar = $"('{parts[1]}','{parts[2]}','{parts[3]}')";  //('9622XY','1111231','1')
                    if (strItem.Length > 2000) 
                    {
                        strSQL = "INSERT INTO `disable` VALUES " + strItem;
                        liData.Add(strSQL);
                        //MessageBox.Show(strSQL);
                        strItem = "";
                    }
                    if (strItem.Length == 0)
                    {
                        strItem = strCar;
                    }else
                    {
                        strItem = strItem + "," + strCar;
                    }

                    //string strDate = parts[1];
                    //string str = "('" + strCar + "','" + strDate + "')";

                    //int y = int.Parse(strDate.Substring(0, 3)) + 1911;
                    //strDate = y + strDate.Substring(3, 4);
                    //ShowInfo("車牌:" + strCar + " 有效日期:" + strDate);
                    //Application.DoEvents();
                    //writeDB(strCar, strDate);
                }
            }
            strSQL = "INSERT INTO `disable` VALUES " + strItem;
            liData.Add((strSQL));
            reader.Close();

        }
        private void UpdataDB()
        {
            if (liData.Count == 0) { return; }

            ShowInfo("資料庫更新....");
            clsSetting.ParkingLots park = clsSetting.LoadDB("disableTable.xml");
            foreach (clsSetting.ParkingLot db in park.Park)
            {
                ShowInfo("連線資料庫：" + db.url );
                string strConnection = "server=" + db.url + ";port=" + db.port  + ";uid=" + db.user  + ";password=" + db.pass  + ";database=" + db.database;

                MySqlConnection con = new MySqlConnection();
                if (MySql_Open(con, strConnection))
                {
                    ClearTable(con);
                    foreach (string query in liData)
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand(query, con);
                            command.ExecuteNonQuery();
                        }catch
                        {
                            ShowInfo("資料寫入失敗 ");
                        }
                    }
                    MySql_Close(con);
                }
            }

            ShowInfo("資料庫更新完成");
        }

        private bool MySql_Open(MySqlConnection con, string strConnection)
        {
            try
            {
                con.ConnectionString = strConnection;
                con.Open();
            }
            catch
            {
                ShowInfo("資料連線失敗 ");
                return false;
            }

            return con.State == ConnectionState.Open;
        }
        private void MySql_Close(MySqlConnection con)
        {
            con.Close();
        }
        private void ClearTable(MySqlConnection con)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("Delete FROM  disable", con);
                command.ExecuteNonQuery();
            }
            catch 
            {
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Analysis("C:\\Users\\ZYT20230329\\Desktop\\parking.csv");
            UpdataDB();
        }
    }
}
