namespace Alarm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSpustit = new System.Windows.Forms.Button();
            this.btnZastavit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(252, 73);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(204, 71);
            this.dateTimePicker.TabIndex = 0;
            // 
            // btnSpustit
            // 
            this.btnSpustit.Location = new System.Drawing.Point(122, 228);
            this.btnSpustit.Name = "btnSpustit";
            this.btnSpustit.Size = new System.Drawing.Size(121, 52);
            this.btnSpustit.TabIndex = 1;
            this.btnSpustit.Text = "Spustit";
            this.btnSpustit.UseVisualStyleBackColor = true;
            this.btnSpustit.Click += new System.EventHandler(this.btnSpustit_Click);
            // 
            // btnZastavit
            // 
            this.btnZastavit.Location = new System.Drawing.Point(434, 228);
            this.btnZastavit.Name = "btnZastavit";
            this.btnZastavit.Size = new System.Drawing.Size(121, 52);
            this.btnZastavit.TabIndex = 1;
            this.btnZastavit.Text = "Zastavit";
            this.btnZastavit.UseVisualStyleBackColor = true;
            this.btnZastavit.Click += new System.EventHandler(this.btnZastavit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 395);
            this.Controls.Add(this.btnZastavit);
            this.Controls.Add(this.btnSpustit);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dateTimePicker;
        private Button btnSpustit;
        private Button btnZastavit;
    }
}