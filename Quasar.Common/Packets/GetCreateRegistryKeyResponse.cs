﻿using ProtoBuf;
using Quasar.Common.Registry;

namespace Quasar.Common.Packets
{
    [ProtoContract]
    public class GetCreateRegistryKeyResponse : IPacket
    {
        [ProtoMember(1)]
        public string ParentPath { get; set; }

        [ProtoMember(2)]
        public RegSeekerMatch Match { get; set; }

        [ProtoMember(3)]
        public bool IsError { get; set; }

        [ProtoMember(4)]
        public string ErrorMsg { get; set; }
    }
}