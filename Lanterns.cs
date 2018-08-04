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
        public int StartTime = 17031;
        [Configurable]
        public int EndTime = 27639;

        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");
            var rope1 = layFore.CreateSprite(@"SB\2dx_42.png", OsbOrigin.TopRight, new Vector2(320, 5));
            rope1.Rotate(StartTime, StartTime + (17445 - 17031), 1, 0.3);
            rope1.Fade(EndTime, 1);

            var rope2 = layFore.CreateSprite(@"SB\2dx_42.png", OsbOrigin.TopLeft, new Vector2(310, 5));
            rope2.Rotate(StartTime + 100, StartTime + (17528 - 17031), -1, -0.37);
            rope2.FlipH(StartTime, EndTime);
            rope2.ScaleVec(StartTime, 0.73, 1);
            rope2.Fade(EndTime, 1);

            var rope3 = layFore.CreateSprite(@"SB\2dx_42.png", OsbOrigin.TopRight, new Vector2(320, 5));
            rope3.Rotate(StartTime + 200, StartTime + (17611 - 17031), 1, 0.57);
            rope3.ScaleVec(StartTime, 0.7, 1);
            rope3.Fade(EndTime, 1);

            const int interval = 90, delay = 350;
            for (int i = 0; i < 5; i++)
            {
                Vector2 point;
                double zoom, deg;
                switch (i)
                {
                    case 0:
                        point = new Vector2(280, 15);
                        zoom = 0.45;
                        deg = 0.03;
                        break;
                    case 1:
                        point = new Vector2(247, 25);
                        zoom = 0.62;
                        deg = 0.03;
                        break;
                    case 2:
                        point = new Vector2(192, 34);
                        zoom = 0.8;
                        deg = -0.095;
                        break;
                    case 3:
                        point = new Vector2(122, 39);
                        zoom = 0.9;
                        deg = -0.1;
                        break;
                    default:
                        point = new Vector2(65, 35);
                        zoom = 1;
                        deg = 0.23;
                        break;
                }
                var lant = layFore.CreateSprite(@"SB\2dx_131.png", OsbOrigin.TopCentre, point);
                lant.Rotate(StartTime + interval * i, StartTime + interval * i + delay, 1, deg);
                lant.Fade(StartTime + interval * i, StartTime + interval * i + delay, 0, 1);
                lant.Fade(EndTime, 1);
                lant.Scale(EndTime, zoom);
                var lantLight = layFore.CreateSprite(@"SB\2dx_132.png", OsbOrigin.TopCentre, point);
                lantLight.Rotate(StartTime + interval * i, StartTime + interval * i + delay, 1, deg);
                lantLight.Fade(StartTime + interval * i, StartTime + interval * i + delay, 0, 1);
                lantLight.Fade(EndTime, 0);
                lantLight.Scale(EndTime, zoom);
                lantLight.Additive(StartTime + 100 + interval * i, EndTime);
                lantLight.StartLoopGroup(StartTime + 100 + interval * i + Random(0, 20), 150);
                const int lightInterval = 50;
                lantLight.Color(0, lightInterval, 0.7, 0.7, 0.7, 0.3, 0.3, 0.3);
                lantLight.Color(lightInterval, lightInterval * 2, 0.3, 0.3, 0.3, 0.7, 0.7, 0.7);
                lantLight.EndGroup();
            }

            for (int i = 0; i < 6; i++)
            {
                Vector2 point;
                double zoom, deg;
                switch (i)
                {
                    case 0:
                        point = new Vector2(338, 13);
                        zoom = 0.45;
                        deg = 0;
                        break;
                    case 1:
                        point = new Vector2(380, 30);
                        zoom = 0.4;
                        deg = 0;
                        break;
                    case 2:
                        point = new Vector2(425, 41);
                        zoom = 0.62;
                        deg = 0;
                        break;
                    case 3:
                        point = new Vector2(481, 45);
                        zoom = 0.8;
                        deg = 0.06;
                        break;
                    case 4:
                        point = new Vector2(527, 42);
                        zoom = 1;
                        deg = -0.18;
                        break;
                    default:
                        point = new Vector2(602, 3);
                        zoom = 1.1;
                        deg = 0.08;
                        break;
                }

                var lant = layFore.CreateSprite(@"SB\2dx_131.png", OsbOrigin.TopCentre, point);
                lant.Rotate(StartTime + 100 + interval * i, StartTime + 100 + interval * i + delay, -1, deg);
                lant.Fade(StartTime + 100 + interval * i, StartTime + 100 + interval * i + delay, 0, 1);
                lant.Fade(EndTime, 1);
                lant.Scale(EndTime, zoom);

                var lantLight = layFore.CreateSprite(@"SB\2dx_132.png", OsbOrigin.TopCentre, point);
                lantLight.Rotate(StartTime + 100 + interval * i, StartTime + 100 + interval * i + delay, -1, deg);
                lantLight.Fade(StartTime + 100 + interval * i, StartTime + 100 + interval * i + delay, 0, 1);
                lantLight.Fade(EndTime, 0);
                lantLight.Scale(EndTime, zoom);
                lantLight.Additive(StartTime + 100 + interval * i, EndTime);
                lantLight.StartLoopGroup(StartTime + 100 + interval * i + Random(0, 20), 150);
                const int lightInterval = 50;
                lantLight.Color(0, lightInterval, 0.7, 0.7, 0.7, 0.3, 0.3, 0.3);
                lantLight.Color(lightInterval, lightInterval * 2, 0.3, 0.3, 0.3, 0.7, 0.7, 0.7);
                lantLight.EndGroup();
            }
        }
    }
}
