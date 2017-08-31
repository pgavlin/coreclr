using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_tryexcept_r_tryexcept_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryexcept_r_tryexcept_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryexcept_r\\tryexcept_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
