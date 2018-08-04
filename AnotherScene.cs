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
    public class AnotherScene : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            const int startTime = 77363, endTime = 80843;


            StoryboardLayer layBack = GetLayer("Back");
            var sky = layBack.CreateSprite("SB\\2dx_22.png", OsbOrigin.TopLeft);
            sky.Move(startTime, 0, 0);
            sky.ScaleVec(startTime, endTime, 640 / 12d, 0.715, 640 / 12d, 0.715);

            for (int i = 0; i < 8; i++)
            {
                int y = 480 - 137 + 7;
                const int distance = 78, offset = 45;
                var grass = layBack.CreateSprite("SB\\2dx_17.png", OsbOrigin.BottomCentre);
                grass.Move(startTime, endTime, offset + i * distance, y, offset + i * distance, y);
            }

            var ground = layBack.CreateSprite("SB\\ground.png", OsbOrigin.BottomLeft);
            ground.Move(startTime, endTime, 0, 480, 0, 480);

            const int cloudY = 110, cloudDistance = 25;
            var cloud1 = layBack.CreateSprite("SB\\2dx_10.png", OsbOrigin.Centre, new Vector2(320, cloudY));
            var cloud2 = layBack.CreateSprite("SB\\2dx_11.png", OsbOrigin.Centre, new Vector2(320, cloudY + 40));
            cloud1.MoveX(startTime, endTime, 140, 140 - cloudDistance);
            cloud2.MoveX(startTime, endTime, 580, 580 - cloudDistance);


            StoryboardLayer layFore = GetLayer("Fore");

            const int wtfX = 310, wtfY = 400;
            Vector2[] wtfPos = { new Vector2(wtfX, wtfY), new Vector2(wtfX + 35, wtfY - 74), new Vector2(wtfX + 63, wtfY + 2) };
            foreach (var item in wtfPos)
            {
                var wtf = layFore.CreateSprite("SB\\2dx_12.png");
                wtf.Move(startTime, endTime, item, item);
            }

            var hito = layFore.CreateSprite("SB\\2dx_9.png", OsbOrigin.Centre, new Vector2(327, 199));
            hito.Fade(startTime, endTime, 1, 1);

            var fox = layFore.CreateSprite("SB\\2dx_99.png", OsbOrigin.Centre, new Vector2(435, 248));
            fox.Fade(startTime, endTime, 1, 1);

            var fire1 = layFore.CreateAnimation(@"SB\Ani5\a.png", 2, 200, OsbLoopType.LoopForever);
            const int fire1X = 142, fire1Y = 165;
            fire1.Move(startTime, endTime, fire1X, fire1Y, fire1X, fire1Y);

            var fire2 = layFore.CreateAnimation(@"SB\Ani5\a.png", 2, 180, OsbLoopType.LoopForever);
            const int fire2X = 487, fire2Y = 76;
            fire2.Fade(startTime - 23, 0);
            fire2.Move(startTime, endTime, fire2X, fire2Y, fire2X, fire2Y);
            fire2.Fade(startTime, 1);

            int aniInterval = 160;
            const int aniX = 205, aniY = 80;
            Vector2[] aniPos = { new Vector2(aniX, aniY), new Vector2(aniX + 28, aniY - 35),
                                  new Vector2(aniX + 60, aniY - 55), new Vector2(aniX + 90, aniY - 61),
                                  new Vector2(aniX + 130, aniY -68), new Vector2(aniX + 172, aniY - 37),
                                  new Vector2(aniX + 206, aniY+3 ) };
            bool[] flag = { false, true, true, false, false, true, false };
            for (int i = 0; i < aniPos.Length; i++)
            {

                var ani = layFore.CreateAnimation("SB\\Ani6\\a.png", 2, aniInterval, OsbLoopType.LoopForever);
                ani.Move(startTime, endTime, aniPos[i], aniPos[i]);
                ani.ScaleVec(startTime, 1.2, 1.88);
                if (flag[i]) continue;
                ani.Fade(startTime - aniInterval, 0);
                ani.Fade(startTime, 1);
            }

            const double lightInterval = 100;
            var light1 = layFore.CreateSprite("SB\\2dx_66.png");
            light1.Move(startTime, 280, 196);
            light1.Additive(startTime, endTime);
            light1.StartLoopGroup(startTime, (int)((endTime - startTime) / lightInterval / 2));
            light1.Fade(0, lightInterval, 0.15, 0.3);
            light1.Fade(lightInterval, lightInterval * 2, 0.3, 0.15);
            light1.EndGroup();

            var light2 = layFore.CreateSprite("SB\\2dx_18.png");
            light2.Move(startTime, 412.9, 247.9);
            light2.Additive(startTime, endTime);
            light2.StartLoopGroup(startTime, (int)((endTime - startTime) / lightInterval / 2));
            light2.Fade(0, lightInterval, 0.2, 0.3);
            light2.Fade(lightInterval, lightInterval * 2, 0.3, 0.2);
            light2.EndGroup();

            var eye1 = layFore.CreateSprite("SB\\2dx_82.png", OsbOrigin.Centre, new Vector2(307, 183));
            eye1.Fade(startTime, 1);
            eye1.Fade(endTime, 1);
            var eye2 = layFore.CreateSprite("SB\\2dx_64.png", OsbOrigin.Centre, new Vector2(307, 183));
            var eye3 = layFore.CreateSprite("SB\\2dx_65.png", OsbOrigin.Centre, new Vector2(307, 183));

            int[] winkTime = { 77694, 1, 78854, 1 };
            aniInterval = 130;
            for (int i = 0; i < winkTime.Length - 1; i += 2)
            {
                eye1.Fade(startTime + (winkTime[i] - 77363) + aniInterval * 1, 0);
                eye2.Fade(startTime + (winkTime[i] - 77363) + aniInterval * 1, 1);
                eye2.Fade(startTime + (winkTime[i] - 77363) + aniInterval * 2, 0);
                eye3.Fade(startTime + (winkTime[i] - 77363) + aniInterval * 2, 1);
                eye3.Fade(startTime + (winkTime[i] - 77363) + aniInterval * 3, 0);
                eye2.Fade(startTime + (winkTime[i] - 77363) + aniInterval * 3, 1);
                eye2.Fade(startTime + (winkTime[i] - 77363) + aniInterval * 4, 0);
                eye1.Fade(startTime + (winkTime[i] - 77363) + aniInterval * 4, 1);

            }
            var tear = layFore.CreateSprite("SB\\2dx_23.png", OsbOrigin.TopLeft, new Vector2(335, 200));
            tear.Fade(startTime + 663, startTime + 663 + (1160 - 663) / 2f, 0.5, 1);
            tear.Scale(startTime + 663, startTime + 663 + (1160 - 663) / 2f, 0.5, 1);
            tear.MoveY(startTime + 663 + (1160 - 663) / 2f, startTime + 1160, 198, 201);
            tear.Fade(startTime + 663 + (1160 - 663) / 2f, startTime + 1160, 1, 0);
            var tear2 = layFore.CreateSprite("SB\\2dx_23.png", OsbOrigin.TopLeft, new Vector2(335, 200));
            tear2.Fade(startTime + 1823, startTime + 1823 + (2403 - 1823) / 2f, 0.5, 1);
            tear2.Scale(startTime + 1823, startTime + 1823 + (2403 - 1823) / 2f, 0.5, 1);
            tear2.MoveY(startTime + 1823 + (2403 - 1823) / 2f, startTime + 2403, 198, 201);
            tear2.Fade(startTime + 1823 + (2403 - 1823) / 2f, startTime + 2403, 1, 0);

            // var fox_hand = lay_fore.CreateSprite("SB\\2dx_19.png", OsbOrigin.TopLeft, new Vector2(382, 257));
            // fox_hand.Fade(start_time, start_time + (78440 - 77363), 1, 1);
            var paper = layFore.CreateSprite("SB\\2dx_19.png", OsbOrigin.TopLeft, new Vector2(382, 257));
            paper.Fade(startTime, startTime + (78440 - 77363), 1, 1);
            var paper2 = layFore.CreateSprite("SB\\2dx_20.png");
            paper2.Fade(startTime + (78440 - 77363), startTime + (78689 - 77363), 1, 1);
            paper2.ScaleVec(startTime + (78440 - 77363), startTime + (78689 - 77363), 1, 0.75, 1, 1);
            paper2.Move(startTime + (78440 - 77363), startTime + (78689 - 77363), 392, 267, 389, 257);
            var paper3 = layFore.CreateSprite("SB\\2dx_21.png", OsbOrigin.Centre, new Vector2(382, 255));
            paper3.Fade(startTime + (78689 - 77363), endTime, 1, 1);

            var cover = layFore.CreateSprite("SB\\w.png", OsbOrigin.TopLeft, new Vector2(-5, -5));
            cover.Scale(startTime + (80015 - 77363), endTime, 1.1, 1.1);
            cover.Fade(startTime + (80015 - 77363), endTime, 0, 1);

        }
    }
}
