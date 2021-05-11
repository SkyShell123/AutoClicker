
namespace AutoClicker
{
    partial class Settings
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
            this.Back = new System.Windows.Forms.Button();
            this.PointWindow = new System.Windows.Forms.Label();
            this.RecButt = new System.Windows.Forms.Button();
            this.KeySelectLabel = new System.Windows.Forms.Label();
            this.KeySelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(658, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PointWindow
            // 
            this.PointWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PointWindow.Location = new System.Drawing.Point(207, 22);
            this.PointWindow.Name = "PointWindow";
            this.PointWindow.Size = new System.Drawing.Size(188, 217);
            this.PointWindow.TabIndex = 1;
            // 
            // RecButt
            // 
            this.RecButt.Location = new System.Drawing.Point(249, 254);
            this.RecButt.Name = "RecButt";
            this.RecButt.Size = new System.Drawing.Size(98, 47);
            this.RecButt.TabIndex = 2;
            this.RecButt.Text = "Запись";
            this.RecButt.UseVisualStyleBackColor = true;
            this.RecButt.Click += new System.EventHandler(this.RecButt_Click);
            // 
            // KeySelectLabel
            // 
            this.KeySelectLabel.AutoSize = true;
            this.KeySelectLabel.Location = new System.Drawing.Point(418, 113);
            this.KeySelectLabel.Name = "KeySelectLabel";
            this.KeySelectLabel.Size = new System.Drawing.Size(229, 13);
            this.KeySelectLabel.TabIndex = 3;
            this.KeySelectLabel.Text = "В данный момент используеться клавиша: ";
            // 
            // KeySelect
            // 
            this.KeySelect.Location = new System.Drawing.Point(643, 108);
            this.KeySelect.Name = "KeySelect";
            this.KeySelect.Size = new System.Drawing.Size(75, 23);
            this.KeySelect.TabIndex = 4;
            this.KeySelect.UseVisualStyleBackColor = true;
            this.KeySelect.Click += new System.EventHandler(this.KeySelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Время задержки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "60";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(533, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество циклов";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.KeySelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeySelect);
            this.Controls.Add(this.KeySelectLabel);
            this.Controls.Add(this.RecButt);
            this.Controls.Add(this.PointWindow);
            this.Controls.Add(this.Back);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label PointWindow;
        private System.Windows.Forms.Button RecButt;
        private System.Windows.Forms.Label KeySelectLabel;
        private System.Windows.Forms.Button KeySelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}