﻿// ----------------------------------------------
// <copyright file="NdisApi.ETH_802_3_FILTER.cs" company="NT Kernel">
//    Copyright (c) 2000-2018 NT Kernel Resources / Contributors
//                      All Rights Reserved.
//                    http://www.ntkernel.com
//                      ndisrd@ntkernel.com
// </copyright>
// ----------------------------------------------


using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace NdisApiDotNet.Native
{
    public static partial class NdisApi
    {
        /// <summary>
        /// Ethernet 802.3 filter type.
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct ETH_802_3_FILTER
        {
            internal ETH_802_3_FLAGS m_ValidFields;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ETHER_ADDR_LENGTH)]
            internal byte[] m_SrcAddress;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ETHER_ADDR_LENGTH)]
            internal byte[] m_DestAddress;
            internal ushort m_Protocol;
            internal ushort _padding;

            /// <summary>
            /// Gets or sets which of the fields below contain valid values and should be matched against the packet.
            /// </summary>
            public ETH_802_3_FLAGS ValidFields
            {
                get => m_ValidFields;
                set => m_ValidFields = value;
            }

            /// <summary>
            /// Gets or sets the source MAC address.
            /// </summary>
            public byte[] SourceAddressBytes
            {
                get => m_SrcAddress;
                set => m_SrcAddress = value;
            }

            /// <summary>
            /// Gets or sets the source MAC address.
            /// </summary>
            public PhysicalAddress SourceAddress
            {
                get => new PhysicalAddress(SourceAddressBytes);
                set => SourceAddressBytes = value.GetAddressBytes();
            }

            /// <summary>
            /// Gets or sets the destination MAC address.
            /// </summary>
            public byte[] DestinationAddressBytes
            {
                get => m_DestAddress;
                set => m_DestAddress = value;
            }

            /// <summary>
            /// Gets or sets the destination MAC address.
            /// </summary>
            public PhysicalAddress DestinationAddress
            {
                get => new PhysicalAddress(DestinationAddressBytes);
                set => DestinationAddressBytes = value.GetAddressBytes();
            }

            /// <summary>
            /// Gets or sets the ether type.
            /// </summary>
            public ushort Protocol
            {
                get => m_Protocol;
                set => m_Protocol = value;
            }

            /// <summary>
            /// Gets or sets the padding.
            /// </summary>
            /// <remarks>This is currently unused.</remarks>
            public ushort Padding
            {
                get => _padding;
                set => _padding = value;
            }
        }
    }
}