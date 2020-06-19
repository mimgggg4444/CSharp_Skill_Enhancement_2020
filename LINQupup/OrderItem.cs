using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace LINQupup
{
    public class OrderItem
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public uint Quantity { get; set; }
    }
}
