using Microsoft.VisualBasic.ApplicationServices;
using panel_foroshgah.Models;
using panel_foroshgah.Utilitis;

namespace panel_foroshgah
{
    public partial class Form1 : Form
    {

        List<Member> members;

        public Form1()
        {
            members = new List<Member>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void login(object sender, EventArgs e)
        {

            string username = UsernametextBox.Text;
            string Password = PasswordtextBox.Text;
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("please enter valid input");
                return;
            }
            if (username == "Raika" && Password == "1234")
            {
                MessageBox.Show("login successfully");
            }
            else
            {
                MessageBox.Show("Username or pasword is invalid");
            }

        }

        private void UsernametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumbertextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNametextBox.Text) ||
                 string.IsNullOrEmpty(LastNametextBox.Text) ||
                  string.IsNullOrEmpty(PhoneNumbertextBox.Text) ||
                  string.IsNullOrEmpty(PhoneNumbertextBox.Text)) {
                MessageBox.Show("please enter valid inputs");
                return;
            }

            string phoneNumber = CleanData.PhoneNumber(PhoneNumbertextBox.Text);
            

            Member member = new(firstname: FirstNametextBox.Text, lastname: LastNametextBox.Text, phonenumber: phoneNumber, nationalcode: NationalCodetextBox.Text);
            members.Add(member);


            MessageBox.Show("Register Successfuly");


            FirstNametextBox.Text = string.Empty;
            LastNametextBox.Text = string.Empty;
            PhoneNumbertextBox.Text = string.Empty;
            NationalCodetextBox.Text = string.Empty;
        }

        
        public string CleanNationalCode(string nationalCode)
        {
            return nationalCode;

        }
    }

}
