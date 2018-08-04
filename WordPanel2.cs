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
        public int StartTime = 20015;
        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");
            //var panel = lay_fore.CreateSprite(@"SB\test.png", OsbOrigin.TopLeft, new Vector2(116, 114));
            //panel.ScaleVec(startTime, 97, 252);
            //panel.Fade(startTime + (18606 - 17031), 1);
            for (int i = 0; i < 4; i++)
            {
                const int offsetX = -270, offsetY = 0;
                Vector2 pos;
                double rot, sca;
                int interval = 80;
                switch (i)
                {
                    case 0:
                        pos = new Vector2(437 + offsetX, 240 + offsetY);
                        rot = 0.7;
                        sca = 1.75;
                        break;
                    case 1:
                        pos = new Vector2(439 + offsetX, 325 + offsetY);
                        rot = 0.2;
                        sca = 1.35;
                        break;
                    case 2:
                        pos = new Vector2(415 + offsetX, 193 + offsetY);
                        rot = 0;
                        sca = 1.8;
                        break;
                    default:
                        pos = new Vector2(465 + offsetX, 180 + offsetY);
                        rot = 0;
                        sca = 1.5;
                        break;
                }
                var flower = layFore.CreateSprite(@"SB\flower_panel.png", OsbOrigin.Centre, pos);
                flower.Scale(StartTime + interval * i, StartTime + (17528 - 17031), 0, sca);
                flower.Rotate(StartTime, rot);
                flower.Scale(StartTime + (22998 - 20015) - interval * i, StartTime + (22998 + 415 - 20015) - interval * i, sca, 0);
            }

            string[] word = { @"SB\2dx_48.png", @"SB\2dx_49.png" };
            int wordStartTime = StartTime + (20678 - 20015);
            int wordInterval = 100;
            for (int i = 0; i < word.Length; i++)
            {
                var wordSprite = layFore.CreateSprite(word[i], OsbOrigin.Centre, new Vector2(165, 226 + 34 * i));
                wordSprite.Scale(wordStartTime + i * wordInterval, wordStartTime + 200 + i * wordInterval, 1.2, 1);
                wordSprite.Fade(wordStartTime + i * wordInterval, wordStartTime + 200 + i * wordInterval, 0, 1);
                wordSprite.Fade(StartTime + (21340 - 20015), StartTime + (21340 - 20015) + 100, 1, 0);
            }
            string[] word2 = { @"SB\2dx_50.png", @"SB\2dx_51.png", @"SB\2dx_52.png", @"SB\2dx_45.png", @"SB\2dx_52.png",
                               @"SB\2dx_53.png", @"SB\2dx_54.png" };
            wordStartTime = StartTime + (21506 - 20015);
            wordInterval = 100;
            for (int i = 0; i < word2.Length; i++)
            {
                var wordSprite = layFore.CreateSprite(word2[i], OsbOrigin.Centre, new Vector2(165, 150 + 30 * i));
                wordSprite.Scale(wordStartTime + i * wordInterval, wordStartTime + 200 + i * wordInterval, 1.2, 1);
                wordSprite.Fade(wordStartTime + i * wordInterval, wordStartTime + 200 + i * wordInterval, 0, 1);
                wordSprite.Fade(StartTime + (22832 - 20015), StartTime + (22832 - 20015) + 100, 1, 0);
            }
            var cover = layFore.CreateSprite(@"SB\panel_cover2.png", OsbOrigin.TopLeft);
            cover.Move(StartTime + (20180 - 20015), 0.3, 103.8);
            cover.Scale(StartTime + (20180 - 20015), 0.6244725738396624);
            cover.Fade(StartTime + (22998 + 415 - 20015), 1);

        }
    }
}
