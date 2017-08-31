using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _throwbox_fault_fault_
    {
        [Fact]
        public void _throwbox_fault_fault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\throwbox\\fault\\fault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
