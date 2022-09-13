
namespace VisualProject
{
    partial class ClientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfo));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.edit_button = new System.Windows.Forms.Button();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Search_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.show_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView.Location = new System.Drawing.Point(154, 173);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 25;
            this.DataGridView.Size = new System.Drawing.Size(730, 306);
            this.DataGridView.TabIndex = 10;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // edit_button
            // 
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit_button.ForeColor = System.Drawing.Color.BlueViolet;
            this.edit_button.Location = new System.Drawing.Point(321, 520);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(86, 26);
            this.edit_button.TabIndex = 12;
            this.edit_button.Text = "UPDATE";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // Search_tb
            // 
            this.Search_tb.BackColor = System.Drawing.Color.White;
            this.Search_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_tb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search_tb.Location = new System.Drawing.Point(638, 136);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(246, 22);
            this.Search_tb.TabIndex = 14;
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.Transparent;
            this.Search_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search_button.ForeColor = System.Drawing.Color.BlueViolet;
            this.Search_button.Location = new System.Drawing.Point(498, 136);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(122, 22);
            this.Search_button.TabIndex = 15;
            this.Search_button.Text = "Search : ";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(356, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Information";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Date.ForeColor = System.Drawing.Color.GhostWhite;
            this.Date.Location = new System.Drawing.Point(753, 78);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(54, 23);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Table_Click);
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
            this.panel1.Size = new System.Drawing.Size(1033, 117);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.BlueViolet;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(12, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Back";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-add-64 (1).png");
            this.imageList1.Images.SetKeyName(1, "icons8-back-arrow-50 (1).png");
            // 
            // show_btn
            // 
            this.show_btn.FlatAppearance.BorderSize = 0;
            this.show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.show_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.show_btn.Location = new System.Drawing.Point(413, 520);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(86, 26);
            this.show_btn.TabIndex = 19;
            this.show_btn.Text = "SHOW";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1033, 564);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search_tb);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ClientInfo";
            this.Text = "ClientInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientInfo_FormClosing);
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button show_btn;
    }
}