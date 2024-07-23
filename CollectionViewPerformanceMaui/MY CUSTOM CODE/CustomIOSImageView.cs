#if IOS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using CoreGraphics;
using Foundation;

namespace CollectionViewPerformanceMaui {
    internal class CustomIOSImageView : UIImageView { //derives from UIImageView

        public override void Draw(CGRect rect) { //not used
            UpdateCounter.addImageDrawUpdate();
            base.Draw(rect);
        }
        public override void LayoutSubviews() {
            UpdateCounter.addImageLayoutUpdate();
            base.LayoutSubviews();
        }
    }
}
#endif