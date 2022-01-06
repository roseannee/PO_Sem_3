using System;
using System.IO;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        ErrorHandling err = new ErrorHandling();

        int listTypeIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void browse_bt_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            path_tb.Text = openFileDialog.FileName;
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Read();
            }
            catch (Exception)
            {
                err.EmptyPathError();
            }
        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Write();
            }
            catch (Exception)
            {
                err.EmptyPathError();
            }
        }

        private void Read()
        {
            using (FileStream fileStream = new FileStream(path_tb.Text, FileMode.Open))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    try
                    {
                        while (binaryReader.PeekChar() > -1)
                        {
                            switch (listTypeIndex)
                            {
                                case 0:
                                    fileContent_rtb.Text += binaryReader.ReadInt32() + " ";
                                    break;

                                case 1:
                                    fileContent_rtb.Text += binaryReader.ReadDouble() + " ";
                                    break;

                                case 2:
                                    tb1.Text += binaryReader.ReadInt32();
                                    tb2.Text += binaryReader.ReadDouble();
                                    tb3.Text += binaryReader.ReadString();
                                    break;

                                case 3:
                                    tb1.Text += binaryReader.ReadString();
                                    tb2.Text += binaryReader.ReadString();
                                    tb3.Text += binaryReader.ReadString();
                                    tb4.Text += binaryReader.ReadInt32();
                                    tb5.Text += binaryReader.ReadInt32();
                                    break;

                                case 4:
                                    int integers = binaryReader.ReadInt32();
                                    int doubles = binaryReader.ReadInt32();

                                    for (int i = 0; i < integers; i++)
                                    {
                                        tb1.Text += binaryReader.ReadInt32() + " ";
                                    }

                                    for (int i = 0; i < doubles; i++)
                                    {
                                        tb2.Text += binaryReader.ReadDouble() + " ";
                                    }
                                    break;

                                case 5:
                                    /*int people = binaryReader.ReadInt32();
                                    for (int i = 0; i < people / 5; i++)
                                    {
                                        fileContent_rtb.Text += binaryReader.ReadString();
                                        fileContent_rtb.Text += "\n" + binaryReader.ReadString();
                                        fileContent_rtb.Text += "\n" + binaryReader.ReadString();
                                        fileContent_rtb.Text += "\n" + binaryReader.ReadDouble();
                                        fileContent_rtb.Text += "\n" + binaryReader.ReadDouble() + "\n";
                                    }*/
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void Write()
        {
            string[] content = fileContent_rtb.Text.Split(' ', '\n');

            using (FileStream fileStream = new FileStream(path_tb.Text, FileMode.Create))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    switch (listTypeIndex)
                    {
                        case 0:
                            foreach (var cont in content)
                            {
                                binaryWriter.Write(Convert.ToInt32(cont));
                            }
                            break;

                        case 1:
                            foreach (var cont in content)
                            {
                                binaryWriter.Write(Convert.ToDouble(cont));
                            }
                            break;

                        case 2:
                            binaryWriter.Write(Convert.ToInt32(tb1.Text));
                            binaryWriter.Write(Convert.ToDouble(tb2.Text));
                            binaryWriter.Write(Convert.ToString(tb3.Text));
                            break;

                        case 3:
                            binaryWriter.Write(Convert.ToString(tb1.Text));
                            binaryWriter.Write(Convert.ToString(tb2.Text));
                            binaryWriter.Write(Convert.ToString(tb3.Text));
                            binaryWriter.Write(Convert.ToInt32(tb4.Text));
                            binaryWriter.Write(Convert.ToInt32(tb5.Text));
                            break;

                        case 4:
                            string[] integers = tb1.Text.Split(' ');
                            string[] doubles = tb2.Text.Split(' ');

                            binaryWriter.Write(integers.Length);
                            binaryWriter.Write(doubles.Length);

                            foreach (string intNum in integers)
                            {
                                binaryWriter.Write(Convert.ToInt32(intNum));
                            }

                            foreach (string doubNum in doubles)
                            {
                                binaryWriter.Write(Convert.ToDouble(doubNum));
                            }
                            break;

                        case 5:
                            /*string[] people = fileContent_rtb.Text.Split('\n');
                            binaryWriter.Write(people.Length);
                            for (int i = 0; i < people.Length - 5; i++)
                            {
                                binaryWriter.Write(Convert.ToString(content[i]));
                                binaryWriter.Write(Convert.ToString(content[i + 1]));
                                binaryWriter.Write(Convert.ToString(content[i + 2]));
                                binaryWriter.Write(Convert.ToInt32(content[i + 3]));
                                binaryWriter.Write(Convert.ToInt32(content[i + 4]));
                            }*/
                            break;

                        default:
                            break;
                    }
                }
            }
        }

        private void listType_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            listTypeIndex = listType_cb.SelectedIndex;

            if (listTypeIndex == 2)
            {
                fileContent_rtb.Visible = false;

                lb1.Text = "integer";
                lb1.Visible = true;
                tb1.Visible = true;

                lb2.Text = "double";
                lb2.Visible = true;
                tb2.Visible = true;

                lb3.Text = "string";
                lb3.Visible = true;
                tb3.Visible = true;
            }
            else if (listTypeIndex == 3)
            {
                fileContent_rtb.Visible = false;

                lb1.Text = "name";
                lb1.Visible = true;
                tb1.Visible = true;

                lb2.Text = "surname";
                lb2.Visible = true;
                tb2.Visible = true;

                lb3.Text = "date of birth";
                lb3.Visible = true;
                tb3.Visible = true;

                lb4.Text = "height";
                lb4.Visible = true;
                tb4.Visible = true;

                lb5.Text = "weight";
                lb5.Visible = true;
                tb5.Visible = true;
            }
            else if (listTypeIndex == 4)
            {
                fileContent_rtb.Visible = false;
                lb3.Visible = false;
                tb3.Visible = false;
                lb4.Visible = false;
                tb4.Visible = false;
                lb5.Visible = false;
                tb5.Visible = false;

                lb1.Text = "inegers";
                lb1.Visible = true;
                tb1.Visible = true;

                lb2.Text = "doubles";
                lb2.Visible = true;
                tb2.Visible = true;
            }
            else
            {
                fileContent_rtb.Visible = true;

                lb1.Visible = false;
                tb1.Visible = false;

                lb2.Visible = false;
                tb2.Visible = false;

                lb3.Visible = false;
                tb3.Visible = false;

                lb4.Visible = false;
                tb4.Visible = false;

                lb5.Visible = false;
                tb5.Visible = false;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileContent_rtb.Clear();

            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
        }
    }
}
