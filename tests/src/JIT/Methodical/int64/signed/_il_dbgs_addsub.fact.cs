using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__il_dbgs_addsub__il_dbgs_addsub_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__il_dbgs_addsub__il_dbgs_addsub_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_il_dbgs_addsub\\_il_dbgs_addsub.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
