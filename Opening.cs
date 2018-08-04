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
        public int StartTime = -537;
        [Configurable]
        public int FadeInTime = 0;
        public override void Generate()
        {
            StoryboardLayer layCover = GetLayer("Cover");

            var door1 = layCover.CreateSprite(@"SB\2dx_87.png", OsbOrigin.CentreRight);
            door1.Fade(StartTime, 1);
            door1.Scale(StartTime + (537 - 205), StartTime + (537 + 2297) - FadeInTime / 2d, 1, 1.8);
            door1.MoveX(0, StartTime + (537 + 788) - FadeInTime / 2d, StartTime + (537 + 1948) - FadeInTime / 2d, 320, 0);

            var door2 = layCover.CreateSprite(@"SB\2dx_87.png", OsbOrigin.CentreLeft);
            door2.Fade(StartTime, 1);
            door2.Scale(StartTime + (537 - 205), StartTime + (537 + 2297) - FadeInTime / 2d, 1, 1.8);
            door2.MoveX(0, StartTime + (537 + 788) - FadeInTime / 2d, StartTime + (537 + 1948) - FadeInTime / 2d, 320, 640);
            
            var cover = layCover.CreateSprite(@"SB\2dx_109.png", OsbOrigin.BottomRight);
            cover.Fade(StartTime, 1);
            cover.Scale(StartTime + (537 - 205), StartTime + (537 + 2297) - FadeInTime / 2d, 1, 1.8);

            var cover2 = layCover.CreateSprite(@"SB\2dx_109.png", OsbOrigin.BottomLeft);
            cover2.Fade(StartTime, 1);
            cover2.Scale(StartTime + (537 - 205), StartTime + (537 + 2297) - FadeInTime / 2d, 1, 1.8);
            cover2.FlipH(StartTime - FadeInTime, StartTime - FadeInTime);

            var cover3 = layCover.CreateSprite(@"SB\2dx_109.png", OsbOrigin.TopRight);
            cover3.Fade(StartTime, 1);
            cover3.Scale(StartTime + (537 - 205), StartTime + (537 + 2297) - FadeInTime / 2d, 1, 1.8);
            cover3.FlipV(StartTime - FadeInTime, StartTime - FadeInTime);

            var cover4 = layCover.CreateSprite(@"SB\2dx_109.png", OsbOrigin.TopLeft);
            cover4.Fade(StartTime, 1);
            cover4.Scale(StartTime + (537 - 205), StartTime + (537 + 2297) - FadeInTime / 2d, 1, 1.8);
            cover4.FlipH(StartTime - FadeInTime, StartTime - FadeInTime);
            cover4.FlipV(StartTime - FadeInTime, StartTime - FadeInTime);

            if (FadeInTime > 0)
            {
                door1.Fade(StartTime - FadeInTime, StartTime, 0, 1);
                door2.Fade(StartTime - FadeInTime, StartTime, 0, 1);
                cover.Fade(StartTime - FadeInTime, StartTime, 0, 1);
                cover2.Fade(StartTime - FadeInTime, StartTime, 0, 1);
                cover3.Fade(StartTime - FadeInTime, StartTime, 0, 1);
                cover4.Fade(StartTime - FadeInTime, StartTime, 0, 1);
            }
        }
    }
}
