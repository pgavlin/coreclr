using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _divref_divref_
    {
        [OuterLoop]
        [Fact]
        public void _divref_divref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\divref\\divref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
