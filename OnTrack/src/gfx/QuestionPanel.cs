using System;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace OnTrack.src.gfx
{
    class QuestionPanel : MetroPanel
    {
        public QuestionPanel()
        {
            /**
             *  @note properties to try combat flickering by using a double buffer
             **/
            this.ResizeRedraw = false;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, false);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.Opaque, true);
        }
    }
}
