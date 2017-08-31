using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _DblAdd_DblAdd_
    {
        [OuterLoop]
        [Fact]
        public void _DblAdd_DblAdd_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblAdd\\DblAdd.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
