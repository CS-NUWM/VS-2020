namespace WindowsFormsGit
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
            this.button1 = new System.Windows.Forms.Button();
            this.kunderenko_KN31_5 = new System.Windows.Forms.Button();
            this.KN_11INT_3 = new System.Windows.Forms.Button();
            this.Khmelnychyi_KN_31 = new System.Windows.Forms.Button();
            this.karpov_kn_31 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kunderenko_KN31_5
            // 
            this.kunderenko_KN31_5.Location = new System.Drawing.Point(331, 94);
            this.kunderenko_KN31_5.Margin = new System.Windows.Forms.Padding(2);
            this.kunderenko_KN31_5.Name = "kunderenko_KN31_5";
            this.kunderenko_KN31_5.Size = new System.Drawing.Size(159, 51);
            this.kunderenko_KN31_5.TabIndex = 1;
            this.kunderenko_KN31_5.Text = "Кундеренко";
            this.kunderenko_KN31_5.UseVisualStyleBackColor = true;
            this.kunderenko_KN31_5.Click += new System.EventHandler(this.kunderenko_KN31_5_Click);
            // 
            // KN_11INT_3
            // 
            this.KN_11INT_3.Location = new System.Drawing.Point(331, 167);
            this.KN_11INT_3.Margin = new System.Windows.Forms.Padding(2);
            this.KN_11INT_3.Name = "KN_11INT_3";
            this.KN_11INT_3.Size = new System.Drawing.Size(159, 51);
            this.KN_11INT_3.TabIndex = 2;
            this.KN_11INT_3.Text = "Нечипорук";
            this.KN_11INT_3.UseVisualStyleBackColor = true;
            this.KN_11INT_3.Click += new System.EventHandler(this.KN_11INT_3_Click);
            // 
            // Khmelnychyi_KN_31
            // 
            this.Khmelnychyi_KN_31.Location = new System.Drawing.Point(331, 241);
            this.Khmelnychyi_KN_31.Name = "Khmelnychyi_KN_31";
            this.Khmelnychyi_KN_31.Size = new System.Drawing.Size(159, 51);
            this.Khmelnychyi_KN_31.TabIndex = 3;
            this.Khmelnychyi_KN_31.Text = "Хмельничий";
            this.Khmelnychyi_KN_31.UseVisualStyleBackColor = true;
            this.Khmelnychyi_KN_31.Click += new System.EventHandler(this.Khmelnychyi_KN_31_Click);
            // 
            // karpov_kn_31
            // 
            this.karpov_kn_31.Location = new System.Drawing.Point(331, 307);
            this.karpov_kn_31.Name = "karpov_kn_31";
            this.karpov_kn_31.Size = new System.Drawing.Size(159, 51);
            this.karpov_kn_31.TabIndex = 4;
            this.karpov_kn_31.Text = "Карпов";
            this.karpov_kn_31.UseVisualStyleBackColor = true;
            this.karpov_kn_31.Click += new System.EventHandler(this.karpov_kn_31_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.karpov_kn_31);
            this.Controls.Add(this.Khmelnychyi_KN_31);
            this.Controls.Add(this.KN_11INT_3);
            this.Controls.Add(this.kunderenko_KN31_5);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kunderenko_KN31_5;
        private System.Windows.Forms.Button KN_11INT_3;
        private System.Windows.Forms.Button Khmelnychyi_KN_31;
        private System.Windows.Forms.Button karpov_kn_31;
    }
}

