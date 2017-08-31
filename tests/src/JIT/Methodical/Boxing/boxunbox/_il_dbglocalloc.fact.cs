using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_dbglocalloc__il_dbglocalloc_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_boxunbox__il_dbglocalloc__il_dbglocalloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_dbglocalloc\\_il_dbglocalloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
