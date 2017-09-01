using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPSubConst_FPSubConst_
    {
        [OuterLoop]
        [Fact]
        public void _FPSubConst_FPSubConst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPSubConst\\FPSubConst.cmd");
        }
    }
}
