﻿namespace Cclearpro
{
    partial class aloytuul
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnewprocess = new System.Windows.Forms.Button();
            this.btstaringprocess = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnewprocess);
            this.groupBox1.Controls.Add(this.btstaringprocess);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Диспечер задач";
            // 
            // btnewprocess
            // 
            this.btnewprocess.Location = new System.Drawing.Point(25, 78);
            this.btnewprocess.Name = "btnewprocess";
            this.btnewprocess.Size = new System.Drawing.Size(165, 23);
            this.btnewprocess.TabIndex = 1;
            this.btnewprocess.Text = "Новый режим";
            this.btnewprocess.UseVisualStyleBackColor = true;
            this.btnewprocess.Click += new System.EventHandler(this.btnewprocess_Click);
            // 
            // btstaringprocess
            // 
            this.btstaringprocess.Location = new System.Drawing.Point(25, 49);
            this.btstaringprocess.Name = "btstaringprocess";
            this.btstaringprocess.Size = new System.Drawing.Size(165, 23);
            this.btstaringprocess.TabIndex = 0;
            this.btstaringprocess.Text = "Старый режим";
            this.btstaringprocess.UseVisualStyleBackColor = true;
            this.btstaringprocess.Click += new System.EventHandler(this.btstaringprocess_Click);
            // 
            // aloytuul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 152);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "aloytuul";
            this.Text = "Диспетчер задач";
            this.Load += new System.EventHandler(this.aloytuul_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnewprocess;
        private System.Windows.Forms.Button btstaringprocess;
    }
}