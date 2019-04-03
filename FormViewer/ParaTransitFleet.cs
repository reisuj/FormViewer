﻿using System;
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
    public partial class ParaTransitFleet : Form
    {
        public bool matchFound;
        public string[,] vehicles = new string[249, 3]
        {
            {"P0001","237531","FT"},
            {"P0002","TD3303","FT"},
            {"P0003","237532","FT"},
            {"P0004","237533","FT"},
            {"P0005","TD86560","FT"},
            {"P0006","237530","FT"},
            {"P0007","TD3304","FT"},
            {"P0008","237534","FT"},
            {"P0009","TA7088","FT"},
            {"P0010","237535","FT"},
            {"P0011","237537","FT"},
            {"P0012","237538","FT"},
            {"P0013","237539","FT"},
            {"P0014","TA7089","FT"},
            {"P0015","TD3694","FT"},
            {"P0016","TD3686","FT"},
            {"P0017","TD3692","FT"},
            {"P0018","TD3695","FT"},
            {"P0019","TD3688","FT"},
            {"P0020","TD3687","FT"},
            {"P0021","TD8644","FT"},
            {"P0022","TD3691","FT"},
            {"P0023","TD8657","FT"},
            {"P0024","TD3690","FT"},
            {"P0025","237536","FT"},
            {"P0026","TD3689","FT"},
            {"P0027","TB5240","FT"},
            {"P0028","TB5241","FT"},
            {"P0029","TB5242","FT"},
            {"P0030","TC3827","FT"},
            {"P0031","TC3829","FT"},
            {"P0032","TD3301","FT"},
            {"P0033","TC3828","FT"},
            {"P0035","TD8493","FT"},
            {"P0036","TC3833","FT"},
            {"P0037","TB5244","FT"},
            {"P0038","108682","FT"},
            {"P0039","TD8492","FT"},
            {"P0040","TC3832","FT"},
            {"P0041","TB5243","FT"},
            {"P0042","TC3831","FT"},
            {"P0043","TC3830","FT"},
            {"P0044","TD8491","FT"},
            {"P0045","TD3302","FT"},
            {"P0046","TC3835","FT"},
            {"P0047","TC3836","FT"},
            {"P0048","TC3834","FT"},
            {"P0049","108683","FT"},
            {"P0050","108686","FT"},
            {"P0051","TD8496","FT"},
            {"P0052","TD8495","FT"},
            {"P0053","TD8494","FT"},
            {"P0054","TD8497","FT"},
            {"P0055","TD8498","FT"},
            {"P0056","TD8499","FT"},
            {"P0057","TD8500","FT"},
            {"P0058","TD8501","FT"},
            {"P0059","TB8038","FT"},
            {"P0060","TB8039","FT"},
            {"P0061","TB8040","FT"},
            {"P0062","108689","FT"},
            {"P0063","108690","FT"},
            {"P0064","TB8474","FT"},
            {"P0065","TB8041","FT"},
            {"P0067","TB8043","FT"},
            {"P0068","TD8490","FT"},
            {"P0069","TB8044","FT"},
            {"P0070","TD8475","FT"},
            {"P0071","TD8505","FT"},
            {"P0072","TD8504","TA"},
            {"P0073","TD8503","TA"},
            {"P0074","TB8045","TA"},
            {"P0075","TD8509","TA"},
            {"P0076","TD8508","TA"},
            {"P0077","TD8507","TA"},
            {"P0078","TD8506","TA"},
            {"P0079","TD8510","TA"},
            {"P0080","TD8511","TA"},
            {"P0081","TD8512","TA"},
            {"P0082","TD8513","TA"},
            {"P0083","TD8514","TA"},
            {"P0084","TD8515","TA"},
            {"P0085","TD8516","TA"},
            {"P0086","TD8517","TA"},
            {"P0087","TD8518","TA"},
            {"P0088","TD8528","TA"},
            {"P0089","TD8519","TA"},
            {"P0090","TD8529","TA"},
            {"P0091","TD8530","TA"},
            {"P0092","TD8531","TA"},
            {"P0093","TD850","TA"},
            {"P0094","TD8521","TA"},
            {"P0095","TD8532","TA"},
            {"P0096","TD8537","TA"},
            {"P0097","TD8536","TA"},
            {"P0098","TD8538","TA"},
            {"P0099","TD8522","TA"},
            {"P0100","TD8534","TA"},
            {"P0101","TD8561","TA"},
            {"P0102","TD8523","TA"},
            {"P0103","TD8524","TA"},
            {"P0104","TD8525","TA"},
            {"P0105","TD8526","TA"},
            {"P0106","TD8527","TA"},
            {"P0107","TD8553","TA"},
            {"P0108","TD8552","TA"},
            {"P0109","TD8535","TA"},
            {"P0110","TD8562","TA"},
            {"P0111","TD8551","TA"},
            {"P0112","TD8549","TA"},
            {"P0113","TD8550","TA"},
            {"P0114","TD8564","TA"},
            {"P0115","TD8563","TA"},
            {"P0116","TD8560","TA"},
            {"P0117","TD8570","TA"},
            {"P0118","108748","TA"},
            {"P0119","TD8555","TA"},
            {"P0120","TD8571","TA"},
            {"P0121","TD8554","TA"},
            {"P0122","TD8572","TA"},
            {"P0123","TD8573","TA"},
            {"P0124","TD8565","TA"},
            {"P0125","TD8566","TA"},
            {"P0126","TD8567","TA"},
            {"P0127","TD8568","TA"},
            {"P0128","TD8569","TA"},
            {"P0129","158742","TA"},
            {"P0130","158743","TA"},
            {"P0131","158744","TA"},
            {"P0132","158745","TA"},
            {"P0133","108747","TA"},
            {"P0134","TD3892","TA"},
            {"P0135","158746","TA"},
            {"P0136","158748","TA"},
            {"P0137","158749","TA"},
            {"P0138","158750","TA"},
            {"P0139","TB8095","TA"},
            {"P0140","TB8093","TA"},
            {"P0141","TB8092","TA"},
            {"P0142","TB8096","TA"},
            {"P0143","TB8094","TA"},
            {"P0144","TB8101","TA"},
            {"P0145","TB8102","TA"},
            {"P0146","TB8104","TA"},
            {"P0147","TB8103","TA"},
            {"P0148","TD9811","TA"},
            {"P0149","TD9813","TA"},
            {"P0150","TD9812","TA"},
            {"P0151","TE0382","FT"},
            {"P0152","TE0388","FT"},
            {"P0153","TD9814","FT"},
            {"P0154","TE0383","FT"},
            {"P0155","TD9815","FT"},
            {"P0156","TE0393","FT"},
            {"P0157","TE0390","FT"},
            {"P0158","TE0391","FT"},
            {"P0159","TE0389","FT"},
            {"P0160","TE0387","FT"},
            {"P0161","TE0392","FT"},
            {"P0162","TE0982","FT"},
            {"P0163","TE0396","TA"},
            {"P0164","TE0983","TA"},
            {"P0165","TF0492","FT"},
            {"P0166","TF0490","FT"},
            {"P0167","TF0489","FT"},
            {"P0168","TF0491","FT"},
            {"P0169","TF0486","TA"},
            {"P0170","TF0487","TA"},
            {"P0171","TF0485","TA"},
            {"P0172","TF0483","TA"},
            {"P0173","TF0488","FT"},
            {"P0174","TF0484","TA"},
            {"P0175","TF0493","TA"},
            {"P0176","TF0499","TA"},
            {"P0177","TF0496","TA"},
            {"P0178","TF0500","FT"},
            {"P0179","TF0501","FT"},
            {"P0180","TF0307","FT"},
            {"P0181","TF0497","TA"},
            {"P0182","TF0494","TA"},
            {"P0183","TF0495","TA"},
            {"P0184","TF0308","FT"},
            {"P0185","TF0309","FT"},
            {"P0186","TF0498","FT"},
            {"P0187","TF7957","FT"},
            {"P0188","TF6413","FT"},
            {"P0189","TF6406","FT"},
            {"P0190","TF6407","FT"},
            {"P0191","TF6405","FT"},
            {"P0192","TF7954","FT"},
            {"P0193","TF7953","FT"},
            {"P0194","TF7952","FT"},
            {"P0195","TF5152","FT"},
            {"P0196","TF6414","FT"},
            {"P0197","TF7958","FT"},
            {"P0198","TF6408","TA"},
            {"P0199","TF6409","TA"},
            {"P0200","TF6410","TA"},
            {"P0201","TF7960","TA"},
            {"P0202","TF5169","TA"},
            {"P0203","TF7961","TA"},
            {"P0204","TF7956","TA"},
            {"P0205","TF7959","TA"},
            {"P0206","TF7955","TA"},
            {"P0207","TF6411","TA"},
            {"P0208","TF6412","TA"},
            {"P0209","TF8862","TA"},
            {"P0210","TC8507","TA"},
            {"P0211","TC8505","TA"},
            {"P0212","TC8506","TA"},
            {"P0213","TF8863","TA"},
            {"P0214","TF8864","TA"},
            {"P0215","TF8865","TA"},
            {"P0216","CHC9236","FT"},
            {"P0217","TG8860","FT"},
            {"P0218","TG8859","FT"},
            {"P0219","TG6838","FT"},
            {"P0220","TG6837","FT"},
            {"P0221","TF8866","FT"},
            {"P0222","TG8865","FT"},
            {"P0223","TG8866","FT"},
            {"P0224","TG8867","FT"},
            {"P0225","TG8868","FT"},
            {"P0226","TG8864","FT"},
            {"P0227","TG8869","TA"},
            {"P0228","TG8870","TA"},
            {"P0229","TG8871","TA"},
            {"P0230","TG8873","TA"},
            {"P0231","TG8872","TA"},
            {"P0232","TG7585","TA"},
            {"P0233","TG7586","TA"},
            {"P0234","TG7587","TA"},
            {"P0235","TG7588","TA"},
            {"P0236","TG7589","TA"},
            {"P0237","TG7590","TA"},
            {"P0238","TG7591","TA"},
            {"P0239","TG7592","TA"},
            {"P0240","TG7593","FT"},
            {"P0241","TG8877","FT"},
            {"P0242","TG8878","FT"},
            {"P0243","TG8879","FT"},
            {"P0244","TG8880","FT"},
            {"P0245","TG8881","FT"},
            {"P0246","TG8882","FT"},
            {"P0247","TG8883","FT"},
            {"P0248","TG8884","FT"},
            {"P0249","TG8896","FT"},
            {"P0250","TG8895","FT"},
            {"P0254","TG8885","TA"}
        };


        public ParaTransitFleet()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int rowLowerLimit = 0;
            int rowUpperLimit = 249;

            int colLowerLimit = 0;
            int colUpperLimit = 3;

            matchFound = false;

            for (int row = rowLowerLimit; row < rowUpperLimit; row++)
            {
                for (int col = colLowerLimit; col < colUpperLimit; col++)
                {
                    if (vehicles[row, col] == txtSearchNum.Text.ToUpper())
                    {
                        matchFound = true;
                        txtVehicleNum.Text = vehicles[row, 0];
                        txtTagNum.Text = vehicles[row, 1];
                        txtProvider.Text = vehicles[row, 2];

                        goto endOfLoop;
                    }
                }
            }
        endOfLoop:;
            if (!matchFound)
            {
                MessageBox.Show("No Matches Found");
            }
        }
    }
}
