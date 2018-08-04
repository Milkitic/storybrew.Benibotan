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
    public class Kiai1 : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 37584;
        [Configurable]
        public int StartOffset = 0;
        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");

            var flower1 = layFore.CreateSprite(@"SB\2dx_128.png");
            flower1.Move(StartTime + StartOffset, 560, 220);
            flower1.Scale(StartTime + StartOffset, 0.7);
            flower1.Rotate(StartTime + StartOffset, StartTime + (43550 - 37584), 0, 13);

            var flower2 = layFore.CreateSprite(@"SB\2dx_128.png");
            flower2.Move(StartTime + StartOffset, 155, 100);
            flower2.Rotate(StartTime + StartOffset, StartTime + (43550 - 37584), 0, 13);

            var flower3 = layFore.CreateSprite(@"SB\2dx_68.png");
            flower3.Move(StartTime + StartOffset, 135, 195);
            flower3.Rotate(StartTime + StartOffset, StartTime + (43550 - 37584), 0, 14);

            var flower4 = layFore.CreateSprite(@"SB\2dx_129.png");
            flower4.Move(StartTime + StartOffset, 540, 320);
            flower4.Rotate(StartTime + StartOffset, StartTime + (43550 - 37584), 0, -13);

            var flower5 = layFore.CreateSprite(@"SB\2dx_129.png");
            flower5.Move(StartTime + StartOffset, 215, 180);
            flower5.Scale(StartTime + StartOffset, 0.7);
            flower5.Rotate(StartTime + StartOffset, StartTime + (43550 - 37584), 0, -13);

            var shadow = layFore.CreateSprite(@"SB\2dx_75.png", OsbOrigin.Centre, new Vector2(325, 240));
            shadow.Fade(StartTime + StartOffset, 0.6);
            shadow.Scale(StartTime + StartOffset, 0.95);
            shadow.MoveY(StartTime + StartOffset, StartTime + (43550 - 37584), 322, 252);

            var hito = layFore.CreateSprite(@"SB\2dx_74.png");
            hito.Scale(StartTime + StartOffset, 0.95);
            hito.MoveY(StartTime + StartOffset, StartTime + (43550 - 37584), 310, 240);

            var eye1 = layFore.CreateSprite(@"SB\2dx_116.png");
            eye1.Fade(StartTime + StartOffset, 1);
            eye1.Scale(StartTime + StartOffset, 0.95);
            eye1.Move(StartTime + StartOffset, StartTime + (43550 - 37584), 353, 169, 353, 99);
            eye1.Fade(StartTime + (1534 - 125), 0);
            eye1.Fade(StartTime + (1782 - 125), 1);
            eye1.Fade(StartTime + (3357 - 125), 0);
            eye1.Fade(StartTime + (3606 - 125), 1);

            var eye2 = layFore.CreateSprite(@"SB\2dx_92.png");
            eye2.Fade(StartTime + StartOffset, 0);
            eye2.Scale(StartTime + StartOffset, 0.95);
            eye2.Move(StartTime + StartOffset, StartTime + (5097 - 125), 353, 169, 353, 109);
            eye2.Fade(StartTime + (1534 - 125), 1);
            eye2.Fade(StartTime + (1617 - 125), 0);
            eye2.Fade(StartTime + (1700 - 125), 1);
            eye2.Fade(StartTime + (1782 - 125), 0);
            eye2.Fade(StartTime + (3357 - 125), 1);
            eye2.Fade(StartTime + (3440 - 125), 0);
            eye2.Fade(StartTime + (3523 - 125), 1);
            eye2.Fade(StartTime + (3606 - 125), 0);

            var eye3 = layFore.CreateSprite(@"SB\2dx_93.png");
            eye3.Fade(StartTime + StartOffset, 0);
            eye3.Scale(StartTime + StartOffset, 0.95);
            eye3.Move(StartTime + StartOffset, StartTime + (5097 - 125), 353, 169, 353, 109);
            eye3.Fade(StartTime + (1617 - 125), 1);
            eye3.Fade(StartTime + (1700 - 125), 0);
            eye3.Fade(StartTime + (3357 - 125), 1);
            eye3.Fade(StartTime + (3523 - 125), 0);

            int newStartTime = StartTime + (43550 - 37584), newTime = 48523 - 43550;
            var flower21 = layFore.CreateSprite(@"SB\2dx_126.png");
            flower21.Move(newStartTime, 250, 320);
            flower21.Scale(newStartTime, 0.7);
            flower21.Rotate(newStartTime, newStartTime + newTime, 0, 13);

            var flower22 = layFore.CreateSprite(@"SB\2dx_126.png");
            flower22.Move(newStartTime, 205, 130);
            flower22.Rotate(newStartTime, newStartTime + newTime, 0, 13);

            var flower23 = layFore.CreateSprite(@"SB\2dx_68.png");
            flower23.Move(newStartTime, 190, 230);
            flower23.Rotate(newStartTime, newStartTime + newTime, 0, 14);

            var flower24 = layFore.CreateSprite(@"SB\2dx_127.png");
            flower24.Move(newStartTime, 100, 340);
            flower24.Scale(newStartTime, 0.9);
            flower24.Rotate(newStartTime, newStartTime + newTime, 0, -13);

            var flower25 = layFore.CreateSprite(@"SB\2dx_127.png");
            flower25.Move(newStartTime, 285, 210);
            flower25.Scale(newStartTime, 0.7);
            flower25.Rotate(newStartTime, newStartTime + newTime, 0, -13);

            var shadow2 = layFore.CreateSprite(@"SB\2dx_2.png", OsbOrigin.Centre, new Vector2(435, 240));
            shadow2.MoveY(newStartTime, newStartTime + newTime, 295, 375);
            shadow2.Fade(newStartTime, 0.6);

            var hito2 = layFore.CreateSprite(@"SB\2dx_1.png", OsbOrigin.Centre, new Vector2(415, 240));
            hito2.MoveY(newStartTime, newStartTime + newTime, 270, 395);

            var eye21 = layFore.CreateSprite(@"SB\2dx_61.png", OsbOrigin.Centre, new Vector2(360, 240));
            eye21.Fade(newStartTime, 1);
            eye21.MoveY(newStartTime, newStartTime + newTime, 270 - 217, 395 - 217);
            eye21.Fade(newStartTime + (46202 - 43550), 0);

            var eye22 = layFore.CreateSprite(@"SB\2dx_3.png", OsbOrigin.Centre, new Vector2(360, 240));
            eye22.Fade(newStartTime, 0);
            eye22.MoveY(newStartTime, newStartTime + newTime, 270 - 217, 395 - 217);
            eye22.Fade(newStartTime + (46202 - 43550), 1);
            eye22.Fade(newStartTime + (46202 - 43550 + 100), 0);

            var eye23 = layFore.CreateSprite(@"SB\2dx_4.png", OsbOrigin.Centre, new Vector2(360, 240));
            eye23.Fade(newStartTime, 0);
            eye23.MoveY(newStartTime, newStartTime + newTime, 270 - 217, 395 - 217);
            eye23.Fade(newStartTime + (46202 - 43550 + 100), 1);


            var lantern1 = layFore.CreateSprite(@"SB\2dx_91.png", OsbOrigin.Centre, new Vector2(507, -135));
            lantern1.MoveY(StartTime + StartOffset, newStartTime + newTime, 10, 10);

            var lantern2 = layFore.CreateSprite(@"SB\2dx_91.png", OsbOrigin.Centre, new Vector2(126, -135));
            lantern2.MoveY(StartTime + StartOffset, newStartTime + newTime, 220, 220);

        }
    }
}
