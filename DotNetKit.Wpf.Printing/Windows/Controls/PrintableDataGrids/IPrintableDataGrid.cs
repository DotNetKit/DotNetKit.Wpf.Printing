﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DotNetKit.Windows.Controls
{
    public interface IPrintableDataGrid
    {
        Grid Grid { get; }
        int FrozenRowCount { get; }
        double ActualHeight { get; }
    }
}
