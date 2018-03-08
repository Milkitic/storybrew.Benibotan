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
    public class BlackCover : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            int count = 17;
            double length = 46.8;
            double deg = Math.PI / 4;
            StoryboardLayer lay_cover = GetLayer("Fore");
            for (int i = 0; i < count; i++)
            {
                double vec_length = length / 850d;
                var cover = lay_cover.CreateSprite(@"SB\w.png", OsbOrigin.CentreLeft);
                cover.Rotate(36921, deg);
                //cover.Color(36921, 0, 0, 0);
                cover.Move(36921, i * length * Math.Sin(deg), i * length * Math.Cos(deg));
                cover.ScaleVec(36921, 37418, 0, 2, vec_length, 2);
                cover.Fade(37584, 1);
                var cover2 = lay_cover.CreateSprite(@"SB\w.png", OsbOrigin.CentreRight);
                cover2.Rotate(37584, deg);
                //cover2.Color(37584, 0, 0, 0);
                cover2.Move(37584, (i + 1) * length * Math.Sin(deg), (i + 1) * length * Math.Cos(deg));
                cover2.ScaleVec(37584, 37998, vec_length, 2, 0, 2);
            }

        }
    }
}
