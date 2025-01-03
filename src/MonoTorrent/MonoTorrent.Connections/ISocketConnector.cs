﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

using ReusableTasks;

namespace MonoTorrent.Connections
{
    public interface ISocketConnector
    {
        public ReusableTask<Socket> ConnectAsync (Uri uri, IPEndPoint? localIpEndpoint, CancellationToken token);
    }
}
