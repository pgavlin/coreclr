using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_throwinnestedfinally_ro_throwinnestedfinally_ro_
    {
        [Fact]
        public void _eh_nested_general_throwinnestedfinally_ro_throwinnestedfinally_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\throwinnestedfinally_ro\\throwinnestedfinally_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
