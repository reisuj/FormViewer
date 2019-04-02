using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormViewer
{
    public partial class BCTForms : Form
    {
        public BCTForms()
        {
            InitializeComponent();
        }

        private void btnLostBusPass_Click(object sender, EventArgs e)
        {
            FormSelect("PassLostFareBox.*");
            //System.Diagnostics.Process.Start(@"G:\BCT Forms\LOST BUS PASS FORM 5-5-2017.pdf");
        }

        private void btnRefundRequest_Click(object sender, EventArgs e)
        {
            FormSelect("RefundRequest.*");
            //System.Diagnostics.Process.Start(@"G:\BCT Forms\Request for Refund Form.docx");
        }

        private void btnMissingPersons_Click(object sender, EventArgs e)
        {
            FormSelect("MissingPerson.*");
            //System.Diagnostics.Process.Start(@"G:\BCT Forms\MISSING PERSONS REPORT.docx");
        }

        private void FormSelect(string fileName)
        {
            DirectoryInfo diSource = new DirectoryInfo(@"g:\FormViewer\BCT Forms\");
            string ExactFilename = string.Empty;
            foreach (FileInfo file in diSource.GetFiles(fileName, SearchOption.TopDirectoryOnly))
            {
                ExactFilename = file.FullName;
            }
            if (ExactFilename != string.Empty)
                System.Diagnostics.Process.Start(ExactFilename);
        }
    }
}
