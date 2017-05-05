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
    public partial class Form6_e : Form {

        string path = "";

        public Form6_e() {
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

                backend.updateROMText(absoluteFilename, 0x6,  textBoxE1,  0x7AC7, 1); //Bamboo --- Start Weapons
                backend.updateROMText(absoluteFilename, 0x4,  textBoxE2,  0x7ACE, 1); //Club
                backend.updateROMText(absoluteFilename, 0x6,  textBoxE3,  0x7AD3, 1); //Copper
                backend.updateROMText(absoluteFilename, 0x4,  textBoxE4,  0x7ADA, 1); //Hand
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE5,  0x7ADF, 1); //Broad
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE6,  0x7AE5, 1); //Flame
                backend.updateROMText(absoluteFilename, 0x9,  textBoxE7,  0x7AEB, 1); //Erdrick's
                backend.updateROMText(absoluteFilename, 0x4,  textBoxE8,  0x7BC7, 1); //Pole
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE9,  0x7BCD, 1); //Sword
                backend.updateROMText(absoluteFilename, 0x3,  textBoxE10, 0x7BD3, 1); //Axe
                backend.updateROMText(absoluteFilename, 0x6,  textBoxE11, 0x7BD7, 1); //Sword
                backend.updateROMText(absoluteFilename, 0x6,  textBoxE12, 0x7BDD, 1); //Sword
                backend.updateROMText(absoluteFilename, 0x6,  textBoxE13, 0x7BE3, 1); //Sword
                backend.updateROMText(absoluteFilename, 0x7,  textBoxE14, 0x7AF5, 1); //Clothes --- Start Armor
                backend.updateROMText(absoluteFilename, 0x7,  textBoxE15, 0x7AFD, 1); //Leather
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE16, 0x7B05, 1); //Chain
                backend.updateROMText(absoluteFilename, 0x4,  textBoxE17, 0x7B0B, 1); //Half
                backend.updateROMText(absoluteFilename, 0x4,  textBoxE18, 0x7B10, 1); //Full
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE19, 0x7B15, 1); //Magic
                backend.updateROMText(absoluteFilename, 0x9,  textBoxE20, 0x7B1B, 1); //Erdrick's
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE21, 0x7BEA, 1); //Armor
                backend.updateROMText(absoluteFilename, 0x4,  textBoxE22, 0x7BF0, 1); //Mail
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE23, 0x7BF5, 1); //Plate
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE24, 0x7BFB, 1); //Plate
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE25, 0x7C01, 1); //Armor
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE26, 0x7C07, 1); //Armor
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE27, 0x7B25, 1); //Small --- Shields
                backend.updateROMText(absoluteFilename, 0x5,  textBoxE28, 0x7B2B, 1); //Large
                backend.updateROMText(absoluteFilename, 0x6,  textBoxE29, 0x7B31, 1); //Silver
                backend.updateROMText(absoluteFilename, 0x6,  textBoxE30, 0x7C0D, 1); //Shield
                backend.updateROMText(absoluteFilename, 0x6,  textBoxE31, 0x7C14, 1); //Shield
                backend.updateROMText(absoluteFilename, 0x6,  textBoxE32, 0x7C1B, 1); //Shield

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form6_e_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxE1,  0x6, 0x7AC7, 1);
                backend.getText(path, textBoxE2,  0x4, 0x7ACE, 1);
                backend.getText(path, textBoxE3,  0x6, 0x7AD3, 1);
                backend.getText(path, textBoxE4,  0x4, 0x7ADA, 1);
                backend.getText(path, textBoxE5,  0x5, 0x7ADF, 1);
                backend.getText(path, textBoxE6,  0x5, 0x7AE5, 1);
                backend.getText(path, textBoxE7,  0x9, 0x7AEB, 1);
                backend.getText(path, textBoxE8,  0x4, 0x7BC7, 1);
                backend.getText(path, textBoxE9,  0x5, 0x7BCD, 1);
                backend.getText(path, textBoxE10, 0x3, 0x7BD3, 1);
                backend.getText(path, textBoxE11, 0x6, 0x7BD7, 1);
                backend.getText(path, textBoxE12, 0x6, 0x7BDD, 1);
                backend.getText(path, textBoxE13, 0x6, 0x7BE3, 1);
                backend.getText(path, textBoxE14, 0x7, 0x7AF5, 1);
                backend.getText(path, textBoxE15, 0x7, 0x7AFD, 1);
                backend.getText(path, textBoxE16, 0x5, 0x7B05, 1);
                backend.getText(path, textBoxE17, 0x4, 0x7B0B, 1);
                backend.getText(path, textBoxE18, 0x4, 0x7B10, 1);
                backend.getText(path, textBoxE19, 0x5, 0x7B15, 1);
                backend.getText(path, textBoxE20, 0x9, 0x7B1B, 1);
                backend.getText(path, textBoxE21, 0x5, 0x7BEA, 1);
                backend.getText(path, textBoxE22, 0x4, 0x7BF0, 1);
                backend.getText(path, textBoxE23, 0x5, 0x7BF5, 1);
                backend.getText(path, textBoxE24, 0x5, 0x7BFB, 1);
                backend.getText(path, textBoxE25, 0x5, 0x7C01, 1);
                backend.getText(path, textBoxE26, 0x5, 0x7C07, 1);
                backend.getText(path, textBoxE27, 0x5, 0x7B25, 1);
                backend.getText(path, textBoxE28, 0x5, 0x7B2B, 1);
                backend.getText(path, textBoxE29, 0x6, 0x7B31, 1);
                backend.getText(path, textBoxE30, 0x6, 0x7C0D, 1);
                backend.getText(path, textBoxE31, 0x6, 0x7C14, 1);
                backend.getText(path, textBoxE32, 0x6, 0x7C1B, 1);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxE1.MaxLength  = 0x6;
            textBoxE2.MaxLength  = 0x4;
            textBoxE3.MaxLength  = 0x6;
            textBoxE4.MaxLength  = 0x4;
            textBoxE5.MaxLength  = 0x5;
            textBoxE6.MaxLength  = 0x5;
            textBoxE7.MaxLength  = 0x9;
            textBoxE8.MaxLength  = 0x4;
            textBoxE9.MaxLength  = 0x5;
            textBoxE10.MaxLength = 0x3;
            textBoxE11.MaxLength = 0x6;
            textBoxE12.MaxLength = 0x6;
            textBoxE13.MaxLength = 0x6;
            textBoxE14.MaxLength = 0x7;
            textBoxE15.MaxLength = 0x7;
            textBoxE16.MaxLength = 0x5;
            textBoxE17.MaxLength = 0x4;
            textBoxE18.MaxLength = 0x4;
            textBoxE19.MaxLength = 0x5;
            textBoxE20.MaxLength = 0x9;
            textBoxE21.MaxLength = 0x5;
            textBoxE22.MaxLength = 0x4;
            textBoxE23.MaxLength = 0x5;
            textBoxE24.MaxLength = 0x5;
            textBoxE25.MaxLength = 0x5;
            textBoxE26.MaxLength = 0x5;
            textBoxE27.MaxLength = 0x5;
            textBoxE28.MaxLength = 0x5;
            textBoxE29.MaxLength = 0x6;
            textBoxE30.MaxLength = 0x6;
            textBoxE31.MaxLength = 0x6;
            textBoxE32.MaxLength = 0x6;
        }
    }
}
