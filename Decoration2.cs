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
    public class Decoration2 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            var dec1 = lay_fore.CreateSprite(@"SB\2dx_28.png", OsbOrigin.TopLeft);
            dec1.Move(788, 5097, 0, 8, 0, 8);
            dec1.Fade(4434, 5097, 0, 1);
            dec1.Fade(77363, 0);
            dec1.Fade(80843, 108523, 1, 1);

            var dec2 = lay_fore.CreateSprite(@"SB\2dx_28.png", OsbOrigin.TopRight);
            dec2.Move(788, 5097, 640, 8, 640, 8);
            dec2.FlipH(788, 788);
            dec2.Fade(4434, 5097, 0, 1);
            dec2.Fade(77363, 0);
            dec2.Fade(80843, 108523, 1, 1);

            var dec3 = lay_fore.CreateSprite(@"SB\2dx_28.png", OsbOrigin.BottomLeft);
            dec3.Move(788, 5097, 0, 472, 0, 472);
            dec3.Fade(4434, 5097, 0, 1);
            dec3.Fade(77363, 0);
            dec3.Fade(80843, 108523, 1, 1);

            var dec4 = lay_fore.CreateSprite(@"SB\2dx_28.png", OsbOrigin.BottomRight);
            dec4.Move(788, 5097, 640, 472, 640, 472);
            dec4.FlipH(788, 788);
            dec4.Fade(4434, 5097, 0, 1);
            dec4.Fade(77363, 0);
            dec4.Fade(80843, 108523, 1, 1);

            var fox1 = lay_fore.CreateSprite(@"SB\2dx_29.png");
            fox1.Move(788, 5097, 320, 40, 320, 40);
            fox1.Fade(4434, 5097, 0, 1);
            fox1.Fade(77363, 0);
            fox1.Fade(80843, 108523, 1, 1);

            var fox2 = lay_fore.CreateSprite(@"SB\2dx_29.png");
            fox2.Move(788, 5097, 320, 440, 320, 440);
            fox2.Fade(4434, 5097, 0, 1);
            fox2.Fade(77363, 0);
            fox2.Fade(80843, 108523, 1, 1);
        }
    }
}
