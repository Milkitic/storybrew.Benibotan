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
    public class WordPanel3 : StoryboardObjectGenerator
    {
        public int startTime = 72722;
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

            string[] word = { @"SB\2dx_56.png", @"SB\2dx_57.png" };
            int word_start_time = startTime + (20678 - 20015);
            int word_interval = 100;
            for (int i = 0; i < word.Length; i++)
            {
                var word_sprite = lay_fore.CreateSprite(word[i], OsbOrigin.Centre, new Vector2(165, 226 + 34 * i));
                word_sprite.Scale(word_start_time + i * word_interval, word_start_time + 200 + i * word_interval, 1.2, 1);
                word_sprite.Fade(word_start_time + i * word_interval, word_start_time + 200 + i * word_interval, 0, 1);
                word_sprite.Fade(startTime + (21340 - 20015), startTime + (21340 - 20015) + 100, 1, 0);
            }
            string[] word2 = { @"SB\2dx_45.png", @"SB\2dx_53.png", @"SB\2dx_57.png", @"SB\2dx_58.png", @"SB\2dx_53.png",
                               @"SB\2dx_59.png" };
            word_start_time = startTime + (21506 - 20015);
            word_interval = 100;
            for (int i = 0; i < word2.Length; i++)
            {
                var word_sprite = lay_fore.CreateSprite(word2[i], OsbOrigin.Centre, new Vector2(165, 163 + 30 * i));
                word_sprite.Scale(word_start_time + i * word_interval, word_start_time + 200 + i * word_interval, 1.2, 1);
                word_sprite.Fade(word_start_time + i * word_interval, word_start_time + 200 + i * word_interval, 0, 1);
                word_sprite.Fade(startTime + (22832 - 20015), startTime + (22832 - 20015) + 100, 1, 0);
            }
            var cover = lay_fore.CreateSprite(@"SB\panel_cover3.png", OsbOrigin.TopLeft);
            cover.Fade(startTime + (20180 - 20015) - 500, startTime + (20180 - 20015), 0, 1);
            cover.Move(startTime + (20180 - 20015), 0.3, 103.8);
            cover.Scale(startTime + (20180 - 20015), 0.6244725738396624);
            cover.Fade(startTime + (22998 + 415 - 20015), startTime + (22998 + 415 - 20015) + 500, 1, 0);

            int startT = 71893;
            var mouth = lay_fore.CreateSprite(@"SB\2dx_34.png", OsbOrigin.Centre, new Vector2(283, 246));
            mouth.Fade(startT + (18854 - 18854), startT + (19020 - 18854), 0, 1);
            var mouth2 = lay_fore.CreateSprite(@"SB\2dx_35.png", OsbOrigin.Centre, new Vector2(283, 246));
            mouth2.Fade(startT, 0);
            var mouth3 = lay_fore.CreateSprite(@"SB\2dx_36.png", OsbOrigin.Centre, new Vector2(284, 246));
            int[] say_time = { 73219, 2, 74131, 3 };
            int smile_time = 75954;
            int ani_interval = 80;
            for (int i = 0; i < say_time.Length - 1; i += 2)
            {
                for (int j = 0; j < say_time[i + 1]; j++)
                {
                    mouth.Fade(startT + (say_time[i] - 71893) + j * ani_interval * 4, 0);
                    mouth2.Fade(startT + (say_time[i] - 71893) + j * ani_interval * 4, 1);
                    mouth2.ScaleVec(startT + (say_time[i] - 71893) + j * ani_interval * 4, 1, 0.5);
                    mouth2.ScaleVec(startT + (say_time[i] - 71893) + ani_interval + j * ani_interval * 4, 1, 1);
                    mouth2.ScaleVec(startT + (say_time[i] - 71893) + ani_interval * 2 + j * ani_interval * 4, 1, 0.5);
                    mouth2.Fade(startT + (say_time[i] - 71893) + ani_interval * 3 + j * ani_interval * 4, 0);
                    mouth.Fade(startT + (say_time[i] - 71893) + ani_interval * 3 + j * ani_interval * 4, 1);
                }
            }

            mouth.Fade(startT + (smile_time - 71893), 0);
            mouth2.Fade(startT + (smile_time - 71893), 1);
            mouth2.ScaleVec(startT + (smile_time - 71893), 1, 0.5);
            mouth2.ScaleVec(startT + (smile_time - 71893) + ani_interval, 1, 1);
            mouth2.Fade(startT + (smile_time - 71893) + ani_interval * 2, 0);
            mouth3.Fade(startT + (smile_time - 71893) + ani_interval * 2, 1);
            mouth3.Fade(startT + (24324 - 18854), 1);
        }
    }
}
