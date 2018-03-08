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
    public class RunScene : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime = 27639;
        [Configurable]
        public int leafOffset = 0;
        [Configurable]
        public int leafEndOffset = 0;
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");

            int leafSpeed = 150;
            var leaf = lay_fore.CreateSprite(@"SB\2dx_27.png");
            int[] timingPoints = { 29379, 33357, 30374, 34849 };
            leaf.Move(startTime + leafOffset, startTime + (37584 - 27639) + leafEndOffset, 195, 240, 195, 240);
            foreach (var item in timingPoints)
            {
                leaf.ScaleVec(startTime + (item - 27639), startTime + (item + leafSpeed - 27639), 1, 1, 0, 1);
                leaf.ScaleVec(startTime + (item + leafSpeed - 27639), startTime + (item + leafSpeed * 2 - 27639), 0, 1, 1, 1);
                leaf.ScaleVec(startTime + (item + leafSpeed * 2 - 27639), startTime + (item + leafSpeed * 3 - 27639), 1, 1, 0, 1);
                leaf.ScaleVec(startTime + (item + leafSpeed * 3 - 27639), startTime + (item + leafSpeed * 4 - 27639), 0, 1, 1, 1);
            }
            var leaf2 = lay_fore.CreateSprite(@"SB\2dx_27.png");
            leaf2.Move(startTime + leafOffset, startTime + (37584 - 27639) + leafEndOffset, 320, 240, 320, 240);
            int[] timingPoints2 = { 28882, 33771, 30042, 35180 };

            foreach (var item in timingPoints2)
            {
                leaf2.ScaleVec(startTime + (item - 27639), startTime + (item + leafSpeed - 27639), 1, 1, 0, 1);
                leaf2.ScaleVec(startTime + (item + leafSpeed - 27639), startTime + (item + leafSpeed * 2 - 27639), 0, 1, 1, 1);
                leaf2.ScaleVec(startTime + (item + leafSpeed * 2 - 27639), startTime + (item + leafSpeed * 3 - 27639), 1, 1, 0, 1);
                leaf2.ScaleVec(startTime + (item + leafSpeed * 3 - 27639), startTime + (item + leafSpeed * 4 - 27639), 0, 1, 1, 1);
            }

            var leaf3 = lay_fore.CreateSprite(@"SB\2dx_27.png");
            leaf3.Move(startTime + leafOffset, startTime + (37584 - 27639) + leafEndOffset, 445, 240, 445, 240);
            int[] timingPoints3 = { 28468, 34269, 29794, 35512 };

            foreach (var item in timingPoints3)
            {
                leaf3.ScaleVec(startTime + (item - 27639), startTime + (item + leafSpeed - 27639), 1, 1, 0, 1);
                leaf3.ScaleVec(startTime + (item + leafSpeed - 27639), startTime + (item + leafSpeed * 2 - 27639), 0, 1, 1, 1);
                leaf3.ScaleVec(startTime + (item + leafSpeed * 2 - 27639), startTime + (item + leafSpeed * 3 - 27639), 1, 1, 0, 1);
                leaf3.ScaleVec(startTime + (item + leafSpeed * 3 - 27639), startTime + (item + leafSpeed * 4 - 27639), 0, 1, 1, 1);
            }

            // heart shadow
            Vector2[] pos;
            int start_time = startTime + (28468 - 27639);
            double[] rot;

            pos = new Vector2[] {   new Vector2(568, 235),
                                    new Vector2(505, 247),
                                    new Vector2(445, 220),
                                    new Vector2(355, 230),
                                    new Vector2(290, 205),
                                    new Vector2(230, 220),
                                    new Vector2(145, 215),

                                    new Vector2(58, 351),
                                    new Vector2(125, 335),
                                    new Vector2(180, 370),
                                    new Vector2(263, 335),
                                    new Vector2(340, 343),
                                    new Vector2(425, 345),
                                    new Vector2(531, 355),
                                    };
            rot = new double[] { 0.85, 0.2, 0.5, -0.3, 0.65, -0.4, 0.5,
                                 -1.05, 0.5, -0.7, -0.3, -0.6, -0.5, 0.5 };
            int fade_time = 28882 - 28468 - 30;
            int interval = 250;
            for (int i = 0; i < pos.Length / 2; i++)
            {
                var flower = lay_fore.CreateSprite("SB\\2dx_90.png");
                flower.Move(start_time + i * interval, pos[i]);
                flower.Rotate(start_time + i * interval, rot[i]);
                flower.Scale(start_time + i * interval, start_time + fade_time + i * interval, 0, 0.7);
                flower.Scale(start_time + fade_time + i * interval, start_time + fade_time * 2 + i * interval - 30, 0.7, 0);
                flower.Fade(start_time + fade_time + i * interval, start_time + fade_time * 2 + i * interval - 30, 1, 0);
            }
            start_time = startTime + (33274 - 27639);
            for (int i = pos.Length / 2; i < pos.Length; i++)
            {
                var flower = lay_fore.CreateSprite("SB\\2dx_90.png");
                flower.Move(start_time + (i - pos.Length / 2) * interval, pos[i]);
                flower.Rotate(start_time + (i - pos.Length / 2) * interval, rot[i]);
                flower.Scale(start_time + (i - pos.Length / 2) * interval, start_time + fade_time + (i - pos.Length / 2) * interval, 0, 0.7);
                flower.Scale(start_time + fade_time + (i - pos.Length / 2) * interval, start_time + fade_time * 2 + (i - pos.Length / 2) * interval - 30, 0.7, 0);
                flower.Fade(start_time + fade_time + (i - pos.Length / 2) * interval, start_time + fade_time * 2 + (i - pos.Length / 2) * interval - 30, 1, 0);
            }
            // fox & girl
            int inteval = 120;
            var hito = lay_fore.CreateAnimation(@"SB\Ani3\a.png", 8, inteval, OsbLoopType.LoopForever);
            int y = 170;
            hito.Fade(startTime, 1);
            hito.Fade(startTime + (30291 - 27639), 0);
            hito.MoveX(startTime, startTime + (30291 - 27639), 720, -80);
            hito.Scale(startTime, 0.95);
            hito.StartLoopGroup(startTime, 3);
            hito.MoveY(0, inteval, y, y);
            hito.MoveY(inteval, inteval * 2, y - 20, y - 20);
            hito.MoveY(inteval * 2, inteval * 3, y + 10, y + 10);
            hito.MoveY(inteval * 3, inteval * 4, y + 5, y + 5);
            hito.MoveY(inteval * 4, inteval * 5, y, y);
            hito.MoveY(inteval * 5, inteval * 6, y - 38, y - 38);
            hito.MoveY(inteval * 6, inteval * 7, y, y);
            hito.MoveY(inteval * 7, inteval * 8, y, y);
            hito.EndGroup();

            int inteval2 = 80;
            var tail = lay_fore.CreateSprite(@"SB\2dx_26.png", OsbOrigin.BottomRight);
            y = 222;
            tail.Fade(startTime + (30954 - 27639), 0);
            tail.MoveX(startTime + (29131 - 27639), startTime + (30954 - 27639), 800, 0);
            tail.Scale(startTime + (29131 - 27639), 0.5);
            tail.StartLoopGroup(startTime + (29131 - 27639), 5);
            tail.Fade(0, 0);
            tail.MoveY(0, inteval2, y + 5, y + 5);
            tail.MoveY(inteval2, inteval2 * 2, y - 10, y - 10);
            tail.Fade(inteval2 * 2, 1);
            tail.MoveY(inteval2 * 2, inteval2 * 3, y - 28, y - 28);
            tail.Rotate(inteval2 * 2, inteval2 * 3, 0, 0);
            tail.MoveY(inteval2 * 3, inteval2 * 4, y - 30, y - 30);
            tail.Rotate(inteval2 * 3, inteval2 * 4, -0.3, -0.3);
            tail.MoveY(inteval2 * 4, inteval2 * 5, y - 20, y - 20);
            tail.Rotate(inteval2 * 4, inteval2 * 5, -0.3, -0.3);
            tail.EndGroup();

            var tail_hid = lay_fore.CreateSprite(@"SB\2dx_26.png", OsbOrigin.BottomRight);
            y = 222;
            tail_hid.Fade(startTime + (30954 - 27639), 0);
            tail_hid.MoveX(startTime + (29131 - 27639), startTime + (30954 - 27639), 825, 25);
            tail_hid.Scale(startTime + (29131 - 27639), 0.5);
            tail_hid.StartLoopGroup(startTime + (29131 - 27639), 5);

            tail_hid.Fade(0, 1);
            tail_hid.MoveY(0, inteval2, y - 8, y - 8);
            tail_hid.Rotate(0, inteval2, 0, 0);
            tail_hid.MoveY(inteval2, inteval2 * 2, y - 20, y - 20);
            tail_hid.Rotate(inteval2, inteval2 * 2, -0.2, -0.2);
            tail_hid.Fade(inteval2 * 2, 0);
            tail_hid.MoveY(inteval2 * 2, inteval2 * 3, y - 28, y - 28);
            tail_hid.Rotate(inteval2 * 2, inteval2 * 3, 0, 0);
            tail_hid.MoveY(inteval2 * 3, inteval2 * 4, y - 30, y - 30);
            tail_hid.Rotate(inteval2 * 3, inteval2 * 4, -0.3, -0.3);
            tail_hid.MoveY(inteval2 * 4, inteval2 * 5, y - 20, y - 20);
            tail_hid.Rotate(inteval2 * 4, inteval2 * 5, -0.3, -0.3);
            tail_hid.EndGroup();

            var fox = lay_fore.CreateAnimation(@"SB\Ani4\a.png", 5, inteval2, OsbLoopType.LoopForever, OsbOrigin.Centre);
            y = 190;
            fox.Fade(startTime + (29131 - 27639), 1);
            fox.Fade(startTime + (30954 - 27639), 0);
            fox.MoveX(startTime + (29131 - 27639), startTime + (30954 - 27639), 720, -80);
            fox.Scale(startTime + (29131 - 27639), 0.95);
            fox.StartLoopGroup(startTime + (29131 - 27639), 5);
            fox.MoveY(0, inteval2, y + 5, y + 5);
            fox.MoveY(inteval2, inteval2 * 2, y - 10, y - 10);
            fox.MoveY(inteval2 * 2, inteval2 * 3, y - 30, y - 30);
            fox.MoveY(inteval2 * 3, inteval2 * 4, y - 10, y - 10);
            fox.MoveY(inteval2 * 4, inteval2 * 5, y, y);
            fox.EndGroup();

            var hito2 = lay_fore.CreateAnimation(@"SB\Ani3\a.png", 8, inteval, OsbLoopType.LoopForever);
            y = 280;
            hito2.Fade(startTime + (32445 - 27639), 1);
            hito2.Fade(startTime + (35180 - 27639), 0);
            hito2.MoveX(startTime + (32445 - 27639), startTime + (35180 - 27639), -80, 720);
            hito2.Scale(startTime + (32445 - 27639), 0.95);
            hito2.FlipH(startTime + (32445 - 27639), startTime + (35180 - 27639));
            hito2.StartLoopGroup(startTime + (32445 - 27639), 3);
            hito2.MoveY(0, inteval, y, y);
            hito2.MoveY(inteval, inteval * 2, y - 20, y - 20);
            hito2.MoveY(inteval * 2, inteval * 3, y + 10, y + 10);
            hito2.MoveY(inteval * 3, inteval * 4, y + 5, y + 5);
            hito2.MoveY(inteval * 4, inteval * 5, y, y);
            hito2.MoveY(inteval * 5, inteval * 6, y - 38, y - 38);
            hito2.MoveY(inteval * 6, inteval * 7, y, y);
            hito2.MoveY(inteval * 7, inteval * 8, y, y);
            hito2.EndGroup();


            var tail_2 = lay_fore.CreateSprite(@"SB\2dx_26.png", OsbOrigin.BottomLeft);
            y = 352;
            tail_2.Fade(startTime + (36258 - 27639), 0);
            tail_2.MoveX(startTime + (34103 - 27639), startTime + (36258 - 27639), -155, 645);
            tail_2.Scale(startTime + (34103 - 27639), 0.5);
            tail_2.FlipH(startTime + (34103 - 27639), startTime + (36258 - 27639));

            tail_2.StartLoopGroup(startTime + (34103 - 27639), 5);
            tail_2.Fade(0, 0);
            tail_2.MoveY(0, inteval2, y + 5, y + 5);
            tail_2.MoveY(inteval2, inteval2 * 2, y - 10, y - 10);
            tail_2.Fade(inteval2 * 2, 1);
            tail_2.MoveY(inteval2 * 2, inteval2 * 3, y - 28, y - 28);
            tail_2.Rotate(inteval2 * 2, inteval2 * 3, 0, 0);
            tail_2.MoveY(inteval2 * 3, inteval2 * 4, y - 30, y - 30);
            tail_2.Rotate(inteval2 * 3, inteval2 * 4, 0.3, 0.3);
            tail_2.MoveY(inteval2 * 4, inteval2 * 5, y - 20, y - 20);
            tail_2.Rotate(inteval2 * 4, inteval2 * 5, 0.3, 0.3);
            tail_2.EndGroup();

            var tail_2_hid = lay_fore.CreateSprite(@"SB\2dx_26.png", OsbOrigin.BottomLeft);
            y = 352;
            tail_2_hid.Fade(startTime + (36258 - 27639), 0);
            tail_2_hid.MoveX(startTime + (34103 - 27639), startTime + (36258 - 27639), -180, 620);
            tail_2_hid.Scale(startTime + (34103 - 27639), 0.5);
            tail_2_hid.FlipH(startTime + (34103 - 27639), startTime + (36258 - 27639));

            tail_2_hid.StartLoopGroup(startTime + (34103 - 27639), 5);
            tail_2_hid.Fade(0, 1);
            tail_2_hid.MoveY(0, inteval2, y - 8, y - 8);
            tail_2_hid.Rotate(0, inteval2, 0, 0);
            tail_2_hid.MoveY(inteval2, inteval2 * 2, y - 20, y - 20);
            tail_2_hid.Rotate(inteval2, inteval2 * 2, 0.2, 0.2);
            tail_2_hid.Fade(inteval2 * 2, 0);
            tail_2_hid.MoveY(inteval2 * 2, inteval2 * 3, y - 28, y - 28);
            tail_2_hid.Rotate(inteval2 * 2, inteval2 * 3, 0, 0);
            tail_2_hid.MoveY(inteval2 * 3, inteval2 * 4, y - 30, y - 30);
            tail_2_hid.Rotate(inteval2 * 3, inteval2 * 4, 0.3, 0.3);
            tail_2_hid.MoveY(inteval2 * 4, inteval2 * 5, y - 20, y - 20);
            tail_2_hid.Rotate(inteval2 * 4, inteval2 * 5, 0.3, 0.3);
            tail_2_hid.EndGroup();

            var fox2 = lay_fore.CreateAnimation(@"SB\Ani4\a.png", 5, inteval2, OsbLoopType.LoopForever, OsbOrigin.Centre);
            y = 320;
            fox2.Fade(startTime + (34103 - 27639), 1);
            fox2.Fade(startTime + (36258 - 27639), 0);
            fox2.MoveX(startTime + (34103 - 27639), startTime + (36258 - 27639), -80, 720);
            fox2.Scale(startTime + (34103 - 27639), 0.95);
            fox2.FlipH(startTime + (34103 - 27639), startTime + (36258 - 27639));
            fox2.StartLoopGroup(startTime + (34103 - 27639), 5);
            fox2.MoveY(0, inteval2, y + 5, y + 5);
            fox2.MoveY(inteval2, inteval2 * 2, y - 10, y - 10);
            fox2.MoveY(inteval2 * 2, inteval2 * 3, y - 30, y - 30);
            fox2.MoveY(inteval2 * 3, inteval2 * 4, y - 10, y - 10);
            fox2.MoveY(inteval2 * 4, inteval2 * 5, y, y);
            fox2.EndGroup();


        }
    }
}
