﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Android.Graphics.Drawables;

namespace RLHelper.Morphemes
{
    class Suffix : Morpheme
    {
        public Suffix(string s, Color c) : base(s, c) { }

        public override void Drow()
        {
            _canvas.DrawRect(new Rect(0, 5, _textWidth, 10), _pt);
        }
    }
}