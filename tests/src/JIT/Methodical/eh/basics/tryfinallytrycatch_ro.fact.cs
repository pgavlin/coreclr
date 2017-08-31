using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfinallytrycatch_ro_tryfinallytrycatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallytrycatch_ro_tryfinallytrycatch_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallytrycatch_ro\\tryfinallytrycatch_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
