using System;
using System.Windows.Forms;
using MySqlConnector;
using students.dao;
using students.models;

namespace students
{
    public partial class Form1 : Form
    {
        private int _currentCareer;
        private int _currentDiscipline;
        private int _currentCourse;

        public Form1()
        {
            InitializeComponent();
            _currentCareer = -1;
            _currentDiscipline = -1;
            _currentCourse = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataGridsView();
        }

        private void PopulateDataGridsView()
        {
            var careers = CarreraDao.GetAll();
            foreach (var career in careers)
            {
                dataGridViewCareer.Rows.Add(
                    career.IdCarrera,
                    career.Descripcion
                );
                comboCareer.Items.Add(career.IdCarrera);
            }

            var disciplines = DisciplinaDao.GetAll();
            foreach (var discipline in disciplines)
            {
                dataGridViewDiscipline.Rows.Add(
                    discipline.IdDisciplina,
                    discipline.Descripcion
                );
                comboDiscipline.Items.Add(discipline.IdDisciplina);
            }
            
            var courses = MateriaDao.GetAll();
            foreach (var course in courses)
            {
                dataGridViewCourse.Rows.Add(
                    course.IdMateria,
                    course.Nombre,
                    course.Hp,
                    course.Ht,
                    course.IdCarrera,
                    course.IdDisciplina
                );
            }
        }

