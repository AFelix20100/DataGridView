using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable mytable = new DataTable();
            mytable.Columns.Add("Base verbale");
            mytable.Columns.Add("participe");
            mytable.Columns.Add("preterit");
            string[] lesVerbes = File.ReadAllLines("verbes.csv");
            string[] valeurs;

            for(int i = 1; i<lesVerbes.Length;i++)
            {
                valeurs = lesVerbes[i].Split(',');
                mytable.Rows.Add(valeurs);
            }

            dataGridView1.DataSource = mytable;
        }
    }
}
