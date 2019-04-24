using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rect
{
    public partial class Form1 : Form
    {
        
        public int x;
        public int y;
        Direction direction;

        enum Direction
        {
            Right,
            Left,
            Up,
            Down
        }
        
        public Form1()
        {
            InitializeComponent();
            x = 50;
            y = 60;
            direction = Direction.Left;
            
        }
      

        
        
        public void move(Direction b)
        {

           
            if (direction == Direction.Right)
            {
                x += 10;
            }
            else if (direction == Direction.Left)
            {
                x -= 10;
            }
            else if (direction == Direction.Up)
            {
                y -= 10;
            }
            else if (direction == Direction.Down)
            {
                y += 10;
            }
            Refresh();

        }
       
        public void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Magenta, 2);
            e.Graphics.FillRectangle(Brushes.Red, x, y, 30, 30);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.Text == "Left")
            {
                direction = Direction.Left;
            }
            else if (b.Text == "Right")
            {
                direction = Direction.Left;
            }
            else if ((Button)sender == button3)
            {
                direction = Direction.Up;
            }
            else if ((Button)sender == button4)
            {
                direction = Direction.Down;
            }
        }
    }

}
