using CoreclrTestLib;
using Xunit;

namespace GC_Coverage
{
    class _delete_next_card_table_delete_next_card_table_
    {
        [OuterLoop]
        [Fact]
        public void _delete_next_card_table_delete_next_card_table_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Coverage\\delete_next_card_table\\delete_next_card_table.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
