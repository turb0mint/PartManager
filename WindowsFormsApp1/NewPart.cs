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



    public partial class NewPart : Form
    {
 
        PartsRegister PartsList = PartsRegister.Instance;
        private SparePart _Part;
       

        public NewPart()
        {
            InitializeComponent();
            
        }

        public NewPart(SparePart Part)
        {
            InitializeComponent();
            
            this._Part = Part;

            this.PartNum.Text = _Part.PartNumber;
            this.Desc.Text = _Part.Desc;
            this.Price.Text = _Part.Price.ToString();
            this.Manufacturer.Text = _Part.Manufacturer;

        }


        private SparePart UpdatePart(SparePart _Part)
        {
            _Part.PartNumber = this.PartNum.Text;
            _Part.Desc = this.Desc.Text;
             Decimal.TryParse(this.Price.Text,);
            _Part.Manufacturer = this.Manufacturer.Text;
            return _Part;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (_Part == null)
            {

                _Part = UpdatePart(new SparePart());
                PartsList.AddPart(_Part);

            }
            else
            {

                _Part = UpdatePart(_Part);
                PartsList.Refresh();

            }
            
            _Part = null;
            this.Close();

        }

        private void NewPart_Load(object sender, EventArgs e)
        {

        }
    }
}
