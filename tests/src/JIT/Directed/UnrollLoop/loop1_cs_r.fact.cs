using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _UnrollLoop_loop1_cs_r_loop1_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop1_cs_r_loop1_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop1_cs_r\\loop1_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
