using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _UnrollLoop_loop1_cs_ro_loop1_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop1_cs_ro_loop1_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop1_cs_ro\\loop1_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
