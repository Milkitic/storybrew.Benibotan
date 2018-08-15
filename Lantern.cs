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
    public class Lantern : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            var lantern1 = lay_fore.CreateSprite(@"SB\2dx_91.png", OsbOrigin.Centre, new Vector2(505, -135));
            lantern1.MoveY(788, -135);
            lantern1.MoveY(1682, 2031, -135, 40);
            lantern1.MoveY(2031, 2114, 40, 20);
            lantern1.MoveY(2114, 5097, 20, -20);

            var lantern2 = lay_fore.CreateSprite(@"SB\2dx_91.png", OsbOrigin.Centre, new Vector2(135, -135));
            lantern2.MoveY(788, -135);
            lantern2.MoveY(1948, 2445, -135, 220);
            lantern2.MoveY(2445, 2528, 220, 200);
            lantern2.MoveY(2528, 5097, 200, 170);

        }
    }
}
