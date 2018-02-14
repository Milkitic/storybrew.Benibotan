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
    public class WordPanel : StoryboardObjectGenerator
    {
        public int startTime = 17031;
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            //var panel = lay_fore.CreateSprite(@"SB\test.png", OsbOrigin.TopLeft, new Vector2(392, 155));
            //panel.ScaleVec(startTime, 92, 200);
            //panel.Fade(startTime + (18606 - 17031), 1);
            for (int i = 0; i < 4; i++)
            {
                Vector2 pos;
                double rot, sca;
                int interval = 80;
                if (i == 0)
                {
                    pos = new Vector2(437, 240);
                    rot = 0.7;
                    sca = 1.75;
                }
                else if (i == 1)
                {
                    pos = new Vector2(435, 325);
                    rot = 0.2;
                    sca = 1.35;
                }
                else if (i == 2)
                {
                    pos = new Vector2(410, 200);
                    rot = 0.1;
                    sca = 1.5;
                }
                else
                {
                    pos = new Vector2(465, 175);
                    rot = -0.3;
                    sca = 1.5;
                }
                var flower = lay_fore.CreateSprite(@"SB\flower_panel.png", OsbOrigin.Centre, pos);
                flower.Scale(startTime + interval * i, startTime + (17528 - 17031), 0, sca);
                flower.Rotate(startTime, rot);
                flower.Scale(startTime + (18191 - 17031) - interval * i, startTime + (18606 - 17031) - interval * i, sca, 0);
            }

            string[] word = { @"SB\2dx_43.png", @"SB\2dx_44.png", @"SB\2dx_45.png", @"SB\2dx_46.png", @"SB\2dx_47.png", };
            int word_start_time = startTime + (17280 - 17031);
            int word_interval = 100;
            for (int i = 0; i < word.Length; i++)
            {
                var word_sprite = lay_fore.CreateSprite(word[i], OsbOrigin.Centre, new Vector2(437, 186 + 34 * i));
                word_sprite.Scale(word_start_time + i * word_interval, word_start_time + 200 + i * word_interval, 1.2, 1);
                word_sprite.Fade(word_start_time + i * word_interval, word_start_time + 200 + i * word_interval, 0, 1);
                word_sprite.Fade(startTime + (18191 - 17031), startTime + (18191 - 17031) + 100, 1, 0);
            }

            var cover = lay_fore.CreateSprite(@"SB\panel_cover.png", OsbOrigin.TopLeft);
            cover.Move(startTime, 330.6, 99.4);
            cover.Scale(startTime, 0.6244725738396624);
            cover.Fade(startTime + (18606 - 17031), 1);

        }
    }
}
