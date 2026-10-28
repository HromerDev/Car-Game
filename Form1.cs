using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videohra
{
    public partial class Form1 : Form
    {
        static Random rng = new Random();
        static ulong frames;
        
        static class CarManager
        {
			public static bool up = false;
			public static bool down = false;
			static List<Car> enemyCars = new List<Car>();
			public static PictureBox[] spawnLocations;
			public static void InstantiateCars(int amount, Form form)
			{
				for (int i = 0; i < amount; i++)
				{
					PictureBox enemy = new PictureBox();	
					enemy.Width = 50;
					enemy.Height = 50;
					enemy.BackColor = Color.Black;
					enemy.Location = new Point(-100, -100);

					enemyCars.Add(new Car(enemy));
					form.Controls.Add(enemyCars[enemyCars.Count - 1].sprite);
					enemy.Visible = false;
				}
			}
			public static void SpawnCars()
			{              
				for(int i = 0; i < 30; i++)  
				{
					if (!enemyCars[i].sprite.Visible)
					{
						int random = rng.Next(0, 3);
						enemyCars[i].sprite.Location = spawnLocations[random].Location;
						enemyCars[i].sprite.Visible = true;

                        return;
					}
				}
			}
			public static void enemyCarStateChange()
			{
				foreach (Car car in CarManager.enemyCars)
				{
					if (car.sprite.Location.X < -car.sprite.Width - 10)
					{
						car.sprite.Location = new Point(-100, -100);
						car.sprite.Visible = false;
					}

					if (car.sprite.Visible)
						car.Move(-4, 0);
				}
			}
			public static void PlayerMovement(Car player)
			{
				if (up && player.sprite.Location.Y > 100)				
					player.Move(0, 4);
				
				if (down && player.sprite.Location.Y < 308)				
					player.Move(0, -4);				
			}
			public static bool Collision(Car player) 
			{
				foreach (Car enemyCar in enemyCars) 
				{
					if (enemyCar.sprite.Visible) 
					{
						if (player.sprite.Location.X + player.sprite.Width > enemyCar.sprite.Location.X &&
							player.sprite.Location.X < enemyCar.sprite.Location.X + enemyCar.sprite.Width &&
						   player.sprite.Location.Y < enemyCar.sprite.Location.Y + enemyCar.sprite.Height &&
						   player.sprite.Location.Y + player.sprite.Height > enemyCar.sprite.Location.Y)
							return true;
					}
				}

				return false;
			}
		}

        class Car 
        {
            public PictureBox sprite;

            public Car(PictureBox playerModel)
            {
                this.sprite = playerModel;
            }

            public void Move(int x, int y) 
            {
                sprite.Location = new Point(sprite.Location.X + x, sprite.Location.Y - y);
            }
        }
        Car player;

        public Form1()
        {           
            InitializeComponent();

			this.Width = 750;
			this.Height = 500;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

        private void Form1_Load(object sender, EventArgs e)
        {            
			player = new Car(car);
			player.sprite.Location = new Point(30, this.Height / 2 - player.sprite.Height);

			CarManager.spawnLocations = new PictureBox[] { spawnLocation1, spawnLocation2, spawnLocation3 };
			CarManager.InstantiateCars(30, this);

			PictureBox[] borders = new PictureBox[] { new PictureBox(), new PictureBox() };

			foreach (PictureBox border in borders) 
			{
				border.BackColor = Color.Black;
				border.Width = this.Width;
				border.Height = 100;
				this.Controls.Add(border);
			}
			borders[0].Location = new Point(0, borders[0].Top);
			borders[1].Location = new Point(0, this.Height - borders[1].Bottom - 39);

			spawnLocation1.Visible = false;
			spawnLocation2.Visible = false;
			spawnLocation3.Visible = false;

		}

        private void Update(object sender, EventArgs e)
        {
			label1.Text = frames.ToString();
			CarManager.PlayerMovement(player);
            CarManager.enemyCarStateChange();

			if (frames % 50 == 0)
				CarManager.SpawnCars();

			if (CarManager.Collision(player))
				timer1.Stop();

			frames++;			
        }
     
        private void buttonUp_MouseDown(object sender, MouseEventArgs e)
        {
			CarManager.up = true;
        }

        private void buttonUp_MouseUp(object sender, MouseEventArgs e)
        {
            CarManager.up = false;
        }

        private void buttonDown_MouseUp(object sender, MouseEventArgs e)
        {
			CarManager.down = false;
        }

        private void buttonDown_MouseDown(object sender, MouseEventArgs e)
        {
			CarManager.down = true;
        }
	}
}
