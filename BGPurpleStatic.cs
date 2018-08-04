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
    public class BgPurpleStatic : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 125;
        [Configurable]
        public int EndTime = 5097;
        public override void Generate()
        {
            StoryboardLayer layBack = GetLayer("Back");
            double x, y = 240;
            for (int i = 0; i < 30; i++)
            {
                x = i * 22;
                var bg = layBack.CreateSprite(@"SB\2dx_8.png", OsbOrigin.CentreLeft);
                bg.Move(0, StartTime, EndTime, x, y, x, y);
                bg.Fade(StartTime, 1);
            }

            for (int j = -1; j < 11; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    x = i * (170 - 170 / 5) - 85;
                    y = j * (58 - 29 / 2 - 1);
                    var pattern = layBack.CreateSprite(@"SB\2dx_5.png", OsbOrigin.TopLeft);
                    pattern.Move(0, StartTime, EndTime, x, y, x, y);
                    pattern.Fade(StartTime, 0.9);
                }
            }

            var left = layBack.CreateSprite(@"SB\2dx_62.png");
            left.Move(StartTime, 600, 295);
            left.Scale(StartTime, EndTime, 1, 1);

            var right = layBack.CreateSprite(@"SB\2dx_77.png");
            right.Move(StartTime, 75, 270);
            right.FlipH(StartTime, EndTime);
            right.Scale(StartTime, 1);
        }
    }
}
