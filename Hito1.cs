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
        public int StartTime = 125;
        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");
            var shadow = layFore.CreateSprite(@"SB\2dx_75.png");
            shadow.Fade(StartTime, 0.5);
            shadow.Scale(StartTime, 0.95);
            shadow.MoveY(StartTime, StartTime + (5097 - 125), 307, 247);

            var hito = layFore.CreateSprite(@"SB\2dx_74.png");
            hito.Scale(StartTime, 0.95);
            hito.MoveY(StartTime, StartTime + (5097 - 125), 300, 240);

            var eye1 = layFore.CreateSprite(@"SB\2dx_116.png");
            eye1.Fade(StartTime, 1);
            eye1.Scale(StartTime, 0.95);
            eye1.Move(StartTime, StartTime + (5097 - 125), 353, 159, 353, 99);
            eye1.Fade(StartTime + (1534 - 125), 0);
            eye1.Fade(StartTime + (1782 - 125), 1);
            eye1.Fade(StartTime + (3357 - 125), 0);
            eye1.Fade(StartTime + (3606 - 125), 1);

            var eye2 = layFore.CreateSprite(@"SB\2dx_92.png");
            eye2.Fade(StartTime, 0);
            eye2.Scale(StartTime, 0.95);
            eye2.Move(StartTime, StartTime + (5097 - 125), 353, 159, 353, 99);
            eye2.Fade(StartTime + (1534 - 125), 1);
            eye2.Fade(StartTime + (1617 - 125), 0);
            eye2.Fade(StartTime + (1700 - 125), 1);
            eye2.Fade(StartTime + (1782 - 125), 0);
            eye2.Fade(StartTime + (3357 - 125), 1);
            eye2.Fade(StartTime + (3440 - 125), 0);
            eye2.Fade(StartTime + (3523 - 125), 1);
            eye2.Fade(StartTime + (3606 - 125), 0);

            var eye3 = layFore.CreateSprite(@"SB\2dx_93.png");
            eye3.Fade(StartTime, 0);
            eye3.Scale(StartTime, 0.95);
            eye3.Move(StartTime, StartTime + (5097 - 125), 353, 159, 353, 99);
            eye3.Fade(StartTime + (1617 - 125), 1);
            eye3.Fade(StartTime + (1700 - 125), 0);
            eye3.Fade(StartTime + (3357 - 125), 1);
            eye3.Fade(StartTime + (3523 - 125), 0);
        }
    }
}
