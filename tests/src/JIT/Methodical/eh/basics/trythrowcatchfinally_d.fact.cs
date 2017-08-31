using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trythrowcatchfinally_d_trythrowcatchfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trythrowcatchfinally_d_trythrowcatchfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trythrowcatchfinally_d\\trythrowcatchfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
