using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _AsgSub1_AsgSub1_
    {
        [OuterLoop]
        [Fact]
        public void _AsgSub1_AsgSub1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\AsgSub1\\AsgSub1.cmd");
        }
    }
}
