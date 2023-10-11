namespace WinFormsApp_ADO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIds = new TextBox();
            txtDOB = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            rFemale = new RadioButton();
            rMale = new RadioButton();
            label5 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgView).BeginInit();
            SuspendLayout();
            // 
            // dgView
            // 
            dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgView.Location = new Point(51, 356);
            dgView.Name = "dgView";
            dgView.RowHeadersWidth = 51;
            dgView.RowTemplate.Height = 29;
            dgView.Size = new Size(727, 252);
            dgView.TabIndex = 0;
            dgView.CellClick += dgView_CellClick;
            dgView.CellContentClick += dgView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 69);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Customer Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 159);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 2;
            label2.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 249);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 66);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 4;
            label4.Text = "Customer name";
            // 
            // txtIds
            // 
            txtIds.Location = new Point(170, 66);
            txtIds.Name = "txtIds";
            txtIds.Size = new Size(233, 27);
            txtIds.TabIndex = 5;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(170, 152);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(233, 27);
            txtDOB.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(170, 246);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(596, 27);
            txtAddress.TabIndex = 7;
            txtAddress.TextChanged += textBox3_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(558, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 8;
            // 
            // rFemale
            // 
            rFemale.AutoSize = true;
            rFemale.Location = new Point(611, 159);
            rFemale.Name = "rFemale";
            rFemale.Size = new Size(78, 24);
            rFemale.TabIndex = 9;
            rFemale.TabStop = true;
            rFemale.Text = "Female";
            rFemale.UseVisualStyleBackColor = true;
            rFemale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rMale
            // 
            rMale.AutoSize = true;
            rMale.Location = new Point(525, 159);
            rMale.Name = "rMale";
            rMale.Size = new Size(63, 24);
            rMale.TabIndex = 10;
            rMale.TabStop = true;
            rMale.Text = "Male";
            rMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 159);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 11;
            label5.Text = "Gender";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(129, 306);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(295, 306);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(456, 306);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(611, 306);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 662);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(rMale);
            Controls.Add(rFemale);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(txtDOB);
            Controls.Add(txtIds);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIds;
        private TextBox txtDOB;
        private TextBox txtAddress;
        private TextBox txtName;
        private RadioButton rFemale;
        private RadioButton rMale;
        private Label label5;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
    }
}