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
    public class EndCover : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            var w = lay_fore.CreateSprite(@"SB\w.png");
            w.Fade(OsbEasing.In,105539, 105871 , 0, 1);
        }
    }
}
