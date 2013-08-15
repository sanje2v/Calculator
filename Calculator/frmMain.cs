using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{
    public partial class frmMain : Form
    {
        // Constants
        const int SUPPORTED_BITS = 32;                          // No. of bits supported for binary calculations
        const int SUPPORTED_HEX_DIGITS = SUPPORTED_BITS / 4;    // No. of bits supported for hexadecimal calculations

        // Enumerated types
        private enum ASCIIKey   // Key mapping for 'KeyPress' event
        {
            Key0 = 0x30, Key1, Key2, Key3, Key4, Key5, Key6, Key7, Key8, Key9,
            KeyA = 0x41, KeyB, KeyC, KeyD, KeyE, KeyF,
            Keya = 0x61, Keyb, Keyc, Keyd, Keye, Keyf,
            KeyDecimal = 0x2E, KeyAdd = 0x2B, KeySubtract = 0x2D, KeyMultiply = 0x2A, KeyDivide = 0x2F,
            KeyBackspace = 0x08
        };
        private enum MultipleOperandsOperation { NoOp, Add, Subtract, Multiply, Divide, Mod, AND, OR, XOR };
        private enum BaseMode { Binary = 2, Decimal = 10, Hexadecimal = 16 };

        // Global variables
        private bool m_Error = false;                                                       // Determines if its an error state
        private double m_Memory = 0.0f;                                                     // Memory contents
        private BaseMode m_BaseMode = BaseMode.Decimal;                                     // Base mode
        private MultipleOperandsOperation m_LastOperator = MultipleOperandsOperation.NoOp;  // Operation to do
        private bool m_ClearDisplayOnEntry = true;                                          // Clear display on next button press
        private string m_LastResult = "0";                                                  // Save first operand

        // Private inline functions
        private double CheckResult(double result) { if (Double.IsNaN(result) || Double.IsInfinity(result)) throw new Exception(); return result; }
        private void RaiseError() { m_Error = true; lblDisplay.Text = "Invalid Op/Division by 0"; }
        
        float ConvertPixelsToPoints(Graphics graphics, int pixels) { return pixels; } //return pixels * 72.0f / graphics.DpiY; }
        
        private void ClearMemory() { m_Memory = (double) 0.0f; }
        private double ReadMemory() { return m_Memory; }
        private void WriteMemory(double data) { m_Memory = data; }
        
        private int GetIntegerPart(double number) { return (int) number; }
        private double GetFractionalPart(double number) { return number - GetIntegerPart(number); }
        private bool HasFractionalPart(double number) { return GetFractionalPart(number) != (double) 0.0f; }

        private double Factorial(double n)
        {
            if (Math.Sign(n) == -1)
                throw new ArithmeticException();

            if (n == 0.0f) return 1.0f;

            return n * Factorial(n - 1.0f);
        }

        private string AND(string number1, string number2)
        {
            if (number1.Length == 0 || number2.Length == 0)
                throw new Exception();

            StringBuilder result = new StringBuilder();
            string repeat0 = new string('0', Math.Abs(number1.Length - number2.Length));

            if (number1.Length < number2.Length)
                number1 = repeat0 + number1;
            else if (number1.Length > number2.Length)
                number2 = repeat0 + number2;

            for (int i = 0; i < number1.Length; i++)
                if (number1[i] == '0' && number2[i] == '0')
                    result.Append('0');
                else if (number1[i] == '0' && number2[i] == '1')
                    result.Append('0');
                else if (number1[i] == '1' && number2[i] == '0')
                    result.Append('0');
                else if (number1[i] == '1' && number2[i] == '1')
                    result.Append('1');
                else throw new Exception();

            return result.ToString();
        }

        private string OR(string number1, string number2)
        {
            if (number1.Length == 0 || number2.Length == 0)
                throw new Exception();

            StringBuilder result = new StringBuilder();
            string repeat0 = new string('0', Math.Abs(number1.Length - number2.Length));

            if (number1.Length < number2.Length)
                number1 = repeat0 + number1;
            else if (number1.Length > number2.Length)
                number2 = repeat0 + number2;

            for (int i = 0; i < number1.Length; i++)
                if (number1[i] == '0' && number2[i] == '0')
                    result.Append('0');
                else if (number1[i] == '0' && number2[i] == '1')
                    result.Append('1');
                else if (number1[i] == '1' && number2[i] == '0')
                    result.Append('1');
                else if (number1[i] == '1' && number2[i] == '1')
                    result.Append('1');
                else throw new Exception();

            return result.ToString();
        }

        private string NOT(string number)
        {
            if (number.Length == 0)
                throw new Exception();

            StringBuilder result = new StringBuilder(number);

            for (int i = 0; i < number.Length; i++)
                switch (number[i])
                {
                    case '0': result[i] = '1'; break;
                    case '1': result[i] = '0'; break;
                    default: throw new Exception();
                };

            return result.ToString();
        }

        private string XOR(string number1, string number2)
        {
            if (number1.Length == 0 || number2.Length == 0)
                throw new Exception();

            StringBuilder result = new StringBuilder();
            string repeat0 = new string('0', Math.Abs(number1.Length - number2.Length));

            if (number1.Length < number2.Length)
                number1 = repeat0 + number1;
            else if (number1.Length > number2.Length)
                number2 = repeat0 + number2;

            for (int i = 0; i < number1.Length; i++)
                if (number1[i] == '0' && number2[i] == '0')
                    result.Append('0');
                else if (number1[i] == '0' && number2[i] == '1')
                    result.Append('1');
                else if (number1[i] == '1' && number2[i] == '0')
                    result.Append('1');
                else if (number1[i] == '1' && number2[i] == '1')
                    result.Append('0');
                else throw new Exception();

            return result.ToString();
        }

        private string Lsh(string number)
        {
            if (number == "0")
                return number;

            if (number.Length == SUPPORTED_BITS)
                return number.Substring(1) + "0";

            return number + "0";
        }

        private string Rsh(string number)
        {
            if (number == "0")
                return number;

            if (number.Length == SUPPORTED_BITS)
                return "0" + number.Substring(0, number.Length - 1);

            return (number.Length == 1 ? "0" : number.Substring(0, number.Length - 1));
        }

        private string RoL(string number)
        {
            if (number == "0")
                return number;

            if (number.Length == SUPPORTED_BITS)
                return number.Substring(1) + number[0];
            
            return Lsh(number);
        }

        private string RoR(string number)
        {
            if (number == "0")
                return number;

            if (number.Length == SUPPORTED_BITS)
                return number[number.Length - 1] + number.Substring(0, number.Length - 1);

            return Lsh(number);
        }

        // Constructor
        public frmMain()
        {
            InitializeComponent();
        }

        // Redirect keyboard input to button press
        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((ASCIIKey) e.KeyChar)
            {
                case ASCIIKey.Key0: btnB.PerformClick(); break;
                case ASCIIKey.Key1: btn1.PerformClick(); break;
                case ASCIIKey.Key2: btn2.PerformClick(); break;
                case ASCIIKey.Key3: btn3.PerformClick(); break;
                case ASCIIKey.Key4: btn4.PerformClick(); break;
                case ASCIIKey.Key5: btn5.PerformClick(); break;
                case ASCIIKey.Key6: btn6.PerformClick(); break;
                case ASCIIKey.Key7: btn7.PerformClick(); break;
                case ASCIIKey.Key8: btn8.PerformClick(); break;
                case ASCIIKey.Key9: btn9.PerformClick(); break;
                case ASCIIKey.KeyA:
                case ASCIIKey.Keya: btnA.PerformClick(); break;
                case ASCIIKey.KeyB:
                case ASCIIKey.Keyb: btnB.PerformClick(); break;
                case ASCIIKey.KeyC:
                case ASCIIKey.Keyc: btnC.PerformClick(); break;
                case ASCIIKey.KeyD:
                case ASCIIKey.Keyd: btnD.PerformClick(); break;
                case ASCIIKey.KeyE:
                case ASCIIKey.Keye: btnE.PerformClick(); break;
                case ASCIIKey.KeyF:
                case ASCIIKey.Keyf: btnF.PerformClick(); break;
                case ASCIIKey.KeyDecimal: btnDecimal.PerformClick(); break;
                case ASCIIKey.KeyAdd: btnAdd.PerformClick(); break;
                case ASCIIKey.KeySubtract: btnSubtract.PerformClick(); break;
                case ASCIIKey.KeyMultiply: btnMultiply.PerformClick(); break;
                case ASCIIKey.KeyDivide: btnDivide.PerformClick(); break;
                case ASCIIKey.KeyBackspace: btnBackspace.PerformClick(); break;
            };
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            ClearMemory();

            lblMemoryData.Text = lblMemoryData.Tag + "0";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            lblDisplay.Text = ReadMemory().ToString();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            WriteMemory(Convert.ToDouble(lblDisplay.Text));
            lblMemoryData.Text = lblMemoryData.Tag + ReadMemory().ToString();
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            WriteMemory(ReadMemory() + Convert.ToDouble(lblDisplay.Text));
            lblMemoryData.Text = lblMemoryData.Tag + ReadMemory().ToString();
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            WriteMemory(ReadMemory() - Convert.ToDouble(lblDisplay.Text));
            lblMemoryData.Text = lblMemoryData.Tag + ReadMemory().ToString();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);

                if (lblDisplay.Text == string.Empty)
                    throw new Exception();
            }

            catch (Exception) { lblDisplay.Text = "0"; }
        }

        private void btnCancelEntry_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            lblDisplay.Text = "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_Error = false;
            m_LastOperator = MultipleOperandsOperation.NoOp;
            m_LastResult = "0";
            m_ClearDisplayOnEntry = true;

            btnCancelEntry.PerformClick();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            lblDisplay.Text = (-Convert.ToDouble(lblDisplay.Text)).ToString();
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                lblDisplay.Text = CheckResult(Convert.ToDouble(lblDisplay.Text) / 100.0f * Convert.ToDouble(m_LastResult)).ToString();
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                lblDisplay.Text = CheckResult(Math.Pow(Convert.ToDouble(lblDisplay.Text), 0.5f)).ToString();
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            m_LastOperator = MultipleOperandsOperation.Add;
            m_LastResult = lblDisplay.Text;
            m_ClearDisplayOnEntry = true;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            m_LastOperator = MultipleOperandsOperation.Subtract;
            m_LastResult = lblDisplay.Text;
            m_ClearDisplayOnEntry = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            m_LastOperator = MultipleOperandsOperation.Multiply;
            m_LastResult = lblDisplay.Text;
            m_ClearDisplayOnEntry = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            m_LastOperator = MultipleOperandsOperation.Divide;
            m_LastResult = lblDisplay.Text;
            m_ClearDisplayOnEntry = true;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            m_LastOperator = MultipleOperandsOperation.Mod;
            m_LastResult = lblDisplay.Text;
            m_ClearDisplayOnEntry = true;
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                lblDisplay.Text = CheckResult(1.0f / Convert.ToDouble(lblDisplay.Text)).ToString();
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_LastOperator == MultipleOperandsOperation.NoOp)
                    return; // No operator specified, so do nothing

                double Operand1 = 0.0f, Operand2 = 0.0f;

                // Determine first and second operands
                switch (m_BaseMode)
                {
                    case BaseMode.Binary:
                        Operand1 = Convert.ToUInt32(m_LastResult, (int) BaseMode.Binary);
                        Operand2 = Convert.ToUInt32(lblDisplay.Text, (int) BaseMode.Binary);

                        break;

                    case BaseMode.Decimal:
                        Operand1 = Convert.ToDouble(m_LastResult);
                        Operand2 = Convert.ToDouble(lblDisplay.Text);

                        break;

                    case BaseMode.Hexadecimal:
                        Operand1 = Convert.ToUInt32(m_LastResult, (int) BaseMode.Hexadecimal);
                        Operand2 = Convert.ToUInt32(lblDisplay.Text, (int) BaseMode.Hexadecimal);

                        break;
                }

                string Result = string.Empty;

                // Do the operation on specified operands
                switch (m_LastOperator)
                {
                    case MultipleOperandsOperation.Add:
                        Result = Convert.ToString(Operand1 + Operand2);

                        switch (m_BaseMode)
                        {
                            case BaseMode.Binary:
                                Result = Convert.ToString(Convert.ToUInt32(Result), (int)BaseMode.Binary);
                                
                                break;

                            case BaseMode.Hexadecimal:
                                Result = Convert.ToUInt32(Result).ToString("X");
                                
                                break;
                        };

                        updownHistory.Items.Add((m_BaseMode == BaseMode.Decimal ? Operand1.ToString() : m_LastResult) + " + " + (m_BaseMode == BaseMode.Decimal ? Operand2.ToString() : lblDisplay.Text) + " = " + Result);

                        break;

                    case MultipleOperandsOperation.Subtract:
                        Result = Convert.ToString(Operand1 - Operand2);

                        switch (m_BaseMode)
                        {
                            case BaseMode.Binary:
                                Result = Convert.ToString(Convert.ToUInt32(Result), (int)BaseMode.Binary);
                                
                                break;

                            case BaseMode.Hexadecimal:
                                Result = Convert.ToUInt32(Result).ToString("X");
                                
                                break;
                        };

                        updownHistory.Items.Add((m_BaseMode == BaseMode.Decimal ? Operand1.ToString() : m_LastResult) + " - " + (m_BaseMode == BaseMode.Decimal ? Operand2.ToString() : lblDisplay.Text) + " = " + Result);

                        break;

                    case MultipleOperandsOperation.Multiply:
                        Result = Convert.ToString(Operand1 * Operand2);

                        switch (m_BaseMode)
                        {
                            case BaseMode.Binary:
                                Result = Convert.ToString(Convert.ToUInt32(Result), (int)BaseMode.Binary);
                                
                                break;

                            case BaseMode.Hexadecimal:
                                Result = Convert.ToUInt32(Result).ToString("X");
                                
                                break;
                        };

                        updownHistory.Items.Add((m_BaseMode == BaseMode.Decimal ? Operand1.ToString() : m_LastResult) + " * " + (m_BaseMode == BaseMode.Decimal ? Operand2.ToString() : lblDisplay.Text) + " = " + Result);

                        break;

                    case MultipleOperandsOperation.Divide:
                        Result = Convert.ToString(Operand1 / Operand2);

                        switch (m_BaseMode)
                        {
                            case BaseMode.Binary:
                                Result = Convert.ToString(Convert.ToUInt32(Result), (int)BaseMode.Binary);
                                
                                break;

                            case BaseMode.Hexadecimal:
                                Result = Convert.ToUInt32(Result).ToString("X");
                                
                                break;
                        };

                        updownHistory.Items.Add((m_BaseMode == BaseMode.Decimal ? Operand1.ToString() : m_LastResult) + " / " + (m_BaseMode == BaseMode.Decimal ? Operand2.ToString() : lblDisplay.Text) + " = " + Result);

                        break;

                    case MultipleOperandsOperation.Mod:
                        Result = Convert.ToString(Operand1 % Operand2);

                        updownHistory.Items.Add(Operand1.ToString() + " Mod " + Operand2.ToString() + " = " + Result);

                        break;

                    case MultipleOperandsOperation.AND:
                        Result = AND(m_LastResult, lblDisplay.Text);

                        updownHistory.Items.Add(Operand1.ToString() + " AND " + Operand2.ToString() + " = " + Result);

                        break;

                    case MultipleOperandsOperation.OR:
                        Result = OR(m_LastResult, lblDisplay.Text);

                        updownHistory.Items.Add(Operand1.ToString() + " OR " + Operand2.ToString() + " = " + Result);

                        break;

                    case MultipleOperandsOperation.XOR:
                        Result = XOR(m_LastResult, lblDisplay.Text);

                        updownHistory.Items.Add(Operand1.ToString() + " XOR " + Operand2.ToString() + " = " + Result);

                        break;
                }

                lblDisplay.Text = Result;
                m_ClearDisplayOnEntry = true;
            }

            catch (Exception) { RaiseError(); }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "9";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "A";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "B";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "C";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "D";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "E";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; lblDisplay.Text = string.Empty; }

            lblDisplay.Text += "F";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            if (m_ClearDisplayOnEntry) { m_ClearDisplayOnEntry = false; }

            lblDisplay.Text += ".";
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                lblDisplay.Text = CheckResult(Math.Pow(Convert.ToDouble(lblDisplay.Text), 2.0f)).ToString();
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                lblDisplay.Text = CheckResult(Math.Pow(Convert.ToDouble(lblDisplay.Text), 3.0f)).ToString();
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnTensPower_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                lblDisplay.Text = CheckResult(Math.Pow(10.0f, Convert.ToDouble(lblDisplay.Text))).ToString();
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnePower_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                lblDisplay.Text = CheckResult(Math.Exp(Convert.ToDouble(lblDisplay.Text))).ToString();
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;
                
                lblDisplay.Text = CheckResult(Factorial(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(Operand + "! = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;

                lblDisplay.Text = CheckResult(Math.Sin(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(btnSin.Text + "(" + Operand + ") = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;

                lblDisplay.Text = CheckResult(Math.Cos(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(btnCos.Text + "(" + Operand + ") = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;

                lblDisplay.Text = CheckResult(Math.Tan(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(btnTan.Text + "(" + Operand + ") = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;

                lblDisplay.Text = CheckResult(Math.Log10(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(btnLog.Text + "(" + Operand + ") = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;

                lblDisplay.Text = CheckResult(Math.Log(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(btnLn.Text + "(" + Operand + ") = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnSinInverse_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;

                lblDisplay.Text = CheckResult(Math.Asin(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(btnSinInverse.Text + "(" + Operand + ") = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnCosInverse_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;

                lblDisplay.Text = CheckResult(Math.Acos(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(btnCosInverse.Text + "(" + Operand + ") = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnTanInverse_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;

                lblDisplay.Text = CheckResult(Math.Atan(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(btnTanInverse.Text + "(" + Operand + ") = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;

                lblDisplay.Text = CheckResult(Math.Sinh(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(btnSinh.Text + "(" + Operand + ") = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;

                lblDisplay.Text = CheckResult(Math.Cosh(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(btnCosh.Text + "(" + Operand + ") = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            try
            {
                string Operand = lblDisplay.Text;

                lblDisplay.Text = CheckResult(Math.Tanh(Convert.ToDouble(lblDisplay.Text))).ToString();
                updownHistory.Items.Add(btnTanh.Text + "(" + Operand + ") = " + lblDisplay.Text);
            }

            catch (Exception) { RaiseError(); }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            m_ClearDisplayOnEntry = true;

            lblDisplay.Text = Math.E.ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            m_ClearDisplayOnEntry = true;

            lblDisplay.Text = Math.PI.ToString();
        }

        private void btnAND_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            m_LastOperator = MultipleOperandsOperation.AND;
            m_LastResult = lblDisplay.Text;
            m_ClearDisplayOnEntry = true;
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            m_LastOperator = MultipleOperandsOperation.OR;
            m_LastResult = lblDisplay.Text;
            m_ClearDisplayOnEntry = true;
        }

        private void btnNOT_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            string Operand = lblDisplay.Text;

            lblDisplay.Text = NOT(lblDisplay.Text);
            updownHistory.Items.Add(btnNOT.Text + " " + Operand + " = " + lblDisplay.Text);
        }

        private void btnXOR_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            m_LastOperator = MultipleOperandsOperation.XOR;
            m_LastResult = lblDisplay.Text;
            m_ClearDisplayOnEntry = true;
        }

        private void btnLsh_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            string Operand = lblDisplay.Text;

            lblDisplay.Text = Lsh(lblDisplay.Text);
            updownHistory.Items.Add(btnLsh.Text + " " + Operand + " = " + lblDisplay.Text);
        }

        private void btnRsh_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            string Operand = lblDisplay.Text;

            lblDisplay.Text = Rsh(lblDisplay.Text);
            updownHistory.Items.Add(btnRsh.Text + " " + Operand + " = " + lblDisplay.Text);
        }

        private void btnRoL_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            string Operand = lblDisplay.Text;

            lblDisplay.Text = RoL(lblDisplay.Text);
            updownHistory.Items.Add(btnRoL.Text + " " + Operand + " = " + lblDisplay.Text);
        }

        private void btnRoR_Click(object sender, EventArgs e)
        {
            if (m_Error) return;

            string Operand = lblDisplay.Text;

            lblDisplay.Text = RoR(lblDisplay.Text);
            updownHistory.Items.Add(btnRoR.Text + " " + Operand + " = " + lblDisplay.Text);
        }

        private void optDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (!optDecimal.Checked) return;

            if (!m_Error)
            {
                string PrevResult = lblDisplay.Text;
                
                btnCancel.PerformClick();

                switch (m_BaseMode)
                {
                    case BaseMode.Hexadecimal:
                        lblDisplay.Text = Convert.ToUInt32(PrevResult, (int) BaseMode.Hexadecimal).ToString();

                        break;

                    case BaseMode.Binary:
                        lblDisplay.Text = Convert.ToUInt32(PrevResult, (int) BaseMode.Binary).ToString();

                        break;
                };
            }

            m_BaseMode = BaseMode.Decimal;

            Button[] ButtonsToEnable = { btnMC, btnMR, btnMS, btnMPlus, btnMMinus, btnExp, btnPi, btnMod, btnDecimal,
                                            btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnPlusMinus, btnSquareRoot, 
                                            btnInverse, btnSquare, btnCube, btnTensPower, btnePower, btnSin, btnCos, btnTan,
                                            btnFactorial, btnSinInverse, btnCosInverse, btnTanInverse, btnLog, btnPercentage,
                                            btnSinh, btnCosh, btnTanh, btnLn };
            Button[] ButtonsToDisable = { btnA, btnB, btnC, btnD, btnE, btnF,
                                            btnAND, btnOR, btnNOT, btnXOR, btnLsh, btnRsh, btnRoL, btnRoR };

            // Enable some
            for (int i = 0; i < ButtonsToEnable.Length; i++)
                ButtonsToEnable[i].Enabled = true;

            // Disable others
            for (int i = 0; i < ButtonsToDisable.Length; i++)
                ButtonsToDisable[i].Enabled = false;
        }

        private void optHex_CheckedChanged(object sender, EventArgs e)
        {
            if (!optHex.Checked) return;

            if (!m_Error)
            {
                string PrevResult = lblDisplay.Text;

                btnCancel.PerformClick();

                switch (m_BaseMode)
                {
                    case BaseMode.Decimal:
                        if (!HasFractionalPart(Convert.ToDouble(PrevResult)) && Math.Sign(Convert.ToDouble(PrevResult)) > 0)
                        {
                            try
                            {
                                lblDisplay.Text = Convert.ToUInt32(PrevResult).ToString("X");
                            }

                            catch (Exception) { lblDisplay.Text = new string('F', 8); }
                        }

                        break;

                    case BaseMode.Binary:
                        try
                        {
                            lblDisplay.Text = Convert.ToString(Convert.ToInt32(PrevResult, (int)BaseMode.Binary), (int)BaseMode.Hexadecimal).ToUpper();
                        }

                        catch (Exception) { lblDisplay.Text = new string('F', 8); }

                        break;
                };
            }

            m_BaseMode = BaseMode.Hexadecimal;

            Button[] ButtonsToEnable = { btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, 
                                           btnA, btnB, btnC, btnD, btnE, btnF };
            Button[] ButtonsToDisable = { btnMC, btnMR, btnMS, btnMPlus, btnMMinus, btnExp, btnPi, btnMod,
                                            btnPlusMinus, btnPercentage, btnSquareRoot, btnInverse, btnSquare, btnCube, 
                                            btnTensPower, btnePower, btnSin, btnCos, btnTan, btnFactorial, 
                                            btnSinInverse, btnCosInverse, btnTanInverse, btnLog, btnDecimal,
                                            btnSinh, btnCosh, btnTanh, btnLn,
                                            btnAND, btnOR, btnNOT, btnXOR, btnLsh, btnRsh, btnRoL, btnRoR };

            // Enable some
            for (int i = 0; i < ButtonsToEnable.Length; i++)
                ButtonsToEnable[i].Enabled = true;

            // Disable others
            for (int i = 0; i < ButtonsToDisable.Length; i++)
                ButtonsToDisable[i].Enabled = false;
        }

        private void optBinary_CheckedChanged(object sender, EventArgs e)
        {
            if (!optBinary.Checked) return;

            if (!m_Error)
            {
                string PrevResult = lblDisplay.Text;

                btnCancel.PerformClick();

                switch (m_BaseMode)
                {
                    case BaseMode.Decimal:
                        try
                        {
                            if (!HasFractionalPart(Convert.ToDouble(PrevResult)) && Math.Sign(Convert.ToDouble(PrevResult)) > 0)
                                lblDisplay.Text = Convert.ToString(Convert.ToUInt32(PrevResult), (int)BaseMode.Binary);
                        }

                        catch (Exception) { lblDisplay.Text = new string('1', SUPPORTED_BITS); }

                        break;

                    case BaseMode.Hexadecimal:
                        try
                        {
                            lblDisplay.Text = Convert.ToString(Convert.ToUInt32(PrevResult, (int)BaseMode.Hexadecimal), (int)BaseMode.Binary);
                        }

                        catch (Exception) { lblDisplay.Text = new string('1', SUPPORTED_BITS); }

                        break;
                };
            }

            m_BaseMode = BaseMode.Binary;

            Button[] ButtonsToEnable = { btnAND, btnOR, btnNOT, btnXOR, btnLsh, btnRsh, btnRoL, btnRoR };
            Button[] ButtonsToDisable = { btnMC, btnMR, btnMS, btnMPlus, btnMMinus, btnExp, btnPi, btnMod,
                                            btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnA, btnB,
                                            btnC, btnD, btnE, btnF, btnDecimal, btnPlusMinus, btnSquareRoot, btnInverse,
                                            btnPercentage, btnSquare, btnCube, btnTensPower, btnePower, btnSin, btnCos, btnTan,
                                            btnFactorial, btnSinInverse, btnCosInverse, btnTanInverse, btnLog, 
                                            btnSinh, btnCosh, btnTanh, btnLn };

            // Enable some
            for (int i = 0; i < ButtonsToEnable.Length; i++)
                ButtonsToEnable[i].Enabled = true;

            // Disable others
            for (int i = 0; i < ButtonsToDisable.Length; i++)
                ButtonsToDisable[i].Enabled = false;
        }

        private void lnklblMyBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lnklblMyBlog.Tag.ToString());
        }

        private void lblDisplay_TextChanged(object sender, EventArgs e)
        {
            // Implement automatic font size reduction when contents get too large
            const float MinFontSize = 7.5f;
            const float MaxFontSize = 21.75f;
            const float IncrementDecrementValue = 0.5f;

            Graphics LabelGraphics = lblDisplay.CreateGraphics();
            SizeF StringSize = LabelGraphics.MeasureString(lblDisplay.Text, lblDisplay.Font);

            if (ConvertPixelsToPoints(LabelGraphics, lblDisplay.ClientSize.Width) < StringSize.Width)
            {
                do
                {
                    lblDisplay.Font = new Font(lblDisplay.Font.Name, (lblDisplay.Font.Size == MinFontSize ? MinFontSize : lblDisplay.Font.Size - IncrementDecrementValue));

                    StringSize = LabelGraphics.MeasureString(lblDisplay.Text, lblDisplay.Font);
                } while (ConvertPixelsToPoints(LabelGraphics, lblDisplay.ClientSize.Width) < StringSize.Width && lblDisplay.Font.Size != MinFontSize);
            }
            else if (ConvertPixelsToPoints(LabelGraphics, lblDisplay.ClientSize.Width) > StringSize.Width)
            {
                do
                {
                    lblDisplay.Font = new Font(lblDisplay.Font.Name, (lblDisplay.Font.Size == MaxFontSize ? MaxFontSize : lblDisplay.Font.Size + IncrementDecrementValue));

                    StringSize = LabelGraphics.MeasureString(lblDisplay.Text, lblDisplay.Font);
                } while (ConvertPixelsToPoints(LabelGraphics, lblDisplay.ClientSize.Width) > StringSize.Width && lblDisplay.Font.Size != MaxFontSize);
            }

            LabelGraphics.Dispose();
        }
    }
}
