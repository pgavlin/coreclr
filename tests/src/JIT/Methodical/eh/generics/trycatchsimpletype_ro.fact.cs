using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_generics_trycatchsimpletype_ro_trycatchsimpletype_ro_
    {
        [Fact]
        public void _eh_generics_trycatchsimpletype_ro_trycatchsimpletype_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\generics\\trycatchsimpletype_ro\\trycatchsimpletype_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
