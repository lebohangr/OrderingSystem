namespace Poppel_System.Presentation_Layer
{
    partial class ViewCustomers
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
            this.studentListview = new System.Windows.Forms.ListView();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentListview
            // 
            this.studentListview.HideSelection = false;
            this.studentListview.Location = new System.Drawing.Point(13, 13);
            this.studentListview.Margin = new System.Windows.Forms.Padding(4);
            this.studentListview.Name = "studentListview";
            this.studentListview.Size = new System.Drawing.Size(956, 479);
            this.studentListview.TabIndex = 1;
            this.studentListview.UseCompatibleStateImageBehavior = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Gainsboro;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Location = new System.Drawing.Point(746, 499);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(223, 62);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Poppel_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 573);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.studentListview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewCustomers";
            this.Text = "ViewCustomers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewCustomers_FormClosed);
            this.Load += new System.EventHandler(this.ViewCustomers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView studentListview;
        private System.Windows.Forms.Button btnView;
    }
}