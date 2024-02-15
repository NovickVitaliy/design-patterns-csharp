namespace Patterns.Creational.Builder.StepwiseBuilder;

public interface IROMBuilder
{
    IPowerSupplyBuilder WithROM(int rom);
}