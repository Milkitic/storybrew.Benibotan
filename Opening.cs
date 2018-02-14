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
    public class Opening : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime = -537;
        public override void Generate()
        {
            StoryboardLayer lay_cover = GetLayer("Cover");

            var door1 = lay_cover.CreateSprite(@"SB\2dx_87.png", OsbOrigin.CentreRight);
            door1.Fade(startTime, 1);
            door1.Scale(startTime + (537 - 205), startTime + (537 + 2297), 1, 1.8);
            door1.MoveX(0, startTime + (537 + 788), startTime + (537 + 1948), 320, 0);

            var door2 = lay_cover.CreateSprite(@"SB\2dx_87.png", OsbOrigin.CentreLeft);
            door2.Fade(startTime, 1);
            door2.Scale(startTime + (537 - 205), startTime + (537 + 2297), 1, 1.8);
            door2.MoveX(0, startTime + (537 + 788), startTime + (537 + 1948), 320, 640);


            var cover = lay_cover.CreateSprite(@"SB\2dx_109.png", OsbOrigin.BottomRight);
            cover.Fade(startTime, 1);
            cover.Scale(startTime + (537 - 205), startTime + (537 + 2297), 1, 1.8);

            var cover2 = lay_cover.CreateSprite(@"SB\2dx_109.png", OsbOrigin.BottomLeft);
            cover2.Fade(startTime, 1);
            cover2.Scale(startTime + (537 - 205), startTime + (537 + 2297), 1, 1.8);
            cover2.FlipH(startTime, startTime);

            var cover3 = lay_cover.CreateSprite(@"SB\2dx_109.png", OsbOrigin.TopRight);
            cover3.Fade(startTime, 1);
            cover3.Scale(startTime + (537 - 205), startTime + (537 + 2297), 1, 1.8);
            cover3.FlipV(startTime, startTime);

            var cover4 = lay_cover.CreateSprite(@"SB\2dx_109.png", OsbOrigin.TopLeft);
            cover4.Fade(startTime, 1);
            cover4.Scale(startTime + (537 - 205), startTime + (537 + 2297), 1, 1.8);
            cover4.FlipH(startTime, startTime);
            cover4.FlipV(startTime, startTime); 
        }
    }
}
