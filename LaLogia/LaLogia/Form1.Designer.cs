
namespace LaLogia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelPiernaH = new System.Windows.Forms.Label();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelNacimiento = new System.Windows.Forms.Label();
            this.listBoxPiernaH = new System.Windows.Forms.ListBox();
            this.labelPiernaM = new System.Windows.Forms.Label();
            this.checkedListBoxPosiciones = new System.Windows.Forms.CheckedListBox();
            this.labelPosiciones = new System.Windows.Forms.Label();
            this.numericUpDownPiernaM = new System.Windows.Forms.NumericUpDown();
            this.labelSkills = new System.Windows.Forms.Label();
            this.numericUpDownSkills = new System.Windows.Forms.NumericUpDown();
            this.labelCamiseta = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPiernaM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkills)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-2, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de La Logia FC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.buttonAgregar);
            this.groupBox2.Controls.Add(this.labelPiernaH);
            this.groupBox2.Controls.Add(this.dateTimePickerNacimiento);
            this.groupBox2.Controls.Add(this.labelNacimiento);
            this.groupBox2.Controls.Add(this.listBoxPiernaH);
            this.groupBox2.Controls.Add(this.labelPiernaM);
            this.groupBox2.Controls.Add(this.checkedListBoxPosiciones);
            this.groupBox2.Controls.Add(this.labelPosiciones);
            this.groupBox2.Controls.Add(this.numericUpDownPiernaM);
            this.groupBox2.Controls.Add(this.labelSkills);
            this.groupBox2.Controls.Add(this.numericUpDownSkills);
            this.groupBox2.Controls.Add(this.labelCamiseta);
            this.groupBox2.Controls.Add(this.textBoxNumero);
            this.groupBox2.Controls.Add(this.labelApellido);
            this.groupBox2.Controls.Add(this.textBoxApellido);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(11, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 518);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.Location = new System.Drawing.Point(118, 453);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(86, 35);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(223, 453);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(86, 35);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
            this.buttonAgregar.Location = new System.Drawing.Point(12, 453);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(86, 35);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelPiernaH
            // 
            this.labelPiernaH.AutoSize = true;
            this.labelPiernaH.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPiernaH.Location = new System.Drawing.Point(9, 320);
            this.labelPiernaH.Name = "labelPiernaH";
            this.labelPiernaH.Size = new System.Drawing.Size(62, 13);
            this.labelPiernaH.TabIndex = 15;
            this.labelPiernaH.Text = "Pierna habil";
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(12, 243);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(297, 20);
            this.dateTimePickerNacimiento.TabIndex = 3;
            this.dateTimePickerNacimiento.ValueChanged += new System.EventHandler(this.dateTimePickerNacimiento_ValueChanged);
            this.dateTimePickerNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerNacimiento_KeyPress);
            // 
            // labelNacimiento
            // 
            this.labelNacimiento.AutoSize = true;
            this.labelNacimiento.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelNacimiento.Location = new System.Drawing.Point(9, 227);
            this.labelNacimiento.Name = "labelNacimiento";
            this.labelNacimiento.Size = new System.Drawing.Size(106, 13);
            this.labelNacimiento.TabIndex = 11;
            this.labelNacimiento.Text = "Fecha de nacimiento";
            // 
            // listBoxPiernaH
            // 
            this.listBoxPiernaH.FormattingEnabled = true;
            this.listBoxPiernaH.Items.AddRange(new object[] {
            "Derecha",
            "Izquierda",
            "Ambidiestro"});
            this.listBoxPiernaH.Location = new System.Drawing.Point(12, 337);
            this.listBoxPiernaH.Name = "listBoxPiernaH";
            this.listBoxPiernaH.Size = new System.Drawing.Size(133, 43);
            this.listBoxPiernaH.TabIndex = 5;
            this.listBoxPiernaH.SelectedIndexChanged += new System.EventHandler(this.listBoxPiernaH_SelectedIndexChanged);
            this.listBoxPiernaH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxPiernaH_KeyPress);
            // 
            // labelPiernaM
            // 
            this.labelPiernaM.AutoSize = true;
            this.labelPiernaM.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPiernaM.Location = new System.Drawing.Point(9, 392);
            this.labelPiernaM.Name = "labelPiernaM";
            this.labelPiernaM.Size = new System.Drawing.Size(62, 13);
            this.labelPiernaM.TabIndex = 14;
            this.labelPiernaM.Text = "Pierna mala";
            // 
            // checkedListBoxPosiciones
            // 
            this.checkedListBoxPosiciones.FormattingEnabled = true;
            this.checkedListBoxPosiciones.Items.AddRange(new object[] {
            "Arquero",
            "Defensor Central",
            "Lateral Derecho",
            "Lateral izquierdo",
            "Mediocampista",
            "Delantero"});
            this.checkedListBoxPosiciones.Location = new System.Drawing.Point(176, 289);
            this.checkedListBoxPosiciones.Name = "checkedListBoxPosiciones";
            this.checkedListBoxPosiciones.Size = new System.Drawing.Size(133, 94);
            this.checkedListBoxPosiciones.TabIndex = 6;
            this.checkedListBoxPosiciones.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxPosiciones_ItemCheck);
            this.checkedListBoxPosiciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkedListBoxPosiciones_KeyPress);
            // 
            // labelPosiciones
            // 
            this.labelPosiciones.AutoSize = true;
            this.labelPosiciones.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPosiciones.Location = new System.Drawing.Point(174, 273);
            this.labelPosiciones.Name = "labelPosiciones";
            this.labelPosiciones.Size = new System.Drawing.Size(58, 13);
            this.labelPosiciones.TabIndex = 10;
            this.labelPosiciones.Text = "Posiciones";
            // 
            // numericUpDownPiernaM
            // 
            this.numericUpDownPiernaM.Location = new System.Drawing.Point(12, 408);
            this.numericUpDownPiernaM.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownPiernaM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPiernaM.Name = "numericUpDownPiernaM";
            this.numericUpDownPiernaM.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownPiernaM.TabIndex = 7;
            this.numericUpDownPiernaM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPiernaM.ValueChanged += new System.EventHandler(this.numericUpDownPiernaM_ValueChanged);
            this.numericUpDownPiernaM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownPiernaM_KeyPress);
            // 
            // labelSkills
            // 
            this.labelSkills.AutoSize = true;
            this.labelSkills.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelSkills.Location = new System.Drawing.Point(173, 392);
            this.labelSkills.Name = "labelSkills";
            this.labelSkills.Size = new System.Drawing.Size(31, 13);
            this.labelSkills.TabIndex = 12;
            this.labelSkills.Text = "Skills";
            this.labelSkills.Click += new System.EventHandler(this.label10_Click);
            // 
            // numericUpDownSkills
            // 
            this.numericUpDownSkills.Location = new System.Drawing.Point(176, 408);
            this.numericUpDownSkills.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSkills.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSkills.Name = "numericUpDownSkills";
            this.numericUpDownSkills.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownSkills.TabIndex = 8;
            this.numericUpDownSkills.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSkills.ValueChanged += new System.EventHandler(this.numericUpDownSkills_ValueChanged);
            this.numericUpDownSkills.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownSkills_KeyPress);
            // 
            // labelCamiseta
            // 
            this.labelCamiseta.AutoSize = true;
            this.labelCamiseta.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelCamiseta.Location = new System.Drawing.Point(9, 273);
            this.labelCamiseta.Name = "labelCamiseta";
            this.labelCamiseta.Size = new System.Drawing.Size(89, 13);
            this.labelCamiseta.TabIndex = 8;
            this.labelCamiseta.Text = "Numero camiseta";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(11, 288);
            this.textBoxNumero.Multiline = true;
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(134, 25);
            this.textBoxNumero.TabIndex = 4;
            this.textBoxNumero.TextChanged += new System.EventHandler(this.textBoxNumero_TextChanged);
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelApellido.Location = new System.Drawing.Point(174, 176);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 6;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(176, 192);
            this.textBoxApellido.Multiline = true;
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(134, 25);
            this.textBoxApellido.TabIndex = 2;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelNombre.Location = new System.Drawing.Point(9, 176);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(11, 192);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(134, 25);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxImage);
            this.groupBox5.Location = new System.Drawing.Point(88, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(154, 131);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.Location = new System.Drawing.Point(6, 10);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(142, 115);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(105, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Información del jugador";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(336, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 517);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(205, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lista de jugadores";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxBuscar);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(805, 57);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Jugadores";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(407, 19);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(241, 23);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(336, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(829, 686);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de La Logia FC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPiernaM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkills)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelCamiseta;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.CheckedListBox checkedListBoxPosiciones;
        private System.Windows.Forms.Label labelPosiciones;
        private System.Windows.Forms.NumericUpDown numericUpDownSkills;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
        private System.Windows.Forms.Label labelPiernaM;
        private System.Windows.Forms.NumericUpDown numericUpDownPiernaM;
        private System.Windows.Forms.Label labelSkills;
        private System.Windows.Forms.Label labelNacimiento;
        private System.Windows.Forms.ListBox listBoxPiernaH;
        private System.Windows.Forms.Label labelPiernaH;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}

