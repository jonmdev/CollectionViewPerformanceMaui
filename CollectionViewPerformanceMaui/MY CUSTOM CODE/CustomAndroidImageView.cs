#if ANDROID
using Android.Content;
using CollectionViewPerformanceMaui;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Android;
using Android.Graphics;

namespace CollectionViewPerformanceMaui {
    internal class CustomAndroidImageView: Android.Widget.ImageView{
        public CustomAndroidImageView(Context context) : base(context) {
        }

        protected override void DrawableStateChanged() {
            UpdateCounter.addImageDrawStateUpdate(); //does run 
            base.DrawableStateChanged();
        }
        protected override void OnDraw(Canvas canvas) {
            UpdateCounter.addImageDrawUpdate(); //doesn't run in xamarin
            base.OnDraw(canvas);
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) {
            UpdateCounter.addImageMeasureUpdate(this.GetHashCode().ToString());
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
        }
        protected override void OnLayout(bool changed, int left, int top, int right, int bottom) {
            UpdateCounter.addImageLayoutUpdate();
            base.OnLayout(changed, left, top, right, bottom);
        }

    }
}
#endif