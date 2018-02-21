using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    public static class Calculator
    {
        public static bool IsFirstNumber(string info)
        {
            //if (info.Contains(CalculatorInfo.Plus) || info.Contains(CalculatorInfo.Multiple) || info.Contains(CalculatorInfo.Divide))
            //{
            //    return false;
            //}
            //else if (info.Contains(CalculatorInfo.Subtract) && info[0].ToString() == CalculatorInfo.Subtract)
            //{
            //    return false;
            //}
            if (info==string.Empty)
            {
                return true;
            }
            else return false;
        }
        //public static bool IsZero(string info)
        //{
        //    if (info[0].ToString() == "0")
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
        //public static bool IsDot(string info)
        //{
        //    if (info[info.Length - 1].ToString() == "." || info.Contains('.'))
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
        public static bool IsOperator(string info)
        {
            if (CalculatorInfo.operatorList.Contains(info[info.Length - 1].ToString()))
            {
                return true;
            }
            else return false;
        }
    }
}
