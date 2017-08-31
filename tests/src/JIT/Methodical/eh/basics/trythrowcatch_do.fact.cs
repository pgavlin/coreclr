using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trythrowcatch_do_trythrowcatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trythrowcatch_do_trythrowcatch_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trythrowcatch_do\\trythrowcatch_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
