using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Lanterns : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime = 17031;
        [Configurable]
        public int endTime = 27639;

        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            var rope1 = lay_fore.CreateSprite(@"SB\2dx_42.png", OsbOrigin.TopRight, new Vector2(320, 5));
            rope1.Rotate(startTime, startTime + (17445 - 17031), 1, 0.3);
            rope1.Fade(endTime, 1);
            var rope2 = lay_fore.CreateSprite(@"SB\2dx_42.png", OsbOrigin.TopLeft, new Vector2(310, 5));
            rope2.Rotate(startTime + 100, startTime + (17528 - 17031), -1, -0.37);
            rope2.FlipH(startTime, endTime);
            rope2.ScaleVec(startTime, 0.73, 1);
            rope2.Fade(endTime, 1);
            var rope3 = lay_fore.CreateSprite(@"SB\2dx_42.png", OsbOrigin.TopRight, new Vector2(320, 5));
            rope3.Rotate(startTime + 200, startTime + (17611 - 17031), 1, 0.57);
            rope3.ScaleVec(startTime, 0.7, 1);
            rope3.Fade(endTime, 1);

            int interval = 90;
            int delay = 350;
            for (int i = 0; i < 5; i++)
            {
                Vector2 point;
                double zoom = 1;
                double deg = 0;
                if (i == 0)
                {
                    point = new Vector2(280, 15);
                    zoom = 0.45;
                    deg = 0.03;
                }
                else if (i == 1)
                {
                    point = new Vector2(247, 25);
                    zoom = 0.62;
                    deg = 0.03;
                }
                else if (i == 2)
                {
                    point = new Vector2(192, 34);
                    zoom = 0.8;
                    deg = -0.095;
                }
                else if (i == 3)
                {
                    point = new Vector2(122, 39);
                    zoom = 0.9;
                    deg = -0.1;
                }
                else
                {
                    point = new Vector2(65, 35);
                    zoom = 1;
                    deg = 0.23;
                }
                var lant = lay_fore.CreateSprite(@"SB\2dx_131.png", OsbOrigin.TopCentre, point);
                lant.Rotate(startTime + interval * i, startTime + interval * i + delay, 1, deg);
                lant.Fade(startTime + interval * i, startTime + interval * i + delay, 0, 1);
                lant.Fade(endTime, 1);
                lant.Scale(endTime, zoom);
                var lantLight = lay_fore.CreateSprite(@"SB\2dx_132.png", OsbOrigin.TopCentre, point);
                lantLight.Rotate(startTime + interval * i, startTime + interval * i + delay, 1, deg);
                lantLight.Fade(startTime + interval * i, startTime + interval * i + delay, 0, 1);
                lantLight.Fade(endTime, 0);
                lantLight.Scale(endTime, zoom);
                lantLight.Additive(startTime + 100 + interval * i, endTime);
                lantLight.StartLoopGroup(startTime + 100 + interval * i + Random(0, 20), 150);
                int lightInterval = 50;
                lantLight.Color(0, lightInterval, 0.7, 0.7, 0.7, 0.3, 0.3, 0.3);
                lantLight.Color(lightInterval, lightInterval * 2, 0.3, 0.3, 0.3, 0.7, 0.7, 0.7);
                lantLight.EndGroup();
            }

            for (int i = 0; i < 6; i++)
            {
                Vector2 point;
                double zoom = 1;
                double deg = 0;
                if (i == 0)
                {
                    point = new Vector2(338, 13);
                    zoom = 0.45;
                    deg = 0;
                }
                else if (i == 1)
                {
                    point = new Vector2(380, 30);
                    zoom = 0.4;
                    deg = 0;
                }
                else if (i == 2)
                {
                    point = new Vector2(425, 41);
                    zoom = 0.62;
                    deg = 0;
                }
                else if (i == 3)
                {
                    point = new Vector2(481, 45);
                    zoom = 0.8;
                    deg = 0.06;
                }
                else if (i == 4)
                {
                    point = new Vector2(527, 42);
                    zoom = 1;
                    deg = -0.18;
                }
                else
                {
                    point = new Vector2(602, 3);
                    zoom = 1.1;
                    deg = 0.08;
                }
                var lant = lay_fore.CreateSprite(@"SB\2dx_131.png", OsbOrigin.TopCentre, point);
                lant.Rotate(startTime + 100 + interval * i, startTime + 100 + interval * i + delay, -1, deg);
                lant.Fade(startTime + 100 + interval * i, startTime + 100 + interval * i + delay, 0, 1);
                lant.Fade(endTime, 1);
                lant.Scale(endTime, zoom);

                var lantLight = lay_fore.CreateSprite(@"SB\2dx_132.png", OsbOrigin.TopCentre, point);
                lantLight.Rotate(startTime + 100 + interval * i, startTime + 100 + interval * i + delay, -1, deg);
                lantLight.Fade(startTime + 100 + interval * i, startTime + 100 + interval * i + delay, 0, 1);
                lantLight.Fade(endTime, 0);
                lantLight.Scale(endTime, zoom);
                lantLight.Additive(startTime + 100 + interval * i, endTime);
                lantLight.StartLoopGroup(startTime + 100 + interval * i + Random(0, 20), 150);
                int lightInterval = 50;
                lantLight.Color(0, lightInterval, 0.7, 0.7, 0.7, 0.3, 0.3, 0.3);
                lantLight.Color(lightInterval, lightInterval * 2, 0.3, 0.3, 0.3, 0.7, 0.7, 0.7);
                lantLight.EndGroup();
            }
        }
    }
}
