using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__il_rellcs_long__il_rellcs_long_
    {
        [Fact]
        public void _int64_arrays__il_rellcs_long__il_rellcs_long_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_il_rellcs_long\\_il_rellcs_long.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
