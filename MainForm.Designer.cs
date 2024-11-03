namespace Student_Note
{
    partial class MainForm
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
            HeaderLabel = new Label();
            WeekLable = new Label();
            WeekComboBox = new ComboBox();
            panel1 = new Panel();
            SaturdayDateLabel = new Label();
            SaturdayLabel = new Label();
            SaturdayTLP = new TableLayoutPanel();
            FridayDateLabel = new Label();
            FridayLabel = new Label();
            FridayTLP = new TableLayoutPanel();
            ThursdayDateLabel = new Label();
            ThursdayLabel = new Label();
            ThursdayTLP = new TableLayoutPanel();
            WednesdayDateLabel = new Label();
            WednesdayLabel = new Label();
            WednesdayTLP = new TableLayoutPanel();
            TuesdayDateLabel = new Label();
            Tuesday = new Label();
            TuesdayTLP = new TableLayoutPanel();
            MondayDateLabel = new Label();
            MondayLabel = new Label();
            MondayTLP = new TableLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.BackColor = Color.FromArgb(52, 199, 89);
            HeaderLabel.Dock = DockStyle.Top;
            HeaderLabel.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            HeaderLabel.ForeColor = Color.White;
            HeaderLabel.Location = new Point(0, 0);
            HeaderLabel.Margin = new Padding(0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Padding = new Padding(100, 0, 0, 0);
            HeaderLabel.Size = new Size(1008, 80);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Электронный дневник";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WeekLable
            // 
            WeekLable.AutoSize = true;
            WeekLable.Location = new Point(54, 95);
            WeekLable.Name = "WeekLable";
            WeekLable.Size = new Size(222, 35);
            WeekLable.TabIndex = 2;
            WeekLable.Text = "Выбор недели:";
            // 
            // WeekComboBox
            // 
            WeekComboBox.FormattingEnabled = true;
            WeekComboBox.Location = new Point(238, 91);
            WeekComboBox.Name = "WeekComboBox";
            WeekComboBox.Size = new Size(363, 43);
            WeekComboBox.TabIndex = 3;
            WeekComboBox.Text = "4 неделя (07.10.24 - 13.10.24)";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(0, 50);
            panel1.Controls.Add(SaturdayDateLabel);
            panel1.Controls.Add(SaturdayLabel);
            panel1.Controls.Add(SaturdayTLP);
            panel1.Controls.Add(FridayDateLabel);
            panel1.Controls.Add(FridayLabel);
            panel1.Controls.Add(FridayTLP);
            panel1.Controls.Add(ThursdayDateLabel);
            panel1.Controls.Add(ThursdayLabel);
            panel1.Controls.Add(ThursdayTLP);
            panel1.Controls.Add(WednesdayDateLabel);
            panel1.Controls.Add(WednesdayLabel);
            panel1.Controls.Add(WednesdayTLP);
            panel1.Controls.Add(TuesdayDateLabel);
            panel1.Controls.Add(Tuesday);
            panel1.Controls.Add(TuesdayTLP);
            panel1.Controls.Add(MondayDateLabel);
            panel1.Controls.Add(MondayLabel);
            panel1.Controls.Add(MondayTLP);
            panel1.Location = new Point(6, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 627);
            panel1.TabIndex = 4;
            // 
            // SaturdayDateLabel
            // 
            SaturdayDateLabel.AutoSize = true;
            SaturdayDateLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaturdayDateLabel.Location = new Point(884, 736);
            SaturdayDateLabel.Name = "SaturdayDateLabel";
            SaturdayDateLabel.Size = new Size(101, 46);
            SaturdayDateLabel.TabIndex = 45;
            SaturdayDateLabel.Text = "12.10";
            // 
            // SaturdayLabel
            // 
            SaturdayLabel.AutoSize = true;
            SaturdayLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaturdayLabel.Location = new Point(513, 721);
            SaturdayLabel.Name = "SaturdayLabel";
            SaturdayLabel.Size = new Size(261, 67);
            SaturdayLabel.TabIndex = 44;
            SaturdayLabel.Text = "Суббота";
            // 
            // SaturdayTLP
            // 
            SaturdayTLP.ColumnCount = 3;
            SaturdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            SaturdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            SaturdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            SaturdayTLP.Location = new Point(508, 776);
            SaturdayTLP.Name = "SaturdayTLP";
            SaturdayTLP.RowCount = 3;
            SaturdayTLP.RowStyles.Add(new RowStyle());
            SaturdayTLP.RowStyles.Add(new RowStyle());
            SaturdayTLP.RowStyles.Add(new RowStyle());
            SaturdayTLP.Size = new Size(460, 265);
            SaturdayTLP.TabIndex = 43;
            // 
            // FridayDateLabel
            // 
            FridayDateLabel.AutoSize = true;
            FridayDateLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FridayDateLabel.Location = new Point(391, 736);
            FridayDateLabel.Name = "FridayDateLabel";
            FridayDateLabel.Size = new Size(101, 46);
            FridayDateLabel.TabIndex = 42;
            FridayDateLabel.Text = "11.10";
            // 
            // FridayLabel
            // 
            FridayLabel.AutoSize = true;
            FridayLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FridayLabel.Location = new Point(17, 721);
            FridayLabel.Name = "FridayLabel";
            FridayLabel.Size = new Size(265, 67);
            FridayLabel.TabIndex = 41;
            FridayLabel.Text = "Пятница";
            // 
            // FridayTLP
            // 
            FridayTLP.ColumnCount = 3;
            FridayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            FridayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            FridayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            FridayTLP.Location = new Point(15, 776);
            FridayTLP.Name = "FridayTLP";
            FridayTLP.RowCount = 3;
            FridayTLP.RowStyles.Add(new RowStyle());
            FridayTLP.RowStyles.Add(new RowStyle());
            FridayTLP.RowStyles.Add(new RowStyle());
            FridayTLP.Size = new Size(460, 265);
            FridayTLP.TabIndex = 40;
            // 
            // ThursdayDateLabel
            // 
            ThursdayDateLabel.AutoSize = true;
            ThursdayDateLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ThursdayDateLabel.Location = new Point(884, 382);
            ThursdayDateLabel.Name = "ThursdayDateLabel";
            ThursdayDateLabel.Size = new Size(101, 46);
            ThursdayDateLabel.TabIndex = 39;
            ThursdayDateLabel.Text = "10.10";
            // 
            // ThursdayLabel
            // 
            ThursdayLabel.AutoSize = true;
            ThursdayLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ThursdayLabel.Location = new Point(513, 367);
            ThursdayLabel.Name = "ThursdayLabel";
            ThursdayLabel.Size = new Size(246, 67);
            ThursdayLabel.TabIndex = 38;
            ThursdayLabel.Text = "Четверг";
            // 
            // ThursdayTLP
            // 
            ThursdayTLP.ColumnCount = 3;
            ThursdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            ThursdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            ThursdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            ThursdayTLP.Location = new Point(508, 422);
            ThursdayTLP.Name = "ThursdayTLP";
            ThursdayTLP.RowCount = 3;
            ThursdayTLP.RowStyles.Add(new RowStyle());
            ThursdayTLP.RowStyles.Add(new RowStyle());
            ThursdayTLP.RowStyles.Add(new RowStyle());
            ThursdayTLP.Size = new Size(460, 265);
            ThursdayTLP.TabIndex = 37;
            // 
            // WednesdayDateLabel
            // 
            WednesdayDateLabel.AutoSize = true;
            WednesdayDateLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WednesdayDateLabel.Location = new Point(391, 382);
            WednesdayDateLabel.Name = "WednesdayDateLabel";
            WednesdayDateLabel.Size = new Size(101, 46);
            WednesdayDateLabel.TabIndex = 36;
            WednesdayDateLabel.Text = "09.10";
            // 
            // WednesdayLabel
            // 
            WednesdayLabel.AutoSize = true;
            WednesdayLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WednesdayLabel.Location = new Point(17, 367);
            WednesdayLabel.Name = "WednesdayLabel";
            WednesdayLabel.Size = new Size(205, 67);
            WednesdayLabel.TabIndex = 35;
            WednesdayLabel.Text = "Среда";
            // 
            // WednesdayTLP
            // 
            WednesdayTLP.ColumnCount = 3;
            WednesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            WednesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            WednesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            WednesdayTLP.Location = new Point(15, 422);
            WednesdayTLP.Name = "WednesdayTLP";
            WednesdayTLP.RowCount = 3;
            WednesdayTLP.RowStyles.Add(new RowStyle());
            WednesdayTLP.RowStyles.Add(new RowStyle());
            WednesdayTLP.RowStyles.Add(new RowStyle());
            WednesdayTLP.Size = new Size(460, 265);
            WednesdayTLP.TabIndex = 34;
            // 
            // TuesdayDateLabel
            // 
            TuesdayDateLabel.AutoSize = true;
            TuesdayDateLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TuesdayDateLabel.Location = new Point(884, 26);
            TuesdayDateLabel.Name = "TuesdayDateLabel";
            TuesdayDateLabel.Size = new Size(101, 46);
            TuesdayDateLabel.TabIndex = 33;
            TuesdayDateLabel.Text = "08.10";
            // 
            // Tuesday
            // 
            Tuesday.AutoSize = true;
            Tuesday.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tuesday.Location = new Point(513, 11);
            Tuesday.Name = "Tuesday";
            Tuesday.Size = new Size(252, 67);
            Tuesday.TabIndex = 32;
            Tuesday.Text = "Вторник";
            // 
            // TuesdayTLP
            // 
            TuesdayTLP.ColumnCount = 3;
            TuesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            TuesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TuesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TuesdayTLP.Location = new Point(508, 66);
            TuesdayTLP.Name = "TuesdayTLP";
            TuesdayTLP.RowCount = 3;
            TuesdayTLP.RowStyles.Add(new RowStyle());
            TuesdayTLP.RowStyles.Add(new RowStyle());
            TuesdayTLP.RowStyles.Add(new RowStyle());
            TuesdayTLP.Size = new Size(460, 265);
            TuesdayTLP.TabIndex = 31;
            // 
            // MondayDateLabel
            // 
            MondayDateLabel.AutoSize = true;
            MondayDateLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MondayDateLabel.Location = new Point(391, 26);
            MondayDateLabel.Name = "MondayDateLabel";
            MondayDateLabel.Size = new Size(101, 46);
            MondayDateLabel.TabIndex = 30;
            MondayDateLabel.Text = "07.10";
            // 
            // MondayLabel
            // 
            MondayLabel.AutoSize = true;
            MondayLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MondayLabel.Location = new Point(17, 11);
            MondayLabel.Name = "MondayLabel";
            MondayLabel.Size = new Size(395, 67);
            MondayLabel.TabIndex = 29;
            MondayLabel.Text = "Понедельник";
            // 
            // MondayTLP
            // 
            MondayTLP.ColumnCount = 3;
            MondayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            MondayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            MondayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            MondayTLP.Location = new Point(15, 66);
            MondayTLP.Name = "MondayTLP";
            MondayTLP.RowCount = 3;
            MondayTLP.RowStyles.Add(new RowStyle());
            MondayTLP.RowStyles.Add(new RowStyle());
            MondayTLP.RowStyles.Add(new RowStyle());
            MondayTLP.Size = new Size(460, 265);
            MondayTLP.TabIndex = 28;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(209, 209, 214);
            ClientSize = new Size(1008, 761);
            Controls.Add(WeekComboBox);
            Controls.Add(WeekLable);
            Controls.Add(HeaderLabel);
            Controls.Add(panel1);
            Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 5, 6, 5);
            MaximumSize = new Size(1440, 1500);
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label WeekLable;
        private ComboBox WeekComboBox;
        private Panel panel1;
        private Label ThursdayDateLabel;
        private Label ThursdayLabel;
        private TableLayoutPanel ThursdayTLP;
        private Label WednesdayDateLabel;
        private Label WednesdayLabel;
        private TableLayoutPanel WednesdayTLP;
        private Label TuesdayDateLabel;
        private Label Tuesday;
        private TableLayoutPanel TuesdayTLP;
        private Label MondayDateLabel;
        private Label MondayLabel;
        private TableLayoutPanel MondayTLP;
        private Label SaturdayDateLabel;
        private Label SaturdayLabel;
        private TableLayoutPanel SaturdayTLP;
        private Label FridayDateLabel;
        private Label FridayLabel;
        private TableLayoutPanel FridayTLP;
    }
}