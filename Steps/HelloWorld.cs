using WorkflowCore.Interface;
using WorkflowCore.Models;

public class HelloWorld : StepBody
{
    public override ExecutionResult Run(IStepExecutionContext context)
    {
        Console.WriteLine("Hello world" + this.GetType().AssemblyQualifiedName);
        return ExecutionResult.Next();
    }
}