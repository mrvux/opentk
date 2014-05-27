﻿#region License
//
// CL20Generator.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.IO;

namespace Bind.CL
{
    class CL20Generator : CLGenerator
    {
        public CL20Generator(Settings settings, string dirname)
            : base(settings, String.IsNullOrEmpty(dirname) ? "CL20" : dirname)
        {
            Settings.DefaultOutputPath = String.Format(
                Settings.DefaultOutputPath, "Compute", "CL20");
            //Settings.DefaultDocPath = Path.Combine(Settings.DefaultDocPath,
            //    "CL20");

            Settings.DefaultOutputNamespace = "OpenTK.Compute.CL20";
            Settings.DefaultWrappersFile = "CL20.cs";
            Settings.DefaultEnumsFile = "CL20.Enums.cs";
        }
    }
}

