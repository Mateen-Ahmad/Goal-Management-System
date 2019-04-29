namespace Goal_Management_System
{
    partial class Goals
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
            this.label4 = new System.Windows.Forms.Label();
            this.lnklblAddGoal = new System.Windows.Forms.LinkLabel();
            this.lblShowRoleType = new System.Windows.Forms.Label();
            this.GoalGridView = new System.Windows.Forms.DataGridView();
            this.Goal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteGoal = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditGoal = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AddTasks = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.cmbRoleName = new System.Windows.Forms.ComboBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblGoalRole = new System.Windows.Forms.Label();
            this.lblGoalRoleType = new System.Windows.Forms.Label();
            this.userControl11 = new Goal_Management_System.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.GoalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Goals";
            // 
            // lnklblAddGoal
            // 
            this.lnklblAddGoal.AutoSize = true;
            this.lnklblAddGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblAddGoal.LinkColor = System.Drawing.Color.Black;
            this.lnklblAddGoal.Location = new System.Drawing.Point(580, 194);
            this.lnklblAddGoal.Name = "lnklblAddGoal";
            this.lnklblAddGoal.Size = new System.Drawing.Size(19, 20);
            this.lnklblAddGoal.TabIndex = 17;
            this.lnklblAddGoal.TabStop = true;
            this.lnklblAddGoal.Text = "+";
            this.lnklblAddGoal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnklblAddGoal_LinkClicked);
            // 
            // lblShowRoleType
            // 
            this.lblShowRoleType.AutoSize = true;
            this.lblShowRoleType.Location = new System.Drawing.Point(475, 170);
            this.lblShowRoleType.Name = "lblShowRoleType";
            this.lblShowRoleType.Size = new System.Drawing.Size(0, 13);
            this.lblShowRoleType.TabIndex = 16;
            // 
            // GoalGridView
            // 
            this.GoalGridView.AllowUserToAddRows = false;
            this.GoalGridView.AllowUserToDeleteRows = false;
            this.GoalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Goal,
            this.Type,
            this.DeleteGoal,
            this.EditGoal,
            this.AddTasks});
            this.GoalGridView.Location = new System.Drawing.Point(213, 249);
            this.GoalGridView.Name = "GoalGridView";
            this.GoalGridView.ReadOnly = true;
            this.GoalGridView.Size = new System.Drawing.Size(543, 133);
            this.GoalGridView.TabIndex = 15;
            this.GoalGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoalGridView_CellContentClick);
            // 
            // Goal
            // 
            this.Goal.HeaderText = "Goal";
            this.Goal.Name = "Goal";
            this.Goal.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // DeleteGoal
            // 
            this.DeleteGoal.HeaderText = "Delete";
            this.DeleteGoal.Name = "DeleteGoal";
            this.DeleteGoal.ReadOnly = true;
            this.DeleteGoal.Text = "x";
            this.DeleteGoal.UseColumnTextForButtonValue = true;
            // 
            // EditGoal
            // 
            this.EditGoal.HeaderText = "Edit";
            this.EditGoal.Name = "EditGoal";
            this.EditGoal.ReadOnly = true;
            this.EditGoal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditGoal.Text = "Edit";
            this.EditGoal.TrackVisitedState = false;
            this.EditGoal.UseColumnTextForLinkValue = true;
            // 
            // AddTasks
            // 
            this.AddTasks.HeaderText = "Add to To-Dos";
            this.AddTasks.Name = "AddTasks";
            this.AddTasks.ReadOnly = true;
            this.AddTasks.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddTasks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AddTasks.Text = "+";
            this.AddTasks.UseColumnTextForButtonValue = true;
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(435, 196);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(121, 20);
            this.txtGoal.TabIndex = 14;
            // 
            // cmbRoleName
            // 
            this.cmbRoleName.FormattingEnabled = true;
            this.cmbRoleName.Location = new System.Drawing.Point(435, 129);
            this.cmbRoleName.Name = "cmbRoleName";
            this.cmbRoleName.Size = new System.Drawing.Size(121, 21);
            this.cmbRoleName.TabIndex = 13;
            this.cmbRoleName.SelectedIndexChanged += new System.EventHandler(this.CmbRoleName_SelectedIndexChanged);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(321, 203);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(29, 13);
            this.lblGoal.TabIndex = 12;
            this.lblGoal.Text = "Goal";
            // 
            // lblGoalRole
            // 
            this.lblGoalRole.AutoSize = true;
            this.lblGoalRole.Location = new System.Drawing.Point(321, 132);
            this.lblGoalRole.Name = "lblGoalRole";
            this.lblGoalRole.Size = new System.Drawing.Size(29, 13);
            this.lblGoalRole.TabIndex = 11;
            this.lblGoalRole.Text = "Role";
            // 
            // lblGoalRoleType
            // 
            this.lblGoalRoleType.AutoSize = true;
            this.lblGoalRoleType.Location = new System.Drawing.Point(321, 170);
            this.lblGoalRoleType.Name = "lblGoalRoleType";
            this.lblGoalRoleType.Size = new System.Drawing.Size(31, 13);
            this.lblGoalRoleType.TabIndex = 10;
            this.lblGoalRoleType.Text = "Type";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(30, 34);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(150, 370);
            this.userControl11.TabIndex = 19;
            // 
            // Goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnklblAddGoal);
            this.Controls.Add(this.lblShowRoleType);
            this.Controls.Add(this.GoalGridView);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.cmbRoleName);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblGoalRole);
            this.Controls.Add(this.lblGoalRoleType);
            this.Name = "Goals";
            this.Text = "Goals";
            this.Load += new System.EventHandler(this.Goals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnklblAddGoal;
        private System.Windows.Forms.Label lblShowRoleType;
        private System.Windows.Forms.DataGridView GoalGridView;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.ComboBox cmbRoleName;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblGoalRole;
        private System.Windows.Forms.Label lblGoalRoleType;
        private UserControl1 userControl11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGoal;
        private System.Windows.Forms.DataGridViewLinkColumn EditGoal;
        private System.Windows.Forms.DataGridViewButtonColumn AddTasks;
    }
}