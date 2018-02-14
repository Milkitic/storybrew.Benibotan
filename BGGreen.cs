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
    public class BGGreen : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer lay_back = GetLayer("Back");
            double x;
            for (int i = 0; i < 29; i++)
            {
                x = i * 22;
                var BG = lay_back.CreateSprite(@"SB\2dx_6.png", OsbOrigin.CentreLeft);
                BG.Move(0, 10567, 11064, x + 640, 240, x, 240);
                BG.Fade(17031, 1);
            }
            double y;
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    x = i * (78 - 3) - 3;
                    y = j * (78 - 3) - 3;
                    var Pattern = lay_back.CreateSprite(@"SB\2dx_98.png", OsbOrigin.TopLeft);
                    Pattern.Move(0, 10567, 11064, x + 640, y, x, y);
                    Pattern.Fade(17031, 0.9);
                }
            }
        }
    }
}
