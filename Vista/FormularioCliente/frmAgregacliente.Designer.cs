
namespace EstudioColmenaTrabajoPractico.Vista.Formularios_cliente
{
    partial class frmAgregacliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregacliente));
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPiso = new System.Windows.Forms.TextBox();
            this.TxtBarrio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtOcupacion = new System.Windows.Forms.TextBox();
            this.TxtCalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvClientes
            // 
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(379, 112);
            this.DgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DgvClientes.MultiSelect = false;
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersWidth = 82;
            this.DgvClientes.RowTemplate.Height = 33;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(651, 492);
            this.DgvClientes.TabIndex = 67;
            this.DgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAgregar.Location = new System.Drawing.Point(563, 639);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 32);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Black;
            this.panelTitulo.Controls.Add(this.pictureBox2);
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnMaximizar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Controls.Add(this.lblCliente);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1052, 76);
            this.panelTitulo.TabIndex = 90;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(939, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(38, 50);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(978, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(38, 50);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1014, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 50);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(519, 17);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(156, 33);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CLIENTES";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnModificar.Location = new System.Drawing.Point(687, 639);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 32);
            this.btnModificar.TabIndex = 91;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEliminar.Location = new System.Drawing.Point(814, 639);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 32);
            this.btnEliminar.TabIndex = 92;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSalir.Location = new System.Drawing.Point(934, 639);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 32);
            this.btnSalir.TabIndex = 93;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtDocumento);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.TxtApellido);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(13, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(362, 154);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 24);
            this.label15.TabIndex = 44;
            this.label15.Text = "Documento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Apellido";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.TxtDocumento.Location = new System.Drawing.Point(141, 48);
            this.TxtDocumento.MaxLength = 8;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(212, 27);
            this.TxtDocumento.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label13.Location = new System.Drawing.Point(13, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "ID";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.TxtNombre.Location = new System.Drawing.Point(141, 114);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(212, 27);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.TxtApellido.Location = new System.Drawing.Point(141, 81);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(212, 27);
            this.TxtApellido.TabIndex = 29;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblId.Location = new System.Drawing.Point(41, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(62, 20);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "label14";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.AutoCompleteCustomSource.AddRange(new string[] {
            "Seleccione",
            "2 de Mayo",
            "25 de Mayo",
            "28 de Noviembre",
            "Abra Pampa",
            "Achiras",
            "Aconquija",
            "Adolfo Gonzales Chaves",
            "Aguas Calientes",
            "Aguas de Oro",
            "Aguas Verdes",
            "Aimogasta",
            "Alba Posse",
            "Alberdi",
            "Alberti",
            "Alcira Gigena",
            "Alejandra",
            "Alijilan",
            "Allen",
            "Almafuerte",
            "Alpa Corral",
            "Alta Gracia",
            "Alto Río Senguer",
            "Alumine",
            "Amaicha del Valle",
            "Amboy",
            "Aminga",
            "Ampimpa",
            "Ancasti",
            "Andacollo",
            "Andalgala",
            "Andresito",
            "Angastaco",
            "Anillaco",
            "Anisacate",
            "Antofagasta",
            "Añatuya",
            "Apostoles",
            "Arenas Verdes",
            "Aristobulo del Valle",
            "Armstrong",
            "Arocena",
            "Arrecifes",
            "Arroyito",
            "Arroyito",
            "Arroyo de los Patos",
            "Arroyo Leyes",
            "Arroyo Seco",
            "Ascochinga",
            "Ataliva Roca",
            "Athos Pampa",
            "Avellaneda",
            "Avia Terai",
            "Ayacucho",
            "Azul",
            "Bahia Blanca",
            "Bahía Bustamante",
            "Bahia San Blas",
            "Balcarce",
            "Balde",
            "Balnearia",
            "Balneario San Cayetano",
            "Bandera",
            "Baradero",
            "Bariloche",
            "Barrancas",
            "Barreal",
            "Basavilbaso",
            "Belen",
            "Bell Ville",
            "Bella Vista",
            "Bella Vista",
            "Benito Juarez",
            "Berisso",
            "Bernardo de Irigoyen",
            "Bernardo Larroude",
            "Bialet Masse",
            "Bolivar",
            "Bragado",
            "Brandsen",
            "Brazo Largo",
            "Burruyacu",
            "C. del Uruguay",
            "Caa Catí",
            "Cabalango",
            "Cabra Corral",
            "Cachi",
            "Cafayate",
            "Caimancito",
            "Caleta Olivia",
            "Calingasta",
            "Calmayo",
            "Camarones",
            "Campana",
            "Campo Grande",
            "Campo Quijano",
            "Campo Viera",
            "Candelaria",
            "Cañada de Gomez",
            "Cañon del Atuel",
            "Cañuelas",
            "Capilla del Monte",
            "Capilla del Señor",
            "Capiovi",
            "Capitan Sarmiento",
            "Caraguatay",
            "Carcaraña",
            "Carhue",
            "Carilo",
            "Carlos Casares",
            "Carlos Keen",
            "Carlos Tejedor",
            "Carmen de Areco",
            "Carmen de Patagones",
            "Carpinteria",
            "Carro Quemado",
            "Casa de Piedra",
            "Casa Grande",
            "Casabindo",
            "Casilda",
            "Castelli",
            "Catriel",
            "Caucete",
            "Caviahue",
            "Cayasta",
            "Centenario",
            "Ceres",
            "Cerrillos",
            "Cerro Colorado",
            "Chabas",
            "Chacabuco",
            "Chacharramendi",
            "Chacras de Coria",
            "Chajari",
            "Chamical",
            "Chapadmalal",
            "Charata",
            "Charbonier",
            "Chascomus",
            "Chepes",
            "Chicoana",
            "Chilecito",
            "Chivilcoy",
            "Choele Choel",
            "Cholila",
            "Chos Malal",
            "Cinco Saltos",
            "Cipolletti",
            "Ciudad de Buenos Aires",
            "Claromeco",
            "Clorinda",
            "Colalao del Valle",
            "Colon",
            "Colon",
            "Colonia 25 de Mayo",
            "Colonia Baron",
            "Colonia Caroya",
            "Colonia Pellegrini",
            "Colonia Suiza",
            "Colonia Victoria",
            "Comodoro Rivadavia",
            "Concaran",
            "Concepcion",
            "Concepción de la Sierra",
            "Concordia",
            "Copacabana",
            "Copahue",
            "Corcovado",
            "Cordoba Capital",
            "Coronda",
            "Coronel Dorrego",
            "Coronel Moldes",
            "Coronel Pringles",
            "Coronel Suarez",
            "Coronel Vidal",
            "Corpus",
            "Corrientes Capital",
            "Cortaderas",
            "Cosquin",
            "Costa Azul",
            "Costa Chica",
            "Costa del Este",
            "Costa Esmeralda",
            "Crespo",
            "Cruz Alta",
            "Cruz Chica",
            "Cruz del Eje",
            "Cruz Grande",
            "Cte. Piedra Buena",
            "Cuesta Blanca",
            "Curuzu Cuatia",
            "Cutral Co",
            "Daireaux",
            "Dean Funes",
            "Del Campillo",
            "Despeñaderos",
            "Desvio Arijon",
            "Diamante",
            "Dina Huapi",
            "Dolores",
            "Eduardo Castex",
            "El Alcazar",
            "El Alto",
            "El Bolson",
            "El Cadillal",
            "El Calafate",
            "El Carmen",
            "El Chalten",
            "El Cholar",
            "El Colorado",
            "El Dorado",
            "El Durazno",
            "El Hoyo",
            "El Huecu",
            "El Maiten",
            "El Manso",
            "El Manzano",
            "El Mollar",
            "El Morro",
            "El Nihuil",
            "El Rodeo",
            "El Sauzalito",
            "El Siambon",
            "El Soberbio",
            "El Sosneado",
            "El Trapiche",
            "El Volcan",
            "Elortondo",
            "Embalse",
            "Embarcacion",
            "Empedrado",
            "Ensenada",
            "Epuyen",
            "Escobar",
            "Esperanza",
            "Esquel",
            "Esquina",
            "Exaltación de la Cruz",
            "Ezeiza",
            "Famailla",
            "Famatina",
            "Federacion",
            "Federal",
            "Fiambala",
            "Firmat",
            "Fitz Roy",
            "Florencia",
            "Florentino Ameghino",
            "Formosa Capital",
            "Franck",
            "Frias",
            "Fuerte Esperanza",
            "Funes",
            "Gaiman",
            "Gancedo",
            "Garupa",
            "General Acha",
            "General Alvear",
            "General Belgrano",
            "General Conesa",
            "General Deheza",
            "General Guemes",
            "General Lamadrid",
            "General Las Heras",
            "General Lavalle",
            "General Levalle",
            "General Madariaga",
            "General Mosconi",
            "General Pico",
            "General Pinedo",
            "General Pinto",
            "General Ramirez",
            "General Roca",
            "General Rodriguez",
            "General San Martin",
            "General San Martin",
            "General Vedia",
            "General Villegas",
            "Gobernador Costa",
            "Gobernador Gregores",
            "Gobernador Roca",
            "Godoy Cruz",
            "Goya",
            "Gral. Manuel Belgrano",
            "Granadero Baigorria",
            "Gualeguay",
            "Gualeguaychu",
            "Guaminí",
            "Guandacol",
            "Guatrache",
            "Guaymallen",
            "Hasenkamp",
            "Helvecia",
            "Hermoso Campo",
            "Hernandarias",
            "Hernando",
            "Herradura",
            "Hipolito Yrigoyen",
            "Hornillos",
            "Huacalera",
            "Huanguelen",
            "Huerta Grande",
            "Huichaira",
            "Huinca Renanco",
            "Huinganco",
            "Humahuaca",
            "Ibarreta",
            "Ibicuy",
            "Icaño",
            "Icho Cruz",
            "Iglesia",
            "Ingeniero Jacobacci",
            "Ingeniero Juarez",
            "Intendente Alvear",
            "Intiyaco",
            "Iruya",
            "Ischilin",
            "Isla del Cerrito",
            "Ita Ibate",
            "Itati",
            "Ituzaingo",
            "Jachal",
            "Jacinto Arauz",
            "James Craik",
            "Jaramillo",
            "Jardin America",
            "Jesus Maria",
            "Joaquin V. Gonzalez",
            "Jose de San Martin",
            "Juan Jose Castelli",
            "Juana Koslay",
            "Junin",
            "Junin",
            "Junin de los Andes",
            "La Banda",
            "La Bolsa",
            "La Caldera",
            "La Calera",
            "La Carlota",
            "La Carolina",
            "La Cesira",
            "La Cruz",
            "La Cruz Corrientes",
            "La Cumbre",
            "La Cumbrecita",
            "La Falda",
            "La Florida",
            "La Granja",
            "La Lucila del Mar",
            "La Paisanita",
            "La Paz",
            "La Paz",
            "La Paz Cordoba",
            "La Plata",
            "La Poblacion",
            "La Poma",
            "La Puerta",
            "La Punta",
            "La Quiaca",
            "La Rioja Capital",
            "La Serranita",
            "La Toma",
            "Laboulaye",
            "Lago Puelo",
            "Laguna Blanca",
            "Larroque",
            "Las Albacas",
            "Las Breñas",
            "Las Caleras",
            "Las Calles",
            "Las Carditas",
            "Las Cuevas",
            "Las Flores",
            "Las Flores",
            "Las Gaviotas",
            "Las Grutas",
            "Las Heras",
            "Las Heras",
            "Las Juntas",
            "Las Lajas",
            "Las Lomitas",
            "Las Ovejas",
            "Las Rabonas",
            "Las Tapias",
            "Las Toninas",
            "Las Vegas",
            "Leandro Alem",
            "Libertador San Martin",
            "Lincoln",
            "Lobería",
            "Lobos",
            "Loma Bola",
            "Loncopue",
            "Loreto",
            "Los Antiguos",
            "Los Cocos",
            "Los Condores",
            "Los Hornillos",
            "Los Menucos",
            "Los Molinos",
            "Los Molles",
            "Los Molles",
            "Los Pozos",
            "Los Reartes",
            "Los Reyunos",
            "Los Toldos",
            "Loza Corral",
            "Lozano",
            "Lujan",
            "Lujan de Cuyo",
            "Lujan San Luis",
            "Macachin",
            "Machagai",
            "Magdalena",
            "Maimara",
            "Maipu",
            "Maipu",
            "Malargue",
            "Manzano Amargo",
            "Manzano Historico",
            "Mar Azul",
            "Mar Chiquita",
            "Mar de Ajo",
            "Mar de Cobo",
            "Mar de las Pampas",
            "Mar del Plata",
            "Mar del Sur",
            "Mar del Tuyu",
            "Marcos Juarez",
            "Maria Grande",
            "Marisol",
            "Mayor Villafañe",
            "Mayu Sumaj",
            "Mburucuya",
            "Medanos",
            "Melincue",
            "Mendiolaza",
            "Mendoza Capital",
            "Mercedes",
            "Mercedes Corrientes",
            "Merlo",
            "Mina Clavero",
            "Ministro Ramos Mexia",
            "Miramar",
            "Miramar",
            "Mision Nueva Pompeya",
            "Molinari",
            "Molinos",
            "Monje",
            "Monte Caseros",
            "Monte Hermoso",
            "Monte Maiz",
            "Montecarlo",
            "Moquehue",
            "Morteros",
            "Navarro",
            "Necochea",
            "Neuquen Capital",
            "Nogoli",
            "Nogoya",
            "Nono",
            "Nueva Atlantis",
            "Nueva Galia",
            "Nueve de Julio",
            "Obera",
            "Olavarria",
            "Oliveros",
            "Olta",
            "Oncativo",
            "Ongamira",
            "Oran",
            "Orense",
            "Oriente",
            "Ostende",
            "Paclin",
            "Pagancillo",
            "Palo Santo",
            "Palpalá",
            "Pampa del Indio",
            "Panaholma",
            "Panambi",
            "Papagayos",
            "Parana",
            "Paso de la Patria",
            "Paso de los Libres",
            "Patquia",
            "Pedro Luro",
            "Pehuajo",
            "Pehuen Co",
            "Pergamino",
            "Perico",
            "Perito Moreno",
            "Pico Truncado",
            "Picun Leufu",
            "Piedra del Aguila",
            "Piedras Blancas",
            "Pigüé",
            "Pilar",
            "Pinamar",
            "Pinar del Sol",
            "Pinto",
            "Pipinas",
            "Pirane",
            "Pismanta",
            "Playa Unión",
            "Playas Doradas",
            "Plaza Huincul",
            "Plottier",
            "Poman",
            "Posadas",
            "Potrerillos",
            "Potrero de Garay",
            "Potrero de los Funes",
            "Primeros Pinos",
            "Puan",
            "Pueblo Liebig",
            "Puerto Deseado",
            "Puerto Esperanza",
            "Puerto Gaboto",
            "Puerto Iguazu",
            "Puerto Libertad",
            "Puerto Madryn",
            "Puerto Mineral",
            "Puerto Piramides",
            "Puerto Piray",
            "Puerto Rico",
            "Puerto San Julian",
            "Puerto Santa Cruz",
            "Puerto Tirol",
            "Puerto Yerua",
            "Puiggari",
            "Pulmari",
            "Punta Alta",
            "Punta Indio",
            "Punta Medanos",
            "Purmamarca",
            "Quequen",
            "Quilino",
            "Quilmes",
            "Quines",
            "Raco",
            "Rada Tilly",
            "Rafaela",
            "Ramallo",
            "Ranchos",
            "Rancul",
            "Rauch",
            "Rawson",
            "Rawson",
            "Realico",
            "Reconquista",
            "Recreo",
            "Renca",
            "Resistencia",
            "Reta",
            "Rincón de los Sauces",
            "Rio Ceballos",
            "Rio Colorado",
            "Rio Cuarto",
            "Rio de los Sauces",
            "Rio Gallegos",
            "Rio Grande",
            "Rio Mayo",
            "Rio Pico",
            "Rio Tercero",
            "Rio Turbio",
            "Rivadavia",
            "Rivadavia",
            "Rivadavia",
            "Rodeo",
            "Rojas",
            "Romang",
            "Roque Perez",
            "Roque Saenz Peña",
            "Rosario",
            "Rosario de la Frontera",
            "Rosario del Tala",
            "Rufino",
            "Ruinas de Quilmes",
            "S. Francisco del Monte",
            "S. Martin de los Andes",
            "Saavedra",
            "Saladillo",
            "Saldan",
            "Saldungaray",
            "Salsacate",
            "Salsipuedes",
            "Salta Capital",
            "Salto",
            "Salto Encantado",
            "San A. de Arredondo",
            "San A. de los Cobres",
            "San Andres de Giles",
            "San Antonio",
            "San Antonio de Apipe",
            "San Antonio de Areco",
            "San Antonio Este",
            "San Antonio Oeste",
            "San Bernardo",
            "San Blas de Los Sauces",
            "San Carlos",
            "San Carlos",
            "San Carlos",
            "San Carlos Minas",
            "San Cayetano",
            "San Clemente",
            "San Clemente del Tuyu",
            "San Cristobal",
            "San Esteban",
            "San Fernando",
            "San Fernando del Valle",
            "San Francisco",
            "San Francisco",
            "San Francisco de Laishi",
            "San Geronimo",
            "San Ignacio",
            "San Isidro",
            "San Isidro",
            "San Javier",
            "San Javier",
            "San Javier Traslasierra",
            "San Javier Tucuman",
            "San Jorge",
            "San Jose de Feliciano",
            "San Jose de la Dormida",
            "San Jose de Metan",
            "San Jose del Rincon",
            "San Juan Capital",
            "San Justo",
            "San Lorenzo",
            "San Luis Capital",
            "San Marcos Sierras",
            "San Martin",
            "San Miguel de Tucuman",
            "San Miguel del Monte",
            "San Nicolas",
            "San Pedro",
            "San Pedro",
            "San Pedro de Colalao",
            "San Pedro de Jujuy",
            "San Rafael",
            "San Roque",
            "San Salvador",
            "San Salvador de Jujuy",
            "San Vicente",
            "Sanagasta",
            "Santa Ana",
            "Santa Ana",
            "Santa Catalina",
            "Santa Clara del Mar",
            "Santa Cruz del Lago",
            "Santa Elena",
            "Santa Fe Capital",
            "Santa Isabel",
            "Santa Lucia",
            "Santa Maria",
            "Santa María",
            "Santa Maria de Punilla",
            "Santa Monica",
            "Santa Rita",
            "Santa Rosa",
            "Santa Rosa Calamuchita",
            "Santa Rosa del Conlara",
            "Santa Rosa La Pampa",
            "Santa Teresita",
            "Santa Teresita",
            "Santo Tome",
            "Santo Tome Corrientes",
            "Sarmiento",
            "Sastre",
            "Sauce",
            "Sauce Viejo",
            "Saujil",
            "Seclantas",
            "Sgo. del Estero Capital",
            "Sierra Colorada",
            "Sierra de la Ventana",
            "Sierra de las Quijadas",
            "Sierra de los Padres",
            "Sierra Grande",
            "Sierras Bayas",
            "Simoca",
            "Sinsacate",
            "Sta. Rosa de Calchines",
            "Suipacha",
            "Sumampa",
            "Sunchales",
            "Susques",
            "Taco Ralo",
            "Tafi del Valle",
            "Tafi Viejo",
            "Tala Huasi",
            "Tama",
            "Tancacha",
            "Tandil",
            "Tanti",
            "Tapalque",
            "Tartagal",
            "Termas de Rio Hondo",
            "Tigre",
            "Tilcara",
            "Tilisarao",
            "Timbues",
            "Tinogasta",
            "Toay",
            "Tobuna",
            "Tolar Grande",
            "Tolhuin",
            "Tomas Jofre",
            "Tornquist",
            "Tostado",
            "Treinta de Agosto",
            "Trelew",
            "Trenque Lauquen",
            "Tres Arroyos",
            "Trevelin",
            "Tricao Malal",
            "Tudcum",
            "Tumbaya",
            "Tunuyan",
            "Tupungato",
            "Ulapes",
            "Ullum",
            "Unquillo",
            "Uquia",
            "Urdinarrain",
            "Ushuaia",
            "Uspallata",
            "V. C. Pque. Los Reartes",
            "Valcheta",
            "Valeria del Mar",
            "Valle de Uco",
            "Valle Fertil",
            "Valle Grande",
            "Valle Grande",
            "Valle Hermoso",
            "Valle Maria",
            "Vallecito",
            "Vaqueros",
            "Varvarco",
            "Vedia",
            "Veinticinco de Mayo",
            "Venado Tuerto",
            "Verónica",
            "Viale",
            "Vicente Casares",
            "Victoria",
            "Victorica",
            "Viedma",
            "Villa Allende",
            "Villa Alpina",
            "Villa Ameghino",
            "Villa Angela",
            "Villa Animi",
            "Villa Ascasubi",
            "Villa Berna",
            "Villa Cañas",
            "Villa Carlos Paz",
            "Villa Castelli",
            "Villa Ciudad America",
            "Villa Constitucion",
            "Villa Cura Brochero",
            "Villa de la Quebrada",
            "Villa de las Rosas",
            "Villa de Maria",
            "Villa de Soto",
            "Villa del Dique",
            "Villa del Totoral",
            "Villa Dolores",
            "Villa El Chocon",
            "Villa El Condor",
            "Villa Elena",
            "Villa Elisa",
            "Villa Futalaufquen",
            "Villa General Belgrano",
            "Villa Gesell",
            "Villa Giardino",
            "Villa Jardín de Reyes",
            "Villa La Angostura",
            "Villa La Arcadia",
            "Villa La Punta",
            "Villa Lago Gutiérrez",
            "Villa Lago Mascardi",
            "Villa Lago Meliquina",
            "Villa Larca",
            "Villa Las Pirquitas",
            "Villa Los Aromos",
            "Villa Maria",
            "Villa Mercedes",
            "Villa Nougues",
            "Villa Ocampo",
            "Villa Ojo de Agua",
            "Villa Paranacito",
            "Villa Parque Siquiman",
            "Villa Pehuenia",
            "Villa Regina",
            "Villa Rio Bermejito",
            "Villa Rumipal",
            "Villa San Jose",
            "Villa San Lorenzo",
            "Villa Serrana La Gruta",
            "Villa Traful",
            "Villa Tulumba",
            "Villa Union",
            "Villa Urquiza",
            "Villa Ventana",
            "Villaguay",
            "Villalonga",
            "Villamonte",
            "Vinchina",
            "Virasoro",
            "Volcan",
            "Wanda",
            "Winifreda",
            "Yacanto Calamuchita",
            "Yacanto Traslasierra",
            "Yala",
            "Yapeyu",
            "Yavi",
            "Yerba Buena",
            "Zapala",
            "Zarate",
            "Zonda"});
            this.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(154, 312);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(212, 21);
            this.cboLocalidad.TabIndex = 0;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.AutoCompleteCustomSource.AddRange(new string[] {
            "Seleccione",
            "1° DE MAYO",
            "12 DE OCTUBRE",
            "2 DE ABRIL",
            "25 DE MAYO",
            "25 DE MAYO",
            "25 DE MAYO",
            "25 DE MAYO",
            "25 DE MAYO",
            "9 DE JULIO",
            "9 DE JULIO",
            "9 DE JULIO",
            "9 DE JULIO",
            "9 DE JULIO",
            "ADOLFO ALSINA",
            "ADOLFO ALSINA",
            "ADOLFO GONZALES CHAVES",
            "AGUIRRE",
            "ALBARDON",
            "ALBERDI",
            "ALBERTI",
            "ALMIRANTE BROWN",
            "ALMIRANTE BROWN",
            "ALUMINE",
            "AMBATO",
            "ANCASTI",
            "ANDALGALÁ",
            "ANGACO",
            "ANTA",
            "ANTÁRTIDA ARGENTINA",
            "ANTOFAGASTA DE LA SIERRA",
            "AÑELO",
            "APOSTOLES",
            "ARAUCO",
            "ARRECIFES",
            "ATAMISQUI",
            "ATREUCO",
            "AVELLANEDA",
            "AVELLANEDA",
            "AVELLANEDA",
            "AYACUCHO",
            "AYACUCHO",
            "AZUL",
            "BAHÍA BLANCA",
            "BALCARCE",
            "BANDA",
            "BARADERO",
            "BARILOCHE",
            "BELEN",
            "BELGRANO",
            "BELGRANO",
            "BELGRANO",
            "BELLA VISTA",
            "BENITO JUAREZ",
            "BERAZATEGUI",
            "BERISSO",
            "BERMEJO",
            "BERMEJO",
            "BERON DE ASTRADA",
            "BIEDMA",
            "BOLIVAR",
            "BRAGADO",
            "BRANDSEN",
            "BURRUYACU",
            "CACHI",
            "CAFAYATE",
            "CAINGUAS",
            "CALAMUCHITA",
            "CALEU CALEU",
            "CALINGASTA",
            "CAMPANA",
            "CANDELARIA",
            "CAÑUELAS",
            "CAPAYAN",
            "CAPITAL",
            "CAPITAL",
            "CAPITAL",
            "CAPITAL",
            "CAPITAL",
            "CAPITAL",
            "CAPITAL",
            "CAPITAL",
            "CAPITAL",
            "CAPITAL",
            "CAPITAL",
            "CAPITAN SARMIENTO",
            "CARLOS CASARES",
            "CARLOS TEJEDOR",
            "CARMEN DE ARECO",
            "CASEROS",
            "CASTELLANOS",
            "CASTELLI",
            "CASTRO BARROS",
            "CATAN LIL",
            "CATRILO",
            "CAUCETE",
            "CERRILLOS",
            "CHACABUCO",
            "CHACABUCO",
            "CHACABUCO",
            "CHALILEO",
            "CHAMICAL",
            "CHAPALEUFU",
            "CHASCOMUS",
            "CHICAL CO",
            "CHICLIGASTA",
            "CHICOANA",
            "CHILECITO",
            "CHIMBAS",
            "CHIVILCOY",
            "CHOS MALAL",
            "CHOYA",
            "CIUDAD DE BUENOS AIRES",
            "COCHINOCA",
            "COLLON CURA",
            "COLON",
            "COLON",
            "COLON",
            "COMANDANTE FERNANDEZ",
            "COMUNA 1",
            "COMUNA 10",
            "COMUNA 11",
            "COMUNA 12",
            "COMUNA 13",
            "COMUNA 14",
            "COMUNA 15",
            "COMUNA 2",
            "COMUNA 3",
            "COMUNA 4",
            "COMUNA 5",
            "COMUNA 6",
            "COMUNA 7",
            "COMUNA 8",
            "COMUNA 9",
            "CONCEPCION",
            "CONCEPCION",
            "CONCORDIA",
            "CONESA",
            "CONFLUENCIA",
            "CONHELO",
            "CONSTITUCION",
            "COPO",
            "CORONEL DE MARINA L ROSALES",
            "CORONEL DORREGO",
            "CORONEL FELIPE VARELA",
            "CORONEL PRINGLES",
            "CORONEL PRINGLES",
            "CORONEL SUAREZ",
            "CORPEN AIKE",
            "CRUZ ALTA",
            "CRUZ DEL EJE",
            "CURACO",
            "CURUZU CUATIA",
            "CUSHAMEN",
            "DAIREAUX",
            "DESEADO",
            "DIAMANTE",
            "DOCTOR MANUEL BELGRANO",
            "DOLORES",
            "EL ALTO",
            "EL CARMEN",
            "EL CUY",
            "ELDORADO",
            "EMPEDRADO",
            "ENSENADA",
            "ESCALANTE",
            "ESCOBAR",
            "ESQUINA",
            "ESTEBAN ECHEVERRIA",
            "EXALTACIÓN DE LA CRUZ",
            "EZEIZA",
            "FAMAILLA",
            "FAMATINA",
            "FEDERACION",
            "FEDERAL",
            "FELICIANO",
            "FIGUEROA",
            "FLORENCIO VARELA",
            "FLORENTINO AMEGHINO",
            "FLORENTINO AMEGHINO",
            "FORMOSA",
            "FRAY JUSTO SANTA MARÍA DE ORO",
            "FRAY MAMERTO ESQUIU",
            "FUTALEUFU",
            "GAIMAN",
            "GARAY",
            "GASTRE",
            "GENERAL ALVARADO",
            "GENERAL ALVEAR",
            "GENERAL ALVEAR",
            "GENERAL ALVEAR",
            "GENERAL ÁNGEL VERA PEÑALOZA",
            "GENERAL ARENALES",
            "GENERAL BELGRANO",
            "GENERAL BELGRANO",
            "GENERAL BELGRANO",
            "GENERAL DONOVAN",
            "GENERAL GUEMES",
            "GENERAL GUEMES",
            "GENERAL GUIDO",
            "GENERAL JOSE DE SAN MARTÍN",
            "GENERAL JUAN F QUIROGA",
            "GENERAL JUAN MADARIAGA",
            "GENERAL LA MADRID",
            "GENERAL LAMADRID",
            "GENERAL LAS HERAS",
            "GENERAL LAVALLE",
            "GENERAL LOPEZ",
            "GENERAL MANUEL BELGRANO",
            "GENERAL OBLIGADO",
            "GENERAL OCAMPO",
            "GENERAL PAZ",
            "GENERAL PAZ",
            "GENERAL PEDERNERA",
            "GENERAL PINTO",
            "GENERAL PUEYRREDON",
            "GENERAL ROCA",
            "GENERAL ROCA",
            "GENERAL RODRIGUEZ",
            "GENERAL SAN MARTIN",
            "GENERAL SAN MARTIN",
            "GENERAL SAN MARTÍN",
            "GENERAL TABOADA",
            "GENERAL VIAMONTE",
            "GENERAL VILLEGAS",
            "GOBERNADOR DUPUY",
            "GODOY CRUZ",
            "GOYA",
            "GRANEROS",
            "GUACHIPAS",
            "GUALEGUAY",
            "GUALEGUAYCHU",
            "GUAMINI",
            "GUARANI",
            "GUASAYAN",
            "GUATRACHE",
            "GUAYMALLEN",
            "GUER AIKE",
            "HIPOLITO YRIGOYEN",
            "HUCAL",
            "HUILICHES",
            "HUMAHUACA",
            "HURLINGHAM",
            "IGLESIA",
            "IGUAZU",
            "INDEPENDENCIA",
            "INDEPENDENCIA",
            "IRIONDO",
            "IRUYA",
            "ISCHILIN",
            "ISLAS DEL ATLANTICO SUR",
            "ISLAS DEL IBICUY",
            "ITATI",
            "ITUZAINGO",
            "ITUZAINGO",
            "JACHAL",
            "JIMENEZ",
            "JOSE C PAZ",
            "JUAN B ALBERDI",
            "JUAN F IBARRA",
            "JUAN MARTÍN DE PUEYRREDÓN",
            "JUAREZ CELMAN",
            "JUNIN",
            "JUNIN",
            "JUNIN",
            "LA CALDERA",
            "LA CANDELARIA",
            "LA CAPITAL",
            "LA COCHA",
            "LA COSTA",
            "LA MATANZA",
            "LA PAZ",
            "LA PAZ",
            "LA PAZ",
            "LA PLATA",
            "LA POMA",
            "LA VIÑA",
            "LACAR",
            "LAGO ARGENTINO",
            "LAGO BUENOS AIRES",
            "LAISHI",
            "LANGUIÑEO",
            "LANÚS",
            "LAPRIDA",
            "LAS COLONIAS",
            "LAS FLORES",
            "LAS HERAS",
            "LAVALLE",
            "LAVALLE",
            "LEALES",
            "LEANDRO N ALEM",
            "LEANDRO N. ALEM",
            "LEDESMA",
            "LEZAMA",
            "LIBERTAD",
            "LIBERTADOR GENERAL SAN MARTÍN",
            "LIBERTADOR GENERAL SAN MARTÍN",
            "LIBERTADOR GENERAL SAN MARTÍN",
            "LIHUEL CALEL",
            "LIMAY MAHUIDA",
            "LINCOLN",
            "LOBERIA",
            "LOBOS",
            "LOMAS DE ZAMORA",
            "LONCOPUE",
            "LORETO",
            "LOS ANDES",
            "LOS LAGOS",
            "LOVENTUE",
            "LUJAN",
            "LUJAN DE CUYO",
            "LULES",
            "MAGALLANES",
            "MAGDALENA",
            "MAIPU",
            "MAIPU",
            "MAIPU",
            "MALARGUE",
            "MALVINAS ARGENTINAS",
            "MAR CHIQUITA",
            "MARACO",
            "MARCOS JUAREZ",
            "MARCOS PAZ",
            "MARTIRES",
            "MATACOS",
            "MAYOR LUIS J FONTANA",
            "MBURUCUYA",
            "MERCEDES",
            "MERCEDES",
            "MERLO",
            "METAN",
            "MINAS",
            "MINAS",
            "MITRE",
            "MOLINOS",
            "MONTE",
            "MONTE CASEROS",
            "MONTE HERMOSO",
            "MONTECARLO",
            "MONTEROS",
            "MORENO",
            "MORENO",
            "MORON",
            "NAVARRO",
            "NECOCHEA",
            "NOGOYA",
            "ÑORQUIN",
            "ÑORQUINCO",
            "O HIGGINS",
            "OBERA",
            "OJO DE AGUA",
            "OLAVARRIA",
            "ORAN",
            "PACLIN",
            "PALPALA",
            "PARANA",
            "PASO DE INDIOS",
            "PASO DE LOS LIBRES",
            "PATAGONES",
            "PATIÑO",
            "PEHUAJO",
            "PEHUENCHES",
            "PELLEGRINI",
            "PELLEGRINI",
            "PERGAMINO",
            "PICHI MAHUIDA",
            "PICUN LEUFU",
            "PICUNCHES",
            "PILA",
            "PILAGAS",
            "PILAR",
            "PILCANIYEU",
            "PILCOMAYO",
            "PINAMAR",
            "PIRANE",
            "POCHO",
            "POCITO",
            "POMAN",
            "PRESIDENCIA DE LA PLAZA",
            "PRESIDENTE PERON",
            "PRESIDENTE ROQUE SAENZ PEÑA",
            "PUAN",
            "PUELEN",
            "PUNILLA",
            "PUNTA INDIO",
            "QUEBRACHOS",
            "QUEMU QUEMU",
            "QUILMES",
            "QUITILIPI",
            "RAMALLO",
            "RAMON LISTA",
            "RANCUL",
            "RAUCH",
            "RAWSON",
            "RAWSON",
            "REALICO",
            "RINCONADA",
            "RIO CHICO",
            "RÍO CHICO",
            "RIO CUARTO",
            "RIO GRANDE",
            "RIO HONDO",
            "RIO PRIMERO",
            "RIO SECO",
            "RIO SEGUNDO",
            "RIO SENGUER",
            "RIVADAVIA",
            "RIVADAVIA",
            "RIVADAVIA",
            "RIVADAVIA",
            "RIVADAVIA",
            "ROBLES",
            "ROJAS",
            "ROQUE PEREZ",
            "ROSARIO",
            "ROSARIO DE LA FRONTERA",
            "ROSARIO DE LERMA",
            "ROSARIO VERA PEÑALOZA",
            "SAAVEDRA",
            "SALADAS",
            "SALADILLO",
            "SALAVINA",
            "SALLIQUELO",
            "SALTO",
            "SAN ALBERTO",
            "SAN ANDRES DE GILES",
            "SAN ANTONIO",
            "SAN ANTONIO",
            "SAN ANTONIO DE ARECO",
            "SAN BLAS DE LOS SAUCES",
            "SAN CARLOS",
            "SAN CARLOS",
            "SAN CAYETANO",
            "SAN COSME",
            "SAN CRISTOBAL",
            "SAN FERNANDO",
            "SAN FERNANDO",
            "SAN IGNACIO",
            "SAN ISIDRO",
            "SAN JAVIER",
            "SAN JAVIER",
            "SAN JAVIER",
            "SAN JERONIMO",
            "SAN JUSTO",
            "SAN JUSTO",
            "SAN LORENZO",
            "SAN LORENZO",
            "SAN LUIS DEL PALMAR",
            "SAN MARTIN",
            "SAN MARTIN",
            "SAN MARTIN",
            "SAN MARTIN",
            "SAN MARTIN",
            "SAN MIGUEL",
            "SAN MIGUEL",
            "SAN NICOLAS",
            "SAN PEDRO",
            "SAN PEDRO",
            "SAN PEDRO",
            "SAN RAFAEL",
            "SAN ROQUE",
            "SAN SALVADOR",
            "SAN VICENTE",
            "SANAGASTA",
            "SANTA BARBARA",
            "SANTA CATALINA",
            "SANTA LUCIA",
            "SANTA MARIA",
            "SANTA MARÍA",
            "SANTA ROSA",
            "SANTA ROSA",
            "SANTA VICTORIA",
            "SANTO TOME",
            "SARGENTO CABRAL",
            "SARMIENTO",
            "SARMIENTO",
            "SARMIENTO",
            "SAUCE",
            "SILIPICA",
            "SIMOCA",
            "SOBREMONTE",
            "SUIPACHA",
            "SUSQUES",
            "TAFI DEL VALLE",
            "TAFI VIEJO",
            "TALA",
            "TANDIL",
            "TAPALQUE",
            "TAPENAGA",
            "TEHUELCHES",
            "TELSEN",
            "TERCERO ARRIBA",
            "TIGRE",
            "TILCARA",
            "TINOGASTA",
            "TOAY",
            "TOLHUIN",
            "TORDILLO",
            "TORNQUIST",
            "TOTORAL",
            "TRANCAS",
            "TRENEL",
            "TRENQUE LAUQUEN",
            "TRES ARROYOS",
            "TRES DE FEBRERO",
            "TRES LOMAS",
            "TULUMBA",
            "TUMBAYA",
            "TUNUYAN",
            "TUPUNGATO",
            "ULLUM",
            "UNION",
            "URUGUAY",
            "USHUAIA",
            "UTRACAN",
            "VALCHETA",
            "VALLE FERTIL",
            "VALLE GRANDE",
            "VALLE VIEJO",
            "VERA",
            "VICENTE LOPEZ",
            "VICTORIA",
            "VILLA GESELL",
            "VILLAGUAY",
            "VILLARINO",
            "VINCHINA",
            "YAVI",
            "YERBA BUENA",
            "ZAPALA",
            "ZARATE",
            "ZONDA"});
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(154, 279);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(212, 21);
            this.cboDepartamento.TabIndex = 0;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // cboProvincia
            // 
            this.cboProvincia.AutoCompleteCustomSource.AddRange(new string[] {
            "Seleccione",
            "BUENOS AIRES",
            "CATAMARCA",
            "CHACO",
            "CHUBUT",
            "CIUDAD DE BUENOS AIRES",
            "CÓRDOBA",
            "CORRIENTES",
            "ENTRE RÍOS",
            "FORMOSA",
            "JUJUY",
            "LA PAMPA",
            "LA RIOJA",
            "MENDOZA",
            "MISIONES",
            "NEUQUÉN",
            "RÍO NEGRO",
            "SALTA",
            "SAN JUAN",
            "SAN LUIS",
            "SANTA CRUZ",
            "SANTA FE",
            "SANTIAGO DEL ESTERO",
            "TIERRA DEL FUEGO, ANTÁRTIDA E ISLAS DEL ATLÁNTICO SUR",
            "TUCUMÁN"});
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(154, 247);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(212, 21);
            this.cboProvincia.TabIndex = 0;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // txtDepto
            // 
            this.txtDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txtDepto.Location = new System.Drawing.Point(153, 477);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(66, 27);
            this.txtDepto.TabIndex = 95;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label14.Location = new System.Drawing.Point(20, 477);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 24);
            this.label14.TabIndex = 94;
            this.label14.Text = "Depto";
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.TxtMail.Location = new System.Drawing.Point(152, 510);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(214, 27);
            this.TxtMail.TabIndex = 86;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.TxtTelefono.Location = new System.Drawing.Point(152, 576);
            this.TxtTelefono.MaxLength = 13;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(214, 27);
            this.TxtTelefono.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 68;
            this.label2.Text = "Telefono";
            // 
            // TxtPiso
            // 
            this.TxtPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.TxtPiso.Location = new System.Drawing.Point(153, 444);
            this.TxtPiso.MaxLength = 3;
            this.TxtPiso.Name = "TxtPiso";
            this.TxtPiso.Size = new System.Drawing.Size(66, 27);
            this.TxtPiso.TabIndex = 83;
            // 
            // TxtBarrio
            // 
            this.TxtBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.TxtBarrio.Location = new System.Drawing.Point(153, 345);
            this.TxtBarrio.Name = "TxtBarrio";
            this.TxtBarrio.Size = new System.Drawing.Size(213, 27);
            this.TxtBarrio.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 69;
            this.label4.Text = "Calle";
            // 
            // TxtAltura
            // 
            this.TxtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.TxtAltura.Location = new System.Drawing.Point(153, 411);
            this.TxtAltura.MaxLength = 5;
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(67, 27);
            this.TxtAltura.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 71;
            this.label6.Text = "Departamento";
            // 
            // TxtOcupacion
            // 
            this.TxtOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.TxtOcupacion.Location = new System.Drawing.Point(152, 543);
            this.TxtOcupacion.Name = "TxtOcupacion";
            this.TxtOcupacion.Size = new System.Drawing.Size(214, 27);
            this.TxtOcupacion.TabIndex = 80;
            // 
            // TxtCalle
            // 
            this.TxtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.TxtCalle.Location = new System.Drawing.Point(153, 378);
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Size = new System.Drawing.Size(213, 27);
            this.TxtCalle.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 24);
            this.label7.TabIndex = 77;
            this.label7.Text = "Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 24);
            this.label8.TabIndex = 76;
            this.label8.Text = "Localidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 75;
            this.label9.Text = "Barrio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 74;
            this.label10.Text = "Altura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 543);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 24);
            this.label11.TabIndex = 73;
            this.label11.Text = "Ocupacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 72;
            this.label5.Text = "Provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(20, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 70;
            this.label3.Text = "Piso";
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.Controls.Add(this.dataRepeater1.ItemTemplate);
            this.dataRepeater1.Location = new System.Drawing.Point(0, 0);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(240, 150);
            this.dataRepeater1.TabIndex = 0;
            // 
            // Agregacliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1052, 683);
            this.Controls.Add(this.cboLocalidad);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPiso);
            this.Controls.Add(this.TxtBarrio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtOcupacion);
            this.Controls.Add(this.TxtCalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Agregacliente";
            this.Text = "Agregacliente";
            this.Load += new System.EventHandler(this.Agregacliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPiso;
        private System.Windows.Forms.TextBox TxtBarrio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtOcupacion;
        private System.Windows.Forms.TextBox TxtCalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.GroupBox groupBox1;
        //private System.Windows.Forms.Label label15;
        //private System.Windows.Forms.Label label12;
        //private System.Windows.Forms.TextBox TxtNombre;
        //private System.Windows.Forms.TextBox TxtApellido;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.TextBox TxtDocumento;
        //private System.Windows.Forms.Label label13;
        //private System.Windows.Forms.Label lblId;
        //private System.Windows.Forms.Button btnRefrescar;
        //private System.Windows.Forms.Panel panelTitulo;
        //private System.Windows.Forms.Button btnMinimizar;
        //private System.Windows.Forms.Button btnMaximizar;
        //private System.Windows.Forms.Button btnCerrar;
        //private System.Windows.Forms.Label lblCliente;
        //private System.Windows.Forms.PictureBox pictureBox2;
        //private System.Windows.Forms.Button btnModificar;
        //private System.Windows.Forms.Button btnEliminar;
        //private System.Windows.Forms.Button btnSalir;
        //private System.Windows.Forms.TextBox txtDepto;
        //private System.Windows.Forms.Label label14;
        //private System.Windows.Forms.ComboBox cboProvincia;
        //private System.Windows.Forms.ComboBox cboDepartamento;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        //private System.Windows.Forms.ComboBox cboLocalidad;
    }
}