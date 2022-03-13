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
    public partial class PersInf : Form
    {
        int id;
        public PersInf(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void PersInf_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = Person.persons[id].name;
            SurnameTextBox.Text = Person.persons[id].sername;
            if (Person.persons[id].floor.Equals(Floor.male))
            {
                FloorTextBox.Text = "М";
            }
            else
                FloorTextBox.Text = "Ж";
            AgeTextBox.Text = Person.persons[id].burthday.ToString();
            pictureBox1.Image = Image.FromFile(Person.persons[id].image);
            diagnozTextBox.Text = Person.persons[id].diagnoz.ToString();
        }
    }
}
