using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 03/27/2016
 */
namespace DragonWarriorTextEditor {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void buttonOpenRom_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file...";
            ofd.Filter = "nes files (*.nes)|*.nes|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK) {
                textBoxFilename.Text = ofd.FileName;

                readRomText();
            }
        }

        private void readRomText() {
            try {
                string path = textBoxFilename.Text;

                Backend backend = new Backend();

        /*        backend.getText(path, textBoxName1, 0xA, 0x61F1, 0);
                backend.getText(path, textBoxName2, 0xA, 0x61FB, 0);
                backend.getText(path, textBoxName3, 0xA, 0x6205, 0);
                backend.getText(path, textBoxName4, 0xA, 0x620F, 0);
                backend.getText(path, textBoxName5, 0xA, 0x6219, 0);
                backend.getText(path, textBoxName6, 0xA, 0x6223, 0);
                backend.getText(path, textBoxName7, 0xA, 0x622D, 0);
                backend.getText(path, textBoxName8, 0xA, 0x6237, 0);

                backend.getText(path, textBoxName9, 0xC, 0x637D, 0); // push start
                backend.getText(path, textBoxName10, 0x6, 0x638C, 0); // spark
                backend.getText(path, textBoxName11, 0x6, 0x6395, 0); // snake
                backend.getText(path, textBoxName12, 0x6, 0x639E, 0); // needle
                backend.getText(path, textBoxName13, 0x3, 0x63AA, 0); // man (spark)
                backend.getText(path, textBoxName14, 0x3, 0x63B3, 0); // man (snake)
                backend.getText(path, textBoxName15, 0x3, 0x63BC, 0); // man (needle)
                backend.getText(path, textBoxName16, 0x6, 0x63C3, 0); // hard
                backend.getText(path, textBoxName17, 0x6, 0x63CC, 0); // top
                backend.getText(path, textBoxName18, 0x3, 0x63D8, 0); // man (hard)
                backend.getText(path, textBoxName19, 0x3, 0x63E1, 0); // man (top)
                backend.getText(path, textBoxName20, 0x6, 0x63E7, 0); // gemini
                backend.getText(path, textBoxName21, 0x6, 0x63F0, 0); // magnet
                backend.getText(path, textBoxName22, 0x6, 0x63F9, 0); // shadow
                backend.getText(path, textBoxName23, 0x3, 0x6405, 0); // man (gemini)
                backend.getText(path, textBoxName24, 0x3, 0x640E, 0); // man (magnet)
                backend.getText(path, textBoxName25, 0x3, 0x6417, 0); // man (shadow) */

                enableMenuItems();
                enableButtons();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enableMenuItems() {
            passwordGameoverToolStripMenuItem.Enabled = true;
            weaponNamesToolStripMenuItem.Enabled = true;
            
            drLightToolStripMenuItem.Enabled = true;
            endingToolStripMenuItem.Enabled = true;
            robotListToolStripMenuItem.Enabled = true;
            creditsToolStripMenuItem.Enabled = true;
            mM3RobotsCreatorsToolStripMenuItem.Enabled = true;
        }

        private void enableButtons() {
            buttonUpdateText.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void disableMenuItems() {
            passwordGameoverToolStripMenuItem.Enabled = false;
            weaponNamesToolStripMenuItem.Enabled = false;
            
            drLightToolStripMenuItem.Enabled = false;
            endingToolStripMenuItem.Enabled = false;
            robotListToolStripMenuItem.Enabled = false;
            creditsToolStripMenuItem.Enabled = false;
            mM3RobotsCreatorsToolStripMenuItem.Enabled = false;
        }

        private void disableButtons() {
            buttonUpdateText.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            disableMenuItems();
            disableButtons();
            setMaxLengthOfTextBoxes();
        }

        private void setMaxLengthOfTextBoxes() {
        /*    textBoxName1.MaxLength = 0xA;
            textBoxName2.MaxLength = 0xA;
            textBoxName3.MaxLength = 0xA;
            textBoxName4.MaxLength = 0xA;
            textBoxName5.MaxLength = 0xA;
            textBoxName6.MaxLength = 0xA;
            textBoxName7.MaxLength = 0xA;
            textBoxName8.MaxLength = 0xA;
            textBoxName9.MaxLength = 0xC;
            textBoxName10.MaxLength = 0x6;
            textBoxName11.MaxLength = 0x6;
            textBoxName12.MaxLength = 0x6;
            textBoxName13.MaxLength = 0x3;
            textBoxName14.MaxLength = 0x3;
            textBoxName15.MaxLength = 0x3;
            textBoxName16.MaxLength = 0x6;
            textBoxName17.MaxLength = 0x6;
            textBoxName18.MaxLength = 0x3;
            textBoxName19.MaxLength = 0x3;
            textBoxName20.MaxLength = 0x6;
            textBoxName21.MaxLength = 0x6;
            textBoxName22.MaxLength = 0x6;
            textBoxName23.MaxLength = 0x3;
            textBoxName24.MaxLength = 0x3;
            textBoxName25.MaxLength = 0x3; */
        }

        // passwordGameoverToolStripMenuItem_Click(object sender, EventArgs e) {
        private void updateTextToolStripMenuItem_Click(object sender, EventArgs e) {
            Form2_pg formPG = new Form2_pg();
            formPG.sendPathToOtherForm = textBoxFilename.Text;
            formPG.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            buttonOpenRom_Click(sender, e);
        }

        private void weaponNamesToolStripMenuItem_Click(object sender, EventArgs e) {
            Form3_wn formWN = new Form3_wn();
            formWN.sendPathToOtherForm = textBoxFilename.Text;
            formWN.ShowDialog();
        }

        private void beginningIntroToolStripMenuItem_Click(object sender, EventArgs e) {
            Form4_bi formBI = new Form4_bi();
            formBI.sendPathToOtherForm = textBoxFilename.Text;
            formBI.ShowDialog();
        }

        private void drLightToolStripMenuItem_Click(object sender, EventArgs e) {
            Form5_dl formDL = new Form5_dl();
            formDL.sendPathToOtherForm = textBoxFilename.Text;
            formDL.ShowDialog();
        }

        private void endingToolStripMenuItem_Click(object sender, EventArgs e) {
            Form6_e formE = new Form6_e();
            formE.sendPathToOtherForm = textBoxFilename.Text;
            formE.ShowDialog();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e) {
            Form7_c formC = new Form7_c();
            formC.sendPathToOtherForm = textBoxFilename.Text;
            formC.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void robotListToolStripMenuItem_Click(object sender, EventArgs e) {
            Form8_rl formRL = new Form8_rl();
            formRL.sendPathToOtherForm = textBoxFilename.Text;
            formRL.ShowDialog();
        }

        private void mM3RobotsCreatorsToolStripMenuItem_Click(object sender, EventArgs e) {
            Form9_rc formRC = new Form9_rc();
            formRC.sendPathToOtherForm = textBoxFilename.Text;
            formRC.ShowDialog();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = textBoxFilename.Text;
                Backend backend = new Backend();

        /*        backend.updateROMText(absoluteFilename, 0xA, textBoxName1, 0x61F1, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxName2, 0x61FB, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxName3, 0x6205, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxName4, 0x620F, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxName5, 0x6219, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxName6, 0x6223, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxName7, 0x622D, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxName8, 0x6237, 0);

                backend.updateROMText(absoluteFilename, 0xC, textBoxName9, 0x637D, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxName10, 0x638C, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxName11, 0x6395, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxName12, 0x639E, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxName13, 0x63AA, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxName14, 0x63B3, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxName15, 0x63BC, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxName16, 0x63C3, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxName17, 0x63CC, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxName18, 0x63D8, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxName19, 0x63E1, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxName20, 0x63E7, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxName21, 0x63F0, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxName22, 0x63F9, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxName23, 0x6405, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxName24, 0x640E, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxName25, 0x6417, 0); */

                MessageBox.Show("Updated Text!", "Mega Man 3 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void text2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11_cc formRC = new Form11_cc();
            formRC.sendPathToOtherForm = textBoxFilename.Text;
            formRC.ShowDialog();
        }

        private void text3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10_rr formRC = new Form10_rr();
            formRC.sendPathToOtherForm = textBoxFilename.Text;
            formRC.ShowDialog();
        }

        private void text4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12_aa formRC = new Form12_aa();
            formRC.sendPathToOtherForm = textBoxFilename.Text;
            formRC.ShowDialog();
        }

        private void text5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13_bb formRC = new Form13_bb();
            formRC.sendPathToOtherForm = textBoxFilename.Text;
            formRC.ShowDialog();
        }

        private void text6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14_dd formRC = new Form14_dd();
            formRC.sendPathToOtherForm = textBoxFilename.Text;
            formRC.ShowDialog();
        }

        private void text7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15_ee formRC = new Form15_ee();
            formRC.sendPathToOtherForm = textBoxFilename.Text;
            formRC.ShowDialog();
        }

        private void text8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16_ff formRC = new Form16_ff();
            formRC.sendPathToOtherForm = textBoxFilename.Text;
            formRC.ShowDialog();
        }

        private void text9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17_gg formRC = new Form17_gg();
            formRC.sendPathToOtherForm = textBoxFilename.Text;
            formRC.ShowDialog();
        }
    }
}
