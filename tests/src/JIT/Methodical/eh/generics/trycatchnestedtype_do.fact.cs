using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_generics_trycatchnestedtype_do_trycatchnestedtype_do_
    {
        [Fact]
        public void _eh_generics_trycatchnestedtype_do_trycatchnestedtype_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\generics\\trycatchnestedtype_do\\trycatchnestedtype_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
