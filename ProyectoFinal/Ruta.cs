using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Ruta : Form
    {
        public Ruta()
        {
            InitializeComponent();
            var facade = new SimulationFacade();
            Dictionary<string, int> d = facade.MethodSort();

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;

            foreach(var dict in d)
            {
                string[] st = { dict.Key,dict.Value.ToString()};
                dataGridView1.Rows.Add(st);
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LeerQR().Show();
            Hide();
        }
    }
}
