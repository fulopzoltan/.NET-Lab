using System;

namespace DrillApp.model;

public class Usage
{
    public bool Concrete { get; set; }
    public bool HardBrick { get; set; }
    public bool HardMaterial { get; set; }
    public bool Metal { get; set; }
    public bool ScrewDriver { get; set; }
    public bool Wood { get; set; }

    public Usage(bool concrete, bool hardBrick, bool hardMaterial, bool metal, bool screwDriver, bool wood)
    {
        Concrete = concrete;
        HardBrick = hardBrick;
        HardMaterial = hardMaterial;
        Metal = metal;
        ScrewDriver = screwDriver;
        Wood = wood;
    }
}