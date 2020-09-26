namespace SSE_Personnel_System
{
    partial class AddEmployee
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblManagerNm = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblFirstNm = new System.Windows.Forms.Label();
            this.lblLastNm = new System.Windows.Forms.Label();
            this.cmbManagerNm = new System.Windows.Forms.ComboBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtFirstNm = new System.Windows.Forms.TextBox();
            this.txtLastNm = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lsbRoleNm = new System.Windows.Forms.ListBox();
            this.lblRoleNm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(236, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Employee";
            // 
            // lblManagerNm
            // 
            this.lblManagerNm.AutoSize = true;
            this.lblManagerNm.Location = new System.Drawing.Point(213, 104);
            this.lblManagerNm.Name = "lblManagerNm";
            this.lblManagerNm.Size = new System.Drawing.Size(52, 13);
            this.lblManagerNm.TabIndex = 1;
            this.lblManagerNm.Text = "Manager:";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(213, 165);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(68, 13);
            this.lblEmployeeId.TabIndex = 2;
            this.lblEmployeeId.Text = "Employee Id:";
            // 
            // lblFirstNm
            // 
            this.lblFirstNm.AutoSize = true;
            this.lblFirstNm.Location = new System.Drawing.Point(214, 212);
            this.lblFirstNm.Name = "lblFirstNm";
            this.lblFirstNm.Size = new System.Drawing.Size(58, 13);
            this.lblFirstNm.TabIndex = 3;
            this.lblFirstNm.Text = "First name:";
            // 
            // lblLastNm
            // 
            this.lblLastNm.AutoSize = true;
            this.lblLastNm.Location = new System.Drawing.Point(213, 258);
            this.lblLastNm.Name = "lblLastNm";
            this.lblLastNm.Size = new System.Drawing.Size(59, 13);
            this.lblLastNm.TabIndex = 4;
            this.lblLastNm.Text = "Last name:";
            // 
            // cmbManagerNm
            // 
            this.cmbManagerNm.FormattingEnabled = true;
            this.cmbManagerNm.Location = new System.Drawing.Point(291, 104);
            this.cmbManagerNm.Name = "cmbManagerNm";
            this.cmbManagerNm.Size = new System.Drawing.Size(196, 21);
            this.cmbManagerNm.TabIndex = 5;
            this.cmbManagerNm.SelectedIndexChanged += new System.EventHandler(this.cmbManagerNm_SelectedIndexChanged);
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(291, 165);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(196, 20);
            this.txtEmployeeId.TabIndex = 6;
            // 
            // txtFirstNm
            // 
            this.txtFirstNm.Location = new System.Drawing.Point(291, 209);
            this.txtFirstNm.Name = "txtFirstNm";
            this.txtFirstNm.Size = new System.Drawing.Size(196, 20);
            this.txtFirstNm.TabIndex = 7;
            // 
            // txtLastNm
            // 
            this.txtLastNm.Location = new System.Drawing.Point(291, 255);
            this.txtLastNm.Name = "txtLastNm";
            this.txtLastNm.Size = new System.Drawing.Size(196, 20);
            this.txtLastNm.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(242, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lsbRoleNm
            // 
            this.lsbRoleNm.FormattingEnabled = true;
            this.lsbRoleNm.Location = new System.Drawing.Point(291, 306);
            this.lsbRoleNm.Name = "lsbRoleNm";
            this.lsbRoleNm.Size = new System.Drawing.Size(196, 56);
            this.lsbRoleNm.TabIndex = 11;
            // 
            // lblRoleNm
            // 
            this.lblRoleNm.AutoSize = true;
            this.lblRoleNm.Location = new System.Drawing.Point(214, 306);
            this.lblRoleNm.Name = "lblRoleNm";
            this.lblRoleNm.Size = new System.Drawing.Size(37, 13);
            this.lblRoleNm.TabIndex = 12;
            this.lblRoleNm.Text = "Roles:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRoleNm);
            this.Controls.Add(this.lsbRoleNm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLastNm);
            this.Controls.Add(this.txtFirstNm);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.cmbManagerNm);
            this.Controls.Add(this.lblLastNm);
            this.Controls.Add(this.lblFirstNm);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.lblManagerNm);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblManagerNm;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblFirstNm;
        private System.Windows.Forms.Label lblLastNm;
        private System.Windows.Forms.ComboBox cmbManagerNm;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtFirstNm;
        private System.Windows.Forms.TextBox txtLastNm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lsbRoleNm;
        private System.Windows.Forms.Label lblRoleNm;
    }
}