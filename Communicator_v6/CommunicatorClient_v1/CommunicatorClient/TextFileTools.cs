using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicatorClient
{
    class TextFileTools
    {
        public static void writeFile(string path, string fileName, string data)
        {
            FileStream fout = new FileStream(path + fileName, FileMode.Create);
            //lub w Moje Dokumenty:
            //fout = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\dane.txt", FileMode.Append);
            //tworzymy strumień znaków połączony z plikiem tekstowym w trybie Create
            StreamWriter fstr_out = new StreamWriter(fout); //tworzymy strumień wyjściowy
            fstr_out.Write(data); //zapisujemy łańcuch do pliku
            fstr_out.Close(); // zamykamy plik
        }

        public static string readFile(string path, string fileName)
        {
            try
            {
                FileStream fin = new FileStream(path + fileName, FileMode.Open);
                //tworzymy strumień znaków połączony z plikiem tekstowym w trybie Open
                StreamReader fstr_in = new StreamReader(fin); //tworzymy strumień wejściowy

                string data = "";
                string data1;
                while ((data1 = fstr_in.ReadLine()) != null)
                {
                    data += data1;
                }
                fstr_in.Close(); // zamykamy odczyt
                fin.Close(); // zamykamy plik
                return data;
            }
            catch
            {
                return "Błąd załadowania rozmowy z pliku";
            }
        }
    }
}

