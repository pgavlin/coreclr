using CoreclrTestLib;
using Xunit;

namespace GC_Coverage
{
    public class _delete_next_card_table_delete_next_card_table_
    {
        [OuterLoop]
        [Fact]
        public void _delete_next_card_table_delete_next_card_table_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Coverage\\delete_next_card_table\\delete_next_card_table.cmd");
        }
    }
}
