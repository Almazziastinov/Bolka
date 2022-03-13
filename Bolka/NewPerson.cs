using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolka
{
    public partial class NewPerson : Form
    {
        string image;

        public NewPerson()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton(object sender, EventArgs e)
        {

            Floor floor;

            if (MaleradioButton.Checked)
            {
                floor = Bolka.Floor.male;
            }
            else
                floor = Bolka.Floor.feemale;

            Person.persons.Add(new Person(NameTextBox.Text, SurnameTextBox.Text, dateTimePicker1.Value, floor, image,richTextBox1.Text));
            DialogResult = DialogResult.OK;

        }

        private void CanselButton(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            image = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(image);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
