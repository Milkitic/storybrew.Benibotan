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
        public int StartTimeOverride = 0;
        public override void Generate()
        {
            const int count = 17;
            const double length = 46.8;
            const double deg = Math.PI / 4;

            int startTime = 36921;
            if (StartTimeOverride != 0) startTime = StartTimeOverride - (37584 - 36921);
            StoryboardLayer layCover = GetLayer("Fore");
            for (int i = 0; i < count; i++)
            {
                const double vecLength = length / 850d;
                if (StartTimeOverride == 0)
                {
                    var cover = layCover.CreateSprite(@"SB\w.png", OsbOrigin.CentreLeft);
                    cover.Rotate(startTime, deg);
                    //cover.Color(36921, 0, 0, 0);
                    cover.Move(startTime, i * length * Math.Sin(deg), i * length * Math.Cos(deg));
                    cover.ScaleVec(startTime, startTime + (37418 - 36921), 0, 2, vecLength, 2);
                    cover.Fade(startTime + (37584 - 36921), 1);
                }
                var cover2 = layCover.CreateSprite(@"SB\w.png", OsbOrigin.CentreRight);
                cover2.Rotate(startTime + (37584 - 36921), deg);
                //cover2.Color(37584, 0, 0, 0);
                cover2.Move(startTime + (37584 - 36921), (i + 1) * length * Math.Sin(deg), (i + 1) * length * Math.Cos(deg));
                cover2.ScaleVec(startTime + (37584 - 36921), startTime + (38081 - 36921), vecLength, 2, 0, 2);
            }

        }
    }
}
