using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfinallytrycatch_do_tryfinallytrycatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallytrycatch_do_tryfinallytrycatch_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallytrycatch_do\\tryfinallytrycatch_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
