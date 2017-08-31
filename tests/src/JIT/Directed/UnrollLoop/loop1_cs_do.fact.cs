using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _UnrollLoop_loop1_cs_do_loop1_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop1_cs_do_loop1_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop1_cs_do\\loop1_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
