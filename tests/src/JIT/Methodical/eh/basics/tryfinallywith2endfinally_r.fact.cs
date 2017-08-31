using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfinallywith2endfinally_r_tryfinallywith2endfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallywith2endfinally_r_tryfinallywith2endfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallywith2endfinally_r\\tryfinallywith2endfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
