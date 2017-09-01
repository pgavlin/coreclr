using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _StructFldAddr_StructFldAddr_
    {
        [OuterLoop]
        [Fact]
        public void _StructFldAddr_StructFldAddr_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\StructFldAddr\\StructFldAddr.cmd");
        }
    }
}
