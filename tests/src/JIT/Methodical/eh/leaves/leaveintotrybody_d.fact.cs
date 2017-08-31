using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_leaveintotrybody_d_leaveintotrybody_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_leaveintotrybody_d_leaveintotrybody_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\leaveintotrybody_d\\leaveintotrybody_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
