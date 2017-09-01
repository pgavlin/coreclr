using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _ModConst_ModConst_
    {
        [Fact]
        public void _ModConst_ModConst_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ModConst\\ModConst.cmd");
        }
    }
}
