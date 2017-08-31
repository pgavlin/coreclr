using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _ExcepFilters_fault_fault_fault_
    {
        [Fact]
        public void _ExcepFilters_fault_fault_fault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\ExcepFilters\\fault\\fault\\fault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
