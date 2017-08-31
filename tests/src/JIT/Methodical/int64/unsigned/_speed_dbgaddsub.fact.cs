using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__speed_dbgaddsub__speed_dbgaddsub_
    {
        [Fact]
        public void _int64_unsigned__speed_dbgaddsub__speed_dbgaddsub_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_speed_dbgaddsub\\_speed_dbgaddsub.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
