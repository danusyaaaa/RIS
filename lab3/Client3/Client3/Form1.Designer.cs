namespace Client3
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
            this.name = new System.Windows.Forms.TextBox();
            this.quant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_view = new System.Windows.Forms.RadioButton();
            this.radio_add = new System.Windows.Forms.RadioButton();
            this.radio_del = new System.Windows.Forms.RadioButton();
            this.radio_edit = new System.Windows.Forms.RadioButton();
            this.radio_find = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(440, 12);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(105, 20);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.Name_OnTextChange);
            // 
            // quant
            // 
            this.quant.Location = new System.Drawing.Point(440, 42);
            this.quant.Margin = new System.Windows.Forms.Padding(2);
            this.quant.Name = "quant";
            this.quant.Size = new System.Drawing.Size(105, 20);
            this.quant.TabIndex = 1;
            this.quant.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фирма компьютера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество компьютеров";
            // 
            // radio_view
            // 
            this.radio_view.AutoSize = true;
            this.radio_view.Location = new System.Drawing.Point(184, 11);
            this.radio_view.Margin = new System.Windows.Forms.Padding(2);
            this.radio_view.Name = "radio_view";
            this.radio_view.Size = new System.Drawing.Size(93, 17);
            this.radio_view.TabIndex = 5;
            this.radio_view.TabStop = true;
            this.radio_view.Text = "Просмотреть";
            this.radio_view.UseVisualStyleBackColor = true;
            // 
            // radio_add
            // 
            this.radio_add.AutoSize = true;
            this.radio_add.Location = new System.Drawing.Point(184, 33);
            this.radio_add.Margin = new System.Windows.Forms.Padding(2);
            this.radio_add.Name = "radio_add";
            this.radio_add.Size = new System.Drawing.Size(75, 17);
            this.radio_add.TabIndex = 6;
            this.radio_add.TabStop = true;
            this.radio_add.Text = "Добавить";
            this.radio_add.UseVisualStyleBackColor = true;
            // 
            // radio_del
            // 
            this.radio_del.AutoSize = true;
            this.radio_del.Location = new System.Drawing.Point(184, 55);
            this.radio_del.Margin = new System.Windows.Forms.Padding(2);
            this.radio_del.Name = "radio_del";
            this.radio_del.Size = new System.Drawing.Size(68, 17);
            this.radio_del.TabIndex = 7;
            this.radio_del.TabStop = true;
            this.radio_del.Text = "Удалить";
            this.radio_del.UseVisualStyleBackColor = true;
            // 
            // radio_edit
            // 
            this.radio_edit.AutoSize = true;
            this.radio_edit.Location = new System.Drawing.Point(184, 78);
            this.radio_edit.Margin = new System.Windows.Forms.Padding(2);
            this.radio_edit.Name = "radio_edit";
            this.radio_edit.Size = new System.Drawing.Size(102, 17);
            this.radio_edit.TabIndex = 8;
            this.radio_edit.TabStop = true;
            this.radio_edit.Text = "Редактировать";
            this.radio_edit.UseVisualStyleBackColor = true;
            // 
            // radio_find
            // 
            this.radio_find.AutoSize = true;
            this.radio_find.Location = new System.Drawing.Point(184, 101);
            this.radio_find.Margin = new System.Windows.Forms.Padding(2);
            this.radio_find.Name = "radio_find";
            this.radio_find.Size = new System.Drawing.Size(56, 17);
            this.radio_find.TabIndex = 9;
            this.radio_find.TabStop = true;
            this.radio_find.Text = "Найти";
            this.radio_find.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(184, 133);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(102, 34);
            this.start.TabIndex = 10;
            this.start.Text = "Выполнить";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(302, 133);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 82);
            this.listBox1.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 10);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(163, 201);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Идентификатор";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(440, 74);
            this.number.Margin = new System.Windows.Forms.Padding(2);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(105, 20);
            this.number.TabIndex = 16;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Послать на сервер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.radio_find);
            this.Controls.Add(this.radio_edit);
            this.Controls.Add(this.radio_del);
            this.Controls.Add(this.radio_add);
            this.Controls.Add(this.radio_view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quant);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Computers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox quant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_view;
        private System.Windows.Forms.RadioButton radio_add;
        private System.Windows.Forms.RadioButton radio_del;
        private System.Windows.Forms.RadioButton radio_edit;
        private System.Windows.Forms.RadioButton radio_find;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button button1;
    }
}

