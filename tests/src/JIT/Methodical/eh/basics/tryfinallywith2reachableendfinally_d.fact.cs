using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfinallywith2reachableendfinally_d_tryfinallywith2reachableendfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallywith2reachableendfinally_d_tryfinallywith2reachableendfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallywith2reachableendfinally_d\\tryfinallywith2reachableendfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
