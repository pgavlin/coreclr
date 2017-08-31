using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinclassconstructor_ro_throwinclassconstructor_ro_
    {
        [Fact]
        public void _eh_basics_throwinclassconstructor_ro_throwinclassconstructor_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinclassconstructor_ro\\throwinclassconstructor_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
