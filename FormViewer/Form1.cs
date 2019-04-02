using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormViewer
{
    public partial class FormViewer : Form
    {
        public FormViewer()
        {
            InitializeComponent();
        }

        private void btnBCTForms_Click(object sender, EventArgs e)
        {
            //Create new instance of form2
            BCTForms bctForm = new BCTForms();

            //Show the form
            bctForm.Show();
        }

        private void btnParaTransitForms_Click(object sender, EventArgs e)
        {
            //Create new instance of form2
            ParaTransitForms paraTransitForm = new ParaTransitForms();

            //Show the form
            paraTransitForm.Show();
        }
    }
}
