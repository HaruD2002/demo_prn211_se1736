namespace WinFormsApp
{
    public partial class Frmgenerateauto : Form
    {
        public Frmgenerateauto()
        {
            InitializeComponent();
        }

        private void Frmgenerateauto_Load(object sender, EventArgs e)
        {

        }

        int n;
        List<TextBox> listTxtbox = new List<TextBox>();
        List<CheckBox> list_check_box = new List<CheckBox>();
        private void btn_create_box_Click(object sender, EventArgs e)
        {
            n = (int)numDrop.Value;
            for (int i = 0; i < n; i++)
            {
                // create label
                Label lbl = new Label();
                lbl.Location = new Point(411, 162 + i * 60);
                lbl.Size = new Size(100, 20);
                lbl.Text = "enter text " + (i + 1);
                Controls.Add(lbl);

                TextBox txt_box = new TextBox();
                txt_box.Location = new Point(550, 155 + i * 60);
                txt_box.Size = new Size(125, 27);
                txt_box.TextChanged += ChangeText;
                Controls.Add(txt_box);
                listTxtbox.Add(txt_box);

            }


            btn_check.Enabled = true;
        }

        private void ChangeText(object? sender, EventArgs e)
        {
            TextBox this_txt_box = (TextBox)sender;
            if (list_check_box.Count == 0) {
                return;
            }
            for (int i = 0; i < listTxtbox.Count; i++) {
                    // ádasdasdsa
                if (listTxtbox[i].Equals(this_txt_box)) {
                    //asdsadhsad
                    list_check_box[i].Text = this_txt_box.Text;
                }
            }

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                CheckBox cbox = new CheckBox();
                cbox.Location = new Point(700, 155 + i * 60);
                cbox.Text = listTxtbox[i].Text;
                cbox.Size = new Size(125, 27);
                Controls.Add(cbox);
                list_check_box.Add(cbox);
                cbox.CheckedChanged += cbox_change;
            }
        }

        private void cbox_change(object? sender, EventArgs e)
        {
            // sender use to identify the parent that send the information
            CheckBox cb = (CheckBox)sender;
            String status = cb.Checked?"check": "not check";
            MessageBox.Show("check box: " + cb.Text + "is " + status);
        }
    }
}
