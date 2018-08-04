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
        public int StartTime = 17031;
        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");
            //var panel = lay_fore.CreateSprite(@"SB\test.png", OsbOrigin.TopLeft, new Vector2(392, 155));
            //panel.ScaleVec(startTime, 92, 200);
            //panel.Fade(startTime + (18606 - 17031), 1);
            for (int i = 0; i < 4; i++)
            {
                Vector2 pos;
                double rot, sca;
                const int interval = 80;
                switch (i)
                {
                    case 0:
                        pos = new Vector2(437, 240);
                        rot = 0.7;
                        sca = 1.75;
                        break;
                    case 1:
                        pos = new Vector2(435, 325);
                        rot = 0.2;
                        sca = 1.35;
                        break;
                    case 2:
                        pos = new Vector2(410, 200);
                        rot = 0.1;
                        sca = 1.5;
                        break;
                    default:
                        pos = new Vector2(465, 175);
                        rot = -0.3;
                        sca = 1.5;
                        break;
                }
                var flower = layFore.CreateSprite(@"SB\flower_panel.png", OsbOrigin.Centre, pos);
                flower.Scale(StartTime + interval * i, StartTime + (17528 - 17031), 0, sca);
                flower.Rotate(StartTime, rot);
                flower.Scale(StartTime + (18191 - 17031) - interval * i, StartTime + (18606 - 17031) - interval * i, sca, 0);
            }

            string[] word = { @"SB\2dx_43.png", @"SB\2dx_44.png", @"SB\2dx_45.png", @"SB\2dx_46.png", @"SB\2dx_47.png", };
            int wordStartTime = StartTime + (17280 - 17031);
            const int wordInterval = 100;
            for (int i = 0; i < word.Length; i++)
            {
                var wordSprite = layFore.CreateSprite(word[i], OsbOrigin.Centre, new Vector2(437, 186 + 34 * i));
                wordSprite.Scale(wordStartTime + i * wordInterval, wordStartTime + 200 + i * wordInterval, 1.2, 1);
                wordSprite.Fade(wordStartTime + i * wordInterval, wordStartTime + 200 + i * wordInterval, 0, 1);
                wordSprite.Fade(StartTime + (18191 - 17031), StartTime + (18191 - 17031) + 100, 1, 0);
            }

            var cover = layFore.CreateSprite(@"SB\panel_cover.png", OsbOrigin.TopLeft);
            cover.Move(StartTime, 330.6, 99.4);
            cover.Scale(StartTime, 0.6244725738396624);
            cover.Fade(StartTime + (18606 - 17031), 1);

        }
    }
}
