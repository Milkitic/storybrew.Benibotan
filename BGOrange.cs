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
    public class BgOrange : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 125;
        [Configurable]
        public int EndTime = 5097;
        public override void Generate()
        {
            StoryboardLayer layBack = GetLayer("Back");
            double x;
            for (int i = 0; i < 30; i++)
            {
                x = i * 22;
                OsbSprite orange = layBack.CreateSprite(@"SB\2dx_7.png", OsbOrigin.CentreLeft);
                orange.Move(OsbEasing.None, StartTime, EndTime, x, 240, x, 240);
            }
            double y;
            for (int j = -1; j < 9; j++)
            {
                for (int i = 0; i < (j % 2 == 0 ? 10 : 11); i++)
                {
                    x = i * (68 - 3.5);
                    if (j % 2 != 0) x -= 32;
                    y = j * (78 * 0.75 - 5);
                    var pattern = layBack.CreateSprite(@"SB\2dx_76.png", OsbOrigin.TopLeft);
                    pattern.Move(OsbEasing.None, StartTime, EndTime, x, y, x, y);
                    pattern.Fade(StartTime, 0.3);
                }
            }
        }
    }
}
