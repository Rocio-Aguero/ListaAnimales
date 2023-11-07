namespace Lista3
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
            this.tsmMenu = new System.Windows.Forms.ToolStrip();
            this.tslRegistrar = new System.Windows.Forms.ToolStripLabel();
            this.tslConsultar = new System.Windows.Forms.ToolStripLabel();
            this.tslEliminar = new System.Windows.Forms.ToolStripLabel();
            this.tlsSALIR = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.txtboxEdad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsmMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // tsmMenu
            // 
            this.tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslRegistrar,
            this.tslConsultar,
            this.tslEliminar,
            this.tlsSALIR});
            this.tsmMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(800, 25);
            this.tsmMenu.TabIndex = 8;
            this.tsmMenu.Text = "toolStrip1";
            // 
            // tslRegistrar
            // 
            this.tslRegistrar.Name = "tslRegistrar";
            this.tslRegistrar.Size = new System.Drawing.Size(65, 22);
            this.tslRegistrar.Text = "REGISTRAR";
            this.tslRegistrar.Click += new System.EventHandler(this.tslRegistrar_Click_1);
            // 
            // tslConsultar
            // 
            this.tslConsultar.Name = "tslConsultar";
            this.tslConsultar.Size = new System.Drawing.Size(72, 22);
            this.tslConsultar.Text = "CONSULTAR";
            this.tslConsultar.Click += new System.EventHandler(this.tslConsultar_Click_1);
            // 
            // tslEliminar
            // 
            this.tslEliminar.Name = "tslEliminar";
            this.tslEliminar.Size = new System.Drawing.Size(60, 22);
            this.tslEliminar.Text = "ELIMINAR";
            this.tslEliminar.Click += new System.EventHandler(this.tslEliminar_Click_1);
            // 
            // tlsSALIR
            // 
            this.tlsSALIR.Name = "tlsSALIR";
            this.tlsSALIR.Size = new System.Drawing.Size(46, 22);
            this.tlsSALIR.Text = "SALIDA";
            this.tlsSALIR.Click += new System.EventHandler(this.tlsSALIR_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "RAZA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "EDAD:";
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(218, 32);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtboxNombre.TabIndex = 12;
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Items.AddRange(new object[] {
            "Affenpinscher",
            "Airedale terrier",
            "Akita",
            "Akita americano",
            "Alaskan Husky",
            "Alaskan malamute",
            "American Foxhound",
            "American pit bull terrier",
            "American staffordshire terrier",
            "Ariegeois",
            "Artois",
            "Australian silky terrier",
            "Australian Terrier",
            "Austrian Black & Tan Hound",
            "Azawakh",
            "Balkan Hound",
            "",
            "Basenji",
            "Basset Alpino (Alpine Dachsbracke)",
            "Basset Artesiano Normando",
            "Basset Azul de Gascuña (Basset Bleu de Gascogne)",
            "Basset de Artois",
            "Basset de Westphalie",
            "Basset Hound",
            "Basset Leonado de Bretaña (Basset fauve de Bretagne)",
            "Bavarian Mountain Scenthound",
            "Beagle",
            "Beagle Harrier",
            "Beauceron",
            "Bedlington Terrier",
            "Bichon Boloñes",
            "Bichón Frisé",
            "Bichón Habanero",
            "Billy",
            "Black and Tan Coonhound",
            "Bloodhound (Sabueso de San Huberto)",
            "Bobtail",
            "Boerboel",
            "Border Collie",
            "Border terrier",
            "Borzoi",
            "Bosnian Hound",
            "Boston terrier",
            "Bouvier des Flandres",
            "Boxer",
            "Boyero de Appenzell",
            "Boyero de Australia",
            "Boyero de Entlebuch",
            "Boyero de las Ardenas",
            "Boyero de Montaña Bernes",
            "Braco Alemán de pelo corto",
            "Braco Alemán de pelo duro",
            "Braco de Ariege",
            "Braco de Auvernia",
            "Braco de Bourbonnais",
            "Braco de Saint Germain",
            "Braco Dupuy",
            "Braco Francés",
            "Braco Italiano",
            "Broholmer",
            "Buhund Noruego",
            "Bull terrier",
            "Bulldog americano",
            "Bulldog inglés",
            "Bulldog francés",
            "Bullmastiff",
            "Ca de Bestiar",
            "Cairn terrier",
            "Cane Corso",
            "Cane da Pastore Maremmano-Abruzzese",
            "Caniche (Poodle)",
            "Caniche Toy (Toy Poodle)",
            "Cao da Serra de Aires",
            "Cao da Serra de Estrela",
            "Cao de Castro Laboreiro",
            "Cao de Fila de Sao Miguel",
            "Cavalier King Charles Spaniel",
            "Cesky Fousek",
            "Cesky Terrier",
            "Chesapeake Bay Retriever",
            "Chihuahua",
            "Chin",
            "Chow Chow",
            "Cirneco del Etna",
            "Clumber Spaniel",
            "Cocker Spaniel Americano",
            "Cocker Spaniel Inglés",
            "Collie Barbudo",
            "Collie de Pelo Cort",
            "Collie de Pelo Largo",
            "Cotón de Tuléar",
            "Curly Coated Retriever",
            "Dálmata",
            "Dandie dinmont terrier",
            "Deerhound",
            "Dobermann",
            "Dogo Argentino",
            "Dogo de Burdeos",
            "Dogo del Tibet",
            "Drentse Partridge Dog",
            "Drever",
            "Dunker",
            "Elkhound Noruego",
            "Elkhound Sueco",
            "English Foxhound",
            "English Springer Spaniel",
            "English Toy Terrier",
            "Epagneul Picard",
            "Eurasier",
            "Fila Brasileiro",
            "Finnish Lapphound",
            "Flat Coated Retriever",
            "Fox terrier de pelo de alambre",
            "Fox terrier de pelo liso",
            "Foxhound Inglés",
            "Frisian Pointer",
            "Galgo Español",
            "Galgo húngaro (Magyar Agar)",
            "Galgo Italiano",
            "Galgo Polaco (Chart Polski)",
            "Glen of Imaal Terrier",
            "Golden Retriever",
            "Gordon Setter",
            "Gos d\'Atura Catalá",
            "Gran Basset Griffon Vendeano",
            "Gran Boyero Suizo",
            "Gran Danés (Dogo Aleman)",
            "Gran Gascón Saintongeois",
            "Gran Griffon Vendeano",
            "Gran Munsterlander",
            "Gran Perro Japonés",
            "Grand Anglo Francais Tricoleur",
            "Grand Bleu de Gascogne",
            "Greyhound",
            "Griffon Bleu de Gascogne",
            "Griffon de pelo duro (Grifón Korthals)",
            "Griffon leonado de Bretaña",
            "Griffon Nivernais",
            "Grifon Belga",
            "Grifón de Bruselas",
            "Haldenstoever",
            "Harrier",
            "Hokkaido",
            "Hovawart",
            "Husky Siberiano (Siberian Husky)",
            "Ioujnorousskaia Ovtcharka",
            "Irish Glen of Imaal terrier",
            "Irish soft coated wheaten terrier",
            "Irish terrier",
            "Irish Water Spaniel",
            "Irish Wolfhound",
            "Jack Russell terrier",
            "Jindo Coreano",
            "Kai",
            "Keeshond",
            "Kelpie australiano (Australian kelpie)",
            "Kerry blue terrier",
            "King Charles Spaniel",
            "Kishu",
            "Komondor",
            "Kooiker",
            "Kromfohrländer",
            "Kuvasz",
            "Labrador Retriever",
            "Lagotto Romagnolo",
            "Laika de Siberia Occidental",
            "Laika de Siberia Oriental",
            "Laika Ruso Europeo",
            "Lakeland terrier",
            "Landseer",
            "Lapphund Sueco",
            "Lebrel Afgano",
            "Lebrel Arabe (Sloughi)",
            "Leonberger",
            "Lhasa Apso",
            "Lowchen (Pequeño Perro León)",
            "Lundehund Noruego",
            "Malamute de Alaska",
            "Maltés",
            "Manchester terrier",
            "Mastiff",
            "Mastín de los Pirineos",
            "Mastín Español",
            "Mastín Napolitano",
            "Mudi",
            "Norfolk terrier",
            "Norwich terrier",
            "Nova Scotia duck tolling retriever",
            "Ovejero alemán",
            "Otterhound",
            "Rafeiro do Alentejo",
            "Ratonero Bodeguero Andaluz",
            "Retriever de Nueva Escocia",
            "Rhodesian Ridgeback",
            "Ridgeback de Tailandia",
            "Rottweiler",
            "Saarloos",
            "Sabueso de Hamilton",
            "Sabueso de Hannover",
            "Sabueso de Hygen",
            "Sabueso de Istria",
            "Sabueso de Posavaz",
            "Sabueso de Schiller (Schillerstovare)",
            "Sabueso de Smaland (Smalandsstovare)",
            "Sabueso de Transilvania",
            "Sabueso del Tirol",
            "Sabueso Español",
            "Sabueso Estirio de pelo duro",
            "Sabueso Finlandés",
            "Sabueso Francés blanco y negro",
            "Sabueso Francés tricolor",
            "Sabueso Griego",
            "Sabueso Polaco (Ogar Polski)",
            "Sabueso Serbio",
            "Sabueso Suizo",
            "Sabueso Yugoslavo de Montaña",
            "Sabueso Yugoslavo tricolor",
            "Saluki",
            "Samoyedo",
            "San Bernardo",
            "Sarplaninac",
            "Schapendoes",
            "Schipperke",
            "Schnauzer estándar",
            "Schnauzer gigante (Riesenschnauzer)",
            "Schnauzer miniatura (Zwergschnauzer)",
            "Scottish terrier",
            "Sealyham terrier",
            "Segugio Italiano",
            "Seppala Siberiano",
            "Setter Inglés",
            "Setter Irlandés",
            "Setter Irlandés rojo y blanco",
            "Shar Pei",
            "Shiba Inu",
            "Shih Tzu",
            "Shikoku",
            "Skye terrier",
            "Slovensky Cuvac",
            "Slovensky Kopov",
            "Smoushond Holandés",
            "Spaniel Alemán (German Wachtelhund)",
            "Spaniel Azul de Picardía",
            "Spaniel Bretón",
            "Spaniel de Campo",
            "Spaniel de Pont Audemer",
            "Spaniel Francés",
            "Spaniel Tibetano",
            "Spinone Italiano",
            "Spítz Alemán",
            "Spitz de Norbotten (Norbottenspets)",
            "Spitz Finlandés",
            "Spitz Japonés",
            "Staffordshire bull terrier",
            "Staffordshire terrier americano",
            "Sussex Spaniel",
            "Teckel (Dachshund)",
            "Tchuvatch eslovaco",
            "Terranova (Newfoundland)",
            "Terrier australiano (Australian terrier)",
            "Terrier brasilero",
            "Terrier cazador alemán",
            "Terrier checo (Ceský teriér)",
            "Terrier galés",
            "Terrier irlandés (Irish terrier)",
            "Terrier japonés (Nihon teria)",
            "Terrier negro ruso",
            "Terrier tibetano",
            "Tosa",
            "Viejo Pastor Inglés",
            "Viejo Pointer Danés (Old Danish Pointer)",
            "Vizsla",
            "Volpino Italiano",
            "Weimaraner",
            "Welsh springer spaniel",
            "Welsh Corgi Cardigan",
            "Welsh Corgi Pembroke",
            "Welsh terrier",
            "West highland white terrier",
            "Whippet",
            "Wirehaired solvakian pointer",
            "Xoloitzcuintle",
            "Yorkshire Terrier",
            "Abisinio.",
            "Americano de pelo duro.",
            "Asiático.",
            "Azul ruso.",
            "Balinés.",
            "Bengalí",
            "Birmano.",
            "Bobtail japonés de pelo corto."});
            this.cmbRaza.Location = new System.Drawing.Point(218, 72);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(121, 21);
            this.cmbRaza.TabIndex = 13;
            // 
            // txtboxEdad
            // 
            this.txtboxEdad.Location = new System.Drawing.Point(218, 107);
            this.txtboxEdad.Name = "txtboxEdad";
            this.txtboxEdad.Size = new System.Drawing.Size(100, 20);
            this.txtboxEdad.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(436, 201);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(673, 201);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(410, 28);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(359, 150);
            this.dgvDatos.TabIndex = 17;
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtboxEdad);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsmMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tsmMenu.ResumeLayout(false);
            this.tsmMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsmMenu;
        private System.Windows.Forms.ToolStripLabel tslRegistrar;
        private System.Windows.Forms.ToolStripLabel tslConsultar;
        private System.Windows.Forms.ToolStripLabel tslEliminar;
        private System.Windows.Forms.ToolStripLabel tlsSALIR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.TextBox txtboxEdad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ErrorProvider erpError;
    }
}

