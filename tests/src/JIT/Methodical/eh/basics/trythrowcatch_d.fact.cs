using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trythrowcatch_d_trythrowcatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trythrowcatch_d_trythrowcatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trythrowcatch_d\\trythrowcatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
