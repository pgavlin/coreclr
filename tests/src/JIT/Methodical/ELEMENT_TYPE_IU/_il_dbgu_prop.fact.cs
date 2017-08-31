using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_dbgu_prop__il_dbgu_prop_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_dbgu_prop__il_dbgu_prop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_dbgu_prop\\_il_dbgu_prop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
