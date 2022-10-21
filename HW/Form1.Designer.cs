namespace HW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonEdual = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonMultiple = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonRemoveLast = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonDivtoOne = new System.Windows.Forms.Button();
            this.buttonKvadrat = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.Location = new System.Drawing.Point(9, 513);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(99, 55);
            this.buttonPlusMinus.TabIndex = 0;
            this.buttonPlusMinus.Text = "+ -";
            this.buttonPlusMinus.UseVisualStyleBackColor = true;
            this.buttonPlusMinus.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(114, 513);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(99, 55);
            this.buttonZero.TabIndex = 1;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(219, 513);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(99, 55);
            this.buttonPoint.TabIndex = 2;
            this.buttonPoint.Text = ",";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonEdual
            // 
            this.buttonEdual.Location = new System.Drawing.Point(324, 513);
            this.buttonEdual.Name = "buttonEdual";
            this.buttonEdual.Size = new System.Drawing.Size(96, 55);
            this.buttonEdual.TabIndex = 3;
            this.buttonEdual.Text = "=";
            this.buttonEdual.UseVisualStyleBackColor = true;
            this.buttonEdual.Click += new System.EventHandler(this.Operations);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(324, 452);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(96, 55);
            this.buttonPlus.TabIndex = 7;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.Operations);
            // 
            // buttonThree
            // 
            this.buttonThree.Location = new System.Drawing.Point(219, 452);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(99, 55);
            this.buttonThree.TabIndex = 6;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(114, 452);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(99, 55);
            this.buttonTwo.TabIndex = 5;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(9, 452);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(99, 55);
            this.buttonOne.TabIndex = 4;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonMultiple
            // 
            this.buttonMultiple.Location = new System.Drawing.Point(324, 330);
            this.buttonMultiple.Name = "buttonMultiple";
            this.buttonMultiple.Size = new System.Drawing.Size(96, 55);
            this.buttonMultiple.TabIndex = 15;
            this.buttonMultiple.Text = "X";
            this.buttonMultiple.UseVisualStyleBackColor = true;
            this.buttonMultiple.Click += new System.EventHandler(this.Operations);
            // 
            // buttonNine
            // 
            this.buttonNine.Location = new System.Drawing.Point(219, 330);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(99, 55);
            this.buttonNine.TabIndex = 14;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Location = new System.Drawing.Point(114, 330);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(99, 55);
            this.buttonEight.TabIndex = 13;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Location = new System.Drawing.Point(9, 330);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(99, 55);
            this.buttonSeven.TabIndex = 12;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(324, 391);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(96, 55);
            this.buttonMinus.TabIndex = 11;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.Operations);
            // 
            // buttonSix
            // 
            this.buttonSix.Location = new System.Drawing.Point(219, 391);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(99, 55);
            this.buttonSix.TabIndex = 10;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Location = new System.Drawing.Point(114, 391);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(99, 55);
            this.buttonFive.TabIndex = 9;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Location = new System.Drawing.Point(9, 391);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(99, 55);
            this.buttonFour.TabIndex = 8;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(324, 269);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(96, 55);
            this.buttonDivide.TabIndex = 23;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.Operations);
            // 
            // buttonRemoveLast
            // 
            this.buttonRemoveLast.Location = new System.Drawing.Point(219, 269);
            this.buttonRemoveLast.Name = "buttonRemoveLast";
            this.buttonRemoveLast.Size = new System.Drawing.Size(99, 55);
            this.buttonRemoveLast.TabIndex = 22;
            this.buttonRemoveLast.Text = "<-";
            this.buttonRemoveLast.UseVisualStyleBackColor = true;
            this.buttonRemoveLast.Click += new System.EventHandler(this.EraseNumber);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(114, 269);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(99, 55);
            this.buttonC.TabIndex = 21;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.EraseNumber);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(9, 269);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(99, 55);
            this.buttonCE.TabIndex = 20;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.EraseNumber);
            // 
            // buttonDivtoOne
            // 
            this.buttonDivtoOne.Location = new System.Drawing.Point(324, 208);
            this.buttonDivtoOne.Name = "buttonDivtoOne";
            this.buttonDivtoOne.Size = new System.Drawing.Size(96, 55);
            this.buttonDivtoOne.TabIndex = 19;
            this.buttonDivtoOne.Text = "1/x";
            this.buttonDivtoOne.UseVisualStyleBackColor = true;
            this.buttonDivtoOne.Click += new System.EventHandler(this.Operations);
            // 
            // buttonKvadrat
            // 
            this.buttonKvadrat.Location = new System.Drawing.Point(219, 208);
            this.buttonKvadrat.Name = "buttonKvadrat";
            this.buttonKvadrat.Size = new System.Drawing.Size(99, 55);
            this.buttonKvadrat.TabIndex = 18;
            this.buttonKvadrat.Text = "x^2";
            this.buttonKvadrat.UseVisualStyleBackColor = true;
            this.buttonKvadrat.Click += new System.EventHandler(this.Operations);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Location = new System.Drawing.Point(114, 208);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(99, 55);
            this.buttonSqrt.TabIndex = 17;
            this.buttonSqrt.Text = "sqrt";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.Operations);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Location = new System.Drawing.Point(9, 208);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(99, 55);
            this.buttonPercent.TabIndex = 16;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.Operations);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 124);
            this.label1.MinimumSize = new System.Drawing.Size(400, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 81);
            this.label1.TabIndex = 24;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.MinimumSize = new System.Drawing.Size(400, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 81);
            this.label2.TabIndex = 25;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonRemoveLast);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonDivtoOne);
            this.Controls.Add(this.buttonKvadrat);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonMultiple);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonEdual);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonPlusMinus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonPlusMinus;
        private Button buttonZero;
        private Button buttonPoint;
        private Button buttonEdual;
        private Button buttonPlus;
        private Button buttonThree;
        private Button buttonTwo;
        private Button buttonOne;
        private Button buttonMultiple;
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonSeven;
        private Button buttonMinus;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonDivide;
        private Button buttonRemoveLast;
        private Button buttonC;
        private Button buttonCE;
        private Button buttonDivtoOne;
        private Button buttonKvadrat;
        private Button buttonSqrt;
        private Button buttonPercent;
        private Label label1;
        private Label label2;
    }
}