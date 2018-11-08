namespace Notepad
{
    partial class saveToClose
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
            this.label1 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btDontSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы хотите сохранить текущий файл? (не выбран путь по умолчанию)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btSave
            // 
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btSave.ForeColor = System.Drawing.Color.OrangeRed;
            this.btSave.Location = new System.Drawing.Point(48, 63);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(121, 32);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDontSave
            // 
            this.btDontSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btDontSave.ForeColor = System.Drawing.Color.BlueViolet;
            this.btDontSave.Location = new System.Drawing.Point(211, 63);
            this.btDontSave.Name = "btDontSave";
            this.btDontSave.Size = new System.Drawing.Size(121, 32);
            this.btDontSave.TabIndex = 2;
            this.btDontSave.Text = "Не сохранять";
            this.btDontSave.UseVisualStyleBackColor = true;
            this.btDontSave.Click += new System.EventHandler(this.btDontSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(376, 63);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(121, 32);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 107);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDontSave);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Блокнот";
            this.Load += new System.EventHandler(this.saveToClose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDontSave;
        private System.Windows.Forms.Button btCancel;
    }
}