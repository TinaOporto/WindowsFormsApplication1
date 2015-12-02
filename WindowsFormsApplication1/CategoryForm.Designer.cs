namespace WindowsFormsApplication1
{
    partial class CategoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtcatdes = new System.Windows.Forms.TextBox();
            this.txtcatname = new System.Windows.Forms.TextBox();
            this.txticid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtupcatdes = new System.Windows.Forms.TextBox();
            this.txtupcatname = new System.Windows.Forms.TextBox();
            this.txtupicid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndelexit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.txtdelicid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.new_logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-9, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._new;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 100);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-6, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1230, 654);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.soft_pastel_vintage_with_pale_mint_green_background_solid_green_background_;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1222, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(527, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 255);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "icid";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "cat_name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "cat_description";
            this.Column3.Name = "Column3";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1111, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.soft_pastel_vintage_with_pale_mint_green_background_solid_green_background_;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txtcatdes);
            this.groupBox1.Controls.Add(this.txtcatname);
            this.groupBox1.Controls.Add(this.txticid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(54, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnadd.Location = new System.Drawing.Point(54, 223);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(126, 32);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtcatdes
            // 
            this.txtcatdes.Location = new System.Drawing.Point(36, 164);
            this.txtcatdes.Name = "txtcatdes";
            this.txtcatdes.Size = new System.Drawing.Size(153, 20);
            this.txtcatdes.TabIndex = 3;
            // 
            // txtcatname
            // 
            this.txtcatname.Location = new System.Drawing.Point(36, 104);
            this.txtcatname.Name = "txtcatname";
            this.txtcatname.Size = new System.Drawing.Size(153, 20);
            this.txtcatname.TabIndex = 3;
            // 
            // txticid
            // 
            this.txticid.Location = new System.Drawing.Point(36, 44);
            this.txticid.Name = "txticid";
            this.txticid.Size = new System.Drawing.Size(153, 20);
            this.txticid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ICID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.soft_pastel_vintage_with_pale_mint_green_background_solid_green_background_;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnexit);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1222, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(560, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 272);
            this.dataGridView2.TabIndex = 2;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "icid";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "cat_name";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "cat_description";
            this.Column6.Name = "Column6";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(1109, 19);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 35);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.soft_pastel_vintage_with_pale_mint_green_background_solid_green_background_;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtupcatdes);
            this.groupBox2.Controls.Add(this.txtupcatname);
            this.groupBox2.Controls.Add(this.txtupicid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(50, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 323);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleGreen;
            this.button4.Location = new System.Drawing.Point(50, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(50, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtupcatdes
            // 
            this.txtupcatdes.Location = new System.Drawing.Point(23, 173);
            this.txtupcatdes.Name = "txtupcatdes";
            this.txtupcatdes.Size = new System.Drawing.Size(175, 20);
            this.txtupcatdes.TabIndex = 1;
            // 
            // txtupcatname
            // 
            this.txtupcatname.Location = new System.Drawing.Point(23, 115);
            this.txtupcatname.Name = "txtupcatname";
            this.txtupcatname.Size = new System.Drawing.Size(175, 20);
            this.txtupcatname.TabIndex = 1;
            // 
            // txtupicid
            // 
            this.txtupicid.Location = new System.Drawing.Point(23, 57);
            this.txtupicid.Name = "txtupicid";
            this.txtupicid.Size = new System.Drawing.Size(175, 20);
            this.txtupicid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "New Category Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "New Category Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ICID";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.soft_pastel_vintage_with_pale_mint_green_background_solid_green_background_;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.btndelexit);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1222, 628);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView3.Location = new System.Drawing.Point(609, 71);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(343, 233);
            this.dataGridView3.TabIndex = 2;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "icid";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "cat_name";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "cat_description";
            this.Column9.Name = "Column9";
            // 
            // btndelexit
            // 
            this.btndelexit.BackColor = System.Drawing.Color.PaleGreen;
            this.btndelexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelexit.Location = new System.Drawing.Point(1090, 26);
            this.btndelexit.Name = "btndelexit";
            this.btndelexit.Size = new System.Drawing.Size(84, 42);
            this.btndelexit.TabIndex = 1;
            this.btndelexit.Text = "Exit";
            this.btndelexit.UseVisualStyleBackColor = false;
            this.btndelexit.Click += new System.EventHandler(this.btndelexit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.soft_pastel_vintage_with_pale_mint_green_background_solid_green_background_;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.btncancel);
            this.groupBox3.Controls.Add(this.btndel);
            this.groupBox3.Controls.Add(this.txtdelicid);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(54, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 233);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.PaleGreen;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(41, 183);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(145, 31);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.PaleGreen;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(41, 135);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(145, 31);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // txtdelicid
            // 
            this.txtdelicid.Location = new System.Drawing.Point(24, 63);
            this.txtdelicid.Name = "txtdelicid";
            this.txtdelicid.Size = new System.Drawing.Size(130, 22);
            this.txtdelicid.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "ICID";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.soft_pastel_vintage_with_pale_mint_green_background_solid_green_background_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 754);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcatdes;
        private System.Windows.Forms.TextBox txtcatname;
        private System.Windows.Forms.TextBox txticid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtupcatdes;
        private System.Windows.Forms.TextBox txtupcatname;
        private System.Windows.Forms.TextBox txtupicid;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btndelexit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.TextBox txtdelicid;
        private System.Windows.Forms.Label label7;
    }
}