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
    public class BlackPanel : StoryboardObjectGenerator
    {
        [Configurable]
        public int EnterTime = 5926;
        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");

            const int x = 320, y = 240;

            var black = layFore.CreateSprite(@"SB\panel.jpg");
            black.Move(0, 5926, 6423, x + 640, y, x, y);
            black.Fade(11064, 1);
            black.Move(0, 10567, 11064, x, y, x - 640, y);

            var tl = layFore.CreateSprite(@"SB\2dx_30.png", OsbOrigin.TopLeft);
            tl.Move(0, 5926, 6423, x + 640, y - 2, x, y - 2);
            tl.Move(0, 10567, 11064, x, y - 2, x - 640, y - 2);
            tl.Fade(11064, 1);
            tl.FlipV(5926, 5926);
            tl.FlipH(5926, 5926);

            var tr = layFore.CreateSprite(@"SB\2dx_30.png", OsbOrigin.TopRight);
            tr.Move(0, 5926, 6423, x + 640, y - 2, x, y - 2);
            tr.Move(0, 10567, 11064, x, y - 2, x - 640, y - 2);
            tr.Fade(11064, 1);
            tr.FlipV(5926, 5926);

            var bl = layFore.CreateSprite(@"SB\2dx_30.png", OsbOrigin.BottomLeft);
            bl.Move(0, 5926, 6423, x + 640, y + 2, x, y + 2);
            bl.Move(0, 10567, 11064, x, y + 2, x - 640, y + 2);
            bl.Fade(11064, 1);
            bl.FlipH(5926, 5926);

            var br = layFore.CreateSprite(@"SB\2dx_30.png", OsbOrigin.BottomRight);
            br.Move(0, 5926, 6423, x + 640, y + 2, x, y + 2);
            br.Move(0, 10567, 11064, x, y + 2, x - 640, y + 2);
            br.Fade(11064, 1);
        }
    }
}
