using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_ilist_IListRemoveAt_IListRemoveAt_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_ilist_IListRemoveAt_IListRemoveAt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\ilist\\IListRemoveAt\\IListRemoveAt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
