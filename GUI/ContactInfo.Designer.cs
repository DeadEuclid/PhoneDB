
namespace GUI
{
    partial class ContactInfo
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
            this.statisticPanel = new System.Windows.Forms.Panel();
            this.butonsGroup = new System.Windows.Forms.GroupBox();
            this.Cansel = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.EditOrAdd = new System.Windows.Forms.Button();
            this.contactGroup = new System.Windows.Forms.GroupBox();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.coment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nickName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.midleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secondName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butonsGroup.SuspendLayout();
            this.contactGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // statisticPanel
            // 
            this.statisticPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statisticPanel.Location = new System.Drawing.Point(6, 190);
            this.statisticPanel.Name = "statisticPanel";
            this.statisticPanel.Size = new System.Drawing.Size(676, 128);
            this.statisticPanel.TabIndex = 18;
            // 
            // butonsGroup
            // 
            this.butonsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butonsGroup.Controls.Add(this.Cansel);
            this.butonsGroup.Controls.Add(this.Delete);
            this.butonsGroup.Controls.Add(this.EditOrAdd);
            this.butonsGroup.Location = new System.Drawing.Point(5, 324);
            this.butonsGroup.Name = "butonsGroup";
            this.butonsGroup.Size = new System.Drawing.Size(677, 51);
            this.butonsGroup.TabIndex = 17;
            this.butonsGroup.TabStop = false;
            this.butonsGroup.Text = "Управление";
            this.butonsGroup.Enter += new System.EventHandler(this.butonsGroup_Enter);
            // 
            // Cansel
            // 
            this.Cansel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cansel.Location = new System.Drawing.Point(6, 18);
            this.Cansel.Name = "Cansel";
            this.Cansel.Size = new System.Drawing.Size(112, 26);
            this.Cansel.TabIndex = 5;
            this.Cansel.Text = "Назад";
            this.Cansel.UseVisualStyleBackColor = true;
            this.Cansel.Click += new System.EventHandler(this.Cansel_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.Location = new System.Drawing.Point(282, 18);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 26);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // EditOrAdd
            // 
            this.EditOrAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditOrAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EditOrAdd.Location = new System.Drawing.Point(558, 18);
            this.EditOrAdd.Name = "EditOrAdd";
            this.EditOrAdd.Size = new System.Drawing.Size(112, 26);
            this.EditOrAdd.TabIndex = 6;
            this.EditOrAdd.Text = "Изменить";
            this.EditOrAdd.UseVisualStyleBackColor = true;
            this.EditOrAdd.Click += new System.EventHandler(this.EditOrAdd_Click);
            // 
            // contactGroup
            // 
            this.contactGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactGroup.Controls.Add(this.phoneNum);
            this.contactGroup.Controls.Add(this.label6);
            this.contactGroup.Controls.Add(this.firstName);
            this.contactGroup.Controls.Add(this.coment);
            this.contactGroup.Controls.Add(this.label1);
            this.contactGroup.Controls.Add(this.nickName);
            this.contactGroup.Controls.Add(this.label2);
            this.contactGroup.Controls.Add(this.midleName);
            this.contactGroup.Controls.Add(this.label3);
            this.contactGroup.Controls.Add(this.label4);
            this.contactGroup.Controls.Add(this.secondName);
            this.contactGroup.Controls.Add(this.label5);
            this.contactGroup.Location = new System.Drawing.Point(6, 9);
            this.contactGroup.Name = "contactGroup";
            this.contactGroup.Size = new System.Drawing.Size(683, 175);
            this.contactGroup.TabIndex = 16;
            this.contactGroup.TabStop = false;
            this.contactGroup.Text = "Контакт";
            this.contactGroup.Enter += new System.EventHandler(this.contactGroup_Enter);
            // 
            // phoneNum
            // 
            this.phoneNum.Location = new System.Drawing.Point(115, 139);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(150, 22);
            this.phoneNum.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Номер ";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(115, 51);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(150, 22);
            this.firstName.TabIndex = 9;
            // 
            // coment
            // 
            this.coment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coment.Location = new System.Drawing.Point(279, 37);
            this.coment.Name = "coment";
            this.coment.Size = new System.Drawing.Size(388, 123);
            this.coment.TabIndex = 12;
            this.coment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // nickName
            // 
            this.nickName.Location = new System.Drawing.Point(115, 111);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(150, 22);
            this.nickName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // midleName
            // 
            this.midleName.Location = new System.Drawing.Point(115, 79);
            this.midleName.Name = "midleName";
            this.midleName.Size = new System.Drawing.Size(150, 22);
            this.midleName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя контакта";
            // 
            // secondName
            // 
            this.secondName.Location = new System.Drawing.Point(115, 21);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(150, 22);
            this.secondName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Коментарий";
            // 
            // ContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 384);
            this.Controls.Add(this.statisticPanel);
            this.Controls.Add(this.butonsGroup);
            this.Controls.Add(this.contactGroup);
            this.MaximumSize = new System.Drawing.Size(713, 1000);
            this.MinimumSize = new System.Drawing.Size(713, 431);
            this.Name = "ContactInfo";
            this.butonsGroup.ResumeLayout(false);
            this.contactGroup.ResumeLayout(false);
            this.contactGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statisticPanel;
        private System.Windows.Forms.GroupBox butonsGroup;
        private System.Windows.Forms.Button Cansel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button EditOrAdd;
        private System.Windows.Forms.GroupBox contactGroup;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.RichTextBox coment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nickName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox midleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secondName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneNum;
        private System.Windows.Forms.Label label6;
    }
}