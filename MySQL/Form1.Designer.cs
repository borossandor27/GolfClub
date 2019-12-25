namespace MySQL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_Szuletett = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_Tagok = new System.Windows.Forms.ListBox();
            this.button_Insert = new System.Windows.Forms.Button();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(98, 73);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(176, 20);
            this.textBox_Nev.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nev";
            // 
            // dateTimePicker_Szuletett
            // 
            this.dateTimePicker_Szuletett.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Szuletett.Location = new System.Drawing.Point(98, 133);
            this.dateTimePicker_Szuletett.Name = "dateTimePicker_Szuletett";
            this.dateTimePicker_Szuletett.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker_Szuletett.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Született";
            // 
            // listBox_Tagok
            // 
            this.listBox_Tagok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Tagok.FormattingEnabled = true;
            this.listBox_Tagok.Location = new System.Drawing.Point(3, 16);
            this.listBox_Tagok.Name = "listBox_Tagok";
            this.listBox_Tagok.Size = new System.Drawing.Size(296, 431);
            this.listBox_Tagok.TabIndex = 6;
            this.listBox_Tagok.SelectedIndexChanged += new System.EventHandler(this.listBox_Tagok_SelectedIndexChanged);
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(49, 261);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(238, 34);
            this.button_Insert.TabIndex = 7;
            this.button_Insert.Text = "Rögzítés";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(98, 19);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(176, 20);
            this.textBox_Id.TabIndex = 2;
            this.textBox_Id.TabStop = false;
            this.textBox_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(49, 311);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(238, 34);
            this.button_Update.TabIndex = 7;
            this.button_Update.Text = "Kiválasztott módosítása";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(49, 363);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(238, 34);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Kiválasztott törlése";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Tagok);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(312, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 450);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Club tags";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_Nev);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker_Szuletett);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 207);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A Club tag adatai";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Insert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nagymenők Golf  Club Tagjai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szuletett;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_Tagok;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

