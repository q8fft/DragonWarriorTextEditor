using System;
using System.Collections.Generic;
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
    class Backend {

        int textFlag = 0;

        public Backend() {

        }

        public void getText(string path, TextBox texboxname, int length, int offset, int decodeOption) {

            string romCodeString = "";
            string megamanAsciiOut = "";
            string tempHexString = "";
            int x = 0;
            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read)) {
                try {
                    fileStream.Seek(offset, SeekOrigin.Begin);

                    while (x < length) {
                        romCodeString = fileStream.ReadByte().ToString("X");
                        //if length is single digit add a 0 ( 1 now is 01)
                        if (romCodeString.Length == 1) {
                            romCodeString = "0" + romCodeString;
                        }
                        tempHexString = romCodeString;
                        if (decodeOption == 0) {
                            decodeRomText1(tempHexString);
                            if (textFlag == 0) {
                                megamanAsciiOut += decodeRomText1(tempHexString);
                            }
                        } else {
                            decodeRomText2(tempHexString);
                            if (textFlag == 0) {
                                megamanAsciiOut += decodeRomText2(tempHexString);
                            }
                        }
                        x++;

                        texboxname.Text = megamanAsciiOut;
                    }

                    fileStream.Close();
                } catch (Exception e) {
                    MessageBox.Show("Error: " + e, "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void updateROMText(string absoluteFilename, int length, TextBox textBox, int offset, int decodeOption) {
            // TODO: Optimize/refactor, this is ugly
            string newMM3String = textBox.Text;

            newMM3String = newMM3String.PadRight(length);
            string hexReturn = "";
            string tempascii = "";
            string[] newMM3StringArray = new string[length];
            byte[] newMM3StringByteArray = new byte[length];
            int[] mm3Decimal = new int[length];
            string[] mm3Final = new string[length];
            string[] mm3s = new string[length];

            int x = 0;
            while (x < length) {
                newMM3StringArray[x] = newMM3String[x].ToString();
                tempascii = newMM3StringArray[x];
                if (decodeOption == 0) {
                    hexReturn += encodeRomText1(tempascii);
                } else {
                    hexReturn += encodeRomText2(tempascii);
                }
                
                x++;
            }

            int i = 0;
            int j = 0;
            while (i < length) {
                mm3s[i] = hexReturn[j].ToString() + hexReturn[j + 1].ToString();
                i++;
                j += 2;
            }

            x = 0;
            while (x < length) {
                mm3Decimal[x] = int.Parse(mm3s[x], System.Globalization.NumberStyles.HexNumber);
                mm3Final[x] = mm3Decimal[x].ToString();
                newMM3StringByteArray[x] = byte.Parse(mm3Final[x]);
                x++;
            }

            using (FileStream fileStream = new FileStream(@absoluteFilename, FileMode.Open, FileAccess.Write)) {
                try {
                    fileStream.Seek(offset, SeekOrigin.Begin);
                    x = 0;
                    while (x < length) {
                        fileStream.WriteByte(newMM3StringByteArray[x]);
                        x++;
                    }
                } catch (Exception e) {
                    MessageBox.Show("Error: " + e, "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string decodeRomText1(string tempHexString) {
            string megamanAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "00":
                    megamanAscii += "0";
                    break;
                case "01":
                    megamanAscii += "1";
                    break;
                case "02":
                    megamanAscii += "2";
                    break;
                case "03":
                    megamanAscii += "3";
                    break;
                case "04":
                    megamanAscii += "4";
                    break;
                case "05":
                    megamanAscii += "5";
                    break;
                case "06":
                    megamanAscii += "6";
                    break;
                case "07":
                    megamanAscii += "7";
                    break;
                case "08":
                    megamanAscii += "8";
                    break;
                case "09":
                    megamanAscii += "9";
                    break;
                case "0A":
                    megamanAscii += "a";
                    break;
                case "0B":
                    megamanAscii += "b";
                    break;
                case "0C":
                    megamanAscii += "c";
                    break;
                case "0D":
                    megamanAscii += "d";
                    break;
                case "0E":
                    megamanAscii += "e";
                    break;
                case "0F":
                    megamanAscii += "f";
                    break;
                case "10":
                    megamanAscii += "g";
                    break;
                case "11":
                    megamanAscii += "h";
                    break;
                case "12":
                    megamanAscii += "i";
                    break;
                case "13":
                    megamanAscii += "j";
                    break;
                case "14":
                    megamanAscii += "k";
                    break;
                case "15":
                    megamanAscii += "l";
                    break;
                case "16":
                    megamanAscii += "m";
                    break;
                case "17":
                    megamanAscii += "n";
                    break;
                case "18":
                    megamanAscii += "o";
                    break;
                case "19":
                    megamanAscii += "p";
                    break;
                case "1A":
                    megamanAscii += "q";
                    break;
                case "1B":
                    megamanAscii += "r";
                    break;
                case "1C":
                    megamanAscii += "s";
                    break;
                case "1D":
                    megamanAscii += "t";
                    break;
                case "1E":
                    megamanAscii += "u";
                    break;
                case "1F":
                    megamanAscii += "v";
                    break;
                case "20":
                    megamanAscii += "w";
                    break;
                case "21":
                    megamanAscii += "x";
                    break;
                case "22":
                    megamanAscii += "y";
                    break;
                case "23":
                    megamanAscii += "z";
                    break;
                // TODO: figure this out: case 24 is 24= "invisible" space(first color in the palette)
                case "24":
                    megamanAscii += "A";
                    break;
                case "25":
                    megamanAscii += "B";
                    break;
                case "26":
                    megamanAscii += "C";
                    break;
                case "27":
                    megamanAscii += "D";
                    break;
                case "28":
                    megamanAscii += "E";
                    break;
                case "29":
                    megamanAscii += "F";
                    break;
                // 2A us "r."
                case "2A":
                    megamanAscii += "G";
                    break;
                case "2B":
                    megamanAscii += "H";
                    break;
                case "2C":
                    megamanAscii += "I";
                    break;
                case "2D":
                    megamanAscii += "J";
                    break;
                case "2E":
                    megamanAscii += "K";
                    break;
                case "2F":
                    megamanAscii += "L";
                    break;
                case "30":
                    megamanAscii += "M";
                    break;
                case "31":
                    megamanAscii += "N";
                    break;
                case "32":
                    megamanAscii += "O";
                    break;
                case "33":
                    megamanAscii += "P";
                    break;
                case "34":
                    megamanAscii += "Q";
                    break;
                case "35":
                    megamanAscii += "R";
                    break;
                case "36":
                    megamanAscii += "S";
                    break;
                case "37":
                    megamanAscii += "T";
                    break;
                case "38":
                    megamanAscii += "U";
                    break;
                case "39":
                    megamanAscii += "V";
                    break;
                case "3A":
                    megamanAscii += "W";
                    break;
                case "3B":
                    megamanAscii += "X";
                    break;
                case "3C":
                    megamanAscii += "Y";
                    break;
                case "3D":
                    megamanAscii += "Z";
                    break;
                case "3E":
                    megamanAscii += "“";
                    break;
                case "3F":
                    megamanAscii += "”";
                    break;
                case "40":
                    megamanAscii += "'";
                    break;
                case "41":
                    megamanAscii += "*";
                    break;
                case "44":
                    megamanAscii += ":";
                    break;
                case "45":
                    megamanAscii += "$";
                    break;
                case "47":
                    megamanAscii += ".";
                    break;
                case "48":
                    megamanAscii += ",";
                    break;
                case "49":
                    megamanAscii += "-";
                    break;
                case "4B":
                    megamanAscii += "?";
                    break;
                case "4C":
                    megamanAscii += "!";
                    break;
                case "4D":
                    megamanAscii += ";";
                    break;
                case "4E":
                    megamanAscii += ")";
                    break;
                case "4F":
                    megamanAscii += "(";
                    break;
                case "50":
                    megamanAscii += "<";
                    break;
                case "51":
                    megamanAscii += "’";
                    break;
                case "52":
                    megamanAscii += ">";
                    break;
                case "53":
                    megamanAscii += "゜";
                    break;
                case "54":
                    megamanAscii += "ﾟ";
                    break;
                case "5F":
                    megamanAscii += " ";
                    break;
                case "81":
                    megamanAscii += "|";
                    break;
                case "F8":
                    megamanAscii += "ь";
                    break;
                case "F4":
                    megamanAscii += "ё";
                    break;
                case "F5":
                    megamanAscii += "Ɠ";
                    break;
                case "F6":
                    megamanAscii += "Σ";
                    break;
                case "F7":
                    megamanAscii += "ϊ";
                    break;
                case "F0":
                    megamanAscii += "ϋ";
                    break;
                case "F1":
                    megamanAscii += "ш";
                    break;
                case "F3":
                    megamanAscii += "Ě";
                    break;
                case "FD":
                    megamanAscii += "~";
                    break;
                case "FC":
                    megamanAscii += "®";
                    break;
                case "FB":
                    megamanAscii += "#";
                    break;
                case "60":
                    megamanAscii += "»";
                    break;
                case "EF":
                    megamanAscii += "ś";
                    break;
                case "57":
                    megamanAscii += "¢";
                    break;
                //case "67":
                //    megamanAscii += "©";
                //    break;
                default:
                    megamanAscii += " ";
                    textFlag = 1;
                    break;
            }

            return megamanAscii;
        }

        private string decodeRomText2(string tempHexString) {
			
            string megamanAscii = "";
            textFlag = 0;

            switch (tempHexString) {
				
                case "00":
                    megamanAscii += "0";
                    break;
                case "01":
                    megamanAscii += "1";
                    break;
                case "02":
                    megamanAscii += "2";
                    break;
                case "03":
                    megamanAscii += "3";
                    break;
                case "04":
                    megamanAscii += "4";
                    break;
                case "05":
                    megamanAscii += "5";
                    break;
                case "06":
                    megamanAscii += "6";
                    break;
                case "07":
                    megamanAscii += "7";
                    break;
                case "08":
                    megamanAscii += "8";
                    break;
                case "09":
                    megamanAscii += "9";
                    break;
                case "0A":
                    megamanAscii += "a";
                    break;
                case "0B":
                    megamanAscii += "b";
                    break;
                case "0C":
                    megamanAscii += "c";
                    break;
                case "0D":
                    megamanAscii += "d";
                    break;
                case "0E":
                    megamanAscii += "e";
                    break;
                case "0F":
                    megamanAscii += "f";
                    break;
                case "10":
                    megamanAscii += "g";
                    break;
                case "11":
                    megamanAscii += "h";
                    break;
                case "12":
                    megamanAscii += "i";
                    break;
                case "13":
                    megamanAscii += "j";
                    break;
                case "14":
                    megamanAscii += "k";
                    break;
                case "15":
                    megamanAscii += "l";
                    break;
                case "16":
                    megamanAscii += "m";
                    break;
                case "17":
                    megamanAscii += "n";
                    break;
                case "18":
                    megamanAscii += "o";
                    break;
                case "19":
                    megamanAscii += "p";
                    break;
                case "1A":
                    megamanAscii += "q";
                    break;
                case "1B":
                    megamanAscii += "r";
                    break;
                case "1C":
                    megamanAscii += "s";
                    break;
                case "1D":
                    megamanAscii += "t";
                    break;
                case "1E":
                    megamanAscii += "u";
                    break;
                case "1F":
                    megamanAscii += "v";
                    break;
                case "20":
                    megamanAscii += "w";
                    break;
                case "21":
                    megamanAscii += "x";
                    break;
                case "22":
                    megamanAscii += "y";
                    break;
                case "23":
                    megamanAscii += "z";
                    break;
                // TODO: figure this out: case 24 is 24= "invisible" space(first color in the palette)
                case "24":
                    megamanAscii += "A";
                    break;
                case "25":
                    megamanAscii += "B";
                    break;
                case "26":
                    megamanAscii += "C";
                    break;
                case "27":
                    megamanAscii += "D";
                    break;
                case "28":
                    megamanAscii += "E";
                    break;
                case "29":
                    megamanAscii += "F";
                    break;
                // 2A us "r."
                case "2A":
                    megamanAscii += "G";
                    break;
                case "2B":
                    megamanAscii += "H";
                    break;
                case "2C":
                    megamanAscii += "I";
                    break;
                case "2D":
                    megamanAscii += "J";
                    break;
                case "2E":
                    megamanAscii += "K";
                    break;
                case "2F":
                    megamanAscii += "L";
                    break;
                case "30":
                    megamanAscii += "M";
                    break;
                case "31":
                    megamanAscii += "N";
                    break;
                case "32":
                    megamanAscii += "O";
                    break;
                case "33":
                    megamanAscii += "P";
                    break;
                case "34":
                    megamanAscii += "Q";
                    break;
                case "35":
                    megamanAscii += "R";
                    break;
                case "36":
                    megamanAscii += "S";
                    break;
                case "37":
                    megamanAscii += "T";
                    break;
                case "38":
                    megamanAscii += "U";
                    break;
                case "39":
                    megamanAscii += "V";
                    break;
                case "3A":
                    megamanAscii += "W";
                    break;
                case "3B":
                    megamanAscii += "X";
                    break;
                case "3C":
                    megamanAscii += "Y";
                    break;
                case "3D":
                    megamanAscii += "Z";
                    break;
                case "3E":
                    megamanAscii += "“";
                    break;
                case "3F":
                    megamanAscii += "”";
                    break;
                case "40":
                    megamanAscii += "'";
                    break;
                case "41":
                    megamanAscii += "*";
                    break;
                case "44":
                    megamanAscii += ":";
                    break;
                case "45":
                    megamanAscii += "$";
                    break;
                case "47":
                    megamanAscii += ".";
                    break;
                case "48":
                    megamanAscii += ",";
                    break;
                case "49":
                    megamanAscii += "-";
                    break;
                case "4B":
                    megamanAscii += "?";
                    break;
                case "4C":
                    megamanAscii += "!";
                    break;
                case "4D":
                    megamanAscii += ";";
                    break;
                case "4E":
                    megamanAscii += ")";
                    break;
                case "4F":
                    megamanAscii += "(";
                    break;
                case "50":
                    megamanAscii += "<";
                    break;
                case "51":
                    megamanAscii += "’";
                    break;
                case "52":
                    megamanAscii += ">";
                    break;
                case "53":
                    megamanAscii += "゜";
                    break;
                case "54":
                    megamanAscii += "ﾟ";
                    break;
                case "5F":
                    megamanAscii += " ";
                    break;
                case "81":
                    megamanAscii += "|";
                    break;
                case "F8":
                    megamanAscii += "ь";
                    break;
                case "F4":
                    megamanAscii += "ё";
                    break;
                case "F5":
                    megamanAscii += "Ɠ";
                    break;
                case "F6":
                    megamanAscii += "Σ";
                    break;
                case "F7":
                    megamanAscii += "ϊ";
                    break;
                case "F0":
                    megamanAscii += "ϋ";
                    break;
                case "F1":
                    megamanAscii += "ш";
                    break;
                case "F3":
                    megamanAscii += "Ě";
                    break;
                case "FD":
                    megamanAscii += "~";
                    break;
                case "FC":
                    megamanAscii += "®";
                    break;
                case "FB":
                    megamanAscii += "#";
                    break;
                case "60":
                    megamanAscii += "»";
                    break;
                case "EF":
                    megamanAscii += "ś";
                    break;
                case "57":
                    megamanAscii += "¢";
                    break;
                //case "67":
                //    megamanAscii += "©";
                //    break;
                default:
                    megamanAscii += " ";
                    textFlag = 1;
                    break;
            }

            return megamanAscii;
        }

        private string encodeRomText1(string tempAscii) {
            string megamanHex = "";
           // tempAscii = tempAscii.ToUpper();

            switch (tempAscii) {
                case "0":
                    megamanHex += "00";
                    break;
                case "1":
                    megamanHex += "01";
                    break;
                case "2":
                    megamanHex += "02";
                    break;
                case "3":
                    megamanHex += "03";
                    break;
                case "4":
                    megamanHex += "04";
                    break;
                case "5":
                    megamanHex += "05";
                    break;
                case "6":
                    megamanHex += "06";
                    break;
                case "7":
                    megamanHex += "07";
                    break;
                case "8":
                    megamanHex += "08";
                    break;
                case "9":
                    megamanHex += "09";
                    break;
                case "a":
                    megamanHex += "0A";
                    break;
                case "b":
                    megamanHex += "0B";
                    break;
                case "c":
                    megamanHex += "0C";
                    break;
                case "d":
                    megamanHex += "0D";
                    break;
                case "e":
                    megamanHex += "0E";
                    break;
                case "f":
                    megamanHex += "0F";
                    break;
                case "g":
                    megamanHex += "10";
                    break;
                case "h":
                    megamanHex += "11";
                    break;
                case "i":
                    megamanHex += "12";
                    break;
                case "j":
                    megamanHex += "13";
                    break;
                case "k":
                    megamanHex += "14";
                    break;
                case "l":
                    megamanHex += "15";
                    break;
                case "m":
                    megamanHex += "16";
                    break;
                case "n":
                    megamanHex += "17";
                    break;
                case "o":
                    megamanHex += "18";
                    break;
                case "p":
                    megamanHex += "19";
                    break;
                case "q":
                    megamanHex += "1A";
                    break;
                case "r":
                    megamanHex += "1B";
                    break;
                case "s":
                    megamanHex += "1C";
                    break;
                case "t":
                    megamanHex += "1D";
                    break;
                case "u":
                    megamanHex += "1E";
                    break;
                case "v":
                    megamanHex += "1F";
                    break;
                case "w":
                    megamanHex += "20";
                    break;
                case "x":
                    megamanHex += "21";
                    break;
                case "y":
                    megamanHex += "22";
                    break;
                case "z":
                    megamanHex += "23";
                    break;
                // TODO: figure this out: case 24 is 24= "invisible" space(first color in the palette)
                case "A":
                    megamanHex += "24";
                    break;
                case "B":
                    megamanHex += "25";
                    break;
                case "C":
                    megamanHex += "26";
                    break;
                case "D":
                    megamanHex += "27";
                    break;
                case "E":
                    megamanHex += "28";
                    break;
                case "F":
                    megamanHex += "29";
                    break;
                // TODO: this is a special case, ignoring for now
                case "G":
                    megamanHex += "2A";
                    break;
                case "H":
                    megamanHex += "2B";
                    break;
                case "I":
                    megamanHex += "2C";
                    break;
                case "J":
                    megamanHex += "2D";
                    break;
                case "K":
                    megamanHex += "2E";
                    break;
                case "L":
                    megamanHex += "2F";
                    break;
                case "M":
                    megamanHex += "30";
                    break;
                case "N":
                    megamanHex += "31";
                    break;
                case "O":
                    megamanHex += "32";
                    break;
                case "P":
                    megamanHex += "33";
                    break;
                case "Q":
                    megamanHex += "34";
                    break;
                case "R":
                    megamanHex += "35";
                    break;
                case "S":
                    megamanHex += "36";
                    break;
                case "T":
                    megamanHex += "37";
                    break;
                case "U":
                    megamanHex += "38";
                    break;
                case "V":
                    megamanHex += "39";
                    break;
                case "W":
                    megamanHex += "3A";
                    break;
                case "X":
                    megamanHex += "3B";
                    break;
                case "Y":
                    megamanHex += "3C";
                    break;
                case "Z":
                    megamanHex += "3D";
                    break;
                case "“":
                    megamanHex += "3E";
                    break;
                case "”":
                    megamanHex += "3F";
                    break;
                case "'":
                    megamanHex += "40";
                    break;
                case "*":
                    megamanHex += "41";
                    break;
                case ":":
                    megamanHex += "44";
                    break;
                case "$":
                    megamanHex += "45";
                    break;
                case ".":
                    megamanHex += "47";
                    break;
                case ",":
                    megamanHex += "48";
                    break;
                case "-":
                    megamanHex += "49";
                    break;
                case "?":
                    megamanHex += "4B";
                    break;
                case "!":
                    megamanHex += "4C";
                    break;
                case ";":
                    megamanHex += "4D";
                    break;
                case ")":
                    megamanHex += "4E";
                    break;
                case "(":
                    megamanHex += "4F";
                    break;
                case "<":
                    megamanHex += "50";
                    break;
                case "’":
                    megamanHex += "51";
                    break;
                case ">":
                    megamanHex += "52";
                    break;
                case "゜":
                    megamanHex += "53";
                    break;
                case "ﾟ":
                    megamanHex += "54";
                    break;
                case " ":
                    megamanHex += "5F";
                    break;
                case "|":
                    megamanHex += "81";
                    break;
                case "ь":
                    megamanHex += "F8";
                    break;
                case "ё":
                    megamanHex += "F4";
                    break;
                case "Ɠ":
                    megamanHex += "F5";
                    break;
                case "Σ":
                    megamanHex += "F6";
                    break;
                case "ϊ":
                    megamanHex += "F7";
                    break;
                case "ϋ":
                    megamanHex += "F0";
                    break;
                case "ш":
                    megamanHex += "F1";
                    break;
                case "Ě":
                    megamanHex += "F3";
                    break;
                case "~":
                    megamanHex += "FD";
                    break;
                case "®":
                    megamanHex += "FC";
                    break;
                case "#":
                    megamanHex += "FB";
                    break;
                case "»":
                    megamanHex += "60";
                    break;
                case "ś":
                    megamanHex += "EF";
                    break;
                case "¢":
                    megamanHex += "57";
                    break;
                //case "Add":
                // megamanHex += "Add";
                //break;
                default:
                    megamanHex += "5F";
                    break;
            }

            return megamanHex;
        }

        private string encodeRomText2(string tempAscii){
			
            string megamanHex = "";
            // tempAscii = tempAscii.ToUpper();

            switch (tempAscii){
                case "0":
				
                    megamanHex += "00";
                    break;
                case "1":
                    megamanHex += "01";
                    break;
                case "2":
                    megamanHex += "02";
                    break;
                case "3":
                    megamanHex += "03";
                    break;
                case "4":
                    megamanHex += "04";
                    break;
                case "5":
                    megamanHex += "05";
                    break;
                case "6":
                    megamanHex += "06";
                    break;
                case "7":
                    megamanHex += "07";
                    break;
                case "8":
                    megamanHex += "08";
                    break;
                case "9":
                    megamanHex += "09";
                    break;
                case "a":
                    megamanHex += "0A";
                    break;
                case "b":
                    megamanHex += "0B";
                    break;
                case "c":
                    megamanHex += "0C";
                    break;
                case "d":
                    megamanHex += "0D";
                    break;
                case "e":
                    megamanHex += "0E";
                    break;
                case "f":
                    megamanHex += "0F";
                    break;
                case "g":
                    megamanHex += "10";
                    break;
                case "h":
                    megamanHex += "11";
                    break;
                case "i":
                    megamanHex += "12";
                    break;
                case "j":
                    megamanHex += "13";
                    break;
                case "k":
                    megamanHex += "14";
                    break;
                case "l":
                    megamanHex += "15";
                    break;
                case "m":
                    megamanHex += "16";
                    break;
                case "n":
                    megamanHex += "17";
                    break;
                case "o":
                    megamanHex += "18";
                    break;
                case "p":
                    megamanHex += "19";
                    break;
                case "q":
                    megamanHex += "1A";
                    break;
                case "r":
                    megamanHex += "1B";
                    break;
                case "s":
                    megamanHex += "1C";
                    break;
                case "t":
                    megamanHex += "1D";
                    break;
                case "u":
                    megamanHex += "1E";
                    break;
                case "v":
                    megamanHex += "1F";
                    break;
                case "w":
                    megamanHex += "20";
                    break;
                case "x":
                    megamanHex += "21";
                    break;
                case "y":
                    megamanHex += "22";
                    break;
                case "z":
                    megamanHex += "23";
                    break;
                // TODO: figure this out: case 24 is 24= "invisible" space(first color in the palette)
                case "A":
                    megamanHex += "24";
                    break;
                case "B":
                    megamanHex += "25";
                    break;
                case "C":
                    megamanHex += "26";
                    break;
                case "D":
                    megamanHex += "27";
                    break;
                case "E":
                    megamanHex += "28";
                    break;
                case "F":
                    megamanHex += "29";
                    break;
                // TODO: this is a special case, ignoring for now
                case "G":
                    megamanHex += "2A";
                    break;
                case "H":
                    megamanHex += "2B";
                    break;
                case "I":
                    megamanHex += "2C";
                    break;
                case "J":
                    megamanHex += "2D";
                    break;
                case "K":
                    megamanHex += "2E";
                    break;
                case "L":
                    megamanHex += "2F";
                    break;
                case "M":
                    megamanHex += "30";
                    break;
                case "N":
                    megamanHex += "31";
                    break;
                case "O":
                    megamanHex += "32";
                    break;
                case "P":
                    megamanHex += "33";
                    break;
                case "Q":
                    megamanHex += "34";
                    break;
                case "R":
                    megamanHex += "35";
                    break;
                case "S":
                    megamanHex += "36";
                    break;
                case "T":
                    megamanHex += "37";
                    break;
                case "U":
                    megamanHex += "38";
                    break;
                case "V":
                    megamanHex += "39";
                    break;
                case "W":
                    megamanHex += "3A";
                    break;
                case "X":
                    megamanHex += "3B";
                    break;
                case "Y":
                    megamanHex += "3C";
                    break;
                case "Z":
                    megamanHex += "3D";
                    break;
                case "“":
                    megamanHex += "3E";
                    break;
                case "”":
                    megamanHex += "3F";
                    break;
                case "'":
                    megamanHex += "40";
                    break;
                case "*":
                    megamanHex += "41";
                    break;
                case ":":
                    megamanHex += "44";
                    break;
                case "$":
                    megamanHex += "45";
                    break;
                case ".":
                    megamanHex += "47";
                    break;
                case ",":
                    megamanHex += "48";
                    break;
                case "-":
                    megamanHex += "49";
                    break;
                case "?":
                    megamanHex += "4B";
                    break;
                case "!":
                    megamanHex += "4C";
                    break;
                case ";":
                    megamanHex += "4D";
                    break;
                case ")":
                    megamanHex += "4E";
                    break;
                case "(":
                    megamanHex += "4F";
                    break;
                case "<":
                    megamanHex += "50";
                    break;
                case "’":
                    megamanHex += "51";
                    break;
                case ">":
                    megamanHex += "52";
                    break;
                case "゜":
                    megamanHex += "53";
                    break;
                case "ﾟ":
                    megamanHex += "54";
                    break;
                case " ":
                    megamanHex += "5F";
                    break;
                case "|":
                    megamanHex += "81";
                    break;
                case "ь":
                    megamanHex += "F8";
                    break;
                case "ё":
                    megamanHex += "F4";
                    break;
                case "Ɠ":
                    megamanHex += "F5";
                    break;
                case "Σ":
                    megamanHex += "F6";
                    break;
                case "ϊ":
                    megamanHex += "F7";
                    break;
                case "ϋ":
                    megamanHex += "F0";
                    break;
                case "ш":
                    megamanHex += "F1";
                    break;
                case "Ě":
                    megamanHex += "F3";
                    break;
                case "~":
                    megamanHex += "FD";
                    break;
                case "®":
                    megamanHex += "FC";
                    break;
                case "#":
                    megamanHex += "FB";
                    break;
                case "»":
                    megamanHex += "60";
                    break;
                case "ś":
                    megamanHex += "EF";
                    break;
                case "¢":
                    megamanHex += "57";
                    break;
                //case "Add":
                // megamanHex += "Add";
                //break;
                default:
                    megamanHex += "5F";
                    break;
            }

            return megamanHex;
        }

    }
}
