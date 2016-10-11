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

        public PlayerData dataHolder;

        public PlayerInfo(int baseAddress, int[] baseOffsets, int[] offsets)
        {
            this.baseAddress = baseAddress;
            this.baseOffsets = baseOffsets;
            this.offsets = offsets;
        }
        
        public void loadData(MemoryManager Mem)
        {
            dataHolder.Health = Mem.ReadInt(pointerAddress + offsets[0]);
            dataHolder.xMouse = Mem.ReadFloat(pointerAddress + offsets[1]);
            dataHolder.yMouse = Mem.ReadFloat(pointerAddress + offsets[2]);
            dataHolder.xPos =   Mem.ReadFloat(pointerAddress + offsets[3]);
            dataHolder.yPos =   Mem.ReadFloat(pointerAddress + offsets[4]);
            dataHolder.zPos =   Mem.ReadFloat(pointerAddress + offsets[5]);
        }

        public void findPointer(MemoryManager Mem)
        {
            pointerAddress = Mem.ReadInt(baseAddress);

            foreach (int baseOffset in baseOffsets)
            {
                pointerAddress = Mem.ReadInt(pointerAddress + baseOffset);
            }
        }

    }

    public struct PlayerData {
        public int Health;
        public float xMouse, yMouse, xPos, yPos, zPos;

        public float distanceTo(PlayerData player2)
        {
            return (float)(Math.Sqrt(
                ((player2.xPos - xPos) * (player2.xPos - xPos)) +
                ((player2.yPos - yPos) * (player2.yPos - yPos)) +
                ((player2.zPos - zPos) * (player2.zPos - zPos))
            ));
        }
    }
}
