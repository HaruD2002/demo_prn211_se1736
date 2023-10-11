namespace WinFormsApp
{
    partial class practise
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
            winForm_name = new Label();
            groupBox1 = new GroupBox();
            cSubject = new ComboBox();
            nMark = new NumericUpDown();
            Itxt_name = new TextBox();
            Itxt_code = new TextBox();
            lMark = new Label();
            lSubject = new Label();
            lName = new Label();
            l_code = new Label();
            button1 = new Button();
            btnRemove = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            button5 = new Button();
            groupBox2 = new GroupBox();
            lstStudent = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nMark).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // winForm_name
            // 
            winForm_name.AutoSize = true;
            winForm_name.BackColor = SystemColors.Control;
            winForm_name.FlatStyle = FlatStyle.System;
            winForm_name.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            winForm_name.ForeColor = Color.Green;
            winForm_name.Location = new Point(197, 31);
            winForm_name.Name = "winForm_name";
            winForm_name.Size = new Size(453, 57);
            winForm_name.TabIndex = 0;
            winForm_name.Text = "Student Management";
            winForm_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cSubject);
            groupBox1.Controls.Add(nMark);
            groupBox1.Controls.Add(Itxt_name);
            groupBox1.Controls.Add(Itxt_code);
            groupBox1.Controls.Add(lMark);
            groupBox1.Controls.Add(lSubject);
            groupBox1.Controls.Add(lName);
            groupBox1.Controls.Add(l_code);
            groupBox1.Location = new Point(31, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 314);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // cSubject
            // 
            cSubject.FormattingEnabled = true;
            cSubject.Items.AddRange(new object[] { "Math", "Design", "Literature" });
            cSubject.Location = new Point(92, 164);
            cSubject.Name = "cSubject";
            cSubject.Size = new Size(218, 28);
            cSubject.TabIndex = 7;
            // 
            // nMark
            // 
            nMark.Location = new Point(92, 215);
            nMark.Name = "nMark";
            nMark.Size = new Size(218, 27);
            nMark.TabIndex = 6;
            // 
            // Itxt_name
            // 
            Itxt_name.Location = new Point(92, 101);
            Itxt_name.Name = "Itxt_name";
            Itxt_name.Size = new Size(218, 27);
            Itxt_name.TabIndex = 4;
            Itxt_name.FontChanged += Itxt_name_FontChanged;
            Itxt_name.Enter += Itxt_name_Enter;
            Itxt_name.Leave += Itxt_name_Leave;
            // 
            // Itxt_code
            // 
            Itxt_code.Location = new Point(92, 44);
            Itxt_code.Name = "Itxt_code";
            Itxt_code.Size = new Size(218, 27);
            Itxt_code.TabIndex = 1;
            Itxt_code.Enter += Itxt_code_Enter;
            Itxt_code.Leave += Itxt_code_Leave;
            // 
            // lMark
            // 
            lMark.AutoSize = true;
            lMark.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lMark.ForeColor = Color.Green;
            lMark.Location = new Point(19, 215);
            lMark.Name = "lMark";
            lMark.Size = new Size(50, 20);
            lMark.TabIndex = 3;
            lMark.Text = "Mark:";
            // 
            // lSubject
            // 
            lSubject.AutoSize = true;
            lSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lSubject.ForeColor = Color.Green;
            lSubject.Location = new Point(19, 159);
            lSubject.Name = "lSubject";
            lSubject.Size = new Size(64, 20);
            lSubject.TabIndex = 2;
            lSubject.Text = "Subject:";
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lName.ForeColor = Color.Green;
            lName.Location = new Point(19, 104);
            lName.Name = "lName";
            lName.Size = new Size(55, 20);
            lName.TabIndex = 1;
            lName.Text = "Name:";
            // 
            // l_code
            // 
            l_code.AutoSize = true;
            l_code.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_code.ForeColor = Color.Green;
            l_code.Location = new Point(19, 44);
            l_code.Name = "l_code";
            l_code.Size = new Size(48, 20);
            l_code.TabIndex = 0;
            l_code.Text = "Code:";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Firebrick;
            button1.Location = new Point(379, 125);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Silver;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.Firebrick;
            btnRemove.Location = new Point(379, 172);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Silver;
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ForeColor = Color.Firebrick;
            btnLoad.Location = new Point(379, 220);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Silver;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Firebrick;
            btnSave.Location = new Point(379, 271);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Silver;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Firebrick;
            button5.Location = new Point(379, 322);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 7;
            button5.Text = "EXIT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstStudent);
            groupBox2.Location = new Point(506, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(610, 305);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output";
            // 
            // lstStudent
            // 
            lstStudent.FormattingEnabled = true;
            lstStudent.ItemHeight = 20;
            lstStudent.Location = new Point(19, 32);
            lstStudent.Name = "lstStudent";
            lstStudent.Size = new Size(554, 244);
            lstStudent.TabIndex = 1;
            // 
            // practise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 450);
            Controls.Add(groupBox2);
            Controls.Add(button5);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(btnRemove);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(winForm_name);
            Name = "practise";
            Text = "practise";
            FormClosing += practise_FormClosing;
            FormClosed += practise_FormClosed;
            Load += practise_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nMark).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label winForm_name;
        private GroupBox groupBox1;
        private Label lMark;
        private Label lSubject;
        private Label lName;
        private Label l_code;
        private NumericUpDown nMark;
        private TextBox Itxt_name;
        private TextBox Itxt_code;
        private Button button1;
        private Button btnRemove;
        private Button btnLoad;
        private Button btnSave;
        private Button button5;
        private GroupBox groupBox2;
        private ListBox lstStudent;
        private ComboBox cSubject;
    }
}