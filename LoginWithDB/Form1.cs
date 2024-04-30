using MySql.Data.MySqlClient;

namespace LoginWithDB
{
    public partial class Form1 : Form
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;database=csharploginform;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader dr;
        string user, password;
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {

            user = user_txt.Text;
            password = password_txt.Text;
            AppForm appform = new AppForm();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Error! User or password is empty");
                return;
            }

            connection.Open();
            string selectQuery = "SELECT * FROM users WHERE Username = @Username AND Password = @Password";
            command = new MySqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@Username", user);
            command.Parameters.AddWithValue("@Password", password);
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Geconnect geslaagd!");
                this.Hide();
                appform.Show();
            }
        else
            {     
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
