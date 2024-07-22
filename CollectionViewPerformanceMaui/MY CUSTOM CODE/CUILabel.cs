using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Platform;

#if IOS
using UIKit;
using CoreGraphics;

namespace CollectionViewPerformanceMaui {
    internal class CUILabel : MauiLabel {
        public CUILabel() {
        }
        public override void Draw(CGRect rect) {
            base.Draw(rect);
            UpdateCounter.addDrawUpdate();
        }
        public override void LayoutSubviews() {
            UpdateCounter.addLayoutUpdate();
            base.LayoutSubviews();
        }

    }
}
#endif