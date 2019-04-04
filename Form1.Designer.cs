namespace ArrayList_ve_List
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lstData = new System.Windows.Forms.ListBox();
            this.btnDizi = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnList2 = new System.Windows.Forms.Button();
            this.btnRenklendir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(402, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(236, 252);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(28, 87);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(343, 251);
            this.lstData.TabIndex = 1;
            // 
            // btnDizi
            // 
            this.btnDizi.Location = new System.Drawing.Point(28, 33);
            this.btnDizi.Name = "btnDizi";
            this.btnDizi.Size = new System.Drawing.Size(75, 23);
            this.btnDizi.TabIndex = 2;
            this.btnDizi.Text = "Array";
            this.btnDizi.UseVisualStyleBackColor = true;
            this.btnDizi.Click += new System.EventHandler(this.btnDizi_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(147, 33);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(75, 23);
            this.btnArrayList.TabIndex = 3;
            this.btnArrayList.Text = "Array List";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(270, 33);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(402, 33);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(75, 23);
            this.btnList2.TabIndex = 5;
            this.btnList2.Text = "Butonlar";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // btnRenklendir
            // 
            this.btnRenklendir.Location = new System.Drawing.Point(540, 33);
            this.btnRenklendir.Name = "btnRenklendir";
            this.btnRenklendir.Size = new System.Drawing.Size(75, 23);
            this.btnRenklendir.TabIndex = 6;
            this.btnRenklendir.Text = "Renklendir";
            this.btnRenklendir.UseVisualStyleBackColor = true;
            this.btnRenklendir.Visible = false;
            this.btnRenklendir.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.btnRenklendir);
            this.Controls.Add(this.btnList2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.btnDizi);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Button btnDizi;
        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnList2;
        private System.Windows.Forms.Button btnRenklendir;
    }
}

