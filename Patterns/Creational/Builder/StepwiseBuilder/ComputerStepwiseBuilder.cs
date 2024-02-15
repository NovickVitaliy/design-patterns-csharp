using Patterns.Creational.Builder.Entity;
using Patterns.Creational.Builder.StepwiseBuilder.BuildersInterfaces;

namespace Patterns.Creational.Builder.StepwiseBuilder;

public class ComputerStepwiseBuilder
{
    public static IMotherboardBuilder CreateBuilder()
    {
        return new Builder();
    }

    private class Builder : IMotherboardBuilder, ICPUBuilder, IGPUBuilder, IRAMBuilder, IROMBuilder,
        IPowerSupplyBuilder, IComputerBuilder
    {
        private Computer _computer;

        public Builder()
        {
            _computer = new Computer();
        }
        public ICPUBuilder WithMotherboard(string name)
        {
            _computer.Motherboard = name;
            return this;
        }

        public IGPUBuilder WithCPU(string cpu)
        {
            _computer.CPU = cpu;
            return this;
        }

        public IRAMBuilder WithGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }

        public IROMBuilder WithRAM(int ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public IPowerSupplyBuilder WithROM(int rom)
        {
            _computer.ROM = rom;
            return this;
        }

        public IComputerBuilder WithPowerSupply(string powerSupply)
        {
            _computer.PowerSupply = powerSupply;
            return this;
        }

        public IComputerBuilder WithCase(string @case)
        {
            _computer.Case = @case;
            return this;
        }

        public IComputerBuilder WithKeyboard(string keyboard)
        {
            _computer.Keyboard = keyboard;
            return this;
        }

        public IComputerBuilder WithMonitor(string monitor)
        {
            _computer.Monitor = monitor;
            return this;
        }

        public IComputerBuilder WithMouse(string mouse)
        {
            _computer.Mouse = mouse;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }

        public ICPUBuilder Reset()
        {
            _computer = new Computer();
            return this;
        }
    }
}