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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevelopers));
            this.labelIntro = new System.Windows.Forms.Label();
            this.labelTeamLead = new System.Windows.Forms.Label();
            this.labelAlgorithms = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelUI = new System.Windows.Forms.Label();
            this.labelExceptions = new System.Windows.Forms.Label();
            this.labelOutro = new System.Windows.Forms.Label();
            this.styledButtonLicense = new code.StyledButton();
            this.styledButtonGithubLink = new code.StyledButton();
            this.formTitle1 = new code.MainTitle();
            this.SuspendLayout();
            // 
            // labelIntro
            // 
            this.labelIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntro.Location = new System.Drawing.Point(14, 66);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(739, 44);
            this.labelIntro.TabIndex = 1;
            this.labelIntro.Text = "Проєкт реалізувала команда розробників з групи КНТ-122. Склад команди та розподіл" +
    "ення відповідальностей і ролей:";
            // 
            // labelTeamLead
            // 
            this.labelTeamLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamLead.Location = new System.Drawing.Point(12, 110);
            this.labelTeamLead.Name = "labelTeamLead";
            this.labelTeamLead.Size = new System.Drawing.Size(739, 23);
            this.labelTeamLead.TabIndex = 1;
            this.labelTeamLead.Text = "- Кирило Коганті - розробка класів та архітектури - Team Lead";
            // 
            // labelAlgorithms
            // 
            this.labelAlgorithms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithms.Location = new System.Drawing.Point(12, 133);
            this.labelAlgorithms.Name = "labelAlgorithms";
            this.labelAlgorithms.Size = new System.Drawing.Size(739, 23);
            this.labelAlgorithms.TabIndex = 1;
            this.labelAlgorithms.Text = "- Коваленко Владислав - імплементація алгоритмів - Algorithms";
            // 
            // labelData
            // 
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(12, 156);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(739, 23);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "- Барабаш Антон - робота з даними - Data";
            // 
            // labelUI
            // 
            this.labelUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUI.Location = new System.Drawing.Point(12, 179);
            this.labelUI.Name = "labelUI";
            this.labelUI.Size = new System.Drawing.Size(739, 23);
            this.labelUI.TabIndex = 1;
            this.labelUI.Text = "- Онищенко Олег - розробка інтерфейсу та дизайну - UI/UX";
            // 
            // labelExceptions
            // 
            this.labelExceptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExceptions.Location = new System.Drawing.Point(12, 202);
            this.labelExceptions.Name = "labelExceptions";
            this.labelExceptions.Size = new System.Drawing.Size(739, 23);
            this.labelExceptions.TabIndex = 1;
            this.labelExceptions.Text = "- Васильєв Максим - обробка виняткових ситуацій - Exceptions";
            // 
            // labelOutro
            // 
            this.labelOutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutro.Location = new System.Drawing.Point(14, 236);
            this.labelOutro.Name = "labelOutro";
            this.labelOutro.Size = new System.Drawing.Size(739, 44);
            this.labelOutro.TabIndex = 1;
            this.labelOutro.Text = resources.GetString("labelOutro.Text");
            // 
            // styledButtonLicense
            // 
            this.styledButtonLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.styledButtonLicense.FlatAppearance.BorderSize = 0;
            this.styledButtonLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styledButtonLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styledButtonLicense.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.styledButtonLicense.Location = new System.Drawing.Point(113, 287);
            this.styledButtonLicense.Name = "styledButtonLicense";
            this.styledButtonLicense.Size = new System.Drawing.Size(104, 30);
            this.styledButtonLicense.TabIndex = 3;
            this.styledButtonLicense.Text = "Ліцензія";
            this.styledButtonLicense.UseVisualStyleBackColor = false;
            this.styledButtonLicense.Click += new System.EventHandler(this.styledButtonLicense_Click);
            // 
            // styledButtonGithubLink
            // 
            this.styledButtonGithubLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.styledButtonGithubLink.FlatAppearance.BorderSize = 0;
            this.styledButtonGithubLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styledButtonGithubLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styledButtonGithubLink.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.styledButtonGithubLink.Location = new System.Drawing.Point(17, 287);
            this.styledButtonGithubLink.Name = "styledButtonGithubLink";
            this.styledButtonGithubLink.Size = new System.Drawing.Size(90, 30);
            this.styledButtonGithubLink.TabIndex = 2;
            this.styledButtonGithubLink.Text = "Гітхаб";
            this.styledButtonGithubLink.UseVisualStyleBackColor = false;
            this.styledButtonGithubLink.Click += new System.EventHandler(this.styledButtonGithubLink_Click);
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
            // FormDevelopers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(768, 561);
            this.Controls.Add(this.styledButtonLicense);
            this.Controls.Add(this.styledButtonGithubLink);
            this.Controls.Add(this.labelExceptions);
            this.Controls.Add(this.labelUI);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelAlgorithms);
            this.Controls.Add(this.labelTeamLead);
            this.Controls.Add(this.labelOutro);
            this.Controls.Add(this.labelIntro);
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

        private MainTitle formTitle1;
        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.Label labelTeamLead;
        private System.Windows.Forms.Label labelAlgorithms;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelUI;
        private System.Windows.Forms.Label labelExceptions;
        private StyledButton styledButtonGithubLink;
        private System.Windows.Forms.Label labelOutro;
        private StyledButton styledButtonLicense;
    }
}