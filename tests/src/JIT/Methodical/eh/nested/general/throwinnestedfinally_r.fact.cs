using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_throwinnestedfinally_r_throwinnestedfinally_r_
    {
        [Fact]
        public void _eh_nested_general_throwinnestedfinally_r_throwinnestedfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\throwinnestedfinally_r\\throwinnestedfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
