using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_szarrayhelper_SZArrayHelperSetItem_SZArrayHelperSetItem_
    {
        [OuterLoop]
        [Fact]
        public void _system_szarrayhelper_SZArrayHelperSetItem_SZArrayHelperSetItem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\szarrayhelper\\SZArrayHelperSetItem\\SZArrayHelperSetItem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
