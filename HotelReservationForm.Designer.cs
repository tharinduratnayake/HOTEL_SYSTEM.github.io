using System.Windows.Forms;

namespace HotelReservationSystem
{
    partial class HotelReservationForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewRooms;
        private Button btnReservation;
        private Button btnViewReservations;
        private Button btnFeedback; // Add the Feedback button

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelReservationForm));
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnViewReservations = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(310, 64);
            this.dataGridViewRooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.Size = new System.Drawing.Size(733, 246);
            this.dataGridViewRooms.TabIndex = 0;
            this.dataGridViewRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellClick);
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(639, 341);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(200, 49);
            this.btnReservation.TabIndex = 1;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnViewReservations
            // 
            this.btnViewReservations.Location = new System.Drawing.Point(719, 398);
            this.btnViewReservations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewReservations.Name = "btnViewReservations";
            this.btnViewReservations.Size = new System.Drawing.Size(200, 49);
            this.btnViewReservations.TabIndex = 2;
            this.btnViewReservations.Text = "View Reservations";
            this.btnViewReservations.UseVisualStyleBackColor = true;
            this.btnViewReservations.Click += new System.EventHandler(this.btnViewReservations_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(783, 455);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(200, 49);
            this.btnFeedback.TabIndex = 3;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // HotelReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 530);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnViewReservations);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.dataGridViewRooms);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HotelReservationForm";
            this.Text = "Hotel Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);

        }
    }
}