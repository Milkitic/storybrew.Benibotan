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
    public class StartCover : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            var w = lay_fore.CreateSprite(@"SB\w.png");
            w.Fade(OsbEasing.Out, -537, -205, 1, 0);
        }
    }
}
