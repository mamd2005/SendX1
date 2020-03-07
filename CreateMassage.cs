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
    public partial class CreateMassage : Form
    {
        public CreateMassage()
        {
            InitializeComponent();
        }

        private void CreateMassage_Load(object sender, EventArgs e)
        {
            BaiqiSoft.HtmlEditorControl.MstHtmlEditor mstHtmlEditor = new BaiqiSoft.HtmlEditorControl.MstHtmlEditor();
            panel1.Controls.Add(mstHtmlEditor);
            mstHtmlEditor.Dock = DockStyle.Fill;
        }
    }
}
