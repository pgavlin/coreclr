using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwincatch_do_throwincatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwincatch_do_throwincatch_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwincatch_do\\throwincatch_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
