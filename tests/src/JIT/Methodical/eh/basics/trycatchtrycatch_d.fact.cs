using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trycatchtrycatch_d_trycatchtrycatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trycatchtrycatch_d_trycatchtrycatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trycatchtrycatch_d\\trycatchtrycatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
