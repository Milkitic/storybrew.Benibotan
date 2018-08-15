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
    public class Flowers1 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            var flower1 = lay_fore.CreateSprite(@"SB\2dx_126.png");
            flower1.Move(788, 560, 220);
            flower1.Scale(788, 0.7);
            flower1.Rotate(788, 5097, 0, 13);

            var flower2 = lay_fore.CreateSprite(@"SB\2dx_126.png");
            flower2.Move(788, 155, 100);
            flower2.Rotate(788, 5097, 0, 13);

            var flower3 = lay_fore.CreateSprite(@"SB\2dx_68.png");
            flower3.Move(788, 135, 195);
            flower3.Rotate(788, 5097, 0, 14);

            var flower4 = lay_fore.CreateSprite(@"SB\2dx_127.png");
            flower4.Move(788, 540, 320);
            flower4.Rotate(788, 5097, 0, -13);

            var flower5 = lay_fore.CreateSprite(@"SB\2dx_127.png");
            flower5.Move(788, 215, 180);
            flower5.Scale(788, 0.7);
            flower5.Rotate(788, 5097, 0, -13);

        }
    }
}
