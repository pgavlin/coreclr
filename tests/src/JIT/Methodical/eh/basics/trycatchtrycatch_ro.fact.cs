using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_trycatchtrycatch_ro_trycatchtrycatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trycatchtrycatch_ro_trycatchtrycatch_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trycatchtrycatch_ro\\trycatchtrycatch_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
