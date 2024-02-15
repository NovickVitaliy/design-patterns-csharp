namespace Patterns.Creational.Builder.StepwiseBuilder;

public interface IGPUBuilder
{
    IRAMBuilder WithGPU(string gpu);
}