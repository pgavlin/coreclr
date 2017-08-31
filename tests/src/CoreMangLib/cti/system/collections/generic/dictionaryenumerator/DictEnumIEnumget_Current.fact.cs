using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_dictionaryenumerator_DictEnumIEnumget_Current_DictEnumIEnumget_Current_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_dictionaryenumerator_DictEnumIEnumget_Current_DictEnumIEnumget_Current_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\dictionaryenumerator\\DictEnumIEnumget_Current\\DictEnumIEnumget_Current.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
