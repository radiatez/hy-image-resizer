﻿using System;

namespace hy_image_resizer._classes.Extensions
{
    public static partial class API
    {
        public static string ToFileSizeString(this long byteCount, bool spaced = true)
        {
            if (byteCount == 0)
            {
                return spaced ? "0 B" : "0B";
            }
            else
            {
                string[] suffixes = { "B", "Kb", "Mb", "Gb", "Tb", "Pb", "Eb" };
                int place = Convert.ToInt32(Math.Floor(Math.Log(Math.Abs(byteCount), 1024)));
                double number = Math.Round(Math.Abs(byteCount) / Math.Pow(1024, place), 1);
                return (Math.Sign(byteCount) * number).ToString()
                    + (spaced ? " " : "") + suffixes[place];
            }
        }

        public static int ToFlat(this int percentage, int total)
        {
            return Convert.ToInt32(total * (percentage / 100.0));
        }

        public static int ToPercentage(this int flat, int total)
        {
            return Convert.ToInt32(flat * (100.0 / total));
        }

        public static string ToPercentageString(this int flat, int total, bool spaced = true)
        {
            return flat.ToPercentage(total).ToString() + (spaced ? " %" : "%");
        }
    }
}
