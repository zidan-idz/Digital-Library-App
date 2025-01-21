namespace Digital_Library_Management
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.correct = new System.Windows.Forms.Button();
            this.member_id = new System.Windows.Forms.TextBox();
            this.telepon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cls = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-11, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 38);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(954, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Members";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.cls);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.correct);
            this.panel1.Controls.Add(this.member_id);
            this.panel1.Controls.Add(this.telepon);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(708, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 675);
            this.panel1.TabIndex = 4;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.ForestGreen;
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(48, 350);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(97, 27);
            this.add.TabIndex = 25;
            this.add.Text = "Tambahkan";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Maroon;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Location = new System.Drawing.Point(442, 628);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 34);
            this.exit.TabIndex = 22;
            this.exit.Text = "Kembali >";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Crimson;
            this.delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete.Location = new System.Drawing.Point(343, 350);
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
            this.correct.Location = new System.Drawing.Point(195, 350);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(97, 27);
            this.correct.TabIndex = 18;
            this.correct.Text = "Perbarui";
            this.correct.UseVisualStyleBackColor = false;
            this.correct.Click += new System.EventHandler(this.correct_Click);
            // 
            // member_id
            // 
            this.member_id.Location = new System.Drawing.Point(173, 93);
            this.member_id.Name = "member_id";
            this.member_id.Size = new System.Drawing.Size(233, 22);
            this.member_id.TabIndex = 7;
            // 
            // telepon
            // 
            this.telepon.Location = new System.Drawing.Point(173, 279);
            this.telepon.Name = "telepon";
            this.telepon.Size = new System.Drawing.Size(233, 22);
            this.telepon.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(24, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telepon";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(173, 229);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(233, 22);
            this.address.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Anggota";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(173, 136);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(233, 22);
            this.username.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(24, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alamat";
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Location = new System.Drawing.Point(173, 182);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(233, 24);
            this.gender.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(24, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(24, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jenis Kelamin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(654, 391);
            this.dataGridView1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(300, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Data Anggota";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Digital_Library_Management.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(27, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // cls
            // 
            this.cls.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cls.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cls.Location = new System.Drawing.Point(442, 184);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(30, 24);
            this.cls.TabIndex = 22;
            this.cls.Text = "⇄";
            this.cls.UseVisualStyleBackColor = true;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox member_id;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox telepon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button correct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cls;
    }
}