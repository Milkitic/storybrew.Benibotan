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
    public class Hito1 : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime = 125;
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            var shadow = lay_fore.CreateSprite(@"SB\2dx_75.png");
            shadow.Fade(startTime, 0.5);
            shadow.Scale(startTime, 0.95);
            shadow.MoveY(startTime, startTime + (5097 - 125), 307, 247);

            var hito = lay_fore.CreateSprite(@"SB\2dx_74.png");
            hito.Scale(startTime, 0.95);
            hito.MoveY(startTime, startTime + (5097 - 125), 300, 240);

            var eye1 = lay_fore.CreateSprite(@"SB\2dx_116.png");
            eye1.Fade(startTime, 1);
            eye1.Scale(startTime, 0.95);
            eye1.Move(startTime, startTime + (5097 - 125), 353, 159, 353, 99);
            eye1.Fade(startTime + (1534 - 125), 0);
            eye1.Fade(startTime + (1782 - 125), 1);
            eye1.Fade(startTime + (3357 - 125), 0);
            eye1.Fade(startTime + (3606 - 125), 1);

            var eye2 = lay_fore.CreateSprite(@"SB\2dx_92.png");
            eye2.Fade(startTime, 0);
            eye2.Scale(startTime, 0.95);
            eye2.Move(startTime, startTime + (5097 - 125), 353, 159, 353, 99);
            eye2.Fade(startTime + (1534 - 125), 1);
            eye2.Fade(startTime + (1617 - 125), 0);
            eye2.Fade(startTime + (1700 - 125), 1);
            eye2.Fade(startTime + (1782 - 125), 0);
            eye2.Fade(startTime + (3357 - 125), 1);
            eye2.Fade(startTime + (3440 - 125), 0);
            eye2.Fade(startTime + (3523 - 125), 1);
            eye2.Fade(startTime + (3606 - 125), 0);

            var eye3 = lay_fore.CreateSprite(@"SB\2dx_93.png");
            eye3.Fade(startTime, 0);
            eye3.Scale(startTime, 0.95);
            eye3.Move(startTime, startTime + (5097 - 125), 353, 159, 353, 99);
            eye3.Fade(startTime + (1617 - 125), 1);
            eye3.Fade(startTime + (1700 - 125), 0);
            eye3.Fade(startTime + (3357 - 125), 1);
            eye3.Fade(startTime + (3523 - 125), 0);
        }
    }
}
