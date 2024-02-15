namespace Patterns.Creational.Builder.StepwiseBuilder;

public interface IMotherboardBuilder
{
    ICPUBuilder WithMotherboard(string name);
}