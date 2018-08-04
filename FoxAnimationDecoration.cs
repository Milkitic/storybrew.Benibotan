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
    public class FoxAnimationDecoration : StoryboardObjectGenerator
    {
        [Configurable] public bool IsFirst = true;

        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");

            if (!IsFirst) return;

            Vector2[] pos =
            {
                new Vector2(75, 240),
                new Vector2(160, 280),
                new Vector2(255, 215),
                new Vector2(405, 250),
                new Vector2(545, 240)
            };
            double[] scale = { 0.9, 0.6, 1, 1, 0.7 };
            string[] name = { "2dx_68.png", "2dx_127.png", "2dx_126.png", "2dx_127.png", "2dx_126.png" };
            bool[] rot = { true, false, true, false, true };
            const int startTime = 59131, endTime = 69738;
            const int fadeTime = startTime + (6921 - 6423);

            for (int i = 0; i < name.Length; i++)
            {
                var flower = layFore.CreateSprite(System.IO.Path.Combine("SB", name[i]));
                flower.Move(startTime, pos[i]);
                flower.Scale(startTime, scale[i]);
                flower.Fade(startTime, fadeTime, 0, 1);
                flower.Rotate(startTime, endTime, 0, 25 * (rot[i] ? 1 : -1));
            }
        }
    }
}
