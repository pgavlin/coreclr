using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_pow_pow3_cs_r_pow3_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow3_cs_r_pow3_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow3_cs_r\\pow3_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
