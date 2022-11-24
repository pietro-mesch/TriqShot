﻿using System.Drawing;
using System.Windows.Forms;

namespace grav
{
    partial class Form1
    {

        private int n = 5;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color black = Color.FromArgb(255, 0, 0, 0);
            Pen greenPen = new Pen(Color.LimeGreen);
            for (int i = 0; i < n; i++)
            {
                e.Graphics.DrawEllipse(greenPen,new Rectangle(new Point(100 + 100 * i,100),new Size(50,50)));
            }

        }

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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "grav";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

