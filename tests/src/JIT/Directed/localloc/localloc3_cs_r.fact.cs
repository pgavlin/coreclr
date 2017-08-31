using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _localloc_localloc3_cs_r_localloc3_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_localloc3_cs_r_localloc3_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\localloc\\localloc3_cs_r\\localloc3_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
