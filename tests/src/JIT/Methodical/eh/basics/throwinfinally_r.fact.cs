using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinally_r_throwinfinally_r_
    {
        [Fact]
        public void _eh_basics_throwinfinally_r_throwinfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinally_r\\throwinfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
