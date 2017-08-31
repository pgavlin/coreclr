using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_pow_pow3_cs_do_pow3_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow3_cs_do_pow3_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow3_cs_do\\pow3_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
