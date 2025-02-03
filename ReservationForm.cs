using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelReservationSystem
{
    public partial class ReservationForm : Form
    {
        private string connectionString = "Server=localhost;Database=hotelreservationsystem;User Id=root;Password=;";

        public ReservationForm()
        {
            InitializeComponent();
            LoadRooms();
        }

        // Load available rooms into the ComboBox
        private void LoadRooms()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT RoomID, RoomType FROM Rooms WHERE IsAvailable = 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbRooms.Items.Add($"{reader["RoomID"]} - {reader["RoomType"]}");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while loading rooms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the "Submit" button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbRooms.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedRoom = cmbRooms.SelectedItem.ToString();
            int roomID = int.Parse(selectedRoom.Split('-')[0].Trim());

            // Get the check-in and check-out dates from the form
            DateTime checkInDate = dtpCheckIn.Value;
            DateTime checkOutDate = dtpCheckOut.Value;

            // Validate the dates
            if (checkInDate >= checkOutDate)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate the total price
            decimal totalPrice = CalculateTotalPrice(roomID, checkInDate, checkOutDate);

            // Display the total price
            lblTotalPrice.Text = $"Total Price: Rs. {totalPrice:N2}";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert the reservation into the Reservations table
                    string insertQuery = @"
                        INSERT INTO Reservations (UserID, RoomID, CheckInDate, CheckOutDate, TotalPrice)
                        VALUES (@UserID, @RoomID, @CheckInDate, @CheckOutDate, @TotalPrice)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@UserID", 1); // Replace with the actual UserID (e.g., from login)
                    insertCmd.Parameters.AddWithValue("@RoomID", roomID);
                    insertCmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                    insertCmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                    insertCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                    int rowsInserted = insertCmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        // Update the room's availability
                        string updateQuery = "UPDATE Rooms SET IsAvailable = 0 WHERE RoomID = @RoomID";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@RoomID", roomID);

                        int rowsUpdated = updateCmd.ExecuteNonQuery();

                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("Room booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the ReservationForm
                        }
                        else
                        {
                            MessageBox.Show("Failed to update room availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to book the room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while booking the room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Calculate the total price based on the room price and duration of stay
        private decimal CalculateTotalPrice(int roomID, DateTime checkInDate, DateTime checkOutDate)
        {
            decimal totalPrice = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Price FROM Rooms WHERE RoomID = @RoomID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RoomID", roomID);

                    decimal roomPrice = Convert.ToDecimal(cmd.ExecuteScalar());

                    // Calculate the number of nights
                    TimeSpan duration = checkOutDate - checkInDate;
                    int numberOfNights = duration.Days;

                    // Calculate the total price
                    totalPrice = roomPrice * numberOfNights;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while calculating the price: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalPrice;
        }

        // Event handler for the "Back" button
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to the HotelReservationForm
            HotelReservationForm hotelReservationForm = new HotelReservationForm();
            hotelReservationForm.Show();
            this.Close(); // Close the current form
        }
    }
}