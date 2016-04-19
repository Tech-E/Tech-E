using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_E_BackEnd
{
    public partial class lstAppointments : Form
    {
        public lstAppointments()
        {
            InitializeComponent();
        }

        private void lstAppointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Tech_EDataSet.tblAppointment' table. You can move, or remove it, as needed.
            this.tblAppointmentTableAdapter.Fill(this._Tech_EDataSet.tblAppointment);

        }
    }
}
