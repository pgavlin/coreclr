using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _Le1_Le1_
    {
        [OuterLoop]
        [Fact]
        public void _Le1_Le1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Le1\\Le1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
