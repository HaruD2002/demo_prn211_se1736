namespace WinFormsApp
{
    partial class Start
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
            components = new System.ComponentModel.Container();
            lStart = new Label();
            s = new Button();
            cdTimer = new System.Windows.Forms.Timer(components);
            tName = new TextBox();
            SuspendLayout();
            // 
            // lStart
            // 
            lStart.AutoSize = true;
            lStart.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            lStart.ImageAlign = ContentAlignment.TopRight;
            lStart.Location = new Point(336, 142);
            lStart.Name = "lStart";
            lStart.Size = new Size(122, 100);
            lStart.TabIndex = 0;
            lStart.Text = "10";
            // 
            // s
            // 
            s.Location = new Point(345, 291);
            s.Name = "s";
            s.Size = new Size(94, 29);
            s.TabIndex = 1;
            s.Text = "start";
            s.UseVisualStyleBackColor = true;
            s.Click += btnStart_Click;
            // 
            // cdTimer
            // 
            cdTimer.Interval = 1000;
            cdTimer.Tick += cdTimer_Tick;
            // 
            // tName
            // 
            tName.Location = new Point(336, 245);
            tName.Name = "tName";
            tName.Size = new Size(125, 27);
            tName.TabIndex = 2;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tName);
            Controls.Add(s);
            Controls.Add(lStart);
            Name = "Start";
            Text = "Start";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lStart;
        private Button s;
        private System.Windows.Forms.Timer cdTimer;
        private TextBox tName;
    }
}