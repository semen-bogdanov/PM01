﻿namespace Cclearpro
{
    partial class login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btminis = new System.Windows.Forms.Label();
            this.btcloses = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.btsavename = new System.Windows.Forms.Button();
            this.btrandomname = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btopenpicter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btminis);
            this.panel1.Controls.Add(this.btcloses);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 26);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btminis
            // 
            this.btminis.AutoSize = true;
            this.btminis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btminis.Location = new System.Drawing.Point(751, -3);
            this.btminis.Name = "btminis";
            this.btminis.Size = new System.Drawing.Size(21, 24);
            this.btminis.TabIndex = 4;
            this.btminis.Text = "_";
            this.btminis.Click += new System.EventHandler(this.btminis_Click);
            this.btminis.MouseEnter += new System.EventHandler(this.btmini_MouseEnter);
            this.btminis.MouseLeave += new System.EventHandler(this.btmini_MouseLeave);
            // 
            // btcloses
            // 
            this.btcloses.AutoSize = true;
            this.btcloses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btcloses.Location = new System.Drawing.Point(778, 0);
            this.btcloses.Name = "btcloses";
            this.btcloses.Size = new System.Drawing.Size(25, 24);
            this.btcloses.TabIndex = 3;
            this.btcloses.Text = "X";
            this.btcloses.Click += new System.EventHandler(this.btcloses_Click);
            this.btcloses.MouseEnter += new System.EventHandler(this.btclose_MouseEnter);
            this.btcloses.MouseLeave += new System.EventHandler(this.btclose_MouseLeave);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbname.Location = new System.Drawing.Point(252, 105);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(260, 39);
            this.lbname.TabIndex = 2;
            this.lbname.Text = "Как вас зовут?";
            // 
            // tbname
            // 
            this.tbname.BackColor = System.Drawing.Color.Gray;
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbname.Location = new System.Drawing.Point(197, 168);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(372, 40);
            this.tbname.TabIndex = 3;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // btsavename
            // 
            this.btsavename.BackColor = System.Drawing.Color.DimGray;
            this.btsavename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btsavename.Location = new System.Drawing.Point(197, 238);
            this.btsavename.Name = "btsavename";
            this.btsavename.Size = new System.Drawing.Size(144, 43);
            this.btsavename.TabIndex = 4;
            this.btsavename.Text = "Вход";
            this.btsavename.UseVisualStyleBackColor = false;
            this.btsavename.Click += new System.EventHandler(this.btsavename_Click);
            // 
            // btrandomname
            // 
            this.btrandomname.BackColor = System.Drawing.Color.DimGray;
            this.btrandomname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btrandomname.Location = new System.Drawing.Point(363, 238);
            this.btrandomname.Name = "btrandomname";
            this.btrandomname.Size = new System.Drawing.Size(206, 43);
            this.btrandomname.TabIndex = 5;
            this.btrandomname.Text = "Выбрать имя Ольга Алексеевна";
            this.btrandomname.UseVisualStyleBackColor = false;
            this.btrandomname.Click += new System.EventHandler(this.btrandomname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Аватарка";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(96, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btopenpicter
            // 
            this.btopenpicter.Location = new System.Drawing.Point(89, 250);
            this.btopenpicter.Name = "btopenpicter";
            this.btopenpicter.Size = new System.Drawing.Size(75, 23);
            this.btopenpicter.TabIndex = 8;
            this.btopenpicter.Text = "Открыть";
            this.btopenpicter.UseVisualStyleBackColor = true;
            this.btopenpicter.Click += new System.EventHandler(this.btopenpicter_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btopenpicter);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btrandomname);
            this.Controls.Add(this.btsavename);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Cclearpro";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btcloses;
        private System.Windows.Forms.Label btminis;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btsavename;
        public System.Windows.Forms.Button btrandomname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btopenpicter;
    }
}

