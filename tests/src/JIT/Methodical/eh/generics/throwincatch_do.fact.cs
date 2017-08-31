using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_generics_throwincatch_do_throwincatch_do_
    {
        [Fact]
        public void _eh_generics_throwincatch_do_throwincatch_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\generics\\throwincatch_do\\throwincatch_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
