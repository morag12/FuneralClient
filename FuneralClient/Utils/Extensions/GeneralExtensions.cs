using FuneralClient.Utils.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace FuneralClient.Utils.Extensions
{
    public static class GeneralExtensions
    {
        public static Color ToColor(this ConfigColor color)
        {
            return new Color(color.R, color.G, color.B);
        }
    }
}
