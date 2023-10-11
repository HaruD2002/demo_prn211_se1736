using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.model;

namespace WinFormsApp
{
    public partial class practise : Form
    {
        public practise()
        {
            InitializeComponent();
            cSubject.Items.Add("Java");
        }

        public practise(string text)
        {
            Text = text;
            InitializeComponent();
            Text = "Welcome " + text; //text of form will go to title
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Itxt_code_Enter(object sender, EventArgs e)
        {
            Itxt_code.BackColor = Color.Pink;
        }

        private void Itxt_code_Leave(object sender, EventArgs e)
        {
            Itxt_code.BackColor = Color.White;
        }

        private void Itxt_name_Leave(object sender, EventArgs e)
        {

            Itxt_name.BackColor = Color.White;
        }

        private void Itxt_name_FontChanged(object sender, EventArgs e)
        {

        }

        private void Itxt_name_Enter(object sender, EventArgs e)
        {

            Itxt_name.BackColor = Color.Pink;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "do you want to exit?", "Alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // Close();
                // xoa winform app trong task manager nếu có lỗi vẫn chạy
                Application.Exit();
            }
        }

        private void practise_Load(object sender, EventArgs e)
        {

        }
        List<Student> students = new List<Student>();
        Dictionary<int, Student> dic = new Dictionary<int, Student>(); //create a dictionary
        private void button1_Click(object sender, EventArgs e)
        {
            int code = Int32.Parse(Itxt_code.Text.Trim());
            if (dic.ContainsKey(code))
            {
                MessageBox.Show("da ton tai");
                return;
            }
            Student s = new Student()
            {
                Code = code, // Student code is int
                Name = Itxt_name.Text,
                Subject = cSubject.SelectedItem.ToString(),
                Mark = (int)nMark.Value

            };
            students.Add(s);
            lstStudent.Items.Add(s);
            dic.Add(code, s);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstStudent.SelectedIndex == -1)
            {
                MessageBox.Show("please select student");
                return;
            }
            string item = lstStudent.SelectedItem.ToString();
            string[] s = item.Split("\t");
            int index = lstStudent.SelectedIndex;
            lstStudent.Items.RemoveAt(index);
            students.RemoveAt(index);
            dic.Remove(Int32.Parse(s[0]));
        }

        private void practise_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void practise_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // load thi load trong dic
        // save thi save vo dic
        // khi chon item output --> display (selectedchange -->listbox)
        // nhap code o trong data co thi auto fill name subject mark (event listener textchange)

    }
}
