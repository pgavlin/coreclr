using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _BinaryRMW_BinaryRMW_
    {
        [OuterLoop]
        [Fact]
        public void _BinaryRMW_BinaryRMW_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\BinaryRMW\\BinaryRMW.cmd");
        }
    }
}
