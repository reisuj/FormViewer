namespace FormViewer
{
    partial class BCTForms
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
            this.btnLostBusPass = new System.Windows.Forms.Button();
            this.btnRefundRequest = new System.Windows.Forms.Button();
            this.btnMissingPersons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLostBusPass
            // 
            this.btnLostBusPass.Location = new System.Drawing.Point(51, 29);
            this.btnLostBusPass.Name = "btnLostBusPass";
            this.btnLostBusPass.Size = new System.Drawing.Size(168, 65);
            this.btnLostBusPass.TabIndex = 1;
            this.btnLostBusPass.Text = "Bus Pass Lost in Farebox Form";
            this.btnLostBusPass.UseVisualStyleBackColor = true;
            this.btnLostBusPass.Click += new System.EventHandler(this.btnLostBusPass_Click);
            // 
            // btnRefundRequest
            // 
            this.btnRefundRequest.Location = new System.Drawing.Point(51, 120);
            this.btnRefundRequest.Name = "btnRefundRequest";
            this.btnRefundRequest.Size = new System.Drawing.Size(168, 65);
            this.btnRefundRequest.TabIndex = 2;
            this.btnRefundRequest.Text = "Refund Request Form";
            this.btnRefundRequest.UseVisualStyleBackColor = true;
            this.btnRefundRequest.Click += new System.EventHandler(this.btnRefundRequest_Click);
            // 
            // btnMissingPersons
            // 
            this.btnMissingPersons.Location = new System.Drawing.Point(51, 211);
            this.btnMissingPersons.Name = "btnMissingPersons";
            this.btnMissingPersons.Size = new System.Drawing.Size(168, 65);
            this.btnMissingPersons.TabIndex = 3;
            this.btnMissingPersons.Text = "Missing Persons Form";
            this.btnMissingPersons.UseVisualStyleBackColor = true;
            this.btnMissingPersons.Click += new System.EventHandler(this.btnMissingPersons_Click);
            // 
            // BCTForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 316);
            this.Controls.Add(this.btnMissingPersons);
            this.Controls.Add(this.btnRefundRequest);
            this.Controls.Add(this.btnLostBusPass);
            this.Name = "BCTForms";
            this.Text = "BCT Forms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLostBusPass;
        private System.Windows.Forms.Button btnRefundRequest;
        private System.Windows.Forms.Button btnMissingPersons;
    }
}