using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewPerformanceMaui.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;


namespace CollectionViewPerformanceMaui {
    public static class OverrideClassCreation {
        public static void overrideLabelCreation() {
#if ANDROID
            LabelHandler.PlatformViewFactory = (handler) => {
                return new CustomAndroidLabel(handler.Context); //Create custom MauiTextView for CLabelHandler
            };
#endif
#if IOS
            LabelHandler.PlatformViewFactory = (handler) => {
                return new CustomIOSLabel(); //Create custom MauiTextView for CLabelHandler
            };
#endif

        }

        public static void overrideImageCreation() {
#if ANDROID
            ImageHandler.PlatformViewFactory = (handler) => {
                return new CustomAndroidImageView(handler.Context); //Create custom MauiTextView for CLabelHandler
            };
#endif
#if IOS
            ImageHandler.PlatformViewFactory = (handler) => {
                return new CustomIOSImageView(); //Create custom MauiTextView for CLabelHandler
            };
#endif

        }
    }
    
}
