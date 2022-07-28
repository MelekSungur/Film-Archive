namespace Film_Archive
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNEKLE = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTFILMAD = new System.Windows.Forms.TextBox();
            this.TXTKATAGORI = new System.Windows.Forms.TextBox();
            this.TXTLINK = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BTNTAMEKRAN = new System.Windows.Forms.Button();
            this.BTNHAKKINDA = new System.Windows.Forms.Button();
            this.BTNRENKDEGIS = new System.Windows.Forms.Button();
            this.BTNCIKIS = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 112);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(221, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 386);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MOVIELIST";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(417, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 386);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SCREEN";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 22);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(447, 361);
            this.webBrowser1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(643, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTNEKLE
            // 
            this.BTNEKLE.Location = new System.Drawing.Point(97, 159);
            this.BTNEKLE.Name = "BTNEKLE";
            this.BTNEKLE.Size = new System.Drawing.Size(119, 26);
            this.BTNEKLE.TabIndex = 0;
            this.BTNEKLE.Text = "ADD NEW MOVİE";
            this.BTNEKLE.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.TXTLINK);
            this.groupBox3.Controls.Add(this.TXTKATAGORI);
            this.groupBox3.Controls.Add(this.TXTFILMAD);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.BTNEKLE);
            this.groupBox3.Location = new System.Drawing.Point(-1, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 383);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ADD NEW MOVİE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "MOVIE NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "CATAGORY:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "LINK:";
            // 
            // TXTFILMAD
            // 
            this.TXTFILMAD.Location = new System.Drawing.Point(97, 27);
            this.TXTFILMAD.Name = "TXTFILMAD";
            this.TXTFILMAD.Size = new System.Drawing.Size(119, 26);
            this.TXTFILMAD.TabIndex = 7;
            // 
            // TXTKATAGORI
            // 
            this.TXTKATAGORI.Location = new System.Drawing.Point(97, 73);
            this.TXTKATAGORI.Name = "TXTKATAGORI";
            this.TXTKATAGORI.Size = new System.Drawing.Size(119, 26);
            this.TXTKATAGORI.TabIndex = 8;
            // 
            // TXTLINK
            // 
            this.TXTLINK.Location = new System.Drawing.Point(97, 116);
            this.TXTLINK.Name = "TXTLINK";
            this.TXTLINK.Size = new System.Drawing.Size(119, 26);
            this.TXTLINK.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BTNCIKIS);
            this.groupBox4.Controls.Add(this.BTNRENKDEGIS);
            this.groupBox4.Controls.Add(this.BTNHAKKINDA);
            this.groupBox4.Controls.Add(this.BTNTAMEKRAN);
            this.groupBox4.Location = new System.Drawing.Point(9, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 163);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // BTNTAMEKRAN
            // 
            this.BTNTAMEKRAN.Location = new System.Drawing.Point(3, 22);
            this.BTNTAMEKRAN.Name = "BTNTAMEKRAN";
            this.BTNTAMEKRAN.Size = new System.Drawing.Size(191, 29);
            this.BTNTAMEKRAN.TabIndex = 0;
            this.BTNTAMEKRAN.Text = "FULL SCREEN";
            this.BTNTAMEKRAN.UseVisualStyleBackColor = true;
            // 
            // BTNHAKKINDA
            // 
            this.BTNHAKKINDA.Location = new System.Drawing.Point(3, 57);
            this.BTNHAKKINDA.Name = "BTNHAKKINDA";
            this.BTNHAKKINDA.Size = new System.Drawing.Size(191, 29);
            this.BTNHAKKINDA.TabIndex = 1;
            this.BTNHAKKINDA.Text = "ABOUT US";
            this.BTNHAKKINDA.UseVisualStyleBackColor = true;
            // 
            // BTNRENKDEGIS
            // 
            this.BTNRENKDEGIS.Location = new System.Drawing.Point(0, 92);
            this.BTNRENKDEGIS.Name = "BTNRENKDEGIS";
            this.BTNRENKDEGIS.Size = new System.Drawing.Size(191, 29);
            this.BTNRENKDEGIS.TabIndex = 1;
            this.BTNRENKDEGIS.Text = "CHANGE COLOR";
            this.BTNRENKDEGIS.UseVisualStyleBackColor = true;
            // 
            // BTNCIKIS
            // 
            this.BTNCIKIS.Location = new System.Drawing.Point(0, 127);
            this.BTNCIKIS.Name = "BTNCIKIS";
            this.BTNCIKIS.Size = new System.Drawing.Size(191, 29);
            this.BTNCIKIS.TabIndex = 2;
            this.BTNCIKIS.Text = "EXİT";
            this.BTNCIKIS.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(184, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(531, 58);
            this.label4.TabIndex = 1;
            this.label4.Text = "SUNGUR MOVİE  LİST";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNEKLE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BTNCIKIS;
        private System.Windows.Forms.Button BTNRENKDEGIS;
        private System.Windows.Forms.Button BTNHAKKINDA;
        private System.Windows.Forms.Button BTNTAMEKRAN;
        private System.Windows.Forms.TextBox TXTLINK;
        private System.Windows.Forms.TextBox TXTKATAGORI;
        private System.Windows.Forms.TextBox TXTFILMAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

