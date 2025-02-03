using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelReservationSystem
{
    public partial class AdminPanelForm : Form
    {
        private string connectionString = "Server=localhost;Database=hotelreservationsystem;User Id=root;Password=;";

        public AdminPanelForm()
        {
            InitializeComponent();
        }

        // Event handler for the "Manage Rooms" button
        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the ManageRoomsForm
                ManageRoomsForm manageRoomsForm = new ManageRoomsForm();
                manageRoomsForm.Show(); // Show the ManageRoomsForm
                this.Hide(); // Hide the current form (AdminPanelForm)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Manage Rooms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the "View Reservations" button
        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to fetch all reservations
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

                    // Display the reservations in a DataGridView
                    DataGridView dataGridViewReservations = new DataGridView
                    {
                        DataSource = dt,
                        Dock = DockStyle.Fill,
                        ReadOnly = true
                    };

                    // Create a new form to display the reservations
                    Form reservationsForm = new Form
                    {
                        Text = "View Reservations",
                        Size = new System.Drawing.Size(800, 400)
                    };

                    reservationsForm.Controls.Add(dataGridViewReservations);
                    reservationsForm.ShowDialog(); // Show the form as a dialog
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while loading reservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the "Moderate Feedback" button
        private void btnModerateFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the ModerateFeedbackForm
                ModerateFeedbackForm moderateFeedbackForm = new ModerateFeedbackForm();
                moderateFeedbackForm.Show(); // Show the ModerateFeedbackForm
                this.Hide(); // Hide the current form (AdminPanelForm)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Moderate Feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}