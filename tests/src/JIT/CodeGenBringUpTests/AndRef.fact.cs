using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _AndRef_AndRef_
    {
        [OuterLoop]
        [Fact]
        public void _AndRef_AndRef_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\AndRef\\AndRef.cmd");
        }
    }
}
