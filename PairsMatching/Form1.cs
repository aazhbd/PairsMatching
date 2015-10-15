using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PairsMatching
{
    public partial class Form1 : Form
    {
        int[] nums, flag;
        Random rnd;
//        String tmp;

        int first, second, fbox, sbox;
        double cscore, score, moves;

        public Form1()
        {
            int i, x, j;
            InitializeComponent();

            nums = new int[21];
            flag = new int[11];
            rnd = new Random();

//            tmp = "";

            for (i = 0; i < 11; i++) flag[i] = 0;

            for (i = 0; i < 10; i++)
            {
                x = rnd.Next(10);
                while (flag[x] != 0)
                {
                    x = rnd.Next(10);
                }

                nums[i] = x;
                flag[x] = 1;
            }

            j = i;
            for (i = 0; i < 11; i++) flag[i] = 0;

            for (i = 0; i < 10; i++)
            {
                x = rnd.Next(10);
                while (flag[x] != 0)
                {
                    x = rnd.Next(10);
                }

                nums[j] = x;
                flag[x] = 1;
                j++;
            }

//            for (i = 0; i < 20; i++) tmp += " : " + nums[i];

//            MessageBox.Show(tmp);

            box1.Image = Image.FromFile("imgs/b.jpg");
            box2.Image = Image.FromFile("imgs/b.jpg");
            box3.Image = Image.FromFile("imgs/b.jpg");
            box4.Image = Image.FromFile("imgs/b.jpg");
            box5.Image = Image.FromFile("imgs/b.jpg");
            box6.Image = Image.FromFile("imgs/b.jpg");
            box7.Image = Image.FromFile("imgs/b.jpg");
            box8.Image = Image.FromFile("imgs/b.jpg");
            box9.Image = Image.FromFile("imgs/b.jpg");
            box10.Image = Image.FromFile("imgs/b.jpg");
            box11.Image = Image.FromFile("imgs/b.jpg");
            box12.Image = Image.FromFile("imgs/b.jpg");
            box13.Image = Image.FromFile("imgs/b.jpg");
            box14.Image = Image.FromFile("imgs/b.jpg");
            box15.Image = Image.FromFile("imgs/b.jpg");
            box16.Image = Image.FromFile("imgs/b.jpg");
            box17.Image = Image.FromFile("imgs/b.jpg");
            box18.Image = Image.FromFile("imgs/b.jpg");
            box19.Image = Image.FromFile("imgs/b.jpg");
            box20.Image = Image.FromFile("imgs/b.jpg");

            first = -1;
            second = -1;
            score = 0;
            cscore = 0;
            moves = 0;

            fbox = -1;
            sbox = -1;
        }

        private void box1_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[0];
                fbox = 1;
                box1.Image = Image.FromFile("imgs/" + nums[0] + ".jpg");
            }
            else
            {
                second = nums[0];
                sbox = 1;
                box1.Image = Image.FromFile("imgs/" + nums[0] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = score / moves;
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box2_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[1];
                fbox = 2;
                box2.Image = Image.FromFile("imgs/" + nums[1] + ".jpg");
            }
            else
            {
                second = nums[1];
                sbox = 2;
                box2.Image = Image.FromFile("imgs/" + nums[1] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box3_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[2];
                fbox = 3;
                box3.Image = Image.FromFile("imgs/" + nums[2] + ".jpg");
            }
            else
            {
                second = nums[2];
                sbox = 3;
                box3.Image = Image.FromFile("imgs/" + nums[2] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box4_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[3];
                fbox = 4;
                box4.Image = Image.FromFile("imgs/" + nums[3] + ".jpg");
            }
            else
            {
                second = nums[3];
                sbox = 4;
                box4.Image = Image.FromFile("imgs/" + nums[3] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box5_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[4];
                fbox = 5;
                box5.Image = Image.FromFile("imgs/" + nums[4] + ".jpg");
            }
            else
            {
                second = nums[4];
                sbox = 5;
                box5.Image = Image.FromFile("imgs/" + nums[4] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box6_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[5];
                fbox = 6;
                box6.Image = Image.FromFile("imgs/" + nums[5] + ".jpg");
            }
            else
            {
                second = nums[5];
                sbox = 6;
                box6.Image = Image.FromFile("imgs/" + nums[5] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box7_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[6];
                fbox = 7;
                box7.Image = Image.FromFile("imgs/" + nums[6] + ".jpg");
            }
            else
            {
                second = nums[6];
                sbox = 7;
                box7.Image = Image.FromFile("imgs/" + nums[6] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box8_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[7];
                fbox = 8;
                box8.Image = Image.FromFile("imgs/" + nums[7] + ".jpg");
            }
            else
            {
                second = nums[7];
                sbox = 8;
                box8.Image = Image.FromFile("imgs/" + nums[7] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box9_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[8];
                fbox = 9;
                box9.Image = Image.FromFile("imgs/" + nums[8] + ".jpg");
            }
            else
            {
                second = nums[8];
                sbox = 9;
                box9.Image = Image.FromFile("imgs/" + nums[8] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box10_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[9];
                fbox = 10;
                box10.Image = Image.FromFile("imgs/" + nums[9] + ".jpg");
            }
            else
            {
                second = nums[9];
                sbox = 10;
                box10.Image = Image.FromFile("imgs/" + nums[9] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box11_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[10];
                fbox = 11;
                box11.Image = Image.FromFile("imgs/" + nums[10] + ".jpg");
            }
            else
            {
                second = nums[10];
                sbox = 11;
                box11.Image = Image.FromFile("imgs/" + nums[10] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box12_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[11];
                fbox = 12;
                box12.Image = Image.FromFile("imgs/" + nums[11] + ".jpg");
            }
            else
            {
                second = nums[11];
                sbox = 12;
                box12.Image = Image.FromFile("imgs/" + nums[11] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box13_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[12];
                fbox = 13;
                box13.Image = Image.FromFile("imgs/" + nums[12] + ".jpg");
            }
            else
            {
                second = nums[12];
                sbox = 13;
                box13.Image = Image.FromFile("imgs/" + nums[12] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box14_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[13];
                fbox = 14;
                box14.Image = Image.FromFile("imgs/" + nums[13] + ".jpg");
            }
            else
            {
                second = nums[13];
                sbox = 14;
                box14.Image = Image.FromFile("imgs/" + nums[13] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box15_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[14];
                fbox = 15;
                box15.Image = Image.FromFile("imgs/" + nums[14] + ".jpg");
            }
            else
            {
                second = nums[14];
                sbox = 15;
                box15.Image = Image.FromFile("imgs/" + nums[14] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box16_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[15];
                fbox = 16;
                box16.Image = Image.FromFile("imgs/" + nums[15] + ".jpg");
            }
            else
            {
                second = nums[15];
                sbox = 16;
                box16.Image = Image.FromFile("imgs/" + nums[15] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box17_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[16];
                fbox = 17;
                box17.Image = Image.FromFile("imgs/" + nums[16] + ".jpg");
            }
            else
            {
                second = nums[16];
                sbox = 17;
                box17.Image = Image.FromFile("imgs/" + nums[16] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box18_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[17];
                fbox = 18;
                box18.Image = Image.FromFile("imgs/" + nums[17] + ".jpg");
            }
            else
            {
                second = nums[17];
                sbox = 18;
                box18.Image = Image.FromFile("imgs/" + nums[17] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box19_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[18];
                fbox = 19;
                box19.Image = Image.FromFile("imgs/" + nums[18] + ".jpg");
            }
            else
            {
                second = nums[18];
                sbox = 19;
                box19.Image = Image.FromFile("imgs/" + nums[18] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void box20_Click(object sender, EventArgs e)
        {
            if (first == -1)
            {
                first = nums[19];
                fbox = 20;
                box20.Image = Image.FromFile("imgs/" + nums[19] + ".jpg");
            }
            else
            {
                second = nums[19];
                sbox = 20;
                box20.Image = Image.FromFile("imgs/" + nums[19] + ".jpg");
                if (first == second)
                {
                    score += 10;
                    textBox1.Text = "" + score;
                    MessageBox.Show("Correct matching", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cscore = (score / moves);
                    textBox2.Text = "" + cscore + "%";
                }
                else
                {
                    MessageBox.Show("Incorrect matching", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (fbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }

                    switch (sbox)
                    {
                        case 1:
                            box1.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 2:
                            box2.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 3:
                            box3.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 4:
                            box4.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 5:
                            box5.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 6:
                            box6.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 7:
                            box7.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 8:
                            box8.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 9:
                            box9.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 10:
                            box10.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 11:
                            box11.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 12:
                            box12.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 13:
                            box13.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 14:
                            box14.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 15:
                            box15.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 16:
                            box16.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 17:
                            box17.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 18:
                            box18.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 19:
                            box19.Image = Image.FromFile("imgs/b.jpg");
                            break;
                        case 20:
                            box20.Image = Image.FromFile("imgs/b.jpg");
                            break;
                    }
                }
                first = -1;
                second = -1;
                fbox = -1;
                sbox = -1;
            }

            moves++;
            textBox3.Text = "" + moves;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Pair Matching Game,\n\n Abdullah Al Zakir Hossain,\nwww.aazhbd.com", "Developer Credit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}