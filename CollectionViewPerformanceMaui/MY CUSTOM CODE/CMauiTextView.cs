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
    internal class CMauiTextView : MauiTextView {
        public CMauiTextView(Context context) : base(context) {
            this.AddOnLayoutChangeListener(new LayoutListener());
        }

        public override void SetLayerPaint(global::Android.Graphics.Paint paint) {
            UpdateCounter.addPaintUpdate();
            base.SetLayerPaint(paint);
        }
        class LayoutListener : Java.Lang.Object, IOnLayoutChangeListener {
            public void OnLayoutChange(Android.Views.View? v, int left, int top, int right, int bottom, int oldLeft, int oldTop, int oldRight, int oldBottom) {
                UpdateCounter.addLayoutUpdate();
            }
        };

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) {
            UpdateCounter.addMeasureUpdate(this.GetHashCode().ToString());
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
        }
    }
}
#endif