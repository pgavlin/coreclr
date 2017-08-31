using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _simple_fault_fault_
    {
        [OuterLoop]
        [Fact]
        public void _simple_fault_fault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\simple\\fault\\fault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
