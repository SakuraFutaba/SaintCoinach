﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintCoinach.Text {
    public enum NodeType {
        CloseTag,
        OpenTag,
        DefaultElement,
        EmptyElement,
        GenericElement,
        IfElement,
        StaticValue,
        XivString,
        Comparison,
        Switch,
        Parameter,
        TopLevelParameter,
    }
}
