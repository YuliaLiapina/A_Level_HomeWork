using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocksLibrary
{

    public enum GenderCategory
    {
        man = 1,
        woman,
        kids
    }
    public static class ListOfSocks
    {
        public static List<Socks> listOfSocks = new List<Socks>();
        public static void addSocks(Socks sock)
        {
            listOfSocks.Add(sock);
        }
    }

    public class Socks
    {

        private Random rndId = new Random();
        public Socks(int countSock, string brandOfSocks, GenderCategory category, int size, string color, string material)
        {
            CountSock = countSock;
            IdNumber = rndId.Next(1, 1000);
            BrandOfSocks = brandOfSocks;
            Category = category;
            Size = size;
            Color = color;
            Material = material;
        }
        public int CountSock { get; }
        public int IdNumber { get; }

        private string _brandOfSocks;
        public string BrandOfSocks
        {
            get
            {
                return _brandOfSocks;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _brandOfSocks = value;
                }
            }
        }

        private int _size;
        public int Size
        {
            get
            {
                return _size;
            }
            private set
            {
                if (value > 0 && value < 50)
                {
                    _size = value;
                }
            }
        }

        public GenderCategory Category { get; }

        public string Material { get; }

        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _color = value;
                }
            }
        }
        public override string ToString()
        {
            char pad = ' ';
            return $"{CountSock} Brand: {BrandOfSocks.ToString().PadRight(12, pad)}\tCategory: {Category.ToString().PadRight(6, pad)}\tSize: {Size.ToString().PadRight(5, pad)}\tColor: {Color.ToString().PadRight(10, pad)}\tMaterial: {Material.ToString().PadRight(10, pad)}\tId: {IdNumber}";
        }









    }
}













