using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _AsgAdd1_AsgAdd1_
    {
        [OuterLoop]
        [Fact]
        public void _AsgAdd1_AsgAdd1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\AsgAdd1\\AsgAdd1.cmd");
        }
    }
}
