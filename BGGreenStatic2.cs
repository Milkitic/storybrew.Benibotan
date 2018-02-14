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
    public class BGGreenStatic2 : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime = 27639;
        [Configurable]
        public int endTime = 37584;
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


            var left = lay_back.CreateSprite(@"SB\2dx_63.png");
            left.Move(startTime, 83, 293);
            left.Fade(startTime, 0.8);
            left.FlipH(startTime, endTime);
            left.Scale(startTime, 1);

            var right = lay_back.CreateSprite(@"SB\2dx_78.png");
            right.Move(startTime, 563, 280);
            right.Fade(startTime, 0.8);
            right.Scale(startTime, endTime, 0.88, 0.88);

        }
    }
}
