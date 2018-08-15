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
        public int startTime = 18854;
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            var panel_back = lay_fore.CreateSprite(@"SB\panel_back.png");
            panel_back.Fade(startTime + (18854 - 18854), startTime + (19020 - 18854), 0, 1);
            panel_back.Fade(startTime + (24324 - 18854), startTime + (24655 - 18854), 1, 0);

            var man = lay_fore.CreateSprite(@"SB\man.png", OsbOrigin.Centre, new Vector2(385, 244));
            man.Fade(startTime + (19020 - 18854), 1);
            man.Fade(startTime + (24324 - 18854), startTime + (24655 - 18854), 1, 0);

            var mouth = lay_fore.CreateSprite(@"SB\2dx_34.png", OsbOrigin.Centre, new Vector2(380, 246));
            mouth.Fade(startTime + (19020 - 18854), 1);
            //mouth.Fade(startTime + (24324 - 18854), startTime + (24655 - 18854), 1, 0);
            var mouth2 = lay_fore.CreateSprite(@"SB\2dx_35.png", OsbOrigin.Centre, new Vector2(380, 246));
            mouth2.Fade(startTime, 0);
            var mouth3 = lay_fore.CreateSprite(@"SB\2dx_36.png", OsbOrigin.Centre, new Vector2(381, 246));
            int[] say_time = { 20595, 2, 21506, 3 };
            int ani_interval = 80;
            for (int i = 0; i < say_time.Length - 1; i += 2)
            {
                for (int j = 0; j < say_time[i + 1]; j++)
                {
                    mouth.Fade(startTime + (say_time[i] - 18854) + j * ani_interval * 4, 0);
                    mouth2.Fade(startTime + (say_time[i] - 18854) + j * ani_interval * 4, 1);
                    mouth2.ScaleVec(startTime + (say_time[i] - 18854) + j * ani_interval * 4, 1, 0.5);
                    mouth2.ScaleVec(startTime + (say_time[i] - 18854) + ani_interval + j * ani_interval * 4, 1, 1);
                    mouth2.ScaleVec(startTime + (say_time[i] - 18854) + ani_interval * 2 + j * ani_interval * 4, 1, 0.5);
                    mouth2.Fade(startTime + (say_time[i] - 18854) + ani_interval * 3 + j * ani_interval * 4, 0);
                    mouth.Fade(startTime + (say_time[i] - 18854) + ani_interval * 3 + j * ani_interval * 4, 1);
                }
            }
            int smile_time = 23164;
            mouth.Fade(startTime + (smile_time - 18854), 0);
            mouth2.Fade(startTime + (smile_time - 18854), 1);
            mouth2.ScaleVec(startTime + (smile_time - 18854), 1, 0.5);
            mouth2.ScaleVec(startTime + (smile_time - 18854) + ani_interval, 1, 1);
            mouth2.Fade(startTime + (smile_time - 18854) + ani_interval * 2, 0);
            mouth3.Fade(startTime + (smile_time - 18854) + ani_interval * 2, 1);
            mouth3.Fade(startTime + (24324 - 18854), startTime + (24655 - 18854), 1, 0);

            var kira = lay_fore.CreateSprite(@"SB\2dx_32.png", OsbOrigin.Centre, new Vector2(400, 241));
            kira.Scale(startTime + (23578 - 18854), startTime + (23661 - 18854), 0, 1);
            kira.Rotate(startTime + (23578 - 18854), startTime + (24324 - 18854), 0, 1);
            kira.Scale(startTime + (23661 - 18854), startTime + (24324 - 18854), 1, 0);
            kira.Fade(startTime + (23661 - 18854), startTime + (24324 - 18854), 1, 0);

            var hand = lay_fore.CreateSprite(@"SB\2dx_33.png", OsbOrigin.BottomCentre, new Vector2(462, 246));
            hand.MoveY(startTime + (20760 - 18854), startTime + (21092 - 18854), 447, 370);
            hand.Scale(startTime + (20678 - 18854), 0.9);
            hand.Fade(startTime + (24324 - 18854), startTime + (24655 - 18854), 1, 0);

            var door_left = lay_fore.CreateSprite(@"SB\door_left.png", OsbOrigin.CentreRight);
            door_left.MoveX(startTime + (19269 - 18854), startTime + (20180 - 18854), 320, 0);
            door_left.Fade(startTime + (18854 - 18854), startTime + (19020 - 18854), 0, 1);
            var door_right = lay_fore.CreateSprite(@"SB\door_right.png", OsbOrigin.CentreLeft);
            door_right.MoveX(startTime + (19269 - 18854), startTime + (20180 - 18854), 320, 640);
            door_right.Fade(startTime + (18854 - 18854), startTime + (19020 - 18854), 0, 1);
            var panel_border = lay_fore.CreateSprite(@"SB\panel_border.png");
            panel_border.Fade(startTime + (18854 - 18854), startTime + (19020 - 18854), 0, 1);
            panel_border.Fade(startTime + (24324 - 18854), startTime + (24655 - 18854), 1, 0);

        }
    }
}
