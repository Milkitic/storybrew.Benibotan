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
    public class FoxAnimation : StoryboardObjectGenerator
    {

        [Configurable]
        public int StartTime = 5926;
        [Configurable]
        public int EndOffset = 0;
        [Configurable]
        public int EndTime = -1;

        public override void Generate()
        {
            StoryboardLayer layFore = GetLayer("Fore");

            var tail1 = layFore.CreateSprite(@"SB\2dx_108.png", OsbOrigin.Centre, new Vector2(460, 240));
            tail1.Move(0, StartTime, StartTime + (6175 - 5926), 460, 410 + 200, 460, 410);
            tail1.Fade(StartTime + (15374 - 5926), 1);
            tail1.FlipH(StartTime, StartTime);

            tail1.StartLoopGroup(StartTime, 24);
            tail1.ScaleVec(0, 0, 0, 1, 1.2, 1, 1.2);
            tail1.Rotate(0, 0, 0, 0, 0);
            tail1.Move(0, 0, 0, 460, 410, 460, 410);

            tail1.ScaleVec(0, 80, 80, 1, 1.1, 1, 1.1);
            tail1.Rotate(0, 80, 80, -0.15, -0.15);
            tail1.Move(0, 80, 80, 450, 410, 450, 410);

            tail1.ScaleVec(0, 160, 160, 1, 1, 1, 1);
            tail1.Rotate(0, 160, 160, -0.3, -0.3);
            tail1.Move(0, 160, 160, 450, 420, 450, 420);

            tail1.ScaleVec(0, 240, 240, 1, 1.1, 1, 1.1);
            tail1.Rotate(0, 240, 240, -0.15, -0.15);
            tail1.Move(0, 240, 240, 450, 410, 450, 410);

            tail1.ScaleVec(0, 320, 320, 1, 1.15, 1, 1.15);
            tail1.Rotate(0, 320, 320, -0.075, -0.075);
            tail1.Move(0, 320, 320, 455, 410, 455, 410);

            tail1.ScaleVec(0, 400, 400, 1, 1.2, 1, 1.2);
            tail1.Rotate(0, 400, 400, 0, 0);
            tail1.Move(0, 400, 400, 460, 410, 460, 410);

            tail1.EndGroup();
            tail1.Move(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 460, 410, 460, 410);
            tail1.ScaleVec(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 1, 1.2, 1, 1.4);
            tail1.Move(StartTime + (16617 - 5926), StartTime + (16700 - 5926), 460, 410, 460, 405);
            tail1.Rotate(StartTime + (16617 - 5926), StartTime + (16700 - 5926), 0, 0.1);
            tail1.ScaleVec(StartTime + (16617 - 5926), StartTime + (17031 - 5926), 1, 1.2, 1, 1.2);
            tail1.Move(StartTime + (16700 - 5926), StartTime + (16782 - 5926), 460, 405, 460, 410);
            tail1.Rotate(StartTime + (16700 - 5926), StartTime + (16782 - 5926), 0.1, 0);

            var tail2 = layFore.CreateSprite(@"SB\2dx_108.png", OsbOrigin.Centre, new Vector2(460, 240));
            tail2.Move(0, StartTime, StartTime + (6175 - 5926), 180, 410 + 200, 180, 410);
            tail2.Fade(StartTime + (15374 - 5926), 1);

            tail2.StartLoopGroup(StartTime, 24);
            tail2.ScaleVec(0, 0, 0, 1, 1.2, 1, 1.2);
            tail2.Rotate(0, 0, 0, 0, 0);
            tail2.Move(0, 0, 0, 180, 410, 180, 410);

            tail2.ScaleVec(0, 80, 80, 1, 1.1, 1, 1.1);
            tail2.Rotate(0, 80, 80, 0.15, 0.15);
            tail2.Move(0, 80, 80, 190, 410, 190, 410);

            tail2.ScaleVec(0, 160, 160, 1, 1, 1, 1);
            tail2.Rotate(0, 160, 160, 0.3, 0.3);
            tail2.Move(0, 160, 160, 190, 420, 190, 420);

            tail2.ScaleVec(0, 240, 240, 1, 1.1, 1, 1.1);
            tail2.Rotate(0, 240, 240, 0.15, 0.15);
            tail2.Move(0, 240, 240, 190, 410, 190, 410);

            tail2.ScaleVec(0, 320, 320, 1, 1.15, 1, 1.15);
            tail2.Rotate(0, 320, 320, 0.075, 0.075);
            tail2.Move(0, 320, 320, 185, 410, 185, 410);

            tail2.ScaleVec(0, 400, 400, 1, 1.2, 1, 1.2);
            tail2.Rotate(0, 400, 400, 0, 0);
            tail2.Move(0, 400, 400, 180, 410, 180, 410);

            tail2.EndGroup();
            tail2.Move(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 180, 410, 180, 410);
            tail2.ScaleVec(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 1, 1.2, 1, 1.4);
            tail2.Move(StartTime + (16617 - 5926), StartTime + (16700 - 5926), 180, 410, 180, 405);
            tail2.Rotate(StartTime + (16617 - 5926), StartTime + (16700 - 5926), 0, -0.1);
            tail2.ScaleVec(StartTime + (16617 - 5926), StartTime + (17031 - 5926), 1, 1.2, 1, 1.2);
            tail2.Move(StartTime + (16700 - 5926), StartTime + (16782 - 5926), 180, 405, 180, 410);
            tail2.Rotate(StartTime + (16700 - 5926), StartTime + (16782 - 5926), -0.1, 0);

            var ani1 = layFore.CreateAnimation(@"SB\Ani1\a.png", 10, 80, OsbLoopType.LoopForever, OsbOrigin.BottomCentre);
            ani1.Fade(StartTime + (6175 - 5926), 1);
            ani1.Move(0, StartTime, StartTime + (6175 - 5926), 480, 480 + 200, 480, 480);
            ani1.Fade(StartTime + (15374 - 5926), 0);

            ani1.StartLoopGroup(StartTime, 24);
            ani1.ScaleVec(0, 0, 0, 1, 1, 1, 1);
            ani1.ScaleVec(0, 80, 80, 1, 0.95, 1, 0.95);
            ani1.ScaleVec(0, 160, 160, 1, 0.9, 1, 0.9);
            ani1.ScaleVec(0, 240, 240, 1, 0.92, 1, 0.92);
            ani1.ScaleVec(0, 320, 320, 1, 0.95, 1, 0.95);
            ani1.ScaleVec(0, 400, 400, 1, 1, 1, 1);
            ani1.EndGroup();

            var bell1 = layFore.CreateSprite(@"SB\2dx_25.png", OsbOrigin.CentreLeft, new Vector2(480, 240));
            bell1.MoveY(0, StartTime, StartTime + (6175 - 5926), 440 + 200, 440);
            bell1.Fade(StartTime + (15374 - 5926), 1);

            bell1.StartLoopGroup(StartTime, 12);
            bell1.Rotate(0, 0, 0, 2, 2);
            bell1.Rotate(0, 80, 80, 1.8, 1.8);
            bell1.Rotate(0, 160, 160, 1.5, 1.5);
            bell1.Rotate(0, 240, 240, 1, 1);
            bell1.Rotate(0, 320, 320, 0.7, 0.7);
            bell1.Rotate(0, 400, 400, 0.3, 0.3);
            bell1.Rotate(0, 480, 480, 0.7, 0.7);
            bell1.Rotate(0, 560, 560, 1, 1);
            bell1.Rotate(0, 640, 640, 1.5, 1.5);
            bell1.Rotate(0, 720, 720, 1.8, 1.8);
            bell1.Rotate(0, 800, 800, 2, 2);
            bell1.EndGroup();

            bell1.StartLoopGroup(StartTime, 24);
            bell1.MoveY(0, 0, 0, 440, 440);
            bell1.MoveY(0, 80, 80, 443, 443);
            bell1.MoveY(0, 160, 160, 446, 446);
            bell1.MoveY(0, 240, 240, 446, 446);
            bell1.MoveY(0, 320, 320, 443, 443);
            bell1.MoveY(0, 400, 400, 440, 440);
            bell1.EndGroup();

            var ani2 = layFore.CreateAnimation(@"SB\Ani1\a.png", 10, 80, OsbLoopType.LoopForever, OsbOrigin.BottomCentre);
            ani2.Fade(StartTime + (6175 - 5926), 1);
            ani2.Move(0, StartTime, StartTime + (6175 - 5926), 160, 480 + 200, 160, 480);
            ani2.FlipH(StartTime, StartTime);
            ani2.Fade(StartTime + (15374 - 5926), 0);

            ani2.StartLoopGroup(StartTime, 24);
            ani2.ScaleVec(0, 0, 0, 1, 1, 1, 1);
            ani2.ScaleVec(0, 80, 80, 1, 0.95, 1, 0.95);
            ani2.ScaleVec(0, 160, 160, 1, 0.9, 1, 0.9);
            ani2.ScaleVec(0, 240, 240, 1, 0.92, 1, 0.92);
            ani2.ScaleVec(0, 320, 320, 1, 0.95, 1, 0.95);
            ani2.ScaleVec(0, 400, 400, 1, 1, 1, 1);
            ani2.EndGroup();

            var bell2 = layFore.CreateSprite(@"SB\2dx_24.png", OsbOrigin.CentreLeft, new Vector2(160, 240));
            bell2.MoveY(0, StartTime, StartTime + (6175 - 5926), 440 + 200, 440);
            bell2.Fade(StartTime + (15374 - 5926), 1);

            bell2.StartLoopGroup(StartTime, 12);
            bell2.Rotate(0, 0, 0, 0.3, 0.3);
            bell2.Rotate(0, 80, 80, 0.7, 0.7);
            bell2.Rotate(0, 160, 160, 1, 1);
            bell2.Rotate(0, 240, 240, 1.5, 1.5);
            bell2.Rotate(0, 320, 320, 1.8, 1.8);
            bell2.Rotate(0, 400, 400, 2, 2);
            bell2.Rotate(0, 480, 480, 1.8, 1.8);
            bell2.Rotate(0, 560, 560, 1.5, 1.5);
            bell2.Rotate(0, 640, 640, 1, 1);
            bell2.Rotate(0, 720, 720, 0.7, 0.7);
            bell2.Rotate(0, 800, 800, 0.3, 0.3);
            bell2.EndGroup();

            bell2.StartLoopGroup(StartTime, 24);
            bell2.MoveY(0, 0, 0, 440, 440);
            bell2.MoveY(0, 80, 80, 443, 443);
            bell2.MoveY(0, 160, 160, 446, 446);
            bell2.MoveY(0, 240, 240, 446, 446);
            bell2.MoveY(0, 320, 320, 443, 443);
            bell2.MoveY(0, 400, 400, 440, 440);

            bell2.EndGroup();

            var hey1 = layFore.CreateSprite(@"SB\Ani2\hey.png", OsbOrigin.BottomCentre);
            hey1.FlipH(StartTime + (16617 - 5926), StartTime + (16617 - 5926));
            hey1.Move(StartTime + (16617 - 5926), StartTime + (17031 - 5926), 160, 480, 160, 480);

            var hey2 = layFore.CreateSprite(@"SB\Ani2\hey.png", OsbOrigin.BottomCentre);
            hey2.Move(StartTime + (16617 - 5926), StartTime + (17031 - 5926), 480, 480, 480, 480);

            var ani12 = layFore.CreateAnimation(@"SB\Ani2\a.png", 5, 66, OsbLoopType.LoopOnce, OsbOrigin.BottomCentre);
            ani12.Fade(StartTime + (15374 - 5926), 1);
            ani12.FlipH(StartTime + (15374 - 5926), StartTime + (15374 - 5926));
            ani12.Move(StartTime + (15374 - 5926), StartTime + (16617 - 5926), 160, 480, 160, 480);
            ani12.ScaleVec(0, StartTime + (15705 - 5926), StartTime + (16451 - 5926), 1, 1, 1, 1.1);

            var bell12 = layFore.CreateSprite(@"SB\2dx_24.png", OsbOrigin.CentreLeft, new Vector2(155, 240));
            bell12.Rotate(StartTime + (15374 - 5926), 1.1);
            bell12.Fade(StartTime + (15374 - 5926), StartTime + (17031 - 5926), 1, 1);
            bell12.MoveY(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 442, 438);
            bell12.MoveY(StartTime + (16617 - 5926), 442);
            bell12.Rotate(OsbEasing.Out, StartTime + (16617 - 5926), StartTime + (16865 - 5926), 1.6, 1.1);

            var ani22 = layFore.CreateAnimation(@"SB\Ani2\a.png", 5, 66, OsbLoopType.LoopOnce, OsbOrigin.BottomCentre);
            ani22.Fade(StartTime + (15374 - 5926), 1);
            ani22.Move(StartTime + (15374 - 5926), StartTime + (16617 - 5926), 480, 480, 480, 480);
            ani22.ScaleVec(0, StartTime + (15705 - 5926), StartTime + (16451 - 5926), 1, 1, 1, 1.1);

            var bell22 = layFore.CreateSprite(@"SB\2dx_25.png", OsbOrigin.CentreLeft, new Vector2(485, 240));
            bell22.Rotate(StartTime + (15374 - 5926), 1.3);
            bell22.Fade(StartTime + (15374 - 5926), StartTime + (17031 - 5926), 1, 1);
            bell22.MoveY(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 442, 438);
            bell22.MoveY(StartTime + (16617 - 5926), 442);
            bell22.Rotate(OsbEasing.Out, StartTime + (16617 - 5926), StartTime + (16865 - 5926), 0.8, 1.3);

            if (EndOffset > 0)
            {
                hey1.Move(StartTime + (17031 - 5926), StartTime + (17031 + EndOffset - 5926), 160, 480, 160, 480 + 200);
                hey2.Move(StartTime + (17031 - 5926), StartTime + (17031 + EndOffset - 5926), 480, 480, 480, 480 + 200);
                bell12.MoveY(StartTime + (17031 - 5926), StartTime + (17031 + EndOffset - 5926), 442, 442 + 200);
                bell22.MoveY(StartTime + (17031 - 5926), StartTime + (17031 + EndOffset - 5926), 442, 442 + 200);
                tail1.Move(StartTime + (17031 - 5926), StartTime + (17031 + EndOffset - 5926), 460, 410, 460, 410 + 200);
                tail2.Move(StartTime + (17031 - 5926), StartTime + (17031 + EndOffset - 5926), 180, 410, 180, 410 + 200);

            }
            if (EndTime != -1)
            {
                hey1.Fade(EndTime, 1);
                hey2.Fade(EndTime, 1);
                bell12.Fade(EndTime, 1);
                bell22.Fade(EndTime, 1);
                tail1.Fade(EndTime, 1);
                tail2.Fade(EndTime, 1);
            }
        }
    }
}
