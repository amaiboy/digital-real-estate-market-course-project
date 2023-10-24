namespace code.Forms
{
    partial class FormMarket
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
            this.formTitle = new code.FormTitle();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.Black;
            this.formTitle.Location = new System.Drawing.Point(12, 24);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(221, 26);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "Ринок нерухомості";
            // 
            // FormMarket
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(768, 561);
            this.Controls.Add(this.formTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(784, 600);
            this.MinimumSize = new System.Drawing.Size(784, 600);
            this.Name = "FormMarket";
            this.Text = "FormMarket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormTitle formTitle;
    }
}