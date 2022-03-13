
namespace Bolka
{
    partial class PersInf
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.FloorTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.diagnozTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AgeTextBox);
            this.panel1.Controls.Add(this.FloorTextBox);
            this.panel1.Controls.Add(this.SurnameTextBox);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 202);
            this.panel1.TabIndex = 0;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(36, 151);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(132, 22);
            this.AgeTextBox.TabIndex = 4;
            // 
            // FloorTextBox
            // 
            this.FloorTextBox.Location = new System.Drawing.Point(36, 106);
            this.FloorTextBox.Name = "FloorTextBox";
            this.FloorTextBox.Size = new System.Drawing.Size(54, 22);
            this.FloorTextBox.TabIndex = 3;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(36, 63);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.SurnameTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(36, 22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(565, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.diagnozTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 250);
            this.panel2.TabIndex = 1;
            // 
            // diagnozTextBox
            // 
            this.diagnozTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagnozTextBox.Location = new System.Drawing.Point(0, 0);
            this.diagnozTextBox.Name = "diagnozTextBox";
            this.diagnozTextBox.Size = new System.Drawing.Size(797, 250);
            this.diagnozTextBox.TabIndex = 0;
            this.diagnozTextBox.Text = "";
            // 
            // PersInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PersInf";
            this.Text = "PersInf";
            this.Load += new System.EventHandler(this.PersInf_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox FloorTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.RichTextBox diagnozTextBox;
    }
}