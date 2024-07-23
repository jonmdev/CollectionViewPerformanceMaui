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
    internal class CustomIOSLabel : MauiLabel {//derives from UILabel
        public CustomIOSLabel() { 
        }
        public override void Draw(CGRect rect) {
            UpdateCounter.addLabelDrawUpdate();
            base.Draw(rect);
        }
        public override void LayoutSubviews() {
            UpdateCounter.addLabelLayoutUpdate();
            base.LayoutSubviews();
        }

    }
}
#endif