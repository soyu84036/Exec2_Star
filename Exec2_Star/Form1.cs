namespace Exec2_Star
{
    public partial class Form1 : Form
    {
        /* �ѨϥΪ̿�J�C�ơ]����[1, 10]�^
         * �e�{�a���A�a�k�A���y���P���T����
         * �T���Χe�{�b�@��TextBox��*/
        public Form1()
        {
            InitializeComponent();
            this.Text = "�P���T����";
            starsTextBox.Text = string.Empty;
        }

        private void leftStarsButton_Click(object sender, EventArgs e)
        {
            // ���o�C��
            int rows = 0;
            try
            { 
                rows = GetRows(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // �ͦ��P���T����
            string stras = leftStars(rows);

            //�e�{�P���T����
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

            // ��J���ȥ������Ʀr
            if (!isint) 
            {
                throw new Exception("�п�J�Ʀr");                
            }
            // ��J���ƥ�������1~10
            if (rows <= 0 || rows > 10)
            {
                throw new Exception("�C�ƥ�������1~10");
            }
            return rows;
        }

        private void rightStarsButton_Click(object sender, EventArgs e)
        {
            // ���o�C��
            int rows = 0;
            try
            {
                rows = GetRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // �ͦ��P���T����
            string stras = rightStars(rows);

            //�e�{�P���T����
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
            // ���o�C��
            int rows = 0;
            try
            {
                rows = GetRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // �ͦ��P���T����
            string stras = isoscelesStarsStars(rows);

            //�e�{�P���T����
            starsTextBox.Text = stras;
        }

        private string isoscelesStarsStars(int rows)
        {
            string result = string.Empty;
            for (int i = 1; i <= rows; i++)
            {
                result += new string(' ', rows - i) + new string('*', 2 * i - 1) + "\r\n";
                
                // �P���ƶq
                //result = new string('*', 2 * i - 1).PadLeft(rows + i - 1);
            }
            return result;
        }
    }
}