using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB.MainParts;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB
{
    public class MotherBoard
    {
        private CPU cpu;
        private RAM ram;
        private GPU gpu;
        private Sockets sockets;
        private NetworkCard networkCard;
        private Disk disk;

        public MotherBoard(CPU cpu, RAM ram, GPU gpu, Sockets sockets, NetworkCard networkCard, Disk disk)
        {
            this.cpu = cpu;
            this.ram = ram;
            this.gpu = gpu;
            this.sockets = sockets;
            this.networkCard = networkCard;
            this.disk = disk;
        }

        public CPU GetCpu()
        {
            return cpu;
        }

        public RAM GetRam()
        {
            return ram;
        }

        public GPU GetGpu()
        {
            return gpu;
        }

        public Sockets GetSockets()
        {
            return sockets;
        }

        public NetworkCard GetNetworkCard()
        {
            return networkCard;
        }

        public Disk GetDisk()
        {
            return disk;
        }
    }
}
