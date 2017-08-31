using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__il_dbgaddsub__il_dbgaddsub_
    {
        [Fact]
        public void _int64_unsigned__il_dbgaddsub__il_dbgaddsub_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_il_dbgaddsub\\_il_dbgaddsub.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
