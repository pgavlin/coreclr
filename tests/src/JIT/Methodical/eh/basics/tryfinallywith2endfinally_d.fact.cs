using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfinallywith2endfinally_d_tryfinallywith2endfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallywith2endfinally_d_tryfinallywith2endfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallywith2endfinally_d\\tryfinallywith2endfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
