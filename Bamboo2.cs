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
    public class Bamboo2 : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime = 11064;
        [Configurable]
        public int endTime = 17031;
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            var left = lay_fore.CreateSprite(@"SB\2dx_63.png");
            left.Rotate(startTime, 0.3);
            left.FlipH(startTime, startTime);
            left.Move(startTime, startTime + (11561 - 11064), 145, 330, 45, 330);
            left.Fade(startTime, startTime + (11561 - 11064), 0, 1);
            left.Scale(startTime, endTime, 0.75, 0.75);

            var right = lay_fore.CreateSprite(@"SB\2dx_78.png");
            right.Move(startTime, startTime + (11561 - 11064), 495, 330, 595, 330);
            right.Fade(startTime, startTime + (11561 - 11064), 0, 1);
            right.Scale(startTime, endTime, 0.75, 0.75);
        }
    }
}
