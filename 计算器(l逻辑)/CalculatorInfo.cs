using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    public class CalculatorInfo
    {
        public static readonly string Plus = "＋";
        public static readonly string Subtract = "－";
        public static readonly string Multiple = "×";
        public static readonly string Divide = "÷";
        public static readonly string[] operatorList = new string[] { Plus, Subtract, Multiple, Divide };
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public List<string> HistoryList { get; set; }
    }
}
