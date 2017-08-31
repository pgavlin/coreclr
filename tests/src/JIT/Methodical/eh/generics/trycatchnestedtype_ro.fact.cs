using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_generics_trycatchnestedtype_ro_trycatchnestedtype_ro_
    {
        [Fact]
        public void _eh_generics_trycatchnestedtype_ro_trycatchnestedtype_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\generics\\trycatchnestedtype_ro\\trycatchnestedtype_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
