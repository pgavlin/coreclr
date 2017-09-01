using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _AsgXor1_AsgXor1_
    {
        [OuterLoop]
        [Fact]
        public void _AsgXor1_AsgXor1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\AsgXor1\\AsgXor1.cmd");
        }
    }
}
