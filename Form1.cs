using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using HOTEL_SYSTEM5;
using MySql.Data.MySqlClient; // Use MySQL library

namespace HotelReservationSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Connection string for MySQL (XAMPP)
            string connectionString = "Server=localhost;Database=hotelreservationsystem;User Id=root;Password=;";

            try
            {
                // Open a connection to the MySQL database
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to check if the user exists and if they are an admin
                    string query = "SELECT IsAdmin FROM Users WHERE Username = @Username AND Password = @Password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Execute the query
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        bool isAdmin = reader.GetBoolean(0);

                        // Redirect to the appropriate form based on user role
                        if (isAdmin)
                        {
                            AdminPanelForm adminForm = new AdminPanelForm();
                            adminForm.Show();
                        }
                        else
                        {
                            HotelReservationForm reservationForm = new HotelReservationForm();
                            reservationForm.Show();
                        }

                        // Hide the login form
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL database-related errors
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Open the sign-up form
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}