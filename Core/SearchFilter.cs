using System;
using System.Linq;

namespace Core
{
    public class SearchFilter
    {
        public RoomType RoomType
        {
            get;
            set;
        }

        private short[] numberOfRooms;
        public short[] NumberOfRooms
        {
            get
            {
                if (!IsNumberedRooms)
                {
                    throw new InvalidOperationException();
                }
                return numberOfRooms;
            }
            set
            {
                numberOfRooms = value.Distinct().ToArray();
            }
        }

        public bool IsNumberedRooms
        {
            get
            {
                return CheckRoomType(RoomType.Numroom);
            }
        }

        public bool CheckRoomType(RoomType type)
        {
            return RoomType.HasFlag(type);
        }

    }

    [Flags]
    public enum RoomType
    {
        None = 0,
        Bed = 1,
        Room = 2,
        Studio = 4,
        Numroom = 8,
    }
}