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
            firstOctetBin = "00000000";
            secondOctetBin = "00000000";
            thirdOctetBin = "00000000";
            fourthOctetBin = "00000000";
            ipBinary = $"{firstOctetBin}.{secondOctetBin}.{thirdOctetBin}.{fourthOctetBin}";
            tbIPBinary.Text = ipBinary;
            decNumber = null;
            hexNumber = null;
            binNumber = null;
            fillMaskTable();
            cbMask.DataSource = subnetMasks;
            cbMask.DisplayMember = "Slash";
            cbMask.SelectedIndex = 0;
        }
        public static string fullBrodcastDec { get; set; }
        public static string fullBrodcastBinary { get; set; }
        public static string fullidDec { get; set; }
        public static string fullidBinary { get; set; }
        public static string[] values { get; set; }
        public static int ipMask1 { get; set; }
        public static int ipMask2 { get; set; }
        public static int ipMask3 { get; set; }
        public static int ipMask4 { get; set; }
        public static string maskIP { get; set; }
        public static string ipBinary { get; set; }
        public static int firstOctet { get; set; }
        public static string firstOctetBin { get; set; }
        public static int secondOctet { get; set; }
        public static string secondOctetBin { get; set; }
        public static int thirdOctet { get; set; }
        public static string thirdOctetBin { get; set; }
        public static int fourthOctet { get; set; }
        public static string fourthOctetBin { get; set; }
        public static string lastChanged { get; set; }
        public static int? decNumber { get; set; }
        public static string hexNumber { get; set; }
        public static string binNumber { get; set; }
        public static List<SubMask> subnetMasks { get; set; } = new List<SubMask>();

        private void fillMaskTable()
        {
            string one = "1";
            string concat = null;
            string octet;
            string full;
            string full2;
            string full3;
            string full4;
            string fulldec;
            int decNum;

            for (int i = 1; i < 9; i++)
            {
                SubMask data = new SubMask();
                concat = concat + one;
                octet = concat.PadRight(8, '0');
                full = octet + ".00000000.00000000.00000000";
                decNum = Convert.ToInt32(octet, 2);
                fulldec = $"{decNum}.0.0.0";
                data.Slash = $"{i}";
                data.Decimal = $"{fulldec}";
                data.Binaa = full;
                subnetMasks.Add(data);
            }
            one = "1";
            concat = null;
            octet = null;
            for (int i = 9; i < 17; i++)
            {
                SubMask data2 = new SubMask();
                concat = concat + one;
                octet = concat.PadRight(8, '0');
                full2 = "11111111." + octet + ".00000000.00000000";
                decNum = Convert.ToInt32(octet, 2);
                fulldec = $"255.{decNum}.0.0";
                data2.Slash = $"{i}";
                data2.Decimal = $"{fulldec}";
                data2.Binaa = full2;
                subnetMasks.Add(data2);
            }
            one = "1";
            concat = null;
            octet = null;
            for (int i = 17; i < 25; i++)
            {
                SubMask data3 = new SubMask();
                concat = concat + one;
                octet = concat.PadRight(8, '0');
                full3 = "11111111.11111111." + octet + ".00000000";
                decNum = Convert.ToInt32(octet, 2);
                fulldec = $"225.255.{decNum}.0";
                data3.Slash = $"{i}";
                data3.Decimal = $"{fulldec}";
                data3.Binaa = full3;
                subnetMasks.Add(data3);
            }
            one = "1";
            concat = null;
            octet = null;
            for (int i = 25; i < 33; i++)
            {
                SubMask data4 = new SubMask();
                concat = concat + one;
                octet = concat.PadRight(8, '0');
                full4 = "11111111.11111111.11111111." + octet;
                decNum = Convert.ToInt32(octet, 2);
                fulldec = $"225.255.255.{decNum}";
                data4.Slash = $"{i}";
                data4.Decimal = $"{fulldec}";
                data4.Binaa = full4;
                subnetMasks.Add(data4);
            }
        }

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
            if (!bgWorkerV4.IsBusy)
            {
                bgWorkerV4.RunWorkerAsync();
            }
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
            //Getting the ID IP
            int outputIDOne = firstOctet & ipMask1;
            int outputIDTwo = secondOctet & ipMask2;
            int outputIDThree = thirdOctet & ipMask3;
            int outputIDFour = fourthOctet & ipMask4;
            fullidDec = $"{outputIDOne}.{outputIDTwo}.{outputIDThree}.{outputIDFour}"; 
            string idBOne = Convert.ToString(outputIDOne, toBase: 2).PadLeft(8, '0');
            string idBTwo = Convert.ToString(outputIDTwo, toBase: 2).PadLeft(8, '0');
            string idBThree = Convert.ToString(outputIDThree, toBase: 2).PadLeft(8, '0');
            string idBFour = Convert.ToString(outputIDFour, toBase: 2).PadLeft(8, '0');
            fullidBinary = $"{idBOne}.{idBTwo}.{idBThree}.{idBFour}";
            //Getting the Broadcast IP
            int outputBOne = firstOctet | ~ipMask1;
            int outputBTwo = secondOctet | ~ipMask2;
            int outputBThree = thirdOctet | ~ipMask3;
            int outputBFour = fourthOctet | ~ipMask4;
            var bco1 = BitConverter.GetBytes(outputBOne);
            var bco2 = BitConverter.GetBytes(outputBTwo);
            var bco3 = BitConverter.GetBytes(outputBThree);
            var bco4 = BitConverter.GetBytes(outputBFour);
            string bc1 = Convert.ToString(Convert.ToInt32(bco1[0]), toBase: 2).PadLeft(8, '0');
            string bc2 = Convert.ToString(Convert.ToInt32(bco2[0]), toBase: 2).PadLeft(8, '0');
            string bc3 = Convert.ToString(Convert.ToInt32(bco3[0]), toBase: 2).PadLeft(8, '0');
            string bc4 = Convert.ToString(Convert.ToInt32(bco4[0]), toBase: 2).PadLeft(8, '0');
            fullBrodcastBinary = $"{bc1}.{bc2}.{bc3}.{bc4}";
            fullBrodcastDec = $"{bco1[0]}.{bco2[0]}.{bco3[0]}.{bco4[0]}";

        }

        private void bgWorkerV4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tbIDIP.Text = fullidDec;
            tbIDIPBinary.Text = fullidBinary;
            tbBroadcast.Text = fullBrodcastDec;
            tbBroadcastB.Text = fullBrodcastBinary;
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

        private void cbMask_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = cbMask.SelectedIndex;
            tbMask.Text = (subnetMasks[selected].Decimal).ToString();
            tbMaskBinary.Text = (subnetMasks[selected].Binaa).ToString();
            maskIP = (subnetMasks[selected].Decimal).ToString();
            values = maskIP.Split('.');
            ipMask1 = Convert.ToInt32(values[0]);
            ipMask2 = Convert.ToInt32(values[1]);
            ipMask3 = Convert.ToInt32(values[2]);
            ipMask4 = Convert.ToInt32(values[3]);
        }

        private void tbFirstOctet_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbFirstOctet.Text))
            {
                firstOctet = Convert.ToInt32(tbFirstOctet.Text);
                firstOctetBin = Convert.ToString(firstOctet, 2);
                firstOctetBin = firstOctetBin.PadLeft(8, '0');
            }
            else
            {
                firstOctet = 0;
                firstOctetBin = "00000000";
            }
            ipBinary = $"{firstOctetBin}.{secondOctetBin}.{thirdOctetBin}.{fourthOctetBin}";
            tbIPBinary.Text = ipBinary;
        }

        private void tbSecondOctet_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSecondOctet.Text))
            {
                secondOctet = Convert.ToInt32(tbSecondOctet.Text);
                secondOctetBin = Convert.ToString(secondOctet, 2);
                secondOctetBin = secondOctetBin.PadLeft(8, '0');
            }
            else
            {
                secondOctet = 0;
                secondOctetBin = "00000000";
            }
            ipBinary = $"{firstOctetBin}.{secondOctetBin}.{thirdOctetBin}.{fourthOctetBin}";
            tbIPBinary.Text = ipBinary;
        }

        private void tbThirdOctet_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbThirdOctet.Text))
            {
                thirdOctet = Convert.ToInt32(tbThirdOctet.Text);
                thirdOctetBin = Convert.ToString(thirdOctet, 2);
                thirdOctetBin = thirdOctetBin.PadLeft(8, '0');
            }
            else
            {
                thirdOctet = 0;
                thirdOctetBin = "00000000";
            }
            ipBinary = $"{firstOctetBin}.{secondOctetBin}.{thirdOctetBin}.{fourthOctetBin}";
            tbIPBinary.Text = ipBinary;
        }

        private void tbFourthOctet_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbFourthOctet.Text))
            {
                fourthOctet = Convert.ToInt32(tbFourthOctet.Text);
                fourthOctetBin = Convert.ToString(fourthOctet, 2);
                fourthOctetBin = fourthOctetBin.PadLeft(8, '0');
            }
            else
            {
                fourthOctet = 0;
                fourthOctetBin = "00000000";
            }
            ipBinary = $"{firstOctetBin}.{secondOctetBin}.{thirdOctetBin}.{fourthOctetBin}";
            tbIPBinary.Text = ipBinary;
        }

    }
}
