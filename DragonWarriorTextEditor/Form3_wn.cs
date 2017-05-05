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
    public partial class Form3_wn : Form {

        string path = "";

        public Form3_wn() {
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

                backend.updateROMText(absoluteFilename, 0x4, textBoxWN1,  0x7B38, 0); //Herb
                backend.updateROMText(absoluteFilename, 0x5, textBoxWN2,  0x7B3D, 0); //Torch
                backend.updateROMText(absoluteFilename, 0x8, textBoxWN3,  0x7B43, 0); //Dragon's
                backend.updateROMText(absoluteFilename, 0x5, textBoxWN4,  0x7B4C, 0); //Wings
                backend.updateROMText(absoluteFilename, 0x5, textBoxWN5,  0x7B52, 0); //Magic
                backend.updateROMText(absoluteFilename, 0x5, textBoxWN6,  0x7B58, 0); //Fairy
                backend.updateROMText(absoluteFilename, 0x7, textBoxWN7,  0x7B5E, 0); //Ball of
                backend.updateROMText(absoluteFilename, 0x6, textBoxWN8,  0x7B66, 0); //Tablet
                backend.updateROMText(absoluteFilename, 0x5, textBoxWN9,  0x7B6D, 0); //Fairy
                backend.updateROMText(absoluteFilename, 0x6, textBoxWN10, 0x7B73, 0); //Silver
                backend.updateROMText(absoluteFilename, 0x8, textBoxWN11, 0x7B7A, 0); //Staff of
                backend.updateROMText(absoluteFilename, 0x9, textBoxWN12, 0x7B83, 0); //Stones of
                backend.updateROMText(absoluteFilename, 0x9, textBoxWN13, 0x7B8D, 0); //Gwaelin's
                backend.updateROMText(absoluteFilename, 0x7, textBoxWN14, 0x7B97, 0); //Rainbow
                backend.updateROMText(absoluteFilename, 0x6, textBoxWN15, 0x7B9F, 0); //Cursed
                backend.updateROMText(absoluteFilename, 0x5, textBoxWN16, 0x7BA6, 0); //Death
                backend.updateROMText(absoluteFilename, 0x9, textBoxWN17, 0x7BAC, 0); //Fighter's
                backend.updateROMText(absoluteFilename, 0x9, textBoxWN18, 0x7BB6, 0); //Erdrick's
                backend.updateROMText(absoluteFilename, 0x5, textBoxWN19, 0x7C24, 0); //Scale
                backend.updateROMText(absoluteFilename, 0x3, textBoxWN20, 0x7C2B, 0); //Key
                backend.updateROMText(absoluteFilename, 0x5, textBoxWN21, 0x7C3C, 0); //Flute
                backend.updateROMText(absoluteFilename, 0x5, textBoxWN22, 0x7C35, 0); //Light
                backend.updateROMText(absoluteFilename, 0x4, textBoxWN23, 0x7C42, 0); //Harp
                backend.updateROMText(absoluteFilename, 0x4, textBoxWN24, 0x7C47, 0); //Rain
                backend.updateROMText(absoluteFilename, 0x8, textBoxWN25, 0x7C4C, 0); //Sunlight
                backend.updateROMText(absoluteFilename, 0x4, textBoxWN26, 0x7C55, 0); //Love
                backend.updateROMText(absoluteFilename, 0x4, textBoxWN27, 0x7C5A, 0); //Drop
                backend.updateROMText(absoluteFilename, 0x4, textBoxWN28, 0x7C5F, 0); //Belt
                backend.updateROMText(absoluteFilename, 0x8, textBoxWN29, 0x7C64, 0); //Necklace
                backend.updateROMText(absoluteFilename, 0x5, textBoxWN30, 0x7C72, 0); //Token
                backend.updateROMText(absoluteFilename, 0x4, textBoxWN31, 0x7C6D, 0); //Ring
                backend.updateROMText(absoluteFilename, 0x5, textBoxWN32, 0x7C2F, 0); //Water

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_wn_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxWN1,  0x4, 0x7B38, 0);
                backend.getText(path, textBoxWN2,  0x5, 0x7B3D, 0);
                backend.getText(path, textBoxWN3,  0x8, 0x7B43, 0);
                backend.getText(path, textBoxWN4,  0x5, 0x7B4C, 0);
                backend.getText(path, textBoxWN5,  0x5, 0x7B52, 0);
                backend.getText(path, textBoxWN6,  0x5, 0x7B58, 0);
                backend.getText(path, textBoxWN7,  0x7, 0x7B5E, 0);
                backend.getText(path, textBoxWN8,  0x6, 0x7B66, 0);
                backend.getText(path, textBoxWN9,  0x5, 0x7B6D, 0);
                backend.getText(path, textBoxWN10, 0x6, 0x7B73, 0);
                backend.getText(path, textBoxWN11, 0x8, 0x7B7A, 0);
                backend.getText(path, textBoxWN12, 0x9, 0x7B83, 0);
                backend.getText(path, textBoxWN13, 0x9, 0x7B8D, 0);
                backend.getText(path, textBoxWN14, 0x7, 0x7B97, 0);
                backend.getText(path, textBoxWN15, 0x6, 0x7B9F, 0);
                backend.getText(path, textBoxWN16, 0x5, 0x7BA6, 0);
                backend.getText(path, textBoxWN17, 0x9, 0x7BAC, 0);
                backend.getText(path, textBoxWN18, 0x9, 0x7BB6, 0);
                backend.getText(path, textBoxWN19, 0x5, 0x7C24, 0);
                backend.getText(path, textBoxWN20, 0x3, 0x7C2B, 0);
                backend.getText(path, textBoxWN21, 0x5, 0x7C3C, 0);
                backend.getText(path, textBoxWN22, 0x5, 0x7C35, 0);
                backend.getText(path, textBoxWN23, 0x4, 0x7C42, 0);
                backend.getText(path, textBoxWN24, 0x4, 0x7C47, 0);
                backend.getText(path, textBoxWN25, 0x8, 0x7C4C, 0);
                backend.getText(path, textBoxWN26, 0x4, 0x7C55, 0);
                backend.getText(path, textBoxWN27, 0x4, 0x7C5A, 0);
                backend.getText(path, textBoxWN28, 0x4, 0x7C5F, 0);
                backend.getText(path, textBoxWN29, 0x8, 0x7C64, 0);
                backend.getText(path, textBoxWN30, 0x5, 0x7C72, 0);
                backend.getText(path, textBoxWN31, 0x4, 0x7C6D, 0);
                backend.getText(path, textBoxWN32, 0x5, 0x7C2F, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxWN1.MaxLength =  0x4;
            textBoxWN2.MaxLength =  0x5;
            textBoxWN3.MaxLength =  0x8;
            textBoxWN4.MaxLength =  0x5;
            textBoxWN5.MaxLength =  0x5;
            textBoxWN6.MaxLength =  0x5;
            textBoxWN7.MaxLength =  0x7;
            textBoxWN8.MaxLength =  0x6;
            textBoxWN9.MaxLength =  0x5;
            textBoxWN10.MaxLength = 0x6;
            textBoxWN11.MaxLength = 0x8;
            textBoxWN12.MaxLength = 0x9;
            textBoxWN13.MaxLength = 0x9;
            textBoxWN14.MaxLength = 0x7;
            textBoxWN15.MaxLength = 0x6;
            textBoxWN16.MaxLength = 0x5;
            textBoxWN17.MaxLength = 0x9;
            textBoxWN18.MaxLength = 0x9;
            textBoxWN19.MaxLength = 0x5;
            textBoxWN20.MaxLength = 0x3;
            textBoxWN21.MaxLength = 0x5;
            textBoxWN22.MaxLength = 0x5;
            textBoxWN23.MaxLength = 0x4;
            textBoxWN24.MaxLength = 0x4;
            textBoxWN25.MaxLength = 0x8;
            textBoxWN26.MaxLength = 0x4;
            textBoxWN27.MaxLength = 0x4;
            textBoxWN28.MaxLength = 0x4;
            textBoxWN29.MaxLength = 0x8;
            textBoxWN30.MaxLength = 0x5;
            textBoxWN31.MaxLength = 0x4;
            textBoxWN32.MaxLength = 0x5;

        }
    }
}
