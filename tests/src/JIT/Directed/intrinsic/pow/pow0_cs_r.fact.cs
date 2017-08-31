using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_pow_pow0_cs_r_pow0_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow0_cs_r_pow0_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow0_cs_r\\pow0_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
