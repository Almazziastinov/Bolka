
namespace Bolka
{
    partial class NewPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPerson));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Floor = new System.Windows.Forms.GroupBox();
            this.MaleradioButton = new System.Windows.Forms.RadioButton();
            this.femaleradioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.no = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Floor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.33113F));
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SurnameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Floor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.save, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.8254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.1746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameTextBox.Location = new System.Drawing.Point(3, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(216, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SurnameTextBox.Location = new System.Drawing.Point(3, 43);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(216, 22);
            this.SurnameTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.no);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(225, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(228, 450);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 135);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Floor
            // 
            this.Floor.Controls.Add(this.femaleradioButton);
            this.Floor.Controls.Add(this.MaleradioButton);
            this.Floor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Floor.Location = new System.Drawing.Point(3, 89);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(216, 94);
            this.Floor.TabIndex = 1;
            this.Floor.TabStop = false;
            this.Floor.Text = "Пол";
            // 
            // MaleradioButton
            // 
            this.MaleradioButton.AutoSize = true;
            this.MaleradioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaleradioButton.Location = new System.Drawing.Point(3, 18);
            this.MaleradioButton.Name = "MaleradioButton";
            this.MaleradioButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.MaleradioButton.Size = new System.Drawing.Size(210, 31);
            this.MaleradioButton.TabIndex = 0;
            this.MaleradioButton.TabStop = true;
            this.MaleradioButton.Text = "М";
            this.MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // femaleradioButton
            // 
            this.femaleradioButton.AutoSize = true;
            this.femaleradioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.femaleradioButton.Location = new System.Drawing.Point(3, 49);
            this.femaleradioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.femaleradioButton.Name = "femaleradioButton";
            this.femaleradioButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.femaleradioButton.Size = new System.Drawing.Size(210, 31);
            this.femaleradioButton.TabIndex = 1;
            this.femaleradioButton.TabStop = true;
            this.femaleradioButton.Text = "Ж";
            this.femaleradioButton.UseVisualStyleBackColor = true;
            this.femaleradioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 189);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(216, 76);
            this.panel2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // no
            // 
            this.no.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.no.Location = new System.Drawing.Point(3, 411);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(222, 36);
            this.no.TabIndex = 1;
            this.no.Text = "Отмена";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.CanselButton);
            // 
            // save
            // 
            this.save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.save.Location = new System.Drawing.Point(3, 411);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(216, 36);
            this.save.TabIndex = 3;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.SaveButton);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ImageButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 271);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(216, 70);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите фото";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ImageButton
            // 
            this.ImageButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImageButton.Location = new System.Drawing.Point(3, 33);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(210, 34);
            this.ImageButton.TabIndex = 1;
            this.ImageButton.Text = "Выбрать фото";
            this.ImageButton.UseVisualStyleBackColor = true;
            this.ImageButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 273);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // NewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewPerson";
            this.Text = "NewPerson";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Floor.ResumeLayout(false);
            this.Floor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.GroupBox Floor;
        private System.Windows.Forms.RadioButton femaleradioButton;
        private System.Windows.Forms.RadioButton MaleradioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ImageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
    }
}