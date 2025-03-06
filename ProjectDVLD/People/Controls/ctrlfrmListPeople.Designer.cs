namespace ProjectDVLD.UserControls
{
    partial class ctrlfrmListPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlfrmListPeople));
            this.picBoxManagePeople = new System.Windows.Forms.PictureBox();
            this.labManagePeople = new System.Windows.Forms.Label();
            this.labFilterBy = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.picBoxAddPerson = new System.Windows.Forms.PictureBox();
            this.DGVGetAllPeople = new System.Windows.Forms.DataGridView();
            this.labRecords = new System.Windows.Forms.Label();
            this.labRecordsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxManagePeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGetAllPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxManagePeople
            // 
            this.picBoxManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("picBoxManagePeople.Image")));
            this.picBoxManagePeople.Location = new System.Drawing.Point(475, 27);
            this.picBoxManagePeople.Name = "picBoxManagePeople";
            this.picBoxManagePeople.Size = new System.Drawing.Size(228, 161);
            this.picBoxManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxManagePeople.TabIndex = 0;
            this.picBoxManagePeople.TabStop = false;
            // 
            // labManagePeople
            // 
            this.labManagePeople.AutoSize = true;
            this.labManagePeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labManagePeople.ForeColor = System.Drawing.Color.Firebrick;
            this.labManagePeople.Location = new System.Drawing.Point(473, 191);
            this.labManagePeople.Name = "labManagePeople";
            this.labManagePeople.Size = new System.Drawing.Size(230, 33);
            this.labManagePeople.TabIndex = 1;
            this.labManagePeople.Text = "Manage People";
            // 
            // labFilterBy
            // 
            this.labFilterBy.AutoSize = true;
            this.labFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.labFilterBy.Location = new System.Drawing.Point(24, 252);
            this.labFilterBy.Name = "labFilterBy";
            this.labFilterBy.Size = new System.Drawing.Size(93, 20);
            this.labFilterBy.TabIndex = 2;
            this.labFilterBy.Text = "Filter By :";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.cbFilterBy.Location = new System.Drawing.Point(123, 252);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 24);
            this.cbFilterBy.TabIndex = 3;
            // 
            // picBoxAddPerson
            // 
            this.picBoxAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAddPerson.Image")));
            this.picBoxAddPerson.Location = new System.Drawing.Point(1140, 226);
            this.picBoxAddPerson.Name = "picBoxAddPerson";
            this.picBoxAddPerson.Size = new System.Drawing.Size(68, 50);
            this.picBoxAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAddPerson.TabIndex = 4;
            this.picBoxAddPerson.TabStop = false;
            this.picBoxAddPerson.Click += new System.EventHandler(this.picBoxAddPerson_Click);
            // 
            // DGVGetAllPeople
            // 
            this.DGVGetAllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGetAllPeople.Location = new System.Drawing.Point(28, 293);
            this.DGVGetAllPeople.Name = "DGVGetAllPeople";
            this.DGVGetAllPeople.Size = new System.Drawing.Size(1180, 333);
            this.DGVGetAllPeople.TabIndex = 5;
            // 
            // labRecords
            // 
            this.labRecords.AutoSize = true;
            this.labRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.labRecords.Location = new System.Drawing.Point(24, 640);
            this.labRecords.Name = "labRecords";
            this.labRecords.Size = new System.Drawing.Size(107, 20);
            this.labRecords.TabIndex = 6;
            this.labRecords.Text = "# Records :";
            // 
            // labRecordsCount
            // 
            this.labRecordsCount.AutoSize = true;
            this.labRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.labRecordsCount.Location = new System.Drawing.Point(137, 640);
            this.labRecordsCount.Name = "labRecordsCount";
            this.labRecordsCount.Size = new System.Drawing.Size(19, 20);
            this.labRecordsCount.TabIndex = 7;
            this.labRecordsCount.Text = "0";
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labRecordsCount);
            this.Controls.Add(this.labRecords);
            this.Controls.Add(this.DGVGetAllPeople);
            this.Controls.Add(this.picBoxAddPerson);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.labFilterBy);
            this.Controls.Add(this.labManagePeople);
            this.Controls.Add(this.picBoxManagePeople);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(1228, 686);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxManagePeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGetAllPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxManagePeople;
        private System.Windows.Forms.Label labManagePeople;
        private System.Windows.Forms.Label labFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.PictureBox picBoxAddPerson;
        private System.Windows.Forms.DataGridView DGVGetAllPeople;
        private System.Windows.Forms.Label labRecords;
        private System.Windows.Forms.Label labRecordsCount;
    }
}
