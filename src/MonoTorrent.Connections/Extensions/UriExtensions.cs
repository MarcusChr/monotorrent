using System;
using System.Net.Sockets;

namespace MonoTorrent.Connections.Extensions
{
    internal static class UriExtensions
    {
        public static AddressFamily ReadAddressFamilyFromUri(this Uri uri)
        {
            var scheme = uri.Scheme;

            return scheme switch {
                "ipv4" => AddressFamily.InterNetwork,
                "ipv6" => AddressFamily.InterNetworkV6,
                _ => throw new NotSupportedException ($"Scheme {scheme} is not supported.")
            };
        }
    }
}
