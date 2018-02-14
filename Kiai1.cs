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
        public int startTime = 37584;
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");

            var flower1 = lay_fore.CreateSprite(@"SB\2dx_128.png");
            flower1.Move(startTime, 560, 220);
            flower1.Scale(startTime, 0.7);
            flower1.Rotate(startTime, startTime + (43550 - 37584), 0, 13);

            var flower2 = lay_fore.CreateSprite(@"SB\2dx_128.png");
            flower2.Move(startTime, 155, 100);
            flower2.Rotate(startTime, startTime + (43550 - 37584), 0, 13);

            var flower3 = lay_fore.CreateSprite(@"SB\2dx_68.png");
            flower3.Move(startTime, 135, 195);
            flower3.Rotate(startTime, startTime + (43550 - 37584), 0, 14);

            var flower4 = lay_fore.CreateSprite(@"SB\2dx_129.png");
            flower4.Move(startTime, 540, 320);
            flower4.Rotate(startTime, startTime + (43550 - 37584), 0, -13);

            var flower5 = lay_fore.CreateSprite(@"SB\2dx_129.png");
            flower5.Move(startTime, 215, 180);
            flower5.Scale(startTime, 0.7);
            flower5.Rotate(startTime, startTime + (43550 - 37584), 0, -13);

            var shadow = lay_fore.CreateSprite(@"SB\2dx_75.png", OsbOrigin.Centre, new Vector2(325, 240));
            shadow.Fade(startTime, 0.6);
            shadow.Scale(startTime, 0.95);
            shadow.MoveY(startTime, startTime + (43550 - 37584), 322, 252);

            var hito = lay_fore.CreateSprite(@"SB\2dx_74.png");
            hito.Scale(startTime, 0.95);
            hito.MoveY(startTime, startTime + (43550 - 37584), 310, 240);

            var eye1 = lay_fore.CreateSprite(@"SB\2dx_116.png");
            eye1.Fade(startTime, 1);
            eye1.Scale(startTime, 0.95);
            eye1.Move(startTime, startTime + (43550 - 37584), 353, 169, 353, 99);
            eye1.Fade(startTime + (1534 - 125), 0);
            eye1.Fade(startTime + (1782 - 125), 1);
            eye1.Fade(startTime + (3357 - 125), 0);
            eye1.Fade(startTime + (3606 - 125), 1);

            var eye2 = lay_fore.CreateSprite(@"SB\2dx_92.png");
            eye2.Fade(startTime, 0);
            eye2.Scale(startTime, 0.95);
            eye2.Move(startTime, startTime + (5097 - 125), 353, 169, 353, 109);
            eye2.Fade(startTime + (1534 - 125), 1);
            eye2.Fade(startTime + (1617 - 125), 0);
            eye2.Fade(startTime + (1700 - 125), 1);
            eye2.Fade(startTime + (1782 - 125), 0);
            eye2.Fade(startTime + (3357 - 125), 1);
            eye2.Fade(startTime + (3440 - 125), 0);
            eye2.Fade(startTime + (3523 - 125), 1);
            eye2.Fade(startTime + (3606 - 125), 0);

            var eye3 = lay_fore.CreateSprite(@"SB\2dx_93.png");
            eye3.Fade(startTime, 0);
            eye3.Scale(startTime, 0.95);
            eye3.Move(startTime, startTime + (5097 - 125), 353, 169, 353, 109);
            eye3.Fade(startTime + (1617 - 125), 1);
            eye3.Fade(startTime + (1700 - 125), 0);
            eye3.Fade(startTime + (3357 - 125), 1);
            eye3.Fade(startTime + (3523 - 125), 0);

            int newStartTime = startTime + (43550 - 37584), newTime = 48523 - 43550;
            var flower2_1 = lay_fore.CreateSprite(@"SB\2dx_126.png");
            flower2_1.Move(newStartTime, 250, 320);
            flower2_1.Scale(newStartTime, 0.7);
            flower2_1.Rotate(newStartTime, newStartTime + newTime, 0, 13);

            var flower2_2 = lay_fore.CreateSprite(@"SB\2dx_126.png");
            flower2_2.Move(newStartTime, 205, 130);
            flower2_2.Rotate(newStartTime, newStartTime + newTime, 0, 13);

            var flower2_3 = lay_fore.CreateSprite(@"SB\2dx_68.png");
            flower2_3.Move(newStartTime, 190, 230);
            flower2_3.Rotate(newStartTime, newStartTime + newTime, 0, 14);

            var flower2_4 = lay_fore.CreateSprite(@"SB\2dx_127.png");
            flower2_4.Move(newStartTime, 100, 340);
            flower2_4.Scale(newStartTime, 0.9);
            flower2_4.Rotate(newStartTime, newStartTime + newTime, 0, -13);

            var flower2_5 = lay_fore.CreateSprite(@"SB\2dx_127.png");
            flower2_5.Move(newStartTime, 285, 210);
            flower2_5.Scale(newStartTime, 0.7);
            flower2_5.Rotate(newStartTime, newStartTime + newTime, 0, -13);

            var shadow2 = lay_fore.CreateSprite(@"SB\2dx_2.png", OsbOrigin.Centre, new Vector2(435, 240));
            shadow2.MoveY(newStartTime, newStartTime + newTime, 295, 375);
            shadow2.Fade(newStartTime, 0.6);

            var hito2 = lay_fore.CreateSprite(@"SB\2dx_1.png", OsbOrigin.Centre, new Vector2(415, 240));
            hito2.MoveY(newStartTime, newStartTime + newTime, 270, 395);

            var eye2_1 = lay_fore.CreateSprite(@"SB\2dx_61.png", OsbOrigin.Centre, new Vector2(360, 240));
            eye2_1.Fade(newStartTime, 1);
            eye2_1.MoveY(newStartTime, newStartTime + newTime, 270 - 217, 395 - 217);
            eye2_1.Fade(newStartTime + (46202 - 43550), 0);

            var eye2_2 = lay_fore.CreateSprite(@"SB\2dx_3.png", OsbOrigin.Centre, new Vector2(360, 240));
            eye2_2.Fade(newStartTime, 0);
            eye2_2.MoveY(newStartTime, newStartTime + newTime, 270 - 217, 395 - 217);
            eye2_2.Fade(newStartTime + (46202 - 43550), 1);
            eye2_2.Fade(newStartTime + (46202 - 43550 + 100), 0);

            var eye2_3 = lay_fore.CreateSprite(@"SB\2dx_4.png", OsbOrigin.Centre, new Vector2(360, 240));
            eye2_3.Fade(newStartTime, 0);
            eye2_3.MoveY(newStartTime, newStartTime + newTime, 270 - 217, 395 - 217);
            eye2_3.Fade(newStartTime + (46202 - 43550 + 100), 1);


            var lantern1 = lay_fore.CreateSprite(@"SB\2dx_91.png", OsbOrigin.Centre, new Vector2(507, -135));
            lantern1.MoveY(startTime, newStartTime + newTime, 10, 10);

            var lantern2 = lay_fore.CreateSprite(@"SB\2dx_91.png", OsbOrigin.Centre, new Vector2(126, -135));
            lantern2.MoveY(startTime, newStartTime + newTime, 220, 220);

        }
    }
}
