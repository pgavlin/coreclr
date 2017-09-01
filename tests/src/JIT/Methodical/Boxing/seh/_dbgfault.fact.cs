using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Boxing_seh__dbgfault__dbgfault_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_seh__dbgfault__dbgfault_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\seh\\_dbgfault\\_dbgfault.cmd");
        }
    }
}
