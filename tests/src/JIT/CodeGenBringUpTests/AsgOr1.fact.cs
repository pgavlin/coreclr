using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _AsgOr1_AsgOr1_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOr1_AsgOr1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\AsgOr1\\AsgOr1.cmd");
        }
    }
}
