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
    public class BgGreenStatic : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 92280;
        [Configurable]
        public int EndTime = 105871;
        public override void Generate()
        {
            StoryboardLayer layBack = GetLayer("Back");
            double x;
            for (int i = 0; i < 29; i++)
            {
                x = i * 22;
                var bg = layBack.CreateSprite(@"SB\2dx_6.png", OsbOrigin.CentreLeft);
                bg.Move(StartTime, x, 240);
                bg.Fade(EndTime, 1);
            }
            double y;
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    x = i * (78 - 3) - 3;
                    y = j * (78 - 3) - 3;
                    var pattern = layBack.CreateSprite(@"SB\2dx_98.png", OsbOrigin.TopLeft);
                    pattern.Move(StartTime, x, y);
                    pattern.Fade(EndTime, 0.9);
                }
            }
        }
    }
}
