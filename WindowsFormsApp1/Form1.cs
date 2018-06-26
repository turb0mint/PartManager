using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private PartsRegister _PartsList;
        
        

        public Form1()
        {
            InitializeComponent();
            _PartsList = PartsRegister.Instance;
            _PartsList.PartsListChange += PartsList_PartsListChange;
            var bindingList = new BindingList<SparePart>(_PartsList.GetParts());
            Update_gridview();
        }

        private void PartsList_PartsListChange(object sender, int e)
        {
            Update_gridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form NewPart = new NewPart();
            NewPart.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Update_gridview()
        {
            dataGridView1.DataSource = new BindingList<SparePart>(_PartsList.GetParts());
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form NewPart = new NewPart(_PartsList.PartsList[dataGridView1.CurrentRow.Index]);
            NewPart.ShowDialog();
        }
    }
}
