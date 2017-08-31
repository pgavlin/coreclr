using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryfault_r_tryfault_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfault_r_tryfault_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfault_r\\tryfault_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
