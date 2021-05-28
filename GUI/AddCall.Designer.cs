
namespace GUI
{
    partial class AddCall
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hourStart = new System.Windows.Forms.NumericUpDown();
            this.minuteStart = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Topic = new System.Windows.Forms.TextBox();
            this.hour = new System.Windows.Forms.NumericUpDown();
            this.minute = new System.Windows.Forms.NumericUpDown();
            this.second = new System.Windows.Forms.NumericUpDown();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.caller = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.hourStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 125;
            this.label11.Text = "дата";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 124;
            this.label9.Text = "часы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 123;
            this.label10.Text = "мин.";
            // 
            // hourStart
            // 
            this.hourStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hourStart.Location = new System.Drawing.Point(124, 76);
            this.hourStart.Name = "hourStart";
            this.hourStart.Size = new System.Drawing.Size(51, 22);
            this.hourStart.TabIndex = 122;
            // 
            // minuteStart
            // 
            this.minuteStart.Location = new System.Drawing.Point(23, 76);
            this.minuteStart.Name = "minuteStart";
            this.minuteStart.Size = new System.Drawing.Size(51, 22);
            this.minuteStart.TabIndex = 121;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(201, 493);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 120;
            this.button3.Text = "Записать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button2.Location = new System.Drawing.Point(20, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 32);
            this.button2.TabIndex = 119;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(20, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 34);
            this.button1.TabIndex = 118;
            this.button1.Text = "Стоп таймер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 17);
            this.label8.TabIndex = 117;
            this.label8.Text = "Описание разговора";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 116;
            this.label7.Text = "час.";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 115;
            this.label6.Text = "мин.";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 114;
            this.label5.Text = "сек.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 113;
            this.label4.Text = "Тема разговора";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 112;
            this.label3.Text = "Продолжительность";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 111;
            this.label2.Text = "Время начала";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 110;
            this.label1.Text = "Тип звонка";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.Location = new System.Drawing.Point(20, 319);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(281, 168);
            this.Description.TabIndex = 109;
            this.Description.Text = "";
            // 
            // Topic
            // 
            this.Topic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Topic.Location = new System.Drawing.Point(19, 274);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(281, 22);
            this.Topic.TabIndex = 108;
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(24, 157);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(51, 22);
            this.hour.TabIndex = 107;
            // 
            // minute
            // 
            this.minute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minute.Location = new System.Drawing.Point(140, 157);
            this.minute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(50, 22);
            this.minute.TabIndex = 106;
            this.minute.ValueChanged += new System.EventHandler(this.minute_ValueChanged);
            // 
            // second
            // 
            this.second.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.second.Location = new System.Drawing.Point(246, 157);
            this.second.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(54, 22);
            this.second.TabIndex = 105;
            this.second.ValueChanged += new System.EventHandler(this.secund_ValueChanged);
            // 
            // dateStart
            // 
            this.dateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(222, 76);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(79, 22);
            this.dateStart.TabIndex = 104;
            // 
            // Type
            // 
            this.Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Входящий",
            "Исходящий"});
            this.Type.Location = new System.Drawing.Point(109, 9);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(192, 24);
            this.Type.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 127;
            this.label12.Text = "Кто звонил";
            // 
            // caller
            // 
            this.caller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caller.FormattingEnabled = true;
            this.caller.Location = new System.Drawing.Point(108, 225);
            this.caller.Name = "caller";
            this.caller.Size = new System.Drawing.Size(192, 24);
            this.caller.TabIndex = 126;
            // 
            // AddCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 535);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.caller);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hourStart);
            this.Controls.Add(this.minuteStart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.second);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.Type);
            this.MinimumSize = new System.Drawing.Size(339, 582);
            this.Name = "AddCall";
            this.Text = "Запись звонка";
            this.Load += new System.EventHandler(this.AddCall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown hourStart;
        private System.Windows.Forms.NumericUpDown minuteStart;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox Topic;
        private System.Windows.Forms.NumericUpDown hour;
        private System.Windows.Forms.NumericUpDown minute;
        private System.Windows.Forms.NumericUpDown second;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox caller;
    }
}