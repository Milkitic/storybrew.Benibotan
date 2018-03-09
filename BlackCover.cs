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
        [Configurable]
        public int startTimeOverride = 0;
        public override void Generate()
        {
            int count = 17;
            double length = 46.8;
            double deg = Math.PI / 4;

            int start_time = 36921;
            if (startTimeOverride != 0) start_time = startTimeOverride - (37584 - 36921);
            StoryboardLayer lay_cover = GetLayer("Fore");
            for (int i = 0; i < count; i++)
            {
                double vec_length = length / 850d;
                if (startTimeOverride == 0)
                {
                    var cover = lay_cover.CreateSprite(@"SB\w.png", OsbOrigin.CentreLeft);
                    cover.Rotate(start_time, deg);
                    //cover.Color(36921, 0, 0, 0);
                    cover.Move(start_time, i * length * Math.Sin(deg), i * length * Math.Cos(deg));
                    cover.ScaleVec(start_time, start_time + (37418 - 36921), 0, 2, vec_length, 2);
                    cover.Fade(start_time + (37584 - 36921), 1);
                }
                var cover2 = lay_cover.CreateSprite(@"SB\w.png", OsbOrigin.CentreRight);
                cover2.Rotate(start_time + (37584 - 36921), deg);
                //cover2.Color(37584, 0, 0, 0);
                cover2.Move(start_time + (37584 - 36921), (i + 1) * length * Math.Sin(deg), (i + 1) * length * Math.Cos(deg));
                cover2.ScaleVec(start_time + (37584 - 36921), start_time + (38081 - 36921), vec_length, 2, 0, 2);
            }

        }
    }
}
