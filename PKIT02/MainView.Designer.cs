
namespace PKIT02
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.activeWorkerLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.activeWorker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // activeWorkerLabel
            // 
            this.activeWorkerLabel.AutoSize = true;
            this.activeWorkerLabel.BackColor = System.Drawing.Color.Transparent;
            this.activeWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeWorkerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.activeWorkerLabel.Location = new System.Drawing.Point(12, 49);
            this.activeWorkerLabel.Name = "activeWorkerLabel";
            this.activeWorkerLabel.Size = new System.Drawing.Size(259, 16);
            this.activeWorkerLabel.TabIndex = 0;
            this.activeWorkerLabel.Text = "Total pegawai yang sedang dinas hari ini: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.dateLabel.Location = new System.Drawing.Point(993, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(59, 16);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Tanggal";
            this.dateLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(118)))), ((int)(((byte)(175)))));
            this.buttonAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddWorker.ForeColor = System.Drawing.Color.White;
            this.buttonAddWorker.Location = new System.Drawing.Point(15, 81);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(130, 36);
            this.buttonAddWorker.TabIndex = 2;
            this.buttonAddWorker.Text = "Tambah Pegawai";
            this.buttonAddWorker.UseVisualStyleBackColor = false;
            this.buttonAddWorker.Click += new System.EventHandler(this.buttonAddWorker_Click);
            // 
            // activeWorker
            // 
            this.activeWorker.AutoSize = true;
            this.activeWorker.BackColor = System.Drawing.Color.Transparent;
            this.activeWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.activeWorker.Location = new System.Drawing.Point(277, 49);
            this.activeWorker.Name = "activeWorker";
            this.activeWorker.Size = new System.Drawing.Size(107, 16);
            this.activeWorker.TabIndex = 3;
            this.activeWorker.Text = "Jumlah Pegawai";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.activeWorker);
            this.Controls.Add(this.buttonAddWorker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.activeWorkerLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "Aplikasi Surat Tugas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activeWorkerLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button buttonAddWorker;
        private System.Windows.Forms.Label activeWorker;
    }
}

