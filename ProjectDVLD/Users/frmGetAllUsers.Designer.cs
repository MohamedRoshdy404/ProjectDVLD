namespace ProjectDVLD.Users
{
    partial class frmGetAllUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetAllUsers));
            this.DGVGetAllUsers = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.labFilterBy = new System.Windows.Forms.Label();
            this.labManageUsers = new System.Windows.Forms.Label();
            this.picBoxManagePeople = new System.Windows.Forms.PictureBox();
            this.picBoxAddPerson = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGetAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxManagePeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVGetAllUsers
            // 
            this.DGVGetAllUsers.AllowUserToAddRows = false;
            this.DGVGetAllUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVGetAllUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVGetAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVGetAllUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVGetAllUsers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVGetAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVGetAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVGetAllUsers.DefaultCellStyle = dataGridViewCellStyle7;
            this.DGVGetAllUsers.Location = new System.Drawing.Point(38, 341);
            this.DGVGetAllUsers.Name = "DGVGetAllUsers";
            this.DGVGetAllUsers.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVGetAllUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVGetAllUsers.Size = new System.Drawing.Size(837, 309);
            this.DGVGetAllUsers.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(319, 300);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(240, 27);
            this.txtFilter.TabIndex = 13;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "UserName",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(133, 300);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(180, 24);
            this.cbFilterBy.TabIndex = 12;
            // 
            // labFilterBy
            // 
            this.labFilterBy.AutoSize = true;
            this.labFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.labFilterBy.Location = new System.Drawing.Point(34, 300);
            this.labFilterBy.Name = "labFilterBy";
            this.labFilterBy.Size = new System.Drawing.Size(93, 20);
            this.labFilterBy.TabIndex = 11;
            this.labFilterBy.Text = "Filter By :";
            // 
            // labManageUsers
            // 
            this.labManageUsers.AutoSize = true;
            this.labManageUsers.Font = new System.Drawing.Font("beIN Normal ", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labManageUsers.ForeColor = System.Drawing.Color.Firebrick;
            this.labManageUsers.Location = new System.Drawing.Point(347, 187);
            this.labManageUsers.Name = "labManageUsers";
            this.labManageUsers.Size = new System.Drawing.Size(221, 68);
            this.labManageUsers.TabIndex = 10;
            this.labManageUsers.Text = "Manage Users";
            // 
            // picBoxManagePeople
            // 
            this.picBoxManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("picBoxManagePeople.Image")));
            this.picBoxManagePeople.Location = new System.Drawing.Point(347, 23);
            this.picBoxManagePeople.Name = "picBoxManagePeople";
            this.picBoxManagePeople.Size = new System.Drawing.Size(228, 161);
            this.picBoxManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxManagePeople.TabIndex = 9;
            this.picBoxManagePeople.TabStop = false;
            // 
            // picBoxAddPerson
            // 
            this.picBoxAddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAddPerson.Image")));
            this.picBoxAddPerson.Location = new System.Drawing.Point(807, 274);
            this.picBoxAddPerson.Name = "picBoxAddPerson";
            this.picBoxAddPerson.Size = new System.Drawing.Size(68, 50);
            this.picBoxAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAddPerson.TabIndex = 14;
            this.picBoxAddPerson.TabStop = false;
            // 
            // frmGetAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 681);
            this.Controls.Add(this.picBoxAddPerson);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.labFilterBy);
            this.Controls.Add(this.labManageUsers);
            this.Controls.Add(this.picBoxManagePeople);
            this.Controls.Add(this.DGVGetAllUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGetAllUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetAllUsers";
            this.Load += new System.EventHandler(this.GetAllUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGetAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxManagePeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVGetAllUsers;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label labFilterBy;
        private System.Windows.Forms.Label labManageUsers;
        private System.Windows.Forms.PictureBox picBoxManagePeople;
        private System.Windows.Forms.PictureBox picBoxAddPerson;
    }
}