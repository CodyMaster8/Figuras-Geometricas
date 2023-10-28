namespace Figuras_Geometricas
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            volumenCirc = new TextBox();
            label4 = new Label();
            areaCirc = new TextBox();
            radioCirc = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            areaTri = new TextBox();
            label8 = new Label();
            button2 = new Button();
            alturaTri = new TextBox();
            label7 = new Label();
            baseTri = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tabPage3 = new TabPage();
            button3 = new Button();
            volumenCubo = new TextBox();
            label12 = new Label();
            areaCubo = new TextBox();
            ladoCubo = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tabPage4 = new TabPage();
            volumenCilindro = new TextBox();
            areaCilindro = new TextBox();
            label17 = new Label();
            label16 = new Label();
            button4 = new Button();
            alturaCilindro = new TextBox();
            label15 = new Label();
            radioCilindro = new TextBox();
            label14 = new Label();
            label13 = new Label();
            tabPage5 = new TabPage();
            button5 = new Button();
            textBox3 = new TextBox();
            label21 = new Label();
            textBox2 = new TextBox();
            label20 = new Label();
            textBox1 = new TextBox();
            label19 = new Label();
            label18 = new Label();
            tabPage6 = new TabPage();
            label22 = new Label();
            label23 = new Label();
            textBox4 = new TextBox();
            label24 = new Label();
            textBox5 = new TextBox();
            label25 = new Label();
            textBox6 = new TextBox();
            button6 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(88, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(613, 308);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Red;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(volumenCirc);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(areaCirc);
            tabPage1.Controls.Add(radioCirc);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(605, 280);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Circunferencia";
            // 
            // button1
            // 
            button1.Location = new Point(300, 222);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // volumenCirc
            // 
            volumenCirc.Location = new Point(434, 169);
            volumenCirc.Name = "volumenCirc";
            volumenCirc.Size = new Size(100, 23);
            volumenCirc.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(349, 167);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 5;
            label4.Text = "Volumen";
            // 
            // areaCirc
            // 
            areaCirc.Location = new Point(201, 165);
            areaCirc.Name = "areaCirc";
            areaCirc.Size = new Size(100, 23);
            areaCirc.TabIndex = 4;
            // 
            // radioCirc
            // 
            radioCirc.Location = new Point(210, 85);
            radioCirc.Name = "radioCirc";
            radioCirc.Size = new Size(100, 23);
            radioCirc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(150, 167);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 2;
            label3.Text = "Area";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(150, 85);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 1;
            label2.Text = "Radio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(219, 31);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 0;
            label1.Text = "Circunferencia";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.OrangeRed;
            tabPage2.Controls.Add(areaTri);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(alturaTri);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(baseTri);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(605, 280);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Triangulo";
            // 
            // areaTri
            // 
            areaTri.Location = new Point(202, 220);
            areaTri.Name = "areaTri";
            areaTri.Size = new Size(100, 23);
            areaTri.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(151, 220);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 6;
            label8.Text = "Area";
            // 
            // button2
            // 
            button2.Location = new Point(289, 155);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // alturaTri
            // 
            alturaTri.Location = new Point(403, 107);
            alturaTri.Name = "alturaTri";
            alturaTri.Size = new Size(100, 23);
            alturaTri.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(340, 105);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 3;
            label7.Text = "Altura";
            // 
            // baseTri
            // 
            baseTri.Location = new Point(202, 103);
            baseTri.Name = "baseTri";
            baseTri.Size = new Size(100, 23);
            baseTri.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(151, 101);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 1;
            label6.Text = "Base";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(289, 31);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 0;
            label5.Text = "Triangulo";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Yellow;
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(volumenCubo);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(areaCubo);
            tabPage3.Controls.Add(ladoCubo);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(605, 280);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cubo";
            // 
            // button3
            // 
            button3.Location = new Point(252, 226);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // volumenCubo
            // 
            volumenCubo.Location = new Point(404, 173);
            volumenCubo.Name = "volumenCubo";
            volumenCubo.Size = new Size(100, 23);
            volumenCubo.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(319, 171);
            label12.Name = "label12";
            label12.Size = new Size(79, 21);
            label12.TabIndex = 5;
            label12.Text = "Volumen";
            // 
            // areaCubo
            // 
            areaCubo.Location = new Point(188, 169);
            areaCubo.Name = "areaCubo";
            areaCubo.Size = new Size(100, 23);
            areaCubo.TabIndex = 4;
            // 
            // ladoCubo
            // 
            ladoCubo.Location = new Point(190, 101);
            ladoCubo.Name = "ladoCubo";
            ladoCubo.Size = new Size(100, 23);
            ladoCubo.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(137, 167);
            label11.Name = "label11";
            label11.Size = new Size(45, 21);
            label11.TabIndex = 2;
            label11.Text = "Area";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(137, 99);
            label10.Name = "label10";
            label10.Size = new Size(47, 21);
            label10.TabIndex = 1;
            label10.Text = "Lado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(252, 41);
            label9.Name = "label9";
            label9.Size = new Size(50, 21);
            label9.TabIndex = 0;
            label9.Text = "Cubo";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Orange;
            tabPage4.Controls.Add(volumenCilindro);
            tabPage4.Controls.Add(areaCilindro);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(alturaCilindro);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(radioCilindro);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label13);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(605, 280);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Cilindro";
            // 
            // volumenCilindro
            // 
            volumenCilindro.Location = new Point(403, 195);
            volumenCilindro.Name = "volumenCilindro";
            volumenCilindro.Size = new Size(100, 23);
            volumenCilindro.TabIndex = 9;
            // 
            // areaCilindro
            // 
            areaCilindro.Location = new Point(166, 195);
            areaCilindro.Name = "areaCilindro";
            areaCilindro.Size = new Size(100, 23);
            areaCilindro.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(318, 193);
            label17.Name = "label17";
            label17.Size = new Size(79, 21);
            label17.TabIndex = 7;
            label17.Text = "Volumen";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(106, 193);
            label16.Name = "label16";
            label16.Size = new Size(45, 21);
            label16.TabIndex = 6;
            label16.Text = "Area";
            // 
            // button4
            // 
            button4.Location = new Point(248, 137);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Calcular";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // alturaCilindro
            // 
            alturaCilindro.Location = new Point(381, 80);
            alturaCilindro.Name = "alturaCilindro";
            alturaCilindro.Size = new Size(100, 23);
            alturaCilindro.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(318, 78);
            label15.Name = "label15";
            label15.Size = new Size(57, 21);
            label15.TabIndex = 3;
            label15.Text = "Altura";
            // 
            // radioCilindro
            // 
            radioCilindro.Location = new Point(166, 76);
            radioCilindro.Name = "radioCilindro";
            radioCilindro.Size = new Size(100, 23);
            radioCilindro.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(106, 78);
            label14.Name = "label14";
            label14.Size = new Size(54, 21);
            label14.TabIndex = 1;
            label14.Text = "Radio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(248, 20);
            label13.Name = "label13";
            label13.Size = new Size(71, 21);
            label13.TabIndex = 0;
            label13.Text = "Cilindro";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Green;
            tabPage5.Controls.Add(button5);
            tabPage5.Controls.Add(textBox3);
            tabPage5.Controls.Add(label21);
            tabPage5.Controls.Add(textBox2);
            tabPage5.Controls.Add(label20);
            tabPage5.Controls.Add(textBox1);
            tabPage5.Controls.Add(label19);
            tabPage5.Controls.Add(label18);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(605, 280);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Rombo";
            // 
            // button5
            // 
            button5.Location = new Point(340, 182);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            button5.Text = "Calcular";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(103, 180);
            label21.Name = "label21";
            label21.Size = new Size(45, 21);
            label21.TabIndex = 5;
            label21.Text = "Area";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(430, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(331, 87);
            label20.Name = "label20";
            label20.Size = new Size(93, 21);
            label20.TabIndex = 3;
            label20.Text = "Diagonal 2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(103, 83);
            label19.Name = "label19";
            label19.Size = new Size(93, 21);
            label19.TabIndex = 1;
            label19.Text = "Diagonal 1";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(255, 36);
            label18.Name = "label18";
            label18.Size = new Size(65, 21);
            label18.TabIndex = 0;
            label18.Text = "Rombo";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.Blue;
            tabPage6.Controls.Add(button6);
            tabPage6.Controls.Add(textBox6);
            tabPage6.Controls.Add(label25);
            tabPage6.Controls.Add(textBox5);
            tabPage6.Controls.Add(label24);
            tabPage6.Controls.Add(textBox4);
            tabPage6.Controls.Add(label23);
            tabPage6.Controls.Add(label22);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(605, 280);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Octaedro";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(244, 42);
            label22.Name = "label22";
            label22.Size = new Size(80, 21);
            label22.TabIndex = 0;
            label22.Text = "Octaedro";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(124, 91);
            label23.Name = "label23";
            label23.Size = new Size(54, 21);
            label23.TabIndex = 1;
            label23.Text = "Arista";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(184, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(98, 23);
            textBox4.TabIndex = 2;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(124, 173);
            label24.Name = "label24";
            label24.Size = new Size(45, 21);
            label24.TabIndex = 3;
            label24.Text = "Area";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(184, 175);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(98, 23);
            textBox5.TabIndex = 4;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(324, 177);
            label25.Name = "label25";
            label25.Size = new Size(79, 21);
            label25.TabIndex = 5;
            label25.Text = "Volumen";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(409, 179);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 6;
            // 
            // button6
            // 
            button6.Location = new Point(375, 91);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 7;
            button6.Text = "Calcular";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Figuras Geometricas";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Button button1;
        private TextBox volumenCirc;
        private Label label4;
        private TextBox areaCirc;
        private TextBox radioCirc;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox areaTri;
        private Label label8;
        private Button button2;
        private TextBox alturaTri;
        private Label label7;
        private TextBox baseTri;
        private Label label9;
        private Button button3;
        private TextBox volumenCubo;
        private Label label12;
        private TextBox areaCubo;
        private TextBox ladoCubo;
        private Label label11;
        private Label label10;
        private Label label13;
        private TextBox alturaCilindro;
        private Label label15;
        private TextBox radioCilindro;
        private Label label14;
        private TextBox volumenCilindro;
        private TextBox areaCilindro;
        private Label label17;
        private Label label16;
        private Button button4;
        private Button button5;
        private TextBox textBox3;
        private Label label21;
        private TextBox textBox2;
        private Label label20;
        private TextBox textBox1;
        private Label label19;
        private Label label18;
        private Label label25;
        private TextBox textBox5;
        private Label label24;
        private TextBox textBox4;
        private Label label23;
        private Label label22;
        private Button button6;
        private TextBox textBox6;
    }
}