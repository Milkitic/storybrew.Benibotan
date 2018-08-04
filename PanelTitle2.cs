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
    public class PanelTitle2 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");

            const int x = 320, y = 240;
            var rnd = new Random();

            var t = layFore.CreateSprite(@"SB\2dx_60.png");
            t.Move(0, 10567, 11064, x + 640, y, x, y);
            t.Move(0, 14048, 14545, x, y, x - 640, y);
            t.StartLoopGroup(11064, (int)((14048 - 11064) / 150d));
            for (int i = 0; i < 4; i++)
            {
                double rndx = rnd.NextDouble() * 1.5;
                double rndy = rnd.NextDouble() * 1.5;
                t.Move(0, i * 50, i * 50, x + rndx, y + rndy, x + rndx, y + rndy);
            }
            t.EndGroup();
        }
    }
}
