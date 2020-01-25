using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicTool
{
    class NoteNames
    {
        public static byte C = 0;
        public static byte CSharp = 1;
        public static byte D = 2;
        public static byte DSharp = 3;
        public static byte E = 4;
        public static byte F = 5;
        public static byte FSharp = 6;
        public static byte G = 7;
        public static byte GSharp = 8;
        public static byte A = 9;
        public static byte ASharp = 10;
        public static byte B = 11;
    }

    class Note
    {
        public byte value;

        public Note(byte n)
        {
            value = (byte)(n % 12);
        }

        public override string ToString()
        {
            string res;
            switch (value % 12)
            {
                case 0:
                    res = "C";
                    break;
                case 1:
                    res = "C#";
                    break;
                case 2:
                    res = "D";
                    break;
                case 3:
                    res = "D#";
                    break;
                case 4:
                    res = "E";
                    break;
                case 5:
                    res = "F";
                    break;
                case 6:
                    res = "F#";
                    break;
                case 7:
                    res = "G";
                    break;
                case 8:
                    res = "G#";
                    break;
                case 9:
                    res = "A";
                    break;
                case 10:
                    res = "A#";
                    break;
                case 11:
                    res = "B";
                    break;
                default:
                    throw new Exception("Invalid internal note value.");
            }
            return res;
        }

        static public Note operator +(Note left, int right)
        {
            return new Note((byte)((left.value + right)%12));
        }

        static public Note operator +(Note left, Note right)
        {
            return new Note((byte)((left.value + right.value) % 12));
        }

    }
}