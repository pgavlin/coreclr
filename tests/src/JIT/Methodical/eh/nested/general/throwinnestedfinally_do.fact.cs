using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_throwinnestedfinally_do_throwinnestedfinally_do_
    {
        [Fact]
        public void _eh_nested_general_throwinnestedfinally_do_throwinnestedfinally_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\throwinnestedfinally_do\\throwinnestedfinally_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
