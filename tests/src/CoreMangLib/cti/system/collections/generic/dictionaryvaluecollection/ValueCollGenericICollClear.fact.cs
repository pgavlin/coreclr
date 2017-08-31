using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionaryvaluecollection_ValueCollGenericICollClear_ValueCollGenericICollClear_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionaryvaluecollection_ValueCollGenericICollClear_ValueCollGenericICollClear_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionaryvaluecollection\\ValueCollGenericICollClear\\ValueCollGenericICollClear.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
