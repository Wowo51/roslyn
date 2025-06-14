﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualStudio.Text;

namespace Microsoft.CodeAnalysis.Editor;

internal interface IContainedDocument
{
    ITextSnapshot ApplyChanges(IEnumerable<TextChange> changes);
}
