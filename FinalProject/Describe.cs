using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace FinalProject
{
    public partial class Describe : Form
    {
        DataRow row;
        public Describe(DataRow dr)
        {
            InitializeComponent();
            row = dr;
        }

        private void Describe_Load(object sender, EventArgs e)
        {
            Load_Data();
            Load_Comment();
            //curUser
            try
            {
                string path_avatar = Application.StartupPath + "\\User\\" + UserData.currentUsername + ".jfif";
                pctAvatar.Image = cv2.resize(cv2.imread(path_avatar), new Size(pctAvatar.Width, pctAvatar.Height));
            }
            catch
            {
                pctAvatar.Image = cv2.resize(Properties.Resources.avarta, new Size(pctAvatar.Width, pctAvatar.Height));
            }
            lbUserName.Text = UserData.currentUsername;
        }

        private void Describe_ClientSizeChanged(object sender, EventArgs e)
        {
            Load_Data();
        }


        private void Load_Image()
        {
            Image preview;
            Image img = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image.jfif");
            try
            {
                preview = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\preview.jfif");
            }
            catch
            {
                preview = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image.jfif");
            }
            preview = cv2.resize_width(preview, pnlPreview.Width);
            pnlPreview.BackgroundImage = preview;
            Image resized = cv2.resize(img, new Size(pctImage.Width, pctImage.Height));
            pctImage.Image = resized;
        }
        private void Load_Name()
        {
            lbName.Text = row["Name"].ToString();
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Describe.txt";
            string s = File.ReadAllText(path);
            lbDescribe.Text = s;

            lbType.Text = row["Type"].ToString();
            lbDirector.Text = row["Director"].ToString();
            lbStudio.Text = row["Studio"].ToString();
            lbSeason.Text = row["Season"].ToString();
            lbView.Text = string.Format("{0:N}", Convert.ToInt32(row["View"])).Replace(".00", "");
            lbNumEp.Text = row["NumEp"].ToString() + " Tập";
            lbNumEp.Text = row["NumMovie"].ToString() + " Tập";
        }
        private void Load_Data()
        {
            Load_Image();
            Load_Name();
        }

        private void lbWatch_Click(object sender, EventArgs e)
        {
            int idx = DataFrame.DataSet.Rows.IndexOf(row);
            int view = Convert.ToInt32(row["View"]) + 1;

            DataFrame.DataSet.Rows[idx]["View"] = view;

            WatchFilm showFilm = new WatchFilm(row);
            showFilm.Show();
        }
        //comments film
        private void Load_Comment()
        {
            //load comment
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Comments.txt";
            if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine();
                }
            }
            List<string> data = File.ReadAllLines(path).OfType<string>().ToList(); ;
            data.Reverse();
            foreach (var line in data)
            {
                if (line != "")
                {
                    try
                    {
                        Comment cmt = new Comment(line)
                        {
                            Dock = DockStyle.Top,
                        };
                        this.Controls.Add(cmt);
                        cmt.BringToFront();
                    }
                    catch { }
                }
            }
        }

        private void ResetCmt()
        {
            foreach(Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Comment))
                {
                    ctrl.Hide();
                }
            }
        }

        private void txtWriteCmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Comments.txt";
                string data = "{\"username\": \"" + lbUserName.Text + "\", \"cmt\": \"" + txtWriteCmt.Text + "\"}";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(data);
                }
                ResetCmt();
                Load_Comment();
                txtWriteCmt.Text = "";
            }
        }
    }
}
