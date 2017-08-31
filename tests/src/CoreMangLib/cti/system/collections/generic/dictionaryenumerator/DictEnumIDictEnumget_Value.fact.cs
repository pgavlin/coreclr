using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionaryenumerator_DictEnumIDictEnumget_Value_DictEnumIDictEnumget_Value_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionaryenumerator_DictEnumIDictEnumget_Value_DictEnumIDictEnumget_Value_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionaryenumerator\\DictEnumIDictEnumget_Value\\DictEnumIDictEnumget_Value.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
