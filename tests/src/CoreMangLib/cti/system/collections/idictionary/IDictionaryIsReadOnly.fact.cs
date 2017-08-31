using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_idictionary_IDictionaryIsReadOnly_IDictionaryIsReadOnly_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_idictionary_IDictionaryIsReadOnly_IDictionaryIsReadOnly_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\idictionary\\IDictionaryIsReadOnly\\IDictionaryIsReadOnly.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
