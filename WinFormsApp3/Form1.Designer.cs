namespace WinFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            result = new Label();
            panel2 = new Panel();
            seven = new Button();
            four = new Button();
            zero = new Button();
            one = new Button();
            dot = new Button();
            two = new Button();
            five = new Button();
            nine = new Button();
            six = new Button();
            three = new Button();
            equal = new Button();
            button16 = new Button();
            button12 = new Button();
            button8 = new Button();
            eight = new Button();
            root = new Button();
            sqr = new Button();
            mult = new Button();
            clean = new Button();
            delete = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(result);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 132);
            panel1.TabIndex = 0;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            result.ForeColor = SystemColors.ButtonHighlight;
            result.Location = new Point(265, 105);
            result.Name = "result";
            result.Size = new Size(0, 20);
            result.TabIndex = 0;
            result.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(seven);
            panel2.Controls.Add(four);
            panel2.Controls.Add(zero);
            panel2.Controls.Add(one);
            panel2.Controls.Add(dot);
            panel2.Controls.Add(two);
            panel2.Controls.Add(five);
            panel2.Controls.Add(nine);
            panel2.Controls.Add(six);
            panel2.Controls.Add(three);
            panel2.Controls.Add(equal);
            panel2.Controls.Add(button16);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(eight);
            panel2.Controls.Add(root);
            panel2.Controls.Add(sqr);
            panel2.Controls.Add(mult);
            panel2.Controls.Add(clean);
            panel2.Controls.Add(delete);
            panel2.Location = new Point(1, 131);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 388);
            panel2.TabIndex = 1;
            // 
            // seven
            // 
            seven.BackColor = SystemColors.ControlDarkDark;
            seven.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            seven.ForeColor = SystemColors.ControlLightLight;
            seven.ImageAlign = ContentAlignment.BottomLeft;
            seven.Location = new Point(3, 84);
            seven.Margin = new Padding(3, 4, 3, 4);
            seven.Name = "seven";
            seven.Size = new Size(75, 69);
            seven.TabIndex = 35;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += seven_Click;
            // 
            // four
            // 
            four.BackColor = SystemColors.ControlDarkDark;
            four.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            four.ForeColor = SystemColors.ControlLightLight;
            four.ImageAlign = ContentAlignment.BottomLeft;
            four.Location = new Point(3, 161);
            four.Margin = new Padding(3, 4, 3, 4);
            four.Name = "four";
            four.Size = new Size(75, 69);
            four.TabIndex = 34;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += four_Click;
            // 
            // zero
            // 
            zero.BackColor = SystemColors.ControlDarkDark;
            zero.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            zero.ForeColor = SystemColors.ControlLightLight;
            zero.ImageAlign = ContentAlignment.BottomLeft;
            zero.Location = new Point(3, 312);
            zero.Margin = new Padding(3, 4, 3, 4);
            zero.Name = "zero";
            zero.Size = new Size(75, 69);
            zero.TabIndex = 33;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += zero_Click;
            // 
            // one
            // 
            one.BackColor = SystemColors.ControlDarkDark;
            one.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            one.ForeColor = SystemColors.ControlLightLight;
            one.ImageAlign = ContentAlignment.BottomLeft;
            one.Location = new Point(2, 235);
            one.Margin = new Padding(3, 4, 3, 4);
            one.Name = "one";
            one.Size = new Size(75, 69);
            one.TabIndex = 32;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += one_Click;
            // 
            // dot
            // 
            dot.BackColor = SystemColors.ControlDarkDark;
            dot.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dot.ForeColor = SystemColors.ControlLightLight;
            dot.ImageAlign = ContentAlignment.BottomLeft;
            dot.Location = new Point(85, 313);
            dot.Margin = new Padding(3, 4, 3, 4);
            dot.Name = "dot";
            dot.Size = new Size(75, 68);
            dot.TabIndex = 31;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += dot_Click;
            // 
            // two
            // 
            two.BackColor = SystemColors.ControlDarkDark;
            two.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            two.ForeColor = SystemColors.ControlLightLight;
            two.ImageAlign = ContentAlignment.BottomLeft;
            two.Location = new Point(85, 235);
            two.Margin = new Padding(3, 4, 3, 4);
            two.Name = "two";
            two.Size = new Size(75, 70);
            two.TabIndex = 30;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += two_Click;
            // 
            // five
            // 
            five.BackColor = SystemColors.ControlDarkDark;
            five.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            five.ForeColor = SystemColors.ControlLightLight;
            five.ImageAlign = ContentAlignment.BottomLeft;
            five.Location = new Point(85, 161);
            five.Margin = new Padding(3, 4, 3, 4);
            five.Name = "five";
            five.Size = new Size(75, 69);
            five.TabIndex = 29;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += five_Click;
            // 
            // nine
            // 
            nine.BackColor = SystemColors.ControlDarkDark;
            nine.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            nine.ForeColor = SystemColors.ControlLightLight;
            nine.Location = new Point(167, 84);
            nine.Margin = new Padding(3, 4, 3, 4);
            nine.Name = "nine";
            nine.Size = new Size(75, 69);
            nine.TabIndex = 28;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += nine_Click;
            // 
            // six
            // 
            six.BackColor = SystemColors.ControlDarkDark;
            six.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            six.ForeColor = SystemColors.ControlLightLight;
            six.ImageAlign = ContentAlignment.BottomLeft;
            six.Location = new Point(167, 160);
            six.Margin = new Padding(3, 4, 3, 4);
            six.Name = "six";
            six.Size = new Size(75, 69);
            six.TabIndex = 25;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += six_Click;
            // 
            // three
            // 
            three.BackColor = SystemColors.ControlDarkDark;
            three.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            three.ForeColor = SystemColors.ControlLightLight;
            three.ImageAlign = ContentAlignment.BottomLeft;
            three.Location = new Point(167, 235);
            three.Margin = new Padding(3, 4, 3, 4);
            three.Name = "three";
            three.Size = new Size(75, 69);
            three.TabIndex = 26;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += three_Click;
            // 
            // equal
            // 
            equal.BackColor = SystemColors.ControlDarkDark;
            equal.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            equal.ForeColor = SystemColors.ControlLightLight;
            equal.ImageAlign = ContentAlignment.BottomLeft;
            equal.Location = new Point(167, 312);
            equal.Margin = new Padding(3, 4, 3, 4);
            equal.Name = "equal";
            equal.Size = new Size(75, 69);
            equal.TabIndex = 27;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.DarkOrange;
            button16.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(246, 313);
            button16.Margin = new Padding(3, 4, 3, 4);
            button16.Name = "button16";
            button16.Size = new Size(75, 68);
            button16.TabIndex = 27;
            button16.Text = "-";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.DarkOrange;
            button12.Font = new Font("Microsoft Sans Serif", 14.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(246, 235);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(75, 70);
            button12.TabIndex = 26;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkOrange;
            button8.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(248, 161);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(75, 69);
            button8.TabIndex = 25;
            button8.Text = "/";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // eight
            // 
            eight.BackColor = SystemColors.ControlDarkDark;
            eight.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            eight.ForeColor = SystemColors.ControlLightLight;
            eight.ImageAlign = ContentAlignment.BottomLeft;
            eight.Location = new Point(85, 84);
            eight.Margin = new Padding(3, 4, 3, 4);
            eight.Name = "eight";
            eight.Size = new Size(75, 69);
            eight.TabIndex = 24;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += eight_Click;
            // 
            // root
            // 
            root.BackColor = Color.Gray;
            root.BackgroundImage = (Image)resources.GetObject("root.BackgroundImage");
            root.BackgroundImageLayout = ImageLayout.Stretch;
            root.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            root.ForeColor = SystemColors.ControlLightLight;
            root.ImageAlign = ContentAlignment.BottomLeft;
            root.Location = new Point(167, 4);
            root.Margin = new Padding(3, 4, 3, 4);
            root.Name = "root";
            root.Size = new Size(75, 69);
            root.TabIndex = 23;
            root.UseVisualStyleBackColor = false;
            root.Click += root_Click;
            // 
            // sqr
            // 
            sqr.BackColor = Color.Gray;
            sqr.BackgroundImage = (Image)resources.GetObject("sqr.BackgroundImage");
            sqr.BackgroundImageLayout = ImageLayout.Zoom;
            sqr.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            sqr.ForeColor = SystemColors.ControlLightLight;
            sqr.ImageAlign = ContentAlignment.BottomLeft;
            sqr.Location = new Point(85, 4);
            sqr.Margin = new Padding(3, 4, 3, 4);
            sqr.Name = "sqr";
            sqr.Size = new Size(75, 69);
            sqr.TabIndex = 22;
            sqr.UseVisualStyleBackColor = false;
            sqr.Click += sqr_Click;
            // 
            // mult
            // 
            mult.BackColor = Color.DarkOrange;
            mult.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            mult.Location = new Point(246, 84);
            mult.Margin = new Padding(3, 4, 3, 4);
            mult.Name = "mult";
            mult.Size = new Size(75, 69);
            mult.TabIndex = 4;
            mult.Text = "*";
            mult.UseVisualStyleBackColor = false;
            mult.Click += mult_Click;
            // 
            // clean
            // 
            clean.BackColor = Color.WhiteSmoke;
            clean.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            clean.ForeColor = SystemColors.WindowFrame;
            clean.Location = new Point(3, 4);
            clean.Margin = new Padding(3, 4, 3, 4);
            clean.Name = "clean";
            clean.Size = new Size(75, 69);
            clean.TabIndex = 3;
            clean.Text = "C";
            clean.UseVisualStyleBackColor = false;
            clean.Click += clean_Click;
            // 
            // delete
            // 
            delete.BackgroundImage = (Image)resources.GetObject("delete.BackgroundImage");
            delete.BackgroundImageLayout = ImageLayout.Zoom;
            delete.Location = new Point(246, 4);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(75, 69);
            delete.TabIndex = 0;
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 516);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label result;
        private Button mult;
        private Button clean;
        private Button delete;
        private Button eight;
        private Button root;
        private Button sqr;
        private Button equal;
        private Button button16;
        private Button button12;
        private Button button8;
        private Button six;
        private Button three;
        private Button seven;
        private Button four;
        private Button zero;
        private Button one;
        private Button dot;
        private Button two;
        private Button five;
        private Button nine;
    }
}