using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trycatch_do_trycatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trycatch_do_trycatch_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trycatch_do\\trycatch_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
