namespace CL19037Guia6Ejercicio10
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s = new System.Windows.Forms.GroupBox();
            this.lblSalarioMeGB = new System.Windows.Forms.Label();
            this.lblSalarioMeG = new System.Windows.Forms.Label();
            this.lblGeneroMeG = new System.Windows.Forms.Label();
            this.lblEdadMeG = new System.Windows.Forms.Label();
            this.lblNombreMeG = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblSalarioMH = new System.Windows.Forms.Label();
            this.lblGeneroMH = new System.Windows.Forms.Label();
            this.lblEdadMH = new System.Windows.Forms.Label();
            this.lblNombreMH = new System.Windows.Forms.Label();
            this.lblSalarioMM = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGeneroMM = new System.Windows.Forms.Label();
            this.lblNombreMG = new System.Windows.Forms.Label();
            this.lblEdadMG = new System.Windows.Forms.Label();
            this.lblEdadMM = new System.Windows.Forms.Label();
            this.lblGeneroMG = new System.Windows.Forms.Label();
            this.lblNombreMM = new System.Windows.Forms.Label();
            this.lblSalarioMG = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudEdad);
            this.groupBox1.Controls.Add(this.cbGenero);
            this.groupBox1.Controls.Add(this.txtSalario);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE ENTRADA";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(85, 78);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(70, 22);
            this.nudEdad.TabIndex = 9;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbGenero.Location = new System.Drawing.Point(83, 105);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(122, 24);
            this.cbGenero.TabIndex = 8;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(83, 133);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(122, 22);
            this.txtSalario.TabIndex = 7;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(83, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(177, 22);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "SALARIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "GENERO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "EDAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEvaluar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.lblContador);
            this.groupBox2.Location = new System.Drawing.Point(343, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PROCESOS";
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(6, 95);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(155, 26);
            this.btnEvaluar.TabIndex = 3;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 63);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 26);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(6, 127);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 26);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar Todo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(6, 24);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(16, 17);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "0";
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.CausesValidation = false;
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.edad,
            this.genero,
            this.salario});
            this.dgvEntrada.Location = new System.Drawing.Point(12, 195);
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.RowTemplate.Height = 24;
            this.dgvEntrada.Size = new System.Drawing.Size(725, 167);
            this.dgvEntrada.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "APELLIDO";
            this.apellido.Name = "apellido";
            // 
            // edad
            // 
            this.edad.HeaderText = "EDAD";
            this.edad.Name = "edad";
            // 
            // genero
            // 
            this.genero.HeaderText = "GENERO";
            this.genero.Name = "genero";
            // 
            // salario
            // 
            this.salario.HeaderText = "SALARIO";
            this.salario.Name = "salario";
            // 
            // s
            // 
            this.s.Controls.Add(this.lblSalarioMeGB);
            this.s.Controls.Add(this.lblSalarioMeG);
            this.s.Controls.Add(this.lblGeneroMeG);
            this.s.Controls.Add(this.lblEdadMeG);
            this.s.Controls.Add(this.lblNombreMeG);
            this.s.Controls.Add(this.label21);
            this.s.Controls.Add(this.lblSalarioMH);
            this.s.Controls.Add(this.lblGeneroMH);
            this.s.Controls.Add(this.lblEdadMH);
            this.s.Controls.Add(this.lblNombreMH);
            this.s.Controls.Add(this.lblSalarioMM);
            this.s.Controls.Add(this.label16);
            this.s.Controls.Add(this.label6);
            this.s.Controls.Add(this.lblGeneroMM);
            this.s.Controls.Add(this.lblNombreMG);
            this.s.Controls.Add(this.lblEdadMG);
            this.s.Controls.Add(this.lblEdadMM);
            this.s.Controls.Add(this.lblGeneroMG);
            this.s.Controls.Add(this.lblNombreMM);
            this.s.Controls.Add(this.lblSalarioMG);
            this.s.Controls.Add(this.label11);
            this.s.Location = new System.Drawing.Point(12, 368);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(725, 367);
            this.s.TabIndex = 3;
            this.s.TabStop = false;
            this.s.Text = "SALIDA";
            // 
            // lblSalarioMeGB
            // 
            this.lblSalarioMeGB.AutoSize = true;
            this.lblSalarioMeGB.Location = new System.Drawing.Point(576, 333);
            this.lblSalarioMeGB.Name = "lblSalarioMeGB";
            this.lblSalarioMeGB.Size = new System.Drawing.Size(13, 17);
            this.lblSalarioMeGB.TabIndex = 24;
            this.lblSalarioMeGB.Text = "-";
            // 
            // lblSalarioMeG
            // 
            this.lblSalarioMeG.AutoSize = true;
            this.lblSalarioMeG.Location = new System.Drawing.Point(476, 333);
            this.lblSalarioMeG.Name = "lblSalarioMeG";
            this.lblSalarioMeG.Size = new System.Drawing.Size(13, 17);
            this.lblSalarioMeG.TabIndex = 23;
            this.lblSalarioMeG.Text = "-";
            // 
            // lblGeneroMeG
            // 
            this.lblGeneroMeG.AutoSize = true;
            this.lblGeneroMeG.Location = new System.Drawing.Point(367, 333);
            this.lblGeneroMeG.Name = "lblGeneroMeG";
            this.lblGeneroMeG.Size = new System.Drawing.Size(13, 17);
            this.lblGeneroMeG.TabIndex = 22;
            this.lblGeneroMeG.Text = "-";
            // 
            // lblEdadMeG
            // 
            this.lblEdadMeG.AutoSize = true;
            this.lblEdadMeG.Location = new System.Drawing.Point(258, 333);
            this.lblEdadMeG.Name = "lblEdadMeG";
            this.lblEdadMeG.Size = new System.Drawing.Size(13, 17);
            this.lblEdadMeG.TabIndex = 21;
            this.lblEdadMeG.Text = "-";
            // 
            // lblNombreMeG
            // 
            this.lblNombreMeG.AutoSize = true;
            this.lblNombreMeG.Location = new System.Drawing.Point(31, 333);
            this.lblNombreMeG.Name = "lblNombreMeG";
            this.lblNombreMeG.Size = new System.Drawing.Size(13, 17);
            this.lblNombreMeG.TabIndex = 20;
            this.lblNombreMeG.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(31, 294);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(206, 17);
            this.label21.TabIndex = 19;
            this.label21.Text = "Menor Salario (general + bono)";
            // 
            // lblSalarioMH
            // 
            this.lblSalarioMH.AutoSize = true;
            this.lblSalarioMH.Location = new System.Drawing.Point(476, 250);
            this.lblSalarioMH.Name = "lblSalarioMH";
            this.lblSalarioMH.Size = new System.Drawing.Size(13, 17);
            this.lblSalarioMH.TabIndex = 18;
            this.lblSalarioMH.Text = "-";
            // 
            // lblGeneroMH
            // 
            this.lblGeneroMH.AutoSize = true;
            this.lblGeneroMH.Location = new System.Drawing.Point(367, 250);
            this.lblGeneroMH.Name = "lblGeneroMH";
            this.lblGeneroMH.Size = new System.Drawing.Size(13, 17);
            this.lblGeneroMH.TabIndex = 17;
            this.lblGeneroMH.Text = "-";
            // 
            // lblEdadMH
            // 
            this.lblEdadMH.AutoSize = true;
            this.lblEdadMH.Location = new System.Drawing.Point(258, 250);
            this.lblEdadMH.Name = "lblEdadMH";
            this.lblEdadMH.Size = new System.Drawing.Size(13, 17);
            this.lblEdadMH.TabIndex = 16;
            this.lblEdadMH.Text = "-";
            // 
            // lblNombreMH
            // 
            this.lblNombreMH.AutoSize = true;
            this.lblNombreMH.Location = new System.Drawing.Point(31, 250);
            this.lblNombreMH.Name = "lblNombreMH";
            this.lblNombreMH.Size = new System.Drawing.Size(13, 17);
            this.lblNombreMH.TabIndex = 15;
            this.lblNombreMH.Text = "-";
            // 
            // lblSalarioMM
            // 
            this.lblSalarioMM.AutoSize = true;
            this.lblSalarioMM.Location = new System.Drawing.Point(476, 158);
            this.lblSalarioMM.Name = "lblSalarioMM";
            this.lblSalarioMM.Size = new System.Drawing.Size(13, 17);
            this.lblSalarioMM.TabIndex = 12;
            this.lblSalarioMM.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(194, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Mayor Salario (solo hombres)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mayor Salario (general)";
            // 
            // lblGeneroMM
            // 
            this.lblGeneroMM.AutoSize = true;
            this.lblGeneroMM.Location = new System.Drawing.Point(367, 158);
            this.lblGeneroMM.Name = "lblGeneroMM";
            this.lblGeneroMM.Size = new System.Drawing.Size(13, 17);
            this.lblGeneroMM.TabIndex = 13;
            this.lblGeneroMM.Text = "-";
            // 
            // lblNombreMG
            // 
            this.lblNombreMG.AutoSize = true;
            this.lblNombreMG.Location = new System.Drawing.Point(31, 71);
            this.lblNombreMG.Name = "lblNombreMG";
            this.lblNombreMG.Size = new System.Drawing.Size(13, 17);
            this.lblNombreMG.TabIndex = 5;
            this.lblNombreMG.Text = "-";
            // 
            // lblEdadMG
            // 
            this.lblEdadMG.AutoSize = true;
            this.lblEdadMG.Location = new System.Drawing.Point(258, 71);
            this.lblEdadMG.Name = "lblEdadMG";
            this.lblEdadMG.Size = new System.Drawing.Size(13, 17);
            this.lblEdadMG.TabIndex = 6;
            this.lblEdadMG.Text = "-";
            // 
            // lblEdadMM
            // 
            this.lblEdadMM.AutoSize = true;
            this.lblEdadMM.Location = new System.Drawing.Point(258, 158);
            this.lblEdadMM.Name = "lblEdadMM";
            this.lblEdadMM.Size = new System.Drawing.Size(13, 17);
            this.lblEdadMM.TabIndex = 11;
            this.lblEdadMM.Text = "-";
            // 
            // lblGeneroMG
            // 
            this.lblGeneroMG.AutoSize = true;
            this.lblGeneroMG.Location = new System.Drawing.Point(367, 71);
            this.lblGeneroMG.Name = "lblGeneroMG";
            this.lblGeneroMG.Size = new System.Drawing.Size(13, 17);
            this.lblGeneroMG.TabIndex = 7;
            this.lblGeneroMG.Text = "-";
            // 
            // lblNombreMM
            // 
            this.lblNombreMM.AutoSize = true;
            this.lblNombreMM.Location = new System.Drawing.Point(31, 158);
            this.lblNombreMM.Name = "lblNombreMM";
            this.lblNombreMM.Size = new System.Drawing.Size(13, 17);
            this.lblNombreMM.TabIndex = 10;
            this.lblNombreMM.Text = "-";
            // 
            // lblSalarioMG
            // 
            this.lblSalarioMG.AutoSize = true;
            this.lblSalarioMG.Location = new System.Drawing.Point(476, 71);
            this.lblSalarioMG.Name = "lblSalarioMG";
            this.lblSalarioMG.Size = new System.Drawing.Size(13, 17);
            this.lblSalarioMG.TabIndex = 8;
            this.lblSalarioMG.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Mayor Salario (solo mujeres)";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 753);
            this.Controls.Add(this.s);
            this.Controls.Add(this.dgvEntrada);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SALARIOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.GroupBox s;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblSalarioMH;
        private System.Windows.Forms.Label lblGeneroMH;
        private System.Windows.Forms.Label lblEdadMH;
        private System.Windows.Forms.Label lblNombreMH;
        private System.Windows.Forms.Label lblSalarioMM;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGeneroMM;
        private System.Windows.Forms.Label lblNombreMG;
        private System.Windows.Forms.Label lblEdadMG;
        private System.Windows.Forms.Label lblEdadMM;
        private System.Windows.Forms.Label lblGeneroMG;
        private System.Windows.Forms.Label lblNombreMM;
        private System.Windows.Forms.Label lblSalarioMG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSalarioMeG;
        private System.Windows.Forms.Label lblGeneroMeG;
        private System.Windows.Forms.Label lblEdadMeG;
        private System.Windows.Forms.Label lblNombreMeG;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblSalarioMeGB;
        private System.Windows.Forms.ToolTip ttAyuda;
        private System.Windows.Forms.ErrorProvider epError;
    }
}

