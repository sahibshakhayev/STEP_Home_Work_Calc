namespace HW
{
    public partial class Form1 : Form
    {
        public double Operand1 { get; set; } = 0;
        public double Operand2 { get; set; } = 0;
        public double Answer { get; set; } = 0;
        bool clear = true;
 

        string operation = "";



        public Form1()
        {
            InitializeComponent();
        }


         private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Numbers_Click(object sender, EventArgs e)
        {

            var btn = (Button)sender;

            if (btn.Text == "," && label1.Text.IndexOf(",") == -1 && label1.Text.Length >= 1)
            {
                 label1.Text += ",";
                 clear = false;
            }

            if (label1.Text != "0"  && btn.Text != "," && btn.Text != "+ -" && !clear)
            {
                label1.Text += btn.Text;
            }
            if (label1.Text == "0" && btn.Text != "0" && btn.Text != "," && btn.Text != "+ -" || clear)
            {
                label1.Text = btn.Text;
                clear = false;
            }

            if (btn.Text == "+ -")
            {
                if (label1.Text[0] == '-')
                {
                     label1.Text = label1.Text.Remove(0, 1);
                }


                else
                {
                    label1.Text = "-" + label1.Text;

                }

            }
     }


        private void EraseNumber(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Text == "<-" && label1.Text != "0" && label1.Text.Length > 1)
            {
              label1.Text = label1.Text.Remove(label1.Text.Length-1, 1);
            }
            else if (label1.Text.Length == 1 && btn.Text == "<-")
            {
                label1.Text = "0";

            }
            else if (btn.Text == "C")
            {
                label1.Text = "0";
                label2.Text = "";
                operation = "";
                Operand1 = 0;
                Operand2 = 0;
                Answer = 0;
                clear = true; ;
            }

            else if (btn.Text == "CE")
            {
                label1.Text = "0";
                clear = true;
            }

        }


        private void Operations(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (btn.Text == "+")
            {
                if (Operand1 == 0)
                {
                    Operand1 = double.Parse(label1.Text);
                    label2.Text = Operand1.ToString() + " + ";
                    clear = true;
                    operation = "+";
                }
                else if ((Operand2 == 0 || !clear) && Answer == 0) {
                    if (Operand1 != 0)
                    {
                        label2.Text = Operand1.ToString() + " + ";
                    }

                    Operand2 = double.Parse(label1.Text);
                    Answer = Operand1 + Operand2;
                    label1.Text = Answer.ToString();
                    label2.Text += Operand2.ToString() + " =";
                    Operand1 = Answer;
                    Operand2 = 0;
                    Answer = 0;
                    clear=true;
                
                
                }

                else if (Operand2 != 0)
                {

                    if (Operand1 != 0)
                    {
                        label2.Text = Operand1.ToString() + " + ";
                    }

                    Operand2 = double.Parse(label1.Text);
                    Answer = Operand1 + Operand2;
                    label1.Text = Answer.ToString();
                    label2.Text += Operand2.ToString() + " =";
                    Operand1 = Answer;
                    Operand2 = 0;
                    Answer = 0;
                    clear = true;

                }



            }
            if (btn.Text == "-")
            {
                if (Operand1 == 0)
                {
                    Operand1 = double.Parse(label1.Text);
                    label2.Text = Operand1.ToString() + " - ";
                    clear = true;
                    operation = "-";
                }
                else if ((Operand2 == 0 || !clear) && Answer == 0)
                {
                    if (Operand1 != 0)
                    {
                        label2.Text = Operand1.ToString() + " - ";
                    }

                    Operand2 = double.Parse(label1.Text);
                    Answer = Operand1 - Operand2;
                    label1.Text = Answer.ToString();
                    label2.Text += Operand2.ToString() + " =";
                    Operand1 = Answer;
                    Operand2 = 0;
                    Answer = 0;
                    clear = true;


                }



            }
            if (btn.Text == "X")
            {
                if (Operand1 == 0)
                {
                    Operand1 = double.Parse(label1.Text);
                    label2.Text = Operand1.ToString() + " X ";
                    clear = true;
                    operation = "*";
                }
                else if ((Operand2 == 0 || !clear) && Answer == 0)
                {
                    if (Operand1 != 0)
                    {
                        label2.Text = Operand1.ToString() + " X ";
                    }

                    Operand2 = double.Parse(label1.Text);
                    Answer = Operand1 * Operand2;
                    label1.Text = Answer.ToString();
                    label2.Text += Operand2.ToString() + " =";
                    Operand1 = Answer;
                    Operand2 = 0;
                    Answer = 0;
                    clear = true;


                }



            }


            if (btn.Text == "/")
            {
                if (Operand1 == 0)
                {
                    Operand1 = double.Parse(label1.Text);
                    label2.Text = Operand1.ToString() + " / ";
                    clear = true;
                    operation = "/";
                }
                else if ((Operand2 == 0 || !clear) && Answer == 0)
                {
                    if (Operand1 != 0)
                    {
                        label2.Text = Operand1.ToString() + " / ";
                    }

                    Operand2 = double.Parse(label1.Text);
                    if (Operand2 != 0)
                    {
                        Answer = Operand1 / Operand2;
                        label1.Text = Answer.ToString();
                    }
                    else
                    {
                        label1.Text = "Error!";
                        clear=true;
                    }
                    
                    label2.Text += Operand2.ToString() + " =";
                    Operand1 = Answer;
                    Operand2 = 0;
                    Answer = 0;
                    clear = true;


                }



            }

            if (btn.Text == "=")
            {
                if (Operand1 == 0 && operation == "")
                {
                    Operand1 = double.Parse(label1.Text);
                    label2.Text = Operand1.ToString() + " = ";
                    clear = true;
                }
                
                    if (Operand1 != 0)
                    {
                        label2.Text = Operand1.ToString() + " " + operation + " ";
                    }
                if (Answer == 0)
                {
                    Operand2 = double.Parse(label1.Text);
                }

                   
                    if (operation == "+")
                    {
                        Answer = Operand1 + Operand2;
                    label1.Text = Answer.ToString();
                }
                if (operation == "-")
                {
                    Answer = Operand1 - Operand2;
                    label1.Text = Answer.ToString();
                }

                if (operation == "*")
                {
                    Answer = Operand1 * Operand2;
                    label1.Text = Answer.ToString();
                }

                if (operation == "/")
                {
                    if (Operand2 != 0)
                    {
                        Answer = Operand1 / Operand2;
                        label1.Text = Answer.ToString();

                    }
                    else
                    {

                        label1.Text = "Error!";
                    }


                }
                
                
                    label2.Text += Operand2.ToString() + " =";
                    Operand1 = Answer;
                    clear = true;


                



            }


            if (btn.Text == "%")
            {

                Answer = Operand1 * double.Parse(label1.Text) / 100;
                label1.Text = Answer.ToString();
                Answer = 0;


            }
            if (btn.Text == "sqrt")
            {

                Answer = Math.Sqrt(double.Parse(label1.Text));
                label2.Text = "sqrt(" + label1.Text + ")";
                label1.Text = Answer.ToString();
                
                Answer = 0;


            }

            if (btn.Text == "x^2")
            {

                Answer = double.Parse(label1.Text) * double.Parse(label1.Text);
                label2.Text = "sqrt(" + label1.Text + ")";
                label1.Text = Answer.ToString();

                Answer = 0;


            }

            if (btn.Text == "x^2")
            {

                Answer = double.Parse(label1.Text) * double.Parse(label1.Text);
                label2.Text = "sqr(" + label1.Text + ")";
                label1.Text = Answer.ToString();

                Answer = 0;


            }

            if (btn.Text == "1/x")
            {
                if (label1.Text != "0")
                {
                    Answer = 1 / double.Parse(label1.Text);
                    label2.Text = "1/(" + label1.Text + ")";
                    label1.Text = Answer.ToString();
                }
                else
                {
                    label2.Text = "1/(" + label1.Text + ")";
                    label1.Text = "Error!";

                }
                
               

                  Answer = 0;


            }

        }



    }
}