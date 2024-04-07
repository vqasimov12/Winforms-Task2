namespace Task2
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
            search = new TextBox();
            name = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            surname = new TextBox();
            panel4 = new Panel();
            father = new TextBox();
            panel5 = new Panel();
            phone = new TextBox();
            panel6 = new Panel();
            city = new TextBox();
            panel7 = new Panel();
            country = new TextBox();
            panel8 = new Panel();
            birthday = new DateTimePicker();
            male = new RadioButton();
            female = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            username = new TextBox();
            panel9 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // search
            // 
            search.BorderStyle = BorderStyle.None;
            search.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            search.Location = new Point(86, 21);
            search.Name = "search";
            search.Size = new Size(218, 23);
            search.TabIndex = 0;
            // 
            // name
            // 
            name.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(167, 173);
            name.Name = "name";
            name.Size = new Size(218, 30);
            name.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(search);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(7, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 72);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(362, 14);
            button2.Name = "button2";
            button2.Size = new Size(117, 35);
            button2.TabIndex = 24;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Load_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Location = new Point(86, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 10);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Brown;
            panel3.Location = new Point(167, 196);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 10);
            panel3.TabIndex = 2;
            // 
            // surname
            // 
            surname.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            surname.Location = new Point(167, 215);
            surname.Name = "surname";
            surname.Size = new Size(218, 30);
            surname.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Brown;
            panel4.Location = new Point(167, 238);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 10);
            panel4.TabIndex = 4;
            // 
            // father
            // 
            father.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            father.Location = new Point(167, 263);
            father.Name = "father";
            father.Size = new Size(218, 30);
            father.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Brown;
            panel5.Location = new Point(167, 286);
            panel5.Name = "panel5";
            panel5.Size = new Size(218, 10);
            panel5.TabIndex = 6;
            // 
            // phone
            // 
            phone.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phone.Location = new Point(167, 418);
            phone.Name = "phone";
            phone.Size = new Size(218, 30);
            phone.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Brown;
            panel6.Location = new Point(167, 441);
            panel6.Name = "panel6";
            panel6.Size = new Size(218, 10);
            panel6.TabIndex = 12;
            // 
            // city
            // 
            city.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            city.Location = new Point(167, 370);
            city.Name = "city";
            city.Size = new Size(218, 30);
            city.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Brown;
            panel7.Location = new Point(167, 393);
            panel7.Name = "panel7";
            panel7.Size = new Size(218, 10);
            panel7.TabIndex = 10;
            // 
            // country
            // 
            country.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            country.Location = new Point(167, 328);
            country.Name = "country";
            country.Size = new Size(218, 30);
            country.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Brown;
            panel8.Location = new Point(167, 351);
            panel8.Name = "panel8";
            panel8.Size = new Size(218, 10);
            panel8.TabIndex = 8;
            // 
            // birthday
            // 
            birthday.Location = new Point(167, 497);
            birthday.Name = "birthday";
            birthday.Size = new Size(218, 27);
            birthday.TabIndex = 0;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(183, 546);
            male.Name = "male";
            male.Size = new Size(63, 24);
            male.TabIndex = 13;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(265, 546);
            female.Name = "female";
            female.Size = new Size(78, 24);
            female.TabIndex = 14;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 176);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 222);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 16;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 273);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 17;
            label3.Text = "Father Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(38, 328);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 18;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(38, 377);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 19;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(38, 425);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 20;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(38, 501);
            label7.Name = "label7";
            label7.Size = new Size(87, 23);
            label7.TabIndex = 21;
            label7.Text = "BirthDay";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(38, 546);
            label8.Name = "label8";
            label8.Size = new Size(74, 23);
            label8.TabIndex = 22;
            label8.Text = "Gender";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(370, 587);
            button1.Name = "button1";
            button1.Size = new Size(117, 35);
            button1.TabIndex = 23;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Save_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(38, 137);
            label9.Name = "label9";
            label9.Size = new Size(95, 23);
            label9.TabIndex = 26;
            label9.Text = "Username";
            // 
            // username
            // 
            username.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            username.Location = new Point(167, 134);
            username.Name = "username";
            username.Size = new Size(218, 30);
            username.TabIndex = 24;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Brown;
            panel9.Location = new Point(167, 157);
            panel9.Name = "panel9";
            panel9.Size = new Size(218, 10);
            panel9.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 638);
            Controls.Add(label9);
            Controls.Add(username);
            Controls.Add(panel9);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(birthday);
            Controls.Add(phone);
            Controls.Add(panel6);
            Controls.Add(city);
            Controls.Add(panel7);
            Controls.Add(country);
            Controls.Add(panel8);
            Controls.Add(father);
            Controls.Add(panel5);
            Controls.Add(surname);
            Controls.Add(panel4);
            Controls.Add(name);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox search;
        private TextBox name;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox surname;
        private Panel panel4;
        private TextBox father;
        private Panel panel5;
        private TextBox phone;
        private Panel panel6;
        private TextBox city;
        private Panel panel7;
        private TextBox country;
        private Panel panel8;
        private DateTimePicker birthday;
        private RadioButton male;
        private RadioButton female;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private Button button1;
        private Label label9;
        private TextBox username;
        private Panel panel9;
    }
}