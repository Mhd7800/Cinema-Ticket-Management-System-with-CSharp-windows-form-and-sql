
namespace VisualProject
{
    partial class Seans_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seans_List));
            this.Seans_Add_btn = new System.Windows.Forms.Button();
            this.Seans_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Seans_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Seans_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Seans_Add_btn
            // 
            this.Seans_Add_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Seans_Add_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.Seans_Add_btn.Location = new System.Drawing.Point(468, 358);
            this.Seans_Add_btn.Name = "Seans_Add_btn";
            this.Seans_Add_btn.Size = new System.Drawing.Size(115, 31);
            this.Seans_Add_btn.TabIndex = 0;
            this.Seans_Add_btn.Text = "All Sessions";
            this.Seans_Add_btn.UseVisualStyleBackColor = true;
            this.Seans_Add_btn.Click += new System.EventHandler(this.Seans_Add_btn_Click);
            // 
            // Seans_dataGridView1
            // 
            this.Seans_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Seans_dataGridView1.Location = new System.Drawing.Point(39, 97);
            this.Seans_dataGridView1.Name = "Seans_dataGridView1";
            this.Seans_dataGridView1.RowTemplate.Height = 25;
            this.Seans_dataGridView1.Size = new System.Drawing.Size(544, 255);
            this.Seans_dataGridView1.TabIndex = 1;
            // 
            // Seans_dateTimePicker1
            // 
            this.Seans_dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Seans_dateTimePicker1.Location = new System.Drawing.Point(454, 68);
            this.Seans_dateTimePicker1.Name = "Seans_dateTimePicker1";
            this.Seans_dateTimePicker1.Size = new System.Drawing.Size(129, 23);
            this.Seans_dateTimePicker1.TabIndex = 2;
            this.Seans_dateTimePicker1.ValueChanged += new System.EventHandler(this.Seans_dateTimePicker1_ValueChanged);
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
            this.button2.Location = new System.Drawing.Point(319, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 19;
            this.button2.Text = "Back";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Seans_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 464);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Seans_dateTimePicker1);
            this.Controls.Add(this.Seans_dataGridView1);
            this.Controls.Add(this.Seans_Add_btn);
            this.Name = "Seans_List";
            this.Text = "Seans_List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Seans_List_FormClosing);
            this.Load += new System.EventHandler(this.Seans_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Seans_dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Seans_Add_btn;
        private System.Windows.Forms.DataGridView Seans_dataGridView1;
        private System.Windows.Forms.DateTimePicker Seans_dateTimePicker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
    }
}