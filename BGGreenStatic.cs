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
    public class BGGreenStatic : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime = 92280;
        [Configurable]
        public int endTime = 105871;
        public override void Generate()
        {
            StoryboardLayer lay_back = GetLayer("Back");
            double x;
            for (int i = 0; i < 29; i++)
            {
                x = i * 22;
                var BG = lay_back.CreateSprite(@"SB\2dx_6.png", OsbOrigin.CentreLeft);
                BG.Move(startTime, x, 240);
                BG.Fade(endTime, 1);
            }
            double y;
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    x = i * (78 - 3) - 3;
                    y = j * (78 - 3) - 3;
                    var Pattern = lay_back.CreateSprite(@"SB\2dx_98.png", OsbOrigin.TopLeft);
                    Pattern.Move(startTime, x, y);
                    Pattern.Fade(endTime, 0.9);
                }
            }
        }
    }
}
