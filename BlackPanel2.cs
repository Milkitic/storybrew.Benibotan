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
    public class BlackPanel2 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");

            int x = 320, y = 240;

            var black = lay_fore.CreateSprite(@"SB\panel.jpg");
            black.Move(0, 10567, 11064, x + 640, y, x, y);
            black.Fade(17031, 1);
            black.Move(0, 14048, 14545, x, y, x - 640, y);

             var TL = lay_fore.CreateSprite(@"SB\2dx_30.png", OsbOrigin.TopLeft);
            TL.Move(0, 10567, 11064, x + 640, y - 2, x, y - 2);
            TL.Move(0, 14048, 14545, x, y - 2, x - 640, y - 2);
            TL.FlipV(10567, 10567);
            TL.FlipH(10567, 10567);

            var TR = lay_fore.CreateSprite(@"SB\2dx_30.png", OsbOrigin.TopRight);
            TR.Move(0, 10567, 11064, x + 640, y - 2, x, y - 2);
            TR.Move(0, 14048, 14545, x, y - 2, x - 640, y - 2);
            TR.FlipV(10567, 10567);

            var BL = lay_fore.CreateSprite(@"SB\2dx_30.png", OsbOrigin.BottomLeft);
            BL.Move(0, 10567, 11064, x + 640, y + 2, x, y + 2);
            BL.Move(0, 14048, 14545, x, y + 2, x - 640, y + 2);
            BL.FlipH(10567, 10567);

            var BR = lay_fore.CreateSprite(@"SB\2dx_30.png", OsbOrigin.BottomRight);
            BR.Move(0, 10567, 11064, x + 640, y + 2, x, y + 2);
            BR.Move(0, 14048, 14545, x, y + 2, x - 640, y + 2); 
        }
    }
}
