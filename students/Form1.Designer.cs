namespace students
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentsGroupCareer = new System.Windows.Forms.GroupBox();
            this.btnCancelCareer = new System.Windows.Forms.Button();
            this.btnDeleteCareer = new System.Windows.Forms.Button();
            this.dataGridViewCareer = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDescriptionCareer = new System.Windows.Forms.Label();
            this.textBoxDescriptionCareer = new System.Windows.Forms.TextBox();
            this.labelIdCareer = new System.Windows.Forms.Label();
            this.btnSaveCareer = new System.Windows.Forms.Button();
            this.textBoxIdCareer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelDiscipline = new System.Windows.Forms.Button();
            this.btnDeleteDiscipline = new System.Windows.Forms.Button();
            this.labelDescriptionDiscipline = new System.Windows.Forms.Label();
            this.textBoxDescriptionDiscipline = new System.Windows.Forms.TextBox();
            this.labelIdDiscipline = new System.Windows.Forms.Label();
            this.btnSaveDiscipline = new System.Windows.Forms.Button();
            this.textBoxIdDisipline = new System.Windows.Forms.TextBox();
            this.dataGridViewDiscipline = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCareer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.comboDiscipline = new System.Windows.Forms.ComboBox();
            this.comboCareer = new System.Windows.Forms.ComboBox();
            this.labelHPCourse = new System.Windows.Forms.Label();
            this.textBoxHPCourse = new System.Windows.Forms.TextBox();
            this.labelHTCourse = new System.Windows.Forms.Label();
            this.textBoxHTCourse = new System.Windows.Forms.TextBox();
            this.labelNameCourse = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.labelIdCourse = new System.Windows.Forms.Label();
            this.btnSaveCourse = new System.Windows.Forms.Button();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.studentsGroupCareer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCareer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscipline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsGroupCareer
            // 
            this.studentsGroupCareer.Controls.Add(this.btnCancelCareer);
            this.studentsGroupCareer.Controls.Add(this.btnDeleteCareer);
            this.studentsGroupCareer.Controls.Add(this.dataGridViewCareer);
            this.studentsGroupCareer.Controls.Add(this.labelDescriptionCareer);
            this.studentsGroupCareer.Controls.Add(this.textBoxDescriptionCareer);
            this.studentsGroupCareer.Controls.Add(this.labelIdCareer);
            this.studentsGroupCareer.Controls.Add(this.btnSaveCareer);
            this.studentsGroupCareer.Controls.Add(this.textBoxIdCareer);
            this.studentsGroupCareer.Location = new System.Drawing.Point(12, 12);
            this.studentsGroupCareer.Name = "studentsGroupCareer";
            this.studentsGroupCareer.Size = new System.Drawing.Size(1008, 197);
            this.studentsGroupCareer.TabIndex = 0;
            this.studentsGroupCareer.TabStop = false;
            this.studentsGroupCareer.Text = "Carreras";
            // 
            // btnCancelCareer
            // 
            this.btnCancelCareer.Location = new System.Drawing.Point(331, 141);
            this.btnCancelCareer.Name = "btnCancelCareer";
            this.btnCancelCareer.Size = new System.Drawing.Size(107, 34);
            this.btnCancelCareer.TabIndex = 4;
            this.btnCancelCareer.Text = "Cancelar";
            this.btnCancelCareer.UseVisualStyleBackColor = true;
            this.btnCancelCareer.Click += new System.EventHandler(this.btnUpdateCareer_Click);
            // 
            // btnDeleteCareer
            // 
            this.btnDeleteCareer.Location = new System.Drawing.Point(169, 141);
            this.btnDeleteCareer.Name = "btnDeleteCareer";
            this.btnDeleteCareer.Size = new System.Drawing.Size(113, 34);
            this.btnDeleteCareer.TabIndex = 3;
            this.btnDeleteCareer.Text = "Eliminar";
            this.btnDeleteCareer.UseVisualStyleBackColor = true;
            this.btnDeleteCareer.Click += new System.EventHandler(this.btnDeleteCareer_Click);
            // 
            // dataGridViewCareer
            // 
            this.dataGridViewCareer.AllowUserToAddRows = false;
            this.dataGridViewCareer.AllowUserToDeleteRows = false;
            this.dataGridViewCareer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCareer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idCol, this.dniCol });
            this.dataGridViewCareer.Location = new System.Drawing.Point(444, 19);
            this.dataGridViewCareer.Name = "dataGridViewCareer";
            this.dataGridViewCareer.ReadOnly = true;
            this.dataGridViewCareer.Size = new System.Drawing.Size(546, 156);
            this.dataGridViewCareer.TabIndex = 19;
            this.dataGridViewCareer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCareer_CellContentClick);
            this.dataGridViewCareer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCareer_CellContentClick);
            this.dataGridViewCareer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCareer_CellContentClick);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            // 
            // dniCol
            // 
            this.dniCol.HeaderText = "Descripción";
            this.dniCol.Name = "dniCol";
            this.dniCol.ReadOnly = true;
            this.dniCol.Width = 400;
            // 
            // labelDescriptionCareer
            // 
            this.labelDescriptionCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionCareer.Location = new System.Drawing.Point(6, 96);
            this.labelDescriptionCareer.Name = "labelDescriptionCareer";
            this.labelDescriptionCareer.Size = new System.Drawing.Size(90, 23);
            this.labelDescriptionCareer.TabIndex = 11;
            this.labelDescriptionCareer.Text = "Descripción:";
            // 
            // textBoxDescriptionCareer
            // 
            this.textBoxDescriptionCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescriptionCareer.Location = new System.Drawing.Point(102, 96);
            this.textBoxDescriptionCareer.Name = "textBoxDescriptionCareer";
            this.textBoxDescriptionCareer.Size = new System.Drawing.Size(336, 26);
            this.textBoxDescriptionCareer.TabIndex = 1;
            // 
            // labelIdCareer
            // 
            this.labelIdCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCareer.Location = new System.Drawing.Point(6, 46);
            this.labelIdCareer.Name = "labelIdCareer";
            this.labelIdCareer.Size = new System.Drawing.Size(79, 23);
            this.labelIdCareer.TabIndex = 7;
            this.labelIdCareer.Text = "ID:";
            // 
            // btnSaveCareer
            // 
            this.btnSaveCareer.Location = new System.Drawing.Point(6, 141);
            this.btnSaveCareer.Name = "btnSaveCareer";
            this.btnSaveCareer.Size = new System.Drawing.Size(107, 34);
            this.btnSaveCareer.TabIndex = 2;
            this.btnSaveCareer.Text = "Guardar";
            this.btnSaveCareer.UseVisualStyleBackColor = true;
            this.btnSaveCareer.Click += new System.EventHandler(this.btnSaveCareer_Click);
            // 
            // textBoxIdCareer
            // 
            this.textBoxIdCareer.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIdCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdCareer.Location = new System.Drawing.Point(102, 43);
            this.textBoxIdCareer.MaxLength = 3;
            this.textBoxIdCareer.Name = "textBoxIdCareer";
            this.textBoxIdCareer.Size = new System.Drawing.Size(336, 26);
            this.textBoxIdCareer.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelDiscipline);
            this.groupBox1.Controls.Add(this.btnDeleteDiscipline);
            this.groupBox1.Controls.Add(this.labelDescriptionDiscipline);
            this.groupBox1.Controls.Add(this.textBoxDescriptionDiscipline);
            this.groupBox1.Controls.Add(this.labelIdDiscipline);
            this.groupBox1.Controls.Add(this.btnSaveDiscipline);
            this.groupBox1.Controls.Add(this.textBoxIdDisipline);
            this.groupBox1.Controls.Add(this.dataGridViewDiscipline);
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disciplinas";
            // 
            // btnCancelDiscipline
            // 
            this.btnCancelDiscipline.Location = new System.Drawing.Point(331, 141);
            this.btnCancelDiscipline.Name = "btnCancelDiscipline";
            this.btnCancelDiscipline.Size = new System.Drawing.Size(107, 34);
            this.btnCancelDiscipline.TabIndex = 9;
            this.btnCancelDiscipline.Text = "Cancelar";
            this.btnCancelDiscipline.UseVisualStyleBackColor = true;
            this.btnCancelDiscipline.Click += new System.EventHandler(this.btnCancelDiscipline_Click);
            // 
            // btnDeleteDiscipline
            // 
            this.btnDeleteDiscipline.Location = new System.Drawing.Point(169, 141);
            this.btnDeleteDiscipline.Name = "btnDeleteDiscipline";
            this.btnDeleteDiscipline.Size = new System.Drawing.Size(113, 34);
            this.btnDeleteDiscipline.TabIndex = 8;
            this.btnDeleteDiscipline.Text = "Eliminar";
            this.btnDeleteDiscipline.UseVisualStyleBackColor = true;
            this.btnDeleteDiscipline.Click += new System.EventHandler(this.btnDeleteDiscipline_Click);
            // 
            // labelDescriptionDiscipline
            // 
            this.labelDescriptionDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionDiscipline.Location = new System.Drawing.Point(6, 96);
            this.labelDescriptionDiscipline.Name = "labelDescriptionDiscipline";
            this.labelDescriptionDiscipline.Size = new System.Drawing.Size(90, 23);
            this.labelDescriptionDiscipline.TabIndex = 11;
            this.labelDescriptionDiscipline.Text = "Descripción:";
            // 
            // textBoxDescriptionDiscipline
            // 
            this.textBoxDescriptionDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescriptionDiscipline.Location = new System.Drawing.Point(102, 96);
            this.textBoxDescriptionDiscipline.Name = "textBoxDescriptionDiscipline";
            this.textBoxDescriptionDiscipline.Size = new System.Drawing.Size(336, 26);
            this.textBoxDescriptionDiscipline.TabIndex = 6;
            // 
            // labelIdDiscipline
            // 
            this.labelIdDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdDiscipline.Location = new System.Drawing.Point(6, 46);
            this.labelIdDiscipline.Name = "labelIdDiscipline";
            this.labelIdDiscipline.Size = new System.Drawing.Size(79, 23);
            this.labelIdDiscipline.TabIndex = 7;
            this.labelIdDiscipline.Text = "ID:";
            // 
            // btnSaveDiscipline
            // 
            this.btnSaveDiscipline.Location = new System.Drawing.Point(6, 141);
            this.btnSaveDiscipline.Name = "btnSaveDiscipline";
            this.btnSaveDiscipline.Size = new System.Drawing.Size(107, 34);
            this.btnSaveDiscipline.TabIndex = 7;
            this.btnSaveDiscipline.Text = "Guardar";
            this.btnSaveDiscipline.UseVisualStyleBackColor = true;
            this.btnSaveDiscipline.Click += new System.EventHandler(this.btnSaveDiscipline_Click);
            // 
            // textBoxIdDisipline
            // 
            this.textBoxIdDisipline.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIdDisipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdDisipline.Location = new System.Drawing.Point(102, 43);
            this.textBoxIdDisipline.MaxLength = 3;
            this.textBoxIdDisipline.Name = "textBoxIdDisipline";
            this.textBoxIdDisipline.Size = new System.Drawing.Size(336, 26);
            this.textBoxIdDisipline.TabIndex = 5;
            // 
            // dataGridViewDiscipline
            // 
            this.dataGridViewDiscipline.AllowUserToAddRows = false;
            this.dataGridViewDiscipline.AllowUserToDeleteRows = false;
            this.dataGridViewDiscipline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscipline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dataGridViewTextBoxColumn3, this.dataGridViewTextBoxColumn4 });
            this.dataGridViewDiscipline.Location = new System.Drawing.Point(444, 19);
            this.dataGridViewDiscipline.Name = "dataGridViewDiscipline";
            this.dataGridViewDiscipline.ReadOnly = true;
            this.dataGridViewDiscipline.Size = new System.Drawing.Size(546, 156);
            this.dataGridViewDiscipline.TabIndex = 20;
            this.dataGridViewDiscipline.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDiscipline_CellContentClick);
            this.dataGridViewDiscipline.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDiscipline_CellContentClick);
            this.dataGridViewDiscipline.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDiscipline_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 400;
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.AllowUserToAddRows = false;
            this.dataGridViewCourse.AllowUserToDeleteRows = false;
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dataGridViewTextBoxColumn1, this.ColumnName, this.ColumnHT, this.ColumnHP, this.ColumnCareer, this.ColumnDiscipline });
            this.dataGridViewCourse.Location = new System.Drawing.Point(444, 13);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.ReadOnly = true;
            this.dataGridViewCourse.Size = new System.Drawing.Size(546, 263);
            this.dataGridViewCourse.TabIndex = 21;
            this.dataGridViewCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourse_CellContentClick);
            this.dataGridViewCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourse_CellContentClick);
            this.dataGridViewCourse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourse_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Nombre";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnHT
            // 
            this.ColumnHT.HeaderText = "HT";
            this.ColumnHT.Name = "ColumnHT";
            this.ColumnHT.ReadOnly = true;
            // 
            // ColumnHP
            // 
            this.ColumnHP.HeaderText = "HP";
            this.ColumnHP.Name = "ColumnHP";
            this.ColumnHP.ReadOnly = true;
            // 
            // ColumnCareer
            // 
            this.ColumnCareer.HeaderText = "Carrera";
            this.ColumnCareer.Name = "ColumnCareer";
            this.ColumnCareer.ReadOnly = true;
            // 
            // ColumnDiscipline
            // 
            this.ColumnDiscipline.HeaderText = "Disciplina";
            this.ColumnDiscipline.Name = "ColumnDiscipline";
            this.ColumnDiscipline.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelCourse);
            this.groupBox2.Controls.Add(this.btnDeleteCourse);
            this.groupBox2.Controls.Add(this.comboDiscipline);
            this.groupBox2.Controls.Add(this.comboCareer);
            this.groupBox2.Controls.Add(this.dataGridViewCourse);
            this.groupBox2.Controls.Add(this.labelHPCourse);
            this.groupBox2.Controls.Add(this.textBoxHPCourse);
            this.groupBox2.Controls.Add(this.labelHTCourse);
            this.groupBox2.Controls.Add(this.textBoxHTCourse);
            this.groupBox2.Controls.Add(this.labelNameCourse);
            this.groupBox2.Controls.Add(this.textBoxCourseName);
            this.groupBox2.Controls.Add(this.labelIdCourse);
            this.groupBox2.Controls.Add(this.btnSaveCourse);
            this.groupBox2.Controls.Add(this.textBoxCourseId);
            this.groupBox2.Location = new System.Drawing.Point(12, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1008, 294);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Materias";
            // 
            // btnCancelCourse
            // 
            this.btnCancelCourse.Location = new System.Drawing.Point(331, 242);
            this.btnCancelCourse.Name = "btnCancelCourse";
            this.btnCancelCourse.Size = new System.Drawing.Size(107, 34);
            this.btnCancelCourse.TabIndex = 18;
            this.btnCancelCourse.Text = "Cancelar";
            this.btnCancelCourse.UseVisualStyleBackColor = true;
            this.btnCancelCourse.Click += new System.EventHandler(this.btnCancelCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(169, 242);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(107, 34);
            this.btnDeleteCourse.TabIndex = 17;
            this.btnDeleteCourse.Text = "Eliminar";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // comboDiscipline
            // 
            this.comboDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDiscipline.FormattingEnabled = true;
            this.comboDiscipline.Location = new System.Drawing.Point(220, 197);
            this.comboDiscipline.Name = "comboDiscipline";
            this.comboDiscipline.Size = new System.Drawing.Size(218, 28);
            this.comboDiscipline.TabIndex = 15;
            this.comboDiscipline.Text = "Seleccione una disciplina";
            // 
            // comboCareer
            // 
            this.comboCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCareer.FormattingEnabled = true;
            this.comboCareer.Location = new System.Drawing.Point(6, 197);
            this.comboCareer.Name = "comboCareer";
            this.comboCareer.Size = new System.Drawing.Size(190, 28);
            this.comboCareer.TabIndex = 14;
            this.comboCareer.Text = "Seleccione una carrera";
            // 
            // labelHPCourse
            // 
            this.labelHPCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHPCourse.Location = new System.Drawing.Point(220, 146);
            this.labelHPCourse.Name = "labelHPCourse";
            this.labelHPCourse.Size = new System.Drawing.Size(33, 23);
            this.labelHPCourse.TabIndex = 15;
            this.labelHPCourse.Text = "HP:";
            // 
            // textBoxHPCourse
            // 
            this.textBoxHPCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHPCourse.Location = new System.Drawing.Point(269, 146);
            this.textBoxHPCourse.Name = "textBoxHPCourse";
            this.textBoxHPCourse.Size = new System.Drawing.Size(169, 26);
            this.textBoxHPCourse.TabIndex = 13;
            this.textBoxHPCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHPCourse_KeyPress);
            // 
            // labelHTCourse
            // 
            this.labelHTCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHTCourse.Location = new System.Drawing.Point(6, 149);
            this.labelHTCourse.Name = "labelHTCourse";
            this.labelHTCourse.Size = new System.Drawing.Size(33, 23);
            this.labelHTCourse.TabIndex = 13;
            this.labelHTCourse.Text = "HT:";
            // 
            // textBoxHTCourse
            // 
            this.textBoxHTCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHTCourse.Location = new System.Drawing.Point(45, 146);
            this.textBoxHTCourse.Name = "textBoxHTCourse";
            this.textBoxHTCourse.Size = new System.Drawing.Size(151, 26);
            this.textBoxHTCourse.TabIndex = 12;
            this.textBoxHTCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHTCourse_KeyPress);
            // 
            // labelNameCourse
            // 
            this.labelNameCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameCourse.Location = new System.Drawing.Point(6, 96);
            this.labelNameCourse.Name = "labelNameCourse";
            this.labelNameCourse.Size = new System.Drawing.Size(90, 23);
            this.labelNameCourse.TabIndex = 11;
            this.labelNameCourse.Text = "Nombre:";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.Location = new System.Drawing.Point(102, 96);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(336, 26);
            this.textBoxCourseName.TabIndex = 11;
            // 
            // labelIdCourse
            // 
            this.labelIdCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCourse.Location = new System.Drawing.Point(6, 46);
            this.labelIdCourse.Name = "labelIdCourse";
            this.labelIdCourse.Size = new System.Drawing.Size(79, 23);
            this.labelIdCourse.TabIndex = 7;
            this.labelIdCourse.Text = "ID:";
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.Location = new System.Drawing.Point(6, 242);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(107, 34);
            this.btnSaveCourse.TabIndex = 16;
            this.btnSaveCourse.Text = "Guardar";
            this.btnSaveCourse.UseVisualStyleBackColor = true;
            this.btnSaveCourse.Click += new System.EventHandler(this.btnSaveCourse_Click);
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxCourseId.Location = new System.Drawing.Point(102, 43);
            this.textBoxCourseId.MaxLength = 3;
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(336, 26);
            this.textBoxCourseId.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentsGroupCareer);
            this.Name = "Form1";
            this.Text = "Escuela";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.studentsGroupCareer.ResumeLayout(false);
            this.studentsGroupCareer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCareer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscipline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnCancelCourse;

        private System.Windows.Forms.Button btnCancelDiscipline;

        private System.Windows.Forms.Button btnCancelCareer;

        private System.Windows.Forms.ComboBox comboCareer;
        private System.Windows.Forms.ComboBox comboDiscipline;

        private System.Windows.Forms.Button btnDeleteCareer;
        private System.Windows.Forms.GroupBox studentsGroupCareer;
        private System.Windows.Forms.Button btnDeleteDiscipline;

        private System.Windows.Forms.TextBox textBoxIdDisipline;
        private System.Windows.Forms.TextBox textBoxDescriptionDiscipline;
        private System.Windows.Forms.Button btnSaveDiscipline;

        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCareer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscipline;

        private System.Windows.Forms.Label labelIdDiscipline;
        private System.Windows.Forms.Label labelDescriptionDiscipline;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label labelNameCourse;
        private System.Windows.Forms.TextBox textBoxCourseId;
        private System.Windows.Forms.Label labelHTCourse;
        private System.Windows.Forms.TextBox textBoxHTCourse;
        private System.Windows.Forms.TextBox textBoxHPCourse;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label labelHPCourse;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label labelIdCourse;
        private System.Windows.Forms.Button btnSaveCourse;

        private System.Windows.Forms.Button btnSaveCareer;

        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniCol;
        private System.Windows.Forms.DataGridView dataGridViewCareer;
        private System.Windows.Forms.Label labelDescriptionCareer;
        private System.Windows.Forms.Label labelIdCareer;

        #endregion
        private System.Windows.Forms.TextBox textBoxIdCareer;
        private System.Windows.Forms.TextBox textBoxDescriptionCareer;
    }
}

