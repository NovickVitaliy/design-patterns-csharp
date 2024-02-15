using Patterns.Creational.Builder.Entity;

namespace Patterns.Creational.Builder.StepwiseBuilder.BuildersInterfaces;

public interface IComputerBuilder
{
    IComputerBuilder WithCase(string @case);
    IComputerBuilder WithKeyboard(string keyboard);
    IComputerBuilder WithMonitor(string monitor);
    IComputerBuilder WithMouse(string mouse);
    Computer Build();
}