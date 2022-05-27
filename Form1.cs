using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace DES
{
    public partial class Form1 : Form
    {
        bool isVetor = false;
        public Form1()
        {
            InitializeComponent();
        }

        public static byte[] StringFromHex(string hex)
        {
            hex = hex.Replace(" ", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //byte[] iv = new byte[] { 0xCC, 0x6F, 0x4F, 0xA9, 0x7E, 0xD7, 0xB0, 0x62 };
            byte[] iv = StringFromHex(textBox1.Text.Replace(" ",""));
            byte[] key = StringFromHex(textBox1.Text.Replace(" ",""));
            byte[] Setdata = StringFromHex(richTextBox1.Text.Replace(" ", ""));

            try
            {
                if (Setdata.Length > 0)
                {
                    try
                    {
                        if (iv.Length > 0)
                        {
                            byte[] data = new byte[0];
                            byte[] Decpacket = new byte[0];
                            byte[] Header = new byte[16];
                            int size = 0;

                            Array.Resize(ref Decpacket, Setdata.Length - 10);//Chave de Autentitaçao
                            Array.Copy(Setdata, 0, Decpacket, 0, Setdata.Length - 10);

                            size = Decpacket.Length;
                            byte[] SetDecpacket = new byte[0];

                            Array.Resize(ref SetDecpacket, Decpacket.Length + 8);//Conteudo
                            Array.Copy(Decpacket, 0, SetDecpacket, 8, size);

                            byte[] descrypt = DESEncryption.DecryptData(SetDecpacket, iv, key);

                            string packetDescrypt = BitConverter.ToString(descrypt).Replace("-", " ");
                            byte[] finalize = StringFromHex(packetDescrypt.Substring(72));
                            string packetDescrypt2 = BitConverter.ToString(finalize);

                            richTextBox2.Text = BitConverter.ToString(finalize).Replace("-", " ");
                            richTextBox3.Text = Encoding.ASCII.GetString(finalize);

                            if (isVetor == true)
                            {
                                byte[] readVetor = new byte[StringFromHex(packetDescrypt.Substring(72)).Length];
                                byte[] newVetor = new byte[8];
                                readVetor = StringFromHex(packetDescrypt.Substring(72));
                                Array.Copy(readVetor, 25, newVetor, 0, 8);
                                textBox1.Text = BitConverter.ToString(newVetor).Replace("-", " ");
                            }

                            getId(finalize);
                            getCompress(finalize[6]);
                            getLen(finalize);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ex.Source);
            }
            //richTextBox2.Text = BitConverter.ToString(DESEncryption.EncryptData(data,iv,key)).Replace("-"," ");
        }

        private void getLen(byte[] finalize)
        {
            SetLen.Text = Convert.ToString(finalize.Length);
        }
        /*private void getLen(byte[] finalize)
        {            
            string id = BitConverter.ToString(finalize, 0).Replace("-", "");
            byte[] setlen = new byte[2];
            setlen[0] = finalize[0];
            setlen[1] = finalize[1];
            Array.Reverse(setlen);
            short num = BitConverter.ToInt16(setlen, 0);
            SetLen.Text = Convert.ToString(num);
        }*/

        private void getCompress(byte Compressor)
        {            
            if (Compressor == 0)
            {
                SetCompress.Text = "Não";
            }
            else if (Compressor == 1)
            {
                SetCompress.Text = "Sim";
            }
        }

        private void getId(byte[] finalize)
        {
            string id = BitConverter.ToString(finalize, 0).Replace("-", "");
            byte[] setid = new byte[2];
            setid[0] = finalize[0];
            setid[1] = finalize[1];
            Array.Reverse(setid);
            short num = BitConverter.ToInt16(setid, 0);
            Setid.Text = Convert.ToString(num);
        }
        private void Clear()
        {
            Setid.Text = "";
            SetLen.Text = "";
            SetCompress.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                isVetor = true;
                textBox1.Text = "C7 D8 C4 BF B5 E9 C0 FD";
            }
            else
            {
                isVetor = false;
            }
        }        
    }
}
