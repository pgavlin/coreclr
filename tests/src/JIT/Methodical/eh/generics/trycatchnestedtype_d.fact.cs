using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_generics_trycatchnestedtype_d_trycatchnestedtype_d_
    {
        [Fact]
        public void _eh_generics_trycatchnestedtype_d_trycatchnestedtype_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\generics\\trycatchnestedtype_d\\trycatchnestedtype_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
