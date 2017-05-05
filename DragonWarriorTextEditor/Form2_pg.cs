using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Form2_pg : Form {

        string path = "";

        public Form2_pg() {
            InitializeComponent();
        }

        public string sendPathToOtherForm {
            get {
                return path;
            }
            set {
                path = value;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x4, textBoxPG1,  0x7E66, 0); //HEAL
                backend.updateROMText(absoluteFilename, 0x4, textBoxPG2,  0x7E6B, 0); //HURT
                backend.updateROMText(absoluteFilename, 0x5, textBoxPG3,  0x7E70, 0); //SLEEP
                backend.updateROMText(absoluteFilename, 0x7, textBoxPG4,  0x7E76, 0); //RADIANT
                backend.updateROMText(absoluteFilename, 0x9, textBoxPG5,  0x7E7E, 0); //STOPSPELL
                backend.updateROMText(absoluteFilename, 0x7, textBoxPG6,  0x7E88, 0); //OUTSIDE
                backend.updateROMText(absoluteFilename, 0x6, textBoxPG7,  0x7E90, 0); //RETURN
                backend.updateROMText(absoluteFilename, 0x5, textBoxPG8,  0x7E97, 0); //REPEL
                backend.updateROMText(absoluteFilename, 0x8, textBoxPG9,  0x7E9D, 0); //HEALMORE
                backend.updateROMText(absoluteFilename, 0x8, textBoxPG10, 0x7EA6, 0); //HURTMORE

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_pg_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxPG1, 0x4,  0x7E66, 0);
                backend.getText(path, textBoxPG2, 0x4,  0x7E6B, 0);
                backend.getText(path, textBoxPG3, 0x5,  0x7E70, 0); // should be "END" but showing "NDZ"
                backend.getText(path, textBoxPG4, 0x7,  0x7E76, 0);
                backend.getText(path, textBoxPG5, 0x9,  0x7E7E, 0); // should be "END" but showing "NDY"
                backend.getText(path, textBoxPG6, 0x7,  0x7E88, 0);
                backend.getText(path, textBoxPG7, 0x6,  0x7E90, 0);
                backend.getText(path, textBoxPG8, 0x5,  0x7E97, 0); // should be "END" but showing "NDW"
                backend.getText(path, textBoxPG9, 0x8,  0x7E9D, 0);
                backend.getText(path, textBoxPG10,0x8,  0x7EA6, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxPG1.MaxLength  = 0x4;
            textBoxPG2.MaxLength  = 0x4;
            textBoxPG3.MaxLength  = 0x5;
            textBoxPG4.MaxLength  = 0x7;
            textBoxPG5.MaxLength  = 0x9;
            textBoxPG6.MaxLength  = 0x7;
            textBoxPG7.MaxLength  = 0x6;
            textBoxPG8.MaxLength  = 0x5;
            textBoxPG9.MaxLength  = 0x8;
            textBoxPG10.MaxLength = 0x8;
        }
    }
}
