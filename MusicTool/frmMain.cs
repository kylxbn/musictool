using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicTool
{
    public partial class frmMain : Form
    {
        Scale scale;

        public frmMain()
        {
            InitializeComponent();
        }

        private void cboKeyNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboKeyNoteAccidental.Items.Clear();
            cboKeyNoteAccidental.Items.Add("(natural)");
            switch (cboKeyNote.Text)
            {
                case "C":
                case "D":
                case "F":
                case "G":
                case "A":
                    cboKeyNoteAccidental.Items.Add("sharp");
                    break;
            }
            switch (cboKeyNote.Text)
            {
                case "D":
                case "E":
                case "G":
                case "A":
                case "B":
                    cboKeyNoteAccidental.Items.Add("flat");
                    break;
            }
            cboKeyNoteAccidental.SelectedIndex = 0;

            UpdateDisplay();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cboKeyNote.SelectedIndex = 0;
            cboKeyScale.SelectedIndex = 0;
            chordNote1.SelectedIndex = 0;
            chordNote2.SelectedIndex = 0;
            chordNote3.SelectedIndex = 0;
            chordNote4.SelectedIndex = 0;
        }

        private void cboKeyNoteAccidental_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void cboKeyScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            if (cboKeyNote.Text != "")
            {
                if (cboKeyScale.Text != "")
                {
                    UpdateNoteList();
                    UpdateChordList();
                }
            }
        }

        void UpdateNoteList()
        {
            byte root = 0;
            byte scaleType;

            switch (cboKeyNote.Text)
            {
                case "C":
                    root = 0;
                    break;
                case "D":
                    root = 2;
                    break;
                case "E":
                    root = 4;
                    break;
                case "F":
                    root = 5;
                    break;
                case "G":
                    root = 7;
                    break;
                case "A":
                    root = 9;
                    break;
                case "B":
                    root = 11;
                    break;
            }
            if (cboKeyNoteAccidental.Text == "sharp") root++;
            else if (cboKeyNoteAccidental.Text == "flat") root--;

            scaleType = (byte)cboKeyScale.SelectedIndex;

            scale = new Scale(root, scaleType);

            lstNotes.Items.Clear();
            foreach (Note n in scale.notes)
            {
                lstNotes.Items.Add(n.ToString());
            }
        }

        void UpdateChordList()
        {
            Chord c;
            lstChords.Items.Clear();

            foreach (Note n in scale.notes)
                for (byte t = 0; t < 15; t++)
                {
                    c = new Chord(n, t, scale);
                    if (c.fitsScale)
                        if (chk4th.Checked && c.chordName.Contains("4th"))
                            lstChords.Items.Add(c);
                        else if (chk6th.Checked && c.chordName.Contains("6th"))
                            lstChords.Items.Add(c);
                        else if (chk7th.Checked && c.chordName.Contains("7th"))
                            lstChords.Items.Add(c);
                        else if (chk9th.Checked && c.chordName.Contains("9th"))
                            lstChords.Items.Add(c);
                        else
                            if (!c.chordName.Contains("4th"))
                                if (!c.chordName.Contains("6th"))
                                    if (!c.chordName.Contains("7th"))
                                        if (!c.chordName.Contains("9th"))
                                        lstChords.Items.Add(c);
                }
        }

        private void chk4th_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChordList();
        }

        private void chk6th_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChordList();
        }

        private void chk7th_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChordList();
        }

        private void chk9th_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChordList();
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            lstMainChords.Items.Clear();
            lstChorusChords.Items.Clear();
            lstAdLibChords.Items.Clear();
            lstExtraChords.Items.Clear();


            Chord c = new Chord(scale.notes[0], scale.scaleType, scale);
            lstMainChords.Items.Add(c);
            lstExtraChords.Items.Add(c);

            int length = Convert.ToInt32(txtProgressionLength.Text);
            while (lstMainChords.Items.Count < length)
            {
                c = c.GetRandomNext(scale);
                lstMainChords.Items.Add(c);
            }

            while (lstChorusChords.Items.Count < length)
            {
                c = c.GetRandomNext(scale);
                lstChorusChords.Items.Add(c);
            }

            while (lstAdLibChords.Items.Count < length)
            {
                c = c.GetRandomNext(scale);
                lstAdLibChords.Items.Add(c);
            }

            c = (Chord)lstExtraChords.Items[0];
            while (lstExtraChords.Items.Count < length)
            {
                c = c.GetRandomNext(scale);
                lstExtraChords.Items.Add(c);
            }
        }

        private void UpdateGuess()
        {
            List<Note> notes = new List<Note>();
            byte root = 0;
            if (chkNote1.Checked)
            {
                switch (chordNote1.Text)
                {
                    case "C":
                        root = 0;
                        break;
                    case "D":
                        root = 2;
                        break;
                    case "E":
                        root = 4;
                        break;
                    case "F":
                        root = 5;
                        break;
                    case "G":
                        root = 7;
                        break;
                    case "A":
                        root = 9;
                        break;
                    case "B":
                        root = 11;
                        break;
                }
                if (cna1.Text == "sharp") root++;
                else if (cna1.Text == "flat") root--;
                notes.Add(new Note(root));
            }
            if (chkNote2.Checked)
            {
                switch (chordNote2.Text)
                {
                    case "C":
                        root = 0;
                        break;
                    case "D":
                        root = 2;
                        break;
                    case "E":
                        root = 4;
                        break;
                    case "F":
                        root = 5;
                        break;
                    case "G":
                        root = 7;
                        break;
                    case "A":
                        root = 9;
                        break;
                    case "B":
                        root = 11;
                        break;
                }
                if (cna2.Text == "sharp") root++;
                else if (cna2.Text == "flat") root--;
                notes.Add(new Note(root));
            }
            if (chkNote3.Checked)
            {
                switch (chordNote3.Text)
                {
                    case "C":
                        root = 0;
                        break;
                    case "D":
                        root = 2;
                        break;
                    case "E":
                        root = 4;
                        break;
                    case "F":
                        root = 5;
                        break;
                    case "G":
                        root = 7;
                        break;
                    case "A":
                        root = 9;
                        break;
                    case "B":
                        root = 11;
                        break;
                }
                if (cna3.Text == "sharp") root++;
                else if (cna3.Text == "flat") root--;
                notes.Add(new Note(root));
            }
            if (chkNote4.Checked)
            {
                switch (chordNote4.Text)
                {
                    case "C":
                        root = 0;
                        break;
                    case "D":
                        root = 2;
                        break;
                    case "E":
                        root = 4;
                        break;
                    case "F":
                        root = 5;
                        break;
                    case "G":
                        root = 7;
                        break;
                    case "A":
                        root = 9;
                        break;
                    case "B":
                        root = 11;
                        break;
                }
                if (cna4.Text == "sharp") root++;
                else if (cna4.Text == "flat") root--;
                notes.Add(new Note(root));
            }

            Chord cTest, cGot;
            cGot = new Chord(notes);

            possibleChords.Items.Clear();

            foreach (Note n in notes)
            {
                for (byte t = 0; t < 15; t++)
                {
                    cTest = new Chord(n, t, new Scale(0, ScaleNames.Any));
                    if (cTest.IsSameAs(cGot))
                    {
                        possibleChords.Items.Add(cTest.ToString());
                    }
                }
            }
        }

        private void chkNote1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGuess();
        }

        private void chkNote2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGuess();
        }

        private void chkNote3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGuess();
        }

        private void chkNote4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGuess();
        }

        private void chordNote1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cna1.Items.Clear();
            cna1.Items.Add("(natural)");
            switch (chordNote1.Text)
            {
                case "C":
                case "D":
                case "F":
                case "G":
                case "A":
                    cna1.Items.Add("sharp");
                    break;
            }
            switch (chordNote1.Text)
            {
                case "D":
                case "E":
                case "G":
                case "A":
                case "B":
                    cna1.Items.Add("flat");
                    break;
            }
            cna1.SelectedIndex = 0;

            UpdateGuess();
        }

        private void chordNote2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cna2.Items.Clear();
            cna2.Items.Add("(natural)");
            switch (chordNote2.Text)
            {
                case "C":
                case "D":
                case "F":
                case "G":
                case "A":
                    cna2.Items.Add("sharp");
                    break;
            }
            switch (chordNote2.Text)
            {
                case "D":
                case "E":
                case "G":
                case "A":
                case "B":
                    cna2.Items.Add("flat");
                    break;
            }
            cna2.SelectedIndex = 0;
            UpdateGuess();
        }

        private void chordNote3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cna3.Items.Clear();
            cna3.Items.Add("(natural)");
            switch (chordNote3.Text)
            {
                case "C":
                case "D":
                case "F":
                case "G":
                case "A":
                    cna3.Items.Add("sharp");
                    break;
            }
            switch (chordNote3.Text)
            {
                case "D":
                case "E":
                case "G":
                case "A":
                case "B":
                    cna3.Items.Add("flat");
                    break;
            }
            cna3.SelectedIndex = 0;
            UpdateGuess();
        }

        private void chordNote4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cna4.Items.Clear();
            cna4.Items.Add("(natural)");
            switch (chordNote4.Text)
            {
                case "C":
                case "D":
                case "F":
                case "G":
                case "A":
                    cna4.Items.Add("sharp");
                    break;
            }
            switch (chordNote4.Text)
            {
                case "D":
                case "E":
                case "G":
                case "A":
                case "B":
                    cna4.Items.Add("flat");
                    break;
            }
            cna4.SelectedIndex = 0;
            UpdateGuess();
        }

        private void cna1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGuess();
        }

        private void cna2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGuess();
        }

        private void cna3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGuess();
        }

        private void cna4_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGuess();
        }

        private void cmdGuess_Click(object sender, EventArgs e)
        {
            Scale minorscale;
            Scale majorscale;
            Scale harmonicscale;
            Scale melodicscale;

            lstKeys.Items.Clear();

            List<Note> used = new List<Note>();
            if (chkC.Checked) used.Add(new Note(NoteNames.C));
            if (chkCS.Checked) used.Add(new Note(NoteNames.CSharp));
            if (chkD.Checked) used.Add(new Note(NoteNames.D));
            if (chkDS.Checked) used.Add(new Note(NoteNames.DSharp));
            if (chkE.Checked) used.Add(new Note(NoteNames.E));
            if (chkF.Checked) used.Add(new Note(NoteNames.F));
            if (chkFS.Checked) used.Add(new Note(NoteNames.FSharp));
            if (chkG.Checked) used.Add(new Note(NoteNames.G));
            if (chkGS.Checked) used.Add(new Note(NoteNames.GSharp));
            if (chkA.Checked) used.Add(new Note(NoteNames.A));
            if (chkAS.Checked) used.Add(new Note(NoteNames.ASharp));
            if (chkB.Checked) used.Add(new Note(NoteNames.B));

            if (used.Count == 0) return;

            bool minorfound, majorfound, harmonicfound, melodicfound;

            for (int i = 0; i<12; i++)
            {
                minorscale = new Scale((byte)i, ScaleNames.NaturalMinor);
                majorscale = new Scale((byte)i, ScaleNames.Major);
                harmonicscale = new Scale((byte)i, ScaleNames.HarmonicMinor);
                melodicscale = new Scale((byte)i, ScaleNames.MelodicMinor);

                minorfound = true;
                majorfound = true;
                harmonicfound = true;
                melodicfound = true;

                foreach (Note n in used)
                {
                    if (!minorscale.Contains(n)) minorfound = false;
                    if (!majorscale.Contains(n)) majorfound = false;
                    if (!harmonicscale.Contains(n)) harmonicfound = false;
                    if (!melodicscale.Contains(n)) melodicfound = false;
                }

                if (minorfound)
                    lstKeys.Items.Add(new Note((byte)i).ToString() + " minor");
                if (majorfound)
                    lstKeys.Items.Add(new Note((byte)i).ToString() + " major");
                if (harmonicfound)
                    lstKeys.Items.Add(new Note((byte)i).ToString() + " harmonic minor");
                if (melodicfound)
                    lstKeys.Items.Add(new Note((byte)i).ToString() + " melodic minor");
            }
        }
    }
}
