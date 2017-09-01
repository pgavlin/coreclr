using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_general_cascadedcatch_r_cascadedcatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_general_cascadedcatch_r_cascadedcatch_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\cascadedcatch_r\\cascadedcatch_r.cmd");
        }
    }
}
