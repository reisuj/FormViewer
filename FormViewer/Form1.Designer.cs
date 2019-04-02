namespace FormViewer
{
    partial class FormViewer
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
            this.btnBCTForms = new System.Windows.Forms.Button();
            this.btnParaTransitForms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBCTForms
            // 
            this.btnBCTForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBCTForms.Location = new System.Drawing.Point(32, 32);
            this.btnBCTForms.Name = "btnBCTForms";
            this.btnBCTForms.Size = new System.Drawing.Size(199, 43);
            this.btnBCTForms.TabIndex = 0;
            this.btnBCTForms.Text = "BCT Forms";
            this.btnBCTForms.UseVisualStyleBackColor = true;
            this.btnBCTForms.Click += new System.EventHandler(this.btnBCTForms_Click);
            // 
            // btnParaTransitForms
            // 
            this.btnParaTransitForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnParaTransitForms.Location = new System.Drawing.Point(32, 114);
            this.btnParaTransitForms.Name = "btnParaTransitForms";
            this.btnParaTransitForms.Size = new System.Drawing.Size(199, 77);
            this.btnParaTransitForms.TabIndex = 1;
            this.btnParaTransitForms.Text = "ParaTransit Forms";
            this.btnParaTransitForms.UseVisualStyleBackColor = true;
            this.btnParaTransitForms.Click += new System.EventHandler(this.btnParaTransitForms_Click);
            // 
            // FormViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(273, 230);
            this.Controls.Add(this.btnParaTransitForms);
            this.Controls.Add(this.btnBCTForms);
            this.Name = "FormViewer";
            this.Text = "FormViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBCTForms;
        private System.Windows.Forms.Button btnParaTransitForms;
    }
}

