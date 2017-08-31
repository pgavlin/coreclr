using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _localloc_zeroinit_zeroinit01_small_zeroinit01_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_zeroinit_zeroinit01_small_zeroinit01_small_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\localloc\\zeroinit\\zeroinit01_small\\zeroinit01_small.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
