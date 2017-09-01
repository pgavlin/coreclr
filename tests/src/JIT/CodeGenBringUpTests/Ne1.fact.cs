using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Ne1_Ne1_
    {
        [OuterLoop]
        [Fact]
        public void _Ne1_Ne1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Ne1\\Ne1.cmd");
        }
    }
}
