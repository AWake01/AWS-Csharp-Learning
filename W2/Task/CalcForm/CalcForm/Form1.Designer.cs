
namespace CalcForm
{
    partial class Shape_Calculator_Form
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
            this.CalcArea_Btn = new System.Windows.Forms.Button();
            this.d1_Tb = new System.Windows.Forms.TextBox();
            this.d2_Tb = new System.Windows.Forms.TextBox();
            this.rectangle_Rb = new System.Windows.Forms.RadioButton();
            this.d1_Lb = new System.Windows.Forms.Label();
            this.circle_Rb = new System.Windows.Forms.RadioButton();
            this.triangle_Rb = new System.Windows.Forms.RadioButton();
            this.d2_Lb = new System.Windows.Forms.Label();
            this.d3_Lb = new System.Windows.Forms.Label();
            this.d3_Tb = new System.Windows.Forms.TextBox();
            this.perimeter_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalcArea_Btn
            // 
            this.CalcArea_Btn.Location = new System.Drawing.Point(71, 155);
            this.CalcArea_Btn.Name = "CalcArea_Btn";
            this.CalcArea_Btn.Size = new System.Drawing.Size(68, 23);
            this.CalcArea_Btn.TabIndex = 0;
            this.CalcArea_Btn.Text = "Area";
            this.CalcArea_Btn.UseVisualStyleBackColor = true;
            this.CalcArea_Btn.Click += new System.EventHandler(this.CalcArea_Btn_Click);
            // 
            // d1_Tb
            // 
            this.d1_Tb.Location = new System.Drawing.Point(188, 57);
            this.d1_Tb.Name = "d1_Tb";
            this.d1_Tb.Size = new System.Drawing.Size(30, 20);
            this.d1_Tb.TabIndex = 1;
            this.d1_Tb.Text = "0";
            this.d1_Tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // d2_Tb
            // 
            this.d2_Tb.Location = new System.Drawing.Point(188, 87);
            this.d2_Tb.Name = "d2_Tb";
            this.d2_Tb.Size = new System.Drawing.Size(30, 20);
            this.d2_Tb.TabIndex = 2;
            this.d2_Tb.Text = "0";
            // 
            // rectangle_Rb
            // 
            this.rectangle_Rb.AutoSize = true;
            this.rectangle_Rb.Location = new System.Drawing.Point(155, 155);
            this.rectangle_Rb.Name = "rectangle_Rb";
            this.rectangle_Rb.Size = new System.Drawing.Size(74, 17);
            this.rectangle_Rb.TabIndex = 3;
            this.rectangle_Rb.TabStop = true;
            this.rectangle_Rb.Text = "Rectangle";
            this.rectangle_Rb.UseVisualStyleBackColor = true;
            this.rectangle_Rb.CheckedChanged += new System.EventHandler(this.rectangle_Rb_CheckedChanged_1);
            // 
            // d1_Lb
            // 
            this.d1_Lb.AutoSize = true;
            this.d1_Lb.Location = new System.Drawing.Point(71, 64);
            this.d1_Lb.Name = "d1_Lb";
            this.d1_Lb.Size = new System.Drawing.Size(21, 13);
            this.d1_Lb.TabIndex = 4;
            this.d1_Lb.Text = "D1";
            this.d1_Lb.Click += new System.EventHandler(this.label1_Click);
            // 
            // circle_Rb
            // 
            this.circle_Rb.AutoSize = true;
            this.circle_Rb.Location = new System.Drawing.Point(155, 178);
            this.circle_Rb.Name = "circle_Rb";
            this.circle_Rb.Size = new System.Drawing.Size(51, 17);
            this.circle_Rb.TabIndex = 5;
            this.circle_Rb.TabStop = true;
            this.circle_Rb.Text = "Circle";
            this.circle_Rb.UseVisualStyleBackColor = true;
            this.circle_Rb.CheckedChanged += new System.EventHandler(this.circle_RB_CheckedChanged);
            // 
            // triangle_Rb
            // 
            this.triangle_Rb.AutoSize = true;
            this.triangle_Rb.Location = new System.Drawing.Point(155, 201);
            this.triangle_Rb.Name = "triangle_Rb";
            this.triangle_Rb.Size = new System.Drawing.Size(63, 17);
            this.triangle_Rb.TabIndex = 6;
            this.triangle_Rb.TabStop = true;
            this.triangle_Rb.Text = "Triangle";
            this.triangle_Rb.UseVisualStyleBackColor = true;
            this.triangle_Rb.CheckedChanged += new System.EventHandler(this.triangle_RB_CheckedChanged);
            // 
            // d2_Lb
            // 
            this.d2_Lb.AutoSize = true;
            this.d2_Lb.Location = new System.Drawing.Point(71, 94);
            this.d2_Lb.Name = "d2_Lb";
            this.d2_Lb.Size = new System.Drawing.Size(21, 13);
            this.d2_Lb.TabIndex = 7;
            this.d2_Lb.Text = "D2";
            this.d2_Lb.Click += new System.EventHandler(this.label2_Click);
            // 
            // d3_Lb
            // 
            this.d3_Lb.AutoSize = true;
            this.d3_Lb.Location = new System.Drawing.Point(71, 121);
            this.d3_Lb.Name = "d3_Lb";
            this.d3_Lb.Size = new System.Drawing.Size(21, 13);
            this.d3_Lb.TabIndex = 8;
            this.d3_Lb.Text = "D3";
            // 
            // d3_Tb
            // 
            this.d3_Tb.Location = new System.Drawing.Point(188, 118);
            this.d3_Tb.Name = "d3_Tb";
            this.d3_Tb.Size = new System.Drawing.Size(30, 20);
            this.d3_Tb.TabIndex = 9;
            this.d3_Tb.Text = "0";
            // 
            // perimeter_btn
            // 
            this.perimeter_btn.Location = new System.Drawing.Point(71, 195);
            this.perimeter_btn.Name = "perimeter_btn";
            this.perimeter_btn.Size = new System.Drawing.Size(68, 23);
            this.perimeter_btn.TabIndex = 10;
            this.perimeter_btn.Text = "Perimeter";
            this.perimeter_btn.UseVisualStyleBackColor = true;
            this.perimeter_btn.Click += new System.EventHandler(this.perimeter_btn_Click);
            // 
            // Shape_Calculator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 295);
            this.Controls.Add(this.perimeter_btn);
            this.Controls.Add(this.d3_Tb);
            this.Controls.Add(this.d3_Lb);
            this.Controls.Add(this.d2_Lb);
            this.Controls.Add(this.triangle_Rb);
            this.Controls.Add(this.circle_Rb);
            this.Controls.Add(this.d1_Lb);
            this.Controls.Add(this.rectangle_Rb);
            this.Controls.Add(this.d2_Tb);
            this.Controls.Add(this.d1_Tb);
            this.Controls.Add(this.CalcArea_Btn);
            this.Name = "Shape_Calculator_Form";
            this.Text = "Shape Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcArea_Btn;
        private System.Windows.Forms.TextBox d1_Tb;
        private System.Windows.Forms.TextBox d2_Tb;
        private System.Windows.Forms.RadioButton rectangle_Rb;
        private System.Windows.Forms.Label d1_Lb;
        private System.Windows.Forms.RadioButton circle_Rb;
        private System.Windows.Forms.RadioButton triangle_Rb;
        private System.Windows.Forms.Label d2_Lb;
        private System.Windows.Forms.Label d3_Lb;
        private System.Windows.Forms.TextBox d3_Tb;
        private System.Windows.Forms.Button perimeter_btn;
    }
}

