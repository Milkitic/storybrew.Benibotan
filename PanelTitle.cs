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
    public class PanelTitle : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");

            int x = 320, y = 240;
            var rnd = new Random();
            double rndx, rndy;

            var t = lay_fore.CreateSprite(@"SB\2dx_97.png");
            t.Move(0, 5926, 6423, x + 640, y, x, y);
            t.Fade(11064, 1);
            t.Move(0, 10567, 11064, x, y, x - 640, y);
            t.StartLoopGroup(6423, (int)((10567 - 6423) / 150d));
            for (int i = 0; i < 4; i++)
            {
                rndx = rnd.NextDouble() * 1.5;
                rndy = rnd.NextDouble() * 1.5;
                t.Move(0, i * 50, i * 50, x + rndx, y + rndy, x + rndx, y + rndy);
            }
            t.EndGroup();
        }
    }
}
