using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelReservationSystem
{
    public partial class HotelReservationForm : Form
    {
        private string connectionString = "Server=localhost;Database=hotelreservationsystem;User Id=root;Password=;";

        public HotelReservationForm()
        {
            InitializeComponent();
            LoadRooms();
        }

        // Load available rooms into the DataGridView
        private void LoadRooms()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT RoomID, RoomType, Amenities, Price FROM Rooms WHERE IsAvailable = 1";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewRooms.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while loading rooms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Open the Reservation Form
        private void btnReservation_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show();
            this.Hide();
        }

        // View Reservations
        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            Reservations.ReservationID,
                            Users.Username AS CustomerName,
                            Rooms.RoomType,
                            Reservations.CheckInDate,
                            Reservations.CheckOutDate,
                            Reservations.TotalPrice
                        FROM Reservations
                        INNER JOIN Users ON Reservations.UserID = Users.UserID
                        INNER JOIN Rooms ON Reservations.RoomID = Rooms.RoomID";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewRooms.DataSource = dt;

                    if (!dataGridViewRooms.Columns.Contains("CancelReservation"))
                    {
                        DataGridViewButtonColumn cancelButtonColumn = new DataGridViewButtonColumn
                        {
                            HeaderText = "Action",
                            Text = "Cancel Reservation",
                            UseColumnTextForButtonValue = true,
                            Name = "CancelReservation"
                        };
                        dataGridViewRooms.Columns.Add(cancelButtonColumn);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while loading reservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel Reservation
        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewRooms.Columns["CancelReservation"].Index && e.RowIndex >= 0)
            {
                int reservationID = Convert.ToInt32(dataGridViewRooms.Rows[e.RowIndex].Cells["ReservationID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM Reservations WHERE ReservationID = @ReservationID";
                            MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                            deleteCmd.Parameters.AddWithValue("@ReservationID", reservationID);

                            int rowsDeleted = deleteCmd.ExecuteNonQuery();

                            if (rowsDeleted > 0)
                            {
                                MessageBox.Show("Reservation canceled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnViewReservations_Click(null, null);
                            }
                            else
                            {
                                MessageBox.Show("Failed to cancel the reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("An error occurred while canceling the reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // In HotelReservationForm.cs
        private void btnFeedback_Click(object sender, EventArgs e)
        {
            int currentUserID = 1; // Get from your authentication system
            int selectedRoomID = 1; // Get from your room selection

            FeedbackForm feedbackForm = new FeedbackForm(currentUserID, selectedRoomID);
            feedbackForm.Show();
            this.Hide();
        }
    }
}
