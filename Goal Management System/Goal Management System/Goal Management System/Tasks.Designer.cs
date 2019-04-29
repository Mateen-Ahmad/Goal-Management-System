namespace Goal_Management_System
{
    partial class Tasks
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
            this.userControl11 = new Goal_Management_System.UserControl1();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.EditTask = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteTask = new System.Windows.Forms.DataGridViewButtonColumn();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbGoalName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRoleType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 36);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(150, 370);
            this.userControl11.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tasks";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Date";
            // 
            // DataGridViewTasks
            // 
            this.DataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditTask,
            this.DeleteTask});
            this.DataGridViewTasks.Location = new System.Drawing.Point(138, 275);
            this.DataGridViewTasks.Name = "DataGridViewTasks";
            this.DataGridViewTasks.Size = new System.Drawing.Size(645, 125);
            this.DataGridViewTasks.TabIndex = 23;
            // 
            // EditTask
            // 
            this.EditTask.HeaderText = "Edit";
            this.EditTask.Name = "EditTask";
            this.EditTask.Text = "Edit";
            this.EditTask.UseColumnTextForButtonValue = true;
            // 
            // DeleteTask
            // 
            this.DeleteTask.HeaderText = "Delete";
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Text = "Delete";
            this.DeleteTask.UseColumnTextForButtonValue = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(584, 228);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(19, 20);
            this.linkLabel2.TabIndex = 22;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "+";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(402, 188);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(100, 20);
            this.txtTaskName.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(373, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // cmbGoalName
            // 
            this.cmbGoalName.FormattingEnabled = true;
            this.cmbGoalName.Location = new System.Drawing.Point(402, 99);
            this.cmbGoalName.Name = "cmbGoalName";
            this.cmbGoalName.Size = new System.Drawing.Size(121, 21);
            this.cmbGoalName.TabIndex = 19;
            this.cmbGoalName.SelectedIndexChanged += new System.EventHandler(this.CmbGoalName_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "To-do";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Type";
            // 
            // lblRoleType
            // 
            this.lblRoleType.AutoSize = true;
            this.lblRoleType.Location = new System.Drawing.Point(439, 159);
            this.lblRoleType.Name = "lblRoleType";
            this.lblRoleType.Size = new System.Drawing.Size(0, 13);
            this.lblRoleType.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Goal";
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(439, 138);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(0, 13);
            this.lblRoleName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Role Name";
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DataGridViewTasks);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbGoalName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblRoleType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userControl11);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Tasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DataGridViewTasks;
        private System.Windows.Forms.DataGridViewButtonColumn EditTask;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteTask;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbGoalName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRoleType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label label7;
    }
}