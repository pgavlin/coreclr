using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_rellocalloc__il_rellocalloc_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_boxunbox__il_rellocalloc__il_rellocalloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_rellocalloc\\_il_rellocalloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
