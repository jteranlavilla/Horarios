
namespace Horarios
{
    partial class frmConvertirHorario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConvertirHorario));
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.ofdHorario = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblArchivo = new System.Windows.Forms.TextBox();
            this.txtBloque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeparadorCampos = new System.Windows.Forms.TextBox();
            this.txtCaracterSeparador = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.INSTRUCTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO_GENERADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackHP = new System.Windows.Forms.TrackBar();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.btnGenerarHorarios = new System.Windows.Forms.Button();
            this.trackPorcentaje = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.chkBlackboard = new System.Windows.Forms.CheckBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fbdDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPorcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Location = new System.Drawing.Point(246, 22);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(34, 30);
            this.btnAbrirArchivo.TabIndex = 2;
            this.btnAbrirArchivo.Text = "...";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // ofdHorario
            // 
            this.ofdHorario.FileName = "Buscar archivo de horarios";
            this.ofdHorario.Filter = "Fichero (*.csv)|*.csv";
            this.ofdHorario.RestoreDirectory = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblArchivo);
            this.groupBox1.Controls.Add(this.txtBloque);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSeparadorCampos);
            this.groupBox1.Controls.Add(this.txtCaracterSeparador);
            this.groupBox1.Controls.Add(this.btnAbrirArchivo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 180);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivo CSV";
            // 
            // lblArchivo
            // 
            this.lblArchivo.Location = new System.Drawing.Point(14, 22);
            this.lblArchivo.Multiline = true;
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.ReadOnly = true;
            this.lblArchivo.Size = new System.Drawing.Size(226, 54);
            this.lblArchivo.TabIndex = 22;
            // 
            // txtBloque
            // 
            this.txtBloque.Location = new System.Drawing.Point(153, 82);
            this.txtBloque.MaxLength = 5;
            this.txtBloque.Name = "txtBloque";
            this.txtBloque.Size = new System.Drawing.Size(68, 23);
            this.txtBloque.TabIndex = 21;
            this.txtBloque.Text = "51P";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Prefijo Bloque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Separador de Valores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Separador de Columnas:";
            // 
            // txtSeparadorCampos
            // 
            this.txtSeparadorCampos.Location = new System.Drawing.Point(153, 140);
            this.txtSeparadorCampos.MaxLength = 1;
            this.txtSeparadorCampos.Name = "txtSeparadorCampos";
            this.txtSeparadorCampos.Size = new System.Drawing.Size(30, 23);
            this.txtSeparadorCampos.TabIndex = 17;
            this.txtSeparadorCampos.Text = "\"";
            // 
            // txtCaracterSeparador
            // 
            this.txtCaracterSeparador.Location = new System.Drawing.Point(153, 111);
            this.txtCaracterSeparador.MaxLength = 1;
            this.txtCaracterSeparador.Name = "txtCaracterSeparador";
            this.txtCaracterSeparador.Size = new System.Drawing.Size(30, 23);
            this.txtCaracterSeparador.TabIndex = 16;
            this.txtCaracterSeparador.Text = ";";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeight = 30;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Location = new System.Drawing.Point(306, 17);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 30;
            this.dgvDatos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvDatos.RowTemplate.Height = 20;
            this.dgvDatos.Size = new System.Drawing.Size(485, 214);
            this.dgvDatos.TabIndex = 17;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDetalles.Location = new System.Drawing.Point(25, 199);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(0, 15);
            this.lblDetalles.TabIndex = 18;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHorarios.ColumnHeadersHeight = 30;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.INSTRUCTOR,
            this.HORARIO_GENERADO});
            this.dgvHorarios.Location = new System.Drawing.Point(12, 338);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHorarios.RowHeadersVisible = false;
            this.dgvHorarios.RowHeadersWidth = 30;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvHorarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHorarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvHorarios.RowTemplate.Height = 20;
            this.dgvHorarios.Size = new System.Drawing.Size(779, 250);
            this.dgvHorarios.TabIndex = 23;
            this.dgvHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarios_CellContentClick);
            // 
            // INSTRUCTOR
            // 
            this.INSTRUCTOR.DataPropertyName = "INSTRUCTOR";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.INSTRUCTOR.DefaultCellStyle = dataGridViewCellStyle4;
            this.INSTRUCTOR.Frozen = true;
            this.INSTRUCTOR.HeaderText = "Nombre de Instructor";
            this.INSTRUCTOR.Name = "INSTRUCTOR";
            this.INSTRUCTOR.ReadOnly = true;
            this.INSTRUCTOR.Width = 250;
            // 
            // HORARIO_GENERADO
            // 
            this.HORARIO_GENERADO.DataPropertyName = "HORARIO_GENERADO";
            this.HORARIO_GENERADO.HeaderText = "Horario";
            this.HORARIO_GENERADO.Name = "HORARIO_GENERADO";
            this.HORARIO_GENERADO.ReadOnly = true;
            this.HORARIO_GENERADO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HORARIO_GENERADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HORARIO_GENERADO.Width = 500;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackHP);
            this.groupBox2.Controls.Add(this.txtHP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPorcentaje);
            this.groupBox2.Controls.Add(this.btnGenerarHorarios);
            this.groupBox2.Controls.Add(this.trackPorcentaje);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chkBlackboard);
            this.groupBox2.Controls.Add(this.dtpFin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpInicio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 106);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convertir horarios";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // trackHP
            // 
            this.trackHP.LargeChange = 1;
            this.trackHP.Location = new System.Drawing.Point(496, 51);
            this.trackHP.Maximum = 60;
            this.trackHP.Minimum = 15;
            this.trackHP.Name = "trackHP";
            this.trackHP.Size = new System.Drawing.Size(202, 45);
            this.trackHP.TabIndex = 35;
            this.trackHP.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackHP.Value = 60;
            this.trackHP.Scroll += new System.EventHandler(this.trackHP_Scroll);
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(466, 62);
            this.txtHP.Name = "txtHP";
            this.txtHP.ReadOnly = true;
            this.txtHP.Size = new System.Drawing.Size(24, 23);
            this.txtHP.TabIndex = 34;
            this.txtHP.Text = "45";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Hora Pedagógica:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(111, 62);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.ReadOnly = true;
            this.txtPorcentaje.Size = new System.Drawing.Size(24, 23);
            this.txtPorcentaje.TabIndex = 32;
            this.txtPorcentaje.Text = "60";
            // 
            // btnGenerarHorarios
            // 
            this.btnGenerarHorarios.Enabled = false;
            this.btnGenerarHorarios.Location = new System.Drawing.Point(632, 19);
            this.btnGenerarHorarios.Name = "btnGenerarHorarios";
            this.btnGenerarHorarios.Size = new System.Drawing.Size(141, 30);
            this.btnGenerarHorarios.TabIndex = 30;
            this.btnGenerarHorarios.Text = "Generar Horarios";
            this.btnGenerarHorarios.UseVisualStyleBackColor = true;
            this.btnGenerarHorarios.Click += new System.EventHandler(this.btnGenerarHorarios_Click);
            // 
            // trackPorcentaje
            // 
            this.trackPorcentaje.LargeChange = 1;
            this.trackPorcentaje.Location = new System.Drawing.Point(141, 51);
            this.trackPorcentaje.Maximum = 100;
            this.trackPorcentaje.Name = "trackPorcentaje";
            this.trackPorcentaje.Size = new System.Drawing.Size(202, 45);
            this.trackPorcentaje.TabIndex = 29;
            this.trackPorcentaje.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackPorcentaje.Value = 60;
            this.trackPorcentaje.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "% Hr. Síncrona:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chkBlackboard
            // 
            this.chkBlackboard.AutoSize = true;
            this.chkBlackboard.Checked = true;
            this.chkBlackboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBlackboard.Location = new System.Drawing.Point(408, 27);
            this.chkBlackboard.Name = "chkBlackboard";
            this.chkBlackboard.Size = new System.Drawing.Size(171, 19);
            this.chkBlackboard.TabIndex = 27;
            this.chkBlackboard.Text = "Mostrar Código Blackboard";
            this.chkBlackboard.UseVisualStyleBackColor = true;
            this.chkBlackboard.CheckedChanged += new System.EventHandler(this.chkBlackboard_CheckedChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Enabled = false;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(291, 24);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(98, 23);
            this.dtpFin.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fin Periodo:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Enabled = false;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(111, 24);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(98, 23);
            this.dtpInicio.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Inicio Periodo:";
            // 
            // fbdDestino
            // 
            this.fbdDestino.Description = "¿Donde se generarán los horarios?";
            // 
            // frmConvertirHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvHorarios);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConvertirHorario";
            this.Text = "Convertir Formato Horario";
            this.Load += new System.EventHandler(this.frmConvertirHorario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPorcentaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.OpenFileDialog ofdHorario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeparadorCampos;
        private System.Windows.Forms.TextBox txtCaracterSeparador;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.TextBox txtBloque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.TextBox lblArchivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBlackboard;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog fbdDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackPorcentaje;
        private System.Windows.Forms.Button btnGenerarHorarios;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTRUCTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_GENERADO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackHP;
        private System.Windows.Forms.TextBox txtHP;
    }
}

