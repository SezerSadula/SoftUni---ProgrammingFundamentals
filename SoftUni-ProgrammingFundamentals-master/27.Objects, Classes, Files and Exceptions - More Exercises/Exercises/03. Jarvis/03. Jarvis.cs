using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Jarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            var robotEnergy = long.Parse(Console.ReadLine());

            var jarvis = new Robot(robotEnergy, "Jarvis");

            var line = Console.ReadLine();

            while (!"Assemble!".Equals(line))
            {
                jarvis.AddNewComponent(line);

                line = Console.ReadLine();
            }

            Console.WriteLine(jarvis);
        }
    }

    internal class Robot
    {
        public long MaxEnergy { get; set; }

        public string Name { get; set; }

        public List<Arm> Arms { get; set; }

        public List<Leg> Legs { get; set; }

        public Torso RobotTorso { get; set; }

        public Head RobotHead { get; set; }

        public Robot(long energy, string name)
        {
            MaxEnergy = energy;
            Name = name;
            Arms = new List<Arm>();
            Legs = new List<Leg>();
            RobotTorso = null;
            RobotHead = null;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (NotEnoughPower())
            {
                sb.AppendLine("We need more power!");
            }
            else if (NotEnoughParts())
            {
                sb.AppendLine("We need more parts!");
            }
            else
            {
                sb.AppendLine($"{Name}:");
                sb.AppendLine($"{RobotHead}");
                sb.AppendLine($"{RobotTorso}");

                foreach (var arm in Arms.OrderBy(a => a.EnergyConsumption))
                {
                    sb.AppendLine($"{arm}");
                }

                foreach (var leg in Legs.OrderBy(l => l.EnergyConsumption))
                {
                    sb.AppendLine($"{leg}");
                }
            }

            return sb.ToString();
        }

        private bool NotEnoughPower()
        {
            var usedEnergy = 0L;

            usedEnergy += RobotHead?.EnergyConsumption ?? 0L;
            usedEnergy += RobotTorso?.EnergyConsumption ?? 0L;
            usedEnergy += Arms.Count < 1 ? 0L : Arms[0].EnergyConsumption;
            usedEnergy += Arms.Count < 2 ? 0L : Arms[1].EnergyConsumption;
            usedEnergy += Legs.Count < 1 ? 0L : Legs[0].EnergyConsumption;
            usedEnergy += Legs.Count < 2 ? 0L : Legs[1].EnergyConsumption;

            return MaxEnergy < usedEnergy;
        }

        private bool NotEnoughParts()
        {
            return RobotHead == null || RobotTorso == null
                   || Arms[0] == null || Arms[1] == null
                   || Legs[0] == null || Legs[1] == null;
        }

        public void AddNewComponent(string component)
        {
            var type = component.Split()[0].ToLower();

            if (type == "arm")
            {
                var arm = new Arm(component);

                if (Arms.Count < 2)
                {
                    Arms.Add(arm);
                }
                else
                {
                    for (var i = 0; i < 2; i++)
                    {
                        if (Arms[i].EnergyConsumption > arm.EnergyConsumption)
                        {
                            Arms[i] = arm;
                            break;
                        }
                    }
                }
            }
            else if (type == "leg")
            {
                var leg = new Leg(component);

                if (Legs.Count < 2)
                {
                    Legs.Add(leg);
                }
                else
                {
                    for (var i = 0; i < 2; i++)
                    {
                        if (Legs[i].EnergyConsumption > leg.EnergyConsumption)
                        {
                            Legs[i] = leg;
                            break;
                        }
                    }
                }
            }
            else if (type == "head")
            {
                var head = new Head(component);

                if (RobotHead == null
                    || RobotHead.EnergyConsumption > head.EnergyConsumption)
                {
                    RobotHead = head;
                }
            }
            else if (type == "torso")
            {
                var torso = new Torso(component);

                if (RobotTorso == null
                    || RobotTorso.EnergyConsumption > torso.EnergyConsumption)
                {
                    RobotTorso = torso;
                }
            }
        }
    }

    internal class Arm
    {
        public int EnergyConsumption { get; set; }

        public int ReachDistance { get; set; }

        public int CountFingers { get; set; }

        public Arm(string parameters)
        {
            var details = parameters.Split();

            EnergyConsumption = int.Parse(details[1]);
            ReachDistance = int.Parse(details[2]);
            CountFingers = int.Parse(details[3]);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("#Arm:");
            sb.AppendLine($"###Energy consumption: {EnergyConsumption}");
            sb.AppendLine($"###Reach: {ReachDistance}");
            sb.Append($"###Fingers: {CountFingers}");

            return sb.ToString();
        }
    }

    internal class Leg
    {
        public int EnergyConsumption { get; set; }

        public int Strength { get; set; }

        public int Speed { get; set; }

        public Leg(string parameters)
        {
            var details = parameters.Split();

            EnergyConsumption = int.Parse(details[1]);
            Strength = int.Parse(details[2]);
            Speed = int.Parse(details[3]);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("#Leg:");
            sb.AppendLine($"###Energy consumption: {EnergyConsumption}");
            sb.AppendLine($"###Strength: {Strength}");
            sb.Append($"###Speed: {Speed}");

            return sb.ToString();
        }
    }

    internal class Torso
    {
        public int EnergyConsumption { get; set; }

        public double ProcessorSizeCm { get; set; }

        public string HousingMaterial { get; set; }

        public Torso(string parameters)
        {
            var details = parameters.Split();

            EnergyConsumption = int.Parse(details[1]);
            ProcessorSizeCm = double.Parse(details[2]);
            HousingMaterial = details[3];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("#Torso:");
            sb.AppendLine($"###Energy consumption: {EnergyConsumption}");
            sb.AppendLine($"###Processor size: {ProcessorSizeCm:F1}");
            sb.Append($"###Corpus material: {HousingMaterial}");

            return sb.ToString();
        }
    }

    internal class Head
    {
        public int EnergyConsumption { get; set; }

        public int Iq { get; set; }

        public string SkinMaterial { get; set; }

        public Head(string parameters)
        {
            var details = parameters.Split();

            EnergyConsumption = int.Parse(details[1]);
            Iq = int.Parse(details[2]);
            SkinMaterial = details[3];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("#Head:");
            sb.AppendLine($"###Energy consumption: {EnergyConsumption}");
            sb.AppendLine($"###IQ: {Iq}");
            sb.Append($"###Skin material: {SkinMaterial}");

            return sb.ToString();
        }
    }
}
