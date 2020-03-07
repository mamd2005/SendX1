using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void اعداداتحسابالبريدالمرسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAcount CreateAcount1 = new CreateAcount(0);
            CreateAcount1.MdiParent = this;
            CreateAcount1.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            CreateAcount1.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEmailAcount EditEmailAcount1 = new EditEmailAcount();
            EditEmailAcount1.MdiParent = this;
            EditEmailAcount1.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            EditEmailAcount1.Show();
        }

        private void CreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMassage CreateMassage1 = new CreateMassage();
            CreateMassage1.MdiParent = this;
            CreateMassage1.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            CreateMassage1.Show();

        }

        private void إنشاءشهادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFormAttach CreateFormAttach = new CreateFormAttach();
            CreateFormAttach.MdiParent = this;
            CreateFormAttach.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            CreateFormAttach.Show();
        }

        private void تعديلرسالةToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EditMassages EditMassages1 = new EditMassages();
            EditMassages1.MdiParent = this;
            EditMassages1.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            EditMassages1.Show();
        }

        private void تعديلشهادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFormAttach EditFormAttach1 = new EditFormAttach();
            EditFormAttach1.MdiParent = this;
            EditFormAttach1.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            EditFormAttach1.Show();
        }

        private void إنشاءقائمةToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CreateList CreateList1 = new CreateList();
            CreateList1.MdiParent = this;
            CreateList1.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            CreateList1.Show();
        }

        private void تعديلقائمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditList EditList1 = new EditList();
            EditList1.MdiParent = this;
            EditList1.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            EditList1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void إرسالبريددعائيToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SendEmailNormal SendEmailNormal1 = new SendEmailNormal();
            SendEmailNormal1.MdiParent = this;
            SendEmailNormal1.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            SendEmailNormal1.Show();
        }

        private void إرسالبريدمرفقشهادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendEmailAttach SendEmailAttach1 = new SendEmailAttach();
            SendEmailAttach1.MdiParent = this;
            SendEmailAttach1.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            SendEmailAttach1.Show();
        }

        private void إرسالبريدبمرفقمربوطبالمستندToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendEmailCertificate SendEmailCertificate1 = new SendEmailCertificate();
            SendEmailCertificate1.MdiParent = this;
            SendEmailCertificate1.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            SendEmailCertificate1.Show();
        }

        private void عنالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox11 = new AboutBox1();
            AboutBox11.MdiParent = this;
            AboutBox11.WindowState = FormWindowState.Maximized;
            //CreateAcount1.Icon = Properties.Resources.Webalys_Kameleon_pics_Cashier_2;
            AboutBox11.ShowDialog();
        }

    }
}
