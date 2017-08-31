using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__rellcs_long__rellcs_long_
    {
        [OuterLoop]
        [Fact]
        public void _int64_arrays__rellcs_long__rellcs_long_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_rellcs_long\\_rellcs_long.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
