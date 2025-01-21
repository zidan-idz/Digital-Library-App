namespace Digital_Library_Management
{
    partial class Borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow));
            this.delete = new System.Windows.Forms.Button();
            this.correct = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.keluar = new System.Windows.Forms.Button();
            this.borrow_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.member_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.book_id = new System.Windows.Forms.TextBox();
            this.return_schedule = new System.Windows.Forms.DateTimePicker();
            this.borrow_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cls = new System.Windows.Forms.Button();
            this.member_table = new System.Windows.Forms.Button();
            this.book_table = new System.Windows.Forms.Button();
            this.borrow_table = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Crimson;
            this.delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete.Location = new System.Drawing.Point(332, 355);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(97, 27);
            this.delete.TabIndex = 19;
            this.delete.Text = "Hapus";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // correct
            // 
            this.correct.BackColor = System.Drawing.Color.SteelBlue;
            this.correct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.correct.Location = new System.Drawing.Point(195, 355);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(97, 27);
            this.correct.TabIndex = 18;
            this.correct.Text = "Perbarui";
            this.correct.UseVisualStyleBackColor = false;
            this.correct.Click += new System.EventHandler(this.correct_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.ForestGreen;
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(57, 355);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(97, 27);
            this.add.TabIndex = 17;
            this.add.Text = "Tambahkan";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // keluar
            // 
            this.keluar.BackColor = System.Drawing.Color.Maroon;
            this.keluar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.keluar.Location = new System.Drawing.Point(358, 628);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(100, 34);
            this.keluar.TabIndex = 4;
            this.keluar.Text = "Kembali >";
            this.keluar.UseVisualStyleBackColor = false;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // borrow_id
            // 
            this.borrow_id.Location = new System.Drawing.Point(225, 95);
            this.borrow_id.Name = "borrow_id";
            this.borrow_id.Size = new System.Drawing.Size(202, 22);
            this.borrow_id.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(25, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jadwal Pengembalian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Peminjaman";
            // 
            // member_id
            // 
            this.member_id.Location = new System.Drawing.Point(225, 136);
            this.member_id.Name = "member_id";
            this.member_id.Size = new System.Drawing.Size(202, 22);
            this.member_id.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(25, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tanggal Peminjaman";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(227, 293);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(200, 24);
            this.status.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(24, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Anggota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID Buku";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(776, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Data Peminjaman";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.cls);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.book_id);
            this.panel1.Controls.Add(this.return_schedule);
            this.panel1.Controls.Add(this.borrow_date);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.correct);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.keluar);
            this.panel1.Controls.Add(this.borrow_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.member_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 675);
            this.panel1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(25, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "Status";
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(227, 176);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(202, 22);
            this.book_id.TabIndex = 24;
            // 
            // return_schedule
            // 
            this.return_schedule.Location = new System.Drawing.Point(225, 255);
            this.return_schedule.Name = "return_schedule";
            this.return_schedule.Size = new System.Drawing.Size(202, 22);
            this.return_schedule.TabIndex = 21;
            // 
            // borrow_date
            // 
            this.borrow_date.Location = new System.Drawing.Point(227, 216);
            this.borrow_date.Name = "borrow_date";
            this.borrow_date.Size = new System.Drawing.Size(202, 22);
            this.borrow_date.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(221, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Borrows";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 414);
            this.dataGridView1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-11, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 38);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Digital_Library_Management.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(1142, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // cls
            // 
            this.cls.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cls.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cls.Location = new System.Drawing.Point(446, 195);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(30, 24);
            this.cls.TabIndex = 23;
            this.cls.Text = "⇄";
            this.cls.UseVisualStyleBackColor = true;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            // 
            // member_table
            // 
            this.member_table.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.member_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_table.Location = new System.Drawing.Point(780, 575);
            this.member_table.Name = "member_table";
            this.member_table.Size = new System.Drawing.Size(37, 23);
            this.member_table.TabIndex = 23;
            this.member_table.Text = "1";
            this.member_table.UseVisualStyleBackColor = false;
            this.member_table.Click += new System.EventHandler(this.member_table_Click);
            // 
            // book_table
            // 
            this.book_table.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.book_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_table.Location = new System.Drawing.Point(839, 575);
            this.book_table.Name = "book_table";
            this.book_table.Size = new System.Drawing.Size(37, 23);
            this.book_table.TabIndex = 24;
            this.book_table.Text = "2";
            this.book_table.UseVisualStyleBackColor = false;
            this.book_table.Click += new System.EventHandler(this.book_table_Click);
            // 
            // borrow_table
            // 
            this.borrow_table.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.borrow_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_table.Location = new System.Drawing.Point(896, 575);
            this.borrow_table.Name = "borrow_table";
            this.borrow_table.Size = new System.Drawing.Size(37, 23);
            this.borrow_table.TabIndex = 25;
            this.borrow_table.Text = "3";
            this.borrow_table.UseVisualStyleBackColor = false;
            this.borrow_table.Click += new System.EventHandler(this.borrow_table_Click);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.borrow_table);
            this.Controls.Add(this.book_table);
            this.Controls.Add(this.member_table);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.Borrow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button correct;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.TextBox borrow_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox member_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker return_schedule;
        private System.Windows.Forms.DateTimePicker borrow_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.Button cls;
        private System.Windows.Forms.Button member_table;
        private System.Windows.Forms.Button book_table;
        private System.Windows.Forms.Button borrow_table;
    }
}