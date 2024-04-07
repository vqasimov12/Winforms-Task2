using System.Text.Json;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Anket";
            male.Select();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach (var ch in phone.Text)
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Phone is not in correct form", "Error", MessageBoxButtons.OK);
                    check = false;
                    break;
                }

            if (username.Text == default && name.Text == default && surname.Text == default && father.Text == default&& country.Text == default && city.Text == default && phone.Text == default 
                && birthday.Text == default)
            {
                MessageBox.Show("Enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (check)
            {
                User u = new User();
                u.name = name.Text;
                u.username = username.Text;
                u.surname = surname.Text;
                u.father = father.Text;
                u.country = country.Text;
                u.city = city.Text;
                u.phone = phone.Text;
                u.birthday = birthday.Value;
                u.gender = (male.Checked) ? "Male" : "Female";
                string json = JsonSerializer.Serialize(u);
                File.WriteAllText($"{u.username}.json", json);
                name.Text = "";
                surname.Text = "";
                father.Text = "";
                country.Text = "";
                phone.Text = "";
                city.Text = "";
                username.Text = "";
                male.Select();
                birthday.Value = DateTime.Now;
                MessageBox.Show("User saved", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Load_Click(object sender, EventArgs e)
        {
            if (!File.Exists($"{search.Text}.json"))
                MessageBox.Show("Username can not be found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                string fileName = $"{search.Text}.json";
                string json = File.ReadAllText(fileName);
                User user = JsonSerializer.Deserialize<User>(json)!;
                name.Text = user.name;
                surname.Text = user.surname;
                father.Text = user.father;
                country.Text = user.country;
                phone.Text = user.phone;
                city.Text = user.city;
                username.Text = user.username;
                birthday.Value = user.birthday;
                if (user.gender == "male") male.Select();
                else female.Select();
            }
            search.Text = "";
        }
    }
}