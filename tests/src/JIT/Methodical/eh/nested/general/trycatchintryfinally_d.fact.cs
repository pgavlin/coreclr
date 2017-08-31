using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_trycatchintryfinally_d_trycatchintryfinally_d_
    {
        [Fact]
        public void _eh_nested_general_trycatchintryfinally_d_trycatchintryfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\trycatchintryfinally_d\\trycatchintryfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
