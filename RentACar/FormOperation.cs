using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FormOperation : Form
    {
        public FormOperation()
        {
            InitializeComponent();
        }

        public int RowId { get; internal set; }
        public bool OperBack { get; internal set; }
        public string RegPlate { get; internal set; }

        private void FormOperation_Load(object sender, EventArgs e)
        {
            if (OperBack)
            {
                //
                this.Text = $"Zwrot pojazdu {RegPlate}";
            } else
            {
                this.Text = $"Wydanie pojazdu {RegPlate}";
            }
        }
    }
}
