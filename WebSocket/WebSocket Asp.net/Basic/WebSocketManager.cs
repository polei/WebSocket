using System;
using System.Collections.Generic;
using ValueWebSocket.Infrastructure;

namespace WebSocket_Asp.net
{
    public class WebSocketManager
    {
        private static ValueWebSocket.ValueWebSocket webSocket;

        public void Init()
        {
            webSocket = new ValueWebSocket.ValueWebSocket("127.0.0.1", 3000);
            webSocket.Start();
        }

        public void Close()
        {
            webSocket.Dispose();
        }

    }
}