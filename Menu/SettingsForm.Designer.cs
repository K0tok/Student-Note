namespace Student_Note.Menu
{
    partial class SettingsForm
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            textCodeGroup = new TextBox();
            label2 = new Label();
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
            HeaderLabel.Padding = new Padding(88, 0, 0, 0);
            HeaderLabel.Size = new Size(610, 60);
            HeaderLabel.TabIndex = 3;
            HeaderLabel.Text = "Настройки";
            HeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(324, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(276, 40);
            button1.TabIndex = 5;
            button1.Text = "Войдите в аккаунт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 88);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 6;
            label1.Text = "Войти в новую группу";
            // 
            // button2
            // 
            button2.Location = new Point(457, 86);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 7;
            button2.Text = "Войти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textCodeGroup
            // 
            textCodeGroup.Location = new Point(158, 86);
            textCodeGroup.Margin = new Padding(3, 2, 3, 2);
            textCodeGroup.Name = "textCodeGroup";
            textCodeGroup.Size = new Size(294, 23);
            textCodeGroup.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 69);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 9;
            label2.Text = "Код группы";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 134);
            Controls.Add(textCodeGroup);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(HeaderLabel);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(626, 173);
            MinimumSize = new Size(626, 173);
            Name = "SettingsForm";
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox textCodeGroup;
        private Label label2;
    }
}