namespace Generateur_identité
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IDD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTNOM = new System.Windows.Forms.TextBox();
            this.TXTPRENOM = new System.Windows.Forms.TextBox();
            this.TXTETUDE = new System.Windows.Forms.TextBox();
            this.TXTNUMERO = new System.Windows.Forms.TextBox();
            this.PIC_ID = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BTNRANDOM = new System.Windows.Forms.Button();
            this.RDFEMME = new System.Windows.Forms.RadioButton();
            this.RDHOMME = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNAPERCU = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BTNDOWNLOAD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ID)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDD
            // 
            this.IDD.AutoSize = true;
            this.IDD.Location = new System.Drawing.Point(6, 121);
            this.IDD.Name = "IDD";
            this.IDD.Size = new System.Drawing.Size(32, 25);
            this.IDD.TabIndex = 3;
            this.IDD.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ecole / Etude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telephone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date de naissance";
            // 
            // TXTID
            // 
            this.TXTID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TXTID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXTID.Location = new System.Drawing.Point(9, 149);
            this.TXTID.Name = "TXTID";
            this.TXTID.ReadOnly = true;
            this.TXTID.Size = new System.Drawing.Size(276, 32);
            this.TXTID.TabIndex = 10;
            this.TXTID.TextChanged += new System.EventHandler(this.TXTID_TextChanged);
            // 
            // TXTNOM
            // 
            this.TXTNOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTNOM.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXTNOM.Location = new System.Drawing.Point(9, 211);
            this.TXTNOM.Name = "TXTNOM";
            this.TXTNOM.Size = new System.Drawing.Size(276, 32);
            this.TXTNOM.TabIndex = 11;
            this.TXTNOM.TextChanged += new System.EventHandler(this.TXTNOM_TextChanged);
            // 
            // TXTPRENOM
            // 
            this.TXTPRENOM.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXTPRENOM.Location = new System.Drawing.Point(9, 273);
            this.TXTPRENOM.Name = "TXTPRENOM";
            this.TXTPRENOM.Size = new System.Drawing.Size(276, 32);
            this.TXTPRENOM.TabIndex = 12;
            this.TXTPRENOM.TextChanged += new System.EventHandler(this.TXTPRENOM_TextChanged);
            // 
            // TXTETUDE
            // 
            this.TXTETUDE.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXTETUDE.Location = new System.Drawing.Point(9, 335);
            this.TXTETUDE.Name = "TXTETUDE";
            this.TXTETUDE.Size = new System.Drawing.Size(276, 32);
            this.TXTETUDE.TabIndex = 13;
            this.TXTETUDE.TextChanged += new System.EventHandler(this.TXTETUDE_TextChanged);
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXTNUMERO.Location = new System.Drawing.Point(9, 400);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(275, 32);
            this.TXTNUMERO.TabIndex = 14;
            this.TXTNUMERO.TextChanged += new System.EventHandler(this.TXTNUMERO_TextChanged);
            // 
            // PIC_ID
            // 
            this.PIC_ID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PIC_ID.Location = new System.Drawing.Point(514, 35);
            this.PIC_ID.Name = "PIC_ID";
            this.PIC_ID.Size = new System.Drawing.Size(239, 327);
            this.PIC_ID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_ID.TabIndex = 17;
            this.PIC_ID.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.BTNRANDOM);
            this.groupBox1.Controls.Add(this.RDFEMME);
            this.groupBox1.Controls.Add(this.RDHOMME);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IDD);
            this.groupBox1.Controls.Add(this.TXTID);
            this.groupBox1.Controls.Add(this.TXTNOM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXTNUMERO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXTETUDE);
            this.groupBox1.Controls.Add(this.TXTPRENOM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(37, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 585);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "       Creation d\'une carte etudiante";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(9, 532);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(276, 32);
            this.dateTimePicker2.TabIndex = 25;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 470);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 32);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // BTNRANDOM
            // 
            this.BTNRANDOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNRANDOM.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNRANDOM.Location = new System.Drawing.Point(291, 150);
            this.BTNRANDOM.Name = "BTNRANDOM";
            this.BTNRANDOM.Size = new System.Drawing.Size(34, 31);
            this.BTNRANDOM.TabIndex = 23;
            this.BTNRANDOM.Text = "⮌";
            this.BTNRANDOM.UseVisualStyleBackColor = true;
            this.BTNRANDOM.Click += new System.EventHandler(this.BTNRANDOM_Click);
            // 
            // RDFEMME
            // 
            this.RDFEMME.AutoSize = true;
            this.RDFEMME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RDFEMME.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RDFEMME.Location = new System.Drawing.Point(112, 78);
            this.RDFEMME.Name = "RDFEMME";
            this.RDFEMME.Size = new System.Drawing.Size(94, 29);
            this.RDFEMME.TabIndex = 22;
            this.RDFEMME.TabStop = true;
            this.RDFEMME.Text = "Femme";
            this.RDFEMME.UseVisualStyleBackColor = true;
            this.RDFEMME.CheckedChanged += new System.EventHandler(this.RDFEMME_CheckedChanged);
            // 
            // RDHOMME
            // 
            this.RDHOMME.AutoSize = true;
            this.RDHOMME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RDHOMME.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RDHOMME.Location = new System.Drawing.Point(9, 78);
            this.RDHOMME.Name = "RDHOMME";
            this.RDHOMME.Size = new System.Drawing.Size(101, 29);
            this.RDHOMME.TabIndex = 21;
            this.RDHOMME.TabStop = true;
            this.RDHOMME.Text = "Homme";
            this.RDHOMME.UseVisualStyleBackColor = true;
            this.RDHOMME.CheckedChanged += new System.EventHandler(this.RDHOMME_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Valide jusqu\'au";
            // 
            // BTNAPERCU
            // 
            this.BTNAPERCU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNAPERCU.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BTNAPERCU.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNAPERCU.Location = new System.Drawing.Point(540, 474);
            this.BTNAPERCU.Name = "BTNAPERCU";
            this.BTNAPERCU.Size = new System.Drawing.Size(192, 63);
            this.BTNAPERCU.TabIndex = 19;
            this.BTNAPERCU.Text = "Voir aperçu";
            this.BTNAPERCU.UseVisualStyleBackColor = true;
            this.BTNAPERCU.Click += new System.EventHandler(this.BTNAPERCU_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BTNDOWNLOAD
            // 
            this.BTNDOWNLOAD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNDOWNLOAD.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BTNDOWNLOAD.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNDOWNLOAD.Location = new System.Drawing.Point(540, 404);
            this.BTNDOWNLOAD.Name = "BTNDOWNLOAD";
            this.BTNDOWNLOAD.Size = new System.Drawing.Size(192, 63);
            this.BTNDOWNLOAD.TabIndex = 20;
            this.BTNDOWNLOAD.Text = "Ajouter une photo";
            this.BTNDOWNLOAD.UseVisualStyleBackColor = true;
            this.BTNDOWNLOAD.Click += new System.EventHandler(this.BTNDOWNLOAD_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 655);
            this.Controls.Add(this.BTNDOWNLOAD);
            this.Controls.Add(this.BTNAPERCU);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PIC_ID);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Generateur de carte etudiante";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ID)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        
        
        private Label IDD;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TXTID;
        private TextBox TXTNOM;
        private TextBox TXTPRENOM;
        private TextBox TXTETUDE;
        private TextBox TXTNUMERO;
        private PictureBox PIC_ID;
        private GroupBox groupBox1;
        private Button BTNRANDOM;
        private RadioButton RDFEMME;
        private RadioButton RDHOMME;
        private Label label7;
        private Label label1;
        private Button BTNAPERCU;
        private OpenFileDialog openFileDialog1;
        private Button BTNDOWNLOAD;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}