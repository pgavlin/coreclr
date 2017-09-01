using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _simple_fault_fault_
    {
        [OuterLoop]
        [Fact]
        public void _simple_fault_fault_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\simple\\fault\\fault.cmd");
        }
    }
}
