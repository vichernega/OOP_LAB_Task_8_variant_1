namespace Task_8_variant_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_C = new System.Windows.Forms.Label();
            this.label_D = new System.Windows.Forms.Label();
            this.label_alert = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.btn_AplusBplusCplusD = new System.Windows.Forms.Button();
            this.btn_AplusB = new System.Windows.Forms.Button();
            this.btn_DoublePlusA = new System.Windows.Forms.Button();
            this.btn_AplusDouble = new System.Windows.Forms.Button();
            this.btn_negativeC = new System.Windows.Forms.Button();
            this.btn_C_eqA_eqB = new System.Windows.Forms.Button();
            this.tb_A_Re = new System.Windows.Forms.TextBox();
            this.tb_B_Re = new System.Windows.Forms.TextBox();
            this.tb_C_Re = new System.Windows.Forms.TextBox();
            this.tb_D_Re = new System.Windows.Forms.TextBox();
            this.tb_A_Im = new System.Windows.Forms.TextBox();
            this.tb_B_Im = new System.Windows.Forms.TextBox();
            this.tb_C_Im = new System.Windows.Forms.TextBox();
            this.tb_D_Im = new System.Windows.Forms.TextBox();
            this.label_real = new System.Windows.Forms.Label();
            this.label_imaginary = new System.Windows.Forms.Label();
            this.label_double = new System.Windows.Forms.Label();
            this.tb_double = new System.Windows.Forms.TextBox();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_subtract_sum = new System.Windows.Forms.Button();
            this.btn_add_difference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(53, 51);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(21, 17);
            this.label_A.TabIndex = 0;
            this.label_A.Text = "A:";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(53, 84);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(21, 17);
            this.label_B.TabIndex = 1;
            this.label_B.Text = "B:";
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Location = new System.Drawing.Point(53, 121);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(21, 17);
            this.label_C.TabIndex = 2;
            this.label_C.Text = "C:";
            // 
            // label_D
            // 
            this.label_D.AutoSize = true;
            this.label_D.Location = new System.Drawing.Point(53, 154);
            this.label_D.Name = "label_D";
            this.label_D.Size = new System.Drawing.Size(22, 17);
            this.label_D.TabIndex = 3;
            this.label_D.Text = "D:";
            // 
            // label_alert
            // 
            this.label_alert.AutoSize = true;
            this.label_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_alert.Location = new System.Drawing.Point(358, 118);
            this.label_alert.Name = "label_alert";
            this.label_alert.Size = new System.Drawing.Size(41, 18);
            this.label_alert.TabIndex = 4;
            this.label_alert.Text = "alert";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_result.Location = new System.Drawing.Point(375, 250);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(65, 25);
            this.label_result.TabIndex = 5;
            this.label_result.Text = "result";
            // 
            // btn_AplusBplusCplusD
            // 
            this.btn_AplusBplusCplusD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AplusBplusCplusD.Location = new System.Drawing.Point(200, 237);
            this.btn_AplusBplusCplusD.Name = "btn_AplusBplusCplusD";
            this.btn_AplusBplusCplusD.Size = new System.Drawing.Size(125, 38);
            this.btn_AplusBplusCplusD.TabIndex = 6;
            this.btn_AplusBplusCplusD.Text = "A + B + C + D";
            this.btn_AplusBplusCplusD.UseVisualStyleBackColor = true;
            this.btn_AplusBplusCplusD.Click += new System.EventHandler(this.btn_AplusBplusCplusD_Click);
            // 
            // btn_AplusB
            // 
            this.btn_AplusB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AplusB.Location = new System.Drawing.Point(42, 193);
            this.btn_AplusB.Name = "btn_AplusB";
            this.btn_AplusB.Size = new System.Drawing.Size(125, 38);
            this.btn_AplusB.TabIndex = 7;
            this.btn_AplusB.Text = "A + B";
            this.btn_AplusB.UseVisualStyleBackColor = true;
            this.btn_AplusB.Click += new System.EventHandler(this.btn_AplusB_Click);
            // 
            // btn_DoublePlusA
            // 
            this.btn_DoublePlusA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoublePlusA.Location = new System.Drawing.Point(42, 281);
            this.btn_DoublePlusA.Name = "btn_DoublePlusA";
            this.btn_DoublePlusA.Size = new System.Drawing.Size(125, 38);
            this.btn_DoublePlusA.TabIndex = 8;
            this.btn_DoublePlusA.Text = "double + A";
            this.btn_DoublePlusA.UseVisualStyleBackColor = true;
            this.btn_DoublePlusA.Click += new System.EventHandler(this.btn_DoublePlusA_Click);
            // 
            // btn_AplusDouble
            // 
            this.btn_AplusDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AplusDouble.Location = new System.Drawing.Point(42, 237);
            this.btn_AplusDouble.Name = "btn_AplusDouble";
            this.btn_AplusDouble.Size = new System.Drawing.Size(125, 38);
            this.btn_AplusDouble.TabIndex = 9;
            this.btn_AplusDouble.Text = "A + double";
            this.btn_AplusDouble.UseVisualStyleBackColor = true;
            this.btn_AplusDouble.Click += new System.EventHandler(this.btn_AplusDouble_Click);
            // 
            // btn_negativeC
            // 
            this.btn_negativeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_negativeC.Location = new System.Drawing.Point(200, 193);
            this.btn_negativeC.Name = "btn_negativeC";
            this.btn_negativeC.Size = new System.Drawing.Size(125, 38);
            this.btn_negativeC.TabIndex = 10;
            this.btn_negativeC.Text = "- D";
            this.btn_negativeC.UseVisualStyleBackColor = true;
            this.btn_negativeC.Click += new System.EventHandler(this.btn_negativeC_Click);
            // 
            // btn_C_eqA_eqB
            // 
            this.btn_C_eqA_eqB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C_eqA_eqB.Location = new System.Drawing.Point(200, 281);
            this.btn_C_eqA_eqB.Name = "btn_C_eqA_eqB";
            this.btn_C_eqA_eqB.Size = new System.Drawing.Size(125, 38);
            this.btn_C_eqA_eqB.TabIndex = 11;
            this.btn_C_eqA_eqB.Text = "C = A = B = C";
            this.btn_C_eqA_eqB.UseVisualStyleBackColor = true;
            this.btn_C_eqA_eqB.Click += new System.EventHandler(this.btn_C_eqA_eqB_Click);
            // 
            // tb_A_Re
            // 
            this.tb_A_Re.Location = new System.Drawing.Point(83, 48);
            this.tb_A_Re.Name = "tb_A_Re";
            this.tb_A_Re.Size = new System.Drawing.Size(100, 22);
            this.tb_A_Re.TabIndex = 12;
            this.tb_A_Re.Text = "0";
            // 
            // tb_B_Re
            // 
            this.tb_B_Re.Location = new System.Drawing.Point(83, 84);
            this.tb_B_Re.Name = "tb_B_Re";
            this.tb_B_Re.Size = new System.Drawing.Size(100, 22);
            this.tb_B_Re.TabIndex = 13;
            this.tb_B_Re.Text = "0";
            // 
            // tb_C_Re
            // 
            this.tb_C_Re.Location = new System.Drawing.Point(83, 118);
            this.tb_C_Re.Name = "tb_C_Re";
            this.tb_C_Re.Size = new System.Drawing.Size(100, 22);
            this.tb_C_Re.TabIndex = 14;
            this.tb_C_Re.Text = "0";
            // 
            // tb_D_Re
            // 
            this.tb_D_Re.Location = new System.Drawing.Point(83, 151);
            this.tb_D_Re.Name = "tb_D_Re";
            this.tb_D_Re.Size = new System.Drawing.Size(100, 22);
            this.tb_D_Re.TabIndex = 15;
            this.tb_D_Re.Text = "0";
            // 
            // tb_A_Im
            // 
            this.tb_A_Im.Location = new System.Drawing.Point(200, 48);
            this.tb_A_Im.Name = "tb_A_Im";
            this.tb_A_Im.Size = new System.Drawing.Size(100, 22);
            this.tb_A_Im.TabIndex = 16;
            this.tb_A_Im.Text = "0";
            // 
            // tb_B_Im
            // 
            this.tb_B_Im.Location = new System.Drawing.Point(200, 81);
            this.tb_B_Im.Name = "tb_B_Im";
            this.tb_B_Im.Size = new System.Drawing.Size(100, 22);
            this.tb_B_Im.TabIndex = 17;
            this.tb_B_Im.Text = "0";
            // 
            // tb_C_Im
            // 
            this.tb_C_Im.Location = new System.Drawing.Point(200, 118);
            this.tb_C_Im.Name = "tb_C_Im";
            this.tb_C_Im.Size = new System.Drawing.Size(100, 22);
            this.tb_C_Im.TabIndex = 18;
            this.tb_C_Im.Text = "0";
            // 
            // tb_D_Im
            // 
            this.tb_D_Im.Location = new System.Drawing.Point(200, 151);
            this.tb_D_Im.Name = "tb_D_Im";
            this.tb_D_Im.Size = new System.Drawing.Size(100, 22);
            this.tb_D_Im.TabIndex = 19;
            this.tb_D_Im.Text = "0";
            // 
            // label_real
            // 
            this.label_real.AutoSize = true;
            this.label_real.Location = new System.Drawing.Point(99, 17);
            this.label_real.Name = "label_real";
            this.label_real.Size = new System.Drawing.Size(68, 17);
            this.label_real.TabIndex = 20;
            this.label_real.Text = "Реальна:";
            // 
            // label_imaginary
            // 
            this.label_imaginary.AutoSize = true;
            this.label_imaginary.Location = new System.Drawing.Point(226, 17);
            this.label_imaginary.Name = "label_imaginary";
            this.label_imaginary.Size = new System.Drawing.Size(52, 17);
            this.label_imaginary.TabIndex = 21;
            this.label_imaginary.Text = "Уявна:";
            // 
            // label_double
            // 
            this.label_double.AutoSize = true;
            this.label_double.Location = new System.Drawing.Point(387, 17);
            this.label_double.Name = "label_double";
            this.label_double.Size = new System.Drawing.Size(53, 17);
            this.label_double.TabIndex = 22;
            this.label_double.Text = "Число:";
            // 
            // tb_double
            // 
            this.tb_double.Location = new System.Drawing.Point(361, 48);
            this.tb_double.Name = "tb_double";
            this.tb_double.Size = new System.Drawing.Size(100, 22);
            this.tb_double.TabIndex = 23;
            this.tb_double.Text = "0";
            // 
            // btn_restart
            // 
            this.btn_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.Location = new System.Drawing.Point(122, 369);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(125, 38);
            this.btn_restart.TabIndex = 24;
            this.btn_restart.Text = "Очистити";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_subtract_sum
            // 
            this.btn_subtract_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtract_sum.Location = new System.Drawing.Point(33, 325);
            this.btn_subtract_sum.Name = "btn_subtract_sum";
            this.btn_subtract_sum.Size = new System.Drawing.Size(150, 38);
            this.btn_subtract_sum.TabIndex = 25;
            this.btn_subtract_sum.Text = "(A + Bi) - (C + Di)";
            this.btn_subtract_sum.UseVisualStyleBackColor = true;
            this.btn_subtract_sum.Click += new System.EventHandler(this.btn_subtract_sum_Click);
            // 
            // btn_add_difference
            // 
            this.btn_add_difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_difference.Location = new System.Drawing.Point(189, 325);
            this.btn_add_difference.Name = "btn_add_difference";
            this.btn_add_difference.Size = new System.Drawing.Size(145, 38);
            this.btn_add_difference.TabIndex = 26;
            this.btn_add_difference.Text = "(A - C) + (B - D)i";
            this.btn_add_difference.UseVisualStyleBackColor = true;
            this.btn_add_difference.Click += new System.EventHandler(this.btn_add_difference_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 442);
            this.Controls.Add(this.btn_add_difference);
            this.Controls.Add(this.btn_subtract_sum);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.tb_double);
            this.Controls.Add(this.label_double);
            this.Controls.Add(this.label_imaginary);
            this.Controls.Add(this.label_real);
            this.Controls.Add(this.tb_D_Im);
            this.Controls.Add(this.tb_C_Im);
            this.Controls.Add(this.tb_B_Im);
            this.Controls.Add(this.tb_A_Im);
            this.Controls.Add(this.tb_D_Re);
            this.Controls.Add(this.tb_C_Re);
            this.Controls.Add(this.tb_B_Re);
            this.Controls.Add(this.tb_A_Re);
            this.Controls.Add(this.btn_C_eqA_eqB);
            this.Controls.Add(this.btn_negativeC);
            this.Controls.Add(this.btn_AplusDouble);
            this.Controls.Add(this.btn_DoublePlusA);
            this.Controls.Add(this.btn_AplusB);
            this.Controls.Add(this.btn_AplusBplusCplusD);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_alert);
            this.Controls.Add(this.label_D);
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Label label_D;
        private System.Windows.Forms.Label label_alert;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button btn_AplusBplusCplusD;
        private System.Windows.Forms.Button btn_AplusB;
        private System.Windows.Forms.Button btn_DoublePlusA;
        private System.Windows.Forms.Button btn_AplusDouble;
        private System.Windows.Forms.Button btn_negativeC;
        private System.Windows.Forms.Button btn_C_eqA_eqB;
        private System.Windows.Forms.TextBox tb_A_Re;
        private System.Windows.Forms.TextBox tb_B_Re;
        private System.Windows.Forms.TextBox tb_C_Re;
        private System.Windows.Forms.TextBox tb_D_Re;
        private System.Windows.Forms.TextBox tb_A_Im;
        private System.Windows.Forms.TextBox tb_B_Im;
        private System.Windows.Forms.TextBox tb_C_Im;
        private System.Windows.Forms.TextBox tb_D_Im;
        private System.Windows.Forms.Label label_real;
        private System.Windows.Forms.Label label_imaginary;
        private System.Windows.Forms.Label label_double;
        private System.Windows.Forms.TextBox tb_double;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_subtract_sum;
        private System.Windows.Forms.Button btn_add_difference;
    }
}

