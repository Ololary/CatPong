using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatPong
{
    public partial class Form1 : Form
    {
        private int speed_vertical = 3;
        private int speed_horizontal =3;
        private int score = 0;
        public Form1()
        {

            InitializeComponent();
            //
            timer.Enabled = true;
            //прячу курсор во время запуска
            Cursor.Hide();
            //убираю обводку окна
            FormBorderStyle = FormBorderStyle.None;
            //запуск программы поверх других окон
            TopMost = true;
            //масштабирование экраны относитьельно размера экрана, на которм она будет запущена
            Bounds = Screen.PrimaryScreen.Bounds;
            //устанавливаем расположение игровой котопанели относительно нижней части бэкграунда
            gamepanel.Top = background.Bottom - (background.Bottom / 7);
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            gamepanel.Left = Cursor.Position.X - (gamepanel.Width / 2);
            gameball.Left += speed_horizontal;
            gameball.Top += speed_vertical;

            if (gameball.Left<=background.Left)
            {
                speed_horizontal *= -1;
            }
            if (gameball.Right >= background.Right)
            {
                speed_horizontal *= -1;
            }
            if (gameball.Top<= background.Top)
            {
                speed_vertical *= -1;
            }
            if (gameball.Bottom >= background.Bottom)
            {
                timer.Enabled = false;
            }
            if (gameball.Bottom>=gamepanel.Top&&gameball.Bottom <=gamepanel.Bottom
                &&gameball.Left>=gamepanel.Left&&gameball.Right<=gamepanel.Right)
            {
                speed_horizontal += 1;
                speed_vertical += 1;
                speed_vertical *= -1;
                score = +1;
                result.Text = "Результат: " + score.ToString();
            }
        }
    }
}
