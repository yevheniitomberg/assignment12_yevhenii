namespace assignment12_yevhenii
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
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_emp_num = new System.Windows.Forms.NumericUpDown();
            this.input_hourly_pay = new System.Windows.Forms.NumericUpDown();
            this.select_shift = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_list = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.input_emp_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_hourly_pay)).BeginInit();
            this.SuspendLayout();
            // 
            // input_name
            // 
            this.input_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_name.Location = new System.Drawing.Point(193, 79);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(100, 26);
            this.input_name.TabIndex = 0;
            // 
            // input_emp_num
            // 
            this.input_emp_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_emp_num.Location = new System.Drawing.Point(341, 80);
            this.input_emp_num.Name = "input_emp_num";
            this.input_emp_num.Size = new System.Drawing.Size(120, 26);
            this.input_emp_num.TabIndex = 1;
            // 
            // input_hourly_pay
            // 
            this.input_hourly_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_hourly_pay.Location = new System.Drawing.Point(512, 80);
            this.input_hourly_pay.Name = "input_hourly_pay";
            this.input_hourly_pay.Size = new System.Drawing.Size(120, 26);
            this.input_hourly_pay.TabIndex = 2;
            // 
            // select_shift
            // 
            this.select_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.select_shift.FormattingEnabled = true;
            this.select_shift.Location = new System.Drawing.Point(683, 80);
            this.select_shift.Name = "select_shift";
            this.select_shift.Size = new System.Drawing.Size(121, 28);
            this.select_shift.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(372, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create New Production Worker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(722, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shift";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(508, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hourly Pay Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(337, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(215, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // label_list
            // 
            this.label_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_list.Location = new System.Drawing.Point(39, 182);
            this.label_list.Name = "label_list";
            this.label_list.Size = new System.Drawing.Size(927, 229);
            this.label_list.TabIndex = 9;
            // 
            // button_create
            // 
            this.button_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_create.Location = new System.Drawing.Point(427, 123);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(119, 37);
            this.button_create.TabIndex = 10;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 437);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.label_list);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_shift);
            this.Controls.Add(this.input_hourly_pay);
            this.Controls.Add(this.input_emp_num);
            this.Controls.Add(this.input_name);
            this.Name = "Form1";
            this.Text = "Worker Data";
            ((System.ComponentModel.ISupportInitialize)(this.input_emp_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_hourly_pay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.NumericUpDown input_emp_num;
        private System.Windows.Forms.NumericUpDown input_hourly_pay;
        private System.Windows.Forms.ComboBox select_shift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_list;
        private System.Windows.Forms.Button button_create;
    }
}

