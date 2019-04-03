using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormViewer
{
    public partial class ParaTransitForms : Form
    {
        public ParaTransitForms()
        {
            InitializeComponent();
        }

        private void btnVisitorRequest_Click(object sender, EventArgs e)
        {
            FormSelect("VisitorRequest.*");
            //System.Diagnostics.Process.Start(@"G:\PARATRANSIT FORMS\Visitor-Status Request Form 8.2017.pdf");
        }

        private void btnADAEZRenew_Click(object sender, EventArgs e)
        {
            FormSelect("ADA_EZ_Form.*");
            //System.Diagnostics.Process.Start(@"G:\PARATRANSIT FORMS\ADA E-Z FORM 2 2016.pdf");
        }

        private void btnPCARequest_Click(object sender, EventArgs e)
        {
            FormSelect("PCA_Request.*");
            // System.Diagnostics.Process.Start(@"G:\PARATRANSIT FORMS\PCA Authorization Form Revised 7.2017.pdf");
        }

        private void btnPCACoverLtr_Click(object sender, EventArgs e)
        {
            FormSelect("PCA_CoverSheet.*");
            //System.Diagnostics.Process.Start(@"G:\PARATRANSIT FORMS\PCA Request Cover Letter-7.2017.pdf");
        }

        private void FormSelect(string fileName)
        {
            DirectoryInfo diSource = new DirectoryInfo(@"g:\FormViewer\ParaTransit Forms\");
            string ExactFilename = string.Empty;
            foreach (FileInfo file in diSource.GetFiles(fileName, SearchOption.TopDirectoryOnly))
            {
                ExactFilename = file.FullName;
            }
            if (ExactFilename != string.Empty)
                System.Diagnostics.Process.Start(ExactFilename);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            //Create new instance of ParaTransitFleet Form
            ParaTransitFleet paraTransitFleert = new ParaTransitFleet();

            //Show the form
            paraTransitFleert.Show();
        }
    }
}
