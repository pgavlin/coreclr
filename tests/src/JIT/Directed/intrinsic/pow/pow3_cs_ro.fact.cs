using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_pow_pow3_cs_ro_pow3_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow3_cs_ro_pow3_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow3_cs_ro\\pow3_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
