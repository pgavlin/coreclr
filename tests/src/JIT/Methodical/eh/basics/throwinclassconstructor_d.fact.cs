using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinclassconstructor_d_throwinclassconstructor_d_
    {
        [Fact]
        public void _eh_basics_throwinclassconstructor_d_throwinclassconstructor_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinclassconstructor_d\\throwinclassconstructor_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
