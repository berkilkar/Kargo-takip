namespace Kargo_takip
{
    partial class Frm_PerEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PerEkleme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPerCinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbpertc = new System.Windows.Forms.MaskedTextBox();
            this.txtpersoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtperad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnokey = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.mtbtel = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.mtbtel);
            this.groupBox1.Controls.Add(this.cmbPerCinsiyet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtbpertc);
            this.groupBox1.Controls.Add(this.txtpersoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtperad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(279, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL";
            // 
            // cmbPerCinsiyet
            // 
            this.cmbPerCinsiyet.FormattingEnabled = true;
            this.cmbPerCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbPerCinsiyet.Location = new System.Drawing.Point(112, 189);
            this.cmbPerCinsiyet.Name = "cmbPerCinsiyet";
            this.cmbPerCinsiyet.Size = new System.Drawing.Size(140, 32);
            this.cmbPerCinsiyet.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(26, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(66, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(27, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefon:";
            // 
            // mtbpertc
            // 
            this.mtbpertc.Location = new System.Drawing.Point(112, 118);
            this.mtbpertc.Mask = "00000000000";
            this.mtbpertc.Name = "mtbpertc";
            this.mtbpertc.Size = new System.Drawing.Size(140, 29);
            this.mtbpertc.TabIndex = 3;
            this.mtbpertc.ValidatingType = typeof(int);
            // 
            // txtpersoyad
            // 
            this.txtpersoyad.Location = new System.Drawing.Point(112, 83);
            this.txtpersoyad.Name = "txtpersoyad";
            this.txtpersoyad.Size = new System.Drawing.Size(140, 29);
            this.txtpersoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Soyad:";
            // 
            // txtperad
            // 
            this.txtperad.Location = new System.Drawing.Point(112, 48);
            this.txtperad.Name = "txtperad";
            this.txtperad.Size = new System.Drawing.Size(140, 29);
            this.txtperad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad:";
            // 
            // btnokey
            // 
            this.btnokey.BackColor = System.Drawing.Color.Transparent;
            this.btnokey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnokey.BackgroundImage")));
            this.btnokey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnokey.Location = new System.Drawing.Point(28, 176);
            this.btnokey.Name = "btnokey";
            this.btnokey.Size = new System.Drawing.Size(116, 63);
            this.btnokey.TabIndex = 30;
            this.btnokey.UseVisualStyleBackColor = false;
            this.btnokey.Click += new System.EventHandler(this.btnokey_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Location = new System.Drawing.Point(150, 176);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(113, 63);
            this.btnexit.TabIndex = 33;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // mtbtel
            // 
            this.mtbtel.Location = new System.Drawing.Point(112, 153);
            this.mtbtel.Mask = "0000000000";
            this.mtbtel.Name = "mtbtel";
            this.mtbtel.Size = new System.Drawing.Size(140, 29);
            this.mtbtel.TabIndex = 20;
            this.mtbtel.ValidatingType = typeof(int);
            // 
            // Frm_PerEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(614, 273);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnokey);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_PerEkleme";
            this.Text = "PERSONEL EKLE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbpertc;
        private System.Windows.Forms.TextBox txtpersoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtperad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnokey;
        private System.Windows.Forms.ComboBox cmbPerCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.MaskedTextBox mtbtel;
    }
}