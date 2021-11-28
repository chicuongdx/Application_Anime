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

namespace FinalProject
{
    public partial class Describe : Form
    {
        DataRow row;
        private Form activeForm;
        public Describe(DataRow dr)
        {
            InitializeComponent();
            row = dr;
        }

        private void Describe_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private Image Reszie_Image(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, size);
            return (Image)bm;
        }
        private void Load_Image()
        {
            Image img = Image.FromFile(Application.StartupPath + "\\Video\\" + row["Name"].ToString() + "\\image.jfif");
            Image resized = Reszie_Image(img, new Size(pctImage.Width, pctImage.Height));
            pctImage.Image = resized;
        }
        private void Load_Name()
        {
            lbName.Text = row["Name"].ToString();
            string path = Application.StartupPath + "\\Video\\" + row["Name"].ToString() + "\\described.txt";
            string s = File.ReadAllText(path);
            richTxtDescribe.Text = s;
        }
        private void Load_Data()
        {
            Load_Image();
            Load_Name();
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void lbWatch_Click(object sender, EventArgs e)
        {
            WatchFilm showFilm = new WatchFilm(row);
            OpenChildForm(showFilm);
        }
    }
}
