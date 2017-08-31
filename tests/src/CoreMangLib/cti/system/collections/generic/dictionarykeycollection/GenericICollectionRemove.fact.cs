using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionarykeycollection_GenericICollectionRemove_GenericICollectionRemove_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionarykeycollection_GenericICollectionRemove_GenericICollectionRemove_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionarykeycollection\\GenericICollectionRemove\\GenericICollectionRemove.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
