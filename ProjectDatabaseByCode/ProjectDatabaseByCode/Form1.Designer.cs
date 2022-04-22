namespace ProjectDatabaseByCode
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadGroups = new System.Windows.Forms.Button();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditGroups = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnLoadGroups
            // 
            this.btnLoadGroups.Location = new System.Drawing.Point(12, 271);
            this.btnLoadGroups.Name = "btnLoadGroups";
            this.btnLoadGroups.Size = new System.Drawing.Size(306, 40);
            this.btnLoadGroups.TabIndex = 1;
            this.btnLoadGroups.Text = "Загрузить группы";
            this.btnLoadGroups.UseVisualStyleBackColor = true;
            this.btnLoadGroups.Click += new System.EventHandler(this.btnLoadGroups_Click);
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.Location = new System.Drawing.Point(335, 271);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(306, 40);
            this.btnLoadStudents.TabIndex = 3;
            this.btnLoadStudents.Text = "Загрузить студентов";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(335, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(284, 184);
            this.dataGridView2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фильтр ФИО";
            // 
            // btnEditGroups
            // 
            this.btnEditGroups.Location = new System.Drawing.Point(12, 326);
            this.btnEditGroups.Name = "btnEditGroups";
            this.btnEditGroups.Size = new System.Drawing.Size(306, 40);
            this.btnEditGroups.TabIndex = 6;
            this.btnEditGroups.Text = "Редактировать группы";
            this.btnEditGroups.UseVisualStyleBackColor = true;
            this.btnEditGroups.Click += new System.EventHandler(this.btnEditGroups_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 408);
            this.Controls.Add(this.btnEditGroups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadStudents);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnLoadGroups);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadGroups;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditGroups;
    }
}

