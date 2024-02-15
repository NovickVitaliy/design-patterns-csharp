using Patterns.Creational.Builder.StepwiseBuilder.BuildersInterfaces;

namespace Patterns.Creational.Builder.StepwiseBuilder;

public interface IPowerSupplyBuilder
{
    IComputerBuilder WithPowerSupply(string powerSupply);
}