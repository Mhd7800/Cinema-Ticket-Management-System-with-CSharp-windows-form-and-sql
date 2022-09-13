
namespace VisualProject
{
    partial class DataGridView_Staff
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridView_Staff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Staff_Search_button = new System.Windows.Forms.Button();
            this.Staff_Search_tb = new System.Windows.Forms.TextBox();
            this.StaffEdit_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Date = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 108);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(420, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Information";
            // 
            // Staff_Search_button
            // 
            this.Staff_Search_button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_Search_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Staff_Search_button.ForeColor = System.Drawing.Color.BlueViolet;
            this.Staff_Search_button.Location = new System.Drawing.Point(200, 124);
            this.Staff_Search_button.Name = "Staff_Search_button";
            this.Staff_Search_button.Size = new System.Drawing.Size(160, 23);
            this.Staff_Search_button.TabIndex = 18;
            this.Staff_Search_button.Text = "Search : ";
            this.Staff_Search_button.UseVisualStyleBackColor = false;
            this.Staff_Search_button.Click += new System.EventHandler(this.Staff_Search_button_Click);
            // 
            // Staff_Search_tb
            // 
            this.Staff_Search_tb.BackColor = System.Drawing.Color.White;
            this.Staff_Search_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Staff_Search_tb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Staff_Search_tb.Location = new System.Drawing.Point(366, 124);
            this.Staff_Search_tb.Name = "Staff_Search_tb";
            this.Staff_Search_tb.Size = new System.Drawing.Size(467, 22);
            this.Staff_Search_tb.TabIndex = 17;
            // 
            // StaffEdit_button
            // 
            this.StaffEdit_button.FlatAppearance.BorderSize = 0;
            this.StaffEdit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffEdit_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StaffEdit_button.ForeColor = System.Drawing.Color.BlueViolet;
            this.StaffEdit_button.Location = new System.Drawing.Point(138, 490);
            this.StaffEdit_button.Name = "StaffEdit_button";
            this.StaffEdit_button.Size = new System.Drawing.Size(86, 26);
            this.StaffEdit_button.TabIndex = 26;
            this.StaffEdit_button.Text = "UPDATE";
            this.StaffEdit_button.UseVisualStyleBackColor = true;
            this.StaffEdit_button.Click += new System.EventHandler(this.StaffEdit_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(633, 319);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-add-64 (1).png");
            this.imageList1.Images.SetKeyName(1, "icons8-back-arrow-50 (1).png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.BlueViolet;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(12, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 42);
            this.button2.TabIndex = 37;
            this.button2.Text = "Back";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.BlueViolet;
            this.button1.Location = new System.Drawing.Point(250, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 38;
            this.button1.Text = "SHOW RECORD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Date.ForeColor = System.Drawing.Color.GhostWhite;
            this.Date.Location = new System.Drawing.Point(945, 74);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(54, 23);
            this.Date.TabIndex = 2;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // DataGridView_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StaffEdit_button);
            this.Controls.Add(this.Staff_Search_button);
            this.Controls.Add(this.Staff_Search_tb);
            this.Controls.Add(this.panel1);
            this.Name = "DataGridView_Staff";
            this.Text = "Staff_Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataGridView_Staff_FormClosing);
            this.Load += new System.EventHandler(this.Staff_Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Staff_Search_button;
        private System.Windows.Forms.TextBox Staff_Search_tb;
        private System.Windows.Forms.Button StaffEdit_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}