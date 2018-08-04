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
    public class CoverScene : StoryboardObjectGenerator
    {
        public int StartTime = 18854;
        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");
            var panelBack = layFore.CreateSprite(@"SB\panel_back.png");
            panelBack.Fade(StartTime + (18854 - 18854), StartTime + (19020 - 18854), 0, 1);
            panelBack.Fade(StartTime + (24324 - 18854), StartTime + (24655 - 18854), 1, 0);

            var man = layFore.CreateSprite(@"SB\man.png", OsbOrigin.Centre, new Vector2(385, 244));
            man.Fade(StartTime + (19020 - 18854), 1);
            man.Fade(StartTime + (24324 - 18854), StartTime + (24655 - 18854), 1, 0);

            var mouth = layFore.CreateSprite(@"SB\2dx_34.png", OsbOrigin.Centre, new Vector2(380, 246));
            mouth.Fade(StartTime + (19020 - 18854), 1);
            //mouth.Fade(startTime + (24324 - 18854), startTime + (24655 - 18854), 1, 0);
            var mouth2 = layFore.CreateSprite(@"SB\2dx_35.png", OsbOrigin.Centre, new Vector2(380, 246));
            mouth2.Fade(StartTime, 0);
            var mouth3 = layFore.CreateSprite(@"SB\2dx_36.png", OsbOrigin.Centre, new Vector2(381, 246));
            int[] sayTime = { 20595, 2, 21506, 3 };
            const int aniInterval = 80;
            for (int i = 0; i < sayTime.Length - 1; i += 2)
            {
                for (int j = 0; j < sayTime[i + 1]; j++)
                {
                    mouth.Fade(StartTime + (sayTime[i] - 18854) + j * aniInterval * 4, 0);
                    mouth2.Fade(StartTime + (sayTime[i] - 18854) + j * aniInterval * 4, 1);
                    mouth2.ScaleVec(StartTime + (sayTime[i] - 18854) + j * aniInterval * 4, 1, 0.5);
                    mouth2.ScaleVec(StartTime + (sayTime[i] - 18854) + aniInterval + j * aniInterval * 4, 1, 1);
                    mouth2.ScaleVec(StartTime + (sayTime[i] - 18854) + aniInterval * 2 + j * aniInterval * 4, 1, 0.5);
                    mouth2.Fade(StartTime + (sayTime[i] - 18854) + aniInterval * 3 + j * aniInterval * 4, 0);
                    mouth.Fade(StartTime + (sayTime[i] - 18854) + aniInterval * 3 + j * aniInterval * 4, 1);
                }
            }
            const int smileTime = 23164;
            mouth.Fade(StartTime + (smileTime - 18854), 0);
            mouth2.Fade(StartTime + (smileTime - 18854), 1);
            mouth2.ScaleVec(StartTime + (smileTime - 18854), 1, 0.5);
            mouth2.ScaleVec(StartTime + (smileTime - 18854) + aniInterval, 1, 1);
            mouth2.Fade(StartTime + (smileTime - 18854) + aniInterval * 2, 0);
            mouth3.Fade(StartTime + (smileTime - 18854) + aniInterval * 2, 1);
            mouth3.Fade(StartTime + (24324 - 18854), StartTime + (24655 - 18854), 1, 0);

            var kira = layFore.CreateSprite(@"SB\2dx_32.png", OsbOrigin.Centre, new Vector2(400, 241));
            kira.Scale(StartTime + (23578 - 18854), StartTime + (23661 - 18854), 0, 1);
            kira.Rotate(StartTime + (23578 - 18854), StartTime + (24324 - 18854), 0, 1);
            kira.Scale(StartTime + (23661 - 18854), StartTime + (24324 - 18854), 1, 0);
            kira.Fade(StartTime + (23661 - 18854), StartTime + (24324 - 18854), 1, 0);

            var hand = layFore.CreateSprite(@"SB\2dx_33.png", OsbOrigin.BottomCentre, new Vector2(462, 246));
            hand.MoveY(StartTime + (20760 - 18854), StartTime + (21092 - 18854), 447, 370);
            hand.Scale(StartTime + (20678 - 18854), 0.9);
            hand.Fade(StartTime + (24324 - 18854), StartTime + (24655 - 18854), 1, 0);

            var doorLeft = layFore.CreateSprite(@"SB\door_left.png", OsbOrigin.CentreRight);
            doorLeft.MoveX(StartTime + (19269 - 18854), StartTime + (20180 - 18854), 320, 0);
            doorLeft.Fade(StartTime + (18854 - 18854), StartTime + (19020 - 18854), 0, 1);
            var doorRight = layFore.CreateSprite(@"SB\door_right.png", OsbOrigin.CentreLeft);
            doorRight.MoveX(StartTime + (19269 - 18854), StartTime + (20180 - 18854), 320, 640);
            doorRight.Fade(StartTime + (18854 - 18854), StartTime + (19020 - 18854), 0, 1);
            var panelBorder = layFore.CreateSprite(@"SB\panel_border.png");
            panelBorder.Fade(StartTime + (18854 - 18854), StartTime + (19020 - 18854), 0, 1);
            panelBorder.Fade(StartTime + (24324 - 18854), StartTime + (24655 - 18854), 1, 0);

        }
    }
}
