using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinally_50_d_throwinfinally_50_d_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinally_50_d_throwinfinally_50_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinally_50_d\\throwinfinally_50_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
