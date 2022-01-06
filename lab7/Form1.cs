using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        bool presents = false;
        bool star = false;
        bool balls = false;
        bool lights = false;
        bool tinsel = false;
        bool carol = false;

        Random random = new Random();

        List<Ball> ballsList = new List<Ball>();
        Brush[] ballsBrush = new Brush[]
        {
            Brushes.White,
            Brushes.Gold,
            Brushes.CornflowerBlue
        };
        Timer timer;

        SoundPlayer sound = new SoundPlayer(@"D:\Downloads\My\Uni\Subjects\Sem. 3\PO\PO_2021-2022\lab7\jingle_bell_rock.wav");
        bool isPlaying = false;

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Tick += new EventHandler(LightsTick);
            timer.Interval = 550;
            timer.Start();
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            point_tb.Text += $"\r\nnew Point({e.X}, {e.Y}),";
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            nowPoint.Text = $"\r\nnew Point({e.X}, {e.Y}),";
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            DrawBackground(e.Graphics);
            DrawChristmasTree(e.Graphics);

            if (presents) DrawPresents(e.Graphics);
            if (star) DrawStar(e.Graphics);
            if (balls) DrawBalls(e.Graphics);
            if (lights) DrawLights();
            if (tinsel) DrawTinsel(e.Graphics);
            if (carol && !isPlaying)
            {
                sound.PlayLooping();
                isPlaying = true;
            }
            else if (!carol && isPlaying)
            {
                sound.Stop();
                isPlaying = false;
            }
        }

        private void presents_cb_CheckedChanged(object sender, EventArgs e)
        {
            presents = !presents;
            panel.Refresh();
        }

        private void star_cb_CheckedChanged(object sender, EventArgs e)
        {
            star = !star;
            panel.Refresh();
        }

        private void balls_cb_CheckedChanged(object sender, EventArgs e)
        {
            balls = !balls;

            if (balls) BallsPrep();

            panel.Refresh();
        }

        private void lights_cb_CheckedChanged(object sender, EventArgs e)
        {
            lights = !lights;
            panel.Refresh();
        }

        private void tinsel_cb_CheckedChanged(object sender, EventArgs e)
        {
            tinsel = !tinsel;
            panel.Refresh();
        }

        private void carol_cb_CheckedChanged(object sender, EventArgs e)
        {
            carol = !carol;
            panel.Refresh();
        }

        private void DrawBackground(Graphics g)
        {
            g.FillRectangle(Brushes.LightSteelBlue, 0, 0, 423, 418);
        }

        private void DrawChristmasTree(Graphics g)
        {
            Point[] trunk = new Point[]
            {
                new Point(185, 285),
                new Point(220, 285),
                new Point(220, 320),
                new Point(185, 330)
            };
            g.FillPolygon(Brushes.Peru, trunk);

            Point[] trunk_1 = new Point[]
            {
                new Point(185, 289),
                new Point(220, 287),
                new Point(220, 310),
                new Point(185, 303)
            };
            g.FillPolygon(Brushes.SaddleBrown, trunk_1);


            Point[] tree3 = new Point[]
            {
                new Point(245, 190),
                new Point(160, 190),
                new Point(90, 285),
                new Point(320, 295)
            };
            g.FillPolygon(Brushes.ForestGreen, tree3);

            Point[] tree3_1 = new Point[]
            {
                new Point(165, 207),
                new Point(254, 202),
                new Point(274, 231),
            };
            g.FillPolygon(Brushes.DarkGreen, tree3_1);

            Point[] tree3_2 = new Point[]
            {
                new Point(114, 252),
                new Point(116, 270),
                new Point(310, 295),
                new Point(89, 286)
            };
            g.FillPolygon(Brushes.LightGreen, tree3_2);


            Point[] tree2 = new Point[]
            {
                new Point(213, 120),
                new Point(185, 120),
                new Point(120, 210),
                new Point(287, 200)
            };
            g.FillPolygon(Brushes.ForestGreen, tree2);

            Point[] tree2_1 = new Point[]
            {
                new Point(180, 127),
                new Point(220, 133),
                new Point(168, 143)
            };
            g.FillPolygon(Brushes.DarkGreen, tree2_1);

            Point[] tree2_2 = new Point[]
            {
                new Point(147, 172),
                new Point(150, 193),
                new Point(277, 201),
                new Point(120, 210)
            };
            g.FillPolygon(Brushes.LightGreen, tree2_2);


            Point[] tree1 = new Point[]
            {
                new Point(200, 80),
                new Point(165, 125),
                new Point(245, 135)
            };
            g.FillPolygon(Brushes.ForestGreen, tree1);

            Point[] tree1_1 = new Point[]
            {
                new Point(179, 107),
                new Point(179, 119),
                new Point(245, 135),
                new Point(165, 125),
            };
            g.FillPolygon(Brushes.LightGreen, tree1_1);
        }

        private void DrawPresents(Graphics g)
        {
            // present 1
            Point[] present = new Point[]
            {
                new Point(120, 305),
                new Point(170, 305),
                new Point(170, 370),
                new Point(120, 370)
            };
            g.FillPolygon(Brushes.Violet, present);

            Point[] presentLines = new Point[]
            {
                new Point(137, 305),
                new Point(153, 305),
                new Point(153, 370),
                new Point(137, 370)
            };
            g.FillPolygon(Brushes.DeepSkyBlue, presentLines);

            presentLines = new Point[]
            {
                new Point(120, 330),
                new Point(170, 330),
                new Point(170, 346),
                new Point(120, 346)
            };
            g.FillPolygon(Brushes.DeepSkyBlue, presentLines);

            //present 2
            present = new Point[]
            {
                new Point(195, 315),
                new Point(265, 315),
                new Point(265, 355),
                new Point(195, 355)
            };
            g.FillPolygon(Brushes.Salmon, present);

            presentLines = new Point[]
            {
                new Point(215, 315),
                new Point(225, 315),
                new Point(225, 355),
                new Point(215, 355)
            };
            g.FillPolygon(Brushes.FloralWhite, presentLines);

            presentLines = new Point[]
            {
                new Point(195, 330),
                new Point(265, 330),
                new Point(265, 340),
                new Point(195, 340)
            };
            g.FillPolygon(Brushes.FloralWhite, presentLines);

            // present 3
            present = new Point[]
            {
                new Point(240, 345),
                new Point(280, 345),
                new Point(280, 385),
                new Point(240, 385)
            };
            g.FillPolygon(Brushes.YellowGreen, present);

            presentLines = new Point[]
            {
                new Point(257, 345),
                new Point(263, 345),
                new Point(263, 385),
                new Point(257, 385),
            };
            g.FillPolygon(Brushes.Orange, presentLines);

            presentLines = new Point[]
            {
                new Point(240, 362),
                new Point(280, 362),
                new Point(280, 368),
                new Point(240, 368)
            };
            g.FillPolygon(Brushes.Orange, presentLines);
        }

        private void DrawStar(Graphics g)
        {
            Point[] star = new Point[]
            {
                new Point(200, 45),
                new Point(207, 60),
                new Point(223, 63),
                new Point(210, 70),
                new Point(220, 85),
                new Point(200, 75),
                new Point(180, 85),
                new Point(190, 70),
                new Point(178, 63),
                new Point(193, 60)
            };
            g.FillPolygon(Brushes.Yellow, star);
        }

        private void DrawBall(Graphics g, Brush brush, PointF position, float size)
        {
            g.FillEllipse(brush, position.X - size / 2, position.Y - size / 2, size, size);
        }

        private void DrawBalls(Graphics g)
        {
            for (int i = 0; i < ballsList.Count; i++)
            {
                DrawBall(g, ballsList[i].brush, ballsList[i].position, ballsList[i].size);
            }
        }

        private void BallsPrep()
        {
            PointF[] ballsArea = new PointF[]
            {
                new PointF(200, 80),
                new PointF(245, 135),
                new PointF(224, 133),
                new PointF(287, 200),
                new PointF(253, 202),
                new PointF(320, 295),
                new PointF(90, 285),
                new PointF(146, 209),
                new PointF(120, 210),
                new PointF(180, 127),
                new PointF(165, 125)
            };

            ballsList.Clear();

            while (ballsList.Count < 22)
            {
                PointF randPosition = new PointF(random.Next(89, 295), random.Next(80, 290));

                if (IsPointInPolygon(ballsArea, randPosition))
                {
                    ballsList.Add(new Ball(ballsBrush[random.Next(0, ballsBrush.Length)], randPosition, random.Next(10, 15)));
                }
            }
        }

        public bool IsPointInPolygon(PointF[] polygon, PointF testPoint)
        {
            bool result = false;
            int j = polygon.Count() - 1;
            for (int i = 0; i < polygon.Count(); i++)
            {
                if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y || polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
                {
                    if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < testPoint.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }

        private void DrawLights()
        {
            Point[] lights = new Point[]
            {
                new Point(223, 109),
                new Point(219, 113),
                new Point(213, 114),
                new Point(209, 115),
                new Point(202, 118),
                new Point(198, 118),
                new Point(192, 118),
                new Point(186, 116),
                new Point(182, 114),
                new Point(177, 111),

                new Point(171, 141),
                new Point(171, 145),
                new Point(175, 149),
                new Point(177, 153),
                new Point(182, 156),
                new Point(187, 160),
                new Point(191, 160),
                new Point(194, 163),
                new Point(198, 164),
                new Point(205, 166),
                new Point(208, 168),
                new Point(212, 168),
                new Point(216, 169),
                new Point(222, 168),
                new Point(226, 167),
                new Point(228, 167),
                new Point(232, 164),
                new Point(238, 163),
                new Point(240, 160),
                new Point(245, 158),

                new Point(252, 163),
                new Point(251, 167),
                new Point(251, 170),
                new Point(249, 177),
                new Point(248, 183),
                new Point(245, 184),
                new Point(241, 191),
                new Point(241, 191),
                new Point(239, 193),
                new Point(236, 196),
                new Point(234, 200),
                new Point(230, 204),
                new Point(224, 205),
                new Point(220, 208),
                new Point(214, 209),
                new Point(209, 212),
                new Point(206, 214),
                new Point(203, 214),
                new Point(196, 216),
                new Point(187, 217),
                new Point(184, 217),
                new Point(179, 217),
                new Point(171, 214),
                new Point(164, 211),
                new Point(159, 211),
                new Point(154, 210),
                new Point(146, 206),
                new Point(140, 204),
                new Point(137, 203),
                new Point(134, 201),
                new Point(130, 198),
                new Point(129, 196),

                new Point(152, 164),
                new Point(154, 168),
                new Point(156, 173),
                new Point(160, 179),
                new Point(162, 182),
                new Point(166, 186),
                new Point(168, 189),
                new Point(170, 192),
                new Point(172, 196),
                new Point(175, 200),
                new Point(177, 203),
                new Point(180, 206),
                new Point(185, 209),
                new Point(188, 212),
                new Point(196, 219),
                new Point(193, 215),
                new Point(201, 222),
                new Point(205, 224),
                new Point(213, 227),
                new Point(218, 230),
                new Point(223, 232),
                new Point(229, 235),
                new Point(235, 236),
                new Point(240, 236),
                new Point(245, 236),
                new Point(248, 237),
                new Point(254, 238),
                new Point(259, 237),
                new Point(264, 236),
                new Point(266, 234),
                new Point(267, 232),
                new Point(271, 228),

                new Point(274, 232),
                new Point(274, 238),
                new Point(272, 245),
                new Point(269, 247),
                new Point(265, 250),
                new Point(259, 256),
                new Point(255, 258),
                new Point(250, 260),
                new Point(243, 261),
                new Point(239, 263),
                new Point(235, 266),
                new Point(228, 268),
                new Point(225, 269),
                new Point(219, 269),
                new Point(213, 270),
                new Point(206, 272),
                new Point(199, 269),
                new Point(193, 273),
                new Point(188, 273),
                new Point(184, 273),
                new Point(179, 274),
                new Point(175, 274),
                new Point(171, 275),
                new Point(162, 274),
                new Point(158, 275),
                new Point(147, 276),
                new Point(137, 274),
                new Point(132, 274),
                new Point(123, 274),
                new Point(118, 272),
                new Point(113, 270),
                new Point(109, 269),
                new Point(105, 267),
                new Point(104, 265),

                new Point(137, 224),
                new Point(139, 227),
                new Point(142, 230),
                new Point(146, 233),
                new Point(148, 235),
                new Point(153, 239),
                new Point(158, 241),
                new Point(158, 241),
                new Point(163, 246),
                new Point(167, 248),
                new Point(176, 252),
                new Point(181, 254),
                new Point(185, 257),
                new Point(192, 258),
                new Point(197, 261),
                new Point(207, 263),
                new Point(218, 264),
                new Point(229, 265),
                new Point(241, 266),
                new Point(246, 267),
                new Point(251, 269),
                new Point(261, 268),
                new Point(269, 268),
                new Point(275, 268),
                new Point(284, 266),
                new Point(293, 266),
                new Point(296, 266)
            };

            Brush[] brushes = new Brush[]
            {
                Brushes.OrangeRed,
                Brushes.DarkSeaGreen,
                Brushes.LightGoldenrodYellow,
                Brushes.BlueViolet
            };

            Graphics lightsGraphics = panel.CreateGraphics();

            for (int i = 0; i < lights.Length; i++)
            {
                lightsGraphics.FillEllipse(brushes[random.Next(0, brushes.Length)], lights[i].X, lights[i].Y, 3.3f, 3.3f);
            }
        }

        private void LightsTick(object sender, EventArgs e)
        {
            if (lights) DrawLights();
        }

        private void DrawTinsel(Graphics g)
        {
            Point[] tinsel = new Point[]
            {
                new Point(186, 96),
                new Point(202, 113),
                new Point(234, 121)
            };
            g.DrawCurve(new Pen(Brushes.White, 8f), tinsel, 2f);
            g.DrawCurve(new Pen(Brushes.Gold, 2.5f), tinsel, 2f);

            tinsel = new Point[]
            {
                new Point(179, 128),
                new Point(191, 151),
                new Point(211, 159),
                new Point(242, 153)
            };
            g.DrawCurve(new Pen(Brushes.White, 8f), tinsel, 2f);
            g.DrawCurve(new Pen(Brushes.Gold, 2.5f), tinsel, 2f);

            tinsel = new Point[]
            {
                new Point(157, 159),
                new Point(184, 183),
                new Point(225, 192),
                new Point(275, 188)
            };
            g.DrawCurve(new Pen(Brushes.White, 8f), tinsel, 2f);
            g.DrawCurve(new Pen(Brushes.Gold, 2.5f), tinsel, 2f);

            tinsel = new Point[]
            {
                new Point(147, 209),
                new Point(177, 232),
                new Point(217, 246),
                new Point(290, 255)
            };
            g.DrawCurve(new Pen(Brushes.White, 8f), tinsel, 2f);
            g.DrawCurve(new Pen(Brushes.Gold, 2.5f), tinsel, 2f);

            tinsel = new Point[]
            {
                new Point(120, 244),
                new Point(186, 277),
                new Point(243, 283),
                new Point(315, 287)
            };
            g.DrawCurve(new Pen(Brushes.White, 8f), tinsel, 2f);
            g.DrawCurve(new Pen(Brushes.Gold, 2.5f), tinsel, 2f);
        }
    }
}
