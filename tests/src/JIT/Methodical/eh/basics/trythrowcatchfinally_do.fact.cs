using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trythrowcatchfinally_do_trythrowcatchfinally_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trythrowcatchfinally_do_trythrowcatchfinally_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trythrowcatchfinally_do\\trythrowcatchfinally_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
