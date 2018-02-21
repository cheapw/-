using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalculatorLogic;

namespace CalculatorUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.tbkMainOperationFrame.Text = "0";
        }
        CalculatorInfo info = new CalculatorInfo();
        /// <summary>
        /// 数字 1 的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if (Calculator.IsFirstNumber(tbkAssistantOperationFrame.Text))//当副计算框为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中包含此运算符时
                {
                    tbkAssistantOperationFrame.Text = tbkMainOperationFrame.Text;
                    info.SecondNumber+="1";
                    tbkMainOperationFrame.Text = info.SecondNumber;
                }
                else//当主计算框中不包含此运算符时
                {
                    info.FirstNumber+="1";
                    tbkMainOperationFrame.Text = info.FirstNumber;
                }
            }
            else//当副计算框不为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中包含此运算符时
                {
                    tbkAssistantOperationFrame.Text = tbkMainOperationFrame.Text;
                    info.SecondNumber = "1";
                    tbkMainOperationFrame.Text = info.SecondNumber;
                }
                else//当主计算框中不包含此运算符时
                {
                    if (tbkMainOperationFrame.Text == "0")
                    {
                        info.SecondNumber = "1";
                        tbkMainOperationFrame.Text = info.SecondNumber;
                    }
                    else
                    {
                        info.SecondNumber += "1";
                        tbkMainOperationFrame.Text = info.SecondNumber;
                    }
                }
            }
        }
        /// <summary>
        /// 数字 2 的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            
        }
        /// <summary>
        /// 数字 3 的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            
        }
        /// <summary>
        /// 数字 4 的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            
        }
        /// <summary>
        /// 数字 5 的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            
        }
        /// <summary>
        /// 数字 6 的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            
        }
        /// <summary>
        /// 数字 7 的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            
        }
        /// <summary>
        /// 数字 8 的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            
        }
        /// <summary>
        /// 数字 9 的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            
        }
        /// <summary>
        /// 数字 0 的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (Calculator.IsFirstNumber(tbkAssistantOperationFrame.Text))//当副计算框为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中包含此运算符时
                {
                    if (this.tbkMainOperationFrame.Text.Length >= 3 && this.tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() == "0" && Calculator.IsOperator(tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 2].ToString()))
                    {
                        return;
                    }
                    else
                    {
                        tbkAssistantOperationFrame.Text = tbkMainOperationFrame.Text;
                        info.SecondNumber += "0";
                        tbkMainOperationFrame.Text = info.SecondNumber;
                    }
                }
                else//当主计算框中不包含此运算符时
                {
                    if (tbkMainOperationFrame.Text=="0")
                    {
                        return;
                    }
                    else
                    {
                        info.FirstNumber += "0";
                        tbkMainOperationFrame.Text = info.FirstNumber;
                    }
                    
                }
            }
            else//当副计算框不为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中包含此运算符时
                {
                    if (this.tbkMainOperationFrame.Text.Length >= 3 && this.tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() == "0" && Calculator.IsOperator(tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 2].ToString()))
                    {
                        return;
                    }
                    else
                    {
                        tbkAssistantOperationFrame.Text = tbkMainOperationFrame.Text;
                        info.SecondNumber = "0";
                        tbkMainOperationFrame.Text = info.SecondNumber;
                    }
                    
                }
                
                else//当主计算框中不包含此运算符时
                {
                    if (tbkMainOperationFrame.Text == "0")
                    {
                        return;
                    }
                    else
                    {
                        info.SecondNumber += "0";
                        tbkMainOperationFrame.Text = info.SecondNumber;
                    }
                }
            }
        }
        /// <summary>
        /// 加号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Calculator.IsFirstNumber(tbkAssistantOperationFrame.Text))  //当副计算框为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中包含此运算符时
                {
                    if (tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() != CalculatorInfo.Plus)
                    {
                        string temp = tbkMainOperationFrame.Text.Remove(-1);
                        tbkMainOperationFrame.Text = temp + CalculatorInfo.Plus;
                    }
                    else { return; }
                    
                }
                if (tbkMainOperationFrame.Text=="0")//当主运算框中的文本为“0”时
                {
                    info.FirstNumber="0";
                    tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Plus;
                }
                else//当主运算框中的文本不为“0”时
                {
                    if (tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() == ".")
                    {
                        info.FirstNumber += "0";
                    }
                    tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Plus;
                }
            }
            else //当副计算框不为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中一包含此运算符时
                {
                    if (tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() != CalculatorInfo.Plus)
                    {
                        string temp = tbkMainOperationFrame.Text.Remove(-1);
                        tbkMainOperationFrame.Text = temp + CalculatorInfo.Plus;
                    }
                    else { return; }
                }
                else
                {
                    if (tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() == ".")
                    {
                        info.SecondNumber += "0";
                    }
                    if (Calculator.IsOperator(tbkMainOperationFrame.Text))
                    {
                        tbkMainOperationFrame.Text = tbkMainOperationFrame.Text.Remove(-1);
                    }
                    string temp = tbkAssistantOperationFrame.Text + tbkMainOperationFrame.Text;
                    if (temp.Contains(CalculatorInfo.Plus))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Plus + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) + Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Plus;
                    }
                    if (temp.Contains(CalculatorInfo.Subtract))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Subtract + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) - Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Subtract;
                    }
                    if (temp.Contains(CalculatorInfo.Multiple))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Multiple + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) * Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Multiple;
                    }
                    if (temp.Contains(CalculatorInfo.Divide))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Divide + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) / Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Divide;
                    }
                } 
            }
        }
        /// <summary>
        /// 减号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsubtract_Click(object sender, RoutedEventArgs e)
        {
            if (Calculator.IsFirstNumber(tbkAssistantOperationFrame.Text))  //当副计算框为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中包含此运算符时
                {
                    if (tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() != CalculatorInfo.Subtract)
                    {
                        string temp = tbkMainOperationFrame.Text.Remove(-1);
                        tbkMainOperationFrame.Text = temp + CalculatorInfo.Subtract;
                    }
                    else { return; }
                }
                if (tbkMainOperationFrame.Text == "0")//当主运算框中的文本为“0”时
                {
                    info.FirstNumber = "0";
                    tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Subtract;
                }
                else//当主运算框中的文本不为“0”时
                {
                    tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Subtract;
                }
            }
            else //当副计算框不为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中一包含此运算符时
                {
                    if (tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() != CalculatorInfo.Subtract)
                    {
                        string temp = tbkMainOperationFrame.Text.Remove(-1);
                        tbkMainOperationFrame.Text = temp + CalculatorInfo.Subtract;
                    }
                    else { return; }
                }
                else
                {
                    if (Calculator.IsOperator(tbkMainOperationFrame.Text))
                    {
                        tbkMainOperationFrame.Text = tbkMainOperationFrame.Text.Remove(-1);
                    }
                    string temp = tbkAssistantOperationFrame.Text + tbkMainOperationFrame.Text;
                    if (temp.Contains(CalculatorInfo.Plus))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Plus + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) + Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Plus;
                    }
                    if (temp.Contains(CalculatorInfo.Subtract))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Subtract + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) - Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Subtract;
                    }
                    if (temp.Contains(CalculatorInfo.Multiple))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Multiple + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) * Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Multiple;
                    }
                    if (temp.Contains(CalculatorInfo.Divide))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Divide + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) / Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Divide;
                    }
                }
            }
        }
        /// <summary>
        /// 乘号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiple_Click(object sender, RoutedEventArgs e)
        {
            if (Calculator.IsFirstNumber(tbkAssistantOperationFrame.Text))  //当副计算框为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中包含此运算符时
                {
                    if (tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() != CalculatorInfo.Multiple)
                    {
                        string temp = tbkMainOperationFrame.Text.Remove(-1);
                        tbkMainOperationFrame.Text = temp + CalculatorInfo.Multiple;
                    }
                    else { return; }
                }
                if (tbkMainOperationFrame.Text == "0")//当主运算框中的文本为“0”时
                {
                    info.FirstNumber = "0";
                    tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Multiple;
                }
                else//当主运算框中的文本不为“0”时
                {
                    tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Multiple;
                }
            }
            else //当副计算框不为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中一包含此运算符时
                {
                    if (tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() != CalculatorInfo.Multiple)
                    {
                        string temp = tbkMainOperationFrame.Text.Remove(-1);
                        tbkMainOperationFrame.Text = temp + CalculatorInfo.Multiple;
                    }
                    else { return; }
                }
                else
                {
                    if (Calculator.IsOperator(tbkMainOperationFrame.Text))
                    {
                        tbkMainOperationFrame.Text = tbkMainOperationFrame.Text.Remove(-1);
                    }
                    string temp = tbkAssistantOperationFrame.Text + tbkMainOperationFrame.Text;
                    if (temp.Contains(CalculatorInfo.Plus))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Plus + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) + Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Plus;
                    }
                    if (temp.Contains(CalculatorInfo.Subtract))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Subtract + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) - Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Subtract;
                    }
                    if (temp.Contains(CalculatorInfo.Multiple))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Multiple + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) * Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Multiple;
                    }
                    if (temp.Contains(CalculatorInfo.Divide))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Divide + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) / Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Divide;
                    }
                }
            }
        }
        /// <summary>
        /// 除号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (Calculator.IsFirstNumber(tbkAssistantOperationFrame.Text))  //当副计算框为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中包含此运算符时
                {
                    if (tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() != CalculatorInfo.Divide)
                    {
                        string temp = tbkMainOperationFrame.Text.Remove(-1);
                        tbkMainOperationFrame.Text = temp + CalculatorInfo.Divide;
                    }
                    else { return; }
                }
                if (tbkMainOperationFrame.Text == "0")//当主运算框中的文本为“0”时
                {
                    info.FirstNumber = "0";
                    tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Divide;
                }
                else//当主运算框中的文本不为“0”时
                {
                    tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Divide;
                }
            }
            else //当副计算框不为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中一包含此运算符时
                {
                    if (tbkMainOperationFrame.Text[tbkMainOperationFrame.Text.Length - 1].ToString() != CalculatorInfo.Multiple)
                    {
                        string temp = tbkMainOperationFrame.Text.Remove(-1);
                        tbkMainOperationFrame.Text = temp + CalculatorInfo.Multiple;
                    }
                    else { return; }
                }
                else
                {
                    if (Calculator.IsOperator(tbkMainOperationFrame.Text))
                    {
                        tbkMainOperationFrame.Text = tbkMainOperationFrame.Text.Remove(-1);
                    }
                    string temp = tbkAssistantOperationFrame.Text + tbkMainOperationFrame.Text;
                    if (temp.Contains(CalculatorInfo.Plus))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Plus + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) + Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Plus;
                    }
                    if (temp.Contains(CalculatorInfo.Subtract))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Subtract + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) - Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Subtract;
                    }
                    if (temp.Contains(CalculatorInfo.Multiple))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Multiple + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) * Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Multiple;
                    }
                    if (temp.Contains(CalculatorInfo.Divide))
                    {
                        this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Divide + info.SecondNumber.ToString();
                        info.FirstNumber = (Convert.ToDouble(info.FirstNumber) / Convert.ToDouble(info.SecondNumber)).ToString();
                        this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Divide;
                    }
                }
            }
        }
        /// <summary>
        /// 点号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (Calculator.IsFirstNumber(tbkAssistantOperationFrame.Text))//当副计算框为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中包含此运算符时
                {
                    tbkAssistantOperationFrame.Text = tbkMainOperationFrame.Text;
                    info.SecondNumber = "0.";
                    tbkMainOperationFrame.Text = info.SecondNumber;
                }
                else//当主计算框中不包含此运算符时
                {
                    if (tbkMainOperationFrame.Text.Contains("."))
                    {
                        return;
                    }
                    else
                    {
                        if (tbkMainOperationFrame.Text == "0")
                        {
                            info.FirstNumber = "0.";
                            tbkMainOperationFrame.Text = info.FirstNumber;
                        }
                        else
                        {
                            info.FirstNumber += ".";
                            tbkMainOperationFrame.Text = info.FirstNumber;
                        }   
                    }
                }
            }
            else//当副计算框不为空时
            {
                if (Calculator.IsOperator(tbkMainOperationFrame.Text))//当主计算框中包含此运算符时
                {                  
                        tbkAssistantOperationFrame.Text = tbkMainOperationFrame.Text;
                        info.SecondNumber = "0.";
                        tbkMainOperationFrame.Text = info.SecondNumber;
                }

                else//当主计算框中不包含此运算符时
                {
                    if (tbkMainOperationFrame.Text.Contains("."))
                    {
                        return;
                    }
                    else
                    {
                        info.SecondNumber += ".";
                        tbkMainOperationFrame.Text = info.SecondNumber;
                    }
                }
            }
        }
        /// <summary>
        /// 等号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            
            if (Calculator.IsOperator(tbkMainOperationFrame.Text))
            {
                tbkMainOperationFrame.Text = tbkMainOperationFrame.Text.Remove(-1);
            }
            string temp = tbkAssistantOperationFrame.Text + tbkMainOperationFrame.Text;
            if (temp.Contains(CalculatorInfo.Plus))
            {
                this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Plus + info.SecondNumber.ToString();
                info.FirstNumber = (Convert.ToDouble(info.FirstNumber) + Convert.ToDouble(info.SecondNumber)).ToString();
                this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Plus;
            }
            if (temp.Contains(CalculatorInfo.Subtract))
            {
                this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Subtract + info.SecondNumber.ToString();
                info.FirstNumber = (Convert.ToDouble(info.FirstNumber) - Convert.ToDouble(info.SecondNumber)).ToString();
                this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Subtract;
            }
            if (temp.Contains(CalculatorInfo.Multiple))
            {
                this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Multiple + info.SecondNumber.ToString();
                info.FirstNumber = (Convert.ToDouble(info.FirstNumber) * Convert.ToDouble(info.SecondNumber)).ToString();
                this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Multiple;
            }
            if (temp.Contains(CalculatorInfo.Divide))
            {
                this.tbkAssistantOperationFrame.Text = info.FirstNumber.ToString() + CalculatorInfo.Divide + info.SecondNumber.ToString();
                info.FirstNumber = (Convert.ToDouble(info.FirstNumber) / Convert.ToDouble(info.SecondNumber)).ToString();
                this.tbkMainOperationFrame.Text = info.FirstNumber + CalculatorInfo.Divide;
            }
        }
    }
}
