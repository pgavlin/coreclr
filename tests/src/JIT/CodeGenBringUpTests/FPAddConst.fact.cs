using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPAddConst_FPAddConst_
    {
        [OuterLoop]
        [Fact]
        public void _FPAddConst_FPAddConst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPAddConst\\FPAddConst.cmd");
        }
    }
}
