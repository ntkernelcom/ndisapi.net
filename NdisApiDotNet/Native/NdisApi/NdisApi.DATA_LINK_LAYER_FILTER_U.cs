﻿// ----------------------------------------------
// <copyright file="NdisApi.DATA_LINK_LAYER_FILTER_U.cs" company="NT Kernel">
//    Copyright (c) 2000-2018 NT Kernel Resources / Contributors
//                      All Rights Reserved.
//                    http://www.ntkernel.com
//                      ndisrd@ntkernel.com
// </copyright>
// ----------------------------------------------


using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace NdisApiDotNet.Native
{
    public static partial class NdisApi
    {
        /// <summary>
        /// Represents data link layer (OSI-7) filter level.
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DATA_LINK_LAYER_FILTER_U
        {
            internal FILTER_SELECT_FLAGS m_dwUnionSelector;
            internal ETH_802_3_FILTER_U m_Eth8023Filter;

            /// <summary>
            /// Gets or sets the union selector.
            /// Must always be set to <see cref="FILTER_SELECT_FLAGS.ETH_802_3" />.
            /// </summary>
            public FILTER_SELECT_FLAGS Selector
            {
                get => m_dwUnionSelector;
                set => m_dwUnionSelector = value;
            }

            /// <summary>
            /// Gets or sets the eth8023 filter.
            /// </summary>
            public ETH_802_3_FILTER_U Filter
            {
                get => m_Eth8023Filter;
                set => m_Eth8023Filter = value;
            }
        }
    }
}