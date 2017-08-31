using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_generics_throwincatch_ro_throwincatch_ro_
    {
        [Fact]
        public void _eh_generics_throwincatch_ro_throwincatch_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\generics\\throwincatch_ro\\throwincatch_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
