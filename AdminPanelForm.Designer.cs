using System.Windows.Forms;

namespace HotelReservationSystem
{
    partial class AdminPanelForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnManageRooms;
        private Button btnViewReservations;
        private Button btnModerateFeedback;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.btnManageRooms = new System.Windows.Forms.Button();
            this.btnViewReservations = new System.Windows.Forms.Button();
            this.btnModerateFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.Location = new System.Drawing.Point(365, 120);
            this.btnManageRooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Size = new System.Drawing.Size(200, 49);
            this.btnManageRooms.TabIndex = 0;
            this.btnManageRooms.Text = "Manage Rooms";
            this.btnManageRooms.UseVisualStyleBackColor = true;
            this.btnManageRooms.Click += new System.EventHandler(this.btnManageRooms_Click);
            // 
            // btnViewReservations
            // 
            this.btnViewReservations.Location = new System.Drawing.Point(365, 193);
            this.btnViewReservations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewReservations.Name = "btnViewReservations";
            this.btnViewReservations.Size = new System.Drawing.Size(200, 49);
            this.btnViewReservations.TabIndex = 1;
            this.btnViewReservations.Text = "View Reservations";
            this.btnViewReservations.UseVisualStyleBackColor = true;
            this.btnViewReservations.Click += new System.EventHandler(this.btnViewReservations_Click);
            // 
            // btnModerateFeedback
            // 
            this.btnModerateFeedback.Location = new System.Drawing.Point(365, 267);
            this.btnModerateFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModerateFeedback.Name = "btnModerateFeedback";
            this.btnModerateFeedback.Size = new System.Drawing.Size(200, 49);
            this.btnModerateFeedback.TabIndex = 2;
            this.btnModerateFeedback.Text = "Moderate Feedback";
            this.btnModerateFeedback.UseVisualStyleBackColor = true;
            this.btnModerateFeedback.Click += new System.EventHandler(this.btnModerateFeedback_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 492);
            this.Controls.Add(this.btnModerateFeedback);
            this.Controls.Add(this.btnViewReservations);
            this.Controls.Add(this.btnManageRooms);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminPanelForm";
            this.Text = "Admin Panel";
            this.ResumeLayout(false);

        }
    }
}