using System.Windows.Forms;

namespace HotelReservationSystem
{
    partial class ManageRoomsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewRooms;
        private ComboBox cmbRoomType;
        private TextBox txtAmenities;
        private TextBox txtPrice;
        private Button btnAddRoom;
        private Button btnDeleteRoom;
        private Label label1;
        private Label label2;
        private Label label3;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRoomsForm));
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.txtAmenities = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(108, 198);
            this.dataGridViewRooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.Size = new System.Drawing.Size(733, 246);
            this.dataGridViewRooms.TabIndex = 0;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Luxury",
            "Regular Suite"});
            this.cmbRoomType.Location = new System.Drawing.Point(160, 25);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(199, 24);
            this.cmbRoomType.TabIndex = 1;
            // 
            // txtAmenities
            // 
            this.txtAmenities.Location = new System.Drawing.Point(160, 74);
            this.txtAmenities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmenities.Name = "txtAmenities";
            this.txtAmenities.Size = new System.Drawing.Size(199, 22);
            this.txtAmenities.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(160, 123);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(199, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(400, 25);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(133, 37);
            this.btnAddRoom.TabIndex = 4;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(400, 74);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(133, 37);
            this.btnDeleteRoom.TabIndex = 5;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Room Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amenities";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(939, 541);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAmenities);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.dataGridViewRooms);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageRoomsForm";
            this.Text = "Manage Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}