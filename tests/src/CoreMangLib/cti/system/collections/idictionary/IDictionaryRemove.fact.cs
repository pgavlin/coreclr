using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_idictionary_IDictionaryRemove_IDictionaryRemove_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_idictionary_IDictionaryRemove_IDictionaryRemove_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\idictionary\\IDictionaryRemove\\IDictionaryRemove.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
