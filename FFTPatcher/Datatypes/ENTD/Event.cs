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

using System;
using System.Collections.Generic;

namespace FFTPatcher.Datatypes
{
    /// <summary>
    /// Represents an Event in the game
    /// </summary>
    public class Event : IEquatable<Event>
    {
        private static string[] pspEventNames;
        private static string[] psxEventNames;
        public static string[] EventNames
        {
            get { return FFTPatch.Context == Context.US_PSP ? pspEventNames : psxEventNames; }
        }

        public EventUnit[] Units { get; private set; }
        public int Value { get; private set; }
        public Event Default { get; private set; }
        public string Name { get; private set; }

        static Event()
        {
            pspEventNames = Utilities.GetStringsFromNumberedXmlNodes(
                Resources.EventNames,
                "/Events/Event[@value='{0:X3}']/@name",
                0x200 + 77 );
            psxEventNames = Utilities.GetStringsFromNumberedXmlNodes(
                PSXResources.EventNames,
                "/Events/Event[@value='{0:X3}']/@name",
                0x200 );
        }

        public Event( int value, SubArray<byte> bytes, Event defaults )
        {
            Value = value;
            Name = EventNames[value];
            Default = defaults;
            Units = new EventUnit[16];
            for( int i = 0; i < 16; i++ )
            {
                Units[i] = new EventUnit( 
                    new SubArray<byte>( bytes, i * 40, (i + 1) * 40 - 1 ), 
                      defaults == null ? null : defaults.Units[i] );
            }
        }

        public byte[] ToByteArray()
        {
            List<byte> result = new List<byte>( 16 * 40 );
            foreach( EventUnit unit in Units )
            {
                result.AddRange( unit.ToByteArray() );
            }

            return result.ToArray();
        }

        public override string ToString()
        {
            return string.Format( "{0:X3} {1}", Value, Name );
        }

        public bool Equals( Event other )
        {
            for( int i = 0; i < Units.Length; i++ )
            {
                if( !other.Units[i].Equals( Units[i] ) )
                    return false;
            }

            return true;
        }
    }
}
