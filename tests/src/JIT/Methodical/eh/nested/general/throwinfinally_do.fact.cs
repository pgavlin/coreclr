using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_throwinfinally_do_throwinfinally_do_
    {
        [Fact]
        public void _eh_nested_general_throwinfinally_do_throwinfinally_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\throwinfinally_do\\throwinfinally_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
