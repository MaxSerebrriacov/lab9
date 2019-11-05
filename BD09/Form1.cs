using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g284_CerebriacovDataSet3.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.g284_CerebriacovDataSet3.Table_1);
            // TODO: This line of code loads data into the 'g284_CerebriacovDataSet2.Table_1' table. You can move, or remove it, as needed.
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table1BindingSource.EndEdit();
            this.table_1TableAdapter.Update(this.g284_CerebriacovDataSet3);

        }
    }
}
