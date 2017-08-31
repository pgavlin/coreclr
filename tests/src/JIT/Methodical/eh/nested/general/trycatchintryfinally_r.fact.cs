using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_trycatchintryfinally_r_trycatchintryfinally_r_
    {
        [Fact]
        public void _eh_nested_general_trycatchintryfinally_r_trycatchintryfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\trycatchintryfinally_r\\trycatchintryfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
