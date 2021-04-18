using System;
using System.IO;
namespace Recommendation_System
{
    public class Hashing
    {
        string[] name;
        public int size;
        int count = 0; int index = 0;
        public string[] finalstring;

        public Hashing(string path)
        {
            size = File.ReadAllLines(path).Length;
            name = new string[size];
            finalstring = new string[size];

            for (int i = 0; i < size; i++)
                name[i] = "0";
            using (StreamReader sr = new StreamReader(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string s in lines)
                    insertData(s);
            }
        }

        public void insertData(string key)
        {

            for (int i = 0; i < size; i++)
            {
                int sum = 0;
                for (int l = 0; l < 2; l++)
                    sum = (key[0] - 65);
                int hv = sum % size;
                if (name[hv] == "0")
                {
                    name[hv] = key;
                    break;
                }

                else
                {
                    int count12 = 0;
                    for (int j = 0; j < size; j++)
                    {
                        int t = (hv + count12) % size;
                        if (name[t] == "0")
                        {
                            name[t] = key;
                            break;
                        }
                        count12++;
                    }
                    break;
                }
            }
        }

        public void searching(string key)
        {
            for (int i = 0; i < size; i++)
            {
                int sum = 0;
                for (int k = 0; k < 2; k++)
                    sum = (key[0] - 65);
                int hv = sum % size;
                if (name[hv][0] == key[0])
                {
                    for (int m = 0; m < key.Length; m++)
                        if (name[hv][m] == key[m])
                            count++;
                    if (count == key.Length)
                    {

                        finalstring[index] = name[hv];
                        name[hv] = "0";
                        count = 0;
                    }
                    count = 0;
                }
                else
                {
                    int count1 = 0;
                    count = 0;
                    for (int j = 0; j < size; j++)
                    {
                        int t = (hv + count1) % size;
                        if (name[t][0] == key[0])
                        {
                            for (int m = 0; m < key.Length; m++)
                            {
                                if (name[t][m] == key[m])
                                {
                                    Console.WriteLine(name[t]);
                                    count++;
                                }
                            }
                            if (count == key.Length)
                            {
                                finalstring[index] = name[t];
                                index++;
                                name[t] = "0";
                            }
                            count = 0;
                        }
                        count1++;
                    }
                }
            }
        }
    }

}
