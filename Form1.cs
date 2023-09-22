using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace shutdownat
{
	public partial class shutdownat : Form
	{
		private System.Threading.Timer sleepTimer;

		public shutdownat()
		{
			InitializeComponent();

			string ApplicationName = "Shutdown@";

			// Set form properties
			this.FormBorderStyle = FormBorderStyle.FixedSingle; // Makes the form border static
			this.MaximizeBox = false; // Disables maximize button
			this.StartPosition = FormStartPosition.CenterScreen; // Starts the form at the center of the screen
			this.Text = ApplicationName;
			this.ShowIcon = false;

			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.NotifyIcon.Text = ApplicationName;
			this.NotifyIcon.Icon = this.Icon;
			this.NotifyIcon.DoubleClick += this.NotifyIcon_DoubleClick;

			this.Resize += this.Form1_Resize;

			Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			this.VersionLabel.Text = $"{version.Major}.{version.Minor}";
		}

		// Form1_Resize event handler
		private void Form1_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.ShowInTaskbar = false;
				this.NotifyIcon.Visible = true;
			}
		}

		// NotifyIcon_DoubleClick event handler
		private void NotifyIcon_DoubleClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			this.ShowInTaskbar = true;
			this.NotifyIcon.Visible = false;
		}

		private void SleepBtn_Click(object sender, EventArgs e)
		{
			// Cancel any existing shutdown or sleep
			this.StopBtn_Click(sender, e);

			int sleepTimeInSeconds = ((int)HoursNum.Value * 3600) + ((int)MinutesNum.Value * 60);
			this.LogTextBox.Text = $"This computer will sleep in {HoursNum.Value} hour(s) and {MinutesNum.Value} minute(s).";

			// Initialize a new Timer that will put the computer to sleep after the specified delay
			this.sleepTimer = new System.Threading.Timer((obj) =>
			{
				Process.Start("rundll32.exe", "powrprof.dll,SetSuspendState 0,1,0");
			}, null, sleepTimeInSeconds * 1000, System.Threading.Timeout.Infinite);
		}

		private void ShutdownBtn_Click(object sender, EventArgs e)
		{
			// Cancel any existing shutdown or sleep
			this.StopBtn_Click(sender, e);

			int shutdownTimeInSeconds = ((int)HoursNum.Value * 3600) + ((int)MinutesNum.Value * 60);
			Process.Start("shutdown", $"/s /t {shutdownTimeInSeconds}");
			this.LogTextBox.Text = $"This computer will shutdown in {HoursNum.Value} hour(s) and {MinutesNum.Value} minute(s).";
		}

		private void StopBtn_Click(object sender, EventArgs e)
		{
			// Cancel shutdown
			Process.Start("shutdown", "/a");

			if (this.sleepTimer != null)
			{
				// Cancel the sleep timer
				this.sleepTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
				this.sleepTimer = null;
			}

			this.LogTextBox.Text = "Schedule cancelled.";
		}
	}
}
