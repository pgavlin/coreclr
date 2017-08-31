using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_list_ListICollectionIsSynchronized_ListICollectionIsSynchronized_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_list_ListICollectionIsSynchronized_ListICollectionIsSynchronized_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\list\\ListICollectionIsSynchronized\\ListICollectionIsSynchronized.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
