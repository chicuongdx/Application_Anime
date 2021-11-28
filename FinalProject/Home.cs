using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace FinalProject
{
    public partial class Home : Form
    {

        private Form activeForm;
        public Home()
        {
            InitializeComponent();
            Load_Data(DataFrame.DataSet);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        Size original;
        private void Home_Load(object sender, EventArgs e)
        {
            original = this.Size;
        }
        private void pnlTile_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
                if (this.Location.Y <= 0)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.Size = original;
                }

                // Drag to side to split screen
                if (this.Location.X <= 0)
                {
                    this.Location = new Point(0, 0);
                    this.Size = new Size(SystemInformation.WorkingArea.Width / 2, SystemInformation.WorkingArea.Height);
                }
                else if (this.Location.X >= SystemInformation.WorkingArea.Width / 2)
                {
                    this.Location = new Point(SystemInformation.WorkingArea.Width / 2, 0);
                    this.Size = new Size(SystemInformation.WorkingArea.Width / 2, SystemInformation.WorkingArea.Height);
                }
                else
                {
                    this.Size = original;
                }
            }
        }

        private void pnlTile_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Load_Data(DataTable table)
        {
            foreach(DataRow row in table.Rows)
            {
                Film film = new Film();
                film.lbName.Text = row["Name"].ToString();
                film.lbView.Text = row["View"].ToString();
                string path = Application.StartupPath + "\\Video\\" + row["Name"].ToString() + "\\image.jfif";
                Image img = Image.FromFile(path);
                film.pctImage.BackgroundImage = img;
                flownlListFilm.Controls.Add(film);

                film.PictureBoxClick += Film_Click;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlAnime.Controls.Add(childForm);
            this.pnlAnime.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Film_Click(object sender, EventArgs e)
        {
            Film film = (Film)sender;
            string s = "Name='" + film.lbName.Text + "'";
            DataRow row = DataFrame.DataSet.Select(s)[0];
            OpenChildForm(new Describe(row));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BringToFront();
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
    }
}
