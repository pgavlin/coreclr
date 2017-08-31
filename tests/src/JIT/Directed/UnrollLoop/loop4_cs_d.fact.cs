using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _UnrollLoop_loop4_cs_d_loop4_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop4_cs_d_loop4_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop4_cs_d\\loop4_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
