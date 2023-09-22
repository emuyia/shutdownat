namespace shutdownat
{
	partial class shutdownat
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shutdownat));
			SleepBtn = new Button();
			ShutdownBtn = new Button();
			StopBtn = new Button();
			HoursNum = new NumericUpDown();
			LogTextBox = new TextBox();
			HoursLabel = new Label();
			MinutesLabel = new Label();
			MinutesNum = new NumericUpDown();
			label1 = new Label();
			NotifyIcon = new NotifyIcon(components);
			VersionLabel = new Label();
			((System.ComponentModel.ISupportInitialize)HoursNum).BeginInit();
			((System.ComponentModel.ISupportInitialize)MinutesNum).BeginInit();
			SuspendLayout();
			// 
			// SleepBtn
			// 
			SleepBtn.ForeColor = SystemColors.ControlText;
			SleepBtn.Location = new Point(47, 60);
			SleepBtn.Margin = new Padding(3, 2, 3, 2);
			SleepBtn.Name = "SleepBtn";
			SleepBtn.Size = new Size(64, 26);
			SleepBtn.TabIndex = 0;
			SleepBtn.Text = "Sleep";
			SleepBtn.UseVisualStyleBackColor = true;
			SleepBtn.Click += SleepBtn_Click;
			// 
			// ShutdownBtn
			// 
			ShutdownBtn.ForeColor = SystemColors.ControlText;
			ShutdownBtn.Location = new Point(111, 60);
			ShutdownBtn.Margin = new Padding(3, 2, 3, 2);
			ShutdownBtn.Name = "ShutdownBtn";
			ShutdownBtn.Size = new Size(75, 26);
			ShutdownBtn.TabIndex = 1;
			ShutdownBtn.Text = "Shutdown";
			ShutdownBtn.UseVisualStyleBackColor = true;
			ShutdownBtn.Click += ShutdownBtn_Click;
			// 
			// StopBtn
			// 
			StopBtn.ForeColor = SystemColors.ControlText;
			StopBtn.Location = new Point(186, 60);
			StopBtn.Margin = new Padding(3, 2, 3, 2);
			StopBtn.Name = "StopBtn";
			StopBtn.Size = new Size(64, 26);
			StopBtn.TabIndex = 2;
			StopBtn.Text = "Stop";
			StopBtn.UseVisualStyleBackColor = true;
			StopBtn.Click += StopBtn_Click;
			// 
			// HoursNum
			// 
			HoursNum.Location = new Point(106, 28);
			HoursNum.Margin = new Padding(3, 2, 3, 2);
			HoursNum.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
			HoursNum.Name = "HoursNum";
			HoursNum.Size = new Size(36, 22);
			HoursNum.TabIndex = 3;
			// 
			// LogTextBox
			// 
			LogTextBox.Location = new Point(10, 95);
			LogTextBox.Margin = new Padding(3, 2, 3, 2);
			LogTextBox.Multiline = true;
			LogTextBox.Name = "LogTextBox";
			LogTextBox.ReadOnly = true;
			LogTextBox.Size = new Size(272, 35);
			LogTextBox.TabIndex = 4;
			// 
			// HoursLabel
			// 
			HoursLabel.AutoSize = true;
			HoursLabel.Location = new Point(104, 13);
			HoursLabel.Name = "HoursLabel";
			HoursLabel.Size = new Size(38, 13);
			HoursLabel.TabIndex = 5;
			HoursLabel.Text = "Hours";
			// 
			// MinutesLabel
			// 
			MinutesLabel.AutoSize = true;
			MinutesLabel.Location = new Point(150, 13);
			MinutesLabel.Name = "MinutesLabel";
			MinutesLabel.Size = new Size(49, 13);
			MinutesLabel.TabIndex = 7;
			MinutesLabel.Text = "Minutes";
			// 
			// MinutesNum
			// 
			MinutesNum.Location = new Point(156, 28);
			MinutesNum.Margin = new Padding(3, 2, 3, 2);
			MinutesNum.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
			MinutesNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			MinutesNum.Name = "MinutesNum";
			MinutesNum.Size = new Size(36, 22);
			MinutesNum.TabIndex = 6;
			MinutesNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("MS Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 137);
			label1.Name = "label1";
			label1.Size = new Size(268, 11);
			label1.TabIndex = 8;
			label1.Text = "a siwwy wittwe pwogwam by june (´◡ ‿ ゝ◡ `)";
			// 
			// NotifyIcon
			// 
			NotifyIcon.Text = "NotifyIcon";
			NotifyIcon.Visible = true;
			NotifyIcon.DoubleClick += NotifyIcon_DoubleClick;
			// 
			// VersionLabel
			// 
			VersionLabel.AutoSize = true;
			VersionLabel.Location = new Point(10, 10);
			VersionLabel.Name = "VersionLabel";
			VersionLabel.Size = new Size(22, 13);
			VersionLabel.TabIndex = 9;
			VersionLabel.Text = "1.0";
			// 
			// shutdownat
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(64, 64, 64);
			ClientSize = new Size(294, 156);
			Controls.Add(VersionLabel);
			Controls.Add(label1);
			Controls.Add(MinutesLabel);
			Controls.Add(MinutesNum);
			Controls.Add(HoursLabel);
			Controls.Add(LogTextBox);
			Controls.Add(HoursNum);
			Controls.Add(StopBtn);
			Controls.Add(ShutdownBtn);
			Controls.Add(SleepBtn);
			Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			ForeColor = SystemColors.ControlLight;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 2, 3, 2);
			Name = "shutdownat";
			Opacity = 0.9D;
			ShowIcon = false;
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)HoursNum).EndInit();
			((System.ComponentModel.ISupportInitialize)MinutesNum).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button SleepBtn;
		private Button ShutdownBtn;
		private Button StopBtn;
		private NumericUpDown HoursNum;
		private TextBox LogTextBox;
		private Label HoursLabel;
		private Label MinutesLabel;
		private NumericUpDown MinutesNum;
		private Label label1;
		private NotifyIcon NotifyIcon;
		private Label VersionLabel;
	}
}