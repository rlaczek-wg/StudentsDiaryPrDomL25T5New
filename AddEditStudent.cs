using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentsDiary
{
    public partial class AddEditStudent : Form
    {

        private int _studentId;
        private Student _student;

        private FileHelper<List<Student>> _fileHelper =
            new FileHelper<List<Student>>(Program.FilePath);



        public AddEditStudent(int id=0)  //Wartosc domyslna w konstruktorze
        {
            InitializeComponent();
            _studentId = id;

            GetStudentData();
            tbFirstName.Select();

            cbGroupId.Items.Add("1A");
            cbGroupId.Items.Add("1B");
            cbGroupId.Items.Add("1C");
            
        }

     

        private void GetStudentData()
        {
            if (_studentId != 0)
            {
                Text = "Edytowanie danych ucznia";

                var students = _fileHelper.DeserializeFromFile();
                _student = students.FirstOrDefault(x => x.Id == _studentId);

                if (_student == null)
                    throw new Exception("Brak uzytkownika o podanym Id");
                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _student.Id.ToString();
            tbFirstName.Text = _student.FirstName;
            tbLastName.Text = _student.LastName;
            cbGroupId.Text = _student.GroupId;
            tbMath.Text = _student.Math;
            tbTechnology.Text = _student.Technology;
            tbPolishLang.Text = _student.ForeignLang;
            chbExtraActivities.Checked = _student.HaveExtraActivities;
            rtbComments.Text = _student.Comments;
            cbGroupId.Text = _student.GroupId;

        }


        


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();

            if (_studentId !=0)
                students.RemoveAll(x => x.Id == _studentId);
            else
                AssignIdToNewStudent(students);

            AddNewUserToList(students);

            _fileHelper.SerializeToFile(students);
           await LongProcessAsync();

            Close();
        }

        //Metoda asynchroniczna
        private async Task LongProcessAsync()
        {
            await Task.Run(() =>
             {
                 Thread.Sleep(3000);
             });
        
        }


        private void AddNewUserToList(List<Student> students)
        {
            var student = new Student
            {
                Id = _studentId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Comments = rtbComments.Text,
                ForeignLang = tbForeignLang.Text,
                Math = tbMath.Text,
                Physics = tbPhysic.Text,
                PolishLang = tbPolishLang.Text,
                Technology = tbTechnology.Text,
                HaveExtraActivities = chbExtraActivities.Checked,
                GroupId = cbGroupId.Text
            };
            students.Add(student);
        }


        private void AssignIdToNewStudent(List<Student> students)
        {
            var studentWithHighestId = students.OrderByDescending(x => x.Id).FirstOrDefault();

            _studentId = studentWithHighestId == null ? 1 : studentWithHighestId.Id + 1;
            /*Mozna tez:
            var studentid = 0;
            if (studentWithHighestId == null)
            {
             studentid = 1;
             }
            else
            {
            studentid = studentWithHighestId.Id + 1;
            }  */

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
