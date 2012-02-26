/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MCForge2_
{
    public class Block
    {
        public const byte air = (byte)0;
        public const byte rock = (byte)1;
        public const byte grass = (byte)2;
        public const byte dirt = (byte)3;
        public const byte stone = (byte)4;
        public const byte wood = (byte)5;
        public const byte shrub = (byte)6;
        public const byte blackrock = (byte)7;// adminium
        public const byte water = (byte)8;
        public const byte waterstill = (byte)9;
        public const byte lava = (byte)10;
        public const byte lavastill = (byte)11;
        public const byte sand = (byte)12;
        public const byte gravel = (byte)13;
        public const byte goldrock = (byte)14;
        public const byte ironrock = (byte)15;
        public const byte coal = (byte)16;
        public const byte trunk = (byte)17;
        public const byte leaf = (byte)18;
        public const byte sponge = (byte)19;
        public const byte glass = (byte)20;
        public const byte red = (byte)21;
        public const byte orange = (byte)22;
        public const byte yellow = (byte)23;
        public const byte lightgreen = (byte)24;
        public const byte green = (byte)25;
        public const byte aquagreen = (byte)26;
        public const byte cyan = (byte)27;
        public const byte lightblue = (byte)28;
        public const byte blue = (byte)29;
        public const byte purple = (byte)30;
        public const byte lightpurple = (byte)31;
        public const byte pink = (byte)32;
        public const byte darkpink = (byte)33;
        public const byte darkgrey = (byte)34;
        public const byte lightgrey = (byte)35;
        public const byte white = (byte)36;
        public const byte yellowflower = (byte)37;
        public const byte redflower = (byte)38;
        public const byte mushroom = (byte)39;
        public const byte redmushroom = (byte)40;
        public const byte goldsolid = (byte)41;
        public const byte iron = (byte)42;
        public const byte staircasefull = (byte)43;
        public const byte staircasestep = (byte)44;
        public const byte brick = (byte)45;
        public const byte tnt = (byte)46;
        public const byte bookcase = (byte)47;
        public const byte stonevine = (byte)48;
        public const byte obsidian = (byte)49;
        public const byte Zero = 0xff;
    }
}