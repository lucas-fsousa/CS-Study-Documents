
namespace Componentes {
    partial class f_pictureBox {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_img1 = new System.Windows.Forms.Button();
            this.btn_img2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_img1
            // 
            this.btn_img1.Location = new System.Drawing.Point(402, 24);
            this.btn_img1.Name = "btn_img1";
            this.btn_img1.Size = new System.Drawing.Size(75, 23);
            this.btn_img1.TabIndex = 3;
            this.btn_img1.Text = "Imagem 1";
            this.btn_img1.UseVisualStyleBackColor = true;
            this.btn_img1.Click += new System.EventHandler(this.btn_img1_Click);
            // 
            // btn_img2
            // 
            this.btn_img2.Location = new System.Drawing.Point(402, 63);
            this.btn_img2.Name = "btn_img2";
            this.btn_img2.Size = new System.Drawing.Size(75, 23);
            this.btn_img2.TabIndex = 4;
            this.btn_img2.Text = "Imagem 2";
            this.btn_img2.UseVisualStyleBackColor = true;
            this.btn_img2.Click += new System.EventHandler(this.btn_img2_Click);
            // 
            // f_pictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 504);
            this.Controls.Add(this.btn_img2);
            this.Controls.Add(this.btn_img1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "f_pictureBox";
            this.Text = "f_pictureBox";
            this.Load += new System.EventHandler(this.f_pictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_img1;
        private System.Windows.Forms.Button btn_img2;
    }
}