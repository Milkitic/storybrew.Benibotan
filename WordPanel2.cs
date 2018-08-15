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
    public class WordPanel2 : StoryboardObjectGenerator
    {
        public int startTime = 20015;
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            //var panel = lay_fore.CreateSprite(@"SB\test.png", OsbOrigin.TopLeft, new Vector2(116, 114));
            //panel.ScaleVec(startTime, 97, 252);
            //panel.Fade(startTime + (18606 - 17031), 1);
            for (int i = 0; i < 4; i++)
            {
                int offsetX = -270, offsetY = 0;
                Vector2 pos;
                double rot, sca;
                int interval = 80;
                if (i == 0)
                {
                    pos = new Vector2(437 + offsetX, 240 + offsetY);
                    rot = 0.7;
                    sca = 1.75;
                }
                else if (i == 1)
                {
                    pos = new Vector2(439 + offsetX, 325 + offsetY);
                    rot = 0.2;
                    sca = 1.35;
                }
                else if (i == 2)
                {
                    pos = new Vector2(415 + offsetX, 193 + offsetY);
                    rot = 0;
                    sca = 1.8;
                }
                else
                {
                    pos = new Vector2(465 + offsetX, 180 + offsetY);
                    rot = 0;
                    sca = 1.5;
                }
                var flower = lay_fore.CreateSprite(@"SB\flower_panel.png", OsbOrigin.Centre, pos);
                flower.Scale(startTime + interval * i, startTime + (17528 - 17031), 0, sca);
                flower.Rotate(startTime, rot);
                flower.Scale(startTime + (22998 - 20015) - interval * i, startTime + (22998 + 415 - 20015) - interval * i, sca, 0);
            }

            string[] word = { @"SB\2dx_48.png", @"SB\2dx_49.png" };
            int word_start_time = startTime + (20678 - 20015);
            int word_interval = 100;
            for (int i = 0; i < word.Length; i++)
            {
                var word_sprite = lay_fore.CreateSprite(word[i], OsbOrigin.Centre, new Vector2(165, 226 + 34 * i));
                word_sprite.Scale(word_start_time + i * word_interval, word_start_time + 200 + i * word_interval, 1.2, 1);
                word_sprite.Fade(word_start_time + i * word_interval, word_start_time + 200 + i * word_interval, 0, 1);
                word_sprite.Fade(startTime + (21340 - 20015), startTime + (21340 - 20015) + 100, 1, 0);
            }
            string[] word2 = { @"SB\2dx_50.png", @"SB\2dx_51.png", @"SB\2dx_52.png", @"SB\2dx_45.png", @"SB\2dx_52.png",
                               @"SB\2dx_53.png", @"SB\2dx_54.png" };
            word_start_time = startTime + (21506 - 20015);
            word_interval = 100;
            for (int i = 0; i < word2.Length; i++)
            {
                var word_sprite = lay_fore.CreateSprite(word2[i], OsbOrigin.Centre, new Vector2(165, 150 + 30 * i));
                word_sprite.Scale(word_start_time + i * word_interval, word_start_time + 200 + i * word_interval, 1.2, 1);
                word_sprite.Fade(word_start_time + i * word_interval, word_start_time + 200 + i * word_interval, 0, 1);
                word_sprite.Fade(startTime + (22832 - 20015), startTime + (22832 - 20015) + 100, 1, 0);
            }
            var cover = lay_fore.CreateSprite(@"SB\panel_cover2.png", OsbOrigin.TopLeft);
            cover.Move(startTime + (20180 - 20015), 0.3, 103.8);
            cover.Scale(startTime + (20180 - 20015), 0.6244725738396624);
            cover.Fade(startTime + (22998 + 415 - 20015), 1);

        }
    }
}
