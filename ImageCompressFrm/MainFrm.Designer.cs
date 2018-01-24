namespace ImageCompressFrm
{
    partial class MainFrm
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
            this.btn_selectImage = new System.Windows.Forms.Button();
            this.lb_imagePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_compressionRatio = new System.Windows.Forms.NumericUpDown();
            this.num_imageReductionMultiplier = new System.Windows.Forms.NumericUpDown();
            this.btn_compressImage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_compressionRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_imageReductionMultiplier)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_selectImage);
            this.groupBox1.Controls.Add(this.lb_imagePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像选择";
            // 
            // btn_selectImage
            // 
            this.btn_selectImage.Location = new System.Drawing.Point(30, 45);
            this.btn_selectImage.Name = "btn_selectImage";
            this.btn_selectImage.Size = new System.Drawing.Size(151, 23);
            this.btn_selectImage.TabIndex = 2;
            this.btn_selectImage.Text = "选择图像";
            this.btn_selectImage.UseVisualStyleBackColor = true;
            this.btn_selectImage.Click += new System.EventHandler(this.btn_selectImage_Click);
            // 
            // lb_imagePath
            // 
            this.lb_imagePath.AutoSize = true;
            this.lb_imagePath.Location = new System.Drawing.Point(69, 21);
            this.lb_imagePath.Name = "lb_imagePath";
            this.lb_imagePath.Size = new System.Drawing.Size(0, 12);
            this.lb_imagePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "路径:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.num_compressionRatio);
            this.groupBox2.Controls.Add(this.num_imageReductionMultiplier);
            this.groupBox2.Controls.Add(this.btn_compressImage);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "压缩设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "缩小倍数(1-100):1为原本大小";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "压缩率(1-100):压缩率越低图像越模糊";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "提示:";
            // 
            // num_compressionRatio
            // 
            this.num_compressionRatio.Location = new System.Drawing.Point(120, 80);
            this.num_compressionRatio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_compressionRatio.Name = "num_compressionRatio";
            this.num_compressionRatio.Size = new System.Drawing.Size(120, 21);
            this.num_compressionRatio.TabIndex = 4;
            this.num_compressionRatio.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // num_imageReductionMultiplier
            // 
            this.num_imageReductionMultiplier.Location = new System.Drawing.Point(120, 32);
            this.num_imageReductionMultiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_imageReductionMultiplier.Name = "num_imageReductionMultiplier";
            this.num_imageReductionMultiplier.Size = new System.Drawing.Size(120, 21);
            this.num_imageReductionMultiplier.TabIndex = 3;
            this.num_imageReductionMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_compressImage
            // 
            this.btn_compressImage.Location = new System.Drawing.Point(31, 120);
            this.btn_compressImage.Name = "btn_compressImage";
            this.btn_compressImage.Size = new System.Drawing.Size(75, 23);
            this.btn_compressImage.TabIndex = 2;
            this.btn_compressImage.Text = "压缩";
            this.btn_compressImage.UseVisualStyleBackColor = true;
            this.btn_compressImage.Click += new System.EventHandler(this.btn_compressImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "压缩率:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图片缩小倍数:";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 287);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainFrm";
            this.Text = "图片压缩工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_compressionRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_imageReductionMultiplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_selectImage;
        private System.Windows.Forms.Label lb_imagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_compressionRatio;
        private System.Windows.Forms.NumericUpDown num_imageReductionMultiplier;
        private System.Windows.Forms.Button btn_compressImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}