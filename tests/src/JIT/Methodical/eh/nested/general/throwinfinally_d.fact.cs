using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_throwinfinally_d_throwinfinally_d_
    {
        [Fact]
        public void _eh_nested_general_throwinfinally_d_throwinfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\throwinfinally_d\\throwinfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