        private void ShowCustomError(string message)
        {
            MessageBox.Show(
                message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private void ShowErrorMessage()
        {
            MessageBox.Show(
                "Llene todos los campos necesarios.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private void ShowSuccessMessage()
        {
            MessageBox.Show(
                "Se completo la tarea con exito.",
                "Ok",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private DialogResult ShowConfirmationMessage()
        {
            return MessageBox.Show("Desea continuar con esta operacion?", "Espere", MessageBoxButtons.YesNo);
        }

        ///////////////////////// Career methods /////////////////////////////////
        private void CleanCareerForm()
        {
            textBoxIdCareer.Text = "";
            textBoxDescriptionCareer.Text = "";
            _currentCareer = -1;
            textBoxIdCareer.Enabled = true;
        }

        private void SaveCareerForm()
        {
            CarreraDao.Insert(new Carrera
            {
                IdCarrera = textBoxIdCareer.Text,
                Descripcion = textBoxDescriptionCareer.Text,
            });
            dataGridViewCareer.Rows.Add(textBoxIdCareer.Text, textBoxDescriptionCareer.Text);
            comboCareer.Items.Add(textBoxIdCareer.Text);
        }

        private void UpdateCareerForm()
        {
            var carrera = new Carrera
            {
                IdCarrera = textBoxIdCareer.Text,
                Descripcion = textBoxDescriptionCareer.Text,
            };
            CarreraDao.Update(carrera);
            comboCareer.Items[_currentCareer] = textBoxIdCareer.Text;
            dataGridViewCareer.Rows[_currentCareer].Cells[1].Value = carrera.Descripcion;
        }

        private void btnSaveCareer_Click(object sender, EventArgs e)
        {
            if (textBoxIdCareer.Text.Trim() != "" && textBoxDescriptionCareer.Text.Trim() != "")
            {
                try
                {
                    if (_currentCareer > -1)
                    {
                        UpdateCareerForm();
                    }
                    else
                    {
                        SaveCareerForm();
                    }

                    ShowSuccessMessage();
                    CleanCareerForm();
                    return;
                }
                catch (MySqlException exception)
                {
                    ShowCustomError(exception.Message);
                    return;
                }
            }

            ShowErrorMessage();
        }

        private void dataGridViewCareer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentCareer = e.RowIndex;
            textBoxIdCareer.Text = dataGridViewCareer.Rows[_currentCareer].Cells[0].Value.ToString();
            textBoxDescriptionCareer.Text = dataGridViewCareer.Rows[_currentCareer].Cells[1].Value.ToString();
            textBoxIdCareer.Enabled = false;
        }

        private void btnUpdateCareer_Click(object sender, EventArgs e)
        {
            CleanCareerForm();
        }

        private void btnDeleteCareer_Click(object sender, EventArgs e)
        {
            if (_currentCareer > -1 && ShowConfirmationMessage() == DialogResult.Yes)
            {
                try
                {
                    CarreraDao.Delete(dataGridViewCareer.Rows[_currentCareer].Cells[0].Value.ToString());
                    dataGridViewCareer.Rows.RemoveAt(_currentCareer);
                    comboCareer.Items.RemoveAt(_currentCareer);
                    ShowSuccessMessage();
                }
                catch (Exception exception)
                {
                    ShowCustomError(exception.Message);
                }
                CleanCareerForm();
            }
        }
        ///////////////////////// Career methods /////////////////////////////////

        ///////////////////////// Discipline methods /////////////////////////////
        private void CleanDisciplineForm()
        {
            textBoxIdDisipline.Text = "";
            textBoxDescriptionDiscipline.Text = "";
            _currentDiscipline = -1;
            textBoxIdDisipline.Enabled = true;
        }

        private void SaveDisciplineForm()
        {
            DisciplinaDao.Insert(new Disciplina
            {
                IdDisciplina = textBoxIdDisipline.Text,
                Descripcion = textBoxDescriptionDiscipline.Text,
            });
            dataGridViewDiscipline.Rows.Add(textBoxIdDisipline.Text, textBoxDescriptionDiscipline.Text);
            comboDiscipline.Items.Add(textBoxIdDisipline.Text);
        }

        private void UpdateDisciplineForm()
        {
            var discipline = new Disciplina
            {
                IdDisciplina = textBoxIdDisipline.Text,
                Descripcion = textBoxDescriptionDiscipline.Text,
            };
            DisciplinaDao.Update(discipline);
            comboDiscipline.Items[_currentDiscipline] = textBoxIdDisipline.Text;
            dataGridViewDiscipline.Rows[_currentDiscipline].Cells[1].Value = textBoxDescriptionDiscipline.Text;
        }

        private void btnSaveDiscipline_Click(object sender, EventArgs e)
        {
            if (textBoxIdDisipline.Text.Trim() != "" && textBoxDescriptionDiscipline.Text.Trim() != "")
            {
                try
                {
                    if (_currentDiscipline > -1)
                    {
                        UpdateDisciplineForm();
                    }
                    else
                    {
                        SaveDisciplineForm();
                    }

                    ShowSuccessMessage();
                    CleanDisciplineForm();
                    return;
                }
                catch (MySqlException exception)
                {
                    ShowCustomError(exception.Message);
                    return;
                }
            }

            ShowErrorMessage();
        }

        private void dataGridViewDiscipline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentDiscipline = e.RowIndex;
            var cells = dataGridViewDiscipline.Rows[_currentDiscipline].Cells;
            textBoxIdDisipline.Text = cells[0].Value.ToString();
            textBoxDescriptionDiscipline.Text = cells[1].Value.ToString();
            textBoxIdDisipline.Enabled = false;
        }

        private void btnCancelDiscipline_Click(object sender, EventArgs e)
        {
            CleanDisciplineForm();
        }

        private void btnDeleteDiscipline_Click(object sender, EventArgs e)
        {
            if (_currentDiscipline > -1 && ShowConfirmationMessage() == DialogResult.Yes)
            {
                try
                {
                    var id = dataGridViewDiscipline.Rows[_currentDiscipline].Cells[0].Value.ToString();
                    DisciplinaDao.Delete(id);
                    dataGridViewDiscipline.Rows.RemoveAt(_currentDiscipline);
                    comboDiscipline.Items.RemoveAt(_currentDiscipline);
                    ShowSuccessMessage();
                }
                catch (Exception exception)
                {
                    ShowCustomError(exception.Message);
                }
                CleanDisciplineForm();
            }
        }

        ///////////////////////// Discipline methods /////////////////////////////

        ///////////////////////// Course methods /////////////////////////////
        private void textBoxHTCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxHPCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        ///////////////////////// Course methods /////////////////////////////
        private void CleanCourseForm()
        {
            textBoxCourseId.Text = "";
            textBoxCourseName.Text = "";
            textBoxHPCourse.Text = "";
            textBoxHTCourse.Text = "";
            comboCareer.Text = "";
            comboDiscipline.Text = "";
            _currentCourse = -1;
            textBoxCourseId.Enabled = true;
        }

        private void SaveCourseForm()
        {
            MateriaDao.Insert(new Materia
            {
                IdMateria = textBoxCourseId.Text,
                Nombre = textBoxCourseName.Text,
                Hp = int.Parse(textBoxHPCourse.Text),
                Ht = int.Parse(textBoxHTCourse.Text),
                IdCarrera = comboCareer.Text,
                IdDisciplina = comboDiscipline.Text,
            });
            dataGridViewCourse.Rows.Add(
                textBoxCourseId.Text,
                textBoxCourseName.Text,
                textBoxHTCourse.Text,
                textBoxHPCourse.Text,
                comboCareer.Text,
                comboDiscipline.Text
            );
        }

        private void UpdateCourseForm()
        {
            var course = new Materia
            {
                IdMateria = textBoxCourseId.Text,
                Nombre = textBoxCourseName.Text,
                Hp = int.Parse(textBoxHPCourse.Text),
                Ht = int.Parse(textBoxHTCourse.Text),
                IdCarrera = comboCareer.Text,
                IdDisciplina = comboDiscipline.Text,
            };
            MateriaDao.Update(course);
            dataGridViewDiscipline.Rows[_currentDiscipline].Cells[1].Value = textBoxCourseName.Text;
            dataGridViewDiscipline.Rows[_currentDiscipline].Cells[2].Value = textBoxHTCourse.Text;
            dataGridViewDiscipline.Rows[_currentDiscipline].Cells[3].Value = textBoxHPCourse.Text;
            dataGridViewDiscipline.Rows[_currentDiscipline].Cells[4].Value = comboCareer.Text;
            dataGridViewDiscipline.Rows[_currentDiscipline].Cells[5].Value = comboDiscipline.Text;
        }


        private bool ValidateCourseForm()
        {
            return textBoxCourseId.Text != "" &&
                   textBoxCourseName.Text != "" &&
                   textBoxHPCourse.Text != "" &&
                   textBoxHTCourse.Text != "" &&
                   comboCareer.Text != "" &&
                   comboDiscipline.Text != "";
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            if (ValidateCourseForm())
            {
                try
                {
                    if (_currentCourse > -1)
                    {
                        UpdateCourseForm();
                    }
                    else
                    {
                        SaveCourseForm();
                    }

                    ShowSuccessMessage();
                    CleanCourseForm();
                    return;
                }
                catch (MySqlException exception)
                {
                    ShowCustomError(exception.Message);
                    return;
                }
            }

            ShowErrorMessage();
        }

        private void dataGridViewCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentCourse = e.RowIndex;
            var cells = dataGridViewCourse.Rows[_currentCourse].Cells;
            textBoxCourseId.Text = cells[0].Value.ToString();
            textBoxCourseName.Text = cells[1].Value.ToString();
            textBoxHTCourse.Text = cells[2].Value.ToString();
            textBoxHPCourse.Text = cells[3].Value.ToString();
            comboCareer.Text = cells[4].Value.ToString();
            comboDiscipline.Text = cells[5].Value.ToString();
            textBoxCourseId.Enabled = false;
        }

        private void btnCancelCourse_Click(object sender, EventArgs e)
        {
            CleanCourseForm();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (_currentCourse > -1 && ShowConfirmationMessage() == DialogResult.Yes)
            {
                try
                {
                    var id = dataGridViewCourse.Rows[_currentCourse].Cells[0].Value.ToString();
                    MateriaDao.Delete(id);
                    dataGridViewCourse.Rows.RemoveAt(_currentCourse);
                    ShowSuccessMessage();
                }
                catch (Exception exception)
                {
                    ShowCustomError(exception.Message);
                }
                CleanCourseForm();
            }
        }
        ///////////////////////// Course methods /////////////////////////////
    }
}