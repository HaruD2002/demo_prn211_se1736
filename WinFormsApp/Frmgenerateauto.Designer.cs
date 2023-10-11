namespace WinFormsApp
{
    partial class Frmgenerateauto
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
            label1 = new Label();
            numDrop = new NumericUpDown();
            btn_create_box = new Button();
            btn_check = new Button();
            ((System.ComponentModel.ISupportInitialize)numDrop).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 38);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter text number";
            // 
            // numDrop
            // 
            numDrop.Location = new Point(375, 36);
            numDrop.Name = "numDrop";
            numDrop.Size = new Size(330, 27);
            numDrop.TabIndex = 1;
            // 
            // btn_create_box
            // 
            btn_create_box.Location = new Point(711, 34);
            btn_create_box.Name = "btn_create_box";
            btn_create_box.Size = new Size(136, 27);
            btn_create_box.TabIndex = 2;
            btn_create_box.Text = "create text box";
            btn_create_box.UseVisualStyleBackColor = true;
            btn_create_box.Click += btn_create_box_Click;
            // 
            // btn_check
            // 
            btn_check.Enabled = false;
            btn_check.Location = new Point(12, 441);
            btn_check.Name = "btn_check";
            btn_check.Size = new Size(132, 39);
            btn_check.TabIndex = 3;
            btn_check.Text = "add checkbox";
            btn_check.UseVisualStyleBackColor = true;
            btn_check.Click += btn_check_Click;
            // 
            // Frmgenerateauto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 492);
            Controls.Add(btn_check);
            Controls.Add(btn_create_box);
            Controls.Add(numDrop);
            Controls.Add(label1);
            Name = "Frmgenerateauto";
            Text = "Frmgenerateauto";
            Load += Frmgenerateauto_Load;
            ((System.ComponentModel.ISupportInitialize)numDrop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numDrop;
        private Button btn_create_box;
        private Button btn_check;
    }
}