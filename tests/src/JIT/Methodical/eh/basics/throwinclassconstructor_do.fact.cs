using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinclassconstructor_do_throwinclassconstructor_do_
    {
        [Fact]
        public void _eh_basics_throwinclassconstructor_do_throwinclassconstructor_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinclassconstructor_do\\throwinclassconstructor_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
