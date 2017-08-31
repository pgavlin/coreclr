using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListIEnumerableGetEnumerator2_ListIEnumerableGetEnumerator2_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListIEnumerableGetEnumerator2_ListIEnumerableGetEnumerator2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListIEnumerableGetEnumerator2\\ListIEnumerableGetEnumerator2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
