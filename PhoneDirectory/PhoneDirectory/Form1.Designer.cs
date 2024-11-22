namespace PhoneDirectory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.number_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.mail_txtbox = new System.Windows.Forms.TextBox();
            this.surname_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_photo_bttn = new System.Windows.Forms.Button();
            this.photo_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clear_bttn = new System.Windows.Forms.Button();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.update_bttn = new System.Windows.Forms.Button();
            this.add_bttn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 386);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.number_txtbox);
            this.groupBox2.Controls.Add(this.mail_txtbox);
            this.groupBox2.Controls.Add(this.surname_txtbox);
            this.groupBox2.Controls.Add(this.name_txtbox);
            this.groupBox2.Controls.Add(this.id_txtbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.add_photo_bttn);
            this.groupBox2.Controls.Add(this.photo_txtbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.clear_bttn);
            this.groupBox2.Controls.Add(this.delete_bttn);
            this.groupBox2.Controls.Add(this.update_bttn);
            this.groupBox2.Controls.Add(this.add_bttn);
            this.groupBox2.Location = new System.Drawing.Point(617, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Contact";
            // 
            // number_txtbox
            // 
            this.number_txtbox.BackColor = System.Drawing.Color.LightGray;
            this.number_txtbox.Location = new System.Drawing.Point(127, 134);
            this.number_txtbox.Mask = "(999) 000-0000";
            this.number_txtbox.Name = "number_txtbox";
            this.number_txtbox.Size = new System.Drawing.Size(258, 27);
            this.number_txtbox.TabIndex = 2;
            // 
            // mail_txtbox
            // 
            this.mail_txtbox.BackColor = System.Drawing.Color.LightGray;
            this.mail_txtbox.Location = new System.Drawing.Point(127, 167);
            this.mail_txtbox.Name = "mail_txtbox";
            this.mail_txtbox.Size = new System.Drawing.Size(258, 27);
            this.mail_txtbox.TabIndex = 3;
            // 
            // surname_txtbox
            // 
            this.surname_txtbox.BackColor = System.Drawing.Color.LightGray;
            this.surname_txtbox.Location = new System.Drawing.Point(127, 101);
            this.surname_txtbox.Name = "surname_txtbox";
            this.surname_txtbox.Size = new System.Drawing.Size(258, 27);
            this.surname_txtbox.TabIndex = 1;
            // 
            // name_txtbox
            // 
            this.name_txtbox.BackColor = System.Drawing.Color.LightGray;
            this.name_txtbox.Location = new System.Drawing.Point(127, 68);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(258, 27);
            this.name_txtbox.TabIndex = 0;
            // 
            // id_txtbox
            // 
            this.id_txtbox.BackColor = System.Drawing.Color.LightGray;
            this.id_txtbox.Enabled = false;
            this.id_txtbox.Location = new System.Drawing.Point(127, 35);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(258, 27);
            this.id_txtbox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mail: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Surname: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID: ";
            // 
            // add_photo_bttn
            // 
            this.add_photo_bttn.BackColor = System.Drawing.Color.LightGray;
            this.add_photo_bttn.Location = new System.Drawing.Point(57, 253);
            this.add_photo_bttn.Name = "add_photo_bttn";
            this.add_photo_bttn.Size = new System.Drawing.Size(185, 32);
            this.add_photo_bttn.TabIndex = 5;
            this.add_photo_bttn.Text = "Add/Update Photograph";
            this.add_photo_bttn.UseVisualStyleBackColor = false;
            this.add_photo_bttn.Click += new System.EventHandler(this.add_photo_bttn_Click);
            // 
            // photo_txtbox
            // 
            this.photo_txtbox.BackColor = System.Drawing.Color.LightGray;
            this.photo_txtbox.Location = new System.Drawing.Point(127, 200);
            this.photo_txtbox.Name = "photo_txtbox";
            this.photo_txtbox.Size = new System.Drawing.Size(258, 27);
            this.photo_txtbox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Photograph: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(262, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // clear_bttn
            // 
            this.clear_bttn.BackColor = System.Drawing.Color.LightGray;
            this.clear_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear_bttn.Location = new System.Drawing.Point(248, 358);
            this.clear_bttn.Name = "clear_bttn";
            this.clear_bttn.Size = new System.Drawing.Size(137, 32);
            this.clear_bttn.TabIndex = 9;
            this.clear_bttn.Text = "Clear";
            this.clear_bttn.UseVisualStyleBackColor = false;
            this.clear_bttn.Click += new System.EventHandler(this.clear_bttn_Click);
            // 
            // delete_bttn
            // 
            this.delete_bttn.BackColor = System.Drawing.Color.LightGray;
            this.delete_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_bttn.Location = new System.Drawing.Point(105, 358);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(137, 32);
            this.delete_bttn.TabIndex = 8;
            this.delete_bttn.Text = "Delete";
            this.delete_bttn.UseVisualStyleBackColor = false;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            // 
            // update_bttn
            // 
            this.update_bttn.BackColor = System.Drawing.Color.LightGray;
            this.update_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_bttn.Location = new System.Drawing.Point(248, 320);
            this.update_bttn.Name = "update_bttn";
            this.update_bttn.Size = new System.Drawing.Size(137, 32);
            this.update_bttn.TabIndex = 7;
            this.update_bttn.Text = "Update";
            this.update_bttn.UseVisualStyleBackColor = false;
            this.update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            // 
            // add_bttn
            // 
            this.add_bttn.BackColor = System.Drawing.Color.LightGray;
            this.add_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_bttn.Location = new System.Drawing.Point(105, 320);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(137, 32);
            this.add_bttn.TabIndex = 6;
            this.add_bttn.Text = "Add";
            this.add_bttn.UseVisualStyleBackColor = false;
            this.add_bttn.Click += new System.EventHandler(this.add_bttn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Directory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clear_bttn;
        private System.Windows.Forms.Button delete_bttn;
        private System.Windows.Forms.Button update_bttn;
        private System.Windows.Forms.Button add_bttn;
        private System.Windows.Forms.Button add_photo_bttn;
        private System.Windows.Forms.TextBox photo_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox number_txtbox;
        private System.Windows.Forms.TextBox mail_txtbox;
        private System.Windows.Forms.TextBox surname_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

