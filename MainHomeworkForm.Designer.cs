namespace Student_Note
{
    partial class MainHomeworkForm
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
            buttonUser = new Button();
            WeekLable = new Label();
            WeekComboBox = new ComboBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel17 = new TableLayoutPanel();
            SaturdayTableLayoutPanel = new TableLayoutPanel();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            tableLayoutPanel19 = new TableLayoutPanel();
            SaturdayDateLabel = new Label();
            SaturdayLabel = new Label();
            tableLayoutPanel14 = new TableLayoutPanel();
            FridayTableLayoutPanel = new TableLayoutPanel();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            tableLayoutPanel16 = new TableLayoutPanel();
            FridayDateLabel = new Label();
            FridayLabel = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            ThursdayTableLayoutPanel = new TableLayoutPanel();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            ThursdayDateLabel = new Label();
            ThursdayLabel = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            WednesdayTableLayoutPanel = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            label11 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            WednesdayDateLabel = new Label();
            WednesdayLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            TuesdayTableLayoutPanel = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            TuesdayDateLabel = new Label();
            TuesdayLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            MondayTableLayoutPanel = new TableLayoutPanel();
            label10 = new Label();
            label2 = new Label();
            label9 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            MondayDateLabel = new Label();
            MondayLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            SaturdayTableLayoutPanel.SuspendLayout();
            tableLayoutPanel19.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            FridayTableLayoutPanel.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ThursdayTableLayoutPanel.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            WednesdayTableLayoutPanel.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            TuesdayTableLayoutPanel.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            MondayTableLayoutPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            HeaderLabel.Size = new Size(1008, 80);
            HeaderLabel.TabIndex = 2;
            HeaderLabel.Text = "Электронный дневник";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonUser
            // 
            buttonUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUser.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonUser.Location = new Point(681, 12);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(315, 54);
            buttonUser.TabIndex = 3;
            buttonUser.Text = "Войдите в аккаунт";
            buttonUser.UseVisualStyleBackColor = true;
            buttonUser.Click += buttonUser_Click;
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
            WeekComboBox.Location = new Point(238, 92);
            WeekComboBox.Name = "WeekComboBox";
            WeekComboBox.Size = new Size(433, 35);
            WeekComboBox.TabIndex = 4;
            WeekComboBox.Text = "4 неделя (07.10.24 - 13.10.24)";
            WeekComboBox.SelectedIndexChanged += WeekComboBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(0, 133);
            panel1.MinimumSize = new Size(1008, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 528);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel17, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel14, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel11, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1008, 279);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.AutoSize = true;
            tableLayoutPanel17.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel17.ColumnCount = 1;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel17.Controls.Add(SaturdayTableLayoutPanel, 0, 1);
            tableLayoutPanel17.Controls.Add(tableLayoutPanel19, 0, 0);
            tableLayoutPanel17.Dock = DockStyle.Fill;
            tableLayoutPanel17.Location = new Point(507, 189);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 2;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel17.Size = new Size(498, 87);
            tableLayoutPanel17.TabIndex = 5;
            // 
            // SaturdayTableLayoutPanel
            // 
            SaturdayTableLayoutPanel.AutoSize = true;
            SaturdayTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaturdayTableLayoutPanel.ColumnCount = 3;
            SaturdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            SaturdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            SaturdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            SaturdayTableLayoutPanel.Controls.Add(label24, 2, 0);
            SaturdayTableLayoutPanel.Controls.Add(label25, 0, 0);
            SaturdayTableLayoutPanel.Controls.Add(label26, 1, 0);
            SaturdayTableLayoutPanel.Dock = DockStyle.Fill;
            SaturdayTableLayoutPanel.Location = new Point(0, 60);
            SaturdayTableLayoutPanel.Margin = new Padding(0);
            SaturdayTableLayoutPanel.Name = "SaturdayTableLayoutPanel";
            SaturdayTableLayoutPanel.RowCount = 1;
            SaturdayTableLayoutPanel.RowStyles.Add(new RowStyle());
            SaturdayTableLayoutPanel.Size = new Size(498, 27);
            SaturdayTableLayoutPanel.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Dock = DockStyle.Fill;
            label24.Font = new Font("Arial", 18F);
            label24.Location = new Point(244, 0);
            label24.Name = "label24";
            label24.Size = new Size(251, 27);
            label24.TabIndex = 8;
            label24.Text = "Первая пара дз";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Dock = DockStyle.Fill;
            label25.Font = new Font("Arial", 18F);
            label25.Location = new Point(3, 0);
            label25.Name = "label25";
            label25.Size = new Size(64, 27);
            label25.TabIndex = 0;
            label25.Text = "I";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Dock = DockStyle.Fill;
            label26.Font = new Font("Arial", 18F);
            label26.Location = new Point(73, 0);
            label26.Name = "label26";
            label26.Size = new Size(165, 27);
            label26.TabIndex = 7;
            label26.Text = "Первая пара";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.ColumnCount = 2;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel19.Controls.Add(SaturdayDateLabel, 1, 0);
            tableLayoutPanel19.Controls.Add(SaturdayLabel, 0, 0);
            tableLayoutPanel19.Dock = DockStyle.Fill;
            tableLayoutPanel19.Location = new Point(3, 3);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.RowCount = 1;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel19.Size = new Size(492, 54);
            tableLayoutPanel19.TabIndex = 0;
            // 
            // SaturdayDateLabel
            // 
            SaturdayDateLabel.AutoSize = true;
            SaturdayDateLabel.Dock = DockStyle.Fill;
            SaturdayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaturdayDateLabel.Location = new Point(393, 0);
            SaturdayDateLabel.Margin = new Padding(0);
            SaturdayDateLabel.Name = "SaturdayDateLabel";
            SaturdayDateLabel.Size = new Size(99, 54);
            SaturdayDateLabel.TabIndex = 40;
            SaturdayDateLabel.Text = "07.10";
            SaturdayDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SaturdayLabel
            // 
            SaturdayLabel.Dock = DockStyle.Fill;
            SaturdayLabel.Font = new Font("Arial", 26.25F, FontStyle.Bold);
            SaturdayLabel.Location = new Point(0, 0);
            SaturdayLabel.Margin = new Padding(0);
            SaturdayLabel.Name = "SaturdayLabel";
            SaturdayLabel.Size = new Size(393, 54);
            SaturdayLabel.TabIndex = 39;
            SaturdayLabel.Text = "Суббота";
            SaturdayLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.AutoSize = true;
            tableLayoutPanel14.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Controls.Add(FridayTableLayoutPanel, 0, 1);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel16, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 189);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 2;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Size = new Size(498, 87);
            tableLayoutPanel14.TabIndex = 4;
            // 
            // FridayTableLayoutPanel
            // 
            FridayTableLayoutPanel.AutoSize = true;
            FridayTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FridayTableLayoutPanel.ColumnCount = 3;
            FridayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            FridayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            FridayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            FridayTableLayoutPanel.Controls.Add(label19, 2, 0);
            FridayTableLayoutPanel.Controls.Add(label20, 0, 0);
            FridayTableLayoutPanel.Controls.Add(label21, 1, 0);
            FridayTableLayoutPanel.Dock = DockStyle.Fill;
            FridayTableLayoutPanel.Location = new Point(0, 60);
            FridayTableLayoutPanel.Margin = new Padding(0);
            FridayTableLayoutPanel.Name = "FridayTableLayoutPanel";
            FridayTableLayoutPanel.RowCount = 1;
            FridayTableLayoutPanel.RowStyles.Add(new RowStyle());
            FridayTableLayoutPanel.Size = new Size(498, 27);
            FridayTableLayoutPanel.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Arial", 18F);
            label19.Location = new Point(244, 0);
            label19.Name = "label19";
            label19.Size = new Size(251, 27);
            label19.TabIndex = 8;
            label19.Text = "Первая пара дз";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Dock = DockStyle.Fill;
            label20.Font = new Font("Arial", 18F);
            label20.Location = new Point(3, 0);
            label20.Name = "label20";
            label20.Size = new Size(64, 27);
            label20.TabIndex = 0;
            label20.Text = "I";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Dock = DockStyle.Fill;
            label21.Font = new Font("Arial", 18F);
            label21.Location = new Point(73, 0);
            label21.Name = "label21";
            label21.Size = new Size(165, 27);
            label21.TabIndex = 7;
            label21.Text = "Первая пара";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 2;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel16.Controls.Add(FridayDateLabel, 1, 0);
            tableLayoutPanel16.Controls.Add(FridayLabel, 0, 0);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(3, 3);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 1;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel16.Size = new Size(492, 54);
            tableLayoutPanel16.TabIndex = 0;
            // 
            // FridayDateLabel
            // 
            FridayDateLabel.AutoSize = true;
            FridayDateLabel.Dock = DockStyle.Fill;
            FridayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FridayDateLabel.Location = new Point(393, 0);
            FridayDateLabel.Margin = new Padding(0);
            FridayDateLabel.Name = "FridayDateLabel";
            FridayDateLabel.Size = new Size(99, 54);
            FridayDateLabel.TabIndex = 40;
            FridayDateLabel.Text = "07.10";
            FridayDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FridayLabel
            // 
            FridayLabel.Dock = DockStyle.Fill;
            FridayLabel.Font = new Font("Arial", 26.25F, FontStyle.Bold);
            FridayLabel.Location = new Point(0, 0);
            FridayLabel.Margin = new Padding(0);
            FridayLabel.Name = "FridayLabel";
            FridayLabel.Size = new Size(393, 54);
            FridayLabel.TabIndex = 39;
            FridayLabel.Text = "Пятница";
            FridayLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.AutoSize = true;
            tableLayoutPanel11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(ThursdayTableLayoutPanel, 0, 1);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel13, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(507, 96);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(498, 87);
            tableLayoutPanel11.TabIndex = 3;
            // 
            // ThursdayTableLayoutPanel
            // 
            ThursdayTableLayoutPanel.AutoSize = true;
            ThursdayTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ThursdayTableLayoutPanel.ColumnCount = 3;
            ThursdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            ThursdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            ThursdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            ThursdayTableLayoutPanel.Controls.Add(label14, 2, 0);
            ThursdayTableLayoutPanel.Controls.Add(label15, 0, 0);
            ThursdayTableLayoutPanel.Controls.Add(label16, 1, 0);
            ThursdayTableLayoutPanel.Dock = DockStyle.Fill;
            ThursdayTableLayoutPanel.Location = new Point(0, 60);
            ThursdayTableLayoutPanel.Margin = new Padding(0);
            ThursdayTableLayoutPanel.Name = "ThursdayTableLayoutPanel";
            ThursdayTableLayoutPanel.RowCount = 1;
            ThursdayTableLayoutPanel.RowStyles.Add(new RowStyle());
            ThursdayTableLayoutPanel.Size = new Size(498, 27);
            ThursdayTableLayoutPanel.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Arial", 18F);
            label14.Location = new Point(244, 0);
            label14.Name = "label14";
            label14.Size = new Size(251, 27);
            label14.TabIndex = 8;
            label14.Text = "Первая пара дз";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Arial", 18F);
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(64, 27);
            label15.TabIndex = 0;
            label15.Text = "I";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Arial", 18F);
            label16.Location = new Point(73, 0);
            label16.Name = "label16";
            label16.Size = new Size(165, 27);
            label16.TabIndex = 7;
            label16.Text = "Первая пара";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel13.Controls.Add(ThursdayDateLabel, 1, 0);
            tableLayoutPanel13.Controls.Add(ThursdayLabel, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.Size = new Size(492, 54);
            tableLayoutPanel13.TabIndex = 0;
            // 
            // ThursdayDateLabel
            // 
            ThursdayDateLabel.AutoSize = true;
            ThursdayDateLabel.Dock = DockStyle.Fill;
            ThursdayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ThursdayDateLabel.Location = new Point(393, 0);
            ThursdayDateLabel.Margin = new Padding(0);
            ThursdayDateLabel.Name = "ThursdayDateLabel";
            ThursdayDateLabel.Size = new Size(99, 54);
            ThursdayDateLabel.TabIndex = 40;
            ThursdayDateLabel.Text = "07.10";
            ThursdayDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ThursdayLabel
            // 
            ThursdayLabel.Dock = DockStyle.Fill;
            ThursdayLabel.Font = new Font("Arial", 26.25F, FontStyle.Bold);
            ThursdayLabel.Location = new Point(0, 0);
            ThursdayLabel.Margin = new Padding(0);
            ThursdayLabel.Name = "ThursdayLabel";
            ThursdayLabel.Size = new Size(393, 54);
            ThursdayLabel.TabIndex = 39;
            ThursdayLabel.Text = "Четверг";
            ThursdayLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.AutoSize = true;
            tableLayoutPanel8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(WednesdayTableLayoutPanel, 0, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 96);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(498, 87);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // WednesdayTableLayoutPanel
            // 
            WednesdayTableLayoutPanel.AutoSize = true;
            WednesdayTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            WednesdayTableLayoutPanel.ColumnCount = 3;
            WednesdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            WednesdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            WednesdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            WednesdayTableLayoutPanel.Controls.Add(label7, 2, 0);
            WednesdayTableLayoutPanel.Controls.Add(label8, 0, 0);
            WednesdayTableLayoutPanel.Controls.Add(label11, 1, 0);
            WednesdayTableLayoutPanel.Dock = DockStyle.Fill;
            WednesdayTableLayoutPanel.Location = new Point(0, 60);
            WednesdayTableLayoutPanel.Margin = new Padding(0);
            WednesdayTableLayoutPanel.Name = "WednesdayTableLayoutPanel";
            WednesdayTableLayoutPanel.RowCount = 1;
            WednesdayTableLayoutPanel.RowStyles.Add(new RowStyle());
            WednesdayTableLayoutPanel.Size = new Size(498, 27);
            WednesdayTableLayoutPanel.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Arial", 18F);
            label7.Location = new Point(244, 0);
            label7.Name = "label7";
            label7.Size = new Size(251, 27);
            label7.TabIndex = 8;
            label7.Text = "Первая пара дз";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Arial", 18F);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(64, 27);
            label8.TabIndex = 0;
            label8.Text = "I";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Arial", 18F);
            label11.Location = new Point(73, 0);
            label11.Name = "label11";
            label11.Size = new Size(165, 27);
            label11.TabIndex = 7;
            label11.Text = "Первая пара";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel10.Controls.Add(WednesdayDateLabel, 1, 0);
            tableLayoutPanel10.Controls.Add(WednesdayLabel, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Size = new Size(492, 54);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // WednesdayDateLabel
            // 
            WednesdayDateLabel.AutoSize = true;
            WednesdayDateLabel.Dock = DockStyle.Fill;
            WednesdayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WednesdayDateLabel.Location = new Point(393, 0);
            WednesdayDateLabel.Margin = new Padding(0);
            WednesdayDateLabel.Name = "WednesdayDateLabel";
            WednesdayDateLabel.Size = new Size(99, 54);
            WednesdayDateLabel.TabIndex = 40;
            WednesdayDateLabel.Text = "07.10";
            WednesdayDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // WednesdayLabel
            // 
            WednesdayLabel.Dock = DockStyle.Fill;
            WednesdayLabel.Font = new Font("Arial", 26.25F, FontStyle.Bold);
            WednesdayLabel.Location = new Point(0, 0);
            WednesdayLabel.Margin = new Padding(0);
            WednesdayLabel.Name = "WednesdayLabel";
            WednesdayLabel.Size = new Size(393, 54);
            WednesdayLabel.TabIndex = 39;
            WednesdayLabel.Text = "Среда";
            WednesdayLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(TuesdayTableLayoutPanel, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(507, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(498, 87);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // TuesdayTableLayoutPanel
            // 
            TuesdayTableLayoutPanel.AutoSize = true;
            TuesdayTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TuesdayTableLayoutPanel.ColumnCount = 3;
            TuesdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            TuesdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TuesdayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TuesdayTableLayoutPanel.Controls.Add(label1, 2, 0);
            TuesdayTableLayoutPanel.Controls.Add(label3, 0, 0);
            TuesdayTableLayoutPanel.Controls.Add(label4, 1, 0);
            TuesdayTableLayoutPanel.Dock = DockStyle.Fill;
            TuesdayTableLayoutPanel.Location = new Point(0, 60);
            TuesdayTableLayoutPanel.Margin = new Padding(0);
            TuesdayTableLayoutPanel.Name = "TuesdayTableLayoutPanel";
            TuesdayTableLayoutPanel.RowCount = 1;
            TuesdayTableLayoutPanel.RowStyles.Add(new RowStyle());
            TuesdayTableLayoutPanel.Size = new Size(498, 27);
            TuesdayTableLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 18F);
            label1.Location = new Point(244, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 27);
            label1.TabIndex = 8;
            label1.Text = "Первая пара дз";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Arial", 18F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 27);
            label3.TabIndex = 0;
            label3.Text = "I";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Arial", 18F);
            label4.Location = new Point(73, 0);
            label4.Name = "label4";
            label4.Size = new Size(165, 27);
            label4.TabIndex = 7;
            label4.Text = "Первая пара";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.Controls.Add(TuesdayDateLabel, 1, 0);
            tableLayoutPanel7.Controls.Add(TuesdayLabel, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(492, 54);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // TuesdayDateLabel
            // 
            TuesdayDateLabel.AutoSize = true;
            TuesdayDateLabel.Dock = DockStyle.Fill;
            TuesdayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TuesdayDateLabel.Location = new Point(393, 0);
            TuesdayDateLabel.Margin = new Padding(0);
            TuesdayDateLabel.Name = "TuesdayDateLabel";
            TuesdayDateLabel.Size = new Size(99, 54);
            TuesdayDateLabel.TabIndex = 40;
            TuesdayDateLabel.Text = "07.10";
            TuesdayDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TuesdayLabel
            // 
            TuesdayLabel.Dock = DockStyle.Fill;
            TuesdayLabel.Font = new Font("Arial", 26.25F, FontStyle.Bold);
            TuesdayLabel.Location = new Point(0, 0);
            TuesdayLabel.Margin = new Padding(0);
            TuesdayLabel.Name = "TuesdayLabel";
            TuesdayLabel.Size = new Size(393, 54);
            TuesdayLabel.TabIndex = 39;
            TuesdayLabel.Text = "Вторник";
            TuesdayLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(MondayTableLayoutPanel, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(498, 87);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // MondayTableLayoutPanel
            // 
            MondayTableLayoutPanel.AutoSize = true;
            MondayTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MondayTableLayoutPanel.ColumnCount = 3;
            MondayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            MondayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            MondayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            MondayTableLayoutPanel.Controls.Add(label10, 2, 0);
            MondayTableLayoutPanel.Controls.Add(label2, 0, 0);
            MondayTableLayoutPanel.Controls.Add(label9, 1, 0);
            MondayTableLayoutPanel.Dock = DockStyle.Fill;
            MondayTableLayoutPanel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MondayTableLayoutPanel.Location = new Point(0, 60);
            MondayTableLayoutPanel.Margin = new Padding(0);
            MondayTableLayoutPanel.Name = "MondayTableLayoutPanel";
            MondayTableLayoutPanel.RowCount = 1;
            MondayTableLayoutPanel.RowStyles.Add(new RowStyle());
            MondayTableLayoutPanel.Size = new Size(498, 27);
            MondayTableLayoutPanel.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Arial", 18F);
            label10.Location = new Point(244, 0);
            label10.Name = "label10";
            label10.Size = new Size(251, 27);
            label10.TabIndex = 8;
            label10.Text = "Первая пара дз";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += label10_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial", 18F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 27);
            label2.TabIndex = 0;
            label2.Text = "I";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Arial", 18F);
            label9.Location = new Point(73, 0);
            label9.Name = "label9";
            label9.Size = new Size(165, 27);
            label9.TabIndex = 7;
            label9.Text = "Первая пара";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(MondayDateLabel, 1, 0);
            tableLayoutPanel3.Controls.Add(MondayLabel, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(492, 54);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // MondayDateLabel
            // 
            MondayDateLabel.AutoSize = true;
            MondayDateLabel.Dock = DockStyle.Fill;
            MondayDateLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MondayDateLabel.Location = new Point(393, 0);
            MondayDateLabel.Margin = new Padding(0);
            MondayDateLabel.Name = "MondayDateLabel";
            MondayDateLabel.Size = new Size(99, 54);
            MondayDateLabel.TabIndex = 40;
            MondayDateLabel.Text = "07.10";
            MondayDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MondayLabel
            // 
            MondayLabel.Dock = DockStyle.Fill;
            MondayLabel.Font = new Font("Arial", 26.25F, FontStyle.Bold);
            MondayLabel.Location = new Point(0, 0);
            MondayLabel.Margin = new Padding(0);
            MondayLabel.Name = "MondayLabel";
            MondayLabel.Size = new Size(393, 54);
            MondayLabel.TabIndex = 39;
            MondayLabel.Text = "Понедельник";
            MondayLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainHomeworkForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1008, 661);
            Controls.Add(panel1);
            Controls.Add(WeekComboBox);
            Controls.Add(WeekLable);
            Controls.Add(buttonUser);
            Controls.Add(HeaderLabel);
            Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinimumSize = new Size(1024, 700);
            Name = "MainHomeworkForm";
            Text = "MainHomeworkForm";
            WindowState = FormWindowState.Maximized;
            Load += MainHomeworkForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel17.PerformLayout();
            SaturdayTableLayoutPanel.ResumeLayout(false);
            SaturdayTableLayoutPanel.PerformLayout();
            tableLayoutPanel19.ResumeLayout(false);
            tableLayoutPanel19.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            FridayTableLayoutPanel.ResumeLayout(false);
            FridayTableLayoutPanel.PerformLayout();
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ThursdayTableLayoutPanel.ResumeLayout(false);
            ThursdayTableLayoutPanel.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            WednesdayTableLayoutPanel.ResumeLayout(false);
            WednesdayTableLayoutPanel.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            TuesdayTableLayoutPanel.ResumeLayout(false);
            TuesdayTableLayoutPanel.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            MondayTableLayoutPanel.ResumeLayout(false);
            MondayTableLayoutPanel.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Button buttonUser;
        private Label WeekLable;
        private ComboBox WeekComboBox;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label MondayLabel;
        private Label MondayDateLabel;
        private TableLayoutPanel MondayTableLayoutPanel;
        private Label label10;
        private Label label2;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel17;
        private TableLayoutPanel SaturdayTableLayoutPanel;
        private Label label24;
        private Label label25;
        private Label label26;
        private TableLayoutPanel tableLayoutPanel19;
        private Label SaturdayDateLabel;
        private Label SaturdayLabel;
        private TableLayoutPanel tableLayoutPanel14;
        private TableLayoutPanel FridayTableLayoutPanel;
        private Label label19;
        private Label label20;
        private Label label21;
        private TableLayoutPanel tableLayoutPanel16;
        private Label FridayDateLabel;
        private Label FridayLabel;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel ThursdayTableLayoutPanel;
        private Label label14;
        private Label label15;
        private Label label16;
        private TableLayoutPanel tableLayoutPanel13;
        private Label ThursdayDateLabel;
        private Label ThursdayLabel;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel WednesdayTableLayoutPanel;
        private Label label7;
        private Label label8;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel10;
        private Label WednesdayDateLabel;
        private Label WednesdayLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel TuesdayTableLayoutPanel;
        private Label label1;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel7;
        private Label TuesdayDateLabel;
        private Label TuesdayLabel;
        private ContextMenuStrip contextMenuStrip1;
    }
}