using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Generator generator = new Generator();

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            PasswordTypes passType = PasswordTypes.ALL;
            if (rbDigits.Checked)
            {
                passType = PasswordTypes.DIGITS;
            }
            if (rbDigitsChars.Checked)
            {
                passType = PasswordTypes.DIGITS_ALFA;
            }

            List<String> passwords = generator.Generate(
                (int)numericPassLength.Value,
                (int)numericPassCount.Value,
                passType
                );
            foreach (var item in passwords)
            {
                lbPasswords.Items.Add(item);
            }
        }

        private void lbPasswords_DoubleClick(object sender, EventArgs e)
        {
            String s = lbPasswords.Items[lbPasswords.SelectedIndex].ToString();
            Clipboard.SetText(s);
        }
    }
}
