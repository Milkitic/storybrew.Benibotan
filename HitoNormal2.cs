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
    public class HitoNormal2 : StoryboardObjectGenerator
    {
        public int StartTime = 69738;

        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");
            var shadow = layFore.CreateSprite(@"SB\2dx_69.png", OsbOrigin.Centre, new Vector2(220, 300));
            shadow.Fade(StartTime, 0.6);
            shadow.Fade(StartTime + (71893 - 69738), StartTime + (72059 - 69738), 0.6, 0);

            var body = layFore.CreateSprite(@"SB\2dx_114.png", OsbOrigin.Centre, new Vector2(223, 285));
            body.Fade(StartTime, 1);
            body.Fade(StartTime + (71893 - 69738), StartTime + (72059 - 69738), 1, 0);

            const int animationInterval = 70, closedDelay = 100;

            var eye = layFore.CreateSprite(@"SB\2dx_70.png", OsbOrigin.Centre, new Vector2(232, 221));
            eye.Fade(StartTime, 1);
            eye.Fade(StartTime + (71396 - 69738), 0);
            eye.Fade(StartTime + (71396 - 69738) + animationInterval * 3 + closedDelay, 1);
            eye.Fade(StartTime + (71893 - 69738), StartTime + (72059 - 69738), 1, 0);

            var eye2 = layFore.CreateSprite(@"SB\2dx_71.png", OsbOrigin.Centre, new Vector2(230, 223));
            eye2.Fade(StartTime, 0);
            eye2.Fade(StartTime + (71396 - 69738), 1);
            eye2.Fade(StartTime + (71396 - 69738) + animationInterval, 0);
            eye2.Fade(StartTime + (71396 - 69738) + animationInterval * 2 + closedDelay, 1);
            eye2.Fade(StartTime + (71396 - 69738) + animationInterval * 3 + closedDelay, 0);

            var eye3 = layFore.CreateSprite(@"SB\2dx_72.png", OsbOrigin.Centre, new Vector2(229, 226));
            eye3.Fade(StartTime, 0);
            eye3.Fade(StartTime + (71396 - 69738) + animationInterval, 1);
            eye3.Fade(StartTime + (71396 - 69738) + animationInterval * 2 + closedDelay, 0);

            var mouth = layFore.CreateSprite(@"SB\2dx_38.png", OsbOrigin.Centre, new Vector2(228, 264));
            mouth.Fade(StartTime, 0.9);
            mouth.Scale(StartTime, 0.9);
            mouth.Fade(StartTime + (71893 - 69738), StartTime + (72059 - 69738), 0.9, 0);


        }
    }
}
