using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionaryenumerator_DictEnumIDictEnumget_Key_DictEnumIDictEnumget_Key_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionaryenumerator_DictEnumIDictEnumget_Key_DictEnumIDictEnumget_Key_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionaryenumerator\\DictEnumIDictEnumget_Key\\DictEnumIDictEnumget_Key.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
