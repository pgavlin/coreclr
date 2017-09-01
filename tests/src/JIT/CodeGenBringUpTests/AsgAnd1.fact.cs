using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _AsgAnd1_AsgAnd1_
    {
        [OuterLoop]
        [Fact]
        public void _AsgAnd1_AsgAnd1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\AsgAnd1\\AsgAnd1.cmd");
        }
    }
}
