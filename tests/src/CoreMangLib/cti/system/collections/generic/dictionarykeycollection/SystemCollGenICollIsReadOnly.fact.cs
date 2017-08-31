using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionarykeycollection_SystemCollGenICollIsReadOnly_SystemCollGenICollIsReadOnly_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionarykeycollection_SystemCollGenICollIsReadOnly_SystemCollGenICollIsReadOnly_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionarykeycollection\\SystemCollGenICollIsReadOnly\\SystemCollGenICollIsReadOnly.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
