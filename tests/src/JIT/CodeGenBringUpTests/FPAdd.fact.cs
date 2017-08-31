using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _FPAdd_FPAdd_
    {
        [OuterLoop]
        [Fact]
        public void _FPAdd_FPAdd_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPAdd\\FPAdd.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
