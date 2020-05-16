namespace HomeWork7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextBoxLeng = new System.Windows.Forms.TextBox();
            this.textBoxPer1 = new System.Windows.Forms.TextBox();
            this.textBoxPer2 = new System.Windows.Forms.TextBox();
            this.trackBarth1 = new System.Windows.Forms.TrackBar();
            this.trackBarth2 = new System.Windows.Forms.TrackBar();
            this.comboBoxPen = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarth2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 425);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(697, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBoxLeng
            // 
            this.TextBoxLeng.Location = new System.Drawing.Point(697, 81);
            this.TextBoxLeng.Name = "TextBoxLeng";
            this.TextBoxLeng.Size = new System.Drawing.Size(91, 21);
            this.TextBoxLeng.TabIndex = 2;
            // 
            // textBoxPer1
            // 
            this.textBoxPer1.Location = new System.Drawing.Point(697, 124);
            this.textBoxPer1.Name = "textBoxPer1";
            this.textBoxPer1.Size = new System.Drawing.Size(91, 21);
            this.textBoxPer1.TabIndex = 3;
            // 
            // textBoxPer2
            // 
            this.textBoxPer2.Location = new System.Drawing.Point(697, 166);
            this.textBoxPer2.Name = "textBoxPer2";
            this.textBoxPer2.Size = new System.Drawing.Size(91, 21);
            this.textBoxPer2.TabIndex = 4;
            // 
            // trackBarth1
            // 
            this.trackBarth1.Location = new System.Drawing.Point(684, 208);
            this.trackBarth1.Maximum = 180;
            this.trackBarth1.Name = "trackBarth1";
            this.trackBarth1.Size = new System.Drawing.Size(104, 45);
            this.trackBarth1.TabIndex = 16;
            // 
            // trackBarth2
            // 
            this.trackBarth2.Location = new System.Drawing.Point(684, 271);
            this.trackBarth2.Maximum = 180;
            this.trackBarth2.Name = "trackBarth2";
            this.trackBarth2.Size = new System.Drawing.Size(104, 45);
            this.trackBarth2.TabIndex = 17;
            // 
            // comboBoxPen
            // 
            this.comboBoxPen.FormattingEnabled = true;
            this.comboBoxPen.Location = new System.Drawing.Point(697, 335);
            this.comboBoxPen.Name = "comboBoxPen";
            this.comboBoxPen.Size = new System.Drawing.Size(91, 20);
            this.comboBoxPen.TabIndex = 18;
            this.comboBoxPen.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPen_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 59);
            this.button1.TabIndex = 19;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "递归深度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "主干长度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "右分支长度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "左分支长度比";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "左分支角度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "画笔颜色";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxPen);
            this.Controls.Add(this.trackBarth2);
            this.Controls.Add(this.trackBarth1);
            this.Controls.Add(this.textBoxPer2);
            this.Controls.Add(this.textBoxPer1);
            this.Controls.Add(this.TextBoxLeng);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarth2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextBoxLeng;
        private System.Windows.Forms.TextBox textBoxPer1;
        private System.Windows.Forms.TextBox textBoxPer2;
        private System.Windows.Forms.TrackBar trackBarth1;
        private System.Windows.Forms.TrackBar trackBarth2;
        private System.Windows.Forms.ComboBox comboBoxPen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

