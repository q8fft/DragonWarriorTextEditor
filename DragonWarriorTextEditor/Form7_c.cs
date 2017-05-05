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
    public partial class Form7_c : Form {

        string path = "";

        public Form7_c() {
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

                backend.updateROMText(absoluteFilename, 0x5, textBoxC1,  0x7C80, 0); //Slime
                backend.updateROMText(absoluteFilename, 0x3, textBoxC2,  0x7C86, 0); //Red: for Slime or Dragon [i dont know]
                backend.updateROMText(absoluteFilename, 0x6, textBoxC3,  0x7C8A, 0); //Drakee
                backend.updateROMText(absoluteFilename, 0x5, textBoxC4,  0x7C91, 0); //Ghost
                backend.updateROMText(absoluteFilename, 0x8, textBoxC5,  0x7C97, 0); //Magician
                backend.updateROMText(absoluteFilename, 0xA, textBoxC6,  0x7CA0, 0); //Magidrakee
                backend.updateROMText(absoluteFilename, 0x8, textBoxC7,  0x7CAB, 0); //Scorpion
                backend.updateROMText(absoluteFilename, 0x5, textBoxC8,  0x7CB4, 0); //Druin
                backend.updateROMText(absoluteFilename, 0xB, textBoxC9,  0x7CBA, 0); //Poltergeist
                backend.updateROMText(absoluteFilename, 0x5, textBoxC10, 0x7CC6, 0); //Droll
                backend.updateROMText(absoluteFilename, 0x8, textBoxC11, 0x7CCC, 0); //Drakeema
                backend.updateROMText(absoluteFilename, 0x8, textBoxC12, 0x7CD5, 0); //Skeleton
                backend.updateROMText(absoluteFilename, 0x7, textBoxC13, 0x7CDE, 0); //Warlock
                backend.updateROMText(absoluteFilename, 0x5, textBoxC14, 0x7CE6, 0); //Metal: for Slime or Scorpion [i dont know]
                backend.updateROMText(absoluteFilename, 0x4, textBoxC15, 0x7CEC, 0); //Wolf
                backend.updateROMText(absoluteFilename, 0x6, textBoxC16, 0x7CF1, 0); //Wraith
                backend.updateROMText(absoluteFilename, 0x5, textBoxC17, 0x7CF8, 0); //Metal: for Slime or Scorpion [i dont know]
                backend.updateROMText(absoluteFilename, 0x7, textBoxC18, 0x7CFE, 0); //Specter
                backend.updateROMText(absoluteFilename, 0x8, textBoxC19, 0x7D06, 0); //Wolflord
                backend.updateROMText(absoluteFilename, 0x9, textBoxC20, 0x7D0F, 0); //Druinlord
                backend.updateROMText(absoluteFilename, 0x9, textBoxC21, 0x7D19, 0); //Drollmagi
                backend.updateROMText(absoluteFilename, 0x6, textBoxC22, 0x7D23, 0); //Wyvern
                backend.updateROMText(absoluteFilename, 0x5, textBoxC23, 0x7D2A, 0); //Rogue
                backend.updateROMText(absoluteFilename, 0x6, textBoxC24, 0x7D30, 0); //Wraith
                backend.updateROMText(absoluteFilename, 0x5, textBoxC25, 0x7D37, 0); //Golem
                backend.updateROMText(absoluteFilename, 0x7, textBoxC26, 0x7D3D, 0); //Goldman
                backend.updateROMText(absoluteFilename, 0x6, textBoxC27, 0x7D45, 0); //Knight
                backend.updateROMText(absoluteFilename, 0xA, textBoxC28, 0x7D4C, 0); //Magiwyvern
                backend.updateROMText(absoluteFilename, 0x5, textBoxC29, 0x7D57, 0); //Demon
                backend.updateROMText(absoluteFilename, 0x8, textBoxC30, 0x7D5D, 0); //Werewolf
                backend.updateROMText(absoluteFilename, 0x5, textBoxC31, 0x7D66, 0); //Green
                backend.updateROMText(absoluteFilename, 0xA, textBoxC32, 0x7D6C, 0); //Starwyvern
                backend.updateROMText(absoluteFilename, 0x6, textBoxC33, 0x7D77, 0); //Wizard
                backend.updateROMText(absoluteFilename, 0x3, textBoxC34, 0x7D7E, 0); //Axe
                backend.updateROMText(absoluteFilename, 0x4, textBoxC35, 0x7D82, 0); //Blue
                backend.updateROMText(absoluteFilename, 0x8, textBoxC36, 0x7D87, 0); //Stoneman
                backend.updateROMText(absoluteFilename, 0x6, textBoxC37, 0x7D90, 0); //Armored
                backend.updateROMText(absoluteFilename, 0x3, textBoxC38, 0x7D98, 0); //Red
                backend.updateROMText(absoluteFilename, 0xA, textBoxC39, 0x7D9C, 0); //Dragonlord
                backend.updateROMText(absoluteFilename, 0xA, textBoxC40, 0x7DA7, 0); //Dragonlord
                backend.updateROMText(absoluteFilename, 0x5, textBoxC41, 0x7DB3, 0); //Slime
                backend.updateROMText(absoluteFilename, 0x8, textBoxC42, 0x7DC4, 0); //Scorpion
                backend.updateROMText(absoluteFilename, 0x5, textBoxC43, 0x7DCF, 0); //Slime
                backend.updateROMText(absoluteFilename, 0x8, textBoxC44, 0x7DDA, 0); //Scorpion
                backend.updateROMText(absoluteFilename, 0x6, textBoxC45, 0x7DE3, 0); //Knight
                backend.updateROMText(absoluteFilename, 0x6, textBoxC46, 0x7DEE, 0); //Knight
                backend.updateROMText(absoluteFilename, 0x6, textBoxC47, 0x7DF6, 0); //Dragon
                backend.updateROMText(absoluteFilename, 0x6, textBoxC48, 0x7DFF, 0); //Knight
                backend.updateROMText(absoluteFilename, 0x6, textBoxC49, 0x7E06, 0); //Dragon
                backend.updateROMText(absoluteFilename, 0x6, textBoxC50, 0x7E0E, 0); //Knight
                backend.updateROMText(absoluteFilename, 0x6, textBoxC51, 0x7E15, 0); //Dragon
             //   backend.updateROMText(absoluteFilename, 0x6, textBoxC52, 0x7E15, 0); //
             //   backend.updateROMText(absoluteFilename, 0x6, textBoxC53, 0x1E5F6, 0);
             //   backend.updateROMText(absoluteFilename, 0x8, textBoxC54, 0x1E5FF, 0);
             //   backend.updateROMText(absoluteFilename, 0x8, textBoxC55, 0x1E60A, 0);
             //   backend.updateROMText(absoluteFilename, 0x8, textBoxC56, 0x1E615, 0);
             //   backend.updateROMText(absoluteFilename, 0x6, textBoxC57, 0x1E620, 0);
             //   backend.updateROMText(absoluteFilename, 0x9, textBoxC58, 0x1E629, 0);
             //   backend.updateROMText(absoluteFilename, 0x5, textBoxC59, 0x1E635, 0);

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form7_c_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                // $1E2D7 - $1E639 - Game Credits
                backend.getText(path, textBoxC1,  0x5,   0x7C80, 0);
                backend.getText(path, textBoxC2,  0x3,   0x7C86, 0);
                backend.getText(path, textBoxC3,  0x6,   0x7C8A, 0);
                backend.getText(path, textBoxC4,  0x5,   0x7C91, 0);
                backend.getText(path, textBoxC5,  0x8,   0x7C97, 0);
                backend.getText(path, textBoxC6,  0xA,   0x7CA0, 0);
                backend.getText(path, textBoxC7,  0x8,   0x7CAB, 0);
                backend.getText(path, textBoxC8,  0x5,   0x7CB4, 0);
                backend.getText(path, textBoxC9,  0xB,   0x7CBA, 0);
                backend.getText(path, textBoxC10, 0x5,   0x7CC6, 0);
                backend.getText(path, textBoxC11, 0x8,   0x7CCC, 0);
                backend.getText(path, textBoxC12, 0x8,   0x7CD5, 0);
                backend.getText(path, textBoxC13, 0x7,   0x7CDE, 0);
                backend.getText(path, textBoxC14, 0x5,   0x7CE6, 0);
                backend.getText(path, textBoxC15, 0x4,   0x7CEC, 0);
                backend.getText(path, textBoxC16, 0x6,   0x7CF1, 0);
                backend.getText(path, textBoxC17, 0x5,   0x7CF8, 0);
                backend.getText(path, textBoxC18, 0x7,   0x7CFE, 0);
                backend.getText(path, textBoxC19, 0x8,   0x7D06, 0);
                backend.getText(path, textBoxC20, 0x9,   0x7D0F, 0);
                backend.getText(path, textBoxC21, 0x9,   0x7D19, 0);
                backend.getText(path, textBoxC22, 0x6,   0x7D23, 0);
                backend.getText(path, textBoxC23, 0x5,   0x7D2A, 0);
                backend.getText(path, textBoxC24, 0x6,   0x7D30, 0);
                backend.getText(path, textBoxC25, 0x5,   0x7D37, 0);
                backend.getText(path, textBoxC26, 0x7,   0x7D3D, 0);
                backend.getText(path, textBoxC27, 0x6,   0x7D45, 0);
                backend.getText(path, textBoxC28, 0xA,   0x7D4C, 0);
                backend.getText(path, textBoxC29, 0x5,   0x7D57, 0);
                backend.getText(path, textBoxC30, 0x8,   0x7D5D, 0);
                backend.getText(path, textBoxC31, 0x5,   0x7D66, 0);
                backend.getText(path, textBoxC32, 0xA,   0x7D6C, 0);
                backend.getText(path, textBoxC33, 0x6,   0x7D77, 0);
                backend.getText(path, textBoxC34, 0x3,   0x7D7E, 0);
                backend.getText(path, textBoxC35, 0x4,   0x7D82, 0);
                backend.getText(path, textBoxC36, 0x8,   0x7D87, 0);
                backend.getText(path, textBoxC37, 0x6,   0x7D90, 0);
                backend.getText(path, textBoxC38, 0x3,   0x7D98, 0);
                backend.getText(path, textBoxC39, 0xA,   0x7D9C, 0);
                backend.getText(path, textBoxC40, 0xA,   0x7DA7, 0);
                backend.getText(path, textBoxC41, 0x5,   0x7DB3, 0);
                backend.getText(path, textBoxC42, 0x8,   0x7DC4, 0);
                backend.getText(path, textBoxC43, 0x5,   0x7DCF, 0);
                backend.getText(path, textBoxC44, 0x8,   0x7DDA, 0);
                backend.getText(path, textBoxC45, 0x6,   0x7DE3, 0);
                backend.getText(path, textBoxC46, 0x6,   0x7DEE, 0);
                backend.getText(path, textBoxC47, 0x6,   0x7DF6, 0);
                backend.getText(path, textBoxC48, 0x6,   0x7DFF, 0);
                backend.getText(path, textBoxC49, 0x6,   0x7E06, 0);
                backend.getText(path, textBoxC50, 0x6,   0x7E0E, 0);
                backend.getText(path, textBoxC51, 0x6, 0x7E15, 0);
             //   backend.getText(path, textBoxC52, 0x6,   0x7E15, 0);
             //   backend.getText(path, textBoxC53, 0x6,   0x1E5F6, 0);
             //   backend.getText(path, textBoxC54, 0x8,   0x1E5FF, 0);
             //   backend.getText(path, textBoxC55, 0x8,   0x1E60A, 0);
             //   backend.getText(path, textBoxC56, 0x8,   0x1E615, 0);
             //   backend.getText(path, textBoxC57, 0x6,   0x1E620, 0);
             //   backend.getText(path, textBoxC58, 0x9,   0x1E629, 0);
             //   backend.getText(path, textBoxC59, 0x5,   0x1E635, 0);


            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxC1.MaxLength =  0x5;
            textBoxC2.MaxLength =  0x3;
            textBoxC3.MaxLength =  0x6;
            textBoxC4.MaxLength =  0x5;
            textBoxC5.MaxLength =  0x8;
            textBoxC6.MaxLength =  0xA;
            textBoxC7.MaxLength =  0x8;
            textBoxC8.MaxLength =  0x5;
            textBoxC9.MaxLength =  0xB;
            textBoxC10.MaxLength = 0x5;
            textBoxC11.MaxLength = 0x8;
            textBoxC12.MaxLength = 0x8;
            textBoxC13.MaxLength = 0x7;
            textBoxC14.MaxLength = 0x5;
            textBoxC15.MaxLength = 0x4;
            textBoxC16.MaxLength = 0x6;
            textBoxC17.MaxLength = 0x5;
            textBoxC18.MaxLength = 0x7;
            textBoxC19.MaxLength = 0x8;
            textBoxC20.MaxLength = 0x9;
            textBoxC21.MaxLength = 0x9;
            textBoxC22.MaxLength = 0x6;
            textBoxC23.MaxLength = 0x5;
            textBoxC24.MaxLength = 0x6;
            textBoxC25.MaxLength = 0x5;
            textBoxC26.MaxLength = 0x7;
            textBoxC27.MaxLength = 0x6;
            textBoxC28.MaxLength = 0xA;
            textBoxC29.MaxLength = 0x5;
            textBoxC30.MaxLength = 0x8;
            textBoxC31.MaxLength = 0x5;
            textBoxC32.MaxLength = 0xA;
            textBoxC33.MaxLength = 0x6;
            textBoxC34.MaxLength = 0x3;
            textBoxC35.MaxLength = 0x4;
            textBoxC36.MaxLength = 0x8;
            textBoxC37.MaxLength = 0x6;
            textBoxC38.MaxLength = 0x3;
            textBoxC39.MaxLength = 0xA;
            textBoxC40.MaxLength = 0xA;
            textBoxC41.MaxLength = 0x5;
            textBoxC42.MaxLength = 0x8;
            textBoxC43.MaxLength = 0x5;
            textBoxC44.MaxLength = 0x8;
            textBoxC45.MaxLength = 0x6;
            textBoxC46.MaxLength = 0x6;
            textBoxC47.MaxLength = 0x6;
            textBoxC48.MaxLength = 0x6;
            textBoxC49.MaxLength = 0x6;
            textBoxC50.MaxLength = 0x6;
            textBoxC51.MaxLength = 0x6;
        //    textBoxC52.MaxLength = 0x6;
        //    textBoxC53.MaxLength = 0x6;
        //    textBoxC54.MaxLength = 0x8;
        //    textBoxC55.MaxLength = 0x8;
        //    textBoxC56.MaxLength = 0x8;
        //    textBoxC57.MaxLength = 0x6;
        //    textBoxC58.MaxLength = 0x9;
        //    textBoxC59.MaxLength = 0x5;
        }


    }
}
