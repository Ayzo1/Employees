using System;
using System.Windows.Forms;

namespace Employees
{
    public partial class MainForm : Form
    {
        private readonly IMainFormController controller;
        private bool creatingNewEmployee = false;

        public MainForm()
        {
            InitializeComponent();
            controller = new MainFormController();
            FillSelectionComboBox();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FillSelectionComboBox()
        {
            selectionComboBox.Items.Add("Все работники");
            selectionComboBox.Items.Add("По должности");
            selectionComboBox.Items.Add("По подразделению");
        }

        private void selectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            secondComboBox.Items.Clear();
            secondComboBox.SelectedItem = null;
            switch (selectionComboBox.SelectedIndex)
            {
                case 0:
                    secondLabel.Visible = false;
                    secondComboBox.Visible = false;

                    break;
                case 1:
                    secondLabel.Text = "Должность";
                    secondLabel.Visible = true;
                    var jobtitles = controller.GetJobtitles();
                    foreach (string jobtitle in jobtitles)
                    {
                        secondComboBox.Items.Add(jobtitle);
                    }
                    secondComboBox.Visible = true;
                    break;
                case 2:
                    secondLabel.Text = "Подразделение";
                    secondLabel.Visible = true;
                    var subunits = controller.GetSubunits();
                    foreach (string subunit in subunits)
                    {
                        secondComboBox.Items.Add(subunit);
                    }
                    secondComboBox.Visible = true;
                    break;
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            FillTable();
        }

        private void FillTable()
        {
            var employees = controller.GetEmployees(selectionComboBox.SelectedIndex, secondComboBox.SelectedIndex);
            if (employees == null) return;

            dataGridView.Columns.Add("id", "Идентификатор");
            dataGridView.Columns.Add("name", "ФИО");
            dataGridView.Columns.Add("gender", "Пол");
            dataGridView.Columns.Add("birthDate", "Дата рождения");
            var i = 0;
            foreach ((int, string, string, string) tuple in employees)
            {
                dataGridView.Rows.Add();

                dataGridView.Rows[i].Cells[0].Value = tuple.Item1;
                dataGridView.Rows[i].Cells[1].Value = tuple.Item2;
                dataGridView.Rows[i].Cells[2].Value = tuple.Item3;
                dataGridView.Rows[i].Cells[3].Value = tuple.Item4;
                i++;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);
            var employee = controller.GetEmployee(id);
            FillEmployeeFields(employee);
        }

        private void FillEmployeeFields(Employee employee)
        {
            idLabel.Text = $"ID: {employee.Id}";
            nameTextBox.Text = employee.Name;
            dateTextBox.Text = employee.BirthDate;
            genderComboBox.Text = employee.Gender.ToRusString();
            jobTitleComboBox.Text = employee.JobTitle.ToRusString();
            subunitComboBox.Text = employee.Subunit.ToRusString();

            var attributeInfo = controller.GetUniqEmployeeAttribute(employee.Id);
            attributeLabel.Text = attributeInfo.Item1;
            attributeTextBox.Text = attributeInfo.Item2;

            idLabel.Visible = true;
            nameTextBox.Visible = true;
            dateTextBox.Visible = true;
            genderComboBox.Visible = true;
            jobTitleComboBox.Visible = true;
            subunitComboBox.Visible = true;
            attributeLabel.Visible = true;

            genderLabel.Visible = true;
            jobTitleLabel.Visible = true;
            subunitLabel.Visible = true;

            attributeTextBox.Visible = true;
            editButton.Visible = true;

            genderComboBox.Items.AddRange(controller.GetGenders());
            jobTitleComboBox.Items.AddRange(controller.GetJobtitles());
            subunitComboBox.Items.AddRange(controller.GetSubunits());
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            controller.Refresh();
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            selectionComboBox.Update();
            secondComboBox.Items.Clear();
            secondComboBox.Visible = false;
            secondLabel.Visible = false;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            creatingNewEmployee = true;
            NewEmployeeEditing();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (creatingNewEmployee)
            {
                CreateEmployee();
            }
            else
            {
                SaveChanges();
            }
            CancelEditing();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelEditing();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            dataGridView.Enabled = false;
            secondComboBox.Enabled = false;
            selectionComboBox.Enabled = false;
            editButton.Visible = false;
            saveButton.Visible = true;
            cancelButton.Visible = true;
            genderComboBox.Visible = true;
            deleteButton.Visible = true;
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            subunitComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            jobTitleComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            subunitComboBox.Visible = true;
            jobTitleComboBox.Visible = true;
        }

        private void jobTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attributeLabel.Text = controller.GetAttributeName(jobTitleComboBox.SelectedIndex);
            attributeTextBox.Clear();
        }

