using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _LocallocB_N_LocallocB_N_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocB_N_LocallocB_N_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocB_N\\LocallocB_N.cmd");
        }
    }
}
