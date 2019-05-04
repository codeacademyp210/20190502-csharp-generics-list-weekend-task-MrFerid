namespace RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 229);
            this.panel1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.AccessibleDescription = "onlyString";
            this.txtName.AccessibleName = "Ad";
            this.txtName.Location = new System.Drawing.Point(88, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.AccessibleDescription = "onlyString";
            this.txtSurname.AccessibleName = "Soyad";
            this.txtSurname.Location = new System.Drawing.Point(88, 67);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(248, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleDescription = "emailType";
            this.txtEmail.AccessibleName = "Email";
            this.txtEmail.Location = new System.Drawing.Point(88, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPosition
            // 
            this.txtPosition.AccessibleDescription = "any";
            this.txtPosition.AccessibleName = "Vezife";
            this.txtPosition.Location = new System.Drawing.Point(88, 142);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(248, 22);
            this.txtPosition.TabIndex = 1;
            // 
            // txtSalary
            // 
            this.txtSalary.AccessibleDescription = "onlyDouble";
            this.txtSalary.AccessibleName = "Maash";
            this.txtSalary.Location = new System.Drawing.Point(88, 181);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(248, 22);
            this.txtSalary.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Maash:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vezife:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad: ";
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(8, 326);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(0, 19);
            this.txtError.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(132, 257);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(240, 45);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.tName,
            this.tSurname,
            this.tEmail,
            this.tPosition,
            this.tSalary});
            this.dataGridView1.Location = new System.Drawing.Point(387, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 290);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // txtID
            // 
            this.txtID.HeaderText = "ID";
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // tName
            // 
            this.tName.HeaderText = "Name";
            this.tName.Name = "tName";
            this.tName.ReadOnly = true;
            // 
            // tSurname
            // 
            this.tSurname.HeaderText = "Surname";
            this.tSurname.Name = "tSurname";
            this.tSurname.ReadOnly = true;
            // 
            // tEmail
            // 
            this.tEmail.HeaderText = "Email";
            this.tEmail.Name = "tEmail";
            this.tEmail.ReadOnly = true;
            // 
            // tPosition
            // 
            this.tPosition.HeaderText = "Position";
            this.tPosition.Name = "tPosition";
            this.tPosition.ReadOnly = true;
            // 
            // tSalary
            // 
            this.tSalary.HeaderText = "Salary";
            this.tSalary.Name = "tSalary";
            this.tSalary.ReadOnly = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(834, 308);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(197, 56);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.DeleteRow);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 488);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSalary;
    }
}

