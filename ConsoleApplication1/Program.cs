using System;
using System.Collections;
using System.Windows.Forms

namespace SDA_Pr03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Decimal Arithmetic ( Decimal a, string oper, Decimal b, out bool isOK)
        {
            Decimal result = 0;
            switch (oper)
            {
                case "+": result = a+b; break;
                case "-": result = a-b; break;
                case "*": result = a*b; break;
                case "/"
                    if (b!=0)
                        result = a/b;
                    else
                    {
                    isOK = false;
                    result=0;
                    }
                    break;
                default:break;
            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Decimal prevNum, currNum = 0;
            Decimal tmpNum;
            string inputText;
            string oper;
            const string operators = "+-*/";
            Stack revStack = new Stack();
            Stack stack = new Stack();
            inputText = textBox1.Text;
            richTextBox1.Clear();
            if (inputText.Length == 0 )
                return;
            string[] temp = inputText.Split ();
            //Split() връща масив от поднизове - разделител "шпация"
            // В цикъла се създава стека stack 
            foreach (String str in temp)
            {
                if (str.Length == 0) // Ако има излишни шпации
                    continue;
                if (Decimal.TryParsee(str, out tmpNum))
                {
                    stack.Push ( str); //Низ от цифри
                }
                else
                {
                    if ( str.Length == 1 && (operators.Contains (str)))
                    {//Ако символът е оператор "+-*/"
                        stack.Push (str); // Добавя се в стека
                    }
                    else
                    {
                        MessageBox.Show("Неразпозната операция [" + str+"]");
                        return;
                    }
                }
            }
            if ((stack.Count < 3 || (stack.Count % 2) ==0)
            {
                MessageBox.Show{
                    "Стекът трябва да съдържа повече от два елемента. \n"
                        +"Броят на елементите трябва да е нечетен.'\n"
                        +"Или операндите не са разделени със шпация.");
                    return;
                }
                //Обръщане на стека stack
                while (stack.Count > 0)
                    revStack.Push ( stack.Pop ());
                //Сега стекът RevStack е обърнат
                //По-нататъшните действия се реализират с този стек
                // Взема се първият елемент от стека
                prevNum = Decimal.Parse (revStack.Pop().ToString());
                bool isOK = true;
                while (revStack.Count > 0)
                {
                    oper = revStack.Pop().ToString();
                    currNum = Decimal.Parse(revStack.Pop().ToString());
                    richTextBox1.Text += String.Format("{0} {1} {2} \n", prevNum, oper, currNum);
                    // 1+ 2
                    prevNum = Arithmetic (prevNum,oper, currNum, out isOK);
                    if (!isOK)
                    { // isOK = false
                        richTextBox1.Text +=
                            String.Format("Опит за деление на нула. \n");
                        break;
                    }
                }
                if (isOK)
                {//isOK = true
                    richTextBox1.Text += String.Format("{0} = {1}", inputText, prevNum.ToString());
                }
            }
        }
    }

}