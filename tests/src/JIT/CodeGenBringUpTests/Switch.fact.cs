using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Switch_Switch_
    {
        [OuterLoop]
        [Fact]
        public void _Switch_Switch_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Switch\\Switch.cmd");
        }
    }
}
