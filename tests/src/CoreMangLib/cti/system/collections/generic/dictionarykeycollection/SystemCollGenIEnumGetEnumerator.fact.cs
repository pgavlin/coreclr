using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionarykeycollection_SystemCollGenIEnumGetEnumerator_SystemCollGenIEnumGetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionarykeycollection_SystemCollGenIEnumGetEnumerator_SystemCollGenIEnumGetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionarykeycollection\\SystemCollGenIEnumGetEnumerator\\SystemCollGenIEnumGetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
