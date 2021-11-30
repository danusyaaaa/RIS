using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'compDataSet.comp_table' table. You can move, or remove it, as needed.
            this.comp_tableTableAdapter.Fill(this.compDataSet.comp_table);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void save_Click(object sender, EventArgs e)
        {
            compDataSet.AcceptChanges();
            comp_tableTableAdapter.Update(compDataSet, "comp");
            this.dataGridView1.Update();
        }
            
        

        private void cancel_Click(object sender, EventArgs e)
        {
            compDataSet.RejectChanges();
            this.dataGridView1.Update();
        }
    }
}
