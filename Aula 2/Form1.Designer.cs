namespace Aula_2
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
            txt_valorA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_valorB = new TextBox();
            label3 = new Label();
            txt_result = new TextBox();
            bt_somar = new Button();
            lbl_sinal = new Label();
            label5 = new Label();
            bt_sub = new Button();
            bt_div = new Button();
            bt_mult = new Button();
            SuspendLayout();
            // 
            // txt_valorA
            // 
            txt_valorA.Location = new Point(108, 59);
            txt_valorA.Name = "txt_valorA";
            txt_valorA.Size = new Size(100, 23);
            txt_valorA.TabIndex = 0;
            txt_valorA.TextChanged += txt_valorA_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 62);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Valor A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 116);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Valor B";
            // 
            // txt_valorB
            // 
            txt_valorB.Location = new Point(108, 113);
            txt_valorB.Name = "txt_valorB";
            txt_valorB.Size = new Size(100, 23);
            txt_valorB.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 200);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Resultado";
            // 
            // txt_result
            // 
            txt_result.Location = new Point(108, 197);
            txt_result.Name = "txt_result";
            txt_result.ReadOnly = true;
            txt_result.Size = new Size(100, 23);
            txt_result.TabIndex = 5;
            txt_result.TextChanged += txt_result_TextChanged;
            // 
            // bt_somar
            // 
            bt_somar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            bt_somar.Location = new Point(293, 50);
            bt_somar.Name = "bt_somar";
            bt_somar.Size = new Size(38, 41);
            bt_somar.TabIndex = 6;
            bt_somar.Text = "+";
            bt_somar.UseVisualStyleBackColor = true;
            bt_somar.Click += bt_calcular_Click;
            // 
            // lbl_sinal
            // 
            lbl_sinal.AutoSize = true;
            lbl_sinal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sinal.Location = new Point(144, 85);
            lbl_sinal.Name = "lbl_sinal";
            lbl_sinal.RightToLeft = RightToLeft.No;
            lbl_sinal.Size = new Size(25, 25);
            lbl_sinal.TabIndex = 7;
            lbl_sinal.Text = "+";
            lbl_sinal.Click += lbl_sinal_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(144, 158);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(25, 25);
            label5.TabIndex = 8;
            label5.Text = "=";
            // 
            // bt_sub
            // 
            bt_sub.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            bt_sub.Location = new Point(293, 99);
            bt_sub.Name = "bt_sub";
            bt_sub.Size = new Size(38, 41);
            bt_sub.TabIndex = 9;
            bt_sub.Text = "-";
            bt_sub.UseVisualStyleBackColor = true;
            bt_sub.Click += bt_sub_Click;
            // 
            // bt_div
            // 
            bt_div.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            bt_div.Location = new Point(293, 200);
            bt_div.Name = "bt_div";
            bt_div.Size = new Size(38, 41);
            bt_div.TabIndex = 10;
            bt_div.Text = "/";
            bt_div.UseVisualStyleBackColor = true;
            bt_div.Click += bt_div_Click;
            // 
            // bt_mult
            // 
            bt_mult.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            bt_mult.Location = new Point(293, 149);
            bt_mult.Name = "bt_mult";
            bt_mult.Size = new Size(38, 41);
            bt_mult.TabIndex = 11;
            bt_mult.Text = "X";
            bt_mult.UseVisualStyleBackColor = true;
            bt_mult.Click += bt_mult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 272);
            Controls.Add(bt_mult);
            Controls.Add(bt_div);
            Controls.Add(bt_sub);
            Controls.Add(label5);
            Controls.Add(lbl_sinal);
            Controls.Add(bt_somar);
            Controls.Add(txt_result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_valorB);
            Controls.Add(label1);
            Controls.Add(txt_valorA);
            Name = "Form1";
            Text = "Calculadora Simples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_valorA;
        private Label label1;
        private Label label2;
        private TextBox txt_valorB;
        private Label label3;
        private TextBox txt_result;
        private Button bt_somar;
        private Label lbl_sinal;
        private Label label5;
        private Button bt_sub;
        private Button bt_div;
        private Button bt_mult;
    }
}