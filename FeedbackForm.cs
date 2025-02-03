using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelReservationSystem
{
    public partial class FeedbackForm : Form
    {
        private string connectionString = "Server=localhost;Database=hotelreservationsystem;User Id=root;Password=;";
        private int userID;
        private int roomID;

        public FeedbackForm(int userID, int roomID)
        {
            InitializeComponent();
            this.userID = userID;
            this.roomID = roomID;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate rating
            if (!int.TryParse(txtRating.Text, out int rating) || rating < 1 || rating > 5)
            {
                MessageBox.Show("Please enter a valid rating between 1 and 5", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate review
            if (string.IsNullOrWhiteSpace(txtReview.Text))
            {
                MessageBox.Show("Please enter a review", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Feedback (UserID, Rating, Review)
                                   VALUES (@UserID, @Rating, @Review)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Rating", rating);
                    cmd.Parameters.AddWithValue("@Review", txtReview.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thank you for your feedback!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Return to Hotel Reservation Form
            HotelReservationForm hotelForm = new HotelReservationForm();
            hotelForm.Show();
            this.Close();
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }
    }
}