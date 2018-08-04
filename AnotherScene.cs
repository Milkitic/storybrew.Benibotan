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
            int start_time = 77363, end_time = 80843;


            StoryboardLayer lay_back = GetLayer("Back");
            var sky = lay_back.CreateSprite("SB\\2dx_22.png", OsbOrigin.TopLeft);
            sky.Move(start_time, 0, 0);
            sky.ScaleVec(start_time, end_time, 640 / 12d, 0.715, 640 / 12d, 0.715);

            for (int i = 0; i < 8; i++)
            {
                int y = 480 - 137 + 7;
                int distance = 78, offset = 45;
                var grass = lay_back.CreateSprite("SB\\2dx_17.png", OsbOrigin.BottomCentre);
                grass.Move(start_time, end_time, offset + i * distance, y, offset + i * distance, y);
            }

            var ground = lay_back.CreateSprite("SB\\ground.png", OsbOrigin.BottomLeft);
            ground.Move(start_time, end_time, 0, 480, 0, 480);

            int cloud_y = 110, cloud_distance = 25;
            var cloud1 = lay_back.CreateSprite("SB\\2dx_10.png", OsbOrigin.Centre, new Vector2(320, cloud_y));
            var cloud2 = lay_back.CreateSprite("SB\\2dx_11.png", OsbOrigin.Centre, new Vector2(320, cloud_y + 40));
            cloud1.MoveX(start_time, end_time, 140, 140 - cloud_distance);
            cloud2.MoveX(start_time, end_time, 580, 580 - cloud_distance);


            StoryboardLayer lay_fore = GetLayer("Fore");

            int wtf_x = 310, wtf_y = 400;
            Vector2[] wtf_pos = { new Vector2(wtf_x, wtf_y), new Vector2(wtf_x + 35, wtf_y - 74), new Vector2(wtf_x + 63, wtf_y + 2) };
            foreach (var item in wtf_pos)
            {
                var wtf = lay_fore.CreateSprite("SB\\2dx_12.png");
                wtf.Move(start_time, end_time, item, item);
            }

            var hito = lay_fore.CreateSprite("SB\\2dx_9.png", OsbOrigin.Centre, new Vector2(327, 199));
            hito.Fade(start_time, end_time, 1, 1);

            var fox = lay_fore.CreateSprite("SB\\2dx_99.png", OsbOrigin.Centre, new Vector2(435, 248));
            fox.Fade(start_time, end_time, 1, 1);

            var fire1 = lay_fore.CreateAnimation(@"SB\Ani5\a.png", 2, 200, OsbLoopType.LoopForever);
            int fire1_x = 142, fire1_y = 165;
            fire1.Move(start_time, end_time, fire1_x, fire1_y, fire1_x, fire1_y);

            var fire2 = lay_fore.CreateAnimation(@"SB\Ani5\a.png", 2, 180, OsbLoopType.LoopForever);
            int fire2_x = 487, fire2_y = 76;
            fire2.Fade(start_time - 23, 0);
            fire2.Move(start_time, end_time, fire2_x, fire2_y, fire2_x, fire2_y);
            fire2.Fade(start_time, 1);

            int ani_interval = 160;
            int ani_x = 205, ani_y = 80;
            Vector2[] ani_pos = { new Vector2(ani_x, ani_y), new Vector2(ani_x + 28, ani_y - 35),
                                  new Vector2(ani_x + 60, ani_y - 55), new Vector2(ani_x + 90, ani_y - 61),
                                  new Vector2(ani_x + 130, ani_y -68), new Vector2(ani_x + 172, ani_y - 37),
                                  new Vector2(ani_x + 206, ani_y+3 ) };
            bool[] flag = { false, true, true, false, false, true, false };
            for (int i = 0; i < ani_pos.Length; i++)
            {

                var ani = lay_fore.CreateAnimation("SB\\Ani6\\a.png", 2, ani_interval, OsbLoopType.LoopForever, OsbOrigin.Centre);
                ani.Move(start_time, end_time, ani_pos[i], ani_pos[i]);
                ani.ScaleVec(start_time, 1.2, 1.88);
                if (!flag[i])
                {
                    ani.Fade(start_time - ani_interval, 0);
                    ani.Fade(start_time, 1);
                }
            }

            double light_interval = 100;
            var light1 = lay_fore.CreateSprite("SB\\2dx_66.png");
            light1.Move(start_time, 280, 196);
            light1.Additive(start_time, end_time);
            light1.StartLoopGroup(start_time, (int)((end_time - start_time) / light_interval / 2));
            light1.Fade(0, light_interval, 0.15, 0.3);
            light1.Fade(light_interval, light_interval * 2, 0.3, 0.15);
            light1.EndGroup();

            var light2 = lay_fore.CreateSprite("SB\\2dx_18.png");
            light2.Move(start_time, 412.9, 247.9);
            light2.Additive(start_time, end_time);
            light2.StartLoopGroup(start_time, (int)((end_time - start_time) / light_interval / 2));
            light2.Fade(0, light_interval, 0.2, 0.3);
            light2.Fade(light_interval, light_interval * 2, 0.3, 0.2);
            light2.EndGroup();

            var eye1 = lay_fore.CreateSprite("SB\\2dx_82.png", OsbOrigin.Centre, new Vector2(307, 183));
            eye1.Fade(start_time, 1);
            eye1.Fade(end_time, 1);
            var eye2 = lay_fore.CreateSprite("SB\\2dx_64.png", OsbOrigin.Centre, new Vector2(307, 183));
            var eye3 = lay_fore.CreateSprite("SB\\2dx_65.png", OsbOrigin.Centre, new Vector2(307, 183));

            int[] wink_time = { 77694, 1, 78854, 1 };
            ani_interval = 130;
            for (int i = 0; i < wink_time.Length - 1; i += 2)
            {
                eye1.Fade(start_time + (wink_time[i] - 77363) + ani_interval * 1, 0);
                eye2.Fade(start_time + (wink_time[i] - 77363) + ani_interval * 1, 1);
                eye2.Fade(start_time + (wink_time[i] - 77363) + ani_interval * 2, 0);
                eye3.Fade(start_time + (wink_time[i] - 77363) + ani_interval * 2, 1);
                eye3.Fade(start_time + (wink_time[i] - 77363) + ani_interval * 3, 0);
                eye2.Fade(start_time + (wink_time[i] - 77363) + ani_interval * 3, 1);
                eye2.Fade(start_time + (wink_time[i] - 77363) + ani_interval * 4, 0);
                eye1.Fade(start_time + (wink_time[i] - 77363) + ani_interval * 4, 1);

            }
            var tear = lay_fore.CreateSprite("SB\\2dx_23.png", OsbOrigin.TopLeft, new Vector2(335, 200));
            tear.Fade(start_time + 663, start_time + 663 + (1160 - 663) / 2f, 0.5, 1);
            tear.Scale(start_time + 663, start_time + 663 + (1160 - 663) / 2f, 0.5, 1);
            tear.MoveY(start_time + 663 + (1160 - 663) / 2f, start_time + 1160, 198, 201);
            tear.Fade(start_time + 663 + (1160 - 663) / 2f, start_time + 1160, 1, 0);
            var tear2 = lay_fore.CreateSprite("SB\\2dx_23.png", OsbOrigin.TopLeft, new Vector2(335, 200));
            tear2.Fade(start_time + 1823, start_time + 1823 + (2403 - 1823) / 2f, 0.5, 1);
            tear2.Scale(start_time + 1823, start_time + 1823 + (2403 - 1823) / 2f, 0.5, 1);
            tear2.MoveY(start_time + 1823 + (2403 - 1823) / 2f, start_time + 2403, 198, 201);
            tear2.Fade(start_time + 1823 + (2403 - 1823) / 2f, start_time + 2403, 1, 0);

            // var fox_hand = lay_fore.CreateSprite("SB\\2dx_19.png", OsbOrigin.TopLeft, new Vector2(382, 257));
            // fox_hand.Fade(start_time, start_time + (78440 - 77363), 1, 1);
            var paper = lay_fore.CreateSprite("SB\\2dx_19.png", OsbOrigin.TopLeft, new Vector2(382, 257));
            paper.Fade(start_time, start_time + (78440 - 77363), 1, 1);
            var paper2 = lay_fore.CreateSprite("SB\\2dx_20.png");
            paper2.Fade(start_time + (78440 - 77363), start_time + (78689 - 77363), 1, 1);
            paper2.ScaleVec(start_time + (78440 - 77363), start_time + (78689 - 77363), 1, 0.75, 1, 1);
            paper2.Move(start_time + (78440 - 77363), start_time + (78689 - 77363), 392, 267, 389, 257);
            var paper3 = lay_fore.CreateSprite("SB\\2dx_21.png", OsbOrigin.Centre, new Vector2(382, 255));
            paper3.Fade(start_time + (78689 - 77363), end_time, 1, 1);

            var cover = lay_fore.CreateSprite("SB\\w.png", OsbOrigin.TopLeft, new Vector2(-5, -5));
            cover.Scale(start_time + (80015 - 77363), end_time, 1.1, 1.1);
            cover.Fade(start_time + (80015 - 77363), end_time, 0, 1);

        }
    }
}
