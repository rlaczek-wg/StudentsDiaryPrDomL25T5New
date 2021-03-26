using StudentsDiary.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class Main : Form
    {
        private FileHelper<List<Student>> _fileHelper =
            new FileHelper<List<Student>>(Program.FilePath);

    

        public bool IsMaximize 
        { 
            get
            {
                return Settings.Default.isMaximize; 
            }
            set
            {
                Settings.Default.isMaximize = value;
            }
        }
            
        public Main()
        {
            InitializeComponent();
            RefreshDiary();
            SetColumnsHeader();

            cbGroupIdFilter.Items.Add("Wszyscy");
            cbGroupIdFilter.Items.Add("1A");
            cbGroupIdFilter.Items.Add("1B");
            cbGroupIdFilter.Items.Add("1C");

            if (IsMaximize)
            {
                WindowState = FormWindowState.Maximized;
            }


        }


        private void RefreshDiary()
        {
            var students = _fileHelper.DeserializeFromFile();
           //dgvDiary.DataSource = students;  //OK

            string selectedGroupId = cbGroupIdFilter.Text.ToString();

            var displayStudentsList = new List<Student>();

            if (selectedGroupId == "1A")
            {
                displayStudentsList = (List<Student>)(from x in students
                                                      where x.GroupId == selectedGroupId
                                                      select x).ToList();
                dgvDiary.DataSource = displayStudentsList;

            }
            else if (selectedGroupId == "1B")
            {
                displayStudentsList = (List<Student>)(from x in students
                                                      where x.GroupId == selectedGroupId
                                                      select x).ToList();
                dgvDiary.DataSource = displayStudentsList;
            }
            else if (selectedGroupId == "1C")
            {
                displayStudentsList = (List<Student>)(from x in students
                                                      where x.GroupId == selectedGroupId
                                                      select x).ToList();
                dgvDiary.DataSource = displayStudentsList;
            }
            else
            {
                dgvDiary.DataSource = students;

            }

        }

        private void SetColumnsHeader()
        {
        
            dgvDiary.Columns[0].HeaderText = "Number";
            dgvDiary.Columns[1].HeaderText = "Imie";
            dgvDiary.Columns[2].HeaderText = "Nazwisko";
            dgvDiary.Columns[3].HeaderText = "Uwagi";
            dgvDiary.Columns[4].HeaderText = "Matematyka";
            dgvDiary.Columns[5].HeaderText = "Technologia";
            dgvDiary.Columns[6].HeaderText = "Fizyka";
            dgvDiary.Columns[7].HeaderText = "Jezyk polski";
            dgvDiary.Columns[8].HeaderText = "Jezyk obcy";
            dgvDiary.Columns[9].HeaderText = "Dodakowe zajecia";
            dgvDiary.Columns[10].HeaderText = "Klasa";
                 
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEitStudent = new AddEditStudent();
            addEitStudent.FormClosing += addEitStudent_FormClosing;
            addEitStudent.ShowDialog();
        }

        private void addEitStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshDiary();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prosze zaznacz ucznia, ktorego dane chcesz edytowac");
                return;
            }

            var addEitStudent = new AddEditStudent(
                Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));
            addEitStudent.FormClosing += addEitStudent_FormClosing;
            addEitStudent.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prosze zaznacz ucznia, ktorego dane chcesz usunac");
                return;
            }

            var selectedStudent = dgvDiary.SelectedRows[0];  //Zaznaczony student
           var confirmDelete = 
                MessageBox.Show("Czy na pewno chcesz usunac ucznia" + selectedStudent.Cells[1].Value.ToString() +
           " "+ selectedStudent.Cells[2].Value.ToString().Trim(), 
           "Usuwanie ucznia", MessageBoxButtons.OKCancel);


            if (confirmDelete == DialogResult.OK)
            {
                DeleteStudent(Convert.ToInt32(selectedStudent.Cells[0].Value));
                RefreshDiary();
            }

        }

        private void DeleteStudent(int id)
        {
            var students = _fileHelper.DeserializeFromFile();
            students.RemoveAll(x => x.Id == id);
            _fileHelper.SerializeToFile(students);
          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDiary();

        }

        private void dgvDiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                IsMaximize = true;
            }
            else
            {
                IsMaximize = false;
            }

            Settings.Default.Save();
        }
    }
}
