using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WowDotNetAPI;
using WowDotNetAPI.Models;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Net;
using System.Windows.Automation;

namespace WindowsFormsApplication4
{
    public partial class Juky : Form
    {
        public Juky()
        {
            InitializeComponent();
            wants66 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            file();
        }
        public string sfile;
        public string ssfile;
        public string sdfile;
        public string banlist;
        public string bbanlist;
        public void file()
        {


            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sfile = (openFileDialog1.FileName);
                ssfile = Environment.CurrentDirectory + "\\Channel_app.txt";
                File.Delete(ssfile);
                File.Copy(sfile, ssfile);
                sdfile = File.ReadAllLines(ssfile).Last();
                textBox1.Text = sfile;

            }
        }
        public string done;
        public string website;
        public string sdd;
        public string msg;
        public int a;
        public int iOffhand;
        public int wants;
        public int wants1;
        public int wants2;
        public string sanvoice;
        public int wants66;
        public int wants3;
        public string TSuser;
        public void sda()


        {
            try
            {
           
            ssfile = Environment.CurrentDirectory + "\\Channel_app.txt";

            File.Delete(ssfile);
            File.Copy(sfile, ssfile);
            sdfile = File.ReadAllLines(ssfile).Last();
            if (string.IsNullOrEmpty(sdfile) == false)
            {


                sdd = sdfile.Remove(10);
                string sww = sdfile.Replace(sdd, "");
                TSuser = sww.Split(':')[0];
                msg = sww.Replace(sww.Split(':')[0] + ":", "");
            }
            banlist = Environment.CurrentDirectory + "\\banlist.txt";
            if (File.Exists(banlist) == false)
            {
                File.AppendAllText(banlist, "crap,");
            }

            g = sdd.Replace("<", "").Replace(">", "");
            bbanlist = File.ReadAllLines(banlist).Last();

            if (g != h && a == 1 && !bbanlist.Contains(TSuser))
            {
                try
                {
                    //    if (TSuser.Contains("gambinooooooo") == true && msg.Contains(".VoiceOff") == true)
                    //    {


                    //        wants3 = 1;
                    //        sendMsg("Voice is Off");
                    //    }
                    //    if (TSuser.Contains("gambinooooooo") == true && msg.Contains(".VoiceOn") == true)
                    //    {

                    //        wants3 = 1;

                    //        sendMsg("Voice is On");
                    //    }
                    //    if (TSuser.Contains("gambinooooooo") == true && wants3 == 1)
                    //    {
                    //        a = 0;
                    //        if (msg.StartsWith(" .") == false && msg.Contains("[URL]") == false)
                    //        {
                    //            SpeechSynthesizer synth = new SpeechSynthesizer();
                    //            synth.SetOutputToDefaultAudioDevice();
                    //            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
                    //            synth.Speak(msg);
                    //        }


                    //        h = g;
                    //        a = 1;
                    //    }
                    if (msg.Contains(".say") == true)
                    {
                        a = 0;
                        if (msg.Contains("[URL]") == false)
                        {
                            string sssss = msg.Replace(".say", "");
                            SpeechSynthesizer synth = new SpeechSynthesizer();
                            synth.SetOutputToDefaultAudioDevice();
                                synth.SelectVoice("IVONA 2 " + sanvoice);
                                synth.Speak(TSuser + "Said," + sssss);
                        }


                        h = g;
                        a = 1;
                    }

                    //if (msg.Contains(".dsay") == true)
                    //{
                    //    a = 0;
                    //    if (msg.Contains("[URL]") == false)
                    //    {
                    //        string sssss = msg.Replace(".dsay", "  ");
                    //        SpeechSynthesizer synth = new SpeechSynthesizer();
                    //        synth.SetOutputToDefaultAudioDevice();
                    //        synth.SelectVoice("IVONA 2 Naja");
                    //        synth.Speak(TSuser + "Said," + sssss);
                    //    }


                    //    h = g;
                    //    a = 1;
                    //}

                    //    if (TSuser.Contains("SindreMA") == true && msg.Contains(".VoiceOff") == true)
                    //    {


                    //        wants2 = 1;
                    //        sendMsg("Voice is Off");
                    //    }
                    //    if (TSuser.Contains("SindreMA") == true && msg.Contains(".VoiceOn") == true)
                    //    {

                    //        wants2 = 1;

                    //        sendMsg("Voice is On");
                    //    }
                    //    if (TSuser.Contains("SindreMA") == true && wants2 == 1)
                    //    {
                    //        a = 0;
                    //        if (msg.StartsWith(" .") == false && msg.Contains("[URL]") == false)
                    //        {
                    //            SpeechSynthesizer synth = new SpeechSynthesizer();
                    //            synth.SetOutputToDefaultAudioDevice();
                    //            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
                    //            synth.Speak(msg);
                    //        }


                    //        h = g;
                    //        a = 1;
                    //    }


                    if (TSuser.Contains("Cather") == true && msg.Contains(".VoiceOff") == true)
                    {


                        wants66 = 0;
                        sendMsg("Voice is Off");
                    }
                    if (TSuser.Contains("Cather") == true && msg.Contains(".VoiceOn") == true)
                    {

                        wants66 = 1;

                        sendMsg("Voice is On");
                    }
                    if (TSuser.Contains("Cather") == true && wants66 == 1)
                    {
                        a = 0;
                            string dsa = msg.Replace(" ", "");
                        if (dsa.StartsWith(".") == false)
                        {
                            SpeechSynthesizer synth = new SpeechSynthesizer();
                            synth.SetOutputToDefaultAudioDevice();
                            synth.SelectVoice("IVONA 2 Nicole");
                            synth.Speak(msg);
                        }
                        h = g;
                        a = 1;
                    }
                        if (TSuser.Contains("Feral") == true)
                        {
                            a = 0;
                            string dsa = msg.Replace(" ", "");
                            if (dsa.StartsWith(".") == false)
                            {
                                SpeechSynthesizer synth = new SpeechSynthesizer();
                                synth.SetOutputToDefaultAudioDevice();
                                synth.SelectVoice("IVONA 2 Eric");
                                synth.Speak(msg);
                            }
                            h = g;
                            a = 1;
                        }
                        if (TSuser.Contains("SindreMA")&& msg.Contains(".sVoice"))
                        {
                            a = 0;

                            string ffdf = msg.Replace(".sVoice","");
                            ffdf = msg.Replace(".sVoice", "");
                            ffdf = ffdf.Replace(" ", "");
                            sanvoice = ffdf;
                            sendMsg("Voice set to " + ffdf);
                            h = g;
                            a = 1;
                        }

                    if (TSuser.Contains("Sanielle") == true && wants == 1)
                    {
                        a = 0;
                            string dsa = msg.Replace(" ", "");
                            if (dsa.StartsWith(".") == false)
                            {
                            SpeechSynthesizer synth = new SpeechSynthesizer();
                            synth.SetOutputToDefaultAudioDevice();
                            synth.SelectVoice("IVONA 2 Salli");
                            synth.Speak(msg);
                        }
                        h = g;
                        a = 1;
                    }
                    if (TSuser.Contains("Vaessa") == true && msg.Contains(".UnBan ") == true || TSuser.Contains("SindreMA") == true && msg.Contains(".UnBan ") == true || TSuser.Contains("Tobíì") == true && msg.Contains(".UnBan ") == true || TSuser.Contains("gambinooooooo") == true && msg.Contains(".UnBan ") == true || TSuser.Contains("shabbus") == true && msg.Contains(".UnBan ") == true || TSuser.Contains("Sanielle") == true && msg.Contains(".UnBan ") == true)
                    {
                        a = 0;
                        string potato = msg.Replace(".UnBan ", "");
                        bbanlist = File.ReadAllLines(banlist).Last().Replace(msg, "");
                        File.Delete(banlist);
                        File.AppendAllText(bbanlist, banlist);

                        sendMsg(potato + " is unbanned!");
                        h = g;
                        a = 1;
                    }
                    if (TSuser.Contains("Vaessa") == true && msg.Contains(".Ban ") == true || TSuser.Contains("SindreMA") == true && msg.Contains(".Ban ") == true || TSuser.Contains("Tobíì") == true && msg.Contains(".Ban ") == true || TSuser.Contains("gambinooooooo") == true && msg.Contains(".Ban ") == true || TSuser.Contains("shabbus") == true && msg.Contains(".Ban ") == true || TSuser.Contains("Sanielle") == true && msg.Contains(".Ban ") == true)
                    {
                        a = 0;
                        string potato = msg.Replace(".Ban ", "");

                        File.AppendAllText("Banlist.txt", potato + ",");

                        sendMsg(potato + " is banned!");
                        h = g;
                        a = 1;
                    }

                    if (TSuser.Contains("Vaessa") && msg.Contains(".MusicOff") == true || TSuser.Contains("SindreMA") && msg.Contains(".MusicOff") == true || TSuser.Contains("Tobíì") && msg.Contains(".MusicOff") == true || TSuser.Contains("gambinooooooo") && msg.Contains(".MusicOff") == true || TSuser.Contains("shabbus") == true && msg.Contains(".MusicOff") == true)
                    {

                        wants1 = 0;


                        sendMsg("Music is Off");
                    }
                    if (TSuser.Contains("Vaessa") && msg.Contains(".MusicOn") == true || TSuser.Contains("SindreMA") && msg.Contains(".MusicOn") == true || TSuser.Contains("Tobíì") && msg.Contains(".MusicOn") == true || TSuser.Contains("gambinooooooo") && msg.Contains(".MusicOn") == true || TSuser.Contains("shabbus") == true && msg.Contains(".MusicOn") == true)
                    {

                        wants1 = 1;

                        sendMsg("Music is On");
                    }
                    //if (msg.Contains(".oldplay") == true && msg.Contains("[URL]") == true && wants1 == 1)
                    //{
                    //    a = 0;

                    //    if (msg.Contains("youtube") == true || msg.Contains("Youtube"))
                    //    {
                    //        try
                    //        {


                    //            //if (Youtube.IsDisposed == true)
                    //            //{
                    //            InitializeComponent();
                    //            //} 
                    //        }
                    //        catch { };

                    //        string cmd = msg.Replace(".play ", "");
                    //        string site = cmd.Replace("[URL]", "");
                    //        website = site.Replace("[/URL]", "");
                    //        string website1 = website.Replace("watch?v=", @"v/") + "?autoplay=1";
                    //        videotitle = GetPageTitle(website).Replace("- YouTube", "");
                    //        Thread.Sleep(1000);
                    //        sendMsg("Playing : " + videotitle);

                    //        h = g;
                    //        /*
                    //        Process.Start("powershell.exe", "/C Stop-Process -name opera");
                    //        done = "";
                    //        string cmd = msg.Replace(".play ", "");
                    //        string site = cmd.Replace("[URL]", "");
                    //        website = site.Replace("[/URL]", "");
                    //        Thread.Sleep(3000);
                    //        Process.Start(@"C:\Program Files (x86)\Opera\launcher.exe", website);
                    //        Thread.Sleep(4000);
                    //        h = g;
                    //        whatsPlaying();
                    //        Thread.Sleep(5000);
                    //        */
                    //    }
                    //    else if (msg.Contains("youtu.be") == true)
                    //    {

                    //        sendMsg("youtu.be is not supported, yet.");
                    //        Thread.Sleep(1000);
                    //        h = g;
                    //    }
                    //    a = 1;
                    //}



                    if (msg.Contains(".play") == true && msg.Contains("[URL]") == true && wants1 == 1)
                    {
                        a = 0;
                        try
                        {
                        }
                        catch { };
                        string cmd = msg.Replace(".play ", "");
                        string site = cmd.Replace("[URL]", "");
                        website = site.Replace("[/URL]", "");
                        videotitle = GetPageTitle(website).Replace("- YouTube", "");
                        Thread.Sleep(1000);
                        sendMsg("Playing =  " + videotitle);
                        Process.Start("powershell.exe", "/C Stop-Process -name opera");
                        done = "";
                       
                        Thread.Sleep(1000);

                        Process[] processlist = Process.GetProcesses();

                        foreach (Process process in processlist)
                        {
                            if (process.MainWindowTitle.Contains("wershe") == true)

                                while (!process.HasExited)
                                {
                                    Thread.Sleep(500);
                                }
                        }
                        Thread.Sleep(2500);
                        Process.Start(@"C:\Program Files (x86)\Opera\launcher.exe", website);
                        h = g;


                        a = 1;
                    }

                    //////////////////////////WEB

                    //if (msg.Contains(".audioplay") == true && msg.Contains("[URL]") == true && wants1 == 1)
                    //{
                    //    a = 0;

                    //    if (msg.Contains("youtube") == true || msg.Contains("Youtube"))
                    //    {
                    //        File.Delete("audio.html");
                    //        webBrowser1.Navigate("google.com");
                    //        string cmd = msg.Replace(".audioplay ", "");
                    //        string site = cmd.Replace("[URL]", "");
                    //        website = site.Replace("[/URL]", "");
                    //        string website1 = website.Replace("watch?v=", @"v/") + "?version=2&autoplay=1&theme=dark";
                    //        website1 =  website1.Replace(" ", "");
                    //        videotitle = GetPageTitle(website).Replace("- YouTube", "");
                    //        File.AppendAllText("audio.html", "<object type=\"application/x-shockwave-flash\" width=\"30\" height=\"25\" data=\""+website1+"\"><param name=\"movie\" value=\""+website1+"\"/><param name=\"wmode\" value=\"transparent\"/></object>");
                    //        webBrowser1.Navigate(Environment.CurrentDirectory + "audio.html");
                    //        Thread.Sleep(1000);
                    //        sendMsg("Playing : " + videotitle);

                    //        h = g;
                    //    }
                    //    else if (msg.Contains("youtu.be") == true)
                    //    {

                    //        sendMsg("youtu.be is not supported, yet.");
                    //        Thread.Sleep(1000);
                    //        h = g;
                    //    }
                    //    a = 1;
                    //}

                    /////////////////////////WEB



                    if (msg.Contains(".stop video"))
                    {
                        a = 0;
                        try
                        {
                            youstop();
                            Process.Start("powershell.exe", "/C Stop-Process -name opera");
                            h = g;
                            Thread.Sleep(3000);
                            sendMsg("Video have been stopped!");
                            Thread.Sleep(5000);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        a = 1;
                    }
                    if (msg.Contains(".gif link") == true)
                    {
                        a = 0;
                        h = g;
                        Thread.Sleep(1000);
                        sendMsg("The current video link is : " + website + " ");

                        Thread.Sleep(1000);
                        Thread.Sleep(5000);
                        a = 1;
                    }

                    if (msg.Contains(".pause") == true)
                    {
                        a = 0;
                        focus();
                        h = g;
                        youtubeContol("k");
                        sendMsg("Video is Paused");
                        a = 1;
                    }
                    if (msg.Contains(".resume") == true)
                    {
                        a = 0;
                        focus();
                        h = g;
                        youtubeContol("k");
                        sendMsg("Video is Resume");
                        a = 1;
                    }
                    if (msg.Contains(".<<") == true)
                    {
                        a = 0;
                        focus();
                        h = g;
                        youtubeContol("J");
                        youtubeContol("J");
                        youtubeContol("J");
                        sendMsg("Skipped 30 sec backwards");
                        a = 1;
                    }
                    if (msg.Contains(".>>") == true)
                    {
                        a = 0;
                        focus();
                        h = g;
                        youtubeContol("L");
                        youtubeContol("L");
                        youtubeContol("L");
                        sendMsg("Skipped 30 sec forward");
                        a = 1;
                    }
                    if (msg.Contains(".noob") == true || msg.Contains("who is the scrub here?"))
                    {
                        a = 0;
                        h = g;
                        Thread.Sleep(1000);
                        sendMsg("ZHORIQUE IS THE SCRUB!!!!");
                        Thread.Sleep(5000);
                        a = 1;
                    }
                    if (msg.Contains(".help") == true)
                    {
                        a = 0;
                        h = g;
                        Thread.Sleep(1000);
                        sendMsg(".\n" +
                            "Use  .  before every command so Juky can see it\n" +
                            "------------------------------------------------------------- \n" +
                            ".play youtube_URL_Here - use this to send video request \n" +
                            ".pause or resume - use this to pause/resume the video \n" +
                            ".gif link  - use this to send video request \n" +
                            ".armory user#realm   - use this to get armory link for wow \n" +
                            ".ilvl user#realm   - use this to get the item level for a character\n" +
                            ".core raiders - use this to get a list of the core raiders \n" +
                            ".logs  - use this to get the link to the logs \n" +
                            ".website - use to get the link to our website\n" +
                            ".core ilvl  - use this to see the ilvl of the core team\n" +
                            "Fun commands: .zhorique , .execute order 66 , .pull , .Special\n" +
                            "-------------------------------------------------------------");

                        Thread.Sleep(1000);
                        a = 1;
                    }
                    if (msg.Contains(".zhorique") == true)
                    {
                        a = 0;
                        h = g;
                        Thread.Sleep(1000);
                        sendMsg("Oh the low dps you mean?");
                        Thread.Sleep(5000);
                        a = 1;
                    }
                    if (msg.Contains(".execute order 66") == true && wants1 == 1)
                    {


                        a = 0;
                        try
                        {
                        }
                        catch { };
                        Process.Start("powershell.exe", "/C Stop-Process -name opera");
                        done = "";
                        string cmd = msg.Replace(".play ", "");
                        string site = cmd.Replace("[URL]", "");
                        website = site.Replace("[/URL]", "");
                        Thread.Sleep(1000);

                        Process[] processlist = Process.GetProcesses();

                        foreach (Process process in processlist)
                        {
                            if (process.MainWindowTitle.Contains("wershe") == true)

                                while (!process.HasExited)
                                {
                                    Thread.Sleep(100);
                                }
                        }
                            Thread.Sleep(3000);
                            Process.Start(@"C:\Program Files (x86)\Opera\launcher.exe", "https://www.youtube.com/watch?v=-bzWSJG93P8");
                        h = g;


                        a = 1;

                    }
                    if (msg.Contains(".pull") == true)
                    {
                        a = 0;
                        h = g;
                        Thread.Sleep(1000);
                        sendMsg("Zhorique go for the ninjaPull!");
                        Thread.Sleep(5000);
                        h = g;
                        a = 1;
                    }
                    if (msg.Contains(".website") == true)
                    {
                        a = 0;
                        h = g;
                        Thread.Sleep(1000);
                        sendMsg("Our Website is = http://persistence-wow.enjin.com/home");
                        Thread.Sleep(5000);
                        h = g;
                        a = 1;
                    }
                    if (msg.Contains(".Special") == true)
                    {
                        a = 0;
                        h = g;
                        Thread.Sleep(1000);
                        sendMsg("Just because your special zoey doesnt mean your usefull");
                        Thread.Sleep(5000);
                        h = g;
                        a = 1;
                    }
                    if (msg.Contains(".armory ") == true)
                    {
                        a = 0;
                        string l = msg.Replace("armory ", "").Split('#')[0];
                        string e = msg.Replace("armory ", "").Split('#')[1];
                        string t = @"Armory for " + l + " = http://eu.battle.net/wow/en/character/" + e + @"/" + l + @"/simple";
                        string r = t.Replace(" ", "").Replace(".", "");
                        sendMsg(r.Replace("=", " = ").Replace("for", " for "));
                        a = 1;
                    }
                    if (msg.Contains(".ilvl") == true)
                    {
                        a = 0;
                        h = g;
                        sendMsg("Ono momento!");
                        Thread.Sleep(1000);
                        string user = msg.Replace(".ilvl ", "").Split('#')[0];
                        string realm = msg.Replace(".ilvl ", "").Split('#')[1];
                        all = 0;
                        wowchar(user, realm);

                        sendMsg("Item level for " + user + " is =" + all);
                        Thread.Sleep(5000);
                        h = g;
                        a = 1;
                    }
                    if (msg.Contains(".core raiders") == true)
                    {
                        a = 0;
                        h = g;

                        WowExplorer explorer = new WowExplorer(WowDotNetAPI.Region.EU, Locale.en_GB, "######################################");
                        WowDotNetAPI.Models.Guild wow = new Guild();
                        string guild = "Persistence";
                        string Realm = "Silvermoon";
                        string va = "";

                        Guild item = explorer.GetGuild(WowDotNetAPI.Region.EU, Realm, guild, GuildOptions.GetEverything);
                        foreach (var item1 in item.Members)
                        {

                            if (item1.Rank == 5 || item1.Rank == 0 || item1.Rank == 1 || item1.Rank == 4)
                            {
                                va = va + ", " + (item1.Character.Name.ToString());
                            }

                        }

                        sendMsg(va);
                        h = g;
                        Thread.Sleep(3000);
                        h = g;
                        a = 1;
                        sumdev = 0;
                    }
                    if (msg.Contains(".core ilvl") == true)
                    {
                        a = 0;
                        h = g;
                        sendMsg("Ohdear, thats alot of users, im gona need a sec...");
                        WowExplorer explorer = new WowExplorer(WowDotNetAPI.Region.EU, Locale.en_GB, "##############################");
                        WowDotNetAPI.Models.Guild wow = new Guild();
                        string guild = "Persistence";
                        string Realm = "Silvermoon";
                        string va = "";

                        Guild item = explorer.GetGuild(WowDotNetAPI.Region.EU, Realm, guild, GuildOptions.GetEverything);
                        foreach (var item1 in item.Members)
                        {

                            if (item1.Rank == 5 || item1.Rank == 0 || item1.Rank == 1 || item1.Rank == 4)
                            {
                                va = va + ", " + (item1.Character.Name.ToString());


                                WowExplorer explorer2 = new WowExplorer(WowDotNetAPI.Region.EU, Locale.en_GB, "##############################");
                                WowDotNetAPI.Models.CharacterItem wow2 = new CharacterItem();
                                string user2 = item1.Character.Name;

                                total = 0;
                                Character item2 = explorer2.GetCharacter(Realm, user2, CharacterOptions.GetEverything);
                                int iFinger1 = item2.Items.Finger1.ItemLevel;
                                int iFinger2 = item2.Items.Finger2.ItemLevel;
                                int iHead = item2.Items.Head.ItemLevel;
                                int iBack = item2.Items.Back.ItemLevel;
                                int iWrist = item2.Items.Wrist.ItemLevel;
                                int iWaist = item2.Items.Waist.ItemLevel;
                                int iFeet = item2.Items.Feet.ItemLevel;
                                int iChest = item2.Items.Chest.ItemLevel;
                                int iWeapon = item2.Items.MainHand.ItemLevel;
                                int iShoulders = item2.Items.Shoulder.ItemLevel;
                                int iTrinket1 = item2.Items.Trinket1.ItemLevel;
                                int iTrinket2 = item2.Items.Trinket2.ItemLevel;
                                int iNeck = item2.Items.Neck.ItemLevel;
                                int iHands = item2.Items.Hands.ItemLevel;
                                int iLegs = item2.Items.Legs.ItemLevel;
                                try
                                {
                                    iOffhand = item2.Items.OffHand.ItemLevel;
                                }
                                catch { iOffhand = 0; }


                                if (iOffhand == 0)
                                {
                                    int sumint1 = (iHead) + (iNeck) + (iShoulders) + (iBack) + (iChest) + (iWrist) + (iHands) + (iWaist) + (iLegs) + (iFeet) + (iFinger1) + (iFinger2) + (iTrinket1) + (iTrinket2) + (iWeapon);
                                    sumdev = (sumint1) / (15);
                                }
                                else
                                {

                                    int sumint1 = (iHead) + (iNeck) + (iShoulders) + (iBack) + (iChest) + (iWrist) + (iHands) + (iWaist) + (iLegs) + (iFeet) + (iFinger1) + (iFinger2) + (iTrinket1) + (iTrinket2) + (iWeapon) + (iOffhand);
                                    sumdev = (sumint1) / (16);
                                }
                                total++;

                                all = sumdev / total;

                            }

                        }
                        sendMsg("Here you go ;D");
                        h = g;
                        sendMsg("Current avg Item Level = " + all);
                        Thread.Sleep(3000);
                        h = g;
                        a = 1;
                        sumdev = 0;
                    }

                    if (msg.Contains(".logs") == true)
                    {
                        a = 0;
                        h = g;
                        Thread.Sleep(1000);
                        sendMsg(@"https://www.warcraftLogs.com/guilds/122793/");

                        Thread.Sleep(5000);
                        h = g;
                        a = 1;
                    }


                }
                catch
                {
                    h = g;
                    a = 1;
                    sendMsg("Im getting errors all over the place, what did u DO??");
                    Thread.Sleep(5000);

                }




            }
            }
            catch { }
        }
        public void wowchar(string user, string realm)
        {

            WowExplorer explorer2 = new WowExplorer(WowDotNetAPI.Region.EU, Locale.en_GB, "##############################");
            WowDotNetAPI.Models.CharacterItem wow2 = new CharacterItem();
            string user2 = user;

            total = 0;
            Character item2 = explorer2.GetCharacter(realm, user2, CharacterOptions.GetEverything);
            int iFinger1 = item2.Items.Finger1.ItemLevel;
            int iFinger2 = item2.Items.Finger2.ItemLevel;
            int iHead = item2.Items.Head.ItemLevel;
            int iBack = item2.Items.Back.ItemLevel;
            int iWrist = item2.Items.Wrist.ItemLevel;
            int iWaist = item2.Items.Waist.ItemLevel;
            int iFeet = item2.Items.Feet.ItemLevel;
            int iChest = item2.Items.Chest.ItemLevel;
            int iWeapon = item2.Items.MainHand.ItemLevel;
            int iShoulders = item2.Items.Shoulder.ItemLevel;
            int iTrinket1 = item2.Items.Trinket1.ItemLevel;
            int iTrinket2 = item2.Items.Trinket2.ItemLevel;
            int iNeck = item2.Items.Neck.ItemLevel;
            int iHands = item2.Items.Hands.ItemLevel;
            int iLegs = item2.Items.Legs.ItemLevel;
            try
            {
                iOffhand = item2.Items.OffHand.ItemLevel;
            }
            catch { iOffhand = 0; }


            if (iOffhand == 0)
            {
                int sumint1 = (iHead) + (iNeck) + (iShoulders) + (iBack) + (iChest) + (iWrist) + (iHands) + (iWaist) + (iLegs) + (iFeet) + (iFinger1) + (iFinger2) + (iTrinket1) + (iTrinket2) + (iWeapon);
                sumdev = (sumint1) / (15);
            }
            else
            {

                int sumint1 = (iHead) + (iNeck) + (iShoulders) + (iBack) + (iChest) + (iWrist) + (iHands) + (iWaist) + (iLegs) + (iFeet) + (iFinger1) + (iFinger2) + (iTrinket1) + (iTrinket2) + (iWeapon) + (iOffhand);
                sumdev = (sumint1) / (16);
            }
            total++;

            all = sumdev / total;
        }
        public int total;
        public int all;
        public int sumdev;
        public string p;
        public string g;
        public string h;
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Online";
            timer1.Start();
        }
        public int i;
        private void timer1_Tick(object sender, EventArgs e)
        {

            sda();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Offline";
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = 1;
            sanvoice = "Russell";
            label1.Text = "Offline";
            i = 0;
            wants = 1;
            wants1 = 1;
        }
        public string b;
        [DllImport("User32.dll")]
        static extern bool SetForegroundWindow(IntPtr point);
        public void focus()
        {


            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    if (process.MainWindowTitle.Contains("pera") == true)
                    {
                        int id = process.Id;

                        Process p = Process.GetProcessById(id);
                        if (p != null)
                        {
                            IntPtr h = p.MainWindowHandle;
                            SetForegroundWindow(h);
                            AutomationElement element = AutomationElement.FromHandle(process.MainWindowHandle);
                            if (element != null)
                            {
                                element.SetFocus();
                            }

                        }

                    }

                }
            }
        }

        public void youtubeContol(string action)
        {

            //IntPtr hh = pp.MainWindowHandle;
            //focus();
            //Thread.Sleep(800);
            Focus();
            Thread.Sleep(1000);
            SendKeys.SendWait(action);
            Thread.Sleep(500);
            Thread.Sleep(1000);
            Thread.Sleep(1000);


        }
        public void sendMsg(string melding)
        {


            Process p = Process.GetProcessesByName("ts3client_win32").FirstOrDefault();
            if (p != null)
            {
                IntPtr h = p.MainWindowHandle;
                SetForegroundWindow(h);
                AutomationElement element = AutomationElement.FromHandle(p.MainWindowHandle);
                if (element != null)
                {
                    element.SetFocus();
                }
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("{ENTER}");
                SendKeys.SendWait(melding);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(350);
                SendKeys.Send("{ENTER}");

            }
        }
        public void whatsPlaying()
        {
            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {

                    if (process.MainWindowTitle.Contains("Opera") == true)
                    {
                        b = process.MainWindowTitle;
                        b = b.Replace("- YouTube - Opera", "");

                    }

                }
            }


            Process p = Process.GetProcessesByName("ts3client_win32").FirstOrDefault();
            if (p != null)
            {
                
                IntPtr h = p.MainWindowHandle;
                SetForegroundWindow(h);
                AutomationElement element = AutomationElement.FromHandle(p.MainWindowHandle);
                if (element != null)
                {
                    element.SetFocus();
                }
                SendKeys.Send("{BACKSPACE}");
                SendKeys.SendWait("Playing  " + b);
                SendKeys.Send("{ENTER}");
                SendKeys.Send("{ENTER}");



            }
        }
        static string GetPageTitle(string link)
        {
            try
            {
                WebClient wc = new WebClient();
                string html = wc.DownloadString(link);

                Regex x = new Regex("<title>(.*)</title>");
                MatchCollection m = x.Matches(html);

                if (m.Count > 0)
                {
                    return m[0].Value.Replace("<title>", "").Replace("</title>", "");
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not connect. Error:" + ex.Message);
                return "";
            }
        }
        public string videotitle;
        private void button4_Click(object sender, EventArgs e)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                foreach (InstalledVoice voice in synth.GetInstalledVoices())
                {
                    MessageBox.Show(voice.VoiceInfo.Name);
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
        public void youstop()
        {
        }
    }
}
