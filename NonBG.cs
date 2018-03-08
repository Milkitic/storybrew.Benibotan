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
    public class NonBG : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer lay_none = GetLayer("None");
            var bg = lay_none.CreateSprite("BG.jpg");
            bg.Fade(0, 0);
        }
    }
}
