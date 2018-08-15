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
    public class FoxAnimationDecoration2 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");

            Vector2[] pos;
            double[] scale;
            string[] name;
            bool[] rot;
            int start_time, end_time;

            pos = new Vector2[] { new Vector2(150, 240),
                                    new Vector2(255, 260),
                                    new Vector2(255, 170),
                                    new Vector2(385, 250),
                                    new Vector2(475, 190) };
            scale = new double[] { 0.7, 0.95, 1, 1, 0.7 };
            name = new string[] { "2dx_79.png", "2dx_68.png", "2dx_128.png", "2dx_79.png", "2dx_128.png" };
            rot = new bool[] { false, true, true, false, true };
            start_time = 92777;
            int fade_time = start_time + (6921 - 6423);
            end_time = 102805;
            const int delay = 200;
            for (int i = 0; i < name.Length; i++)
            {
                var flower = lay_fore.CreateSprite(System.IO.Path.Combine("SB", name[i]));
                flower.Move(start_time, pos[i]);
                flower.Scale(start_time, scale[i]);
                flower.Fade(start_time, fade_time, 0, 1);
                flower.Rotate(start_time, end_time + delay, 0, 25 * (rot[i] == true ? 1 : -1));
                flower.Scale(end_time, end_time + delay, scale[i], 0);
            }

            const int trueEndT = 105871;
            name = new string[] { "2dx_110.png", "2dx_111.png", "2dx_112.png" };
            const int aniDelay = 50;
            for (int i = 0; i < name.Length; i++)
            {
                var path = System.IO.Path.Combine("SB", name[i]);
                var word = lay_fore.CreateSprite(path, OsbOrigin.Centre, new Vector2(320 + (i - 1) * 130, 240));
                word.Scale(end_time + i * aniDelay, end_time + 200 + i * aniDelay, 0, 1.1);
                word.Scale(end_time + 200 + i * aniDelay, end_time + 300 + i * aniDelay, 1.1, 1);
                word.Fade(trueEndT, 1);
            }
        }
    }
}
