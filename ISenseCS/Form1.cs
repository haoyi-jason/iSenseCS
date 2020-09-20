using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISenseCS
{
    public partial class Form1 : Form
    {
        _ModuleSetting _nodeDef;
        public Form1()
        {
            InitializeComponent();
            _nodeDef = new _ModuleSetting();
            propertyGrid1.SelectedObject = _nodeDef;

            Regex rx = new Regex(@"(COM\d+):?(\d+)?",RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex rx2 = new Regex(@"\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}$");
            string text = "COM1";
            MatchCollection match = rx.Matches(text);
            if(match.Count > 0)
            {
                foreach (Match m in match)
                    Console.WriteLine("   " + m.Value);
            }

            string text2 = "192.168.0.240:5001";
            MatchCollection m2 = rx2.Matches(text2);
            if (m2.Count > 0)
            {
                foreach (Match m in m2)
                    Console.WriteLine("   " + m.Value);
            }
        }
    }
}
