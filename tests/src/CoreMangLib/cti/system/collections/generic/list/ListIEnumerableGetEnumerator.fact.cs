using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListIEnumerableGetEnumerator_ListIEnumerableGetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListIEnumerableGetEnumerator_ListIEnumerableGetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListIEnumerableGetEnumerator\\ListIEnumerableGetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
