using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_general_cascadedcatch_do_cascadedcatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_general_cascadedcatch_do_cascadedcatch_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\cascadedcatch_do\\cascadedcatch_do.cmd");
        }
    }
}
