using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionarykeycollection_SystemCollGenericICollectionAdd_SystemCollGenericICollectionAdd_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionarykeycollection_SystemCollGenericICollectionAdd_SystemCollGenericICollectionAdd_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionarykeycollection\\SystemCollGenericICollectionAdd\\SystemCollGenericICollectionAdd.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
