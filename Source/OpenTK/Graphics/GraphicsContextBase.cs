﻿#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Platform;

namespace OpenTK.Graphics
{
    // Provides the foundation for all IGraphicsContext implementations.
    abstract class GraphicsContextBase : IGraphicsContext, IGraphicsContextInternal
    {
        #region Fields

        bool disposed;
        
        protected ContextHandle Handle;
        protected GraphicsMode Mode;

        #endregion

        #region IGraphicsContext Members

        public abstract void SwapBuffers();

        public abstract void MakeCurrent(IWindowInfo window);

        public abstract bool IsCurrent { get; }

        public bool IsDisposed
        {
            get { return disposed; }
            protected set { disposed = value; }
        }

        public bool VSync
        {
            get { return SwapInterval > 0; }
            set
            {
                if (value && SwapInterval <= 0)
                    SwapInterval = 1;
                else if (!value && SwapInterval > 0)
                    SwapInterval = 0;
            }
        }

        public abstract int SwapInterval { get; set; }

        public virtual void Update(IWindowInfo window) { }

        public GraphicsMode GraphicsMode { get { return Mode; } }

        public bool ErrorChecking
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        #endregion

        #region IGraphicsContextInternal Members

        public IGraphicsContext Implementation { get { return this; } }

        public abstract void LoadAll();

        public ContextHandle Context { get { return Handle; } }

        // This function is no longer used.
        // The GraphicsContext facade will
        // always call the IntPtr overload.
        public IntPtr GetAddress(string function)
        {
            throw new NotImplementedException();
        }

        public abstract IntPtr GetAddress(IntPtr function);

        #endregion

        #region IDisposable Members

        public abstract void Dispose();

        #endregion
    }
}
