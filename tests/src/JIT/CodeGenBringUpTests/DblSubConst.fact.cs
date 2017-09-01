using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblSubConst_DblSubConst_
    {
        [OuterLoop]
        [Fact]
        public void _DblSubConst_DblSubConst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblSubConst\\DblSubConst.cmd");
        }
    }
}
