using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__speed_rellcs_ulong__speed_rellcs_ulong_
    {
        [Fact]
        public void _int64_arrays__speed_rellcs_ulong__speed_rellcs_ulong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_speed_rellcs_ulong\\_speed_rellcs_ulong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
