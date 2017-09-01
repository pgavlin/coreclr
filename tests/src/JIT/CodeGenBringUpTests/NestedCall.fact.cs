using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _NestedCall_NestedCall_
    {
        [OuterLoop]
        [Fact]
        public void _NestedCall_NestedCall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\NestedCall\\NestedCall.cmd");
        }
    }
}
