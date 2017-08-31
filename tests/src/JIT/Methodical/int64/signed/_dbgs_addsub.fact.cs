using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__dbgs_addsub__dbgs_addsub_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__dbgs_addsub__dbgs_addsub_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_dbgs_addsub\\_dbgs_addsub.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
