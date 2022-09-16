namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.lbl_left = new System.Windows.Forms.Label();
            this.lbl_plus = new System.Windows.Forms.Label();
            this.lbl_right = new System.Windows.Forms.Label();
            this.lbl_equal = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_start = new System.Windows.Forms.Button();
            this.time_left1 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_left
            // 
            this.lbl_left.AutoSize = true;
            this.lbl_left.Location = new System.Drawing.Point(18, 52);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(62, 13);
            this.lbl_left.TabIndex = 0;
            this.lbl_left.Text = "left_number";
            // 
            // lbl_plus
            // 
            this.lbl_plus.AutoSize = true;
            this.lbl_plus.Location = new System.Drawing.Point(86, 52);
            this.lbl_plus.Name = "lbl_plus";
            this.lbl_plus.Size = new System.Drawing.Size(13, 13);
            this.lbl_plus.TabIndex = 1;
            this.lbl_plus.Text = "+";
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.Location = new System.Drawing.Point(105, 52);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(68, 13);
            this.lbl_right.TabIndex = 2;
            this.lbl_right.Text = "right_number";
            // 
            // lbl_equal
            // 
            this.lbl_equal.AutoSize = true;
            this.lbl_equal.Location = new System.Drawing.Point(179, 52);
            this.lbl_equal.Name = "lbl_equal";
            this.lbl_equal.Size = new System.Drawing.Size(13, 13);
            this.lbl_equal.TabIndex = 3;
            this.lbl_equal.Text = "=";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(207, 50);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(79, 110);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // time_left1
            // 
            this.time_left1.AutoSize = true;
            this.time_left1.Location = new System.Drawing.Point(65, 163);
            this.time_left1.Name = "time_left1";
            this.time_left1.Size = new System.Drawing.Size(89, 13);
            this.time_left1.TabIndex = 6;
            this.time_left1.Text = "Remaining Time :";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(160, 163);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(13, 13);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "5";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 296);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.time_left1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_equal);
            this.Controls.Add(this.lbl_right);
            this.Controls.Add(this.lbl_plus);
            this.Controls.Add(this.lbl_left);
            this.Name = "Form1";
            this.Text = "A New Simple Game";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label lbl_plus;
        private System.Windows.Forms.Label lbl_right;
        private System.Windows.Forms.Label lbl_equal;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label time_left1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
    }
}

