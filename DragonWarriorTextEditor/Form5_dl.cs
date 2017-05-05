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
    public partial class Form5_dl : Form {

        string path = "";

        public Form5_dl() {
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

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x7,  textBoxDL1,  0x706B, 1); //COMMAND
                backend.updateROMText(absoluteFilename, 0x4,  textBoxDL2,  0x7074, 1); //TALK
                backend.updateROMText(absoluteFilename, 0x5,  textBoxDL3,  0x7079, 1); //SPELL
                backend.updateROMText(absoluteFilename, 0x6,  textBoxDL4,  0x707F, 1); //STATUS
                backend.updateROMText(absoluteFilename, 0x4,  textBoxDL5,  0x7086, 1); //ITEM
                backend.updateROMText(absoluteFilename, 0x6,  textBoxDL6,  0x708C, 1); //STAIRS
                backend.updateROMText(absoluteFilename, 0x4,  textBoxDL7,  0x7093, 1); //DOOR
                backend.updateROMText(absoluteFilename, 0x6,  textBoxDL8,  0x7099, 1); //SEARCH
                backend.updateROMText(absoluteFilename, 0x4,  textBoxDL9,  0x70A0, 1); //TAKE
                backend.updateROMText(absoluteFilename, 0x4,  textBoxDL10, 0x6FDD, 1); //NAME
                backend.updateROMText(absoluteFilename, 0x8,  textBoxDL11, 0x6FE5, 1); //STRENGTH
                backend.updateROMText(absoluteFilename, 0x7,  textBoxDL12, 0x6FF1, 1); //AGILITY
                backend.updateROMText(absoluteFilename, 0x7,  textBoxDL13, 0x6FFC, 1); //MAXIMUM
                backend.updateROMText(absoluteFilename, 0x2,  textBoxDL14, 0x7004, 1); //HP
                backend.updateROMText(absoluteFilename, 0x7,  textBoxDL15, 0x700A, 1); //MAXIMUM
                backend.updateROMText(absoluteFilename, 0x2,  textBoxDL16, 0x7012, 1); //MP
                backend.updateROMText(absoluteFilename, 0x6,  textBoxDL17, 0x7018, 1); //ATTACK
                backend.updateROMText(absoluteFilename, 0x5,  textBoxDL18, 0x701F, 1); //POWER
                backend.updateROMText(absoluteFilename, 0x7,  textBoxDL19, 0x7028, 1); //DEFENSE
                backend.updateROMText(absoluteFilename, 0x5,  textBoxDL20, 0x7030, 1); //POWER
                backend.updateROMText(absoluteFilename, 0x6,  textBoxDL21, 0x7039, 1); //WEAPON
                backend.updateROMText(absoluteFilename, 0x5,  textBoxDL22, 0x7045, 1); //ARMOR
                backend.updateROMText(absoluteFilename, 0x6,  textBoxDL23, 0x7050, 1); //SHIELD
                backend.updateROMText(absoluteFilename, 0x7,  textBoxDL24, 0x70AC, 1); //COMMAND
                backend.updateROMText(absoluteFilename, 0x5,  textBoxDL25, 0x70B5, 1); //FIGHT
                backend.updateROMText(absoluteFilename, 0x5,  textBoxDL26, 0x70BB, 1); //SPELL
                backend.updateROMText(absoluteFilename, 0x3,  textBoxDL27, 0x70C1, 1); //RUN
                backend.updateROMText(absoluteFilename, 0x4,  textBoxDL28, 0x70C5, 1); //ITEM
                backend.updateROMText(absoluteFilename, 0x3,  textBoxDL29, 0x7103, 1); //YES
                backend.updateROMText(absoluteFilename, 0x2,  textBoxDL30, 0x7108, 1); //NO
                backend.updateROMText(absoluteFilename, 0x3,  textBoxDL31, 0x7113, 1); //BUY
                backend.updateROMText(absoluteFilename, 0x4,  textBoxDL32, 0x7118, 1); //SELL
                backend.updateROMText(absoluteFilename, 0x5,  textBoxDL33, 0x70D1, 1); //SPELL

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_dl_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxDL1,  0x7, 0x706B, 1);
                backend.getText(path, textBoxDL2,  0x4, 0x7074, 1);
                backend.getText(path, textBoxDL3,  0x5, 0x7079, 1);
                backend.getText(path, textBoxDL4,  0x6, 0x707F, 1);
                backend.getText(path, textBoxDL5,  0x4, 0x7086, 1);
                backend.getText(path, textBoxDL6,  0x6, 0x708C, 1);
                backend.getText(path, textBoxDL7,  0x4, 0x7093, 1);
                backend.getText(path, textBoxDL8,  0x6, 0x7099, 1);
                backend.getText(path, textBoxDL9,  0x4, 0x70A0, 1);
                backend.getText(path, textBoxDL10, 0x4, 0x6FDD, 1);
                backend.getText(path, textBoxDL11, 0x8, 0x6FE5, 1);
                backend.getText(path, textBoxDL12, 0x7, 0x6FF1, 1);
                backend.getText(path, textBoxDL13, 0x7, 0x6FFC, 1);
                backend.getText(path, textBoxDL14, 0x2, 0x7004, 1);
                backend.getText(path, textBoxDL15, 0x7, 0x700A, 1);
                backend.getText(path, textBoxDL16, 0x2, 0x7012, 1);
                backend.getText(path, textBoxDL17, 0x6, 0x7018, 1);
                backend.getText(path, textBoxDL18, 0x5, 0x701F, 1);
                backend.getText(path, textBoxDL19, 0x7, 0x7028, 1);
                backend.getText(path, textBoxDL20, 0x5, 0x7030, 1);
                backend.getText(path, textBoxDL21, 0x6, 0x7039, 1);
                backend.getText(path, textBoxDL22, 0x5, 0x7045, 1);
                backend.getText(path, textBoxDL23, 0x6, 0x7050, 1);
                backend.getText(path, textBoxDL24, 0x7, 0x70AC, 1);
                backend.getText(path, textBoxDL25, 0x5, 0x70B5, 1);
                backend.getText(path, textBoxDL26, 0x5, 0x70BB, 1);
                backend.getText(path, textBoxDL27, 0x3, 0x70C1, 1);
                backend.getText(path, textBoxDL28, 0x4, 0x70C5, 1);
                backend.getText(path, textBoxDL29, 0x3, 0x7103, 1);
                backend.getText(path, textBoxDL30, 0x2, 0x7108, 1);
                backend.getText(path, textBoxDL31, 0x3, 0x7113, 1);
                backend.getText(path, textBoxDL32, 0x4, 0x7118, 1);
                backend.getText(path, textBoxDL33, 0x5, 0x70D1, 1);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxDL1.MaxLength =  0x7;
            textBoxDL2.MaxLength =  0x4;
            textBoxDL3.MaxLength =  0x5;
            textBoxDL4.MaxLength =  0x6;
            textBoxDL5.MaxLength =  0x4;
            textBoxDL6.MaxLength =  0x6;
            textBoxDL7.MaxLength =  0x4;
            textBoxDL8.MaxLength =  0x6;
            textBoxDL9.MaxLength =  0x4;
            textBoxDL10.MaxLength = 0x4;
            textBoxDL11.MaxLength = 0x8;
            textBoxDL12.MaxLength = 0x7;
            textBoxDL13.MaxLength = 0x7;
            textBoxDL14.MaxLength = 0x2;
            textBoxDL15.MaxLength = 0x7;
            textBoxDL16.MaxLength = 0x2;
            textBoxDL17.MaxLength = 0x6;
            textBoxDL18.MaxLength = 0x5;
            textBoxDL19.MaxLength = 0x7;
            textBoxDL20.MaxLength = 0x5;
            textBoxDL21.MaxLength = 0x6;
            textBoxDL22.MaxLength = 0x5;
            textBoxDL23.MaxLength = 0x6;
            textBoxDL24.MaxLength = 0x7;
            textBoxDL25.MaxLength = 0x5;
            textBoxDL26.MaxLength = 0x5;
            textBoxDL27.MaxLength = 0x3;
            textBoxDL28.MaxLength = 0x4;
            textBoxDL29.MaxLength = 0x3;
            textBoxDL30.MaxLength = 0x2;
            textBoxDL31.MaxLength = 0x3;
            textBoxDL32.MaxLength = 0x4;
            textBoxDL33.MaxLength = 0x5;
        }
    }
}
