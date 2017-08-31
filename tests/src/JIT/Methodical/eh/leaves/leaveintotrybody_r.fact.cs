using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_leaveintotrybody_r_leaveintotrybody_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_leaveintotrybody_r_leaveintotrybody_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\leaveintotrybody_r\\leaveintotrybody_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
