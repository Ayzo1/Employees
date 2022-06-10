
namespace Employees
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.selectionComboBox = new System.Windows.Forms.ComboBox();
            this.secondLabel = new System.Windows.Forms.Label();
            this.secondComboBox = new System.Windows.Forms.ComboBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.jobTitleComboBox = new System.Windows.Forms.ComboBox();
            this.subunitLabel = new System.Windows.Forms.Label();
            this.subunitComboBox = new System.Windows.Forms.ComboBox();
            this.attributeLabel = new System.Windows.Forms.Label();
            this.attributeTextBox = new System.Windows.Forms.TextBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(30, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(594, 467);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(643, 39);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(75, 20);
            this.selectionLabel.TabIndex = 1;
            this.selectionLabel.Text = "Выборка";
            // 
            // selectionComboBox
            // 
            this.selectionComboBox.FormattingEnabled = true;
            this.selectionComboBox.Location = new System.Drawing.Point(780, 39);
            this.selectionComboBox.Name = "selectionComboBox";
            this.selectionComboBox.Size = new System.Drawing.Size(186, 28);
            this.selectionComboBox.TabIndex = 2;
            this.selectionComboBox.SelectedIndexChanged += new System.EventHandler(this.selectionComboBox_SelectedIndexChanged);
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(643, 94);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(51, 20);
            this.secondLabel.TabIndex = 3;
            this.secondLabel.Text = "label1";
            this.secondLabel.Visible = false;
            // 
            // secondComboBox
            // 
            this.secondComboBox.FormattingEnabled = true;
            this.secondComboBox.Location = new System.Drawing.Point(780, 86);
            this.secondComboBox.Name = "secondComboBox";
            this.secondComboBox.Size = new System.Drawing.Size(186, 28);
            this.secondComboBox.TabIndex = 4;
            this.secondComboBox.Visible = false;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(647, 144);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(195, 52);
            this.selectButton.TabIndex = 5;
            this.selectButton.Text = "Выбрать";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(647, 225);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(308, 26);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.Visible = false;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(643, 299);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(40, 20);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "Пол";
            this.genderLabel.Visible = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(892, 144);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(186, 52);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(647, 258);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(129, 26);
            this.dateTextBox.TabIndex = 10;
            this.dateTextBox.Visible = false;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(856, 296);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(110, 30);
            this.genderComboBox.TabIndex = 11;
            this.genderComboBox.Visible = false;
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Location = new System.Drawing.Point(643, 332);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(95, 20);
            this.jobTitleLabel.TabIndex = 12;
            this.jobTitleLabel.Text = "Должность";
            this.jobTitleLabel.Visible = false;
            // 
            // jobTitleComboBox
            // 
            this.jobTitleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.jobTitleComboBox.FormattingEnabled = true;
            this.jobTitleComboBox.Location = new System.Drawing.Point(856, 329);
            this.jobTitleComboBox.Name = "jobTitleComboBox";
            this.jobTitleComboBox.Size = new System.Drawing.Size(210, 28);
            this.jobTitleComboBox.TabIndex = 13;
            this.jobTitleComboBox.Visible = false;
            this.jobTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.jobTitleComboBox_SelectedIndexChanged);
            // 
            // subunitLabel
            // 
            this.subunitLabel.AutoSize = true;
            this.subunitLabel.Location = new System.Drawing.Point(643, 370);
            this.subunitLabel.Name = "subunitLabel";
            this.subunitLabel.Size = new System.Drawing.Size(133, 20);
            this.subunitLabel.TabIndex = 14;
            this.subunitLabel.Text = "Подразделение";
            this.subunitLabel.Visible = false;
            // 
            // subunitComboBox
            // 
            this.subunitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.subunitComboBox.FormattingEnabled = true;
            this.subunitComboBox.Location = new System.Drawing.Point(856, 362);
            this.subunitComboBox.Name = "subunitComboBox";
            this.subunitComboBox.Size = new System.Drawing.Size(210, 28);
            this.subunitComboBox.TabIndex = 15;
            this.subunitComboBox.Visible = false;
            // 
            // attributeLabel
            // 
            this.attributeLabel.AutoSize = true;
            this.attributeLabel.Location = new System.Drawing.Point(643, 405);
            this.attributeLabel.Name = "attributeLabel";
            this.attributeLabel.Size = new System.Drawing.Size(72, 20);
            this.attributeLabel.TabIndex = 16;
            this.attributeLabel.Text = "Атрибут";
            this.attributeLabel.Visible = false;
            // 
            // attributeTextBox
            // 
            this.attributeTextBox.Location = new System.Drawing.Point(856, 396);
            this.attributeTextBox.Name = "attributeTextBox";
            this.attributeTextBox.Size = new System.Drawing.Size(210, 26);
            this.attributeTextBox.TabIndex = 17;
            this.attributeTextBox.Visible = false;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(979, 39);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(114, 78);
            this.addEmployeeButton.TabIndex = 18;
            this.addEmployeeButton.Text = "Добавить работника";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(979, 225);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 44);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(979, 275);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 44);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(979, 225);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(114, 62);
            this.editButton.TabIndex = 21;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(841, 261);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(51, 20);
            this.idLabel.TabIndex = 22;
            this.idLabel.Text = "label1";
            this.idLabel.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(647, 440);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(195, 55);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Удалить работника";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 507);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.attributeTextBox);
            this.Controls.Add(this.attributeLabel);
            this.Controls.Add(this.subunitComboBox);
            this.Controls.Add(this.subunitLabel);
            this.Controls.Add(this.jobTitleComboBox);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.secondComboBox);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.selectionComboBox);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.ComboBox selectionComboBox;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.ComboBox secondComboBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.ComboBox jobTitleComboBox;
        private System.Windows.Forms.Label subunitLabel;
        private System.Windows.Forms.ComboBox subunitComboBox;
        private System.Windows.Forms.Label attributeLabel;
        private System.Windows.Forms.TextBox attributeTextBox;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}

