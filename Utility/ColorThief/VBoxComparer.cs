﻿using System.Collections.Generic;

namespace BhModule.Community.Pathing.Utility.ColorThief {

    internal class VBoxComparer : IComparer<VBox> {

        public int Compare(VBox x, VBox y) {
            var aCount  = x.Count(false);
            var bCount  = y.Count(false);
            var aVolume = x.Volume(false);
            var bVolume = y.Volume(false);

            // Otherwise sort by products
            var a = aCount * aVolume;
            var b = bCount * bVolume;
            return a < b ? -1 : (a > b ? 1 : 0);
        }

    }

}