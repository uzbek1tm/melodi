using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace melodi
{
   static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuraction = 60;
        static public int musicDusraction = 10;
        static public bool random = false;
        static public string LastFolder = " ";
        static public bool allDirestry = false;
        static public string playerName1 = "Игрок 1";
        static public string playerName2 = "Игрок 2";
        static public int playerCount1 = 0;
        static public int PlayerCount2 = 0;
        static public string PlayerWiner = " ";
        static public int Winercount = 0;
        static public string answer = " ";
        static public void ReadMusic()
        {
            try
            {
                string[] music_files = Directory.GetFiles(LastFolder, "*.mp3", allDirestry ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(music_files);
            }
            catch
            {

            }
        }
        static string regKey = "Software\\CRABU\\Melodi";
        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKey);
                if (rk == null) return;
                rk.SetValue("LastFolder", LastFolder);
                rk.SetValue("Random", random);
                rk.SetValue("GameDuraction", gameDuraction);
                rk.SetValue("MusicDuraction", musicDusraction);
                rk.SetValue("AllDirectry", allDirestry);
                
               

            }
            finally
            {
                if (rk != null) rk.Close();
            }

        }
        public static void WritePlayerName()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKey);
                if (rk == null) return;
                rk.SetValue("PlayerName1", playerName1);
                rk.SetValue("PlayerName2", playerName2);
               


            }
            finally
            {
                if (rk != null) rk.Close();
            }

        }
        public static void WritePlayerName1()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKey);
                if (rk == null) return;
               
                rk.SetValue("Winer", PlayerWiner);
                rk.SetValue("WinerCount", Winercount);


            }
            finally
            {
                if (rk != null) rk.Close();
            }

        }
        public static void WritePlayerCount()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKey);
                if (rk == null) return;
                rk.SetValue("Count1", playerCount1);
                rk.SetValue("Count2", PlayerCount2);

            }
            finally
            {
                if (rk != null) rk.Close();
            }

        }
        public static void ReadParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKey);
                if(rk!=null)
                {
                    LastFolder = (string)rk.GetValue("LastFolder");
                    gameDuraction = (int)rk.GetValue("GameDuraction");
                    random = Convert.ToBoolean(rk.GetValue("Random", false));
                    musicDusraction = (int)rk.GetValue("MusicDuraction");
                    allDirestry = Convert.ToBoolean(rk.GetValue("AllDirectry", false));
                    playerName1 = (string)rk.GetValue("PlayerName1");
                    playerName2 = (string)rk.GetValue("PlayerName2");
                    


                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }

        }
        public static void ReadParam1()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKey);
                if (rk != null)
                {
                    
                    playerCount1 = (int)rk.GetValue("Count1");
                    PlayerCount2 = (int)rk.GetValue("Count2");

                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }

        }
        public static void ReadParam2()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKey);
                if (rk != null)
                {

                    PlayerWiner = (string)rk.GetValue("Winer");
                    Winercount = (int)rk.GetValue("WinerCount");

                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }

        }


    }
}
