using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_pow_pow0_cs_d_pow0_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow0_cs_d_pow0_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow0_cs_d\\pow0_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
