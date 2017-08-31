using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _StructFldAddr_StructFldAddr_
    {
        [OuterLoop]
        [Fact]
        public void _StructFldAddr_StructFldAddr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\StructFldAddr\\StructFldAddr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
