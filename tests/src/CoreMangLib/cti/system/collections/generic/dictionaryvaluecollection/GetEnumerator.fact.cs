using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionaryvaluecollection_GetEnumerator_GetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionaryvaluecollection_GetEnumerator_GetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionaryvaluecollection\\GetEnumerator\\GetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
