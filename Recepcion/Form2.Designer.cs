namespace Recepcion
{
    partial class Form2
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
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.id_nombre = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPageMoficar = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPageEliminaciones = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.id_nombre.SuspendLayout();
            this.tabPageMoficar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPageEliminaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(445, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 46);
            this.button3.TabIndex = 0;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Fechas});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(838, 247);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "correo";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "telefono";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Fechas
            // 
            this.Fechas.HeaderText = "Fecha";
            this.Fechas.MinimumWidth = 8;
            this.Fechas.Name = "Fechas";
            this.Fechas.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(-2, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox4.ForeColor = System.Drawing.Color.Snow;
            this.textBox4.Location = new System.Drawing.Point(103, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 27);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(10, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Correo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox5.ForeColor = System.Drawing.Color.Snow;
            this.textBox5.Location = new System.Drawing.Point(103, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(178, 27);
            this.textBox5.TabIndex = 7;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(10, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox6.ForeColor = System.Drawing.Color.Snow;
            this.textBox6.Location = new System.Drawing.Point(103, 84);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(178, 27);
            this.textBox6.TabIndex = 9;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.id_nombre);
            this.tabControl1.Controls.Add(this.tabPageMoficar);
            this.tabControl1.Controls.Add(this.tabPageEliminaciones);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 498);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // id_nombre
            // 
            this.id_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.id_nombre.Controls.Add(this.textBox7);
            this.id_nombre.Controls.Add(this.label19);
            this.id_nombre.Controls.Add(this.dataGridView1);
            this.id_nombre.Controls.Add(this.button3);
            this.id_nombre.Controls.Add(this.textBox4);
            this.id_nombre.Controls.Add(this.label4);
            this.id_nombre.Controls.Add(this.textBox5);
            this.id_nombre.Controls.Add(this.label5);
            this.id_nombre.Controls.Add(this.textBox6);
            this.id_nombre.Controls.Add(this.label6);
            this.id_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_nombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.id_nombre.Location = new System.Drawing.Point(4, 33);
            this.id_nombre.Name = "id_nombre";
            this.id_nombre.Padding = new System.Windows.Forms.Padding(3);
            this.id_nombre.Size = new System.Drawing.Size(844, 461);
            this.id_nombre.TabIndex = 0;
            this.id_nombre.Text = "Agregar";
            this.id_nombre.Click += new System.EventHandler(this.id_nombre_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox7.ForeColor = System.Drawing.Color.Snow;
            this.textBox7.Location = new System.Drawing.Point(465, 28);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(202, 27);
            this.textBox7.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label19.Location = new System.Drawing.Point(391, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 21);
            this.label19.TabIndex = 15;
            this.label19.Text = "Fecha";
            // 
            // tabPageMoficar
            // 
            this.tabPageMoficar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.tabPageMoficar.Controls.Add(this.label7);
            this.tabPageMoficar.Controls.Add(this.dataGridView3);
            this.tabPageMoficar.Controls.Add(this.textBox8);
            this.tabPageMoficar.Controls.Add(this.textBox9);
            this.tabPageMoficar.Controls.Add(this.textBox10);
            this.tabPageMoficar.Controls.Add(this.textBox11);
            this.tabPageMoficar.Controls.Add(this.label8);
            this.tabPageMoficar.Controls.Add(this.button5);
            this.tabPageMoficar.Controls.Add(this.button6);
            this.tabPageMoficar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabPageMoficar.Location = new System.Drawing.Point(4, 33);
            this.tabPageMoficar.Name = "tabPageMoficar";
            this.tabPageMoficar.Size = new System.Drawing.Size(844, 461);
            this.tabPageMoficar.TabIndex = 2;
            this.tabPageMoficar.Text = "Modificar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(65, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nombre";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Fecha});
            this.dataGridView3.Location = new System.Drawing.Point(-4, 190);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(853, 198);
            this.dataGridView3.TabIndex = 15;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Nombre";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 200;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Correo";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.Width = 200;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Telèfono";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.Width = 200;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox8.Location = new System.Drawing.Point(69, 124);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(166, 27);
            this.textBox8.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox9.Location = new System.Drawing.Point(295, 124);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(194, 27);
            this.textBox9.TabIndex = 13;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox10.Location = new System.Drawing.Point(559, 124);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(162, 27);
            this.textBox10.TabIndex = 12;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox11.ForeColor = System.Drawing.Color.Snow;
            this.textBox11.Location = new System.Drawing.Point(176, 38);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(173, 27);
            this.textBox11.TabIndex = 11;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(599, 21);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 37);
            this.button5.TabIndex = 9;
            this.button5.Text = "Actualizar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(452, 21);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 37);
            this.button6.TabIndex = 8;
            this.button6.Text = "Buscar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabPageEliminaciones
            // 
            this.tabPageEliminaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.tabPageEliminaciones.Controls.Add(this.label17);
            this.tabPageEliminaciones.Controls.Add(this.button7);
            this.tabPageEliminaciones.Controls.Add(this.dataGridView4);
            this.tabPageEliminaciones.Controls.Add(this.textBox12);
            this.tabPageEliminaciones.Controls.Add(this.label9);
            this.tabPageEliminaciones.Location = new System.Drawing.Point(4, 33);
            this.tabPageEliminaciones.Name = "tabPageEliminaciones";
            this.tabPageEliminaciones.Size = new System.Drawing.Size(844, 461);
            this.tabPageEliminaciones.TabIndex = 3;
            this.tabPageEliminaciones.Text = "Busqueda";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(155, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 21);
            this.label17.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(393, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 33);
            this.button7.TabIndex = 11;
            this.button7.Text = "Buscar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Fecha1});
            this.dataGridView4.Location = new System.Drawing.Point(3, 139);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.Size = new System.Drawing.Size(968, 218);
            this.dataGridView4.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Fecha1
            // 
            this.Fecha1.HeaderText = "Fecha";
            this.Fecha1.MinimumWidth = 8;
            this.Fecha1.Name = "Fecha1";
            this.Fecha1.Width = 150;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox12.Location = new System.Drawing.Point(159, 23);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(188, 27);
            this.textBox12.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Cornsilk;
            this.label9.Location = new System.Drawing.Point(61, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Busqueda";
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(907, 539);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.id_nombre.ResumeLayout(false);
            this.id_nombre.PerformLayout();
            this.tabPageMoficar.ResumeLayout(false);
            this.tabPageMoficar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPageEliminaciones.ResumeLayout(false);
            this.tabPageEliminaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage id_nombre;
        private System.Windows.Forms.TabPage tabPageMoficar;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPageEliminaciones;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label19;
    }
}