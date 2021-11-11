using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.panelBorder.MouseDown += panelBorder_MouseDown;
        }
       
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxMax2.Visible = true;
            pictureBoxMax.Visible = false;

        }

        private void pictureBoxMax2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBoxMax2.Visible = false;
            pictureBoxMax.Visible = true;
        }

        private void pictureBoxMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBorder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.panelBorder.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;

                Message message = Message.Create(Handle, WM_NCLBUTTONDOWN, new IntPtr(HTCAPTION), IntPtr.Zero);

                DefWndProc(ref message);
            }
        }

        private void pictureBoxGroupChat_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            Form4 newForm3 = new Form4();
            newForm3.Show();
            Form5 newForm4 = new Form5();
            newForm4.Show();
        }

        #region User1

        private void panelUser1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form3 newForm2 = new Form3();
            newForm2.Show();
        }

        private void textBoxUser1Chat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form3 newForm2 = new Form3();
            newForm2.Show();
        }

        private void labelUser1Name_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form3 newForm2 = new Form3();
            newForm2.Show();
        }

        private void roundPictureBoxUser1Pic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form3 newForm2 = new Form3();
            newForm2.Show();
        }

        #endregion

        #region User2

        private void panelUser2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form3 newForm2 = new Form3();
            newForm2.Show();
        }

        private void labelUser2Name_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form3 newForm2 = new Form3();
            newForm2.Show();
        }

        private void textBoxUser2Chat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form3 newForm2 = new Form3();
            newForm2.Show();
        }

        private void roundPictureBoxUser2Pic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form3 newForm2 = new Form3();
            newForm2.Show();
        }

        #endregion

        private void FixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxPin.Visible = true;
        }

        private void pictureBoxChatList_Click(object sender, EventArgs e)
        {
            pictureBoxChatListhide.Visible = true;
            pictureBoxChatList.Visible = false;
            this.Visible = false;
            Form1 showForm = new Form1();
            showForm.ShowDialog();
        }

        private void pictureBoxChatListhide_Click(object sender, EventArgs e)
        {
            pictureBoxChatListhide.Visible = false;
            pictureBoxChatList.Visible = true;
            this.Visible = false;
            Form1 showForm = new Form1();
            showForm.ShowDialog();
        }

        private void pictureBoxBellhide_Click(object sender, EventArgs e)
        {
            pictureBoxChatList.Visible = false;
            pictureBoxChatListhide.Visible = true;
            pictureBoxBell.Visible = true;
            pictureBoxBellhide.Visible = false;
            // 알람폼 띄우기
            // 
        }

        private void pictureBoxSettingshide_Click(object sender, EventArgs e)
        {
            // 세팅폼 띄우면 될거 같아욤
        }

        private void pictureBoxFriendListhide_Click(object sender, EventArgs e)
        {
            // settings랑 동일
        }
    }
}
