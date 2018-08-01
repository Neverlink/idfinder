using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PortableSteam;
using idfinder;
namespace Dab
{
    class Utility
    {
        public static void FindLetterIds(int count)
        {
            if (count == 2)
            {
                using (StreamWriter sw = File.AppendText("2letterids.txt"))
                {
                    MainForm.mf.totalIds.Maximum = 26 * 26;
                    for (char i = 'a'; i <= 'z'; i++)
                    {
                        for (char j = 'a'; j <= 'z'; j++)
                        {
                            var result = SteamWebAPI.General().ISteamUser().ResolveVanityURL($"{i}{j}").GetResponse();
                            if (result.Data.Message == "No match")
                            {
                                sw.WriteLine($"{i}{j}");
                            }
                            MainForm.mf.totalIds.Value++;
                        }
                    }
                    sw.Flush();
                }
            }
            else if (count == 3)
            {
                using (StreamWriter sw = File.AppendText("3letterids.txt"))
                {
                    MainForm.mf.totalIds.Maximum = 26 * 26 * 26;
                    for (char i = 'a'; i <= 'z'; i++)
                    {
                        for (char j = 'a'; j <= 'z'; j++)
                        {
                            for (char k = 'a'; k <= 'z'; k++)
                            {
                                var result = SteamWebAPI.General().ISteamUser().ResolveVanityURL($"{i}{j}{k}").GetResponse();
                                if (result.Data.Message == "No match")
                                {
                                    sw.WriteLine($"{i}{j}{k}");
                                }
                                MainForm.mf.totalIds.Value++;
                            }
                        }
                    }
                    sw.Flush();
                }
            }
        }

        public static void FindNumberIds(int count)
        {
            if (count == 2)
            {
                using (StreamWriter sw = File.AppendText("2letterids.txt"))
                {
                    MainForm.mf.totalIds.Maximum = 26 * 26;
                    for (int i = 0; i <= 9; i++)
                    {
                        for (int j = 0; j <= 9; j++)
                        {
                            var result = SteamWebAPI.General().ISteamUser().ResolveVanityURL($"{i}{j}").GetResponse();
                            if (result.Data.Message == "No match")
                            {
                                sw.WriteLine($"{i}{j}");
                            }
                            MainForm.mf.totalIds.Value++;
                        }
                    }
                    sw.Flush();
                }
            }
            else if (count == 3)
            {
                using (StreamWriter sw = File.AppendText("3letterids.txt"))
                {
                    MainForm.mf.totalIds.Maximum = 26 * 26 * 26;
                    for (int i = 0; i <= 9; i++)
                    {
                        for (int j = 0; j <= 9; j++)
                        {
                            for (int k = 0; k <= 9; k++)
                            {
                                var result = SteamWebAPI.General().ISteamUser().ResolveVanityURL($"{i}{j}{k}").GetResponse();
                                if (result.Data.Message == "No match")
                                {
                                    sw.WriteLine($"{i}{j}{k}");
                                }
                                MainForm.mf.totalIds.Value++;
                            }
                        }
                    }
                    sw.Flush();
                }
            }
        }

        public static void FindWordIds(int count)
        {

        }
    }
}
