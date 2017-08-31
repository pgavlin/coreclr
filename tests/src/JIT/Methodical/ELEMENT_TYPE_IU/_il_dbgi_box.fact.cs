using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_dbgi_box__il_dbgi_box_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_dbgi_box__il_dbgi_box_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_dbgi_box\\_il_dbgi_box.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
