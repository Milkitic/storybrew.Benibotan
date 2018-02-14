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
    public class HitoNormal : StoryboardObjectGenerator
    {
        public int startTime = 17031;

        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");

            int shakeDelay = 120;
            var shadow = lay_fore.CreateSprite(@"SB\2dx_69.png", OsbOrigin.BottomCentre, new Vector2(320, 300 + 398 / 2));
            shadow.Fade(startTime + (17155 - 17031) - 100, startTime + (17528 - 17031), 0, 0.6);
            shadow.MoveX(startTime + (17280 - 17031) - 100, startTime + (17528 - 17031), 240, 220);
            shadow.Fade(startTime + (18854 - 17031), startTime + (19020 - 17031), 0.6, 0);
            shadow.Fade(startTime + (24324 - 17031), startTime + (24655 - 17031), 0, 0.6);
            shadow.Rotate(startTime + (24987 - 17031), startTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            shadow.Rotate(startTime + (24987 - 17031) + shakeDelay, startTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);

            shadow.Fade(startTime + (27639 - 17031), 0.6);

            var body = lay_fore.CreateSprite(@"SB\2dx_114.png", OsbOrigin.BottomCentre, new Vector2(320, 285 + 398 / 2));
            body.Fade(startTime, startTime + (17280 - 17031), 0, 1);
            body.MoveX(startTime, startTime + (17280 - 17031), 280, 223);
            body.Fade(startTime + (18854 - 17031), startTime + (19020 - 17031), 1, 0);
            body.Fade(startTime + (24324 - 17031), startTime + (24655 - 17031), 0, 1);
            body.Rotate(startTime + (24987 - 17031), startTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            body.Rotate(startTime + (24987 - 17031) + shakeDelay, startTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);

            body.Fade(startTime + (27639 - 17031), 1);

            int animationInterval = 70;
            int closedDelay = 100;
            var eye = lay_fore.CreateSprite(@"SB\2dx_70.png", OsbOrigin.Centre, new Vector2(320, 221));
            eye.Fade(startTime, startTime + (17280 - 17031), 0, 1);
            eye.MoveX(startTime, startTime + (17280 - 17031), 289, 232);
            eye.Fade(startTime + (17445 - 17031), 0);
            eye.Fade(startTime + (17445 - 17031) + animationInterval * 3 + closedDelay, 1);
            eye.Fade(startTime + (18854 - 17031), startTime + (19020 - 17031), 1, 0);
            eye.Fade(startTime + (24324 - 17031), startTime + (24655 - 17031), 0, 1);
            // Shake
            eye.MoveX(startTime + (24987 - 17031), startTime + (24987 - 17031) + shakeDelay, 232, 222);
            eye.MoveX(startTime + (24987 - 17031) + shakeDelay, startTime + (24987 - 17031) + shakeDelay * 2, 222, 232);
            eye.Rotate(startTime + (24987 - 17031), startTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            eye.Rotate(startTime + (24987 - 17031) + shakeDelay, startTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);

            // Fade out
            eye.Fade(startTime + (27639 - 17031), 1);

            var eye2 = lay_fore.CreateSprite(@"SB\2dx_71.png", OsbOrigin.Centre, new Vector2(230, 223));
            eye2.Fade(startTime, 0);
            eye2.Fade(startTime + (17445 - 17031), 1);
            eye2.Fade(startTime + (17445 - 17031) + animationInterval, 0);
            eye2.Fade(startTime + (17445 - 17031) + animationInterval * 2 + closedDelay, 1);
            eye2.Fade(startTime + (17445 - 17031) + animationInterval * 3 + closedDelay, 0);
            // Shake
            eye2.MoveX(startTime + (24987 - 17031), startTime + (24987 - 17031) + shakeDelay, 230, 220);
            eye2.MoveX(startTime + (24987 - 17031) + shakeDelay, startTime + (24987 - 17031) + shakeDelay * 2, 220, 230);
            eye2.Rotate(startTime + (24987 - 17031), startTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            eye2.Rotate(startTime + (24987 - 17031) + shakeDelay, startTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);

            var eye3 = lay_fore.CreateSprite(@"SB\2dx_72.png", OsbOrigin.Centre, new Vector2(229, 226));
            eye3.Fade(startTime, 0);
            eye3.Fade(startTime + (17445 - 17031) + animationInterval, 1);
            eye3.Fade(startTime + (17445 - 17031) + animationInterval * 2 + closedDelay, 0);
            // Shake
            eye3.MoveX(startTime + (24987 - 17031), startTime + (24987 - 17031) + shakeDelay, 229, 219);
            eye3.MoveX(startTime + (24987 - 17031) + shakeDelay, startTime + (24987 - 17031) + shakeDelay * 2, 219, 229);
            eye3.Rotate(startTime + (24987 - 17031), startTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            eye3.Rotate(startTime + (24987 - 17031) + shakeDelay, startTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);

            var mouth = lay_fore.CreateSprite(@"SB\2dx_38.png", OsbOrigin.Centre, new Vector2(320, 264));
            mouth.Fade(startTime, startTime + (17280 - 17031), 0, 0.9);
            mouth.Scale(startTime, 0.9);
            mouth.MoveX(startTime, startTime + (17280 - 17031), 285, 228);
            mouth.Fade(startTime + (18854 - 17031), startTime + (19020 - 17031), 0.9, 0);
            mouth.Fade(startTime + (24324 - 17031), startTime + (24655 - 17031), 0, 1);
            // Shake
            mouth.MoveX(startTime + (24987 - 17031), startTime + (24987 - 17031) + shakeDelay, 228, 220);
            mouth.MoveX(startTime + (24987 - 17031) + shakeDelay, startTime + (24987 - 17031) + shakeDelay * 2, 220, 228);
            mouth.Rotate(startTime + (24987 - 17031), startTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            mouth.Rotate(startTime + (24987 - 17031) + shakeDelay, startTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);

            // Fade out
            mouth.Fade(startTime + (25153 - 17031), 1);

            int[] say_time = { 25070, 1 };
            int ani_interval = 60;
            for (int i = 0; i < say_time.Length - 1; i += 2)
            {
                for (int j = 0; j < say_time[i + 1]; j++)
                {
                    eye.Fade(startTime + (say_time[i] - 17031) + j * ani_interval * 4, 0);
                    eye2.Fade(startTime + (say_time[i] - 17031) + j * ani_interval * 4, 1);
                    eye2.Fade(startTime + (say_time[i] - 17031) + ani_interval + j * ani_interval * 4, 0);
                    eye3.Fade(startTime + (say_time[i] - 17031) + ani_interval + j * ani_interval * 4, 1);
                    eye3.Fade(startTime + (say_time[i] - 17031) + ani_interval * 3 + j * ani_interval * 4, 0);
                    eye2.Fade(startTime + (say_time[i] - 17031) + ani_interval * 3 + j * ani_interval * 4, 1);
                    eye2.Fade(startTime + (say_time[i] - 17031) + ani_interval * 4 + j * ani_interval * 4, 0);
                    eye.Fade(startTime + (say_time[i] - 17031) + ani_interval * 4 + j * ani_interval * 4, 1);
                }
            }
        }
    }
}
