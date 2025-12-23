

using System.Formats.Asn1;
using TravelManagement.Domain.Exceptions;

namespace TravelManagement.Domain.ValueObjects
{
    public record TravelerItem
    {
        private string v1;
        private int v2;
        private uint v;

        public string Name {  get; set; }
        public uint Quantity { get; set; }
        public bool IsTaken { get; set; }
        public TravelerItem(string name, uint quantity, bool isTaken)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new TravelerItemNameException();
            }
            Name = name;
            Quantity = quantity;
            IsTaken = isTaken;
        }

        public TravelerItem(string v1, uint v)
        {
            this.v1 = v1;
            this.v = v;
        }
    }
 }
 



