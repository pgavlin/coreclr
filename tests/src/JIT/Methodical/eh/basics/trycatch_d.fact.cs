using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trycatch_d_trycatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trycatch_d_trycatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trycatch_d\\trycatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
