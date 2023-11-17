namespace Lab0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            asd = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // asd
            // 
            asd.AutoSize = true;
            asd.Location = new Point(112, 215);
            asd.Name = "asd";
            asd.Size = new Size(168, 20);
            asd.TabIndex = 0;
            asd.Text = "Chukiat Kammaneechan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 276);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "663450174-1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 332);
            label3.Name = "label3";
            label3.Size = new Size(240, 20);
            label3.TabIndex = 2;
            label3.Text = "Computer and Information Science";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(432, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 406);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(asd);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label asd;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
