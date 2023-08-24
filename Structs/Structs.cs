using System.Reflection.Metadata.Ecma335;

namespace troubleshooting
{
    internal class Structs
    {
           
        static void Main(string[] args)
        {
            Digitalsize size = new Digitalsize(60000);
            size = size.Addbit(8);   // 60000 removed   8 printed;
            Console.WriteLine(size.Bit); // 8bit
            Console.WriteLine(size.Byte);// 1 byte
            Console.WriteLine(size.KB);  // 0 KB
            Console.WriteLine(size.MB);  //0 MB
            Console.WriteLine(size.GB);  //0 GB
            Console.WriteLine(size.TB);  //0 TB

        }
        
    }
    struct Digitalsize
    {
        private long bit;
        private const long bitsinBit = 1;
        private const long bitsinByte = 8;
        private const long bitsinKB = bitsinByte*1024;
        private const long bitsinMB =bitsinKB*1024;
        private const long bitsinGB =bitsinMB*1024;
        private const long bitsinTB =bitsinGB*1024;
        public string Bit => $"{(bit / bitsinBit):N0}Bit";
        public string Byte => $"{(bit / bitsinByte):N0}Bit";
        public string KB => $"{(bit / bitsinKB):N0}KB";
        public string MB => $"{(bit / bitsinMB):N0}MB";
        public string GB => $"{(bit / bitsinGB):N0}GB";
        public string TB => $"{(bit / bitsinTB):N0}TB";
        public Digitalsize(long intialvalue)
        {
             this.bit = intialvalue;
        }
        private Digitalsize Add(long value , long scale)
        {
            return new Digitalsize(value * scale);
        }
        public Digitalsize Addbit(long bit)
        {
            return Add(bit, bitsinBit);
        }
        public Digitalsize Addbyte(long bit)
        {
            return Add(bit, bitsinByte);
        }
        public Digitalsize AddKB(long bit)
        {
            return Add(bit, bitsinKB);
        }
        public Digitalsize AddGB(long bit)
        {
            return Add(bit, bitsinMB);
        }
        public Digitalsize AddMB(long bit)
        {
            return Add(bit,bitsinGB);
        }
        public Digitalsize AddTB(long bit)
        {
            return Add(bit, bitsinTB);
        }
    }
}