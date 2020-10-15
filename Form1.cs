using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //  string message = "?△";
            // string caption = "Error";
            //  MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            // DialogResult result;
            // result = MessageBox.Show(message, caption, buttons);
            //int randomNum = new Random().Next(6)+1;

            // MessageBox.Show($"{randomNum}","LONG", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //MessageBox.Show("" + randomNum, "DICE", MessageBoxButtons.OK, MessageBoxIcon.Question);
            
                try
                {
                    //提取輸入內容
                    string input_str = tbInput.Text;
                    //轉換int 
                    int input_int = int.Parse(input_str);

                    //TODO: 寫判斷邏輯

                    //顯示內容
                    MessageBox.Show($"{input_int}", "Random Num", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    //錯誤提示
                    MessageBox.Show($"不要亂輸入", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            
        }
    }
}
