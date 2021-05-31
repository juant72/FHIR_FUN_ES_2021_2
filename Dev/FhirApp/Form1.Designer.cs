
namespace FhirApp
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
            this.buttonCreatePatient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreatePatient
            // 
            this.buttonCreatePatient.Location = new System.Drawing.Point(12, 31);
            this.buttonCreatePatient.Name = "buttonCreatePatient";
            this.buttonCreatePatient.Size = new System.Drawing.Size(202, 23);
            this.buttonCreatePatient.TabIndex = 0;
            this.buttonCreatePatient.Text = "Create Patient";
            this.buttonCreatePatient.UseVisualStyleBackColor = true;
            this.buttonCreatePatient.Click += new System.EventHandler(this.buttonCreatePatient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "GetPatient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCreatePatient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreatePatient;
        private System.Windows.Forms.Button button1;
    }
}

