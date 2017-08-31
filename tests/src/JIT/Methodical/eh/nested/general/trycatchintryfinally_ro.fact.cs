using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_trycatchintryfinally_ro_trycatchintryfinally_ro_
    {
        [Fact]
        public void _eh_nested_general_trycatchintryfinally_ro_trycatchintryfinally_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\trycatchintryfinally_ro\\trycatchintryfinally_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
