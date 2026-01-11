using System;
using Tyuiu.DolgovIV.Sprint6.TaskReview.V25.Lib;

namespace Tyuiu.DolgovIV.Sprint6.TaskReview.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matr;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxStartPosKInput.Text) > Convert.ToInt32(textBoxEndPosLInput.Text))
                {
                    MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                matr = new int[Convert.ToInt32(textBoxRowsNInput.Text), Convert.ToInt32(textBoxColumnsMInput.Text)];

                int[,] resmatr = ds.GetMatrix(matr, Convert.ToInt32(textBoxRandNum_n1_Input.Text), Convert.ToInt32(textBoxRandNum_n2_Input.Text), Convert.ToInt32(textBoxBetweenNumXInput.Text));

                int res = ds.result(resmatr, Convert.ToInt32(textBoxRowRInput.Text), Convert.ToInt32(textBoxStartPosKInput.Text), Convert.ToInt32(textBoxEndPosLInput.Text));



                int row = resmatr.GetUpperBound(0) + 1;
                int col = resmatr.Length / row;

                dataGridViewOutPut.RowCount = row;
                dataGridViewOutPut.ColumnCount = col;

                for (int i = 0; i < col; i++)
                {
                    dataGridViewOutPut.Columns[i].Width = 25;
                }

                for (int i = 0; i < row; i++)
                {
                    for (global::System.Int32 j = 0; j < col; j++)
                    {
                        dataGridViewOutPut.Rows[i].Cells[j].Value = Convert.ToString(resmatr[i, j]);
                    }
                }

                textBoxAnswOutPut.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
