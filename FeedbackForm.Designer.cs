using System.Windows.Forms;

namespace HotelReservationSystem
{
    partial class FeedbackForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblRating;
        private TextBox txtRating;
        private Label lblReview;
        private TextBox txtReview;
        private Button btnSubmit;
        private Button btnBack;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackForm));
            this.lblRating = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(40, 37);
            this.lblRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(110, 16);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "Rating (1-5 stars):";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(200, 33);
            this.txtRating.Margin = new System.Windows.Forms.Padding(4);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(65, 22);
            this.txtRating.TabIndex = 1;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Location = new System.Drawing.Point(40, 86);
            this.lblReview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(55, 16);
            this.lblReview.TabIndex = 2;
            this.lblReview.Text = "Review:";
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(40, 111);
            this.txtReview.Margin = new System.Windows.Forms.Padding(4);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(452, 147);
            this.txtReview.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(293, 283);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 37);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(40, 283);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 345);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.lblRating);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FeedbackForm";
            this.Text = "Feedback Form";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}