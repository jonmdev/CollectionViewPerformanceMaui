#if ANDROID
using Android.Content;
using CollectionViewPerformanceMaui;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CollectionViewPerformanceMaui {
    internal class CustomAndroidLabel : MauiTextView {
        public CustomAndroidLabel(Context context) : base(context) {
            this.AddOnLayoutChangeListener(new LayoutListener());
        }

        class LayoutListener : Java.Lang.Object, IOnLayoutChangeListener {
            public void OnLayoutChange(Android.Views.View? v, int left, int top, int right, int bottom, int oldLeft, int oldTop, int oldRight, int oldBottom) {
                UpdateCounter.addLabelLayoutUpdate();
            }
        };
        protected override void OnLayout(bool changed, int left, int top, int right, int bottom) {
            //UpdateCounter.addLabelLayoutUpdate();
            base.OnLayout(changed, left, top, right, bottom);
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) {
            UpdateCounter.addLabelMeasureUpdate(this.GetHashCode().ToString());
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
        }
    }
}
#endif