namespace HotelReservationSystem
{
    partial class ModerateFeedbackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModerateFeedbackForm));
            this.dataGridViewFeedback = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFeedback
            // 
            this.dataGridViewFeedback.AllowUserToAddRows = false;
            this.dataGridViewFeedback.AllowUserToDeleteRows = false;
            this.dataGridViewFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewFeedback.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFeedback.Name = "dataGridViewFeedback";
            this.dataGridViewFeedback.ReadOnly = true;
            this.dataGridViewFeedback.RowHeadersWidth = 51;
            this.dataGridViewFeedback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFeedback.Size = new System.Drawing.Size(1067, 492);
            this.dataGridViewFeedback.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(0, 505);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(1067, 49);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Selected Feedback";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ModerateFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridViewFeedback);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModerateFeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moderate Feedback";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFeedback;
        private System.Windows.Forms.Button btnDelete;
    }
}