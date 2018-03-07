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
        [Configurable]
        public bool isFirst = true;
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");

            Vector2[] pos;
            double[] scale;
            string[] name;
            bool[] rot;
            int start_time, end_time;
            if (isFirst)
            {
                pos = new Vector2[] { new Vector2(75, 240),
                                    new Vector2(160, 280),
                                    new Vector2(255, 215),
                                    new Vector2(405, 250),
                                    new Vector2(545, 240) };
                scale = new double[] { 0.9, 0.6, 1, 1, 0.7 };
                name = new string[] { "2dx_68.png", "2dx_127.png", "2dx_126.png", "2dx_127.png", "2dx_126.png" };
                rot = new bool[] { true, false, true, false, true };
                start_time = 59131;
                int fade_time = start_time + (6921 - 6423);
                end_time = 69738;
                for (int i = 0; i < name.Length; i++)
                {
                    var flower = lay_fore.CreateSprite(System.IO.Path.Combine("SB", name[i]));
                    flower.Move(start_time, pos[i]);
                    flower.Scale(start_time, scale[i]);
                    flower.Fade(start_time, fade_time, 0, 1);
                    flower.Rotate(start_time, end_time, 0, 25 * (rot[i] == true ? 1 : -1));
                }
            }
        }
    }
}
