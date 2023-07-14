using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace shutdownat
{
	public partial class Form1 : Form
	{
		private Button shutdownButton;
		private Button cancelButton;
		private NumericUpDown shutdownTimer;
		private TextBox logTextBox;

		public Form1()
		{
			InitializeComponent();

			this.shutdownButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.shutdownTimer = new System.Windows.Forms.NumericUpDown();
			this.logTextBox = new System.Windows.Forms.TextBox();

			// shutdownButton
			this.shutdownButton.Location = new System.Drawing.Point(60, 90);
			this.shutdownButton.Name = "shutdownButton";
			this.shutdownButton.Size = new System.Drawing.Size(75, 23);
			this.shutdownButton.TabIndex = 0;
			this.shutdownButton.Text = "Schedule";
			this.shutdownButton.UseVisualStyleBackColor = true;
			this.shutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);

			// cancelButton
			this.cancelButton.Location = new System.Drawing.Point(160, 90);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);

			// shutdownTimer
			this.shutdownTimer.Location = new System.Drawing.Point(60, 40);
			this.shutdownTimer.Name = "shutdownTimer";
			this.shutdownTimer.Size = new System.Drawing.Size(175, 20);
			this.shutdownTimer.TabIndex = 2;
			this.shutdownTimer.Value = new decimal(new int[] { 1, 0, 0, 0 });

			// logTextBox
			this.logTextBox.Location = new System.Drawing.Point(10, 130);
			this.logTextBox.Name = "logTextBox";
			this.logTextBox.Size = new System.Drawing.Size(280, 20);
			this.logTextBox.ReadOnly = true;

			this.Controls.Add(this.logTextBox);
			this.Controls.Add(this.shutdownTimer);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.shutdownButton);

			// Set form properties
			this.ClientSize = new System.Drawing.Size(300, 150); // Sets size
			this.FormBorderStyle = FormBorderStyle.FixedSingle; // Makes the form border static
			this.MaximizeBox = false; // Disables maximize button
			this.StartPosition = FormStartPosition.CenterScreen; // Starts the form at the center of the screen
			this.Text = "Shutdown Scheduler";
			this.ShowIcon = false;
		}

		private void ShutdownButton_Click(object sender, EventArgs e)
		{
			int shutdownTimeInSeconds = (int)shutdownTimer.Value * 3600;
			Process.Start("shutdown", $"/s /t {shutdownTimeInSeconds}");
			this.logTextBox.Text = $"Shutdown scheduled in {shutdownTimer.Value} hour(s)";
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Process.Start("shutdown", "/a");
			this.logTextBox.Text = "Shutdown cancelled";
		}
	}
}
