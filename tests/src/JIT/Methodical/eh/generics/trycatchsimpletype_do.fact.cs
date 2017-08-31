using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_generics_trycatchsimpletype_do_trycatchsimpletype_do_
    {
        [Fact]
        public void _eh_generics_trycatchsimpletype_do_trycatchsimpletype_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\generics\\trycatchsimpletype_do\\trycatchsimpletype_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
