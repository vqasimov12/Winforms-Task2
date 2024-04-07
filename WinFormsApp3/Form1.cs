namespace WinFormsApp3;
public partial class Form1 : Form
{

    string num1 = "";
    string num2 = "";
    char op = ' ';
    double a;
    double b;
    bool square = false;
    bool sqr_root = false;
    bool cl = false;
    public Form1()
    {
        InitializeComponent();
        result.Text = "";
    }

    private void zero_Click(object sender, EventArgs e)
    {
        if (op == ' ')
            num1 += "0";
        else num2 += "0";
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void clean_Click(object sender, EventArgs e)
    {
        num2 = "";
        num1 = "";
        op = ' ';
        result.Text = "";
        square = false;
        sqr_root = false;
    }

    private void seven_Click(object sender, EventArgs e)
    {
        if (op == ' ')
            num1 += "7";
        else num2 += "7";
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void eight_Click(object sender, EventArgs e)
    {

        if (op == ' ')
            num1 += "8";
        else num2 += "8";
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void nine_Click(object sender, EventArgs e)
    {

        if (op == ' ')
            num1 += "9";
        else num2 += "9";
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void four_Click(object sender, EventArgs e)
    {

        if (op == ' ')
            num1 += "4";
        else num2 += "4";
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void five_Click(object sender, EventArgs e)
    {

        if (op == ' ')
            num1 += "5";
        else num2 += "5";
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void six_Click(object sender, EventArgs e)
    {

        if (op == ' ')
            num1 += "6";
        else num2 += "6";
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void one_Click(object sender, EventArgs e)
    {

        if (op == ' ')
            num1 += "1";
        else num2 += "1";
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void two_Click(object sender, EventArgs e)
    {

        if (op == ' ')
            num1 += "2";
        else num2 += "2";
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void three_Click(object sender, EventArgs e)
    {

        if (op == ' ')
            num1 += "3";
        else num2 += "3";
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void dot_Click(object sender, EventArgs e)
    {

        if (op == ' ')
            num1 += ".";
        else num2 += ".";
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void equal_Click(object sender, EventArgs e)
    {
        cl = true;
        if (num2 == "")
            MessageBox.Show("Operation is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
            try
            {
                a = Convert.ToDouble(num1);
            }
            catch { }
            b = Convert.ToDouble(num2);
            if (sqr_root)
                result.Text = Math.Round(b * b, 4).ToString();
            else if (square)
                result.Text = Math.Round(Math.Sqrt(b), 4).ToString();

            else
                switch (op)
                {
                    case '/':
                        result.Text = Math.Round(a / b, 4).ToString();
                        break;
                    case '*':
                        result.Text = Math.Round(a * b, 4).ToString();
                        break;
                    case '+':
                        result.Text = Math.Round(a + b, 4).ToString();
                        break;
                    case '-':
                        result.Text = Math.Round(a - b, 4).ToString();
                        break;
                }
            num2 = "";
            num1 = "";
            op = ' ';
            square = false;
            sqr_root = false;
        }
    }

    private void button16_Click(object sender, EventArgs e)
    {
        op = '-';
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void button12_Click(object sender, EventArgs e)
    {
        op = '+';
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void button8_Click(object sender, EventArgs e)
    {
        op = '/';
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void mult_Click(object sender, EventArgs e)
    {
        op = '*';
        result.Text = square ? $"({num2}^(1/2)) " : sqr_root ? $"({num2}^(2))" : num1 + op + num2;
    }

    private void delete_Click(object sender, EventArgs e)
    {
        if (cl)
            result.Text = "";
        else
            try
            {
                if (op == ' ')
                    num1 = num1.Substring(0, num1.Length - 1);
                else
                    num2 = num2.Substring(0, num2.Length - 1);
                result.Text = num1 + op + num2;
            }
            catch
            {

            }
    }

    private void root_Click(object sender, EventArgs e)
    {
        num1 = " ";
        op = '\0';
        sqr_root = true;
        square = false;
    }

    private void sqr_Click(object sender, EventArgs e)
    {
        num1 = " ";
        op = '\0';
        square = true;
        sqr_root = false;
    }
}