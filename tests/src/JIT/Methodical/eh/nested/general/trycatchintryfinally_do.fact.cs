using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_trycatchintryfinally_do_trycatchintryfinally_do_
    {
        [Fact]
        public void _eh_nested_general_trycatchintryfinally_do_trycatchintryfinally_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\trycatchintryfinally_do\\trycatchintryfinally_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
