using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPArea_FPArea_
    {
        [OuterLoop]
        [Fact]
        public void _FPArea_FPArea_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPArea\\FPArea.cmd");
        }
    }
}
