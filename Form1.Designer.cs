namespace labFigures
{
    partial class Canvas
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
            this.DrawBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.x1Box = new System.Windows.Forms.TextBox();
            this.y1Box = new System.Windows.Forms.TextBox();
            this.x2Box = new System.Windows.Forms.TextBox();
            this.y2Box = new System.Windows.Forms.TextBox();
            this.radBox = new System.Windows.Forms.TextBox();
            this.lenBox = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelRad = new System.Windows.Forms.Label();
            this.labelLen = new System.Windows.Forms.Label();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.rad2Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawBtn
            // 
            this.DrawBtn.Location = new System.Drawing.Point(12, 12);
            this.DrawBtn.Name = "DrawBtn";
            this.DrawBtn.Size = new System.Drawing.Size(139, 37);
            this.DrawBtn.TabIndex = 0;
            this.DrawBtn.Text = "Рисовать";
            this.DrawBtn.UseVisualStyleBackColor = true;
            this.DrawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(12, 72);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(139, 36);
            this.ResetBtn.TabIndex = 1;
            this.ResetBtn.Text = "Сброс";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 167);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(940, 409);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // x1Box
            // 
            this.x1Box.Location = new System.Drawing.Point(563, 10);
            this.x1Box.Name = "x1Box";
            this.x1Box.Size = new System.Drawing.Size(100, 20);
            this.x1Box.TabIndex = 4;
            // 
            // y1Box
            // 
            this.y1Box.Location = new System.Drawing.Point(563, 36);
            this.y1Box.Name = "y1Box";
            this.y1Box.Size = new System.Drawing.Size(100, 20);
            this.y1Box.TabIndex = 5;
            // 
            // x2Box
            // 
            this.x2Box.Location = new System.Drawing.Point(563, 62);
            this.x2Box.Name = "x2Box";
            this.x2Box.Size = new System.Drawing.Size(100, 20);
            this.x2Box.TabIndex = 6;
            // 
            // y2Box
            // 
            this.y2Box.Location = new System.Drawing.Point(563, 88);
            this.y2Box.Name = "y2Box";
            this.y2Box.Size = new System.Drawing.Size(100, 20);
            this.y2Box.TabIndex = 7;
            // 
            // radBox
            // 
            this.radBox.Location = new System.Drawing.Point(805, 10);
            this.radBox.Name = "radBox";
            this.radBox.Size = new System.Drawing.Size(100, 20);
            this.radBox.TabIndex = 8;
            // 
            // lenBox
            // 
            this.lenBox.Location = new System.Drawing.Point(805, 36);
            this.lenBox.Name = "lenBox";
            this.lenBox.Size = new System.Drawing.Size(100, 20);
            this.lenBox.TabIndex = 9;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(539, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(18, 13);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "x1";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(539, 39);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(18, 13);
            this.labelY1.TabIndex = 11;
            this.labelY1.Text = "y1";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(539, 65);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(18, 13);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "x2";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(539, 91);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(18, 13);
            this.labelY2.TabIndex = 13;
            this.labelY2.Text = "y2";
            // 
            // labelRad
            // 
            this.labelRad.AutoSize = true;
            this.labelRad.Location = new System.Drawing.Point(759, 13);
            this.labelRad.Name = "labelRad";
            this.labelRad.Size = new System.Drawing.Size(43, 13);
            this.labelRad.TabIndex = 14;
            this.labelRad.Text = "Радиус";
            // 
            // labelLen
            // 
            this.labelLen.AutoSize = true;
            this.labelLen.Location = new System.Drawing.Point(764, 39);
            this.labelLen.Name = "labelLen";
            this.labelLen.Size = new System.Drawing.Size(40, 13);
            this.labelLen.TabIndex = 15;
            this.labelLen.Text = "Длина";
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(362, 8);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(139, 28);
            this.btnPoint.TabIndex = 16;
            this.btnPoint.Text = "Точка";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(362, 42);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(139, 28);
            this.btnLine.TabIndex = 17;
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(362, 76);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(139, 28);
            this.btnSquare.TabIndex = 18;
            this.btnSquare.Text = "Квадрат";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(217, 8);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(139, 28);
            this.btnRect.TabIndex = 19;
            this.btnRect.Text = "Прямоугольник";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.BtnRect_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(217, 42);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(139, 28);
            this.btnCircle.TabIndex = 20;
            this.btnCircle.Text = "Круг";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(217, 76);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(139, 28);
            this.btnEllipse.TabIndex = 21;
            this.btnEllipse.Text = "Эллипс";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // rad2Box
            // 
            this.rad2Box.Location = new System.Drawing.Point(805, 88);
            this.rad2Box.Name = "rad2Box";
            this.rad2Box.Size = new System.Drawing.Size(100, 20);
            this.rad2Box.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Радиус 2 (для эллипса)";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Красный",
            "Черный",
            "Синий",
            "Зеленый",
            "Желтый"});
            this.comboBoxColor.Location = new System.Drawing.Point(805, 125);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxColor.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(767, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Цвет";
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rad2Box);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.labelLen);
            this.Controls.Add(this.labelRad);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lenBox);
            this.Controls.Add(this.radBox);
            this.Controls.Add(this.y2Box);
            this.Controls.Add(this.x2Box);
            this.Controls.Add(this.y1Box);
            this.Controls.Add(this.x1Box);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.DrawBtn);
            this.Name = "Canvas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrawBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox x1Box;
        private System.Windows.Forms.TextBox y1Box;
        private System.Windows.Forms.TextBox x2Box;
        private System.Windows.Forms.TextBox y2Box;
        private System.Windows.Forms.TextBox radBox;
        private System.Windows.Forms.TextBox lenBox;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelRad;
        private System.Windows.Forms.Label labelLen;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.TextBox rad2Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label2;
    }
}

