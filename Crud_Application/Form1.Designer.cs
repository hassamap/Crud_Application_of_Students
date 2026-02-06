namespace Crud_Application
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NAMEtextBox = new System.Windows.Forms.TextBox();
            this.AGEtextBox = new System.Windows.Forms.TextBox();
            this.GENDERtextBox = new System.Windows.Forms.TextBox();
            this.STANDARDtextBox = new System.Windows.Forms.TextBox();
            this.INSERTbutton = new System.Windows.Forms.Button();
            this.UPDATEbutton = new System.Windows.Forms.Button();
            this.DELbutton = new System.Windows.Forms.Button();
            this.CLEARbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT APP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Standard";
            // 
            // NAMEtextBox
            // 
            this.NAMEtextBox.Location = new System.Drawing.Point(280, 77);
            this.NAMEtextBox.Name = "NAMEtextBox";
            this.NAMEtextBox.Size = new System.Drawing.Size(314, 22);
            this.NAMEtextBox.TabIndex = 0;
            // 
            // AGEtextBox
            // 
            this.AGEtextBox.Location = new System.Drawing.Point(280, 113);
            this.AGEtextBox.Name = "AGEtextBox";
            this.AGEtextBox.Size = new System.Drawing.Size(314, 22);
            this.AGEtextBox.TabIndex = 1;
            // 
            // GENDERtextBox
            // 
            this.GENDERtextBox.Location = new System.Drawing.Point(280, 152);
            this.GENDERtextBox.Name = "GENDERtextBox";
            this.GENDERtextBox.Size = new System.Drawing.Size(314, 22);
            this.GENDERtextBox.TabIndex = 2;
            // 
            // STANDARDtextBox
            // 
            this.STANDARDtextBox.Location = new System.Drawing.Point(280, 194);
            this.STANDARDtextBox.Name = "STANDARDtextBox";
            this.STANDARDtextBox.Size = new System.Drawing.Size(314, 22);
            this.STANDARDtextBox.TabIndex = 3;
            // 
            // INSERTbutton
            // 
            this.INSERTbutton.Location = new System.Drawing.Point(87, 231);
            this.INSERTbutton.Name = "INSERTbutton";
            this.INSERTbutton.Size = new System.Drawing.Size(117, 47);
            this.INSERTbutton.TabIndex = 4;
            this.INSERTbutton.Text = "INSERT";
            this.INSERTbutton.UseVisualStyleBackColor = true;
            this.INSERTbutton.Click += new System.EventHandler(this.INSERTbutton_Click);
            // 
            // UPDATEbutton
            // 
            this.UPDATEbutton.Location = new System.Drawing.Point(228, 231);
            this.UPDATEbutton.Name = "UPDATEbutton";
            this.UPDATEbutton.Size = new System.Drawing.Size(117, 47);
            this.UPDATEbutton.TabIndex = 5;
            this.UPDATEbutton.Text = "UPDATE";
            this.UPDATEbutton.UseVisualStyleBackColor = true;
            this.UPDATEbutton.Click += new System.EventHandler(this.UPDATEbutton_Click);
            // 
            // DELbutton
            // 
            this.DELbutton.Location = new System.Drawing.Point(366, 231);
            this.DELbutton.Name = "DELbutton";
            this.DELbutton.Size = new System.Drawing.Size(117, 47);
            this.DELbutton.TabIndex = 6;
            this.DELbutton.Text = "DEl";
            this.DELbutton.UseVisualStyleBackColor = true;
            this.DELbutton.Click += new System.EventHandler(this.DELbutton_Click);
            // 
            // CLEARbutton
            // 
            this.CLEARbutton.Location = new System.Drawing.Point(522, 231);
            this.CLEARbutton.Name = "CLEARbutton";
            this.CLEARbutton.Size = new System.Drawing.Size(117, 47);
            this.CLEARbutton.TabIndex = 7;
            this.CLEARbutton.Text = "CLEAR";
            this.CLEARbutton.UseVisualStyleBackColor = true;
            this.CLEARbutton.Click += new System.EventHandler(this.CLEARbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 188);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CLEARbutton);
            this.Controls.Add(this.DELbutton);
            this.Controls.Add(this.UPDATEbutton);
            this.Controls.Add(this.INSERTbutton);
            this.Controls.Add(this.STANDARDtextBox);
            this.Controls.Add(this.GENDERtextBox);
            this.Controls.Add(this.AGEtextBox);
            this.Controls.Add(this.NAMEtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NAMEtextBox;
        private System.Windows.Forms.TextBox AGEtextBox;
        private System.Windows.Forms.TextBox GENDERtextBox;
        private System.Windows.Forms.TextBox STANDARDtextBox;
        private System.Windows.Forms.Button INSERTbutton;
        private System.Windows.Forms.Button UPDATEbutton;
        private System.Windows.Forms.Button DELbutton;
        private System.Windows.Forms.Button CLEARbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

