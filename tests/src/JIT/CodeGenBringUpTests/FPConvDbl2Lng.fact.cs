using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _FPConvDbl2Lng_FPConvDbl2Lng_
    {
        [OuterLoop]
        [Fact]
        public void _FPConvDbl2Lng_FPConvDbl2Lng_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPConvDbl2Lng\\FPConvDbl2Lng.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
