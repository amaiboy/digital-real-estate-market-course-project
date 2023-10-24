namespace code.Forms
{
    partial class FormDevelopers
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
            this.formTitle1 = new code.FormTitle();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formTitle1
            // 
            this.formTitle1.AutoSize = true;
            this.formTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle1.ForeColor = System.Drawing.Color.Black;
            this.formTitle1.Location = new System.Drawing.Point(12, 24);
            this.formTitle1.Name = "formTitle1";
            this.formTitle1.Size = new System.Drawing.Size(329, 26);
            this.formTitle1.TabIndex = 0;
            this.formTitle1.Text = "Інформація про розробників";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FormDevelopers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(768, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formTitle1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(784, 600);
            this.MinimumSize = new System.Drawing.Size(784, 600);
            this.Name = "FormDevelopers";
            this.Text = "FormDevelopers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormTitle formTitle1;
        private System.Windows.Forms.Label label1;
    }
}