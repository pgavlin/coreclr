using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinally_50_r_throwinfinally_50_r_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinally_50_r_throwinfinally_50_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinally_50_r\\throwinfinally_50_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
