using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_generics_trycatchnestedtype_r_trycatchnestedtype_r_
    {
        [Fact]
        public void _eh_generics_trycatchnestedtype_r_trycatchnestedtype_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\generics\\trycatchnestedtype_r\\trycatchnestedtype_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
