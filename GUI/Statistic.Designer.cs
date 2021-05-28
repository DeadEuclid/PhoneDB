
namespace GUI
{
    partial class Statistic
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DurationOut = new System.Windows.Forms.Label();
            this.DurationIn = new System.Windows.Forms.Label();
            this.CountIn = new System.Windows.Forms.Label();
            this.CountOut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DurationOut);
            this.groupBox1.Controls.Add(this.DurationIn);
            this.groupBox1.Controls.Add(this.CountIn);
            this.groupBox1.Controls.Add(this.CountOut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.splitter3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.splitter2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 122);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // DurationOut
            // 
            this.DurationOut.AutoSize = true;
            this.DurationOut.Location = new System.Drawing.Point(448, 85);
            this.DurationOut.Name = "DurationOut";
            this.DurationOut.Size = new System.Drawing.Size(53, 17);
            this.DurationOut.TabIndex = 11;
            this.DurationOut.Text = "Кол-во";
            // 
            // DurationIn
            // 
            this.DurationIn.AutoSize = true;
            this.DurationIn.Location = new System.Drawing.Point(448, 57);
            this.DurationIn.Name = "DurationIn";
            this.DurationIn.Size = new System.Drawing.Size(53, 17);
            this.DurationIn.TabIndex = 10;
            this.DurationIn.Text = "Кол-во";
            // 
            // CountIn
            // 
            this.CountIn.AutoSize = true;
            this.CountIn.Location = new System.Drawing.Point(232, 54);
            this.CountIn.Name = "CountIn";
            this.CountIn.Size = new System.Drawing.Size(53, 17);
            this.CountIn.TabIndex = 9;
            this.CountIn.Text = "Кол-во";
            // 
            // CountOut
            // 
            this.CountOut.AutoSize = true;
            this.CountOut.Location = new System.Drawing.Point(232, 82);
            this.CountOut.Name = "CountOut";
            this.CountOut.Size = new System.Drawing.Size(53, 17);
            this.CountOut.TabIndex = 8;
            this.CountOut.Text = "Кол-во";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Продолжительность";
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(111, 54);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(556, 28);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(111, 18);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(556, 36);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            this.splitter2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter2_SplitterMoved);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Исходящих:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Входящих:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 18);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(108, 101);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Statistic";
            this.Size = new System.Drawing.Size(676, 128);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label DurationOut;
        private System.Windows.Forms.Label DurationIn;
        private System.Windows.Forms.Label CountIn;
        private System.Windows.Forms.Label CountOut;
        private System.Windows.Forms.Label label2;
    }
}
