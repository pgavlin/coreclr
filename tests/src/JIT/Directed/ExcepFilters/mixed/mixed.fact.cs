using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _ExcepFilters_mixed_mixed_mixed_
    {
        [OuterLoop]
        [Fact]
        public void _ExcepFilters_mixed_mixed_mixed_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\ExcepFilters\\mixed\\mixed\\mixed.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
