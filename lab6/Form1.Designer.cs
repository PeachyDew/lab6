﻿namespace lab6
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All elements");
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.lineRadioButton = new System.Windows.Forms.RadioButton();
            this.circleRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.Location = new System.Drawing.Point(52, 56);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(282, 55);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.Delete_Click);
            this.buttonDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(52, 131);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "blue ",
            "green",
            "red",
            "black"});
            this.comboBox1.Location = new System.Drawing.Point(625, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rectangleRadioButton);
            this.groupBox1.Controls.Add(this.lineRadioButton);
            this.groupBox1.Controls.Add(this.circleRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(357, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "objects";
            // 
            // rectangleRadioButton
            // 
            this.rectangleRadioButton.AutoSize = true;
            this.rectangleRadioButton.Location = new System.Drawing.Point(126, 24);
            this.rectangleRadioButton.Name = "rectangleRadioButton";
            this.rectangleRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rectangleRadioButton.Size = new System.Drawing.Size(56, 19);
            this.rectangleRadioButton.TabIndex = 2;
            this.rectangleRadioButton.TabStop = true;
            this.rectangleRadioButton.Text = "sqare";
            this.rectangleRadioButton.UseVisualStyleBackColor = true;
            this.rectangleRadioButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            // 
            // lineRadioButton
            // 
            this.lineRadioButton.Location = new System.Drawing.Point(66, 24);
            this.lineRadioButton.Name = "lineRadioButton";
            this.lineRadioButton.Size = new System.Drawing.Size(54, 19);
            this.lineRadioButton.TabIndex = 1;
            this.lineRadioButton.TabStop = true;
            this.lineRadioButton.Text = "line";
            this.lineRadioButton.UseVisualStyleBackColor = true;
            this.lineRadioButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            // 
            // circleRadioButton
            // 
            this.circleRadioButton.AutoSize = true;
            this.circleRadioButton.Checked = true;
            this.circleRadioButton.Location = new System.Drawing.Point(6, 24);
            this.circleRadioButton.Name = "circleRadioButton";
            this.circleRadioButton.Size = new System.Drawing.Size(54, 19);
            this.circleRadioButton.TabIndex = 0;
            this.circleRadioButton.TabStop = true;
            this.circleRadioButton.Text = "circle";
            this.circleRadioButton.UseVisualStyleBackColor = true;
            this.circleRadioButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Output";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(584, 230);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "All elements";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(194, 401);
            this.treeView1.TabIndex = 8;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 643);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rectangleRadioButton;
        private System.Windows.Forms.RadioButton lineRadioButton;
        private System.Windows.Forms.RadioButton circleRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView treeView1;
    }
}

