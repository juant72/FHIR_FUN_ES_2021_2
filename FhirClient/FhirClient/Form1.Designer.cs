
namespace FhirClientApp
{
    partial class Form1
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
            this.buttonPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPatient
            // 
            this.buttonPatient.Location = new System.Drawing.Point(29, 207);
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.Size = new System.Drawing.Size(213, 39);
            this.buttonPatient.TabIndex = 0;
            this.buttonPatient.Text = "Generar Patient resource";
            this.buttonPatient.UseVisualStyleBackColor = true;
            this.buttonPatient.Click += new System.EventHandler(this.buttonPatient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPatient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPatient;
    }
}

