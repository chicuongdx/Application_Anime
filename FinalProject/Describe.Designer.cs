
namespace FinalProject
{
    partial class Describe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSuggest = new Guna.UI2.WinForms.Guna2Panel();
            this.lbWatch = new System.Windows.Forms.Label();
            this.richTxtDescribe = new System.Windows.Forms.RichTextBox();
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pctImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GpBoxRandom = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnRandom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlDescribe = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSuggest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.GpBoxRandom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuggest
            // 
            this.pnlSuggest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSuggest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSuggest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSuggest.Controls.Add(this.lbWatch);
            this.pnlSuggest.Controls.Add(this.richTxtDescribe);
            this.pnlSuggest.Controls.Add(this.lbName);
            this.pnlSuggest.Controls.Add(this.pctImage);
            this.pnlSuggest.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlSuggest.Location = new System.Drawing.Point(2, 0);
            this.pnlSuggest.Name = "pnlSuggest";
            this.pnlSuggest.ShadowDecoration.Parent = this.pnlSuggest;
            this.pnlSuggest.Size = new System.Drawing.Size(590, 290);
            this.pnlSuggest.TabIndex = 0;
            // 
            // lbWatch
            // 
            this.lbWatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.lbWatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbWatch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWatch.Location = new System.Drawing.Point(25, 183);
            this.lbWatch.Name = "lbWatch";
            this.lbWatch.Size = new System.Drawing.Size(150, 28);
            this.lbWatch.TabIndex = 4;
            this.lbWatch.Text = "Xem phim";
            this.lbWatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWatch.Click += new System.EventHandler(this.lbWatch_Click);
            // 
            // richTxtDescribe
            // 
            this.richTxtDescribe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtDescribe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTxtDescribe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtDescribe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtDescribe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richTxtDescribe.Location = new System.Drawing.Point(180, 95);
            this.richTxtDescribe.Name = "richTxtDescribe";
            this.richTxtDescribe.Size = new System.Drawing.Size(387, 145);
            this.richTxtDescribe.TabIndex = 2;
            this.richTxtDescribe.Text = "";
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(231)))), ((int)(((byte)(69)))));
            this.lbName.Location = new System.Drawing.Point(181, 63);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 33);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // pctImage
            // 
            this.pctImage.BorderRadius = 5;
            this.pctImage.ImageRotate = 0F;
            this.pctImage.Location = new System.Drawing.Point(25, 40);
            this.pctImage.Name = "pctImage";
            this.pctImage.ShadowDecoration.Parent = this.pctImage;
            this.pctImage.Size = new System.Drawing.Size(150, 200);
            this.pctImage.TabIndex = 0;
            this.pctImage.TabStop = false;
            // 
            // GpBoxRandom
            // 
            this.GpBoxRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GpBoxRandom.BorderColor = System.Drawing.Color.Transparent;
            this.GpBoxRandom.BorderRadius = 10;
            this.GpBoxRandom.Controls.Add(this.btnRandom);
            this.GpBoxRandom.Controls.Add(this.guna2HtmlLabel1);
            this.GpBoxRandom.CustomBorderColor = System.Drawing.Color.Gray;
            this.GpBoxRandom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.GpBoxRandom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GpBoxRandom.ForeColor = System.Drawing.Color.White;
            this.GpBoxRandom.Location = new System.Drawing.Point(600, 9);
            this.GpBoxRandom.Name = "GpBoxRandom";
            this.GpBoxRandom.ShadowDecoration.Parent = this.GpBoxRandom;
            this.GpBoxRandom.Size = new System.Drawing.Size(290, 140);
            this.GpBoxRandom.TabIndex = 1;
            this.GpBoxRandom.Text = "Hôm nay xem gì?";
            // 
            // btnRandom
            // 
            this.btnRandom.BorderRadius = 5;
            this.btnRandom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnRandom.CheckedState.Parent = this.btnRandom;
            this.btnRandom.CustomImages.Parent = this.btnRandom;
            this.btnRandom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRandom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRandom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRandom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRandom.DisabledState.Parent = this.btnRandom;
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRandom.ForeColor = System.Drawing.Color.White;
            this.btnRandom.HoverState.Parent = this.btnRandom;
            this.btnRandom.Image = global::FinalProject.Properties.Resources.play;
            this.btnRandom.Location = new System.Drawing.Point(10, 93);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.ShadowDecoration.Parent = this.btnRandom;
            this.btnRandom.Size = new System.Drawing.Size(180, 38);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Xem anime ngẫu nhiên";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(133)))), ((int)(((byte)(156)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(10, 40);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(276, 47);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Nếu bạn buồn phiền không biết xem gì hôm nay. Hãy để chúng tôi chọn cho bạn.";
            // 
            // pnlDescribe
            // 
            this.pnlDescribe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDescribe.Location = new System.Drawing.Point(2, 293);
            this.pnlDescribe.Name = "pnlDescribe";
            this.pnlDescribe.ShadowDecoration.Parent = this.pnlDescribe;
            this.pnlDescribe.Size = new System.Drawing.Size(888, 181);
            this.pnlDescribe.TabIndex = 2;
            // 
            // Describe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 474);
            this.Controls.Add(this.pnlDescribe);
            this.Controls.Add(this.GpBoxRandom);
            this.Controls.Add(this.pnlSuggest);
            this.Name = "Describe";
            this.Text = "Describle";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Describe_Load);
            this.pnlSuggest.ResumeLayout(false);
            this.pnlSuggest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.GpBoxRandom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSuggest;
        private Guna.UI2.WinForms.Guna2GroupBox GpBoxRandom;
        private Guna.UI2.WinForms.Guna2Button btnRandom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel pnlDescribe;
        private Guna.UI2.WinForms.Guna2PictureBox pctImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private System.Windows.Forms.RichTextBox richTxtDescribe;
        private System.Windows.Forms.Label lbWatch;
    }
}