using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trythrowcatch_r_trythrowcatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trythrowcatch_r_trythrowcatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trythrowcatch_r\\trythrowcatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
