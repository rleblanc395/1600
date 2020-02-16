using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA4
{
    public partial class Form1 : Form
    {
        private List<byte> _KeyCodes = new List<byte>();
        private int _onesCount = 0;
        private int _longRun = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CodeBox_KeyDown(object sender, KeyEventArgs e)
        {
            // write kew pressed on label
            KCLbl.Text = e.KeyData.ToString();
            // put key code into the List Box in 2-byte binary
            CodeBox.Items.Add(Convert.ToString(e.KeyValue, 2).PadLeft(8, '0'));
            // add the value to the list
            _KeyCodes.Add((byte)e.KeyValue);
            // Adjust ones count
            CountOnes(_KeyCodes[CodeBox.SelectedIndex], ref _onesCount);
            OCLbl.Text = _onesCount.ToString();
        }

        private void CodeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            LRLbl.Text = CountRuns(_KeyCodes[CodeBox.SelectedIndex]).ToString();
        }
        

        private int CountRuns(byte currentCode)
        {
            int longestRun = 0;
            int check = 1;
            int nowLong = 0;
            while ( check < currentCode)
	{
                if ((check & currentCode) != 0)
                {
                    nowLong++;
                    if ((((check << 1) & currentCode)) == 0)
                    {
                        if (nowLong > longestRun)
                            longestRun = nowLong;
                        nowLong = 0;
                    }
                }
                check = check << 1;
            }
            return longestRun;
        }
        private void CountOnes(byte currentCode, ref int onesCount)
        {
            int check = 1;
            while ( check < currentCode)
	{
                if ((check & currentCode) != 0)
                    onesCount++;
                check = check << 1;
            }
        }
    }
}
