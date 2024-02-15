namespace Patterns.Creational.Builder.Entity;

public class Computer
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public string Motherboard { get; set; }
    public int RAM { get; set; }
    public int ROM { get; set; }
    public string Case { get; set; }
    public string Keyboard { get; set; }
    public string Monitor { get; set; }
    public string PowerSupply { get; set; }
    public string Mouse { get; set; }


    public override string ToString()
    {
        return $"{nameof(CPU)}: {CPU}, {nameof(GPU)}: {GPU}, {nameof(Motherboard)}: {Motherboard}, {nameof(RAM)}: {RAM}, {nameof(ROM)}: {ROM}, {nameof(Case)}: {Case}, {nameof(Keyboard)}: {Keyboard}, {nameof(Monitor)}: {Monitor}, {nameof(PowerSupply)}: {PowerSupply}, {nameof(Mouse)}: {Mouse}";
    }
}