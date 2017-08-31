using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trycatchtrycatch_do_trycatchtrycatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trycatchtrycatch_do_trycatchtrycatch_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trycatchtrycatch_do\\trycatchtrycatch_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
