using Microsoft.Maui.Controls.PlatformConfiguration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerformanceMaui {
    public static class UpdateCounter {

        //label
        public static int labelMeasureUpdates = 0;
        public static int labelDrawUpdates = 0;
        public static int labelLayoutUpdates = 0;

        //image
        public static int imageMeasureUpdates = 0;
        public static int imageDrawUpdates = 0;
        public static int imageDrawStateUpdates = 0;
        public static int imageLayoutUpdates = 0;

        //label
        public static void addLabelMeasureUpdate(string idCode) {
            labelMeasureUpdates++;
            Debug.WriteLine("LABEL MEASURE UPDATE " + UpdateCounter.labelMeasureUpdates);
            //Debug.WriteLine("LABEL MEASURE UPDATE " + UpdateCounter.labelMeasureUpdates + " ID: " + idCode);
        }
        public static void addLabelDrawUpdate() {
            labelDrawUpdates++;
            Debug.WriteLine("LABEL DRAW UPDATE " + UpdateCounter.labelDrawUpdates);
        }
        public static void addLabelLayoutUpdate() {
            labelLayoutUpdates++;
            Debug.WriteLine("LABEL LAYOUT UPDATE " + UpdateCounter.labelLayoutUpdates);
        }

        //image
        public static void addImageMeasureUpdate(string idCode) {
            imageMeasureUpdates++;
            Debug.WriteLine("IMAGE MEASURE UPDATE " + UpdateCounter.imageMeasureUpdates);
            //Debug.WriteLine("LABEL MEASURE UPDATE " + UpdateCounter.labelMeasureUpdates + " ID: " + idCode);
        }
        public static void addImageDrawUpdate() {
            imageDrawUpdates++;
            Debug.WriteLine("IMAGE DRAW UPDATE " + UpdateCounter.imageDrawUpdates);
        }
        public static void addImageDrawStateUpdate() {
            imageDrawStateUpdates++;
            Debug.WriteLine("IMAGE STATE UPDATE " + UpdateCounter.imageDrawStateUpdates);
        }
        public static void addImageLayoutUpdate() {
            imageLayoutUpdates++;
            Debug.WriteLine("IMAGE LAYOUT UPDATE " + UpdateCounter.imageLayoutUpdates);
        }

        //reset all
        public static void resetCounters() {
            labelMeasureUpdates = 0;
            labelLayoutUpdates = 0;
            labelDrawUpdates = 0;
            imageMeasureUpdates = 0;
            imageDrawUpdates = 0;
            imageDrawStateUpdates = 0;
            imageLayoutUpdates = 0;
        }
    }
}
