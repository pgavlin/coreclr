using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfinallytryfinally_do_tryfinallytryfinally_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallytryfinally_do_tryfinallytryfinally_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallytryfinally_do\\tryfinallytryfinally_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
