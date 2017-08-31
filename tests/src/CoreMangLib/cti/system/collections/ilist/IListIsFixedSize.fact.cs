using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_ilist_IListIsFixedSize_IListIsFixedSize_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_ilist_IListIsFixedSize_IListIsFixedSize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\ilist\\IListIsFixedSize\\IListIsFixedSize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
