using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_pow_pow2_cs_do_pow2_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow2_cs_do_pow2_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow2_cs_do\\pow2_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
