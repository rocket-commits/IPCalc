using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            decNumber = null;
            hexNumber = null;
            binNumber = null;
        }
        public static string lastChanged { get; set; }
        public static int? decNumber { get; set; }
        public static string hexNumber { get; set; }
        public static string binNumber { get; set; }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            bool tbNull = CheckNullControls(tabPage3);
            if (tbNull)
            {
                MessageBox.Show("Write at least one number in a text field to convert", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!bgWorkerConversion.IsBusy)
                {
                    bgWorkerConversion.RunWorkerAsync();
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

        }

        private void bgWorkerConversion_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int dec;
                string hexadec;
                string binaary;
                switch (lastChanged)
                {
                    case "tbDecimal":
                        hexadec = string.Format("{0:x}", decNumber).ToUpper();
                        hexNumber = hexadec;
                        binaary = Convert.ToString((int)decNumber, 2);
                        binaary = binaary.PadLeft(8, '0');
                        binNumber = binaary;
                        break;
                    case "tbHex":
                        dec = (int)Convert.ToInt64(hexNumber, 16);
                        decNumber = dec;
                        binaary = Convert.ToString((int)dec, 2);
                        binaary = binaary.PadLeft(8, '0');
                        binNumber = binaary;
                        break;
                    case "tbBinary":
                        dec = Convert.ToInt32(binNumber, 2);
                        decNumber = dec;
                        hexadec = string.Format("{0:x}", dec).ToUpper();
                        hexNumber = hexadec;
                        break;
                    default:
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgWorkerConversion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tbHex.Text = hexNumber;
            tbBinary.Text = binNumber;
            tbDecimal.Text = decNumber.ToString();
        }

        private void bgWorkerV4_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgWorkerV4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void tbDecimal_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbDecimal.Text))
            {
                decNumber = Convert.ToInt32(tbDecimal.Text);
                lastChanged = "tbDecimal";
            }
            else
            {
                decNumber = null;
            }
        }

        private void tbHex_TextChanged(object sender, EventArgs e)
        {
            hexNumber = tbHex.Text;
            lastChanged = "tbHex";
        }

        private void tbBinary_TextChanged(object sender, EventArgs e)
        {
            binNumber = tbBinary.Text;
            lastChanged = "tbBinary";
        }

        public static bool CheckNullControls(Control form)
        {
            bool isNull = true;
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (!String.IsNullOrEmpty(textBox.Text))
                    {
                        isNull = false;
                    }
                }
            }
            return isNull;
        }
    }
}
