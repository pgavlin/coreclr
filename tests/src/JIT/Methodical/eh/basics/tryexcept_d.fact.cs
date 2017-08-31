using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryexcept_d_tryexcept_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryexcept_d_tryexcept_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryexcept_d\\tryexcept_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
