namespace FormViewer
{
    partial class ParaTransitFleet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEnterVehicleInfo = new System.Windows.Forms.Label();
            this.lblVehicleNum = new System.Windows.Forms.Label();
            this.lblTagNum = new System.Windows.Forms.Label();
            this.lblProvider = new System.Windows.Forms.Label();
            this.txtSearchNum = new System.Windows.Forms.TextBox();
            this.txtVehicleNum = new System.Windows.Forms.TextBox();
            this.txtTagNum = new System.Windows.Forms.TextBox();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterVehicleInfo
            // 
            this.lblEnterVehicleInfo.AutoSize = true;
            this.lblEnterVehicleInfo.Location = new System.Drawing.Point(34, 32);
            this.lblEnterVehicleInfo.Name = "lblEnterVehicleInfo";
            this.lblEnterVehicleInfo.Size = new System.Drawing.Size(172, 13);
            this.lblEnterVehicleInfo.TabIndex = 0;
            this.lblEnterVehicleInfo.Text = "Enter Vehicle \"P\" number or Tag #";
            // 
            // lblVehicleNum
            // 
            this.lblVehicleNum.AutoSize = true;
            this.lblVehicleNum.Location = new System.Drawing.Point(51, 96);
            this.lblVehicleNum.Name = "lblVehicleNum";
            this.lblVehicleNum.Size = new System.Drawing.Size(52, 13);
            this.lblVehicleNum.TabIndex = 1;
            this.lblVehicleNum.Text = "Vehicle #";
            // 
            // lblTagNum
            // 
            this.lblTagNum.AutoSize = true;
            this.lblTagNum.Location = new System.Drawing.Point(148, 96);
            this.lblTagNum.Name = "lblTagNum";
            this.lblTagNum.Size = new System.Drawing.Size(36, 13);
            this.lblTagNum.TabIndex = 2;
            this.lblTagNum.Text = "Tag #";
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(238, 96);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(46, 13);
            this.lblProvider.TabIndex = 3;
            this.lblProvider.Text = "Provider";
            // 
            // txtSearchNum
            // 
            this.txtSearchNum.Location = new System.Drawing.Point(37, 59);
            this.txtSearchNum.Name = "txtSearchNum";
            this.txtSearchNum.Size = new System.Drawing.Size(100, 20);
            this.txtSearchNum.TabIndex = 4;
            this.txtSearchNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVehicleNum
            // 
            this.txtVehicleNum.Location = new System.Drawing.Point(37, 112);
            this.txtVehicleNum.Name = "txtVehicleNum";
            this.txtVehicleNum.ReadOnly = true;
            this.txtVehicleNum.Size = new System.Drawing.Size(76, 20);
            this.txtVehicleNum.TabIndex = 5;
            this.txtVehicleNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTagNum
            // 
            this.txtTagNum.Location = new System.Drawing.Point(131, 112);
            this.txtTagNum.Name = "txtTagNum";
            this.txtTagNum.ReadOnly = true;
            this.txtTagNum.Size = new System.Drawing.Size(75, 20);
            this.txtTagNum.TabIndex = 6;
            this.txtTagNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProvider
            // 
            this.txtProvider.Location = new System.Drawing.Point(241, 112);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.ReadOnly = true;
            this.txtProvider.Size = new System.Drawing.Size(43, 20);
            this.txtProvider.TabIndex = 7;
            this.txtProvider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(187, 59);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ParaTransitFleet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 153);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtProvider);
            this.Controls.Add(this.txtTagNum);
            this.Controls.Add(this.txtVehicleNum);
            this.Controls.Add(this.txtSearchNum);
            this.Controls.Add(this.lblProvider);
            this.Controls.Add(this.lblTagNum);
            this.Controls.Add(this.lblVehicleNum);
            this.Controls.Add(this.lblEnterVehicleInfo);
            this.Name = "ParaTransitFleet";
            this.Text = "ParaTransitFleet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterVehicleInfo;
        private System.Windows.Forms.Label lblVehicleNum;
        private System.Windows.Forms.Label lblTagNum;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.TextBox txtSearchNum;
        private System.Windows.Forms.TextBox txtVehicleNum;
        private System.Windows.Forms.TextBox txtTagNum;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Button btnSubmit;
    }
}