using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_tryfault_d_tryfault_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfault_d_tryfault_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfault_d\\tryfault_d.cmd");
        }
    }
}
