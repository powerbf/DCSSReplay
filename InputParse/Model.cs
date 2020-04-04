﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace InputParser
{
    public enum LayoutType
    {
        Normal,
        TextOnly,
        MapOnly
    }
    public enum ColorList2
    {
        BLACK,//0 (black if sleeping? color is background for monster list?)
        RED,//1
        GREEN,//2
        BROWN,//3 (wandering)(can hide yellow and brown)
        BLUE,//4
        MAGENTA,//5
        CYAN, //6
        LIGHTGREY,//7 if nothing nothing its black, otherwise default is 7 for lightgrey
        DARKGREY, //8
        LIGHTRED,//9
        LIGHTGREEN,//10
        YELLOW,//11
        LIGHTBLUE,//12
        LIGHTMAGENTA,//13
        LIGHTCYAN,//14
        WHITE,//15
        WHITE2 = 256
    }

    public static class Locations
    {
        public static List<string> locations = new List<string> { "Dungeon","Temple","Orcish Mines","Elven Halls","Lair","Swamp","Shoals","Snake Pit",
    "Spider Nest","Slime Pits","Vaults","Hall of Blades","Crypt","Tomb","Hell","Dis","Gehenna","Cocytus","Tartarus","Zot","Abyss","Pandemonium",
   "Ziggurat", "Bazaar","Trove","Sewer","Ossuary","Bailey","Ice Cave","Volcano","Wizlab","Depths","Desolation of Salt"};
    }
    public class ColorList
    {
        public SolidBrush BLACK = new SolidBrush(Color.FromArgb(0, 0, 0));
        public SolidBrush RED = new SolidBrush(Color.FromArgb(255, 0, 0));
        public SolidBrush GREEN = new SolidBrush(Color.FromArgb(0, 255, 0));
        public SolidBrush BROWN = new SolidBrush(Color.FromArgb(165, 91, 0));
        public SolidBrush BLUE = new SolidBrush(Color.FromArgb(0, 64, 255));
        public SolidBrush MAGENTA = new SolidBrush(Color.FromArgb(192, 0, 255));
        public SolidBrush CYAN = new SolidBrush(Color.FromArgb(0, 255, 255));
        public SolidBrush LIGHTGREY = new SolidBrush(Color.FromArgb(192, 192, 192));
        public SolidBrush DARKGREY = new SolidBrush(Color.FromArgb(128, 128, 128));
        public SolidBrush LIGHTRED = new SolidBrush(Color.FromArgb(255, 128, 128));
        public SolidBrush LIGHTGREEN = new SolidBrush(Color.FromArgb(128, 255, 128));
        public SolidBrush YELLOW = new SolidBrush(Color.FromArgb(255, 255, 0));
        public SolidBrush LIGHTBLUE = new SolidBrush(Color.FromArgb(128, 128, 255));
        public SolidBrush LIGHTMAGENTA = new SolidBrush(Color.FromArgb(255, 128, 255));
        public SolidBrush LIGHTCYAN = new SolidBrush(Color.FromArgb(64, 255, 255));
        public SolidBrush WHITE = new SolidBrush(Color.FromArgb(255, 255, 255));
        public SolidBrush WHITE2 = new SolidBrush(Color.FromArgb(255, 255, 255));

        public static Color GetColor(string name)
        {
            return name switch
            {
                "BLACK" => Color.FromArgb(0, 0, 0),
                "RED" => Color.FromArgb(255, 0, 0),
                "GREEN" => Color.FromArgb(0, 255, 0),
                "BROWN" => Color.FromArgb(165, 91, 0),
                "BLUE" => Color.FromArgb(0, 64, 255),
                "MAGENTA" => Color.FromArgb(192, 0, 255),
                "CYAN" => Color.FromArgb(0, 255, 255),
                "LIGHTGREY" => Color.FromArgb(192, 192, 192),
                "DARKGREY" => Color.FromArgb(128, 128, 128),
                "LIGHTRED" => Color.FromArgb(255, 128, 128),
                "LIGHTGREEN" => Color.FromArgb(128, 255, 128),
                "YELLOW" => Color.FromArgb(255, 255, 0),
                "LIGHTBLUE" => Color.FromArgb(128, 128, 255),
                "LIGHTMAGENTA" => Color.FromArgb(255, 128, 255),
                "LIGHTCYAN" => Color.FromArgb(64, 255, 255),
                "WHITE" => Color.FromArgb(255, 255, 255),
                _ => throw new ArgumentException($"No Color with name: {name} is defined"),
            };
        }
    }

    public class Model
    {
        public LayoutType Layout { get; set; } = LayoutType.Normal;
        public string Location { get; set; } = "Dungeon";
        public string[] TileNames { get; set; } = { " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "#BLUE", ".BLUE", ".BLUE", ".BLUE", "#BLUE", " LIGHTGREY", " LIGHTGREY", "#BLUE", ".BLUE", "!LIGHTBLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", "*BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "*BLUE", " LIGHTGREY", " LIGHTGREY", "#BLUE", "#BLUE", "#BLUE", ".BLUE", ".BLUE", ".BLUE", "#BLUE", " LIGHTGREY", " LIGHTGREY", "#BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", "*BLUE", " LIGHTGREY", "*BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", ",BLUE", ",BLUE", ",BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "#BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", "#BLUE", " LIGHTGREY", " LIGHTGREY", "#BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", " LIGHTGREY", ",BLUE", "*BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", ".BLUE", ".BLUE", "#BLUE", " LIGHTGREY", " LIGHTGREY", "#BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", "#BLUE", "#BLUE", "#BLUE", "#BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", "+BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", "rBLUE", "FBLUE", "OBLUE", ".BLUE", ".BLUE", ".BLUE", "#BLUE", "+BLUE", "#BLUE", "#BLUE", "#BLUE", "#BLUE", ".BLUE", ".BLUE", ".BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "#BLUE", ".BLUE", ".BLUE", " LIGHTGREY", " LIGHTGREY", "#BLUE", ".BLUE", ".BLUE", ".BLUE", ".LIGHTGREY", "#BLUE", "#BLUE", "#BLUE", "#BLUE", "#BLUE", "#BLUE", "#BLUE", ".BLUE", "#BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", ".BLUE", "*BLUE", " LIGHTGREY", "*BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", ".BLUE", ".BLUE", ".BLUE", ".BLUE", "#BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", "#BLUE", "+LIGHTGREY", "#BROWN", "#BROWN", "#BROWN", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "#BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", "<GREEN", ".LIGHTGREY", "#BROWN", "#BROWN", "#BROWN", "#BROWN", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", "#BROWN", " LIGHTGREY", ",BLUE", " LIGHTGREY", " LIGHTGREY", "*BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", "#BLUE", "#BLUE", "#BLUE", "#BROWN", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", "@BLACK", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", "#BROWN", "*BLUE", " LIGHTGREY", ",BLUE", " LIGHTGREY", "*BLUE", ",BLUE", " LIGHTGREY", ",BLUE", " LIGHTGREY", " LIGHTGREY", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", "+BLUE", ",BLUE", ",BLUE", "#BROWN", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", "#BROWN", "#BROWN", ".LIGHTGREY", ".LIGHTGREY", "ÃLIGHTGREY", "·LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", "#BROWN", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "*BLUE", " LIGHTGREY", " LIGHTGREY", ",BLUE", " LIGHTGREY", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", ".BLUE", " LIGHTGREY", ",BLUE", "#BROWN", ".LIGHTGREY", ".LIGHTGREY", ".BLUE", "#BLUE", "#BLUE", "<GREEN", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", "#BROWN", "*BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "*BLUE", ",BLUE", "*BLUE", "*BLUE", " LIGHTGREY", " LIGHTGREY", ".BLUE", ".BLUE", ".BLUE", ".BLUE", "âBLUE", "(CYAN", "âBLUE", ".BLUE", "âBLUE", ".BLUE", " LIGHTGREY", "#BROWN", ".LIGHTGREY", ".BLUE", ".BLUE", "#BLUE", "#BLUE", "#BROWN", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", ".LIGHTGREY", "#BROWN", "*BLUE", ",BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", ",BLUE", " LIGHTGREY", " LIGHTGREY", ".BLUE", ".BLUE", ".BLUE", "âBLUE", "#BLUE", "#BLUE", "+BLUE", "#BLUE", "#BLUE", "âBLUE", ".BLUE", "#BROWN", ".BLUE", ".BLUE", ".BLUE", "#BLUE", " LIGHTGREY", "#BLUE", "OLIGHTRED", "@GREEN", ".LIGHTGREY", "(BROWN", "#BROWN", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "*BLUE", " LIGHTGREY", " LIGHTGREY", "*BLUE", " LIGHTGREY", "#BLUE", "#BLUE", "#BLUE", "#BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "*BLUE", "#BLUE", ".BLUE", "#BLUE", ".BLUE", ".BLUE", ".BLUE", "#BLUE", " LIGHTGREY", "#BLUE", ".LIGHTGREY", "<GREEN", ".LIGHTGREY", ".LIGHTGREY", "+LIGHTGREY", " LIGHTGREY", " LIGHTGREY", ",BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", ".BLUE", "#BLUE", ".BLUE", ".BLUE", ".BLUE", "#BLUE", " LIGHTGREY", "#BLUE", ".BLUE", ".LIGHTGREY", "!LIGHTBLUE", ".LIGHTGREY", "#BROWN", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "*BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "#BLUE", ".BLUE", ".BLUE", ".BLUE", "#BLUE", " LIGHTGREY", "#BLUE", "#BLUE", "#BROWN", "#BROWN", "#BROWN", "#BROWN", "*BLUE", ",BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "*BLUE", "*BLUE", " LIGHTGREY", ",BLUE", "*BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", "*BLUE", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY", " LIGHTGREY" };
        public string[] HighlightColors { get; set; } = { "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "LIGHTGREY", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK", "BLACK" };
        public int LineLength { get; set; } = 33;
        public LogData[] LogData { get; set; } = new LogData[6] { new LogData(), new LogData(), new LogData(), new LogData(), new LogData(), new LogData() };
        public MonsterData[] MonsterData { get; set; } = new MonsterData[4] { new MonsterData(), new MonsterData(), new MonsterData(), new MonsterData() };
        public SideData SideData { get; set; } = new SideData();
        public ColorList ColorList { get; set; } = new ColorList();
    }

    public class LogData
    {
        public bool Empty { get; set; } = true;
        public string[] LogText { get; set; }//{" LIGHTGRAY, jYELLOW" ...}
        public string[] LogBackground { get; set; }//{"YELLOW",....}
        public string LogTextRaw { get; set; }// jackal

    }
    public class MonsterData
    {
        public bool Empty { get; set; } = true;
        public string[] MonsterText { get; set; }//{" LIGHTGRAY, jYELLOW" ...}
        public string MonsterTextRaw { get; set; }// jackal
        public string[] MonsterDisplay { get; set; }//{"jYELLOW",....}
        public string[] MonsterBackground { get; set; }//{"YELLOW",....}
    }
    public class SideData
    {
        public string Name { get; set; } = "Sentinel The Covered";
        public string Race { get; set; } = "Ogre of Jiyva Jeggou ******";
        public int Health { get; set; } = -320;
        public int MaxHealth { get; set; } = 320;
        public string TrueHealth { get; set; } = "(321)";
        public int Magic { get; set; } = 50;
        public int MaxMagic { get; set; } = 50;
        public string TrueMagic { get; set; } = "(100)";
        public string ArmourClass { get; set; } = "100";
        public string Evasion { get; set; } = "100";
        public string Shield { get; set; } = "100";
        public string ExperienceLevel { get; set; } = "27";
        public string NextLevel { get; set; } = "-130%";
        public string Weapon { get; set; } = "a) +4 demon trident \"Embalmer\" {pierce, *Corrode Dex+3 SInv Int+10}";
        public string Quiver { get; set; } = "b) +4 demon trident \"Embalmer\" {pierce, *Corrode Dex+3 SInv Int+10}";
        public string Strength { get; set; } = "9999";
        public string Dexterity { get; set; } = "9999";
        public string Inteligence { get; set; } = "9999";
        public string Place { get; set; } = "Dungeon:1";
        public string Time { get; set; } = "9999999 (25.0)";
        public string Statuses1 { get; set; } = "Slow Agi Might Haste Para";
        public string Statuses2 { get; set; } = "Tree -Tele ";

    };


}
