using SendX.DatabaseSendXDataSetTableAdapters;
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
    public partial class CreateAcount : Form
    {
        int ID = 0;
        AccountEmailTableAdapter accountEmailTableAdapter = new AccountEmailTableAdapter();
        public CreateAcount(int Id)
        {
            ID = Id;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (String.IsNullOrEmpty(((TextBox)c).Text.Trim()))
                    {
                        MessageBox.Show("إملا الحقول", "يوجد حقول فارغة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                }
            }
            try
            {
                if (ID != 0)
                {
                    accountEmailTableAdapter.Update(textBoxSmtp.Text.Trim(), textBoxPort.Text.Trim(), textBoxSender.Text.Trim(), textBoxPassword.Text.Trim(), ID);
                }
                else
                {
                    accountEmailTableAdapter.Insert(textBoxSmtp.Text.Trim(), textBoxPort.Text.Trim(), textBoxSender.Text.Trim(), textBoxPassword.Text.Trim());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool FieldEmpty( string[] Fields)
        {
            foreach (string Field in Fields)
            {
                if (String.IsNullOrEmpty(Field.Trim()))
                {
                    return true;
                }
            }
            return false;
        }

        private void CreateAcount_Load(object sender, EventArgs e)
        {
            if (ID!=0)
            {
               DataTable table= accountEmailTableAdapter.GetDataByID(ID);
               textBoxSmtp.Text= table.Rows[0]["ServerSMTP"].ToString();
                textBoxPort.Text = table.Rows[0]["port"].ToString();
                textBoxSender.Text = table.Rows[0]["EmailSender"].ToString();
                textBoxPassword.Text = table.Rows[0]["Password"].ToString();
            }
        }
    }
}
