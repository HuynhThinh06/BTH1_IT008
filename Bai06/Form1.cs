using System;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        double memory = 0;        // Bộ nhớ M
        double lastOperand = 0;   // Toán hạng trái (left)
        double lastRight = 0;     // Toán hạng phải (right) — dùng khi lặp "="
        string lastOperator = ""; // Phép toán cuối cùng
        bool isNewEntry = true;   // Bắt đầu nhập số mới
        bool hasOperator = false; // Đã chọn phép toán hay chưa

        public Form1()
        {
            InitializeComponent();
            AddHandlers();
            textBox1.Text = "0";
        }

        private void AddHandlers()
        {
            btZero.Click += Number_Click;
            btOne.Click += Number_Click;
            btTwo.Click += Number_Click;
            btThree.Click += Number_Click;
            btFour.Click += Number_Click;
            btFive.Click += Number_Click;
            btSix.Click += Number_Click;
            btSeven.Click += Number_Click;
            btEight.Click += Number_Click;
            btNine.Click += Number_Click;
            btPoint.Click += Number_Click;
            btAdd.Click += Operator_Click;
            btSub.Click += Operator_Click;
            btMul.Click += Operator_Click;
            btTen.Click += Operator_Click;
            btEqual.Click += Equal_Click;
            btC.Click += (s, e) => ClearAll();
            btCE.Click += (s, e) => ClearEntry();
            btBS.Click += (s, e) => Backspace();
            btOpposite.Click += (s, e) => ToggleSign();
            btSQRT.Click += (s, e) => Sqrt();
            btPerc.Click += (s, e) => Percent();
            btFr.Click += (s, e) => Reciprocal();
            btMC.Click += (s, e) => { memory = 0; };
            btMS.Click += (s, e) => { memory = ParseDisplay(); };
            btMR.Click += (s, e) => { textBox1.Text = memory.ToString(); isNewEntry = true; };
            btM.Click += (s, e) => { memory += ParseDisplay(); };
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            string text = bt.Text;

            if (isNewEntry)
            {
                textBox1.Text = (text == ".") ? "0." : text;
                isNewEntry = false;
            }
            else
            {
                if (text == "." && textBox1.Text.Contains(".")) return;
                if (textBox1.Text == "0" && text != ".")
                    textBox1.Text = text;
                else
                    textBox1.Text += text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            string op = bt.Text;

            double current = ParseDisplay();

            if (hasOperator)
            {
                // chuỗi phép toán: thực hiện phép trước khi gán phép mới
                ApplyOperator(lastOperator, lastOperand, current);
                // ApplyOperator cập nhật lastOperand (kết quả)
            }
            else
            {
                lastOperand = current;
            }

            // Chuẩn bị cho phép toán mới
            lastOperator = op;
            isNewEntry = true;
            hasOperator = true;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            double current = ParseDisplay();

            if (hasOperator)
            {
                lastRight = current; // lưu toán hạng phải để lặp '=' sau này
                ApplyOperator(lastOperator, lastOperand, current);
                hasOperator = false;
            }
            else
            {
                if (lastOperator != "")
                {
                    ApplyOperator(lastOperator, lastOperand, lastRight);
                }
            }
        }

        private void ApplyOperator(string op, double left, double right)
        {
            double result = left;

            switch (op)
            {
                case "+": result = left + right; break;
                case "-": result = left - right; break;
                case "*": result = left * right; break;
                case "/":
                    if (right == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!");
                        return;
                    }
                    result = left / right;
                    break;
                default:
                    // nếu op rỗng thì bỏ qua
                    break;
            }

            textBox1.Text = result.ToString();
            lastOperand = result; 
            isNewEntry = true;
        }

        private void ClearAll()
        {
            textBox1.Text = "0";
            lastOperand = 0;
            lastRight = 0;
            lastOperator = "";
            hasOperator = false;
            isNewEntry = true;
        }

        private void ClearEntry()
        {
            textBox1.Text = "0";
            isNewEntry = true;
        }

        private void Backspace()
        {
            if (!isNewEntry && textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                if (textBox1.Text == "") textBox1.Text = "0";
            }
        }

        private void ToggleSign()
        {
            double val = ParseDisplay();
            val = -val;
            textBox1.Text = val.ToString();
        }

        private void Sqrt()
        {
            double val = ParseDisplay();
            if (val < 0)
            {
                MessageBox.Show("Không thể căn số âm!");
                return;
            }
            textBox1.Text = Math.Sqrt(val).ToString();
            isNewEntry = true;
        }

        private void Percent()
        {
            double val = ParseDisplay();
            textBox1.Text = (val / 100.0).ToString();
            isNewEntry = true;
        }

        private void Reciprocal()
        {
            double val = ParseDisplay();
            if (val == 0)
            {
                MessageBox.Show("Không thể chia cho 0!");
                return;
            }
            textBox1.Text = (1.0 / val).ToString();
            isNewEntry = true;
        }

        private double ParseDisplay()
        {
            double.TryParse(textBox1.Text, out double val);
            return val;
        }
    }
}
