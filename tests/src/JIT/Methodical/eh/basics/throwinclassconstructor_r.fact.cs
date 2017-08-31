using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinclassconstructor_r_throwinclassconstructor_r_
    {
        [Fact]
        public void _eh_basics_throwinclassconstructor_r_throwinclassconstructor_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinclassconstructor_r\\throwinclassconstructor_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
