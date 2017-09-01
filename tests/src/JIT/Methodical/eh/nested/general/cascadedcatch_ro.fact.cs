using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_nested_general_cascadedcatch_ro_cascadedcatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_general_cascadedcatch_ro_cascadedcatch_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\cascadedcatch_ro\\cascadedcatch_ro.cmd");
        }
    }
}
