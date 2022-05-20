using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PCStruct
    {
        public PCStruct(BitReader reader)
        {
            field0 = reader.ReadByte();
            field1 = reader.ReadUInt32();
            field2 = reader.ReadByte();
            field3 = reader.ReadUInt64();
            statPair = new StatPair(reader);
            field5 = reader.ReadUInt32();
            field6 = reader.ReadByte();
            hasfield7 = reader.ReadByte();
            if (hasfield7 == 1)
                field7 = reader.ReadBytes(12);
            field8 = new Struct7(reader);
            field9 = new Struct8(reader);
            field10 = reader.ReadByte();
            field11 = reader.ReadByte();
            field12 = reader.ReadUInt32();
            field13 = new Struct11(reader);
            field14 = new Struct12(reader);
            field15 = reader.ReadString();
            field16 = reader.ReadUInt32();
            field17 = reader.ReadUInt32();
            field18 = reader.ReadUInt32();
            PlayerId = reader.ReadUInt64();
            field20 = reader.ReadBytes(25);
            field21 = reader.ReadUInt16();
            field22 = reader.ReadBytes(5);
            field23 = new Struct13(reader);
            field24 = reader.ReadByte();
            Name = reader.ReadString();
            field26 = reader.ReadUInt32();
            field27 = reader.ReadByte();
            field28 = new Struct16(reader);
            field29 = reader.ReadByte();
            field30 = reader.ReadUInt32();
            field31 = reader.ReadUInt32();
            field32 = reader.ReadUInt64();
            field33 = reader.ReadByte();
            field34 = reader.ReadByte();
            field35 = reader.ReadUInt16();
            ClassId = reader.ReadUInt16();
            field37 = reader.ReadUInt16();
            field38 = reader.ReadUInt32();
            field39 = reader.ReadUInt16();
            field40 = reader.ReadByte();
            field41 = new Struct18(reader);
            field42 = reader.ReadUInt16();
            field43 = reader.ReadByte();
        }
        public Byte field0;
        public UInt32 field1;
        public Byte field2;
        public UInt64 field3;
        public StatPair statPair;
        public UInt32 field5;
        public Byte field6;
        public Byte hasfield7;
        public Byte[] field7;
        public Struct7 field8;
        public Struct8 field9;
        public Byte field10;
        public Byte field11;
        public UInt32 field12;
        public Struct11 field13;
        public Struct12 field14;
        public String field15;
        public UInt32 field16;
        public UInt32 field17;
        public UInt32 field18;
        public UInt64 PlayerId;
        public Byte[] field20;
        public UInt16 field21;
        public Byte[] field22;
        public Struct13 field23;
        public Byte field24;
        public String Name;
        public UInt32 field26;
        public Byte field27;
        public Struct16 field28;
        public Byte field29;
        public UInt32 field30;
        public UInt32 field31;
        public UInt64 field32;
        public Byte field33;
        public Byte field34;
        public UInt16 field35;
        public UInt16 ClassId;
        public UInt16 field37;
        public UInt32 field38;
        public UInt16 field39;
        public Byte field40;
        public Struct18 field41;
        public UInt16 field42;
        public Byte field43;
    }
}
