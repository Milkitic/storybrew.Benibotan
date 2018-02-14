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
    public class BGOrange : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime = 125;
        [Configurable]
        public int endTime = 5097;
        public override void Generate()
        {
            StoryboardLayer lay_back = GetLayer("Back");
            double x;
            for (int i = 0; i < 30; i++)
            {
                x = i * 22;
                OsbSprite orange = lay_back.CreateSprite(@"SB\2dx_7.png", OsbOrigin.CentreLeft);
                orange.Move(OsbEasing.None, startTime, endTime, x, 240, x, 240);
            }
            double y;
            for (int j = -1; j < 9; j++)
            {
                for (int i = 0; i < (j % 2 == 0 ? 10 : 11); i++)
                {
                    x = i * (68 - 3.5);
                    if (j % 2 != 0) x -= 32;
                    y = j * (78 * 0.75 - 5);
                    var Pattern = lay_back.CreateSprite(@"SB\2dx_76.png", OsbOrigin.TopLeft);
                    Pattern.Move(OsbEasing.None, startTime, endTime, x, y, x, y);
                    Pattern.Fade(startTime, 0.3);
                }
            }
        }
    }
}
