using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionarykeycollection_KeyCollectionCtor_KeyCollectionCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionarykeycollection_KeyCollectionCtor_KeyCollectionCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionarykeycollection\\KeyCollectionCtor\\KeyCollectionCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
