using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_ilist_IListIndexOf_IListIndexOf_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_ilist_IListIndexOf_IListIndexOf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\ilist\\IListIndexOf\\IListIndexOf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
