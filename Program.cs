using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check if there's an argument
            if (args.Length == 1)
            {
                //Put the entire file content in a buffer
                byte[] input = File.ReadAllBytes(args[0]);
                //Prepare the future output file
                List<string> output = new List<string>();

                //From offset 0x12 to 0x37D, loop the following
                for (int i = 0x12; i < 0x37D; i += 7)
                {
                    //Prepare empty string
                    string temp = "";

                    //To the string:
                    temp += (char)input[i + 0];                   //Add first char of ID (char treats the value as a letter)
                    temp += (char)input[i + 1];                   //Add second char of ID
                    temp += (char)input[i + 2];                   //Add third char of ID
                    temp += (char)input[i + 3];                   //Add fourth char of ID
                    temp += input[i + 4].ToString("X2");          //Add 5th byte in hex
                    temp += input[i + 5].ToString("X2");          //Add 6th byte in hex
                    temp += " " + input[i + 6].ToString("X2");    //Add 7th byte in hex (amount of writes?)

                    string mvl = "";

                    mvl += (char)input[i + 0];
                    mvl += (char)input[i + 1];
                    mvl += (char)input[i + 2];
                    mvl += (char)input[i + 3];

                    if (mvl == "MVL ")
                    { temp += (" - Maerchen Veil"); }

                    ///

                    string esp = "";

                    esp += (char)input[i + 0];
                    esp += (char)input[i + 1];
                    esp += (char)input[i + 2];
                    esp += (char)input[i + 3];

                    if (esp == "ESP ")
                    { temp += (" - Esper Dream"); }

                    ///

                    string tt2 = "";

                    tt2 += (char)input[i + 0];
                    tt2 += (char)input[i + 1];
                    tt2 += (char)input[i + 2];
                    tt2 += (char)input[i + 3];

                    if (esp == "TT2 ")
                    { temp += (" - Time Twist - Rekishi no Katasumi de..."); }

                    ///

                    string dan = "";

                    dan += (char)input[i + 0];
                    dan += (char)input[i + 1];
                    dan += (char)input[i + 2];
                    dan += (char)input[i + 3];

                    if (dan == "DAN ")
                    { temp += (" - Dandy - Zeuon no Fukkatsu"); }

                    ///

                    string qho = "";

                    qho += (char)input[i + 0];
                    qho += (char)input[i + 1];
                    qho += (char)input[i + 2];
                    qho += (char)input[i + 3];

                    if (qho == "QHO ")
                    { temp += (" - Unknown?"); }

                    ///

                    string utm = "";

                    utm += (char)input[i + 0];
                    utm += (char)input[i + 1];
                    utm += (char)input[i + 2];
                    utm += (char)input[i + 3];

                    if (utm == "UTM ")
                    { temp += (" - Tama & Friends - Sanchoume Daibouken"); }

                    ///

                    string ain = "";

                    ain += (char)input[i + 0];
                    ain += (char)input[i + 1];
                    ain += (char)input[i + 2];
                    ain += (char)input[i + 3];

                    if (ain == "AIN ")
                    { temp += (" - Ai Senshi Nicol"); }

                    ///

                    string dpd = "";

                    dpd += (char)input[i + 0];
                    dpd += (char)input[i + 1];
                    dpd += (char)input[i + 2];
                    dpd += (char)input[i + 3];

                    if (dpd == "DPD ")
                    { temp += (" - Madou Senki - Deep Dungeon"); }

                    ///

                    string ysm = "";

                    ysm += (char)input[i + 0];
                    ysm += (char)input[i + 1];
                    ysm += (char)input[i + 2];
                    ysm += (char)input[i + 3];

                    if (ysm == "YSM ")
                    { temp += (" - Yuushi no Monshou - Deep Dungeon"); }

                    ///

                    string akm = "";

                    akm += (char)input[i + 0];
                    akm += (char)input[i + 1];
                    akm += (char)input[i + 2];
                    akm += (char)input[i + 3];

                    if (akm == "AKM ")
                    { temp += (" - Akumajou Dracula"); }

                    ///

                    string fco = "";

                    fco += (char)input[i + 0];
                    fco += (char)input[i + 1];
                    fco += (char)input[i + 2];
                    fco += (char)input[i + 3];

                    if (fco == "FCO ")
                    { temp += (" - Family Composer"); }

                    ///

                    string lnk = "";

                    lnk += (char)input[i + 0];
                    lnk += (char)input[i + 1];
                    lnk += (char)input[i + 2];
                    lnk += (char)input[i + 3];

                    if (lnk == "LNK ")
                    { temp += (" - Link no Bouken - The Legend of Zelda 2"); }

                    ///

                    string nmj = "";

                    nmj += (char)input[i + 0];
                    nmj += (char)input[i + 1];
                    nmj += (char)input[i + 2];
                    nmj += (char)input[i + 3];

                    if (lnk == "NMJ ")
                    { temp += (" - Nazo no Murasamejou"); }

                    ///

                    string grn = "";

                    grn += (char)input[i + 0];
                    grn += (char)input[i + 1];
                    grn += (char)input[i + 2];
                    grn += (char)input[i + 3];

                    if (grn == "GRN ")
                    { temp += (" - Green Beret"); }

                    ///

                    string sl2 = "";

                    sl2 += (char)input[i + 0];
                    sl2 += (char)input[i + 1];
                    sl2 += (char)input[i + 2];
                    sl2 += (char)input[i + 3];

                    if (sl2 == "SL2 ")
                    { temp += (" - Super Lode Runner II"); }

                    ///

                    string egl = "";

                    egl += (char)input[i + 0];
                    egl += (char)input[i + 1];
                    egl += (char)input[i + 2];
                    egl += (char)input[i + 3];

                    if (egl == "EGL ")
                    { temp += (" - Egger Land"); }

                    ///

                    string egs = "";

                    egs += (char)input[i + 0];
                    egs += (char)input[i + 1];
                    egs += (char)input[i + 2];
                    egs += (char)input[i + 3];

                    if (egs == "EGS ")
                    { temp += (" - Egger Land - Souzou e no Tabidachi"); }

                    ///

                    string kmar = "";

                    kmar += (char)input[i + 0];
                    kmar += (char)input[i + 1];
                    kmar += (char)input[i + 2];
                    kmar += (char)input[i + 3];

                    if (egs == "KMAR")
                    { temp += (" - Kaettekita Mario Bros."); }

                    ///

                    string vbw = "";

                    vbw += (char)input[i + 0];
                    vbw += (char)input[i + 1];
                    vbw += (char)input[i + 2];
                    vbw += (char)input[i + 3];

                    if (vbw == "VBW ")
                    { temp += (" - Volleyball"); }

                    ///

                    string mja = "";

                    mja += (char)input[i + 0];
                    mja += (char)input[i + 1];
                    mja += (char)input[i + 2];
                    mja += (char)input[i + 3];

                    if (mja == "MJA ")
                    { temp += (" - Mahjong"); }

                    ///

                    string kmv = "";

                    kmv += (char)input[i + 0];
                    kmv += (char)input[i + 1];
                    kmv += (char)input[i + 2];
                    kmv += (char)input[i + 3];

                    if (kmv == "KMV ")
                    { temp += (" - Knight Move"); }

                    ///

                    string thse = "";

                    thse += (char)input[i + 0];
                    thse += (char)input[i + 1];
                    thse += (char)input[i + 2];
                    thse += (char)input[i + 3];

                    if (thse == "THSE")
                    { temp += (" - Idol Hotline - Nakayama Miho no Tokimeki High School"); }

                    ///

                    string bre = "";

                    bre += (char)input[i + 0];
                    bre += (char)input[i + 1];
                    bre += (char)input[i + 2];
                    bre += (char)input[i + 3];

                    if (bre == "BRE ")
                    { temp += (" - Breeder"); }

                    ///

                    string ulc = "";

                    ulc += (char)input[i + 0];
                    ulc += (char)input[i + 1];
                    ulc += (char)input[i + 2];
                    ulc += (char)input[i + 3];

                    if (ulc == "ULC ")
                    { temp += (" - Ultraman Club - Chikyuu Dakkan Sakusen"); }

                    ///

                    string sg2 = "";

                    sg2 += (char)input[i + 0];
                    sg2 += (char)input[i + 1];
                    sg2 += (char)input[i + 2];
                    sg2 += (char)input[i + 3];

                    if (sg2 == "SG2 ")
                    { temp += (" - SD Gundam World - Gachapon Senshi - Scramble Wars - Map Collection"); }

                    ///

                    string esc = "";

                    esc += (char)input[i + 0];
                    esc += (char)input[i + 1];
                    esc += (char)input[i + 2];
                    esc += (char)input[i + 3];

                    if (esc == "ESC ")
                    { temp += (" - Exciting Soccer - Konami Cup"); }

                    ///

                    string nzl = "";

                    nzl += (char)input[i + 0];
                    nzl += (char)input[i + 1];
                    nzl += (char)input[i + 2];
                    nzl += (char)input[i + 3];

                    if (nzl == "NZL ")
                    { temp += (" - Nazoler Land - Soukangou"); }

                    ///

                    string knm = "";

                    knm += (char)input[i + 0];
                    knm += (char)input[i + 1];
                    knm += (char)input[i + 2];
                    knm += (char)input[i + 3];

                    if (knm == "KNM ")
                    { temp += (" - Kinnikuman - Kinnikusei Oui Soudatsusen"); }

                    ///

                    string tdre = "";

                    tdre += (char)input[i + 0];
                    tdre += (char)input[i + 1];
                    tdre += (char)input[i + 2];
                    tdre += (char)input[i + 3];

                    if (tdre == "TDRE")
                    { temp += (" - Famicom Grand Prix II - 3D Hot Rally"); }

                    ///

                    string smb = "";

                    smb += (char)input[i + 0];
                    smb += (char)input[i + 1];
                    smb += (char)input[i + 2];
                    smb += (char)input[i + 3];

                    if (smb == "SMB ")
                    { temp += (" - Super Mario Bros. 2"); }

                    ///

                    string ten = "";

                    ten += (char)input[i + 0];
                    ten += (char)input[i + 1];
                    ten += (char)input[i + 2];
                    ten += (char)input[i + 3];

                    if (ten == "TEN ")
                    { temp += (" - Tennis"); }

                    ///

                    string krn = "";

                    krn += (char)input[i + 0];
                    krn += (char)input[i + 1];
                    krn += (char)input[i + 2];
                    krn += (char)input[i + 3];

                    if (krn == "KRN ")
                    { temp += (" - Kalin no Tsurugi"); }

                    ///

                    string sma = "";

                    sma += (char)input[i + 0];
                    sma += (char)input[i + 1];
                    sma += (char)input[i + 2];
                    sma += (char)input[i + 3];

                    if (sma == "SMA ")
                    { temp += (" - Super Mario Bros."); }

                    ///

                    string kf1 = "";

                    kf1 += (char)input[i + 0];
                    kf1 += (char)input[i + 1];
                    kf1 += (char)input[i + 2];
                    kf1 += (char)input[i + 3];

                    if (kf1 == "KF1 ")
                    { temp += (" - Tantei Jinguuji Saburou - Kiken na Futari - Zenpen"); }

                    ///

                    string fyt = "";

                    fyt += (char)input[i + 0];
                    fyt += (char)input[i + 1];
                    fyt += (char)input[i + 2];
                    fyt += (char)input[i + 3];

                    if (fyt == "FYT ")
                    { temp += (" - Fairytale"); }

                    ///

                    string met = "";

                    met += (char)input[i + 0];
                    met += (char)input[i + 1];
                    met += (char)input[i + 2];
                    met += (char)input[i + 3];

                    if (met == "MET ")
                    { temp += (" - Metroid"); }

                    ///

                    string twn = "";

                    twn += (char)input[i + 0];
                    twn += (char)input[i + 1];
                    twn += (char)input[i + 2];
                    twn += (char)input[i + 3];

                    if (twn == "TWN ")
                    { temp += (" - TwinBee"); }

                    ///

                    string ssd = "";

                    ssd += (char)input[i + 0];
                    ssd += (char)input[i + 1];
                    ssd += (char)input[i + 2];
                    ssd += (char)input[i + 3];

                    if (ssd == "SSD ")
                    { temp += (" - Suishou no Dragon"); }

                    ///

                    string ebd = "";

                    ebd += (char)input[i + 0];
                    ebd += (char)input[i + 1];
                    ebd += (char)input[i + 2];
                    ebd += (char)input[i + 3];

                    if (ebd == "EBD ")
                    { temp += (" - Vs. Excitebike"); }

                    ///

                    string zel = "";

                    zel += (char)input[i + 0];
                    zel += (char)input[i + 1];
                    zel += (char)input[i + 2];
                    zel += (char)input[i + 3];

                    if (zel == "ZEL ")
                    { temp += (" - Zelda no Densetsu - The Hyrule Fantasy"); }

                    ///

                    string pro = "";

                    pro += (char)input[i + 0];
                    pro += (char)input[i + 1];
                    pro += (char)input[i + 2];
                    pro += (char)input[i + 3];

                    if (pro == "PRO ")
                    { temp += (" - Pro Wres"); }

                    ///

                    string tc1 = "";

                    tc1 += (char)input[i + 0];
                    tc1 += (char)input[i + 1];
                    tc1 += (char)input[i + 2];
                    tc1 += (char)input[i + 3];

                    if (tc1 == "TC1 ")
                    { temp += (" - Famicom Tantei Club - Kieta Koukeisha"); }

                    ///

                    string fal = "";

                    fal += (char)input[i + 0];
                    fal += (char)input[i + 1];
                    fal += (char)input[i + 2];
                    fal += (char)input[i + 3];

                    if (fal == "FAL ")
                    { temp += (" - Falsion"); }

                    ///

                    string ptm = "";

                    ptm += (char)input[i + 0];
                    ptm += (char)input[i + 1];
                    ptm += (char)input[i + 2];
                    ptm += (char)input[i + 3];

                    if (ptm == "PTM ")
                    { temp += (" - Hikari Shinwa - Palthena no Kagami"); }

                    ///

                    string ki2 = "";

                    ki2 += (char)input[i + 0];
                    ki2 += (char)input[i + 1];
                    ki2 += (char)input[i + 2];
                    ki2 += (char)input[i + 3];

                    if (ki2 == "KI2 ")
                    { temp += (" - Monitor Puzzle Kineko, The - Kinetic Connection II"); }

                    ///

                    string wad = "";

                    wad += (char)input[i + 0];
                    wad += (char)input[i + 1];
                    wad += (char)input[i + 2];
                    wad += (char)input[i + 3];

                    if (wad == "WAD ")
                    { temp += (" - Wardner no Mori"); }

                    ///

                    string tc3 = "";

                    tc3 += (char)input[i + 0];
                    tc3 += (char)input[i + 1];
                    tc3 += (char)input[i + 2];
                    tc3 += (char)input[i + 3];

                    if (tc3 == "TC3 ")
                    { temp += (" - Famicom Tantei Club Part II - Ushiro ni Tatsu Shoujo - Zenpen"); }

                    ///

                    string tc4 = "";

                    tc4 += (char)input[i + 0];
                    tc4 += (char)input[i + 1];
                    tc4 += (char)input[i + 2];
                    tc4 += (char)input[i + 3];

                    if (tc4 == "TC4 ")
                    { temp += (" - Famicom Tantei Club Part II - Ushiro ni Tatsu Shoujo - Kouhen"); }

                    ///

                    string nzb = "";

                    nzb += (char)input[i + 0];
                    nzb += (char)input[i + 1];
                    nzb += (char)input[i + 2];
                    nzb += (char)input[i + 3];

                    if (nzb == "NZB ")
                    { temp += (" - Nazoler Land - Dainigou"); }

                    ///

                    string pgp = "";

                    pgp += (char)input[i + 0];
                    pgp += (char)input[i + 1];
                    pgp += (char)input[i + 2];
                    pgp += (char)input[i + 3];

                    if (pgp == "PGP ")
                    { temp += (" - Pachinko Grand Prix"); }

                    ///

                    string bag = "";

                    bag += (char)input[i + 0];
                    bag += (char)input[i + 1];
                    bag += (char)input[i + 2];
                    bag += (char)input[i + 3];

                    if (bag == "BAG ")
                    { temp += (" - Backgammon"); }

                    ///

                    string ppn = "";

                    ppn += (char)input[i + 0];
                    ppn += (char)input[i + 1];
                    ppn += (char)input[i + 2];
                    ppn += (char)input[i + 3];

                    if (ppn == "PPN ")
                    { temp += (" - Smash Ping Pong"); }

                    ///

                    string ekb = "";

                    ekb += (char)input[i + 0];
                    ekb += (char)input[i + 1];
                    ekb += (char)input[i + 2];
                    ekb += (char)input[i + 3];

                    if (ekb == "EKB ")
                    { temp += (" - Exciting Basket"); }

                    ///

                    string gen = "";

                    gen += (char)input[i + 0];
                    gen += (char)input[i + 1];
                    gen += (char)input[i + 2];
                    gen += (char)input[i + 3];

                    if (gen == "GEN ")
                    { temp += (" - Hikaru Genji - Roller Panic"); }

                    ///

                    string ice = "";

                    ice += (char)input[i + 0];
                    ice += (char)input[i + 1];
                    ice += (char)input[i + 2];
                    ice += (char)input[i + 3];

                    if (ice == "ICE ")
                    { temp += (" - Ice Hockey"); }

                    ///

                    string psr = "";

                    psr += (char)input[i + 0];
                    psr += (char)input[i + 1];
                    psr += (char)input[i + 2];
                    psr += (char)input[i + 3];

                    if (psr == "PSR ")
                    { temp += (" - Pulsar no Hikari - Space Wars Simulation"); }

                    ///

                    string oto = "";

                    oto += (char)input[i + 0];
                    oto += (char)input[i + 1];
                    oto += (char)input[i + 2];
                    oto += (char)input[i + 3];

                    if (oto == "OTO ")
                    { temp += (" - Otocky"); }

                    ///

                    string scc = "";

                    scc += (char)input[i + 0];
                    scc += (char)input[i + 1];
                    scc += (char)input[i + 2];
                    scc += (char)input[i + 3];

                    if (scc == "SCC ")
                    { temp += (" - Soccer"); }

                    ///

                    string mdd = "";

                    mdd += (char)input[i + 0];
                    mdd += (char)input[i + 1];
                    mdd += (char)input[i + 2];
                    mdd += (char)input[i + 3];

                    if (mdd == "MDD ")
                    { temp += (" - Monty on the Run - Monty no Doki Doki Dai Dassou"); }

                    ///

                    string yok = "";

                    yok += (char)input[i + 0];
                    yok += (char)input[i + 1];
                    yok += (char)input[i + 2];
                    yok += (char)input[i + 3];

                    if (yok == "YOK ")
                    { temp += (" - Youkai Yashiki"); }

                    ///

                    string you = "";

                    you += (char)input[i + 0];
                    you += (char)input[i + 1];
                    you += (char)input[i + 2];
                    you += (char)input[i + 3];

                    if (you == "YOU ")
                    { temp += (" - Risa no Yousei Densetsu"); }

                    ///

                    string drk = "";

                    drk += (char)input[i + 0];
                    drk += (char)input[i + 1];
                    drk += (char)input[i + 2];
                    drk += (char)input[i + 3];

                    if (drk == "DRK ")
                    { temp += (" - Dracula II - Noroi no Fuuin"); }

                    ///

                    string tin = "";

                    tin += (char)input[i + 0];
                    tin += (char)input[i + 1];
                    tin += (char)input[i + 2];
                    tin += (char)input[i + 3];

                    if (tin == "TIN ")
                    { temp += (" - Moero TwinBee - Cinnamon Hakase wo Sukue!"); }

                    ///

                    string grs = "";

                    grs += (char)input[i + 0];
                    grs += (char)input[i + 1];
                    grs += (char)input[i + 2];
                    grs += (char)input[i + 3];

                    if (grs == "GRS ")
                    { temp += (" - Gyruss"); }

                    ///

                    string gal = "";

                    gal += (char)input[i + 0];
                    gal += (char)input[i + 1];
                    gal += (char)input[i + 2];
                    gal += (char)input[i + 3];

                    if (gal == "GAL ")
                    { temp += (" - Gall Force - Eternal Story"); }

                    ///

                    string drm = "";

                    drm += (char)input[i + 0];
                    drm += (char)input[i + 1];
                    drm += (char)input[i + 2];
                    drm += (char)input[i + 3];

                    if (drm == "DRM ")
                    { temp += (" - Yume Koujou Doki Doki Panic"); }

                    ///

                    string tar = "";

                    tar += (char)input[i + 0];
                    tar += (char)input[i + 1];
                    tar += (char)input[i + 2];
                    tar += (char)input[i + 3];

                    if (tar == "TAR ")
                    { temp += (" - Tarot Uranai"); }

                    ///

                    string dzn = "";

                    dzn += (char)input[i + 0];
                    dzn += (char)input[i + 1];
                    dzn += (char)input[i + 2];
                    dzn += (char)input[i + 3];

                    if (dzn == "DZN ")
                    { temp += (" - Dead Zone"); }

                    ///

                    string aka = "";

                    aka += (char)input[i + 0];
                    aka += (char)input[i + 1];
                    aka += (char)input[i + 2];
                    aka += (char)input[i + 3];

                    if (aka == "AKA ")
                    { temp += (" - Final Command - Akai Yousai"); }

                    ///

                    string pat = "";

                    pat += (char)input[i + 0];
                    pat += (char)input[i + 1];
                    pat += (char)input[i + 2];
                    pat += (char)input[i + 3];

                    if (pat == "PAT ")
                    { temp += (" - Bakutoushi Patton-kun"); }

                    ///

                    string ghf = "";

                    ghf += (char)input[i + 0];
                    ghf += (char)input[i + 1];
                    ghf += (char)input[i + 2];
                    ghf += (char)input[i + 3];

                    if (ghf == "GHF ")
                    { temp += (" - Unknown?"); }

                    ///

                    string nzc = "";

                    nzc += (char)input[i + 0];
                    nzc += (char)input[i + 1];
                    nzc += (char)input[i + 2];
                    nzc += (char)input[i + 3];

                    if (nzc == "NZC ")
                    { temp += (" - Nazoler Land - Daisangou"); }

                    ///

                    string frge = "";

                    frge += (char)input[i + 0];
                    frge += (char)input[i + 1];
                    frge += (char)input[i + 2];
                    frge += (char)input[i + 3];

                    if (frge == "FRGE")
                    { temp += (" - Famicom Grand Prix - F1 Race"); }

                    ///

                    string nsp = "";

                    nsp += (char)input[i + 0];
                    nsp += (char)input[i + 1];
                    nsp += (char)input[i + 2];
                    nsp += (char)input[i + 3];

                    if (nsp == "NSP ")
                    { temp += (" - Nazoler Land Special!! - Quiz Ou wo Sagase"); }

                    ///

                    string gku = "";

                    gku += (char)input[i + 0];
                    gku += (char)input[i + 1];
                    gku += (char)input[i + 2];
                    gku += (char)input[i + 3];

                    if (gku == "GKU ")
                    { temp += (" - Professional Mahjong Gokuu"); }

                    ///

                    string mbm = "";

                    mbm += (char)input[i + 0];
                    mbm += (char)input[i + 1];
                    mbm += (char)input[i + 2];
                    mbm += (char)input[i + 3];

                    if (mbm == "MBM ")
                    { temp += (" - Moonball Magic"); }

                    ///

                    string rjn = "";

                    rjn += (char)input[i + 0];
                    rjn += (char)input[i + 1];
                    rjn += (char)input[i + 2];
                    rjn += (char)input[i + 3];

                    if (rjn == "RJN ")
                    { temp += (" - Akuu Senki Raijin"); }

                    ///

                    string pyo = "";

                    pyo += (char)input[i + 0];
                    pyo += (char)input[i + 1];
                    pyo += (char)input[i + 2];
                    pyo += (char)input[i + 3];

                    if (pyo == "PYO ")
                    { temp += (" - Famimaga Disk Vol. 5 - Puyo Puyo"); }

                    ///

                    string nzn = "";

                    nzn += (char)input[i + 0];
                    nzn += (char)input[i + 1];
                    nzn += (char)input[i + 2];
                    nzn += (char)input[i + 3];

                    if (nzn == "NZN ")
                    { temp += (" - Nazo no Kabe - Block Kuzushi"); }

                    ///

                    string eks = "";

                    eks += (char)input[i + 0];
                    eks += (char)input[i + 1];
                    eks += (char)input[i + 2];
                    eks += (char)input[i + 3];

                    if (eks == "EKS ")
                    { temp += (" - Exciting Billiard"); }

                    ///

                    string oth = "";

                    oth += (char)input[i + 0];
                    oth += (char)input[i + 1];
                    oth += (char)input[i + 2];
                    oth += (char)input[i + 3];

                    if (oth == "OTH ")
                    { temp += (" - Othello"); }

                    ///

                    string wrd = "";

                    wrd += (char)input[i + 0];
                    wrd += (char)input[i + 1];
                    wrd += (char)input[i + 2];
                    wrd += (char)input[i + 3];

                    if (wrd == "WRD ")
                    { temp += (" - Wrecking Crew"); }

                    ///

                    string tc2 = "";

                    tc2 += (char)input[i + 0];
                    tc2 += (char)input[i + 1];
                    tc2 += (char)input[i + 2];
                    tc2 += (char)input[i + 3];

                    if (tc2 == "TC2 ")
                    { temp += (" - Famicom Tantei Club - Kieta Koukeisha - Kouhen"); }

                    ///

                    string juk = "";

                    juk += (char)input[i + 0];
                    juk += (char)input[i + 1];
                    juk += (char)input[i + 2];
                    juk += (char)input[i + 3];

                    if (juk == "JUK ")
                    { temp += (" - Tantei Jinguuji Saburou - Shinjuku Chuuou Kouen Satsujin Jiken"); }

                    ///

                    string mph = "";

                    mph += (char)input[i + 0];
                    mph += (char)input[i + 1];
                    mph += (char)input[i + 2];
                    mph += (char)input[i + 3];

                    if (mph == "MPH ")
                    { temp += (" - Magma Project - Hacker"); }

                    ///

                    string hkd = "";

                    hkd += (char)input[i + 0];
                    hkd += (char)input[i + 1];
                    hkd += (char)input[i + 2];
                    hkd += (char)input[i + 3];

                    if (hkd == "HKD ")
                    { temp += (" - Famimaga Disk Vol. 1 - Hong Kong"); }

                    ///

                    string isd = "";

                    isd += (char)input[i + 0];
                    isd += (char)input[i + 1];
                    isd += (char)input[i + 2];
                    isd += (char)input[i + 3];

                    if (isd == "ISD ")
                    { temp += (" - Ishidou"); }

                    ///

                    string bub = "";

                    bub += (char)input[i + 0];
                    bub += (char)input[i + 1];
                    bub += (char)input[i + 2];
                    bub += (char)input[i + 3];

                    if (bub == "BUB ")
                    { temp += (" - Bubble Bobble"); }

                    ///

                    string tt1 = "";

                    tt1 += (char)input[i + 0];
                    tt1 += (char)input[i + 1];
                    tt1 += (char)input[i + 2];
                    tt1 += (char)input[i + 3];

                    if (tt1 == "TT1 ")
                    { temp += (" - Time Twist - Rekishi no Katasumi de... - Zenpen"); }

                    ///

                    string scz = "";

                    scz += (char)input[i + 0];
                    scz += (char)input[i + 1];
                    scz += (char)input[i + 2];
                    scz += (char)input[i + 3];

                    if (scz == "SCZ ")
                    { temp += (" - Section-Z"); }

                    ///

                    string gfue = "";

                    gfue += (char)input[i + 0];
                    gfue += (char)input[i + 1];
                    gfue += (char)input[i + 2];
                    gfue += (char)input[i + 3];

                    if (gfue == "GFUE")
                    { temp += (" - Golf - US Course"); }

                    ///

                    string jkd = "";

                    jkd += (char)input[i + 0];
                    jkd += (char)input[i + 1];
                    jkd += (char)input[i + 2];
                    jkd += (char)input[i + 3];

                    if (jkd == "JKD ")
                    { temp += (" - Famimaga Disk Vol. 6 - Janken Disk Jou"); }

                    ///

                    string ckd = "";

                    ckd += (char)input[i + 0];
                    ckd += (char)input[i + 1];
                    ckd += (char)input[i + 2];
                    ckd += (char)input[i + 3];

                    if (ckd == "CKD ")
                    { temp += (" - Famimaga Disk Vol. 4 - Clox"); }

                    ///

                    string on1 = "";

                    on1 += (char)input[i + 0];
                    on1 += (char)input[i + 1];
                    on1 += (char)input[i + 2];
                    on1 += (char)input[i + 3];

                    if (on1 == "ON1 ")
                    { temp += (" - Famicom Mukashibanashi - Shin Onigashima - Zenpen"); }

                    ///

                    string cld = "";

                    cld += (char)input[i + 0];
                    cld += (char)input[i + 1];
                    cld += (char)input[i + 2];
                    cld += (char)input[i + 3];

                    if (cld == "CLD ")
                    { temp += (" - Clu Clu Land"); }

                    ///

                    string win = "";

                    win += (char)input[i + 0];
                    win += (char)input[i + 1];
                    win += (char)input[i + 2];
                    win += (char)input[i + 3];

                    if (win == "WIN ")
                    { temp += (" - Winter Games"); }

                    ///

                    string tds = "";

                    tds += (char)input[i + 0];
                    tds += (char)input[i + 1];
                    tds += (char)input[i + 2];
                    tds += (char)input[i + 3];

                    if (tds == "TDS ")
                    { temp += (" - Tobidase Daisakusen"); }

                    ///

                    string fmt = "";

                    fmt += (char)input[i + 0];
                    fmt += (char)input[i + 1];
                    fmt += (char)input[i + 2];
                    fmt += (char)input[i + 3];

                    if (fmt == "FMT ")
                    { temp += (" - Unknown?"); }

                    ///

                    string pnd = "";

                    pnd += (char)input[i + 0];
                    pnd += (char)input[i + 1];
                    pnd += (char)input[i + 2];
                    pnd += (char)input[i + 3];

                    if (pnd == "PND ")
                    { temp += (" - Pinball"); }

                    ///

                    string uwo = "";

                    uwo += (char)input[i + 0];
                    uwo += (char)input[i + 1];
                    uwo += (char)input[i + 2];
                    uwo += (char)input[i + 3];

                    if (uwo == "UWO!")
                    { temp += (" - Unknown?"); }

                    ///

                    string fmts = "";

                    fmts += (char)input[i + 0];
                    fmts += (char)input[i + 1];
                    fmts += (char)input[i + 2];
                    fmts += (char)input[i + 3];

                    if (fmts == "FMTS")
                    { temp += (" - Unknown?"); }

                    ///

                    string tni = "";

                    tni += (char)input[i + 0];
                    tni += (char)input[i + 1];
                    tni += (char)input[i + 2];
                    tni += (char)input[i + 3];

                    if (tni == "TNI ")
                    { temp += (" - Konamic Tennis"); }

                    ///

                    string sam = "";

                    sam += (char)input[i + 0];
                    sam += (char)input[i + 1];
                    sam += (char)input[i + 2];
                    sam += (char)input[i + 3];

                    if (sam == "SAM ")
                    { temp += (" - Fuuun Shourin Ken - Ankoku no Maou"); }

                    ///

                    string bla = "";

                    bla += (char)input[i + 0];
                    bla += (char)input[i + 1];
                    bla += (char)input[i + 2];
                    bla += (char)input[i + 3];

                    if (bla == "BLA ")
                    { temp += (" - Kamen Rider Black - Taiketsu Shadow Moon"); }

                    ///

                    string nam = "";

                    nam += (char)input[i + 0];
                    nam += (char)input[i + 1];
                    nam += (char)input[i + 2];
                    nam += (char)input[i + 3];

                    if (nam == "001 ")
                    { temp += (" - Namida no Soukoban Special"); }

                    ///

                    string asp = "";

                    asp += (char)input[i + 0];
                    asp += (char)input[i + 1];
                    asp += (char)input[i + 2];
                    asp += (char)input[i + 3];

                    if (asp == "ASP ")
                    { temp += (" - Aspic - Majaou no Noroi"); }

                    ///

                    string gxn = "";

                    gxn += (char)input[i + 0];
                    gxn += (char)input[i + 1];
                    gxn += (char)input[i + 2];
                    gxn += (char)input[i + 3];

                    if (gxn == "GXN ")
                    { temp += (" - Galaxian"); }

                    ///

                    string gag = "";

                    gag += (char)input[i + 0];
                    gag += (char)input[i + 1];
                    gag += (char)input[i + 2];
                    gag += (char)input[i + 3];

                    if (gag == "GAG ")
                    { temp += (" - Galaga"); }

                    ///

                    string ebs = "";

                    ebs += (char)input[i + 0];
                    ebs += (char)input[i + 1];
                    ebs += (char)input[i + 2];
                    ebs += (char)input[i + 3];

                    if (ebs == "EBS ")
                    { temp += (" - Exciting Baseball"); }

                    ///

                    string kom = "";

                    kom += (char)input[i + 0];
                    kom += (char)input[i + 1];
                    kom += (char)input[i + 2];
                    kom += (char)input[i + 3];

                    if (kom == "KOM ")
                    { temp += (" - Koneko Monogatari - The Adventures of Chatran"); }

                    ///

                    string bok = "";

                    bok += (char)input[i + 0];
                    bok += (char)input[i + 1];
                    bok += (char)input[i + 2];
                    bok += (char)input[i + 3];

                    if (bok == "BOK ")
                    { temp += (" - Bio Miracle Bokutte Upa"); }

                    ///

                    string gns = "";

                    gns += (char)input[i + 0];
                    gns += (char)input[i + 1];
                    gns += (char)input[i + 2];
                    gns += (char)input[i + 3];

                    if (gns == "GNS ")
                    { temp += (" - Goonies"); }

                    ///

                    string on2 = "";

                    on2 += (char)input[i + 0];
                    on2 += (char)input[i + 1];
                    on2 += (char)input[i + 2];
                    on2 += (char)input[i + 3];

                    if (on2 == "ON2 ")
                    { temp += (" - Famicom Mukashibanashi - Shin Onigashima - Kouhen"); }

                    ///

                    string ptl = "";

                    ptl += (char)input[i + 0];
                    ptl += (char)input[i + 1];
                    ptl += (char)input[i + 2];
                    ptl += (char)input[i + 3];

                    if (ptl == "PTL ")
                    { temp += (" - Patlabor - The Mobile Police - Daini Shoutai Shutsudou seyo!"); }

                    ///

                    string ul1 = "";

                    ul1 += (char)input[i + 0];
                    ul1 += (char)input[i + 1];
                    ul1 += (char)input[i + 2];
                    ul1 += (char)input[i + 3];

                    if (ul1 == "UL1 ")
                    { temp += (" - Ultraman - Kaijuu Teikoku no Gyakushuu"); }

                    ///

                    string apt = "";

                    apt += (char)input[i + 0];
                    apt += (char)input[i + 1];
                    apt += (char)input[i + 2];
                    apt += (char)input[i + 3];

                    if (apt == "APT ")
                    { temp += (" - Apple Town Monogatari - Little Computer People"); }

                    ///

                    string mjk = "";

                    mjk += (char)input[i + 0];
                    mjk += (char)input[i + 1];
                    mjk += (char)input[i + 2];
                    mjk += (char)input[i + 3];

                    if (mjk == "MJK ")
                    { temp += (" - Mahjong Kazoku"); }

                    ///

                    string dig = "";

                    dig += (char)input[i + 0];
                    dig += (char)input[i + 1];
                    dig += (char)input[i + 2];
                    dig += (char)input[i + 3];

                    if (dig == "DIG ")
                    { temp += (" - Dig Dug"); }

                    ///

                    string zan = "";

                    zan += (char)input[i + 0];
                    zan += (char)input[i + 1];
                    zan += (char)input[i + 2];
                    zan += (char)input[i + 3];

                    if (zan == "ZAN ")
                    { temp += (" - Zanac"); }

                    ///

                    string cjs = "";

                    cjs += (char)input[i + 0];
                    cjs += (char)input[i + 1];
                    cjs += (char)input[i + 2];
                    cjs += (char)input[i + 3];

                    if (cjs == "CJS ")
                    { temp += (" - Big Challenge! Juudou Senshuken"); }

                    ///

                    string bgt = "";

                    bgt += (char)input[i + 0];
                    bgt += (char)input[i + 1];
                    bgt += (char)input[i + 2];
                    bgt += (char)input[i + 3];

                    if (bgt == "BGT ")
                    { temp += (" - BurgerTime"); }

                    ///

                    string skd = "";

                    skd += (char)input[i + 0];
                    skd += (char)input[i + 1];
                    skd += (char)input[i + 2];
                    skd += (char)input[i + 3];

                    if (skd == "SKD ")
                    { temp += (" - Solomon no Kagi"); }

                    ///

                    string tpz = "";

                    tpz += (char)input[i + 0];
                    tpz += (char)input[i + 1];
                    tpz += (char)input[i + 2];
                    tpz += (char)input[i + 3];

                    if (tpz == "TPZ ")
                    { temp += (" - Topple Zip"); }

                    ///

                    string dkd = "";

                    dkd += (char)input[i + 0];
                    dkd += (char)input[i + 1];
                    dkd += (char)input[i + 2];
                    dkd += (char)input[i + 3];

                    if (dkd == "DKD ")
                    { temp += (" - Donkey Kong"); }

                    ///

                    string sho = "";

                    sho += (char)input[i + 0];
                    sho += (char)input[i + 1];
                    sho += (char)input[i + 2];
                    sho += (char)input[i + 3];

                    if (sho == "SHO ")
                    { temp += (" - Tanigawa Kouji no Shogi Shinan II"); }

                    ///

                    string kik = "";

                    kik += (char)input[i + 0];
                    kik += (char)input[i + 1];
                    kik += (char)input[i + 2];
                    kik += (char)input[i + 3];

                    if (kik == "KIK ")
                    { temp += (" - Kiki Kaikai - Dotou-hen"); }


                    Console.WriteLine(temp);    //Put the full string line on console
                    output.Add(temp);           //Put the full string line into the list of lines
                    //After that, 7 would be added to i (i += 7), to go to the next information in the data and loop until the end
                }

                //Write all the lines from the list of lines into a txt file
                File.WriteAllLines(args[0] + ".txt", output.ToArray());
            }
        }
    }
}