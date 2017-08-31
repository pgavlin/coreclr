using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfinallywith2reachableendfinally_r_tryfinallywith2reachableendfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallywith2reachableendfinally_r_tryfinallywith2reachableendfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallywith2reachableendfinally_r\\tryfinallywith2reachableendfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
