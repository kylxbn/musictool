namespace MusicTool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.chk7th = new System.Windows.Forms.CheckBox();
            this.chk9th = new System.Windows.Forms.CheckBox();
            this.chk6th = new System.Windows.Forms.CheckBox();
            this.chk4th = new System.Windows.Forms.CheckBox();
            this.lstChords = new System.Windows.Forms.ListBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.txtProgressionLength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstExtraChords = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstAdLibChords = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstChorusChords = new System.Windows.Forms.ListBox();
            this.lstMainChords = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.possibleChords = new System.Windows.Forms.ListBox();
            this.cna1 = new System.Windows.Forms.ComboBox();
            this.chordNote1 = new System.Windows.Forms.ComboBox();
            this.cna4 = new System.Windows.Forms.ComboBox();
            this.chordNote4 = new System.Windows.Forms.ComboBox();
            this.cna2 = new System.Windows.Forms.ComboBox();
            this.chordNote2 = new System.Windows.Forms.ComboBox();
            this.chkNote4 = new System.Windows.Forms.CheckBox();
            this.chkNote3 = new System.Windows.Forms.CheckBox();
            this.chkNote2 = new System.Windows.Forms.CheckBox();
            this.chkNote1 = new System.Windows.Forms.CheckBox();
            this.cna3 = new System.Windows.Forms.ComboBox();
            this.chordNote3 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmdGuess = new System.Windows.Forms.Button();
            this.lstKeys = new System.Windows.Forms.ListBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkAS = new System.Windows.Forms.CheckBox();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.chkGS = new System.Windows.Forms.CheckBox();
            this.chkG = new System.Windows.Forms.CheckBox();
            this.chkFS = new System.Windows.Forms.CheckBox();
            this.chkF = new System.Windows.Forms.CheckBox();
            this.chkE = new System.Windows.Forms.CheckBox();
            this.chkDS = new System.Windows.Forms.CheckBox();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.chkCS = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.cboKeyScale = new System.Windows.Forms.ComboBox();
            this.cboKeyNoteAccidental = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboKeyNote = new System.Windows.Forms.ComboBox();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Controls.Add(this.tabPage4);
            this.TabControl1.Location = new System.Drawing.Point(15, 33);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(396, 374);
            this.TabControl1.TabIndex = 9;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.chk7th);
            this.TabPage1.Controls.Add(this.chk9th);
            this.TabPage1.Controls.Add(this.chk6th);
            this.TabPage1.Controls.Add(this.chk4th);
            this.TabPage1.Controls.Add(this.lstChords);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.lstNotes);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(388, 348);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Key Info";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // chk7th
            // 
            this.chk7th.AutoSize = true;
            this.chk7th.Location = new System.Drawing.Point(294, 325);
            this.chk7th.Name = "chk7th";
            this.chk7th.Size = new System.Drawing.Size(41, 17);
            this.chk7th.TabIndex = 7;
            this.chk7th.Text = "7th";
            this.chk7th.UseVisualStyleBackColor = true;
            this.chk7th.CheckedChanged += new System.EventHandler(this.chk7th_CheckedChanged);
            // 
            // chk9th
            // 
            this.chk9th.AutoSize = true;
            this.chk9th.Location = new System.Drawing.Point(341, 325);
            this.chk9th.Name = "chk9th";
            this.chk9th.Size = new System.Drawing.Size(41, 17);
            this.chk9th.TabIndex = 6;
            this.chk9th.Text = "9th";
            this.chk9th.UseVisualStyleBackColor = true;
            this.chk9th.CheckedChanged += new System.EventHandler(this.chk9th_CheckedChanged);
            // 
            // chk6th
            // 
            this.chk6th.AutoSize = true;
            this.chk6th.Location = new System.Drawing.Point(247, 325);
            this.chk6th.Name = "chk6th";
            this.chk6th.Size = new System.Drawing.Size(41, 17);
            this.chk6th.TabIndex = 5;
            this.chk6th.Text = "6th";
            this.chk6th.UseVisualStyleBackColor = true;
            this.chk6th.CheckedChanged += new System.EventHandler(this.chk6th_CheckedChanged);
            // 
            // chk4th
            // 
            this.chk4th.AutoSize = true;
            this.chk4th.Location = new System.Drawing.Point(200, 325);
            this.chk4th.Name = "chk4th";
            this.chk4th.Size = new System.Drawing.Size(41, 17);
            this.chk4th.TabIndex = 4;
            this.chk4th.Text = "4th";
            this.chk4th.UseVisualStyleBackColor = true;
            this.chk4th.CheckedChanged += new System.EventHandler(this.chk4th_CheckedChanged);
            // 
            // lstChords
            // 
            this.lstChords.FormattingEnabled = true;
            this.lstChords.Location = new System.Drawing.Point(103, 19);
            this.lstChords.Name = "lstChords";
            this.lstChords.Size = new System.Drawing.Size(279, 303);
            this.lstChords.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(100, 3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(93, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Chords in this key:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Notes in this key:";
            // 
            // lstNotes
            // 
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F",
            "G"});
            this.lstNotes.Location = new System.Drawing.Point(6, 19);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(88, 303);
            this.lstNotes.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.cmdGenerate);
            this.TabPage2.Controls.Add(this.txtProgressionLength);
            this.TabPage2.Controls.Add(this.label8);
            this.TabPage2.Controls.Add(this.label7);
            this.TabPage2.Controls.Add(this.lstExtraChords);
            this.TabPage2.Controls.Add(this.label6);
            this.TabPage2.Controls.Add(this.lstAdLibChords);
            this.TabPage2.Controls.Add(this.label5);
            this.TabPage2.Controls.Add(this.label4);
            this.TabPage2.Controls.Add(this.lstChorusChords);
            this.TabPage2.Controls.Add(this.lstMainChords);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(388, 348);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Chord progression generator";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Location = new System.Drawing.Point(288, 320);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(75, 23);
            this.cmdGenerate.TabIndex = 10;
            this.cmdGenerate.Text = "Generate";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // txtProgressionLength
            // 
            this.txtProgressionLength.Location = new System.Drawing.Point(109, 322);
            this.txtProgressionLength.Name = "txtProgressionLength";
            this.txtProgressionLength.Size = new System.Drawing.Size(71, 20);
            this.txtProgressionLength.TabIndex = 9;
            this.txtProgressionLength.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Progression length:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Extra chords:";
            // 
            // lstExtraChords
            // 
            this.lstExtraChords.FormattingEnabled = true;
            this.lstExtraChords.Location = new System.Drawing.Point(186, 172);
            this.lstExtraChords.Name = "lstExtraChords";
            this.lstExtraChords.Size = new System.Drawing.Size(177, 134);
            this.lstExtraChords.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ad-lib chords:";
            // 
            // lstAdLibChords
            // 
            this.lstAdLibChords.FormattingEnabled = true;
            this.lstAdLibChords.Location = new System.Drawing.Point(3, 172);
            this.lstAdLibChords.Name = "lstAdLibChords";
            this.lstAdLibChords.Size = new System.Drawing.Size(177, 134);
            this.lstAdLibChords.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Chorus chords:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Main chords:";
            // 
            // lstChorusChords
            // 
            this.lstChorusChords.FormattingEnabled = true;
            this.lstChorusChords.Location = new System.Drawing.Point(186, 19);
            this.lstChorusChords.Name = "lstChorusChords";
            this.lstChorusChords.Size = new System.Drawing.Size(177, 134);
            this.lstChorusChords.TabIndex = 1;
            // 
            // lstMainChords
            // 
            this.lstMainChords.FormattingEnabled = true;
            this.lstMainChords.Location = new System.Drawing.Point(3, 19);
            this.lstMainChords.Name = "lstMainChords";
            this.lstMainChords.Size = new System.Drawing.Size(177, 134);
            this.lstMainChords.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.possibleChords);
            this.tabPage3.Controls.Add(this.cna1);
            this.tabPage3.Controls.Add(this.chordNote1);
            this.tabPage3.Controls.Add(this.cna4);
            this.tabPage3.Controls.Add(this.chordNote4);
            this.tabPage3.Controls.Add(this.cna2);
            this.tabPage3.Controls.Add(this.chordNote2);
            this.tabPage3.Controls.Add(this.chkNote4);
            this.tabPage3.Controls.Add(this.chkNote3);
            this.tabPage3.Controls.Add(this.chkNote2);
            this.tabPage3.Controls.Add(this.chkNote1);
            this.tabPage3.Controls.Add(this.cna3);
            this.tabPage3.Controls.Add(this.chordNote3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(388, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chord Guesser";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // possibleChords
            // 
            this.possibleChords.FormattingEnabled = true;
            this.possibleChords.Location = new System.Drawing.Point(3, 114);
            this.possibleChords.Name = "possibleChords";
            this.possibleChords.Size = new System.Drawing.Size(382, 225);
            this.possibleChords.TabIndex = 20;
            // 
            // cna1
            // 
            this.cna1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cna1.FormattingEnabled = true;
            this.cna1.Location = new System.Drawing.Point(132, 3);
            this.cna1.Name = "cna1";
            this.cna1.Size = new System.Drawing.Size(103, 21);
            this.cna1.TabIndex = 19;
            this.cna1.SelectedIndexChanged += new System.EventHandler(this.cna1_SelectedIndexChanged);
            // 
            // chordNote1
            // 
            this.chordNote1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chordNote1.FormattingEnabled = true;
            this.chordNote1.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G",
            "A",
            "B"});
            this.chordNote1.Location = new System.Drawing.Point(67, 3);
            this.chordNote1.Name = "chordNote1";
            this.chordNote1.Size = new System.Drawing.Size(59, 21);
            this.chordNote1.TabIndex = 18;
            this.chordNote1.SelectedIndexChanged += new System.EventHandler(this.chordNote1_SelectedIndexChanged);
            // 
            // cna4
            // 
            this.cna4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cna4.FormattingEnabled = true;
            this.cna4.Location = new System.Drawing.Point(132, 84);
            this.cna4.Name = "cna4";
            this.cna4.Size = new System.Drawing.Size(103, 21);
            this.cna4.TabIndex = 17;
            this.cna4.SelectedIndexChanged += new System.EventHandler(this.cna4_SelectedIndexChanged);
            // 
            // chordNote4
            // 
            this.chordNote4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chordNote4.FormattingEnabled = true;
            this.chordNote4.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G",
            "A",
            "B"});
            this.chordNote4.Location = new System.Drawing.Point(67, 84);
            this.chordNote4.Name = "chordNote4";
            this.chordNote4.Size = new System.Drawing.Size(59, 21);
            this.chordNote4.TabIndex = 16;
            this.chordNote4.SelectedIndexChanged += new System.EventHandler(this.chordNote4_SelectedIndexChanged);
            // 
            // cna2
            // 
            this.cna2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cna2.FormattingEnabled = true;
            this.cna2.Location = new System.Drawing.Point(132, 30);
            this.cna2.Name = "cna2";
            this.cna2.Size = new System.Drawing.Size(103, 21);
            this.cna2.TabIndex = 15;
            this.cna2.SelectedIndexChanged += new System.EventHandler(this.cna2_SelectedIndexChanged);
            // 
            // chordNote2
            // 
            this.chordNote2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chordNote2.FormattingEnabled = true;
            this.chordNote2.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G",
            "A",
            "B"});
            this.chordNote2.Location = new System.Drawing.Point(67, 30);
            this.chordNote2.Name = "chordNote2";
            this.chordNote2.Size = new System.Drawing.Size(59, 21);
            this.chordNote2.TabIndex = 14;
            this.chordNote2.SelectedIndexChanged += new System.EventHandler(this.chordNote2_SelectedIndexChanged);
            // 
            // chkNote4
            // 
            this.chkNote4.AutoSize = true;
            this.chkNote4.Location = new System.Drawing.Point(3, 86);
            this.chkNote4.Name = "chkNote4";
            this.chkNote4.Size = new System.Drawing.Size(58, 17);
            this.chkNote4.TabIndex = 13;
            this.chkNote4.Text = "Note 4";
            this.chkNote4.UseVisualStyleBackColor = true;
            this.chkNote4.CheckedChanged += new System.EventHandler(this.chkNote4_CheckedChanged);
            // 
            // chkNote3
            // 
            this.chkNote3.AutoSize = true;
            this.chkNote3.Location = new System.Drawing.Point(3, 59);
            this.chkNote3.Name = "chkNote3";
            this.chkNote3.Size = new System.Drawing.Size(58, 17);
            this.chkNote3.TabIndex = 12;
            this.chkNote3.Text = "Note 3";
            this.chkNote3.UseVisualStyleBackColor = true;
            this.chkNote3.CheckedChanged += new System.EventHandler(this.chkNote3_CheckedChanged);
            // 
            // chkNote2
            // 
            this.chkNote2.AutoSize = true;
            this.chkNote2.Location = new System.Drawing.Point(3, 32);
            this.chkNote2.Name = "chkNote2";
            this.chkNote2.Size = new System.Drawing.Size(58, 17);
            this.chkNote2.TabIndex = 11;
            this.chkNote2.Text = "Note 2";
            this.chkNote2.UseVisualStyleBackColor = true;
            this.chkNote2.CheckedChanged += new System.EventHandler(this.chkNote2_CheckedChanged);
            // 
            // chkNote1
            // 
            this.chkNote1.AutoSize = true;
            this.chkNote1.Location = new System.Drawing.Point(3, 5);
            this.chkNote1.Name = "chkNote1";
            this.chkNote1.Size = new System.Drawing.Size(58, 17);
            this.chkNote1.TabIndex = 10;
            this.chkNote1.Text = "Note 1";
            this.chkNote1.UseVisualStyleBackColor = true;
            this.chkNote1.CheckedChanged += new System.EventHandler(this.chkNote1_CheckedChanged);
            // 
            // cna3
            // 
            this.cna3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cna3.FormattingEnabled = true;
            this.cna3.Location = new System.Drawing.Point(132, 57);
            this.cna3.Name = "cna3";
            this.cna3.Size = new System.Drawing.Size(103, 21);
            this.cna3.TabIndex = 9;
            this.cna3.SelectedIndexChanged += new System.EventHandler(this.cna3_SelectedIndexChanged);
            // 
            // chordNote3
            // 
            this.chordNote3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chordNote3.FormattingEnabled = true;
            this.chordNote3.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G",
            "A",
            "B"});
            this.chordNote3.Location = new System.Drawing.Point(67, 57);
            this.chordNote3.Name = "chordNote3";
            this.chordNote3.Size = new System.Drawing.Size(59, 21);
            this.chordNote3.TabIndex = 8;
            this.chordNote3.SelectedIndexChanged += new System.EventHandler(this.chordNote3_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmdGuess);
            this.tabPage4.Controls.Add(this.lstKeys);
            this.tabPage4.Controls.Add(this.chkB);
            this.tabPage4.Controls.Add(this.chkAS);
            this.tabPage4.Controls.Add(this.chkA);
            this.tabPage4.Controls.Add(this.chkGS);
            this.tabPage4.Controls.Add(this.chkG);
            this.tabPage4.Controls.Add(this.chkFS);
            this.tabPage4.Controls.Add(this.chkF);
            this.tabPage4.Controls.Add(this.chkE);
            this.tabPage4.Controls.Add(this.chkDS);
            this.tabPage4.Controls.Add(this.chkD);
            this.tabPage4.Controls.Add(this.chkCS);
            this.tabPage4.Controls.Add(this.chkC);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(388, 348);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Key Guesser";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmdGuess
            // 
            this.cmdGuess.Location = new System.Drawing.Point(307, 319);
            this.cmdGuess.Name = "cmdGuess";
            this.cmdGuess.Size = new System.Drawing.Size(75, 23);
            this.cmdGuess.TabIndex = 13;
            this.cmdGuess.Text = "Guess";
            this.cmdGuess.UseVisualStyleBackColor = true;
            this.cmdGuess.Click += new System.EventHandler(this.cmdGuess_Click);
            // 
            // lstKeys
            // 
            this.lstKeys.FormattingEnabled = true;
            this.lstKeys.Location = new System.Drawing.Point(124, 6);
            this.lstKeys.Name = "lstKeys";
            this.lstKeys.Size = new System.Drawing.Size(258, 264);
            this.lstKeys.TabIndex = 12;
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Location = new System.Drawing.Point(6, 259);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(33, 17);
            this.chkB.TabIndex = 11;
            this.chkB.Text = "B";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // chkAS
            // 
            this.chkAS.AutoSize = true;
            this.chkAS.Location = new System.Drawing.Point(6, 236);
            this.chkAS.Name = "chkAS";
            this.chkAS.Size = new System.Drawing.Size(40, 17);
            this.chkAS.TabIndex = 10;
            this.chkAS.Text = "A#";
            this.chkAS.UseVisualStyleBackColor = true;
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Location = new System.Drawing.Point(6, 213);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(33, 17);
            this.chkA.TabIndex = 9;
            this.chkA.Text = "A";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // chkGS
            // 
            this.chkGS.AutoSize = true;
            this.chkGS.Location = new System.Drawing.Point(6, 190);
            this.chkGS.Name = "chkGS";
            this.chkGS.Size = new System.Drawing.Size(41, 17);
            this.chkGS.TabIndex = 8;
            this.chkGS.Text = "G#";
            this.chkGS.UseVisualStyleBackColor = true;
            // 
            // chkG
            // 
            this.chkG.AutoSize = true;
            this.chkG.Location = new System.Drawing.Point(6, 167);
            this.chkG.Name = "chkG";
            this.chkG.Size = new System.Drawing.Size(34, 17);
            this.chkG.TabIndex = 7;
            this.chkG.Text = "G";
            this.chkG.UseVisualStyleBackColor = true;
            // 
            // chkFS
            // 
            this.chkFS.AutoSize = true;
            this.chkFS.Location = new System.Drawing.Point(6, 144);
            this.chkFS.Name = "chkFS";
            this.chkFS.Size = new System.Drawing.Size(39, 17);
            this.chkFS.TabIndex = 6;
            this.chkFS.Text = "F#";
            this.chkFS.UseVisualStyleBackColor = true;
            // 
            // chkF
            // 
            this.chkF.AutoSize = true;
            this.chkF.Location = new System.Drawing.Point(6, 121);
            this.chkF.Name = "chkF";
            this.chkF.Size = new System.Drawing.Size(32, 17);
            this.chkF.TabIndex = 5;
            this.chkF.Text = "F";
            this.chkF.UseVisualStyleBackColor = true;
            // 
            // chkE
            // 
            this.chkE.AutoSize = true;
            this.chkE.Location = new System.Drawing.Point(6, 98);
            this.chkE.Name = "chkE";
            this.chkE.Size = new System.Drawing.Size(33, 17);
            this.chkE.TabIndex = 4;
            this.chkE.Text = "E";
            this.chkE.UseVisualStyleBackColor = true;
            // 
            // chkDS
            // 
            this.chkDS.AutoSize = true;
            this.chkDS.Location = new System.Drawing.Point(6, 75);
            this.chkDS.Name = "chkDS";
            this.chkDS.Size = new System.Drawing.Size(41, 17);
            this.chkDS.TabIndex = 3;
            this.chkDS.Text = "D#";
            this.chkDS.UseVisualStyleBackColor = true;
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Location = new System.Drawing.Point(6, 52);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(34, 17);
            this.chkD.TabIndex = 2;
            this.chkD.Text = "D";
            this.chkD.UseVisualStyleBackColor = true;
            // 
            // chkCS
            // 
            this.chkCS.AutoSize = true;
            this.chkCS.Location = new System.Drawing.Point(6, 29);
            this.chkCS.Name = "chkCS";
            this.chkCS.Size = new System.Drawing.Size(40, 17);
            this.chkCS.TabIndex = 1;
            this.chkCS.Text = "C#";
            this.chkCS.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(6, 6);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(33, 17);
            this.chkC.TabIndex = 0;
            this.chkC.Text = "C";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // cboKeyScale
            // 
            this.cboKeyScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKeyScale.FormattingEnabled = true;
            this.cboKeyScale.Items.AddRange(new object[] {
            "major",
            "natural minor",
            "melodic minor"});
            this.cboKeyScale.Location = new System.Drawing.Point(269, 6);
            this.cboKeyScale.Name = "cboKeyScale";
            this.cboKeyScale.Size = new System.Drawing.Size(138, 21);
            this.cboKeyScale.TabIndex = 8;
            this.cboKeyScale.SelectedIndexChanged += new System.EventHandler(this.cboKeyScale_SelectedIndexChanged);
            // 
            // cboKeyNoteAccidental
            // 
            this.cboKeyNoteAccidental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKeyNoteAccidental.FormattingEnabled = true;
            this.cboKeyNoteAccidental.Location = new System.Drawing.Point(160, 6);
            this.cboKeyNoteAccidental.Name = "cboKeyNoteAccidental";
            this.cboKeyNoteAccidental.Size = new System.Drawing.Size(103, 21);
            this.cboKeyNoteAccidental.TabIndex = 7;
            this.cboKeyNoteAccidental.SelectedIndexChanged += new System.EventHandler(this.cboKeyNoteAccidental_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Key signature:";
            // 
            // cboKeyNote
            // 
            this.cboKeyNote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKeyNote.FormattingEnabled = true;
            this.cboKeyNote.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G",
            "A",
            "B"});
            this.cboKeyNote.Location = new System.Drawing.Point(95, 6);
            this.cboKeyNote.Name = "cboKeyNote";
            this.cboKeyNote.Size = new System.Drawing.Size(59, 21);
            this.cboKeyNote.TabIndex = 5;
            this.cboKeyNote.SelectedIndexChanged += new System.EventHandler(this.cboKeyNote_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 419);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.cboKeyScale);
            this.Controls.Add(this.cboKeyNoteAccidental);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboKeyNote);
            this.Name = "frmMain";
            this.Text = "MusicTool v2.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.ListBox lstChords;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ListBox lstNotes;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.ComboBox cboKeyScale;
        internal System.Windows.Forms.ComboBox cboKeyNoteAccidental;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboKeyNote;
        private System.Windows.Forms.CheckBox chk7th;
        private System.Windows.Forms.CheckBox chk9th;
        private System.Windows.Forms.CheckBox chk6th;
        private System.Windows.Forms.CheckBox chk4th;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.TextBox txtProgressionLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstExtraChords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstAdLibChords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstChorusChords;
        private System.Windows.Forms.ListBox lstMainChords;
        private System.Windows.Forms.TabPage tabPage3;
        internal System.Windows.Forms.ComboBox cna1;
        internal System.Windows.Forms.ComboBox chordNote1;
        internal System.Windows.Forms.ComboBox cna4;
        internal System.Windows.Forms.ComboBox chordNote4;
        internal System.Windows.Forms.ComboBox cna2;
        internal System.Windows.Forms.ComboBox chordNote2;
        private System.Windows.Forms.CheckBox chkNote4;
        private System.Windows.Forms.CheckBox chkNote3;
        private System.Windows.Forms.CheckBox chkNote2;
        private System.Windows.Forms.CheckBox chkNote1;
        internal System.Windows.Forms.ComboBox cna3;
        internal System.Windows.Forms.ComboBox chordNote3;
        private System.Windows.Forms.ListBox possibleChords;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button cmdGuess;
        private System.Windows.Forms.ListBox lstKeys;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkAS;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.CheckBox chkGS;
        private System.Windows.Forms.CheckBox chkG;
        private System.Windows.Forms.CheckBox chkFS;
        private System.Windows.Forms.CheckBox chkF;
        private System.Windows.Forms.CheckBox chkE;
        private System.Windows.Forms.CheckBox chkDS;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.CheckBox chkCS;
        private System.Windows.Forms.CheckBox chkC;
    }
}

