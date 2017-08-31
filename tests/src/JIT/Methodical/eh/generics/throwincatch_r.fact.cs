using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_generics_throwincatch_r_throwincatch_r_
    {
        [Fact]
        public void _eh_generics_throwincatch_r_throwincatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\generics\\throwincatch_r\\throwincatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
