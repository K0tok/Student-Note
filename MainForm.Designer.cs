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
            components = new System.ComponentModel.Container();
            HeaderLabel = new Label();
            WeekLable = new Label();
            WeekComboBox = new ComboBox();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            FridayDateLabel = new Label();
            FridayLabel = new Label();
            FridayTLP = new TableLayoutPanel();
            WednesdayDateLabel = new Label();
            WednesdayLabel = new Label();
            WednesdayTLP = new TableLayoutPanel();
            MondayDateLabel = new Label();
            MondayLabel = new Label();
            MondayTLP = new TableLayoutPanel();
            SaturdayDateLabel = new Label();
            SaturdayLabel = new Label();
            SaturdayTLP = new TableLayoutPanel();
            ThursdayDateLabel = new Label();
            ThursdayLabel = new Label();
            ThursdayTLP = new TableLayoutPanel();
            TuesdayDateLabel = new Label();
            Tuesday = new Label();
            TuesdayTLP = new TableLayoutPanel();
            buttonUser = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.BackColor = Color.FromArgb(52, 199, 89);
            HeaderLabel.Dock = DockStyle.Top;
            HeaderLabel.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeaderLabel.ForeColor = Color.White;
            HeaderLabel.Location = new Point(0, 0);
            HeaderLabel.Margin = new Padding(0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Padding = new Padding(100, 0, 0, 0);
            HeaderLabel.Size = new Size(1339, 80);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Электронный дневник";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WeekLable
            // 
            WeekLable.AutoSize = true;
            WeekLable.Location = new Point(54, 95);
            WeekLable.Name = "WeekLable";
            WeekLable.Size = new Size(178, 27);
            WeekLable.TabIndex = 2;
            WeekLable.Text = "Выбор недели:";
            // 
            // WeekComboBox
            // 
            WeekComboBox.FormattingEnabled = true;
            WeekComboBox.Location = new Point(238, 91);
            WeekComboBox.Name = "WeekComboBox";
            WeekComboBox.Size = new Size(433, 35);
            WeekComboBox.TabIndex = 3;
            WeekComboBox.Text = "4 неделя (07.10.24 - 13.10.24)";
            WeekComboBox.SelectedIndexChanged += WeekComboBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(splitContainer1);
            panel1.Location = new Point(0, 128);
            panel1.MinimumSize = new Size(991, 1110);
            panel1.Name = "panel1";
            panel1.Size = new Size(1339, 1110);
            panel1.TabIndex = 8;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(12, 16);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(FridayDateLabel);
            splitContainer1.Panel1.Controls.Add(FridayLabel);
            splitContainer1.Panel1.Controls.Add(FridayTLP);
            splitContainer1.Panel1.Controls.Add(WednesdayDateLabel);
            splitContainer1.Panel1.Controls.Add(WednesdayLabel);
            splitContainer1.Panel1.Controls.Add(WednesdayTLP);
            splitContainer1.Panel1.Controls.Add(MondayDateLabel);
            splitContainer1.Panel1.Controls.Add(MondayLabel);
            splitContainer1.Panel1.Controls.Add(MondayTLP);
            splitContainer1.Panel1MinSize = 325;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SaturdayDateLabel);
            splitContainer1.Panel2.Controls.Add(SaturdayLabel);
            splitContainer1.Panel2.Controls.Add(SaturdayTLP);
            splitContainer1.Panel2.Controls.Add(ThursdayDateLabel);
            splitContainer1.Panel2.Controls.Add(ThursdayLabel);
            splitContainer1.Panel2.Controls.Add(ThursdayTLP);
            splitContainer1.Panel2.Controls.Add(TuesdayDateLabel);
            splitContainer1.Panel2.Controls.Add(Tuesday);
            splitContainer1.Panel2.Controls.Add(TuesdayTLP);
            splitContainer1.Panel2MinSize = 325;
            splitContainer1.Size = new Size(1315, 1094);
            splitContainer1.SplitterDistance = 576;
            splitContainer1.SplitterWidth = 30;
            splitContainer1.TabIndex = 8;
            // 
            // FridayDateLabel
            // 
            FridayDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FridayDateLabel.AutoSize = true;
            FridayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FridayDateLabel.Location = new Point(568, 715);
            FridayDateLabel.Name = "FridayDateLabel";
            FridayDateLabel.Size = new Size(92, 37);
            FridayDateLabel.TabIndex = 45;
            FridayDateLabel.Text = "11.10";
            // 
            // FridayLabel
            // 
            FridayLabel.AutoSize = true;
            FridayLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FridayLabel.Location = new Point(0, 698);
            FridayLabel.Name = "FridayLabel";
            FridayLabel.Size = new Size(216, 55);
            FridayLabel.TabIndex = 44;
            FridayLabel.Text = "Пятница";
            // 
            // FridayTLP
            // 
            FridayTLP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FridayTLP.ColumnCount = 3;
            FridayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            FridayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            FridayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            FridayTLP.Location = new Point(0, 752);
            FridayTLP.MinimumSize = new Size(327, 0);
            FridayTLP.Name = "FridayTLP";
            FridayTLP.RowCount = 3;
            FridayTLP.RowStyles.Add(new RowStyle());
            FridayTLP.RowStyles.Add(new RowStyle());
            FridayTLP.RowStyles.Add(new RowStyle());
            FridayTLP.Size = new Size(663, 265);
            FridayTLP.TabIndex = 40;
            // 
            // WednesdayDateLabel
            // 
            WednesdayDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WednesdayDateLabel.AutoSize = true;
            WednesdayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WednesdayDateLabel.Location = new Point(564, 372);
            WednesdayDateLabel.Name = "WednesdayDateLabel";
            WednesdayDateLabel.Size = new Size(96, 37);
            WednesdayDateLabel.TabIndex = 42;
            WednesdayDateLabel.Text = "09.10";
            // 
            // WednesdayLabel
            // 
            WednesdayLabel.AutoSize = true;
            WednesdayLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WednesdayLabel.Location = new Point(7, 356);
            WednesdayLabel.Name = "WednesdayLabel";
            WednesdayLabel.Size = new Size(167, 55);
            WednesdayLabel.TabIndex = 41;
            WednesdayLabel.Text = "Среда";
            // 
            // WednesdayTLP
            // 
            WednesdayTLP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WednesdayTLP.ColumnCount = 3;
            WednesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            WednesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            WednesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            WednesdayTLP.Location = new Point(0, 411);
            WednesdayTLP.Margin = new Padding(0);
            WednesdayTLP.MinimumSize = new Size(327, 0);
            WednesdayTLP.Name = "WednesdayTLP";
            WednesdayTLP.RowCount = 3;
            WednesdayTLP.RowStyles.Add(new RowStyle());
            WednesdayTLP.RowStyles.Add(new RowStyle());
            WednesdayTLP.RowStyles.Add(new RowStyle());
            WednesdayTLP.Size = new Size(663, 265);
            WednesdayTLP.TabIndex = 40;
            // 
            // MondayDateLabel
            // 
            MondayDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MondayDateLabel.AutoSize = true;
            MondayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MondayDateLabel.Location = new Point(431, 16);
            MondayDateLabel.Name = "MondayDateLabel";
            MondayDateLabel.Size = new Size(96, 37);
            MondayDateLabel.TabIndex = 39;
            MondayDateLabel.Text = "07.10";
            // 
            // MondayLabel
            // 
            MondayLabel.AutoSize = true;
            MondayLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MondayLabel.Location = new Point(0, 0);
            MondayLabel.Margin = new Padding(0);
            MondayLabel.Name = "MondayLabel";
            MondayLabel.Size = new Size(320, 55);
            MondayLabel.TabIndex = 38;
            MondayLabel.Text = "Понедельник";
            // 
            // MondayTLP
            // 
            MondayTLP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MondayTLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MondayTLP.ColumnCount = 3;
            MondayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            MondayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            MondayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            MondayTLP.Location = new Point(0, 55);
            MondayTLP.Margin = new Padding(0);
            MondayTLP.MinimumSize = new Size(327, 0);
            MondayTLP.Name = "MondayTLP";
            MondayTLP.RowCount = 7;
            MondayTLP.RowStyles.Add(new RowStyle());
            MondayTLP.RowStyles.Add(new RowStyle());
            MondayTLP.RowStyles.Add(new RowStyle());
            MondayTLP.RowStyles.Add(new RowStyle());
            MondayTLP.RowStyles.Add(new RowStyle());
            MondayTLP.RowStyles.Add(new RowStyle());
            MondayTLP.RowStyles.Add(new RowStyle());
            MondayTLP.Size = new Size(546, 265);
            MondayTLP.TabIndex = 37;
            // 
            // SaturdayDateLabel
            // 
            SaturdayDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaturdayDateLabel.AutoSize = true;
            SaturdayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaturdayDateLabel.Location = new Point(295, 714);
            SaturdayDateLabel.Name = "SaturdayDateLabel";
            SaturdayDateLabel.Size = new Size(94, 37);
            SaturdayDateLabel.TabIndex = 48;
            SaturdayDateLabel.Text = "12.10";
            // 
            // SaturdayLabel
            // 
            SaturdayLabel.AutoSize = true;
            SaturdayLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaturdayLabel.Location = new Point(3, 695);
            SaturdayLabel.Name = "SaturdayLabel";
            SaturdayLabel.Size = new Size(213, 55);
            SaturdayLabel.TabIndex = 47;
            SaturdayLabel.Text = "Суббота";
            // 
            // SaturdayTLP
            // 
            SaturdayTLP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SaturdayTLP.ColumnCount = 3;
            SaturdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            SaturdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            SaturdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            SaturdayTLP.Location = new Point(0, 752);
            SaturdayTLP.MinimumSize = new Size(473, 265);
            SaturdayTLP.Name = "SaturdayTLP";
            SaturdayTLP.RowCount = 3;
            SaturdayTLP.RowStyles.Add(new RowStyle());
            SaturdayTLP.RowStyles.Add(new RowStyle());
            SaturdayTLP.RowStyles.Add(new RowStyle());
            SaturdayTLP.Size = new Size(517, 265);
            SaturdayTLP.TabIndex = 46;
            // 
            // ThursdayDateLabel
            // 
            ThursdayDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ThursdayDateLabel.AutoSize = true;
            ThursdayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ThursdayDateLabel.Location = new Point(295, 371);
            ThursdayDateLabel.Name = "ThursdayDateLabel";
            ThursdayDateLabel.Size = new Size(94, 37);
            ThursdayDateLabel.TabIndex = 42;
            ThursdayDateLabel.Text = "10.10";
            // 
            // ThursdayLabel
            // 
            ThursdayLabel.AutoSize = true;
            ThursdayLabel.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ThursdayLabel.Location = new Point(3, 351);
            ThursdayLabel.Name = "ThursdayLabel";
            ThursdayLabel.Size = new Size(200, 55);
            ThursdayLabel.TabIndex = 41;
            ThursdayLabel.Text = "Четверг";
            // 
            // ThursdayTLP
            // 
            ThursdayTLP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ThursdayTLP.ColumnCount = 3;
            ThursdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            ThursdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            ThursdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            ThursdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            ThursdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            ThursdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            ThursdayTLP.Location = new Point(0, 411);
            ThursdayTLP.MinimumSize = new Size(473, 265);
            ThursdayTLP.Name = "ThursdayTLP";
            ThursdayTLP.RowCount = 3;
            ThursdayTLP.RowStyles.Add(new RowStyle());
            ThursdayTLP.RowStyles.Add(new RowStyle());
            ThursdayTLP.RowStyles.Add(new RowStyle());
            ThursdayTLP.RowStyles.Add(new RowStyle());
            ThursdayTLP.RowStyles.Add(new RowStyle());
            ThursdayTLP.RowStyles.Add(new RowStyle());
            ThursdayTLP.Size = new Size(517, 265);
            ThursdayTLP.TabIndex = 40;
            // 
            // TuesdayDateLabel
            // 
            TuesdayDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TuesdayDateLabel.AutoSize = true;
            TuesdayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TuesdayDateLabel.Location = new Point(295, 16);
            TuesdayDateLabel.Name = "TuesdayDateLabel";
            TuesdayDateLabel.Size = new Size(96, 37);
            TuesdayDateLabel.TabIndex = 36;
            TuesdayDateLabel.Text = "08.10";
            // 
            // Tuesday
            // 
            Tuesday.AutoSize = true;
            Tuesday.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tuesday.Location = new Point(3, 0);
            Tuesday.Name = "Tuesday";
            Tuesday.Size = new Size(204, 55);
            Tuesday.TabIndex = 35;
            Tuesday.Text = "Вторник";
            // 
            // TuesdayTLP
            // 
            TuesdayTLP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TuesdayTLP.ColumnCount = 3;
            TuesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            TuesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TuesdayTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TuesdayTLP.Location = new Point(0, 55);
            TuesdayTLP.Margin = new Padding(0);
            TuesdayTLP.MinimumSize = new Size(473, 265);
            TuesdayTLP.Name = "TuesdayTLP";
            TuesdayTLP.RowCount = 3;
            TuesdayTLP.RowStyles.Add(new RowStyle());
            TuesdayTLP.RowStyles.Add(new RowStyle());
            TuesdayTLP.RowStyles.Add(new RowStyle());
            TuesdayTLP.Size = new Size(709, 265);
            TuesdayTLP.TabIndex = 34;
            // 
            // buttonUser
            // 
            buttonUser.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonUser.Location = new Point(1008, 12);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(315, 54);
            buttonUser.TabIndex = 0;
            buttonUser.Text = "Войдите в аккаунт";
            buttonUser.UseVisualStyleBackColor = true;
            buttonUser.Click += buttonUser_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 26);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(209, 209, 214);
            ClientSize = new Size(1356, 661);
            Controls.Add(buttonUser);
            Controls.Add(WeekComboBox);
            Controls.Add(WeekLable);
            Controls.Add(HeaderLabel);
            Controls.Add(panel1);
            Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1024, 700);
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.Manual;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label WeekLable;
        private ComboBox WeekComboBox;
        private Panel panel1;
        private Label MondayDateLabel;
        private Label MondayLabel;
        private TableLayoutPanel MondayTLP;
        private Button buttonUser;
        private ContextMenuStrip contextMenuStrip1;
        private SplitContainer splitContainer1;
        private Label FridayDateLabel;
        private Label FridayLabel;
        private TableLayoutPanel FridayTLP;
        private Label WednesdayDateLabel;
        private Label WednesdayLabel;
        private TableLayoutPanel WednesdayTLP;
        private Label SaturdayDateLabel;
        private Label SaturdayLabel;
        private TableLayoutPanel SaturdayTLP;
        private Label ThursdayDateLabel;
        private Label ThursdayLabel;
        private TableLayoutPanel ThursdayTLP;
        private Label TuesdayDateLabel;
        private Label Tuesday;
        private TableLayoutPanel TuesdayTLP;
    }
}