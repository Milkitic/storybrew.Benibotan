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
        public int StartTime = 17031;

        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");

            // Fox's Shadow
            const int shakeDelay = 120;
            var shadow = layFore.CreateSprite(@"SB\2dx_69.png", OsbOrigin.BottomCentre, new Vector2(320, 300 + 398 / 2));
            shadow.Fade(StartTime + (17155 - 17031) - 100, StartTime + (17528 - 17031), 0, 0.6);
            shadow.MoveX(StartTime + (17280 - 17031) - 100, StartTime + (17528 - 17031), 240, 220);
            shadow.Fade(StartTime + (18854 - 17031), StartTime + (19020 - 17031), 0.6, 0);
            shadow.Fade(StartTime + (24324 - 17031), StartTime + (24655 - 17031), 0, 0.6);
            shadow.Rotate(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            shadow.Rotate(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);

            shadow.Fade(StartTime + (27639 - 17031), 0.6);

            // Fox's body
            var body = layFore.CreateSprite(@"SB\2dx_114.png", OsbOrigin.BottomCentre, new Vector2(320, 285 + 398 / 2));
            body.Fade(StartTime, StartTime + (17280 - 17031), 0, 1);
            body.MoveX(StartTime, StartTime + (17280 - 17031), 280, 223);
            body.Fade(StartTime + (18854 - 17031), StartTime + (19020 - 17031), 1, 0);
            body.Fade(StartTime + (24324 - 17031), StartTime + (24655 - 17031), 0, 1);
            body.Rotate(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            body.Rotate(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);

            body.Fade(StartTime + (27639 - 17031), 1);

            // Arrow
            var arrow = layFore.CreateSprite(@"SB\2dx_31.png");
            const double arrowDeg = 25, arrowX = 300, arrowY = 125, length = 600, length2 = 5;
            const double arrowR = arrowDeg / 180 * Math.PI;
            arrow.Move(StartTime + (24738 - 17031), StartTime + (24987 - 17031), arrowX + length * Math.Cos(arrowR),
                       arrowY - length * Math.Sin(arrowR), arrowX, arrowY);
            arrow.Rotate(StartTime + (24987 - 17031), -(arrowDeg - 20) / 180 * Math.PI);
            arrow.Fade(StartTime + (24987 - 17031) + 100, 1);
            arrow.Move(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay, arrowX, arrowY,
                       arrowX - length2 * Math.Cos(arrowR), arrowY + length2 * Math.Sin(arrowR));
            arrow.Rotate(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay,
                      -(arrowDeg - 20) / 180 * Math.PI, -(arrowDeg - 20 + 3) / 180 * Math.PI);
            arrow.Move(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2,
                       arrowX - length2 * Math.Cos(arrowR), arrowY + length2 * Math.Sin(arrowR), arrowX + 10, arrowY - 9);
            arrow.Rotate(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2,
                      -(arrowDeg - 20 + 3) / 180 * Math.PI, -(arrowDeg - 20 + 10) / 180 * Math.PI);
            arrow.Fade(StartTime + (27639 - 17031), 1);


            const int animationInterval = 70, closedDelay = 100;

            // Code here need to be optimized
            // Like eye.Blink(timing1, timing2, ...);
            var eye = layFore.CreateSprite(@"SB\2dx_70.png", OsbOrigin.Centre, new Vector2(320, 221));
            eye.Fade(StartTime, StartTime + (17280 - 17031), 0, 1);
            eye.MoveX(StartTime, StartTime + (17280 - 17031), 289, 232);
            eye.Fade(StartTime + (17445 - 17031), 0);
            eye.Fade(StartTime + (17445 - 17031) + animationInterval * 3 + closedDelay, 1);
            eye.Fade(StartTime + (18854 - 17031), StartTime + (19020 - 17031), 1, 0);
            eye.Fade(StartTime + (24324 - 17031), StartTime + (24655 - 17031), 0, 1);
            // Shake
            eye.MoveX(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay, 232, 222);
            eye.MoveX(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2, 222, 232);
            eye.Rotate(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            eye.Rotate(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);

            // Fade out
            eye.Fade(StartTime + (27639 - 17031), 1);

            var eye2 = layFore.CreateSprite(@"SB\2dx_71.png", OsbOrigin.Centre, new Vector2(230, 223));
            eye2.Fade(StartTime, 0);
            eye2.Fade(StartTime + (17445 - 17031), 1);
            eye2.Fade(StartTime + (17445 - 17031) + animationInterval, 0);
            eye2.Fade(StartTime + (17445 - 17031) + animationInterval * 2 + closedDelay, 1);
            eye2.Fade(StartTime + (17445 - 17031) + animationInterval * 3 + closedDelay, 0);
            // Shake
            eye2.MoveX(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay, 230, 220);
            eye2.MoveX(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2, 220, 230);
            eye2.Rotate(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            eye2.Rotate(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);

            var eye3 = layFore.CreateSprite(@"SB\2dx_72.png", OsbOrigin.Centre, new Vector2(229, 226));
            eye3.Fade(StartTime, 0);
            eye3.Fade(StartTime + (17445 - 17031) + animationInterval, 1);
            eye3.Fade(StartTime + (17445 - 17031) + animationInterval * 2 + closedDelay, 0);
            // Shake
            eye3.MoveX(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay, 229, 219);
            eye3.MoveX(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2, 219, 229);
            eye3.Rotate(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            eye3.Rotate(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);

            var mouth = layFore.CreateSprite(@"SB\2dx_38.png", OsbOrigin.Centre, new Vector2(320, 264));
            mouth.Fade(StartTime, StartTime + (17280 - 17031), 0, 0.9);
            mouth.Scale(StartTime, 0.9);
            mouth.MoveX(StartTime, StartTime + (17280 - 17031), 285, 228);
            mouth.Fade(StartTime + (18854 - 17031), StartTime + (19020 - 17031), 0.9, 0);
            mouth.Fade(StartTime + (24324 - 17031), StartTime + (24655 - 17031), 0, 1);
            // Shake
            mouth.MoveX(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay, 228, 220);
            mouth.MoveX(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2, 220, 228);
            mouth.Rotate(StartTime + (24987 - 17031), StartTime + (24987 - 17031) + shakeDelay, 0, -0.04);
            mouth.Rotate(StartTime + (24987 - 17031) + shakeDelay, StartTime + (24987 - 17031) + shakeDelay * 2, -0.04, 0);
            // Fade out
            mouth.Fade(StartTime + (25153 - 17031), 1);

            int[] blinkTime = { 25070, 1 };
            const int aniInterval = 60;
            for (int i = 0; i < blinkTime.Length - 1; i += 2)
            {
                for (int j = 0; j < blinkTime[i + 1]; j++)
                {
                    eye.Fade(StartTime + (blinkTime[i] - 17031) + j * aniInterval * 4, 0);
                    eye2.Fade(StartTime + (blinkTime[i] - 17031) + j * aniInterval * 4, 1);
                    eye2.Fade(StartTime + (blinkTime[i] - 17031) + aniInterval + j * aniInterval * 4, 0);
                    eye3.Fade(StartTime + (blinkTime[i] - 17031) + aniInterval + j * aniInterval * 4, 1);
                    eye3.Fade(StartTime + (blinkTime[i] - 17031) + aniInterval * 3 + j * aniInterval * 4, 0);
                    eye2.Fade(StartTime + (blinkTime[i] - 17031) + aniInterval * 3 + j * aniInterval * 4, 1);
                    eye2.Fade(StartTime + (blinkTime[i] - 17031) + aniInterval * 4 + j * aniInterval * 4, 0);
                    eye.Fade(StartTime + (blinkTime[i] - 17031) + aniInterval * 4 + j * aniInterval * 4, 1);
                }
            }
            // Fox's big mouth
            var mouth2 = layFore.CreateSprite(@"SB\2dx_39.png", OsbOrigin.Centre, new Vector2(228, 264));
            mouth2.Fade(StartTime + (25236 - 17031), StartTime + (27639 - 17031), 1, 1);
            mouth2.ScaleVec(StartTime + (25236 - 17031), StartTime + (25236 - 17031) + 150, 0.9, 0.5, 0.9, 0.9);

            // Blusher on face
            var blusher = layFore.CreateSprite(@"SB\2dx_88.png", OsbOrigin.Centre, new Vector2(219, 240));
            blusher.Fade(StartTime + (25236 - 17031) - 250, StartTime + (25236 - 17031) + 250, 0, 1);
            blusher.Fade(StartTime + (27639 - 17031), 1);

            // Hearts in eyes
            var heart = layFore.CreateSprite(@"SB\2dx_37.png", OsbOrigin.Centre, new Vector2(203, 218));
            heart.Fade(StartTime + (25236 - 17031) + 250, StartTime + (25236 - 17031) + 250 + 600, 0, 1);
            heart.Scale(StartTime + (25236 - 17031) + 250, StartTime + (25236 - 17031) + 250 + 600, 0, 1);
            heart.Fade(StartTime + (27639 - 17031), 1);
            var heart2 = layFore.CreateSprite(@"SB\2dx_37.png", OsbOrigin.Centre, new Vector2(255, 231));
            heart2.Fade(StartTime + (25236 - 17031) + 250, StartTime + (25236 - 17031) + 250 + 600, 0, 1);
            heart2.Scale(StartTime + (25236 - 17031) + 250, StartTime + (25236 - 17031) + 250 + 600, 0, 0.95);
            heart2.Fade(StartTime + (27639 - 17031), 1);
            heart2.Rotate(StartTime + (25236 - 17031) + 250, 0.1);

            // Big heart
            var heart3 = layFore.CreateSprite(@"SB\2dx_89.png");
            heart3.Move(StartTime + (25401 - 17031), StartTime + (25981 - 17031), 380, 230, 410, 220);
            heart3.Rotate(StartTime + (25401 - 17031), StartTime + (25981 - 17031), 0.33, 0.5);
            heart3.Fade(StartTime + (25401 - 17031), StartTime + (25981 - 17031), 1, 0);

            // Leaves
            int[] timings = { 27142, 27307 };
            for (int i = 0; i < timings.Length; i++)
            {
                var leaf = layFore.CreateSprite(@"SB\2dx_27.png");
                leaf.Move(StartTime + (timings[i] - 17031), StartTime + (27639 - 17031), 400 + i * 110, 255, 400 + i * 110, 255);
            }
        }
    }
}
