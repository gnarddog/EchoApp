using System;
using System; using System.Collections.Generic;

namespace Echo
{
    public static class Options
    {
        public static string numberofplayers;
        public static string difficulty;
        public static string imgdif { get; set; }
        public static string easydif = "/Images/singlestar.png";
        public static string mediumdif = "/Images/twostars.png";
        public static string harddif = "/Images/threestars.png";
    }

    public class ImgDif     {         public string ImgSource { get; set; }     } }
