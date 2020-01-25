using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicTool
{
    class ChordNames
    {
        public static byte Major = 0;
        public static byte Minor = 1;
        public static byte Augmented = 2;
        public static byte Diminished = 3;
        public static byte Major7th = 4;
        public static byte Minor7th = 5;
        public static byte Dominant7th = 6;
        public static byte Minor7flat5 = 7;
        public static byte Diminished7th = 8;
        public static byte MinorMajor7th = 9;
        public static byte Major6th = 10;
        public static byte Minor6th = 11;
        public static byte Suspended4th = 12;
        public static byte Major9th = 13;
        public static byte Minor9th = 14;


    }

    class Chord
    {
        static Random r = new Random((int)System.DateTime.UtcNow.Ticks);

        public string rootName;
        public string chordName;
        public byte degree;
        public byte chordType;
        public bool fitsScale;
        public List<Note> notes;

        public Chord(Note root, byte type, Scale scale = null)
        {
            chordType = type;
            PopulateChord(root, type);
            CheckSuitability(scale);

            for (int i = 0; i < scale.notes.Count; i++)
                if (scale.notes[i].ToString() == root.ToString())
                    degree = (byte)(i+1);
        }

        public Chord(List<Note> n)
        {
            chordType = 0;
            notes = n;

        }

        public bool IsSameAs(Chord c)
        {
            bool same = true;
            bool found;
            foreach (Note n in this.notes)
            {
                found = false;
                foreach (Note t in c.notes)
                {
                    if (n.ToString() == t.ToString()) found = true;
                }
                if (!found) same = false;
            }

            if (c.notes.Count != this.notes.Count) same = false;

            return same;
        }

        void CheckSuitability(Scale scale)
        {
            fitsScale = true;
            bool found;
            foreach (Note cn in notes)
            {
                found = false;
                foreach (Note sn in scale.notes)
                {
                    if (cn.ToString() == sn.ToString()) found = true;
                }
                if (!found) fitsScale = false;
            }


        }

        void PopulateChord(Note root, byte type)
        {
            rootName = root.ToString();
            

            notes = new List<Note>();
            notes.Add(root);

            switch (type)
            {
                case 0:
                    notes.Add(root + 4);
                    notes.Add(root + 7);
                    chordName = "Major";
                    break;
                case 1:
                    notes.Add(root + 3);
                    notes.Add(root + 7);
                    chordName = "Minor";
                    break;
                case 2:
                    notes.Add(root + 3);
                    notes.Add(root + 8);
                    chordName = "Augmented";
                    break;
                case 3:
                    notes.Add(root + 3);
                    notes.Add(root + 6);
                    chordName = "Diminished";
                    break;
                case 4:
                    notes.Add(root + 4);
                    notes.Add(root + 7);
                    notes.Add(root + 11);
                    chordName = "Major 7th";
                    break;
                case 5:
                    notes.Add(root + 3);
                    notes.Add(root + 7);
                    notes.Add(root + 10);
                    chordName = "Minor 7th";
                    break;
                case 6:
                    notes.Add(root + 4);
                    notes.Add(root + 7);
                    notes.Add(root + 10);
                    chordName = "Dominant 7th";
                    break;
                case 7:
                    notes.Add(root + 3);
                    notes.Add(root + 6);
                    notes.Add(root + 10);

                    chordName = "Minor 7th Flat 5th";
                    break;
                case 8:
                    notes.Add(root + 3);
                    notes.Add(root + 6);
                    notes.Add(root + 9);
                    chordName = "Diminished 7th";
                    break;
                case 9:
                    notes.Add(root + 3);
                    notes.Add(root + 7);
                    notes.Add(root + 11);
                    chordName = "Minor Major 7th";
                    break;
                case 10:
                    notes.Add(root + 4);
                    notes.Add(root + 7);
                    notes.Add(root + 9);
                    chordName = "Major 6th";
                    break;
                case 11:
                    notes.Add(root + 3);
                    notes.Add(root + 7);
                    notes.Add(root + 9);
                    chordName = "Minor 6th";
                    break;
                case 12:
                    notes.Add(root + 5);
                    notes.Add(root + 7);
                    chordName = "Suspended 4th";
                    break;
                case 13:
                    notes.Add(root + 4);
                    notes.Add(root + 7);
                    notes.Add(root + 13);
                    chordName = "Major 9th";
                    break;
                case 14:
                    notes.Add(root + 3);
                    notes.Add(root + 7);
                    notes.Add(root + 13);
                    chordName = "Minor 9th";
                    break;
            }
        }

        public override string ToString()
        {
            string res = (degree).ToString() + ": " + rootName + " " + chordName + " (";
            foreach (Note n in notes)
                res += n.ToString();
            return res + ")";
        }

        public Chord GetRandomNext(Scale scale)
        {
            List<Chord> choices = new List<Chord>();
            List<Chord> fittingChoices = new List<Chord>();
            

            if (scale.scaleType == 0)
            {
                
                switch (degree)
                {
                    case 1:
                        foreach (Note n in scale.notes)
                            for (byte i = 0; i<10; i++)
                            {
                                choices.Add(new Chord(n, i, scale));
                            }
                        break;
                    case 2:
                        choices.Add(new Chord(scale.notes[4], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[4], ChordNames.Major7th, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Diminished, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Diminished7th, scale));
                        break;
                    case 3:
                        choices.Add(new Chord(scale.notes[3], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[3], ChordNames.Major7th, scale));
                        choices.Add(new Chord(scale.notes[5], ChordNames.Minor, scale));
                        choices.Add(new Chord(scale.notes[5], ChordNames.Minor7th, scale));
                        break;
                    case 4:
                        choices.Add(new Chord(scale.notes[1], ChordNames.Minor, scale));
                        choices.Add(new Chord(scale.notes[1], ChordNames.Minor7th, scale));
                        choices.Add(new Chord(scale.notes[4], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[4], ChordNames.Major7th, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Diminished, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Diminished7th, scale));
                        break;
                    case 5:
                        choices.Add(new Chord(scale.notes[5], ChordNames.Minor, scale));
                        choices.Add(new Chord(scale.notes[5], ChordNames.Minor7th, scale));
                        break;
                    case 6:
                        choices.Add(new Chord(scale.notes[1], ChordNames.Minor, scale));
                        choices.Add(new Chord(scale.notes[1], ChordNames.Minor7th, scale));
                        choices.Add(new Chord(scale.notes[2], ChordNames.Minor, scale));
                        choices.Add(new Chord(scale.notes[2], ChordNames.Minor7th, scale));
                        choices.Add(new Chord(scale.notes[3], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[3], ChordNames.Major7th, scale));
                        choices.Add(new Chord(scale.notes[4], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[4], ChordNames.Major7th, scale));
                        break;
                    case 7:
                        choices.Add(new Chord(scale.notes[0], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[0], ChordNames.Major7th, scale));
                        break;
                }
            }
            else
            {
                switch (degree)
                {
                    case 1:
                        foreach (Note n in scale.notes)
                            for (byte i = 0; i < 10; i++)
                            {
                                choices.Add(new Chord(n, i, scale));
                            }
                        break;
                    case 2:
                        choices.Add(new Chord(scale.notes[4], ChordNames.Minor, scale));
                        choices.Add(new Chord(scale.notes[4], ChordNames.Minor7th, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Major7th, scale));
                        break;
                    case 3:
                        choices.Add(new Chord(scale.notes[3], ChordNames.Minor, scale));
                        choices.Add(new Chord(scale.notes[3], ChordNames.Minor7th, scale));
                        choices.Add(new Chord(scale.notes[5], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[5], ChordNames.Major7th, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Major7th, scale));
                        break;
                    case 4:
                        choices.Add(new Chord(scale.notes[4], ChordNames.Minor, scale));
                        choices.Add(new Chord(scale.notes[4], ChordNames.Minor7th, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Major7th, scale));
                        break;
                    case 5:
                        choices.Add(new Chord(scale.notes[5], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[5], ChordNames.Major7th, scale));
                        break;
                    case 6:
                        choices.Add(new Chord(scale.notes[2], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[2], ChordNames.Major7th, scale));
                        choices.Add(new Chord(scale.notes[3], ChordNames.Minor, scale));
                        choices.Add(new Chord(scale.notes[3], ChordNames.Minor7th, scale));
                        choices.Add(new Chord(scale.notes[4], ChordNames.Minor, scale));
                        choices.Add(new Chord(scale.notes[4], ChordNames.Minor7th, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Major, scale));
                        choices.Add(new Chord(scale.notes[6], ChordNames.Major7th, scale));
                        break;
                    case 7:
                        choices.Add(new Chord(scale.notes[0], ChordNames.Minor, scale));
                        choices.Add(new Chord(scale.notes[0], ChordNames.Minor7th, scale));
                        break;
                }
            }

            foreach (Chord c in choices)
            {
                if (c.fitsScale)
                    fittingChoices.Add(c);
            }

            return fittingChoices[r.Next(fittingChoices.Count-1)];
        }
    }


}
