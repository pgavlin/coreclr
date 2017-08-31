using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_idictionary_IDictionaryIsFixedSize_IDictionaryIsFixedSize_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_idictionary_IDictionaryIsFixedSize_IDictionaryIsFixedSize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\idictionary\\IDictionaryIsFixedSize\\IDictionaryIsFixedSize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
