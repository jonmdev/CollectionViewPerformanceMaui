using Microsoft.Maui.Controls.PlatformConfiguration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerformanceMaui {
    public static class UpdateCounter {
        public static int measureUpdates = 0;
        public static int paintUpdates = 0;
        public static int layoutUpdates = 0;

        public static void addMeasureUpdate(string idCode) {
            measureUpdates++;
            Debug.WriteLine("MEASURE UPDATE " + UpdateCounter.measureUpdates + " ID: " + idCode);
        }
        public static void resetMeasureUpdates() {
            measureUpdates = 0;
        }
        public static void addPaintUpdate() {
            paintUpdates++;
            Debug.WriteLine("PAINT UPDATE " + UpdateCounter.paintUpdates);
        }
        public static void addLayoutUpdate() {
            layoutUpdates++;
            Debug.WriteLine("LAYOUT UPDATE " + UpdateCounter.layoutUpdates);
        }
        public static void resetPaintUpdates() {
            paintUpdates = 0;
        }
    }
}
