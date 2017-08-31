using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trycatch_r_trycatch_r_
    {
        [Fact]
        public void _eh_basics_trycatch_r_trycatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trycatch_r\\trycatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
