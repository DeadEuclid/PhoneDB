
namespace GUI
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.callsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moreInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactsToolStripMenuItem,
            this.callsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.referenceToolStripMenuItem1,
            this.moreInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem1});
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.contactsToolStripMenuItem.Text = "Контакты";
            this.contactsToolStripMenuItem.Click += new System.EventHandler(this.contactsToolStripMenuItem_Click);
            // 
            // addContactToolStripMenuItem1
            // 
            this.addContactToolStripMenuItem1.Name = "addContactToolStripMenuItem1";
            this.addContactToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.addContactToolStripMenuItem1.Text = "Добавить";
            this.addContactToolStripMenuItem1.Click += new System.EventHandler(this.addContactToolStripMenuItem1_Click);
            // 
            // callsToolStripMenuItem
            // 
            this.callsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCallToolStripMenuItem});
            this.callsToolStripMenuItem.Name = "callsToolStripMenuItem";
            this.callsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.callsToolStripMenuItem.Text = "Звонки";
            this.callsToolStripMenuItem.Click += new System.EventHandler(this.callsToolStripMenuItem_Click);
            // 
            // addCallToolStripMenuItem
            // 
            this.addCallToolStripMenuItem.Name = "addCallToolStripMenuItem";
            this.addCallToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addCallToolStripMenuItem.Text = "Добавить";
            this.addCallToolStripMenuItem.Click += new System.EventHandler(this.addCallToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // referenceToolStripMenuItem1
            // 
            this.referenceToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.referenceToolStripMenuItem1.Name = "referenceToolStripMenuItem1";
            this.referenceToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.referenceToolStripMenuItem1.Text = "О прогрмме";
            this.referenceToolStripMenuItem1.Click += new System.EventHandler(this.referenceToolStripMenuItem1_Click);
            // 
            // moreInfoToolStripMenuItem
            // 
            this.moreInfoToolStripMenuItem.Enabled = false;
            this.moreInfoToolStripMenuItem.Name = "moreInfoToolStripMenuItem";
            this.moreInfoToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.moreInfoToolStripMenuItem.Text = "Подробнее о выбранном";
            this.moreInfoToolStripMenuItem.Visible = false;
            this.moreInfoToolStripMenuItem.Click += new System.EventHandler(this.moreInfoToolStripMenuItem_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid.Location = new System.Drawing.Point(0, 32);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(800, 418);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Телефонные переговоры";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem callsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreInfoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

