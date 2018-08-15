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
    public class CoverScene2 : StoryboardObjectGenerator
    {
        public int startTime = 71893;
        public override void Generate()
        {
            StoryboardLayer lay_fore = GetLayer("Fore");
            var panel_back = lay_fore.CreateSprite(@"SB\panel_back.png");
            panel_back.Fade(startTime + (18854 - 18854), startTime + (19020 - 18854), 0, 1);
            panel_back.Fade(startTime + (24324 - 18854), 1);

            var wom = lay_fore.CreateSprite(@"SB\wom.png", OsbOrigin.Centre, new Vector2(450, 309));
            wom.MoveX(startTime + (73550 - 71893), startTime + (73882 - 71893), 470, 450);
            wom.Fade(startTime + (73550 - 71893), startTime + (73882 - 71893), 0, 1);
            wom.Fade(startTime + (24324 - 18854), 1);

            var womHead = lay_fore.CreateSprite(@"SB\2dx_130.png", OsbOrigin.Centre);
            womHead.MoveY(startTime + (73550 - 71893), 212.5);
            womHead.MoveX(startTime + (73550 - 71893), startTime + (73882 - 71893), 443, 423);
            womHead.Fade(startTime + (73550 - 71893), startTime + (73882 - 71893), 0, 1);
            womHead.Rotate(startTime + (75539 - 71893), startTime + (76037 - 71893), 0, 0.16);
            womHead.MoveX(startTime + (75539 - 71893), startTime + (76037 - 71893), 423, 428);
            womHead.MoveY(startTime + (75539 - 71893), startTime + (76037 - 71893), 212.5, 211);
            womHead.Fade(startTime + (24324 - 18854), 1);

            var man = lay_fore.CreateSprite(@"SB\man.png", OsbOrigin.Centre, new Vector2(288, 244));
            man.Fade(startTime + (18854 - 18854), startTime + (19020 - 18854), 0, 1);
            man.Fade(startTime + (24324 - 18854), 1);


            int ani_interval = 80;
            int smile_time = 75954;

            var womMouth = lay_fore.CreateSprite(@"SB\2dx_35.png", OsbOrigin.Centre, new Vector2(442, 247));
            womMouth.Fade(startTime + (smile_time - 71893), 0);
            womMouth.Rotate(startTime + (smile_time - 71893), 0.1);
            womMouth.ScaleVec(startTime + (smile_time - 71893) + ani_interval * 3 / 4, 0.75, 0.2);
            womMouth.Fade(startTime + (smile_time - 71893) + ani_interval * 3 / 4, 1);
            womMouth.ScaleVec(startTime + (smile_time - 71893) + ani_interval * 3 / 4 * 2, 0.75, 0.7);
            womMouth.Fade(startTime + (smile_time - 71893) + ani_interval * 3 / 4 * 2, 1);
            womMouth.Fade(startTime + (24324 - 18854), 1);



            var panel_border = lay_fore.CreateSprite(@"SB\panel_border.png");
            panel_border.Fade(startTime + (18854 - 18854), startTime + (19020 - 18854), 0, 1);
            panel_border.Fade(startTime + (24324 - 18854), 1);

        }
    }
}
