
namespace PKIT02
{
    partial class InputWorker
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.nipLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nipInput = new System.Windows.Forms.TextBox();
            this.levelInput = new System.Windows.Forms.TextBox();
            this.labelJob = new System.Windows.Forms.Label();
            this.jobInput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(170, 73);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nama";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(170, 126);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(53, 13);
            this.levelLabel.TabIndex = 1;
            this.levelLabel.Text = "Golongan";
            this.levelLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // nipLabel
            // 
            this.nipLabel.AutoSize = true;
            this.nipLabel.Location = new System.Drawing.Point(170, 99);
            this.nipLabel.Name = "nipLabel";
            this.nipLabel.Size = new System.Drawing.Size(25, 13);
            this.nipLabel.TabIndex = 2;
            this.nipLabel.Text = "NIP";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(237, 70);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(226, 20);
            this.nameInput.TabIndex = 3;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // nipInput
            // 
            this.nipInput.Location = new System.Drawing.Point(237, 96);
            this.nipInput.Name = "nipInput";
            this.nipInput.Size = new System.Drawing.Size(226, 20);
            this.nipInput.TabIndex = 4;
            // 
            // levelInput
            // 
            this.levelInput.Location = new System.Drawing.Point(237, 123);
            this.levelInput.Name = "levelInput";
            this.levelInput.Size = new System.Drawing.Size(226, 20);
            this.levelInput.TabIndex = 5;
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Location = new System.Drawing.Point(170, 153);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(45, 13);
            this.labelJob.TabIndex = 6;
            this.labelJob.Text = "Jabatan";
            this.labelJob.Click += new System.EventHandler(this.label4_Click);
            // 
            // jobInput
            // 
            this.jobInput.Location = new System.Drawing.Point(237, 150);
            this.jobInput.Name = "jobInput";
            this.jobInput.Size = new System.Drawing.Size(226, 20);
            this.jobInput.TabIndex = 7;
            this.jobInput.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(315, 221);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Simpan";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // InputWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.jobInput);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.levelInput);
            this.Controls.Add(this.nipInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nipLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "InputWorker";
            this.Text = "Tambah Data Pegawai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label nipLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox nipInput;
        private System.Windows.Forms.TextBox levelInput;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.TextBox jobInput;
        private System.Windows.Forms.Button saveButton;
    }
}