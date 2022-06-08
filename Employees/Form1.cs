using System;
using System.Windows.Forms;
using Employees.Database;

namespace Employees
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var manager = new DatabaseManager();
            var a = manager.GetEmployees();
            //var worker = new Worker(0, "Кирилл Кириллов Кириллович", Gender.M, "30.06.2002", 1, JobTitle.Worker, "Сидоров Денис Васильевич");
            //manager.CreateEmployee(worker);
            //var c = a[2];
            //c.Name = "Кириллов Кирилл Кириллович";
            //manager.ChangeEmployee(c);
            //manager.DeleteEmployee(3);
            var b = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
