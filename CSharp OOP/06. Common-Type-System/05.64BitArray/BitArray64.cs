
namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int this[int index]
        {
            get 
            { 
                if(index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range.");
                }
                return (int)((this.number >> index) & 1);
            }
            set 
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range.");
                }
                if (value == 1)
                {
                    this.number = this.number | ((ulong)1 << index);
                }
                else if (value == 0)
                {
                    this.number = this.number & (~((ulong)1 << index));
                }
                else 
                {
                    throw new ArgumentOutOfRangeException("Bit should be 0 or 1.");
                }
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 other = obj as BitArray64;
            if (other == null)
            {
                return false;
            }
            return this.Number.Equals(other.Number);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + this.Number.GetHashCode();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(BitArray64.Equals(first, second));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i <= 63; i++)
            {
                yield return this[i];
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                if (((this.number >> (63 - i)) & 1) == 1)
                {
                    result.Append(1);
                }
                else
                {
                    result.Append(0);
                }
            }
            return result.ToString();
        }
    }
}
