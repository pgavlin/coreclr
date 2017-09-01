using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_tryexcept_r_tryexcept_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryexcept_r_tryexcept_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryexcept_r\\tryexcept_r.cmd");
        }
    }
}
