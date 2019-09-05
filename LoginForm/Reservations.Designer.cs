namespace LoginForm
{
    partial class Reservations
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
            this.Dat_Grid_Reservation = new System.Windows.Forms.DataGridView();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Email = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Grid_Reservation)).BeginInit();
            this.SuspendLayout();
            // 
            // Dat_Grid_Reservation
            // 
            this.Dat_Grid_Reservation.AllowUserToAddRows = false;
            this.Dat_Grid_Reservation.AllowUserToDeleteRows = false;
            this.Dat_Grid_Reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dat_Grid_Reservation.Location = new System.Drawing.Point(12, 33);
            this.Dat_Grid_Reservation.Name = "Dat_Grid_Reservation";
            this.Dat_Grid_Reservation.ReadOnly = true;
            this.Dat_Grid_Reservation.Size = new System.Drawing.Size(599, 409);
            this.Dat_Grid_Reservation.TabIndex = 0;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(12, 457);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(117, 31);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(168, 457);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 31);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_Email
            // 
            this.btn_Email.Location = new System.Drawing.Point(335, 457);
            this.btn_Email.Name = "btn_Email";
            this.btn_Email.Size = new System.Drawing.Size(117, 31);
            this.btn_Email.TabIndex = 1;
            this.btn_Email.Text = "Email";
            this.btn_Email.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(494, 457);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(117, 31);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 510);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_Email);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.Dat_Grid_Reservation);
            this.Name = "Reservations";
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.Dat_Grid_Reservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dat_Grid_Reservation;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Email;
        private System.Windows.Forms.Button btn_save;
    }
}