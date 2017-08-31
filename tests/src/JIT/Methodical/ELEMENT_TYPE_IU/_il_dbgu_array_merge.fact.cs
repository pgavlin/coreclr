using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_dbgu_array_merge__il_dbgu_array_merge_
    {
        [Fact]
        public void _ELEMENT_TYPE_IU__il_dbgu_array_merge__il_dbgu_array_merge_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_dbgu_array_merge\\_il_dbgu_array_merge.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
