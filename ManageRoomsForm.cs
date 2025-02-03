using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelReservationSystem
{
    public partial class ManageRoomsForm : Form
    {
        private string connectionString = "Server=localhost;Database=hotelreservationsystem;User Id=root;Password=;";

        public ManageRoomsForm()
        {
            InitializeComponent();
            LoadRooms();
        }

        // Load rooms from the database and display them in the DataGridView
        private void LoadRooms()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT RoomID, RoomType, Amenities, Price FROM Rooms";
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

        // Add a new room to the database
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomType = cmbRoomType.Text;
            string amenities = txtAmenities.Text;
            decimal price;

            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Rooms (RoomType, Amenities, Price) VALUES (@RoomType, @Amenities, @Price)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RoomType", roomType);
                    cmd.Parameters.AddWithValue("@Amenities", amenities);
                    cmd.Parameters.AddWithValue("@Price", price);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRooms(); // Refresh the room list
                    }
                    else
                    {
                        MessageBox.Show("Failed to add room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while adding the room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete a room from the database
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int roomID = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells["RoomID"].Value);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Rooms WHERE RoomID = @RoomID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RoomID", roomID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Room deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRooms(); // Refresh the room list
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while deleting the room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}