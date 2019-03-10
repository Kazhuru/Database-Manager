using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace FileManager
{
    public class IndexHandler
    {
        public bool KeyType { get; set; }
        public string[,] KArray { get; set; }
        public int Count { get; set; }
        public Attribute CurrentAttribute { get; set; }
        public string IdxURL { get; set; }
        public DataHandler Dh { get; set; }

        public IndexHandler()
        {
        }

        /// <summary>
        /// PK nad FK index initializer 
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="currAtt"></param>
        /// <param name="path"></param>
        public void SetIndexHandler(bool mode,Attribute currAtt,string path, DataHandler indh)
        {
            Dh = indh;
            KeyType = mode;
            KArray = KeyType ? new string[2, 20] : new string[20, 20];
            FillArr();
            Count = 0;
            CurrentAttribute = currAtt;
            IdxURL = path;
            UpdateIndexFile();
        }

        /// <summary>
        /// method that set the PKs or FKs array
        /// </summary>
        private void FillArr()
        {
            int N = KeyType ? 2 : 20;
            for (int j = 0; j < 20; j++)
                for (int i = 0; i < N; i++)
                    KArray[i, j] = "-1";
        }

        /// <summary>
        /// method that adds a new Register value to the index
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="RegAdrs"></param>
        public void Add(string Key, long RegAdrs)
        {
            if (Count == 0)
            {
                KArray[0, Count] = Key;
                KArray[1, Count] = RegAdrs.ToString();
                Count++;
                UpdateIndexFile();
            }
            else
            {
                if (KeyType)
                {   //PK
                    int posToInsert = CheckIdxKeyPos(Key);
                    if(posToInsert == -1)
                    {
                        KArray[0, Count] = Key;
                        KArray[1, Count] = RegAdrs.ToString();
                        Count++;
                        UpdateIndexFile();
                    }
                    else
                    {
                        for (int i = Count; i >= posToInsert; i--)
                        {
                            if (i == posToInsert)
                            {
                                KArray[0, i] = Key;
                                KArray[1, i] = RegAdrs.ToString();
                            }
                            else
                            {
                                KArray[0, i] = KArray[0, i - 1];
                                KArray[1, i] = KArray[1, i - 1];
                            }
                        }
                        Count++;
                        UpdateIndexFile();
                    }
                }
                else
                {   //FK
                    int pos = -1;
                    for (int i = 0; i < 20; i++)
                        if (KArray[0, i] == Key)
                        {
                            pos = i;
                            break;
                        }
                    if (pos != -1)
                    {   //Exists the index
                        string end = "";
                        int c = 1;
                        while(end != "-1")
                        {
                            end = KArray[c, pos];
                            if(end == "-1")
                                KArray[c, pos] = RegAdrs.ToString();
                            UpdateIndexFile();
                            c++;
                        }
                    }
                    else
                    {   //No Exist the index
                        int posToInsert = CheckIdxKeyPos(Key);
                        if(posToInsert == -1)
                        {   //final insert
                            KArray[0, Count] = Key;
                            KArray[1, Count] = RegAdrs.ToString();
                            Count++;
                            UpdateIndexFile();
                        }
                        else
                        {   //no final insert
                            for (int i = Count; i >= posToInsert; i--)
                                for (int h = 0; h < 20; h++)
                                {
                                    if (i == posToInsert)
                                    {
                                        if (h == 0)
                                        {
                                            KArray[0, i] = Key;
                                            KArray[1, i] = RegAdrs.ToString();
                                            h++;
                                        }
                                        else
                                            KArray[h, i] = "-1";
                                    }
                                    else
                                        KArray[h, i] = KArray[h, i - 1];
                                }
                            Count++;
                            UpdateIndexFile();
                        } 
                    }
                }
            }
        }

        /// <summary>
        /// method that removes the selected Register value to the index
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="RegAdrs"></param>
        public void Remove(string Key, long RegAdrs)
        {
            int pos = -1;  //position to remove the stuff
            for (int i = 0; i < 20; i++)
                if (KArray[0, i] == Key)
                {
                    pos = i;
                    break;
                }
            if (KeyType)
            {   //PK
                for (int i = pos; i < Count; i++)
                {
                    KArray[0, i] = KArray[0, i + 1];
                    KArray[1, i] = KArray[1, i + 1];
                }
                Count--;
                UpdateIndexFile();
            }
            else
            {   //FK
                string end = "";
                int startsMinusOne = 1;
                int findIdx = -1;
                while (end != "-1")
                {
                    end = KArray[startsMinusOne, pos];
                    if (RegAdrs == long.Parse(end))
                        findIdx = startsMinusOne;
                    if (end != "-1")
                        startsMinusOne++;
                }
                if (startsMinusOne == 2)
                {   //last to delete
                    for (int i = pos; i < Count; i++)
                        for (int h = 0; h < 20; h++)
                            KArray[h, i] = KArray[h, i + 1];
                    Count--;
                    UpdateIndexFile();
                }
                else
                {   //remains stuff
                    for (int i = findIdx; i < startsMinusOne; i++)
                        KArray[i, pos] = KArray[i + 1, pos];
                    UpdateIndexFile();
                }
            }
        }

        /// <summary>
        /// method that locates the idx position for PKs and FKs
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        private int CheckIdxKeyPos(string Key)
        {
            for (int i = 0; i < Count; i++)
            {
                if (CurrentAttribute.DataType == "STRING")
                {
                    if (KArray[0, i].CompareTo(Key) == 1)
                        return i;
                }
                else
                {
                    if (int.Parse(KArray[0, i]).CompareTo(int.Parse(Key)) == 1)
                        return i;
                }
            }
            //last in the list
            return -1;
        }

        /// <summary>
        /// method that updates the Pk or Fk changes in to the file.idx
        /// </summary>
        private void UpdateIndexFile()
        {
            
        }

        /// <summary>
        /// method that restores the index data to memory from the file.idx PK and FK only
        /// </summary>
        public void RestoreIndex()
        {

        }
    }
}
