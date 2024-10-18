namespace WeatherDataApp
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
            dateInput = new DateTimePicker();
            dateLabel = new Label();
            dateBox = new Label();
            precipitationBox = new Label();
            highTempBox = new Label();
            lowTempBox = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // dateInput
            // 
            dateInput.Location = new Point(54, 54);
            dateInput.Name = "dateInput";
            dateInput.Size = new Size(250, 27);
            dateInput.TabIndex = 0;
            dateInput.ValueChanged += dateInput_ValueChanged;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(135, 31);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(95, 20);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Select a date";
            // 
            // dateBox
            // 
            dateBox.BorderStyle = BorderStyle.FixedSingle;
            dateBox.Location = new Point(201, 112);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(119, 35);
            dateBox.TabIndex = 2;
            // 
            // precipitationBox
            // 
            precipitationBox.BorderStyle = BorderStyle.FixedSingle;
            precipitationBox.Location = new Point(201, 159);
            precipitationBox.Name = "precipitationBox";
            precipitationBox.Size = new Size(119, 35);
            precipitationBox.TabIndex = 2;
            // 
            // highTempBox
            // 
            highTempBox.BorderStyle = BorderStyle.FixedSingle;
            highTempBox.Location = new Point(201, 209);
            highTempBox.Name = "highTempBox";
            highTempBox.Size = new Size(119, 35);
            highTempBox.TabIndex = 3;
            // 
            // lowTempBox
            // 
            lowTempBox.BorderStyle = BorderStyle.FixedSingle;
            lowTempBox.Location = new Point(201, 260);
            lowTempBox.Name = "lowTempBox";
            lowTempBox.Size = new Size(119, 35);
            lowTempBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 275);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 5;
            label5.Text = "Low Temp:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 224);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 6;
            label6.Text = "High Temp:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 174);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 7;
            label7.Text = "Precipitation: ";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(147, 127);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 8;
            label8.Text = "Date: ";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lowTempBox);
            Controls.Add(highTempBox);
            Controls.Add(precipitationBox);
            Controls.Add(dateBox);
            Controls.Add(dateLabel);
            Controls.Add(dateInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateInput;
        private Label dateLabel;
        private Label dateBox;
        private Label precipitationBox;
        private Label highTempBox;
        private Label lowTempBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}