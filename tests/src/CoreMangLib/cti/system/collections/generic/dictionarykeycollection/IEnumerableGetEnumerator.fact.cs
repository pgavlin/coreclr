using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionarykeycollection_IEnumerableGetEnumerator_IEnumerableGetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionarykeycollection_IEnumerableGetEnumerator_IEnumerableGetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionarykeycollection\\IEnumerableGetEnumerator\\IEnumerableGetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
