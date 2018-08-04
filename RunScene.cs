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
        public int StartTime = 27639;
        [Configurable]
        public int LeafOffset = 0;
        [Configurable]
        public int LeafEndOffset = 0;

        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");

            const int leafSpeed = 150;
            var leaf = layFore.CreateSprite(@"SB\2dx_27.png");
            int[] timingPoints = { 29379, 33357, 30374, 34849 };
            leaf.Move(StartTime + LeafOffset, StartTime + (37584 - 27639) + LeafEndOffset, 195, 240, 195, 240);
            foreach (var item in timingPoints)
            {
                leaf.ScaleVec(StartTime + (item - 27639), StartTime + (item + leafSpeed - 27639), 1, 1, 0, 1);
                leaf.ScaleVec(StartTime + (item + leafSpeed - 27639), StartTime + (item + leafSpeed * 2 - 27639), 0, 1,
                    1, 1);
                leaf.ScaleVec(StartTime + (item + leafSpeed * 2 - 27639), StartTime + (item + leafSpeed * 3 - 27639), 1,
                    1, 0, 1);
                leaf.ScaleVec(StartTime + (item + leafSpeed * 3 - 27639), StartTime + (item + leafSpeed * 4 - 27639), 0,
                    1, 1, 1);
            }

            var leaf2 = layFore.CreateSprite(@"SB\2dx_27.png");
            leaf2.Move(StartTime + LeafOffset, StartTime + (37584 - 27639) + LeafEndOffset, 320, 240, 320, 240);
            int[] timingPoints2 = { 28882, 33771, 30042, 35180 };

            foreach (var item in timingPoints2)
            {
                leaf2.ScaleVec(StartTime + (item - 27639), StartTime + (item + leafSpeed - 27639), 1, 1, 0, 1);
                leaf2.ScaleVec(StartTime + (item + leafSpeed - 27639), StartTime + (item + leafSpeed * 2 - 27639), 0, 1,
                    1, 1);
                leaf2.ScaleVec(StartTime + (item + leafSpeed * 2 - 27639), StartTime + (item + leafSpeed * 3 - 27639),
                    1, 1, 0, 1);
                leaf2.ScaleVec(StartTime + (item + leafSpeed * 3 - 27639), StartTime + (item + leafSpeed * 4 - 27639),
                    0, 1, 1, 1);
            }

            var leaf3 = layFore.CreateSprite(@"SB\2dx_27.png");
            leaf3.Move(StartTime + LeafOffset, StartTime + (37584 - 27639) + LeafEndOffset, 445, 240, 445, 240);
            int[] timingPoints3 = { 28468, 34269, 29794, 35512 };

            foreach (var item in timingPoints3)
            {
                leaf3.ScaleVec(StartTime + (item - 27639), StartTime + (item + leafSpeed - 27639), 1, 1, 0, 1);
                leaf3.ScaleVec(StartTime + (item + leafSpeed - 27639), StartTime + (item + leafSpeed * 2 - 27639), 0, 1,
                    1, 1);
                leaf3.ScaleVec(StartTime + (item + leafSpeed * 2 - 27639), StartTime + (item + leafSpeed * 3 - 27639),
                    1, 1, 0, 1);
                leaf3.ScaleVec(StartTime + (item + leafSpeed * 3 - 27639), StartTime + (item + leafSpeed * 4 - 27639),
                    0, 1, 1, 1);
            }

            // heart shadow
            int newStartTime = StartTime + (28468 - 27639);
            Vector2[] pos = {
                new Vector2(568, 235),
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
            double[] rot =
            {
                0.85, 0.2, 0.5, -0.3, 0.65, -0.4, 0.5,
                -1.05, 0.5, -0.7, -0.3, -0.6, -0.5, 0.5
            };
            const int fadeTime = 28882 - 28468 - 30, interval = 250;
            for (int i = 0; i < pos.Length / 2; i++)
            {
                var flower = layFore.CreateSprite("SB\\2dx_90.png");
                flower.Move(newStartTime + i * interval, pos[i]);
                flower.Rotate(newStartTime + i * interval, rot[i]);
                flower.Scale(newStartTime + i * interval, newStartTime + fadeTime + i * interval, 0, 0.7);
                flower.Scale(newStartTime + fadeTime + i * interval, newStartTime + fadeTime * 2 + i * interval - 30, 0.7,
                    0);
                flower.Fade(newStartTime + fadeTime + i * interval, newStartTime + fadeTime * 2 + i * interval - 30, 1,
                    0);
            }

            newStartTime = StartTime + (33274 - 27639);
            for (int i = pos.Length / 2; i < pos.Length; i++)
            {
                var flower = layFore.CreateSprite("SB\\2dx_90.png");
                flower.Move(newStartTime + (i - pos.Length / 2) * interval, pos[i]);
                flower.Rotate(newStartTime + (i - pos.Length / 2) * interval, rot[i]);
                flower.Scale(newStartTime + (i - pos.Length / 2) * interval,
                    newStartTime + fadeTime + (i - pos.Length / 2) * interval, 0, 0.7);
                flower.Scale(newStartTime + fadeTime + (i - pos.Length / 2) * interval,
                    newStartTime + fadeTime * 2 + (i - pos.Length / 2) * interval - 30, 0.7, 0);
                flower.Fade(newStartTime + fadeTime + (i - pos.Length / 2) * interval,
                    newStartTime + fadeTime * 2 + (i - pos.Length / 2) * interval - 30, 1, 0);
            }

            // fox & girl
            int inteval = 120;
            var hito = layFore.CreateAnimation(@"SB\Ani3\a.png", 8, inteval, OsbLoopType.LoopForever);
            int y = 170;
            hito.Fade(StartTime, 1);
            hito.Fade(StartTime + (30291 - 27639), 0);
            hito.MoveX(StartTime, StartTime + (30291 - 27639), 720, -80);
            hito.Scale(StartTime, 0.95);
            hito.StartLoopGroup(StartTime, 3);
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
            var tail = layFore.CreateSprite(@"SB\2dx_26.png", OsbOrigin.BottomRight);
            y = 222;
            tail.Fade(StartTime + (30954 - 27639), 0);
            tail.MoveX(StartTime + (29131 - 27639), StartTime + (30954 - 27639), 800, 0);
            tail.Scale(StartTime + (29131 - 27639), 0.5);
            tail.StartLoopGroup(StartTime + (29131 - 27639), 5);
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

            var tailHid = layFore.CreateSprite(@"SB\2dx_26.png", OsbOrigin.BottomRight);
            y = 222;
            tailHid.Fade(StartTime + (30954 - 27639), 0);
            tailHid.MoveX(StartTime + (29131 - 27639), StartTime + (30954 - 27639), 825, 25);
            tailHid.Scale(StartTime + (29131 - 27639), 0.5);
            tailHid.StartLoopGroup(StartTime + (29131 - 27639), 5);

            tailHid.Fade(0, 1);
            tailHid.MoveY(0, inteval2, y - 8, y - 8);
            tailHid.Rotate(0, inteval2, 0, 0);
            tailHid.MoveY(inteval2, inteval2 * 2, y - 20, y - 20);
            tailHid.Rotate(inteval2, inteval2 * 2, -0.2, -0.2);
            tailHid.Fade(inteval2 * 2, 0);
            tailHid.MoveY(inteval2 * 2, inteval2 * 3, y - 28, y - 28);
            tailHid.Rotate(inteval2 * 2, inteval2 * 3, 0, 0);
            tailHid.MoveY(inteval2 * 3, inteval2 * 4, y - 30, y - 30);
            tailHid.Rotate(inteval2 * 3, inteval2 * 4, -0.3, -0.3);
            tailHid.MoveY(inteval2 * 4, inteval2 * 5, y - 20, y - 20);
            tailHid.Rotate(inteval2 * 4, inteval2 * 5, -0.3, -0.3);
            tailHid.EndGroup();

            var fox = layFore.CreateAnimation(@"SB\Ani4\a.png", 5, inteval2, OsbLoopType.LoopForever);
            y = 190;
            fox.Fade(StartTime + (29131 - 27639), 1);
            fox.Fade(StartTime + (30954 - 27639), 0);
            fox.MoveX(StartTime + (29131 - 27639), StartTime + (30954 - 27639), 720, -80);
            fox.Scale(StartTime + (29131 - 27639), 0.95);
            fox.StartLoopGroup(StartTime + (29131 - 27639), 5);
            fox.MoveY(0, inteval2, y + 5, y + 5);
            fox.MoveY(inteval2, inteval2 * 2, y - 10, y - 10);
            fox.MoveY(inteval2 * 2, inteval2 * 3, y - 30, y - 30);
            fox.MoveY(inteval2 * 3, inteval2 * 4, y - 10, y - 10);
            fox.MoveY(inteval2 * 4, inteval2 * 5, y, y);
            fox.EndGroup();

            var hito2 = layFore.CreateAnimation(@"SB\Ani3\a.png", 8, inteval, OsbLoopType.LoopForever);
            y = 280;
            hito2.Fade(StartTime + (32445 - 27639), 1);
            hito2.Fade(StartTime + (35180 - 27639), 0);
            hito2.MoveX(StartTime + (32445 - 27639), StartTime + (35180 - 27639), -80, 720);
            hito2.Scale(StartTime + (32445 - 27639), 0.95);
            hito2.FlipH(StartTime + (32445 - 27639), StartTime + (35180 - 27639));
            hito2.StartLoopGroup(StartTime + (32445 - 27639), 3);
            hito2.MoveY(0, inteval, y, y);
            hito2.MoveY(inteval, inteval * 2, y - 20, y - 20);
            hito2.MoveY(inteval * 2, inteval * 3, y + 10, y + 10);
            hito2.MoveY(inteval * 3, inteval * 4, y + 5, y + 5);
            hito2.MoveY(inteval * 4, inteval * 5, y, y);
            hito2.MoveY(inteval * 5, inteval * 6, y - 38, y - 38);
            hito2.MoveY(inteval * 6, inteval * 7, y, y);
            hito2.MoveY(inteval * 7, inteval * 8, y, y);
            hito2.EndGroup();


            var tail2 = layFore.CreateSprite(@"SB\2dx_26.png", OsbOrigin.BottomLeft);
            y = 352;
            tail2.Fade(StartTime + (36258 - 27639), 0);
            tail2.MoveX(StartTime + (34103 - 27639), StartTime + (36258 - 27639), -155, 645);
            tail2.Scale(StartTime + (34103 - 27639), 0.5);
            tail2.FlipH(StartTime + (34103 - 27639), StartTime + (36258 - 27639));

            tail2.StartLoopGroup(StartTime + (34103 - 27639), 5);
            tail2.Fade(0, 0);
            tail2.MoveY(0, inteval2, y + 5, y + 5);
            tail2.MoveY(inteval2, inteval2 * 2, y - 10, y - 10);
            tail2.Fade(inteval2 * 2, 1);
            tail2.MoveY(inteval2 * 2, inteval2 * 3, y - 28, y - 28);
            tail2.Rotate(inteval2 * 2, inteval2 * 3, 0, 0);
            tail2.MoveY(inteval2 * 3, inteval2 * 4, y - 30, y - 30);
            tail2.Rotate(inteval2 * 3, inteval2 * 4, 0.3, 0.3);
            tail2.MoveY(inteval2 * 4, inteval2 * 5, y - 20, y - 20);
            tail2.Rotate(inteval2 * 4, inteval2 * 5, 0.3, 0.3);
            tail2.EndGroup();

            var tail2Hid = layFore.CreateSprite(@"SB\2dx_26.png", OsbOrigin.BottomLeft);
            y = 352;
            tail2Hid.Fade(StartTime + (36258 - 27639), 0);
            tail2Hid.MoveX(StartTime + (34103 - 27639), StartTime + (36258 - 27639), -180, 620);
            tail2Hid.Scale(StartTime + (34103 - 27639), 0.5);
            tail2Hid.FlipH(StartTime + (34103 - 27639), StartTime + (36258 - 27639));

            tail2Hid.StartLoopGroup(StartTime + (34103 - 27639), 5);
            tail2Hid.Fade(0, 1);
            tail2Hid.MoveY(0, inteval2, y - 8, y - 8);
            tail2Hid.Rotate(0, inteval2, 0, 0);
            tail2Hid.MoveY(inteval2, inteval2 * 2, y - 20, y - 20);
            tail2Hid.Rotate(inteval2, inteval2 * 2, 0.2, 0.2);
            tail2Hid.Fade(inteval2 * 2, 0);
            tail2Hid.MoveY(inteval2 * 2, inteval2 * 3, y - 28, y - 28);
            tail2Hid.Rotate(inteval2 * 2, inteval2 * 3, 0, 0);
            tail2Hid.MoveY(inteval2 * 3, inteval2 * 4, y - 30, y - 30);
            tail2Hid.Rotate(inteval2 * 3, inteval2 * 4, 0.3, 0.3);
            tail2Hid.MoveY(inteval2 * 4, inteval2 * 5, y - 20, y - 20);
            tail2Hid.Rotate(inteval2 * 4, inteval2 * 5, 0.3, 0.3);
            tail2Hid.EndGroup();

            var fox2 = layFore.CreateAnimation(@"SB\Ani4\a.png", 5, inteval2, OsbLoopType.LoopForever);
            y = 320;
            fox2.Fade(StartTime + (34103 - 27639), 1);
            fox2.Fade(StartTime + (36258 - 27639), 0);
            fox2.MoveX(StartTime + (34103 - 27639), StartTime + (36258 - 27639), -80, 720);
            fox2.Scale(StartTime + (34103 - 27639), 0.95);
            fox2.FlipH(StartTime + (34103 - 27639), StartTime + (36258 - 27639));
            fox2.StartLoopGroup(StartTime + (34103 - 27639), 5);
            fox2.MoveY(0, inteval2, y + 5, y + 5);
            fox2.MoveY(inteval2, inteval2 * 2, y - 10, y - 10);
            fox2.MoveY(inteval2 * 2, inteval2 * 3, y - 30, y - 30);
            fox2.MoveY(inteval2 * 3, inteval2 * 4, y - 10, y - 10);
            fox2.MoveY(inteval2 * 4, inteval2 * 5, y, y);
            fox2.EndGroup();
        }
    }
}
