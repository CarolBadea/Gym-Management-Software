
namespace SalaDeGimnastica
{
    partial class AddReservation
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
            this.tb_title = new System.Windows.Forms.TextBox();
            this.lb_pt = new System.Windows.Forms.ListBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_spots = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_title
            // 
            this.tb_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_title.Font = new System.Drawing.Font("Vivaldi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_title.ForeColor = System.Drawing.Color.Crimson;
            this.tb_title.Location = new System.Drawing.Point(178, 12);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(450, 37);
            this.tb_title.TabIndex = 0;
            this.tb_title.Text = "Make a rezervation";
            this.tb_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_pt
            // 
            this.lb_pt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb_pt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_pt.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_pt.ForeColor = System.Drawing.Color.Crimson;
            this.lb_pt.FormattingEnabled = true;
            this.lb_pt.ItemHeight = 24;
            this.lb_pt.Items.AddRange(new object[] {
            "Badea Andrei",
            "Popescu Maria",
            "Pop Adriana",
            "Bolda Ana",
            "Stanescu David"});
            this.lb_pt.Location = new System.Drawing.Point(219, 111);
            this.lb_pt.Name = "lb_pt";
            this.lb_pt.Size = new System.Drawing.Size(414, 120);
            this.lb_pt.TabIndex = 1;
            this.lb_pt.SelectedIndexChanged += new System.EventHandler(this.lb_pt_SelectedIndexChanged);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_1.ForeColor = System.Drawing.Color.Crimson;
            this.lb_1.Location = new System.Drawing.Point(219, 70);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(307, 28);
            this.lb_1.TabIndex = 2;
            this.lb_1.Text = "Select your personal trainer";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.Crimson;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.Crimson;
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(219, 292);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(292, 30);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_submit.ForeColor = System.Drawing.Color.Crimson;
            this.btn_submit.Location = new System.Drawing.Point(219, 352);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(106, 34);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_spots
            // 
            this.btn_spots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_spots.ForeColor = System.Drawing.Color.Crimson;
            this.btn_spots.Location = new System.Drawing.Point(470, 356);
            this.btn_spots.Name = "btn_spots";
            this.btn_spots.Size = new System.Drawing.Size(94, 29);
            this.btn_spots.TabIndex = 6;
            this.btn_spots.Text = "Open Spots";
            this.btn_spots.UseVisualStyleBackColor = false;
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_spots);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.lb_pt);
            this.Controls.Add(this.tb_title);
            this.Name = "AddReservation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.ListBox lb_pt;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_spots;
    }
}