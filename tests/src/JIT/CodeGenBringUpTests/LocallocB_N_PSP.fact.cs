using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _LocallocB_N_PSP_LocallocB_N_PSP_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocB_N_PSP_LocallocB_N_PSP_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocB_N_PSP\\LocallocB_N_PSP.cmd");
        }
    }
}
