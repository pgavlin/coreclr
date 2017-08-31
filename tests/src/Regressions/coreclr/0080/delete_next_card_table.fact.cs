using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0080_delete_next_card_table_delete_next_card_table_
    {
        [OuterLoop]
        [Fact]
        public void _0080_delete_next_card_table_delete_next_card_table_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0080\\delete_next_card_table\\delete_next_card_table.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
