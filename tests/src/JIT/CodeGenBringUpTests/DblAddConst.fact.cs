using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblAddConst_DblAddConst_
    {
        [OuterLoop]
        [Fact]
        public void _DblAddConst_DblAddConst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblAddConst\\DblAddConst.cmd");
        }
    }
}
