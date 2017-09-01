using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPDiv_FPDiv_
    {
        [OuterLoop]
        [Fact]
        public void _FPDiv_FPDiv_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPDiv\\FPDiv.cmd");
        }
    }
}
