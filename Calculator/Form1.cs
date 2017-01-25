using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    /**
    * @brief Form1 클래스
    * @author 정기빈
    * @date 2017-1-15
    * @version 1.0
    * @remarks ver1.1 doxygen 주석 양식 적용 및 주석 예시 추가
    * @warning 특이 경고 없음
    * @bug 작동상의 bug 없음
    * @todo 없음
    */
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        

        public enum Operator { ADD, SUB, MUL, DIV, EQU } // Opt 구분을 위한 enum 선언
        
        Operator PrevOpt = Operator.ADD; // 현재 눌린 Operator버튼의 종류 구분을 위한 변수
        double mem = 0; // num_screen(TextBox)의 값을 임시 저장하기 위한 변수
        bool is_opt_pushed = false;
        


        #region setNum 함수, NumClick 처리기 
    
       
        private void SetNum(string s)
        {


            if (is_opt_pushed == true)
            {
                is_opt_pushed = false;
                exp_screen.Text += s;
                num_screen.Text = s;
            }

            else if (num_screen.Text == "0")
            {
                exp_screen.Text += s;
                num_screen.Text = s;
            }

            else
            {
                exp_screen.Text += s;
                num_screen.Text = num_screen.Text + s;

            }
        }
       

    

        private void NumClick(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            SetNum(bt.Text);
        }
       
        #endregion


        #region OptClick 처리기
        
        /**
         * @brief click-EventHandler
         * @author 정기빈(hellome305@naver.com)
         * date 2017-1-3
         * @version 1.0
         * @remarks 1.1 1-9 까지의 click-EventHandler 재정의, 모든 버튼이 하나의 EventHandler를 공유하도록 코딩
         */ 
        private void OptClick(object sender, EventArgs e)
        {

            Button cur_bt = (Button)sender;

            if (is_opt_pushed == false)
            {
               

                double num = double.Parse(num_screen.Text);
                switch (PrevOpt)
                {
                    case Operator.ADD:
                    
                        mem += num;
                        break;

                    case Operator.SUB:
                      
                        mem -= num;
                        break;

                    case Operator.MUL:
                     
                        mem *= num;
                        break;


                    case Operator.DIV:
                       
                        mem /= num;
                        break;
                }


                num_screen.Text = mem.ToString();

            }


            
            String cur_opt = cur_bt.Text;
            switch (cur_opt)
            {
                case "+":
                    PrevOpt = Operator.ADD;
                    break;

                case "-":
                    PrevOpt = Operator.SUB;
                    break;

                case "*":
                    PrevOpt = Operator.MUL;
                    break;

                case "/":
                    PrevOpt = Operator.DIV;
                    break;

                case "=":
                    PrevOpt = Operator.EQU;
                    break;
                    
            }

            if (cur_bt != equalbtn)
            {
                if (cur_bt.Text == "*" || cur_bt.Text == "/")
                    exp_screen.Text = "(" + exp_screen.Text + ")" + cur_bt.Text;

                else
                    exp_screen.Text += cur_bt.Text;

                is_opt_pushed = true;
            }
        }
        
        #endregion


        #region ClearClick 처리기
       

        private void ClearClick(object sender, EventArgs e)
        {
            PrevOpt = Operator.ADD;
            mem = 0;
            is_opt_pushed = false;

            exp_screen.Text = null;
            num_screen.Text = "0";
        }

        #endregion
        
      
        #region DecipointClick 처리기

        private void DeciPointClick(object sender, EventArgs e)
        {
            bool existd_point = (num_screen.Text).Contains(".");

            if (existd_point == true)
                return;
            
             
            if (is_opt_pushed == true)
            {
                is_opt_pushed = false;
                exp_screen.Text += "0.";
                num_screen.Text = "0.";
            }

            else if (PrevOpt == Operator.EQU)
            {
                exp_screen.Text = null;
                num_screen.Text = "0.";
            }

            else
            {
                exp_screen.Text += ".";
                num_screen.Text += ".";
            }
        }



        #endregion

        #region Form1_KeyPress 처리기

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {            
           
            switch (e.KeyChar)
            {
                case '0':
                    zero.PerformClick();
                    break;

                case '1':
                    one.PerformClick();
                    break;

                case '2':
                    two.PerformClick();
                    break;

                case '3':
                    three.PerformClick();
                    break;

                case '4':
                    four.PerformClick();
                    break;

                case '5':
                    five.PerformClick();
                    break;

                case '6':
                    six.PerformClick();
                    break;

                case '7':
                    seven.PerformClick();
                    break;

                case '8':
                    eight.PerformClick();
                    break;

                case '9':
                    nine.PerformClick();
                    break;

                case '+':
                    add.PerformClick();
                    break;

                case '-':
                    sub.PerformClick();
                    break;

                case '*':
                    mul.PerformClick();
                    break;

                case '/':
                    div.PerformClick();
                    break;

                case '.':
                    decipoint.PerformClick();
                    break;


                case '=':
                    equalbtn.PerformClick();
                    break;


                default:
                    MessageBox.Show("잘못된 키 입력");
                    break;

                case (char)Keys.Enter:                  // ENTER키 입력시
                    equalbtn.PerformClick();
                    break;
                   

            }
        }
        #endregion

        
    }
}
