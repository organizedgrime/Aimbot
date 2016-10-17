using MemoryManagerLib;
using System;

namespace Aimbot
{

    public class PlayerInfo {

        public int baseAddress;
        public int pointerAddress;
        public int[] baseOffsets;

        // Health, xMouse, yMouse, xPos, yPos, zPos;
        public int[] offsets;

        // in-game Data
        public int Health;
        public float xMouse, yMouse, xPos, yPos, zPos;

        public PlayerInfo(int baseAddress, int[] baseOffsets, int[] offsets)
        {
            this.baseAddress = baseAddress;
            this.baseOffsets = baseOffsets;
            this.offsets = offsets;
        }
        
        // This function reads data from the game
        public void loadData(MemoryManager Mem)
        {
            Health = Mem.ReadInt(pointerAddress + offsets[0]);
            xMouse = Mem.ReadFloat(pointerAddress + offsets[1]);
            yMouse = Mem.ReadFloat(pointerAddress + offsets[2]);
            xPos =   Mem.ReadFloat(pointerAddress + offsets[3]);
            yPos =   Mem.ReadFloat(pointerAddress + offsets[4]);
            zPos =   Mem.ReadFloat(pointerAddress + offsets[5]);
        }

        public void findPointer(MemoryManager Mem)
        {
            pointerAddress = Mem.ReadInt(baseAddress);

            foreach (int baseOffset in baseOffsets)
            {
                pointerAddress = Mem.ReadInt(pointerAddress + baseOffset);
            }
        }

        public float distanceTo(PlayerInfo player2)
        {
            return (float)(Math.Sqrt(
                ((player2.xPos - xPos) * (player2.xPos - xPos)) +
                ((player2.yPos - yPos) * (player2.yPos - yPos)) +
                ((player2.zPos - zPos) * (player2.zPos - zPos))
            ));
        }
    }
}
