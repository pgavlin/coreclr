using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trythrowcatchfinally_ro_trythrowcatchfinally_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trythrowcatchfinally_ro_trythrowcatchfinally_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trythrowcatchfinally_ro\\trythrowcatchfinally_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
