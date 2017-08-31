using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _localloc_localloc3_cs_ro_localloc3_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_localloc3_cs_ro_localloc3_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\localloc\\localloc3_cs_ro\\localloc3_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
