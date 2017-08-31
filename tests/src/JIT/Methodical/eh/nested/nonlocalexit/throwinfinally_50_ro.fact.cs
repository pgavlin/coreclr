using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_nonlocalexit_throwinfinally_50_ro_throwinfinally_50_ro_
    {
        [Fact]
        public void _eh_nested_nonlocalexit_throwinfinally_50_ro_throwinfinally_50_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\nonlocalexit\\throwinfinally_50_ro\\throwinfinally_50_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
