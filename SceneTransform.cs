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
    public class SceneTransform : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer layCover = GetLayer("Cover");

            for (int i = 0; i < 11; i++)
            {
                double x = i * 64;
                const double y = 240;
                var pattern = layCover.CreateSprite(@"SB\w2.png");
                pattern.Move(OsbEasing.None, 4434, 5097, x, y, x, y);
                pattern.ScaleVec(OsbEasing.None, 4434, 5097, 0, 1, 1, 1);
                pattern.Fade(0, 4434, 5097, 0, 1);
                pattern.Fade(0, 5097, 6423, 1, 1);
            }

            var leaf = layCover.CreateSprite(@"SB\2dx_27.png");
            leaf.Move(5097, 6423, 195, 240, 195, 240);
            var leaf2 = layCover.CreateSprite(@"SB\2dx_27.png");
            leaf2.Move(5346, 6423, 320, 240, 320, 240);
            var leaf3 = layCover.CreateSprite(@"SB\2dx_27.png");
            leaf3.Move(5595, 6423, 445, 240, 445, 240);
        }
    }
}
