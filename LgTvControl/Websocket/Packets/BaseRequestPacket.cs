﻿using System.Text.Json.Serialization;

namespace LgTvControl.Websocket.Packets;

public class BaseRequestPacket : BasePacket
{
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}