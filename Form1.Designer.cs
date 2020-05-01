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
            this.picture = new System.Windows.Forms.PictureBox();
            this.Color = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FiguresComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fill = new System.Windows.Forms.CheckBox();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(750, 564);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.Picture_Paint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseUp);
            // 
            // Color
            // 
            this.Color.FormattingEnabled = true;
            this.Color.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Blue",
            "Green",
            "Yellow"});
            this.Color.Location = new System.Drawing.Point(810, 51);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(139, 21);
            this.Color.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Color";
            // 
            // FiguresComboBox
            // 
            this.FiguresComboBox.FormattingEnabled = true;
            this.FiguresComboBox.Location = new System.Drawing.Point(810, 13);
            this.FiguresComboBox.Name = "FiguresComboBox";
            this.FiguresComboBox.Size = new System.Drawing.Size(139, 21);
            this.FiguresComboBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(768, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Figure";
            // 
            // Fill
            // 
            this.Fill.AutoSize = true;
            this.Fill.Location = new System.Drawing.Point(810, 87);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(70, 17);
            this.Fill.TabIndex = 28;
            this.Fill.Text = "Fill Figure";
            this.Fill.UseVisualStyleBackColor = true;
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(771, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 32);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(771, 143);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(178, 32);
            this.btnLoad.TabIndex = 30;
            this.btnLoad.Text = "Open";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.Location = new System.Drawing.Point(771, 252);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(178, 32);
            this.btnLibrary.TabIndex = 31;
            this.btnLibrary.Text = "Load Library";
            this.btnLibrary.UseVisualStyleBackColor = true;
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 593);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiguresComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.picture);
            this.Name = "Canvas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ComboBox Color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiguresComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Fill;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnLibrary;
    }
}

