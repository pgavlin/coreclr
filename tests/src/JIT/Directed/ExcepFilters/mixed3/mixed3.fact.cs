using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _ExcepFilters_mixed3_mixed3_mixed3_
    {
        [Fact]
        public void _ExcepFilters_mixed3_mixed3_mixed3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\ExcepFilters\\mixed3\\mixed3\\mixed3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
