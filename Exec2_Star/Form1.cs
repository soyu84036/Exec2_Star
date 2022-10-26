namespace Exec2_Star
{
    public partial class Form1 : Form
    {
        /* 由使用者輸入列數（介於[1, 10]）
         * 呈現靠左，靠右，等腰的星號三角形
         * 三角形呈現在一個TextBox中*/
        public Form1()
        {
            InitializeComponent();
            this.Text = "星號三角形";
            starsTextBox.Text = string.Empty;
        }

        private void leftStarsButton_Click(object sender, EventArgs e)
        {
            // 取得列數
            int rows = 0;
            try
            { 
                rows = GetRows(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // 生成星號三角形
            string stras = leftStars(rows);

            //呈現星號三角形
            starsTextBox.Text = stras;
        }

        private string leftStars(int rows)
        {
            string result = string.Empty;
            for (int i = 1; i <= rows; i++)
            {
                result += new string('*', i) + "\r\n";
            }
            return result;
        }

        private int GetRows()
        {
            string input = rowsTextBox.Text;
            bool isint = int.TryParse(input, out int rows);

            // 輸入的值必須為數字
            if (!isint) 
            {
                throw new Exception("請輸入數字");                
            }
            // 輸入的數必須介於1~10
            if (rows <= 0 || rows > 10)
            {
                throw new Exception("列數必須介於1~10");
            }
            return rows;
        }

        private void rightStarsButton_Click(object sender, EventArgs e)
        {
            // 取得列數
            int rows = 0;
            try
            {
                rows = GetRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // 生成星號三角形
            string stras = rightStars(rows);

            //呈現星號三角形
            starsTextBox.Text = stras;
        }

        private string rightStars(int rows)
        {
            string result = string.Empty;
            for (int i = 1; i <= rows; i++)
            {
                result += new string(' ', rows - i) + new string('*', i) + "\r\n";
            }
            return result;
        }

        private void isoscelesStarsButton_Click(object sender, EventArgs e)
        {
            // 取得列數
            int rows = 0;
            try
            {
                rows = GetRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // 生成星號三角形
            string stras = isoscelesStarsStars(rows);

            //呈現星號三角形
            starsTextBox.Text = stras;
        }

        private string isoscelesStarsStars(int rows)
        {
            string result = string.Empty;
            for (int i = 1; i <= rows; i++)
            {
                result += new string(' ', rows - i) + new string('*', 2 * i - 1) + "\r\n";
                
                // 星號數量
                //result = new string('*', 2 * i - 1).PadLeft(rows + i - 1);
            }
            return result;
        }
    }
}