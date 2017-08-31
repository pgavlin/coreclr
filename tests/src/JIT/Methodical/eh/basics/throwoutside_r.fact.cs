using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwoutside_r_throwoutside_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwoutside_r_throwoutside_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwoutside_r\\throwoutside_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
