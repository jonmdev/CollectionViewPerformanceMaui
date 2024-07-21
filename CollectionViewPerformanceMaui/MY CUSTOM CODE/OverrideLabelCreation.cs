using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewPerformanceMaui.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;


namespace CollectionViewPerformanceMaui {
    public static class OverrideLabelCreation {
        public static void overrideLabelCreation() {
#if ANDROID
            LabelHandler.PlatformViewFactory = (handler) => {
                return new CMauiTextView(handler.Context); //Create custom MauiTextView for CLabelHandler
            };
#endif
#if IOS
            LabelHandler.PlatformViewFactory = (handler) => {
                return new CUILabel(); //Create custom MauiTextView for CLabelHandler
            };
#endif

        }
    }
}
