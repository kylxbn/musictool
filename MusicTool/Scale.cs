using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicTool
{
    class ScaleNames
    {
        public static byte Major = 0;
        public static byte NaturalMinor = 1;
        public static byte HarmonicMinor = 2;
        public static byte MelodicMinor = 3;
        public static byte Any = 4;
    }

    class Scale
    {
        public List<Note> notes;
        public byte scaleType;
        public Note rootnote;

        public Scale(Note note = null, byte type = 0)
        {
            rootnote = note;

            byte root;
            if (note == null) root = 0;
            else
                root = note.value;

            notes = new List<Note>();
            scaleType = type;

            switch (type)
            {
                case 0:
                    notes.Add(new Note(root));
                    notes.Add(new Note((byte)(root + 2)));
                    notes.Add(new Note((byte)(root + 4)));
                    notes.Add(new Note((byte)(root + 5)));
                    notes.Add(new Note((byte)(root + 7)));
                    notes.Add(new Note((byte)(root + 9)));
                    notes.Add(new Note((byte)(root + 11)));
                    break;
                case 1:
                    notes.Add(new Note(root));
                    notes.Add(new Note((byte)(root + 2)));
                    notes.Add(new Note((byte)(root + 3)));
                    notes.Add(new Note((byte)(root + 5)));
                    notes.Add(new Note((byte)(root + 7)));
                    notes.Add(new Note((byte)(root + 8)));
                    notes.Add(new Note((byte)(root + 10)));
                    break;
                case 2:
                    notes.Add(new Note(root));
                    notes.Add(new Note((byte)(root + 2)));
                    notes.Add(new Note((byte)(root + 3)));
                    notes.Add(new Note((byte)(root + 5)));
                    notes.Add(new Note((byte)(root + 7)));
                    notes.Add(new Note((byte)(root + 8)));
                    notes.Add(new Note((byte)(root + 11)));
                    break;
                case 3:
                    notes.Add(new Note(root));
                    notes.Add(new Note((byte)(root + 2)));
                    notes.Add(new Note((byte)(root + 3)));
                    notes.Add(new Note((byte)(root + 5)));
                    notes.Add(new Note((byte)(root + 7)));
                    notes.Add(new Note((byte)(root + 8)));
                    notes.Add(new Note((byte)(root + 9)));
                    notes.Add(new Note((byte)(root + 10)));
                    notes.Add(new Note((byte)(root + 11)));
                    break;
                case 4:
                    for (byte i = 0; i < 11; i++)
                        notes.Add(new Note((byte)(root + i)));
                    break;
            }
        }
        
        public Scale(byte root = 0, byte type = 0)
        {
            notes = new List<Note>();
            scaleType = type;

            switch (type)
            {
                case 0:
                    notes.Add(new Note(root));
                    notes.Add(new Note((byte)(root + 2)));
                    notes.Add(new Note((byte)(root + 4)));
                    notes.Add(new Note((byte)(root + 5)));
                    notes.Add(new Note((byte)(root + 7)));
                    notes.Add(new Note((byte)(root + 9)));
                    notes.Add(new Note((byte)(root + 11)));
                    break;
                case 1:
                    notes.Add(new Note(root));
                    notes.Add(new Note((byte)(root + 2)));
                    notes.Add(new Note((byte)(root + 3)));
                    notes.Add(new Note((byte)(root + 5)));
                    notes.Add(new Note((byte)(root + 7)));
                    notes.Add(new Note((byte)(root + 8)));
                    notes.Add(new Note((byte)(root + 10)));
                    break;
                case 2:
                    notes.Add(new Note(root));
                    notes.Add(new Note((byte)(root + 2)));
                    notes.Add(new Note((byte)(root + 3)));
                    notes.Add(new Note((byte)(root + 5)));
                    notes.Add(new Note((byte)(root + 7)));
                    notes.Add(new Note((byte)(root + 8)));
                    notes.Add(new Note((byte)(root + 11)));
                    break;
                case 3:
                    notes.Add(new Note(root));
                    notes.Add(new Note((byte)(root + 2)));
                    notes.Add(new Note((byte)(root + 3)));
                    notes.Add(new Note((byte)(root + 5)));
                    notes.Add(new Note((byte)(root + 7)));
                    notes.Add(new Note((byte)(root + 8)));
                    notes.Add(new Note((byte)(root + 9)));
                    notes.Add(new Note((byte)(root + 10)));
                    notes.Add(new Note((byte)(root + 11)));
                    break;
            }
        }

        public bool Contains(Note n)
        {
            bool found = false;
            foreach (Note note in notes)
            {
                if (note.ToString() == n.ToString())
                {
                    found = true;
                    break;
                }
            }

            return found;
        }
    }
}
