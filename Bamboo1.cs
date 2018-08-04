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
    public class Bamboo1 : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 6423;
        [Configurable]
        public int EndTime = 11064;
        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");
            var left = layFore.CreateSprite(@"SB\2dx_62.png");
            left.Rotate(StartTime, 0.3);
            left.FlipH(StartTime, StartTime);
            left.Move(StartTime, StartTime + (6921 - 6423), 145, 330, 45, 330);
            left.Fade(StartTime, StartTime + (6921 - 6423), 0, 1);
            left.Scale(StartTime, EndTime, 0.75, 0.75);

            var right = layFore.CreateSprite(@"SB\2dx_77.png");
            right.Move(StartTime, StartTime + (6921 - 6423), 495, 330, 595, 330);
            right.Fade(StartTime, StartTime + (6921 - 6423), 0, 1);
            right.Scale(StartTime, EndTime, 0.75, 0.75);
        }
    }
}
