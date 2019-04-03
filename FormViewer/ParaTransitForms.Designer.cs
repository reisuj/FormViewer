namespace FormViewer
{
    partial class ParaTransitForms
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
            this.btnVisitorRequest = new System.Windows.Forms.Button();
            this.btnADAEZRenew = new System.Windows.Forms.Button();
            this.btnPCARequest = new System.Windows.Forms.Button();
            this.btnPCACoverLtr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVisitorRequest
            // 
            this.btnVisitorRequest.Location = new System.Drawing.Point(22, 10);
            this.btnVisitorRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVisitorRequest.Name = "btnVisitorRequest";
            this.btnVisitorRequest.Size = new System.Drawing.Size(150, 47);
            this.btnVisitorRequest.TabIndex = 0;
            this.btnVisitorRequest.Text = "Visitor Request Form";
            this.btnVisitorRequest.UseVisualStyleBackColor = true;
            this.btnVisitorRequest.Click += new System.EventHandler(this.btnVisitorRequest_Click);
            // 
            // btnADAEZRenew
            // 
            this.btnADAEZRenew.Location = new System.Drawing.Point(22, 74);
            this.btnADAEZRenew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnADAEZRenew.Name = "btnADAEZRenew";
            this.btnADAEZRenew.Size = new System.Drawing.Size(150, 47);
            this.btnADAEZRenew.TabIndex = 1;
            this.btnADAEZRenew.Text = "ADA EZ Renew Form";
            this.btnADAEZRenew.UseVisualStyleBackColor = true;
            this.btnADAEZRenew.Click += new System.EventHandler(this.btnADAEZRenew_Click);
            // 
            // btnPCARequest
            // 
            this.btnPCARequest.Location = new System.Drawing.Point(22, 141);
            this.btnPCARequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPCARequest.Name = "btnPCARequest";
            this.btnPCARequest.Size = new System.Drawing.Size(150, 47);
            this.btnPCARequest.TabIndex = 2;
            this.btnPCARequest.Text = "PCA Request Form";
            this.btnPCARequest.UseVisualStyleBackColor = true;
            this.btnPCARequest.Click += new System.EventHandler(this.btnPCARequest_Click);
            // 
            // btnPCACoverLtr
            // 
            this.btnPCACoverLtr.Location = new System.Drawing.Point(22, 207);
            this.btnPCACoverLtr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPCACoverLtr.Name = "btnPCACoverLtr";
            this.btnPCACoverLtr.Size = new System.Drawing.Size(150, 48);
            this.btnPCACoverLtr.TabIndex = 3;
            this.btnPCACoverLtr.Text = "PCA Request Cover Letter";
            this.btnPCACoverLtr.UseVisualStyleBackColor = true;
            this.btnPCACoverLtr.Click += new System.EventHandler(this.btnPCACoverLtr_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "ParaTransit Vehicle Search by Vehicle or Tag #";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ParaTransitForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPCACoverLtr);
            this.Controls.Add(this.btnPCARequest);
            this.Controls.Add(this.btnADAEZRenew);
            this.Controls.Add(this.btnVisitorRequest);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ParaTransitForms";
            this.Text = "ParaTransit Forms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVisitorRequest;
        private System.Windows.Forms.Button btnADAEZRenew;
        private System.Windows.Forms.Button btnPCARequest;
        private System.Windows.Forms.Button btnPCACoverLtr;
        private System.Windows.Forms.Button button1;
    }
}