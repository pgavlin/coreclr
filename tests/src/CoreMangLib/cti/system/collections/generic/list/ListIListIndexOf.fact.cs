using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListIListIndexOf_ListIListIndexOf_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListIListIndexOf_ListIListIndexOf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListIListIndexOf\\ListIListIndexOf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
