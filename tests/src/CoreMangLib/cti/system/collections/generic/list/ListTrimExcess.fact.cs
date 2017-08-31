using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListTrimExcess_ListTrimExcess_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListTrimExcess_ListTrimExcess_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListTrimExcess\\ListTrimExcess.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
