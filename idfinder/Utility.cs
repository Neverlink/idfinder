using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PortableSteam;
using idfinder.Properties;
namespace idfinder
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
                                sw.Flush();
                            }
                            MainForm.mf.totalIds.Value++;
                        }
                    }
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
                                    sw.Flush();
                                }
                                MainForm.mf.totalIds.Value++;
                            }
                        }
                    }
                }
            }
        }

        public static void FindNumberIds(int count)
        {
            if (count == 2)
            {
                using (StreamWriter sw = File.AppendText("2numberids.txt"))
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
                                sw.Flush();
                            }
                            MainForm.mf.totalIds.Value++;
                        }
                    }

                }
            }
            else if (count == 3)
            {
                using (StreamWriter sw = File.AppendText("3numberids.txt"))
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
                                    sw.Flush();
                                }
                                MainForm.mf.totalIds.Value++;
                            }
                        }
                    }
                }
            }
        }

        public static void FindWordIds()
        {
            var words = File.ReadAllLines(Resources.words);
            using (StreamWriter sw = File.AppendText("wordids.txt"))
            {
                MainForm.mf.totalIds.Maximum = words.Length;
                foreach (var word in words)
                {
                    var result = SteamWebAPI.General().ISteamUser().ResolveVanityURL(word).GetResponse();
                    if (result.Data.Message == "No match")
                    {
                        sw.WriteLine(word);
                        sw.Flush();
                    }
                    MainForm.mf.totalIds.Value++;
                }
            }
        }
    }
}

