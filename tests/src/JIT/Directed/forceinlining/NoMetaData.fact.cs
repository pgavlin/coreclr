using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _forceinlining_NoMetaData_NoMetaData_
    {
        [OuterLoop]
        [Fact]
        public void _forceinlining_NoMetaData_NoMetaData_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\NoMetaData\\NoMetaData.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
