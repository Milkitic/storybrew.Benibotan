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
    public class NonBg : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer layNone = GetLayer("None");
            var bg = layNone.CreateSprite("BG.jpg");
            bg.Fade(0, 0);
        }
    }
}
