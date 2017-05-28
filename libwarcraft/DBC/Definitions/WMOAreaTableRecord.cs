//
//  WMOAreaTableRecord.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2016 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.IO;
using Warcraft.DBC.SpecialFields;

namespace Warcraft.DBC.Definitions
{
	public class WMOAreaTableRecord : DBCRecord
	{
		public const DatabaseName Database = DatabaseName.WMOAreaTable;
		
		public uint WMOID;
		public uint NameSetID;
		public uint WMOGroupID;
		public uint DayAmbienceSoundID;
		public uint NightAmbienceSoundID;
		public uint SoundProviderPref;
		public uint SoundProviderPrefUnderwater;
		public uint MIDIAmbience;
		public uint MIDIAmbienceUnderwater;
		public ForeignKey<uint> ZoneMusic;
		public uint IntroSound;
		public uint IntroPriority;
		public uint Flags;
		private LocalizedStringReference AreaName;

		/// <summary>
		/// Loads and parses the provided data.
		/// </summary>
		/// <param name="data">ExtendedData.</param>
		public override void PostLoad(byte[] data)
		{
			using (MemoryStream ms = new MemoryStream(data))
			{
				using (BinaryReader br = new BinaryReader(ms))
				{
					DeserializeSelf(br);
				}
			}
		}

		/// <summary>
		/// Deserializes the data of the object using the provided <see cref="BinaryReader"/>.
		/// </summary>
		/// <param name="reader"></param>
		public override void DeserializeSelf(BinaryReader reader)
		{
			base.DeserializeSelf(reader);
			
			throw new NotImplementedException();
		}

		public override int FieldCount => throw new System.NotImplementedException();

		public override int RecordSize => throw new System.NotImplementedException();
	}
}