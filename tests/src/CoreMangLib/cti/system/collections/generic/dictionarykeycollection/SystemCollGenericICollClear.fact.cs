using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionarykeycollection_SystemCollGenericICollClear_SystemCollGenericICollClear_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionarykeycollection_SystemCollGenericICollClear_SystemCollGenericICollClear_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionarykeycollection\\SystemCollGenericICollClear\\SystemCollGenericICollClear.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
