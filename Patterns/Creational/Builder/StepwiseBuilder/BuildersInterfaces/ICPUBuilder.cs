using Patterns.Creational.Builder.StepwiseBuilder.BuildersInterfaces;

namespace Patterns.Creational.Builder.StepwiseBuilder;

public interface ICPUBuilder : IResetable
{
    IGPUBuilder WithCPU(string cpu);
}