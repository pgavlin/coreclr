using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _localloc_localloc3_cs_d_localloc3_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_localloc3_cs_d_localloc3_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\localloc\\localloc3_cs_d\\localloc3_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
