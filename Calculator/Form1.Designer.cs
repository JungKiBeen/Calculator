namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.num_screen = new System.Windows.Forms.TextBox();
            this.exp_screen = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.decipoint = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.equalbtn = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // num_screen
            // 
            this.num_screen.Cursor = System.Windows.Forms.Cursors.Default;
            this.num_screen.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num_screen.Location = new System.Drawing.Point(12, 182);
            this.num_screen.Name = "num_screen";
            this.num_screen.ReadOnly = true;
            this.num_screen.Size = new System.Drawing.Size(307, 35);
            this.num_screen.TabIndex = 0;
            this.num_screen.Text = "0";
            this.num_screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // exp_screen
            // 
            this.exp_screen.Cursor = System.Windows.Forms.Cursors.Default;
            this.exp_screen.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exp_screen.Location = new System.Drawing.Point(12, 141);
            this.exp_screen.Name = "exp_screen";
            this.exp_screen.ReadOnly = true;
            this.exp_screen.Size = new System.Drawing.Size(307, 35);
            this.exp_screen.TabIndex = 0;
            this.exp_screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seven
            // 
            this.seven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seven.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.seven.Location = new System.Drawing.Point(12, 238);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(56, 42);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.NumClick);
            // 
            // eight
            // 
            this.eight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eight.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.eight.Location = new System.Drawing.Point(74, 238);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(56, 42);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.NumClick);
            // 
            // nine
            // 
            this.nine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nine.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nine.Location = new System.Drawing.Point(136, 238);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(56, 42);
            this.nine.TabIndex = 1;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.NumClick);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(260, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 42);
            this.button5.TabIndex = 1;
            this.button5.Text = "C";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ClearClick);
            // 
            // four
            // 
            this.four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.four.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.four.Location = new System.Drawing.Point(12, 286);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(56, 42);
            this.four.TabIndex = 1;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.NumClick);
            // 
            // five
            // 
            this.five.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.five.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.five.Location = new System.Drawing.Point(74, 286);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(56, 42);
            this.five.TabIndex = 1;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.NumClick);
            // 
            // six
            // 
            this.six.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.six.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.six.Location = new System.Drawing.Point(136, 286);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(56, 42);
            this.six.TabIndex = 1;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.NumClick);
            // 
            // one
            // 
            this.one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.one.Location = new System.Drawing.Point(12, 334);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(56, 42);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.NumClick);
            // 
            // two
            // 
            this.two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.two.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.two.Location = new System.Drawing.Point(74, 334);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(56, 42);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.NumClick);
            // 
            // three
            // 
            this.three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.three.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.three.Location = new System.Drawing.Point(136, 334);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(56, 42);
            this.three.TabIndex = 1;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.NumClick);
            // 
            // zero
            // 
            this.zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zero.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.zero.Location = new System.Drawing.Point(12, 382);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(118, 42);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.NumClick);
            // 
            // decipoint
            // 
            this.decipoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.decipoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decipoint.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.decipoint.Location = new System.Drawing.Point(136, 382);
            this.decipoint.Name = "decipoint";
            this.decipoint.Size = new System.Drawing.Size(56, 42);
            this.decipoint.TabIndex = 1;
            this.decipoint.Text = ".";
            this.decipoint.UseVisualStyleBackColor = true;
            this.decipoint.Click += new System.EventHandler(this.DeciPointClick);
            // 
            // add
            // 
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.add.Location = new System.Drawing.Point(198, 382);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(56, 42);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.OptClick);
            // 
            // equalbtn
            // 
            this.equalbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.equalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equalbtn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.equalbtn.Location = new System.Drawing.Point(260, 334);
            this.equalbtn.Name = "equalbtn";
            this.equalbtn.Size = new System.Drawing.Size(56, 90);
            this.equalbtn.TabIndex = 1;
            this.equalbtn.Text = "=";
            this.equalbtn.UseVisualStyleBackColor = true;
            this.equalbtn.Click += new System.EventHandler(this.OptClick);
            // 
            // sub
            // 
            this.sub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sub.Location = new System.Drawing.Point(198, 334);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(56, 42);
            this.sub.TabIndex = 1;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.OptClick);
            // 
            // mul
            // 
            this.mul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mul.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mul.Location = new System.Drawing.Point(198, 286);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(56, 42);
            this.mul.TabIndex = 1;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.OptClick);
            // 
            // div
            // 
            this.div.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.div.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.div.Location = new System.Drawing.Point(198, 238);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(56, 42);
            this.div.TabIndex = 1;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.OptClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(331, 456);
            this.Controls.Add(this.equalbtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.decipoint);
            this.Controls.Add(this.three);
            this.Controls.Add(this.six);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.two);
            this.Controls.Add(this.five);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.exp_screen);
            this.Controls.Add(this.num_screen);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num_screen;
        private System.Windows.Forms.TextBox exp_screen;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button decipoint;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button equalbtn;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

