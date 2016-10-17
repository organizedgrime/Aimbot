using MemoryManagerLib;
using System;

namespace Aimbot
{
    public class PlayerInfo
    {
        // Int for the base address, where the first pointer is found
        public int baseAddress;

        // Int for the final address, where all offsets will applied
        public int pointerAddress;

        // Array of memory offsets for each value in memory
        public int[] baseOffsets;

        // Array of memory offsets to the addresses actually containing data
        // Health, xMouse, yMouse, xPos, yPos, zPos
        public int[] offsets;

        // Int for health, because reading in data from a byte array as a float doesn't work here
        public int health;

        // Float array for in-game Data
        // xMouse, yMouse, xPos, yPos, zPos
        public float[] data = new float[5];

        public PlayerInfo(int baseAddress, int[] baseOffsets, int[] offsets)
        {
            this.baseAddress = baseAddress;
            this.baseOffsets = baseOffsets;
            this.offsets = offsets;
        }
        
        // This function reads data from the game
        public void loadData(MemoryManager Mem)
        {
            health = Mem.ReadInt(pointerAddress + offsets[0]);
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = Mem.ReadFloat(pointerAddress + offsets[i+1]);
            }
        }

        // This function, knowing the base offsets, will find the actual current memory address in the computer memory
        public void findPointer(MemoryManager Mem)
        {
            pointerAddress = Mem.ReadInt(baseAddress);

            foreach (int baseOffset in baseOffsets)
            {
                pointerAddress = Mem.ReadInt(pointerAddress + baseOffset);
            }
        }

        // This function uses the 3D distance formula to determine distance between two players
        public float distanceTo(PlayerInfo player2)
        {
            return (float)(Math.Sqrt(
                ((player2.data[2] - data[2]) * (player2.data[2] - data[2])) +
                ((player2.data[3] - data[3]) * (player2.data[3] - data[3])) +
                ((player2.data[4] - data[4]) * (player2.data[4] - data[4]))
            ));
        }
    }
}
