﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System;
using osu.Framework.Configuration;
using osu.Framework.Input;

namespace osu.Framework.Graphics.Containers
{
    public class ClickableContainer : Container
    {
        public Action Action;
        public BindableBool Enabled { get; set; } = new BindableBool(true);

        protected override bool OnClick(InputState state)
        {
            if (Enabled.Value)
                Action?.Invoke();
            return true;
        }
    }
}