        private void CreateEmployee()
        {
            controller.AddEmployee(
                nameTextBox.Text,
                dateTextBox.Text,
                genderComboBox.Text,
                jobTitleComboBox.Text,
                subunitComboBox.Text,
                attributeTextBox.Text);
        }

        private void SaveChanges()
        {
            controller.ChangeEmployee(
                idLabel.Text.Split(' ')[1],
                nameTextBox.Text,
                dateTextBox.Text,
                genderComboBox.Text,
                jobTitleComboBox.Text,
                subunitComboBox.Text,
                attributeTextBox.Text);
        }

        private void NewEmployeeEditing()
        {
            dataGridView.Enabled = false;
            secondComboBox.Enabled = false;
            selectionComboBox.Enabled = false;
            editButton.Visible = false;
            idLabel.Visible = false;
            nameTextBox.Visible = true;
            dateTextBox.Visible = true;
            genderComboBox.Visible = true;
            jobTitleComboBox.Visible = true;
            subunitComboBox.Visible = true;
            attributeLabel.Visible = true;

            genderLabel.Visible = true;
            jobTitleLabel.Visible = true;
            subunitLabel.Visible = true;

            attributeTextBox.Visible = true;

            nameTextBox.Clear();
            dateTextBox.Clear();
            genderComboBox.Items.Clear();
            jobTitleComboBox.Items.Clear();
            subunitComboBox.Items.Clear();
            attributeTextBox.Clear();

            genderComboBox.Items.AddRange(controller.GetGenders());
            jobTitleComboBox.Items.AddRange(controller.GetJobtitles());
            subunitComboBox.Items.AddRange(controller.GetSubunits());

           

            saveButton.Visible = true;
            cancelButton.Visible = true;
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            subunitComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            jobTitleComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void CancelEditing()
        {
            idLabel.Visible = false;
            nameTextBox.Visible = false;
            dateTextBox.Visible = false;
            genderComboBox.Visible = false;
            genderLabel.Visible = false;
            jobTitleComboBox.Visible = false;
            jobTitleLabel.Visible = false;
            subunitComboBox.Visible = false;
            subunitLabel.Visible = false;
            attributeLabel.Visible = false;
            attributeTextBox.Visible = false;

            nameTextBox.Clear();
            dateTextBox.Clear();
            genderComboBox.Items.Clear();
            jobTitleComboBox.Items.Clear();
            subunitComboBox.Items.Clear();
            attributeTextBox.Clear();

            genderComboBox.DropDownStyle = ComboBoxStyle.Simple;
            subunitComboBox.DropDownStyle = ComboBoxStyle.Simple;
            jobTitleComboBox.DropDownStyle = ComboBoxStyle.Simple;

            dataGridView.Enabled = true;
            secondComboBox.Enabled = true;
            selectionComboBox.Enabled = true;

            saveButton.Visible = false;
            cancelButton.Visible = false;
            deleteButton.Visible = false;

            creatingNewEmployee = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            controller.Delete(Convert.ToInt32(idLabel.Text.Split(' ')[1]));
            CancelEditing();
        }
    }
}
