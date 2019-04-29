namespace Goal_Management_System
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnGoals = new System.Windows.Forms.Button();
            this.btnToDos = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(30, 41);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(75, 23);
            this.btnRoles.TabIndex = 0;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.BtnRoles_Click);
            // 
            // btnGoals
            // 
            this.btnGoals.Location = new System.Drawing.Point(30, 107);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Size = new System.Drawing.Size(75, 23);
            this.btnGoals.TabIndex = 1;
            this.btnGoals.Text = "Goals";
            this.btnGoals.UseVisualStyleBackColor = true;
            this.btnGoals.Click += new System.EventHandler(this.BtnGoals_Click);
            // 
            // btnToDos
            // 
            this.btnToDos.Location = new System.Drawing.Point(30, 169);
            this.btnToDos.Name = "btnToDos";
            this.btnToDos.Size = new System.Drawing.Size(75, 23);
            this.btnToDos.TabIndex = 2;
            this.btnToDos.Text = "To-dos";
            this.btnToDos.UseVisualStyleBackColor = true;
            this.btnToDos.Click += new System.EventHandler(this.BtnToDos_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(30, 261);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(75, 23);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnToDos);
            this.Controls.Add(this.btnGoals);
            this.Controls.Add(this.btnRoles);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(150, 370);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Button btnToDos;
        private System.Windows.Forms.Button btnReports;
    }
}
