using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelReservationSystem
{
    public partial class ModerateFeedbackForm : Form
    {
        private string connectionString = "Server=localhost;Database=hotelreservationsystem;User Id=root;Password=;";

        public ModerateFeedbackForm()
        {
            InitializeComponent();
            LoadFeedback();
        }

        // Load feedback from the database and display it in the DataGridView
        private void LoadFeedback()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT FeedbackID, UserID, Rating, Review FROM Feedback ORDER BY FeedbackID DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridViewFeedback.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while loading feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the "Delete Feedback" button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewFeedback.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a feedback entry to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the FeedbackID of the selected row
            int feedbackID = Convert.ToInt32(dataGridViewFeedback.SelectedRows[0].Cells["FeedbackID"].Value);

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this feedback?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Feedback WHERE FeedbackID = @FeedbackID";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Feedback deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadFeedback(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occurred while deleting feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}