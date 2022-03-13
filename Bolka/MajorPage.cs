using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bolka
{
    public partial class MajorPage : Form
    {

        int id;
        public MajorPage()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        

        private void CreatePersClic(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            NewPerson newPerson = new NewPerson();
            if (newPerson.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            foreach ( var people in Person.persons)
            {
                dataGridView1.Rows.Add(people.id, people.name, people.sername, people.burthday.ToShortDateString(), people.floor);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (dataGridView1.Rows[index].Cells[0].ToString() == "" & dataGridView1.Rows[index].Cells[1].ToString() == "" & dataGridView1.Rows[index].Cells[2].ToString() == "" & dataGridView1.Rows[index].Cells[3].ToString() == "" & dataGridView1.Rows[index].Cells[4].ToString() == "" & dataGridView1.Rows[index].Cells[5].ToString() == "" )
            {
                
            }

            pictureBox1.Image = Image.FromFile(Person.persons[index].image);
            id = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            NameSurname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString() + " " + dataGridView1.Rows[index].Cells[2].Value.ToString();
            if (dataGridView1.Rows[index].Cells[4].Value is Bolka.Floor.feemale)
            {
                FloorTextBox.Text = "ж";
            }
            else
                FloorTextBox.Text = "М";
            AgeTexBox.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersInf pers = new PersInf(id);
            if (pers.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
        }
    }
}
