using System;

namespace EDaemon.Domain.Items
{
    public class Item
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public string? Description { get; set; }
    }
}
