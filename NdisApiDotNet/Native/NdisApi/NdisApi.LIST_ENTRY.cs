﻿// ----------------------------------------------
// <copyright file="NdisApi.LIST_ENTRY.cs" company="NT Kernel">
//    Copyright (c) 2000-2018 NT Kernel Resources / Contributors
//                      All Rights Reserved.
//                    http://www.ntkernel.com
//                      ndisrd@ntkernel.com
// </copyright>
// ----------------------------------------------


using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace NdisApiDotNet.Native
{
    public static partial class NdisApi
    {
        /// <summary>
        /// List entry type.
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct LIST_ENTRY
        {
            internal IntPtr _flink;
            internal IntPtr _blink;

            /// <summary>
            /// Gets or sets the blink.
            /// </summary>
            public IntPtr Blink
            {
                get => _blink;
                set => _blink = value;
            }

            /// <summary>
            /// Gets or sets the flink.
            /// </summary>
            public IntPtr Flink
            {
                get => _flink;
                set => _flink = value;
            }
        }
    }
}