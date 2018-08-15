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
        public int endOffset = 0;
        [Configurable]
        public int EndTime = -1;

        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");

            var Tail1 = lay_fore.CreateSprite(@"SB\2dx_108.png", OsbOrigin.Centre, new Vector2(460, 240));
            Tail1.Move(0, StartTime, StartTime + (6175 - 5926), 460, 410 + 200, 460, 410);
            Tail1.Fade(StartTime + (15374 - 5926), 1);
            Tail1.FlipH(StartTime, StartTime);

            Tail1.StartLoopGroup(StartTime, 24);
            Tail1.ScaleVec(0, 0, 0, 1, 1.2, 1, 1.2);
            Tail1.Rotate(0, 0, 0, 0, 0);
            Tail1.Move(0, 0, 0, 460, 410, 460, 410);

            Tail1.ScaleVec(0, 80, 80, 1, 1.1, 1, 1.1);
            Tail1.Rotate(0, 80, 80, -0.15, -0.15);
            Tail1.Move(0, 80, 80, 450, 410, 450, 410);

            Tail1.ScaleVec(0, 160, 160, 1, 1, 1, 1);
            Tail1.Rotate(0, 160, 160, -0.3, -0.3);
            Tail1.Move(0, 160, 160, 450, 420, 450, 420);

            Tail1.ScaleVec(0, 240, 240, 1, 1.1, 1, 1.1);
            Tail1.Rotate(0, 240, 240, -0.15, -0.15);
            Tail1.Move(0, 240, 240, 450, 410, 450, 410);

            Tail1.ScaleVec(0, 320, 320, 1, 1.15, 1, 1.15);
            Tail1.Rotate(0, 320, 320, -0.075, -0.075);
            Tail1.Move(0, 320, 320, 455, 410, 455, 410);

            Tail1.ScaleVec(0, 400, 400, 1, 1.2, 1, 1.2);
            Tail1.Rotate(0, 400, 400, 0, 0);
            Tail1.Move(0, 400, 400, 460, 410, 460, 410);

            Tail1.EndGroup();
            Tail1.Move(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 460, 410, 460, 410);
            Tail1.ScaleVec(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 1, 1.2, 1, 1.4);
            Tail1.Move(StartTime + (16617 - 5926), StartTime + (16700 - 5926), 460, 410, 460, 405);
            Tail1.Rotate(StartTime + (16617 - 5926), StartTime + (16700 - 5926), 0, 0.1);
            Tail1.ScaleVec(StartTime + (16617 - 5926), StartTime + (17031 - 5926), 1, 1.2, 1, 1.2);
            Tail1.Move(StartTime + (16700 - 5926), StartTime + (16782 - 5926), 460, 405, 460, 410);
            Tail1.Rotate(StartTime + (16700 - 5926), StartTime + (16782 - 5926), 0.1, 0);

            var Tail2 = lay_fore.CreateSprite(@"SB\2dx_108.png", OsbOrigin.Centre, new Vector2(460, 240));
            Tail2.Move(0, StartTime, StartTime + (6175 - 5926), 180, 410 + 200, 180, 410);
            Tail2.Fade(StartTime + (15374 - 5926), 1);

            Tail2.StartLoopGroup(StartTime, 24);
            Tail2.ScaleVec(0, 0, 0, 1, 1.2, 1, 1.2);
            Tail2.Rotate(0, 0, 0, 0, 0);
            Tail2.Move(0, 0, 0, 180, 410, 180, 410);

            Tail2.ScaleVec(0, 80, 80, 1, 1.1, 1, 1.1);
            Tail2.Rotate(0, 80, 80, 0.15, 0.15);
            Tail2.Move(0, 80, 80, 190, 410, 190, 410);

            Tail2.ScaleVec(0, 160, 160, 1, 1, 1, 1);
            Tail2.Rotate(0, 160, 160, 0.3, 0.3);
            Tail2.Move(0, 160, 160, 190, 420, 190, 420);

            Tail2.ScaleVec(0, 240, 240, 1, 1.1, 1, 1.1);
            Tail2.Rotate(0, 240, 240, 0.15, 0.15);
            Tail2.Move(0, 240, 240, 190, 410, 190, 410);

            Tail2.ScaleVec(0, 320, 320, 1, 1.15, 1, 1.15);
            Tail2.Rotate(0, 320, 320, 0.075, 0.075);
            Tail2.Move(0, 320, 320, 185, 410, 185, 410);

            Tail2.ScaleVec(0, 400, 400, 1, 1.2, 1, 1.2);
            Tail2.Rotate(0, 400, 400, 0, 0);
            Tail2.Move(0, 400, 400, 180, 410, 180, 410);

            Tail2.EndGroup();
            Tail2.Move(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 180, 410, 180, 410);
            Tail2.ScaleVec(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 1, 1.2, 1, 1.4);
            Tail2.Move(StartTime + (16617 - 5926), StartTime + (16700 - 5926), 180, 410, 180, 405);
            Tail2.Rotate(StartTime + (16617 - 5926), StartTime + (16700 - 5926), 0, -0.1);
            Tail2.ScaleVec(StartTime + (16617 - 5926), StartTime + (17031 - 5926), 1, 1.2, 1, 1.2);
            Tail2.Move(StartTime + (16700 - 5926), StartTime + (16782 - 5926), 180, 405, 180, 410);
            Tail2.Rotate(StartTime + (16700 - 5926), StartTime + (16782 - 5926), -0.1, 0);

            var Ani1 = lay_fore.CreateAnimation(@"SB\Ani1\a.png", 10, 80, OsbLoopType.LoopForever, OsbOrigin.BottomCentre);
            Ani1.Fade(StartTime + (6175 - 5926), 1);
            Ani1.Move(0, StartTime, StartTime + (6175 - 5926), 480, 480 + 200, 480, 480);
            Ani1.Fade(StartTime + (15374 - 5926), 0);

            Ani1.StartLoopGroup(StartTime, 24);
            Ani1.ScaleVec(0, 0, 0, 1, 1, 1, 1);
            Ani1.ScaleVec(0, 80, 80, 1, 0.95, 1, 0.95);
            Ani1.ScaleVec(0, 160, 160, 1, 0.9, 1, 0.9);
            Ani1.ScaleVec(0, 240, 240, 1, 0.92, 1, 0.92);
            Ani1.ScaleVec(0, 320, 320, 1, 0.95, 1, 0.95);
            Ani1.ScaleVec(0, 400, 400, 1, 1, 1, 1);
            Ani1.EndGroup();

            var Bell1 = lay_fore.CreateSprite(@"SB\2dx_25.png", OsbOrigin.CentreLeft, new Vector2(480, 240));
            Bell1.MoveY(0, StartTime, StartTime + (6175 - 5926), 440 + 200, 440);
            Bell1.Fade(StartTime + (15374 - 5926), 1);

            Bell1.StartLoopGroup(StartTime, 12);
            Bell1.Rotate(0, 0, 0, 2, 2);
            Bell1.Rotate(0, 80, 80, 1.8, 1.8);
            Bell1.Rotate(0, 160, 160, 1.5, 1.5);
            Bell1.Rotate(0, 240, 240, 1, 1);
            Bell1.Rotate(0, 320, 320, 0.7, 0.7);
            Bell1.Rotate(0, 400, 400, 0.3, 0.3);
            Bell1.Rotate(0, 480, 480, 0.7, 0.7);
            Bell1.Rotate(0, 560, 560, 1, 1);
            Bell1.Rotate(0, 640, 640, 1.5, 1.5);
            Bell1.Rotate(0, 720, 720, 1.8, 1.8);
            Bell1.Rotate(0, 800, 800, 2, 2);
            Bell1.EndGroup();

            Bell1.StartLoopGroup(StartTime, 24);
            Bell1.MoveY(0, 0, 0, 440, 440);
            Bell1.MoveY(0, 80, 80, 443, 443);
            Bell1.MoveY(0, 160, 160, 446, 446);
            Bell1.MoveY(0, 240, 240, 446, 446);
            Bell1.MoveY(0, 320, 320, 443, 443);
            Bell1.MoveY(0, 400, 400, 440, 440);
            Bell1.EndGroup();

            var Ani2 = lay_fore.CreateAnimation(@"SB\Ani1\a.png", 10, 80, OsbLoopType.LoopForever, OsbOrigin.BottomCentre);
            Ani2.Fade(StartTime + (6175 - 5926), 1);
            Ani2.Move(0, StartTime, StartTime + (6175 - 5926), 160, 480 + 200, 160, 480);
            Ani2.FlipH(StartTime, StartTime);
            Ani2.Fade(StartTime + (15374 - 5926), 0);

            Ani2.StartLoopGroup(StartTime, 24);
            Ani2.ScaleVec(0, 0, 0, 1, 1, 1, 1);
            Ani2.ScaleVec(0, 80, 80, 1, 0.95, 1, 0.95);
            Ani2.ScaleVec(0, 160, 160, 1, 0.9, 1, 0.9);
            Ani2.ScaleVec(0, 240, 240, 1, 0.92, 1, 0.92);
            Ani2.ScaleVec(0, 320, 320, 1, 0.95, 1, 0.95);
            Ani2.ScaleVec(0, 400, 400, 1, 1, 1, 1);
            Ani2.EndGroup();

            var Bell2 = lay_fore.CreateSprite(@"SB\2dx_24.png", OsbOrigin.CentreLeft, new Vector2(160, 240));
            Bell2.MoveY(0, StartTime, StartTime + (6175 - 5926), 440 + 200, 440);
            Bell2.Fade(StartTime + (15374 - 5926), 1);

            Bell2.StartLoopGroup(StartTime, 12);
            Bell2.Rotate(0, 0, 0, 0.3, 0.3);
            Bell2.Rotate(0, 80, 80, 0.7, 0.7);
            Bell2.Rotate(0, 160, 160, 1, 1);
            Bell2.Rotate(0, 240, 240, 1.5, 1.5);
            Bell2.Rotate(0, 320, 320, 1.8, 1.8);
            Bell2.Rotate(0, 400, 400, 2, 2);
            Bell2.Rotate(0, 480, 480, 1.8, 1.8);
            Bell2.Rotate(0, 560, 560, 1.5, 1.5);
            Bell2.Rotate(0, 640, 640, 1, 1);
            Bell2.Rotate(0, 720, 720, 0.7, 0.7);
            Bell2.Rotate(0, 800, 800, 0.3, 0.3);
            Bell2.EndGroup();

            Bell2.StartLoopGroup(StartTime, 24);
            Bell2.MoveY(0, 0, 0, 440, 440);
            Bell2.MoveY(0, 80, 80, 443, 443);
            Bell2.MoveY(0, 160, 160, 446, 446);
            Bell2.MoveY(0, 240, 240, 446, 446);
            Bell2.MoveY(0, 320, 320, 443, 443);
            Bell2.MoveY(0, 400, 400, 440, 440);

            Bell2.EndGroup();

            var hey1 = lay_fore.CreateSprite(@"SB\Ani2\hey.png", OsbOrigin.BottomCentre);
            hey1.FlipH(StartTime + (16617 - 5926), StartTime + (16617 - 5926));
            hey1.Move(StartTime + (16617 - 5926), StartTime + (17031 - 5926), 160, 480, 160, 480);

            var hey2 = lay_fore.CreateSprite(@"SB\Ani2\hey.png", OsbOrigin.BottomCentre);
            hey2.Move(StartTime + (16617 - 5926), StartTime + (17031 - 5926), 480, 480, 480, 480);

            var Ani1_2 = lay_fore.CreateAnimation(@"SB\Ani2\a.png", 5, 66, OsbLoopType.LoopOnce, OsbOrigin.BottomCentre);
            Ani1_2.Fade(StartTime + (15374 - 5926), 1);
            Ani1_2.FlipH(StartTime + (15374 - 5926), StartTime + (15374 - 5926));
            Ani1_2.Move(StartTime + (15374 - 5926), StartTime + (16617 - 5926), 160, 480, 160, 480);
            Ani1_2.ScaleVec(0, StartTime + (15705 - 5926), StartTime + (16451 - 5926), 1, 1, 1, 1.1);

            var Bell1_2 = lay_fore.CreateSprite(@"SB\2dx_24.png", OsbOrigin.CentreLeft, new Vector2(155, 240));
            Bell1_2.Rotate(StartTime + (15374 - 5926), 1.1);
            Bell1_2.Fade(StartTime + (15374 - 5926), StartTime + (17031 - 5926), 1, 1);
            Bell1_2.MoveY(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 442, 438);
            Bell1_2.MoveY(StartTime + (16617 - 5926), 442);
            Bell1_2.Rotate(OsbEasing.Out, StartTime + (16617 - 5926), StartTime + (16865 - 5926), 1.6, 1.1);

            var Ani2_2 = lay_fore.CreateAnimation(@"SB\Ani2\a.png", 5, 66, OsbLoopType.LoopOnce, OsbOrigin.BottomCentre);
            Ani2_2.Fade(StartTime + (15374 - 5926), 1);
            Ani2_2.Move(StartTime + (15374 - 5926), StartTime + (16617 - 5926), 480, 480, 480, 480);
            Ani2_2.ScaleVec(0, StartTime + (15705 - 5926), StartTime + (16451 - 5926), 1, 1, 1, 1.1);

            var Bell2_2 = lay_fore.CreateSprite(@"SB\2dx_25.png", OsbOrigin.CentreLeft, new Vector2(485, 240));
            Bell2_2.Rotate(StartTime + (15374 - 5926), 1.3);
            Bell2_2.Fade(StartTime + (15374 - 5926), StartTime + (17031 - 5926), 1, 1);
            Bell2_2.MoveY(StartTime + (15705 - 5926), StartTime + (16451 - 5926), 442, 438);
            Bell2_2.MoveY(StartTime + (16617 - 5926), 442);
            Bell2_2.Rotate(OsbEasing.Out, StartTime + (16617 - 5926), StartTime + (16865 - 5926), 0.8, 1.3);

            if (endOffset > 0)
            {
                hey1.Move(StartTime + (17031 - 5926), StartTime + (17031 + endOffset - 5926), 160, 480, 160, 480 + 200);
                hey2.Move(StartTime + (17031 - 5926), StartTime + (17031 + endOffset - 5926), 480, 480, 480, 480 + 200);
                Bell1_2.MoveY(StartTime + (17031 - 5926), StartTime + (17031 + endOffset - 5926), 442, 442 + 200);
                Bell2_2.MoveY(StartTime + (17031 - 5926), StartTime + (17031 + endOffset - 5926), 442, 442 + 200);
                Tail1.Move(StartTime + (17031 - 5926), StartTime + (17031 + endOffset - 5926), 460, 410, 460, 410 + 200);
                Tail2.Move(StartTime + (17031 - 5926), StartTime + (17031 + endOffset - 5926), 180, 410, 180, 410 + 200);

            }
            if (EndTime != -1)
            {
                hey1.Fade(EndTime, 1);
                hey2.Fade(EndTime, 1);
                Bell1_2.Fade(EndTime, 1);
                Bell2_2.Fade(EndTime, 1);
                Tail1.Fade(EndTime, 1);
                Tail2.Fade(EndTime, 1);
            }
        }
    }
}
