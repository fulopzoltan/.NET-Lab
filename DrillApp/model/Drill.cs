using System.Collections.Generic;

namespace DrillApp.model
{
    public class Drill
    {
        public List<string> IncludeComponents { get; set; }
        public string InstallationMethod { get; set; }
        public string ItemWeight { get; set; }
        public string Manufacturer { get; set; }
        public Material Material { get; set; }
        public IList<Material> Materials { get; set; }
        public string Note { get; set; }
        public string PackageDimensions { get; set; }
        public string PartNumber { get; set; }
        public string PowerSource { get; set; }
        public string Size { get; set; }
        public Speed Speed { get; set; }
        public IList<Speed> Speeds { get; set; }
        public string Torque { get; set; }
        public Usage Usage { get; set; }

        Drill()
        {
        }

        public Drill(List<string> includeComponents, string installationMethod, string itemWeight,
            string manufacturer, Material material, IList<Material> materials, string note, string packageDimensions,
            string partNumber, string powerSource, string size, Speed speed, IList<Speed> speeds, string torque,
            Usage usage)
        {
            IncludeComponents = includeComponents;
            InstallationMethod = installationMethod;
            ItemWeight = itemWeight;
            Manufacturer = manufacturer;
            Material = material;
            Materials = materials;
            Note = note;
            PackageDimensions = packageDimensions;
            PartNumber = partNumber;
            PowerSource = powerSource;
            Size = size;
            Speed = speed;
            Speeds = speeds;
            Torque = torque;
            Usage = usage;
        }
    }
    public enum Speed
    {
        Slow = 500,
        Medium = 1350,
        Fast = 1850,
    }

    public enum Material
    {
        Metal, Plastic, Titanium,
    }

}

