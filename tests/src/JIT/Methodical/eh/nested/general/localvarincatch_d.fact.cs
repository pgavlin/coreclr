using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_localvarincatch_d_localvarincatch_d_
    {
        [Fact]
        public void _eh_nested_general_localvarincatch_d_localvarincatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\localvarincatch_d\\localvarincatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
