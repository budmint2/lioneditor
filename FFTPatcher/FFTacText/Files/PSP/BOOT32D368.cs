﻿/*
    Copyright 2007, Joe Davidson <joedavidson@gmail.com>

    This file is part of FFTPatcher.

    FFTPatcher is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    FFTPatcher is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with FFTPatcher.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Collections.Generic;

namespace FFTPatcher.TextEditor.Files.PSP
{
    public class BOOT32D368 : BasePSPFile
    {
        protected override int NumberOfSections
        {
            get { return 21; }
        }

        private static string[][] entryNames;
        private static Dictionary<string, long> locations;
        private static string[] sectionNames = new string[21];

        public override IList<string> SectionNames { get { return sectionNames; } }
        public override IList<IList<string>> EntryNames { get { return entryNames; } }
        public override IDictionary<string, long> Locations
        {
            get
            {
                if( locations == null )
                {
                    locations = new Dictionary<string, long>();
                    locations.Add( "BOOT.BIN", 0x32D368 );
                }
                return locations;
            }
        }

        public override int MaxLength
        {
            get { return 0x2CF5B; }
        }

        private static BOOT32D368 Instance { get; set; }


        static BOOT32D368()
        {
            Instance = new BOOT32D368( PSPResources.BOOT_32D368 );

            entryNames = new string[21][];
            for( int i = 0; i < entryNames.Length; i++ )
            {
                entryNames[i] = new string[Instance.Sections[i].Count];
            }
        }

        private BOOT32D368( IList<byte> bytes )
            : base( bytes )
        {
        }

        public static BOOT32D368 GetInstance()
        {
            return Instance;
        }
    }
}
