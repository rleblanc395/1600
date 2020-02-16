//****************************************************************************************




//*****************************************************************************************
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
        private List<byte> _KeyCodes = new List<byte>();    //key codes in binary list
        private int _onesCount = 0;                         // total number of ones
        public Form1()
        {
            InitializeComponent();
        }

        //
        private void CodeBox_KeyDown(object sender, KeyEventArgs e)
        {
            _onesCount = 0;
            // write kew pressed on label
            KCLbl.Text = e.KeyData.ToString();
            // put key code into the List Box in 2-byte binary
            CodeBox.Items.Add(Convert.ToString(e.KeyValue, 2).PadLeft(8, '0'));
            // add the value to the list
            _KeyCodes.Add((byte)e.KeyValue);
            // Count total 1's and adjust label
            foreach (byte key in _KeyCodes)
            {
                CountOnes(key, ref _onesCount);
                OCLbl.Text = _onesCount.ToString();
            }
        }

        private void CodeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Find Longest Run and adjust longest run label
            LRLbl.Text = CountRuns(_KeyCodes[CodeBox.SelectedIndex]).ToString();
        }
        

        private int CountRuns(byte currentCode)
        {
            int longestRun = 0;     // length of longest run
            int check = 1;          // used for bitwise ops to check if set
            int nowLong = 0;        // stores length of current run being checked
            // runs code until every bit is checked
            while ( check < currentCode)
	        {
                // check if a bit is a 1
                if ((check & currentCode) != 0)
                {
                    // count number of 1's in a row
                    nowLong++;
                    // checks for a zero after a one to end the run 
                    if ((((check << 1) & currentCode)) == 0)
                    {
                        // record longest run
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
            int check = 1;      // used to check if a bit is set
            // run through every bit
            while ( check < currentCode)
	        {
                // count number of ones
                if ((check & currentCode) != 0)
                    onesCount++;
                check = check << 1;
            }
        }
    }
}
