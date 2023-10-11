namespace WinFormsApp
{
    partial class body
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
            btn_asa = new Button();
            btn_miru = new Button();
            btn_ban = new Button();
            SuspendLayout();
            // 
            // btn_asa
            // 
            btn_asa.BackColor = Color.Red;
            btn_asa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_asa.ForeColor = Color.White;
            btn_asa.Location = new Point(90, 196);
            btn_asa.Name = "btn_asa";
            btn_asa.Size = new Size(132, 59);
            btn_asa.TabIndex = 0;
            btn_asa.Text = "btn asa";
            btn_asa.UseVisualStyleBackColor = false;
            btn_asa.Click += button1_Click;
            // 
            // btn_miru
            // 
            btn_miru.BackColor = Color.White;
            btn_miru.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_miru.ForeColor = Color.Black;
            btn_miru.Location = new Point(342, 196);
            btn_miru.Name = "btn_miru";
            btn_miru.Size = new Size(132, 59);
            btn_miru.TabIndex = 1;
            btn_miru.Text = "btn miru";
            btn_miru.UseVisualStyleBackColor = false;
            btn_miru.Click += btn_miru_Click;
            // 
            // btn_ban
            // 
            btn_ban.BackColor = Color.Blue;
            btn_ban.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ban.ForeColor = Color.White;
            btn_ban.Location = new Point(583, 196);
            btn_ban.Name = "btn_ban";
            btn_ban.Size = new Size(132, 59);
            btn_ban.TabIndex = 2;
            btn_ban.Text = "btn ban";
            btn_ban.UseVisualStyleBackColor = false;
            btn_ban.Click += button3_Click;
            // 
            // body
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ban);
            Controls.Add(btn_miru);
            Controls.Add(btn_asa);
            Name = "body";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_asa;
        private Button btn_miru;
        private Button btn_ban;
    }
}