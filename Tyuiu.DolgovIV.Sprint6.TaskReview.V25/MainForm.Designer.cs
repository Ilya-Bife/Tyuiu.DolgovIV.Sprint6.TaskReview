namespace Tyuiu.DolgovIV.Sprint6.TaskReview.V25
{
    partial class FormMain
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
            textBoxRowsNTip = new TextBox();
            groupBoxInput = new GroupBox();
            buttonDone = new Button();
            groupBoxFind = new GroupBox();
            textBoxRowRInput = new TextBox();
            textBoxRowRTip = new TextBox();
            textBoxEndPosLInput = new TextBox();
            textBoxStartPosKInput = new TextBox();
            textBoxEndPosLTip = new TextBox();
            textBoxStartPosKTip = new TextBox();
            textBoxBetweenNumXInput = new TextBox();
            textBoxBetweenNumXTip = new TextBox();
            textBoxRandNum_n2_Input = new TextBox();
            textBoxRandNum_n1_Input = new TextBox();
            textBoxRandNum_n2_Tip = new TextBox();
            textBoxRandNum_n1_Tip = new TextBox();
            textBoxRandNumsTip = new TextBox();
            textBoxColumnsMInput = new TextBox();
            textBoxRowsNInput = new TextBox();
            textBoxColumnsMTip = new TextBox();
            dataGridViewOutPut = new DataGridView();
            textBoxAnswTip = new TextBox();
            textBoxAnswOutPut = new TextBox();
            groupBoxOutPut = new GroupBox();
            groupBoxInput.SuspendLayout();
            groupBoxFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).BeginInit();
            groupBoxOutPut.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxRowsNTip
            // 
            textBoxRowsNTip.BorderStyle = BorderStyle.None;
            textBoxRowsNTip.Location = new Point(26, 45);
            textBoxRowsNTip.Name = "textBoxRowsNTip";
            textBoxRowsNTip.ReadOnly = true;
            textBoxRowsNTip.Size = new Size(125, 16);
            textBoxRowsNTip.TabIndex = 0;
            textBoxRowsNTip.Text = "Количество строк N:";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(buttonDone);
            groupBoxInput.Controls.Add(groupBoxFind);
            groupBoxInput.Controls.Add(textBoxBetweenNumXInput);
            groupBoxInput.Controls.Add(textBoxBetweenNumXTip);
            groupBoxInput.Controls.Add(textBoxRandNum_n2_Input);
            groupBoxInput.Controls.Add(textBoxRandNum_n1_Input);
            groupBoxInput.Controls.Add(textBoxRandNum_n2_Tip);
            groupBoxInput.Controls.Add(textBoxRandNum_n1_Tip);
            groupBoxInput.Controls.Add(textBoxRandNumsTip);
            groupBoxInput.Controls.Add(textBoxColumnsMInput);
            groupBoxInput.Controls.Add(textBoxRowsNInput);
            groupBoxInput.Controls.Add(textBoxColumnsMTip);
            groupBoxInput.Controls.Add(textBoxRowsNTip);
            groupBoxInput.Location = new Point(37, 37);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(402, 612);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Условие";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(26, 553);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(356, 52);
            buttonDone.TabIndex = 12;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxFind
            // 
            groupBoxFind.Controls.Add(textBoxRowRInput);
            groupBoxFind.Controls.Add(textBoxRowRTip);
            groupBoxFind.Controls.Add(textBoxEndPosLInput);
            groupBoxFind.Controls.Add(textBoxStartPosKInput);
            groupBoxFind.Controls.Add(textBoxEndPosLTip);
            groupBoxFind.Controls.Add(textBoxStartPosKTip);
            groupBoxFind.Location = new Point(6, 371);
            groupBoxFind.Name = "groupBoxFind";
            groupBoxFind.Size = new Size(390, 176);
            groupBoxFind.TabIndex = 11;
            groupBoxFind.TabStop = false;
            groupBoxFind.Text = "Найти";
            // 
            // textBoxRowRInput
            // 
            textBoxRowRInput.Location = new Point(159, 42);
            textBoxRowRInput.Name = "textBoxRowRInput";
            textBoxRowRInput.Size = new Size(125, 23);
            textBoxRowRInput.TabIndex = 5;
            // 
            // textBoxRowRTip
            // 
            textBoxRowRTip.BorderStyle = BorderStyle.None;
            textBoxRowRTip.Location = new Point(88, 45);
            textBoxRowRTip.Name = "textBoxRowRTip";
            textBoxRowRTip.ReadOnly = true;
            textBoxRowRTip.Size = new Size(65, 16);
            textBoxRowRTip.TabIndex = 4;
            textBoxRowRTip.Text = "Строка R:";
            // 
            // textBoxEndPosLInput
            // 
            textBoxEndPosLInput.Location = new Point(227, 121);
            textBoxEndPosLInput.Name = "textBoxEndPosLInput";
            textBoxEndPosLInput.Size = new Size(143, 23);
            textBoxEndPosLInput.TabIndex = 3;
            // 
            // textBoxStartPosKInput
            // 
            textBoxStartPosKInput.Location = new Point(26, 121);
            textBoxStartPosKInput.Name = "textBoxStartPosKInput";
            textBoxStartPosKInput.Size = new Size(125, 23);
            textBoxStartPosKInput.TabIndex = 2;
            // 
            // textBoxEndPosLTip
            // 
            textBoxEndPosLTip.BorderStyle = BorderStyle.None;
            textBoxEndPosLTip.Location = new Point(227, 99);
            textBoxEndPosLTip.Name = "textBoxEndPosLTip";
            textBoxEndPosLTip.ReadOnly = true;
            textBoxEndPosLTip.Size = new Size(143, 16);
            textBoxEndPosLTip.TabIndex = 1;
            textBoxEndPosLTip.Text = "До элемента L:";
            // 
            // textBoxStartPosKTip
            // 
            textBoxStartPosKTip.BorderStyle = BorderStyle.None;
            textBoxStartPosKTip.Location = new Point(26, 99);
            textBoxStartPosKTip.Name = "textBoxStartPosKTip";
            textBoxStartPosKTip.ReadOnly = true;
            textBoxStartPosKTip.Size = new Size(125, 16);
            textBoxStartPosKTip.TabIndex = 0;
            textBoxStartPosKTip.Text = "От элемента K:";
            // 
            // textBoxBetweenNumXInput
            // 
            textBoxBetweenNumXInput.Location = new Point(175, 259);
            textBoxBetweenNumXInput.Name = "textBoxBetweenNumXInput";
            textBoxBetweenNumXInput.Size = new Size(129, 23);
            textBoxBetweenNumXInput.TabIndex = 10;
            // 
            // textBoxBetweenNumXTip
            // 
            textBoxBetweenNumXTip.BorderStyle = BorderStyle.None;
            textBoxBetweenNumXTip.Location = new Point(26, 262);
            textBoxBetweenNumXTip.Name = "textBoxBetweenNumXTip";
            textBoxBetweenNumXTip.ReadOnly = true;
            textBoxBetweenNumXTip.Size = new Size(143, 16);
            textBoxBetweenNumXTip.TabIndex = 9;
            textBoxBetweenNumXTip.Text = "Чередующееся число X:";
            // 
            // textBoxRandNum_n2_Input
            // 
            textBoxRandNum_n2_Input.Location = new Point(227, 185);
            textBoxRandNum_n2_Input.Name = "textBoxRandNum_n2_Input";
            textBoxRandNum_n2_Input.Size = new Size(105, 23);
            textBoxRandNum_n2_Input.TabIndex = 8;
            // 
            // textBoxRandNum_n1_Input
            // 
            textBoxRandNum_n1_Input.Location = new Point(26, 185);
            textBoxRandNum_n1_Input.Name = "textBoxRandNum_n1_Input";
            textBoxRandNum_n1_Input.Size = new Size(105, 23);
            textBoxRandNum_n1_Input.TabIndex = 7;
            // 
            // textBoxRandNum_n2_Tip
            // 
            textBoxRandNum_n2_Tip.BorderStyle = BorderStyle.None;
            textBoxRandNum_n2_Tip.Location = new Point(227, 163);
            textBoxRandNum_n2_Tip.Name = "textBoxRandNum_n2_Tip";
            textBoxRandNum_n2_Tip.ReadOnly = true;
            textBoxRandNum_n2_Tip.Size = new Size(77, 16);
            textBoxRandNum_n2_Tip.TabIndex = 6;
            textBoxRandNum_n2_Tip.Text = "До n2:";
            // 
            // textBoxRandNum_n1_Tip
            // 
            textBoxRandNum_n1_Tip.BorderStyle = BorderStyle.None;
            textBoxRandNum_n1_Tip.Location = new Point(26, 163);
            textBoxRandNum_n1_Tip.Name = "textBoxRandNum_n1_Tip";
            textBoxRandNum_n1_Tip.ReadOnly = true;
            textBoxRandNum_n1_Tip.Size = new Size(77, 16);
            textBoxRandNum_n1_Tip.TabIndex = 5;
            textBoxRandNum_n1_Tip.Text = "От n1:";
            // 
            // textBoxRandNumsTip
            // 
            textBoxRandNumsTip.BorderStyle = BorderStyle.None;
            textBoxRandNumsTip.Location = new Point(118, 124);
            textBoxRandNumsTip.Name = "textBoxRandNumsTip";
            textBoxRandNumsTip.ReadOnly = true;
            textBoxRandNumsTip.Size = new Size(125, 16);
            textBoxRandNumsTip.TabIndex = 4;
            textBoxRandNumsTip.Text = "Случайные числа:";
            // 
            // textBoxColumnsMInput
            // 
            textBoxColumnsMInput.Location = new Point(227, 67);
            textBoxColumnsMInput.Name = "textBoxColumnsMInput";
            textBoxColumnsMInput.Size = new Size(143, 23);
            textBoxColumnsMInput.TabIndex = 3;
            // 
            // textBoxRowsNInput
            // 
            textBoxRowsNInput.Location = new Point(26, 67);
            textBoxRowsNInput.Name = "textBoxRowsNInput";
            textBoxRowsNInput.Size = new Size(125, 23);
            textBoxRowsNInput.TabIndex = 2;
            // 
            // textBoxColumnsMTip
            // 
            textBoxColumnsMTip.BorderStyle = BorderStyle.None;
            textBoxColumnsMTip.Location = new Point(227, 45);
            textBoxColumnsMTip.Name = "textBoxColumnsMTip";
            textBoxColumnsMTip.ReadOnly = true;
            textBoxColumnsMTip.Size = new Size(143, 16);
            textBoxColumnsMTip.TabIndex = 1;
            textBoxColumnsMTip.Text = "Количество столбцов M:";
            textBoxColumnsMTip.TextChanged += textBox2_TextChanged;
            // 
            // dataGridViewOutPut
            // 
            dataGridViewOutPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut.Location = new Point(531, 37);
            dataGridViewOutPut.Name = "dataGridViewOutPut";
            dataGridViewOutPut.Size = new Size(554, 436);
            dataGridViewOutPut.TabIndex = 2;
            // 
            // textBoxAnswTip
            // 
            textBoxAnswTip.BorderStyle = BorderStyle.None;
            textBoxAnswTip.Location = new Point(20, 36);
            textBoxAnswTip.Name = "textBoxAnswTip";
            textBoxAnswTip.ReadOnly = true;
            textBoxAnswTip.Size = new Size(175, 16);
            textBoxAnswTip.TabIndex = 13;
            textBoxAnswTip.Text = "Сумма нечетных элементов:";
            // 
            // textBoxAnswOutPut
            // 
            textBoxAnswOutPut.Location = new Point(201, 33);
            textBoxAnswOutPut.Name = "textBoxAnswOutPut";
            textBoxAnswOutPut.ReadOnly = true;
            textBoxAnswOutPut.Size = new Size(143, 23);
            textBoxAnswOutPut.TabIndex = 6;
            // 
            // groupBoxOutPut
            // 
            groupBoxOutPut.Controls.Add(textBoxAnswTip);
            groupBoxOutPut.Controls.Add(textBoxAnswOutPut);
            groupBoxOutPut.Location = new Point(594, 507);
            groupBoxOutPut.Name = "groupBoxOutPut";
            groupBoxOutPut.Size = new Size(390, 90);
            groupBoxOutPut.TabIndex = 12;
            groupBoxOutPut.TabStop = false;
            groupBoxOutPut.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(groupBoxOutPut);
            Controls.Add(dataGridViewOutPut);
            Controls.Add(groupBoxInput);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск Review | Вариант 25 | Долгов И.В.";
            Load += Form1_Load;
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxFind.ResumeLayout(false);
            groupBoxFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).EndInit();
            groupBoxOutPut.ResumeLayout(false);
            groupBoxOutPut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxRowsNTip;
        private GroupBox groupBoxInput;
        private TextBox textBoxRowsNInput;
        private TextBox textBoxColumnsMTip;
        private TextBox textBoxColumnsMInput;
        private TextBox textBoxBetweenNumXInput;
        private TextBox textBoxBetweenNumXTip;
        private TextBox textBoxRandNum_n2_Input;
        private TextBox textBoxRandNum_n1_Input;
        private TextBox textBoxRandNum_n2_Tip;
        private TextBox textBoxRandNum_n1_Tip;
        private TextBox textBoxRandNumsTip;
        private GroupBox groupBoxFind;
        private TextBox textBoxEndPosLInput;
        private TextBox textBoxStartPosKInput;
        private TextBox textBoxEndPosLTip;
        private TextBox textBoxStartPosKTip;
        private TextBox textBoxRowRInput;
        private TextBox textBoxRowRTip;
        private DataGridView dataGridViewOutPut;
        private Button buttonDone;
        private TextBox textBoxAnswTip;
        private TextBox textBoxAnswOutPut;
        private GroupBox groupBoxOutPut;
    }
}
