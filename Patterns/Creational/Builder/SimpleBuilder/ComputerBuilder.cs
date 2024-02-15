using Patterns.Creational.Builder.Entity;

namespace Patterns.Creational.Builder.SimpleBuilder;

public class ComputerBuilder
{
    private Computer _computer;

    public ComputerBuilder()
    {
        _computer = new Computer();
    }

    public ComputerBuilder Reset()
    {
        _computer = new Computer();
        return this;
    }

    public ComputerBuilder WithMotherboard(string motherboard)
    {
        _computer.Motherboard = motherboard;
        return this;
    }


    public ComputerBuilder WithCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder WithGPU(string gpu)
    {
        _computer.GPU = gpu;
        return this;
    }

    public ComputerBuilder WithRAM(int ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public ComputerBuilder WithROM(int rom)
    {
        _computer.ROM = rom;
        return this;
    }

    public ComputerBuilder WithCase(string @case)
    {
        _computer.Case = @case;
        return this;
    }

    public ComputerBuilder WithKeyboard(string keyboard)
    {
        _computer.Keyboard = keyboard;
        return this;
    }

    public ComputerBuilder WithMonitor(string monitor)
    {
        _computer.Monitor = monitor;
        return this;
    }

    public ComputerBuilder WithPowerSupply(string powerSupply)
    {
        _computer.PowerSupply = powerSupply;
        return this;
    }

    public ComputerBuilder WithMouse(string mouse)
    {
        _computer.Mouse = mouse;
        return this;
    }

    public Computer Build()
    {
        var pc = _computer;
        Reset();
        return pc;
    }
}