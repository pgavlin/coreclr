using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__speed_rellcs_long__speed_rellcs_long_
    {
        [Fact]
        public void _int64_arrays__speed_rellcs_long__speed_rellcs_long_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_speed_rellcs_long\\_speed_rellcs_long.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
